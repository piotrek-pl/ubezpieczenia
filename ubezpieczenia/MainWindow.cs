using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ubezpieczenia
{
    public partial class MainWindow : Form
    {
        enum Item
        {
            Client,
            Agent
        }

        Item activeItem;
        int idToDelete;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["loginWindow"].Close();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            agentEmploymentDateTextBox_SetText();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = dataGridView.ColumnHeadersDefaultCellStyle.BackColor;
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addAgentPanel.Visible = false;
            searchPanel.Visible = false;
            addClientPanel.Visible = true;
            pictureBoxMainWindow.Visible = false;
        }

        private bool IsConnectionOpen(OracleConnection connection)
        {
            return connection.State == ConnectionState.Open;
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            string addClientSqlCommand = "INSERT INTO KLIENCI (KLIENT_ID, IMIE, NAZWISKO, ULICA_NR, KOD_POCZTOWY, MIEJSCOWOSC, TELEFON, EMAIL) " +
                                         "VALUES (KLIENCI_SEQ.nextval, :Imie, :Nazwisko, :Ulica, :KodPocztowy, :Miejscowosc, :Telefon, :Email)";

            using (OracleCommand command = new OracleCommand(addClientSqlCommand, LoginWindow.connection))
            {
                command.Parameters.Add(":Imie", OracleDbType.Varchar2).Value = clientFirstNameTextBox.Text;
                command.Parameters.Add(":Nazwisko", OracleDbType.Varchar2).Value = clientSurnameTextBox.Text;
                command.Parameters.Add(":Ulica", OracleDbType.Varchar2).Value = clientStreetTextBox.Text;
                command.Parameters.Add(":KodPocztowy", OracleDbType.Varchar2).Value = clientPostcodeTextBox.Text;
                command.Parameters.Add(":Miejscowosc", OracleDbType.Varchar2).Value = clientTownTextBox.Text;
                command.Parameters.Add(":Telefon", OracleDbType.Varchar2).Value = clientPhoneTextBox.Text;
                command.Parameters.Add(":Email", OracleDbType.Varchar2).Value = clientEmailTextBox.Text;

                try
                {
                    int rowsInserted = command.ExecuteNonQuery();

                    if (rowsInserted > 0)
                    {
                        MessageBox.Show("Pomyślnie dodano klienta");
                        clearClientTextBoxes();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearClientTextBoxes()
        {
            clientEmailTextBox.Text = "";
            clientFirstNameTextBox.Text = "";
            clientPhoneTextBox.Text = "";
            clientPostcodeTextBox.Text = "";
            clientStreetTextBox.Text = "";
            clientSurnameTextBox.Text = "";
            clientTownTextBox.Text = "";
        }

        private void addAgentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addClientPanel.Visible = false;
            searchPanel.Visible = false;
            addAgentPanel.Visible = true;
            pictureBoxMainWindow.Visible = false;
        } 
        
        private void addAgentButton_Click(object sender, EventArgs e)
        {
            string addAgentSqlCommand = "INSERT INTO AGENCI (AGENT_ID, IMIE, NAZWISKO, DATA_ZATR, PROWIZJA) " +
                                         "VALUES (AGENCI_SEQ.nextval, :Imie, :Nazwisko, :DataZatrudnienia, :Prowizja)";

            using (OracleCommand command = new OracleCommand(addAgentSqlCommand, LoginWindow.connection))
            {
                command.Parameters.Add(":Imie", OracleDbType.Varchar2).Value = agentFirstNameTextBox.Text;
                command.Parameters.Add(":Nazwisko", OracleDbType.Varchar2).Value = agentSurnameLabelTextBox.Text;
                command.Parameters.Add(":DataZatrudnienia", OracleDbType.Varchar2).Value = agentEmploymentDateTextBox.Text;
                command.Parameters.Add(":Prowizja", OracleDbType.Varchar2).Value = agentCommissionTextBox.Text;

                try
                {
                    int rowsInserted = command.ExecuteNonQuery();

                    if (rowsInserted > 0)
                    {
                        MessageBox.Show("Pomyślnie dodano agenta");
                        clearAgentTextBoxes();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearAgentTextBoxes()
        {
            agentCommissionTextBox.Text = "";
            agentEmploymentDateTextBox_SetText();
            agentFirstNameTextBox.Text = "";
            agentSurnameLabelTextBox.Text = "";           
        }

        private void agentEmploymentDateTextBox_Enter(object sender, EventArgs e)
        {
            agentEmploymentDateTextBox.ForeColor = Color.Black;
            agentEmploymentDateTextBox.Text = "";
        }

        private void agentEmploymentDateTextBox_Leave(object sender, EventArgs e)
        {
            if (agentEmploymentDateTextBox.Text.Trim() == "")
                agentEmploymentDateTextBox_SetText();
        }

        private void agentEmploymentDateTextBox_SetText()
        {
            agentEmploymentDateTextBox.ForeColor = Color.Gray;
            agentEmploymentDateTextBox.Text = "dd/mm/rr";
        }

        private void searchClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addClientPanel.Visible = false;
            searchPanel.Visible = true;
            activeItem = Item.Client;
            searchTextBox.Text = "";
            dataGridView.DataSource = null;
            deleteButton.Enabled = false;
            pictureBoxMainWindow.Visible = false;
        }

        private void searchAgentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addAgentPanel.Visible = false;
            searchPanel.Visible = true;
            activeItem = Item.Agent;
            searchTextBox.Text = "";
            dataGridView.DataSource = null;
            deleteButton.Enabled = false;
            pictureBoxMainWindow.Visible = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            deleteButton.Enabled = false;
            try
            {
                switch (activeItem)
                {
                    case Item.Client:
                        {
                            string searchClientSqlCommand = "SELECT * FROM KLIENCI WHERE KLIENT_ID              LIKE :KlientId              OR " +
                                                                                        "LOWER(IMIE)            LIKE LOWER(:Imie)           OR " +
                                                                                        "LOWER(NAZWISKO)        LIKE LOWER(:Nazwisko)       OR " +
                                                                                        "LOWER(ULICA_NR)        LIKE LOWER(:Ulica)          OR " +
                                                                                        "KOD_POCZTOWY           LIKE :KodPocztowy           OR " +
                                                                                        "LOWER(MIEJSCOWOSC)     LIKE LOWER(:Miejscowosc)    OR " +
                                                                                        "TELEFON                LIKE :Telefon               OR " +
                                                                                        "LOWER(EMAIL)           LIKE LOWER(:Email)";
                            using (DataTable dataTable = new DataTable("Client"))
                            {
                                dataTable.DefaultView.AllowEdit = false;
                                using (OracleCommand command = new OracleCommand(searchClientSqlCommand, LoginWindow.connection))
                                {
                                    command.Parameters.Add("KlientId", OracleDbType.Varchar2).Value = searchTextBox.Text;
                                    command.Parameters.Add("Imie", OracleDbType.Varchar2).Value = string.Format("%{0}%", searchTextBox.Text);
                                    command.Parameters.Add("Nazwisko", OracleDbType.Varchar2).Value = string.Format("%{0}%", searchTextBox.Text);
                                    command.Parameters.Add("Ulica", OracleDbType.Varchar2).Value = searchTextBox.Text;
                                    command.Parameters.Add("KodPocztowy", OracleDbType.Varchar2).Value = searchTextBox.Text;
                                    command.Parameters.Add("Miejscowosc", OracleDbType.Varchar2).Value = string.Format("%{0}%", searchTextBox.Text);
                                    command.Parameters.Add("Telefon", OracleDbType.Varchar2).Value = searchTextBox.Text;
                                    command.Parameters.Add("Email", OracleDbType.Varchar2).Value = searchTextBox.Text;

                                    using (OracleDataAdapter dataAdapter = new OracleDataAdapter(command))
                                    {
                                        dataAdapter.Fill(dataTable);
                                        dataGridView.DataSource = dataTable;
                                        dataGridView.ClearSelection();
                                    }
                                    disableColumnSorting(dataGridView);
                                }
                            }
                        }
                        break;
                    case Item.Agent:
                        {
                            string searchAgentSqlCommand = "SELECT * FROM AGENCI WHERE AGENT_ID         LIKE :AgentId           OR " +
                                                                                      "LOWER(IMIE)      LIKE LOWER(:Imie)       OR " +
                                                                                      "LOWER(NAZWISKO)  LIKE LOWER(:Nazwisko)   OR " +
                                                                                      "DATA_ZATR        LIKE :DataZatrudnienia  OR " +
                                                                                      "PROWIZJA         LIKE :Prowizja";
                            using (DataTable dataTable = new DataTable("Agent"))
                            {
                                dataTable.DefaultView.AllowEdit = false;
                                using (OracleCommand command = new OracleCommand(searchAgentSqlCommand, LoginWindow.connection))
                                {
                                    command.Parameters.Add("AgentId", OracleDbType.Varchar2).Value = searchTextBox.Text;
                                    command.Parameters.Add("Imie", OracleDbType.Varchar2).Value = string.Format("%{0}%", searchTextBox.Text);
                                    command.Parameters.Add("Nazwisko", OracleDbType.Varchar2).Value = string.Format("%{0}%", searchTextBox.Text);
                                    command.Parameters.Add("DataZatrudnienia", OracleDbType.Varchar2).Value = searchTextBox.Text;
                                    command.Parameters.Add("Prowizja", OracleDbType.Varchar2).Value = searchTextBox.Text;

                                    using (OracleDataAdapter dataAdapter = new OracleDataAdapter(command))
                                    {
                                        dataAdapter.Fill(dataTable);
                                        dataGridView.DataSource = dataTable;
                                        dataGridView.ClearSelection();
                                    }
                                    disableColumnSorting(dataGridView);
                                }
                            }
                        }
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {        
            string columnName = "";
            switch (activeItem)
            {
                case Item.Client:
                    columnName = "KLIENT_ID";
                    break;
                case Item.Agent:
                    columnName = "AGENT_ID";
                    break;
            }
            if (e.RowIndex >= 0) // Upewnij się, że kliknięto na prawidłowy wiersz
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                // Pobranie wartości z konkretnej kolumny (np. "NazwaKolumny") z wybranego wiersza
                try
                {
                    idToDelete = int.Parse(row.Cells[columnName].Value.ToString());
                    //MessageBox.Show("ID = " + idToDelete);
                    deleteButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            switch (activeItem)
            {
                case Item.Client:
                    {
                        try
                        {
                            string deleteClientSqlCommand = "DELETE FROM KLIENCI WHERE KLIENT_ID = :Id";
                            using (OracleCommand command = new OracleCommand(deleteClientSqlCommand, LoginWindow.connection))
                            {
                                command.Parameters.Add(":Id", OracleDbType.Int32).Value = idToDelete;

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Wiersz został pomyślnie usunięty");
                                    dataGridView.ClearSelection();
                                    deleteButton.Enabled = false;
                                    deleteRowByKey(idToDelete, "KLIENT_ID");
                                    dataGridView.ClearSelection();
                                }
                            }
                        }
                        catch (OracleException ex)
                        {
                            MessageBox.Show("Wystąpił błąd podczas usuwania wiersza: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Wystąpił ogólny błąd: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case Item.Agent:
                    {
                        try
                        {
                            string deleteAgentSqlCommand = "DELETE FROM AGENCI WHERE AGENT_ID = :Id";
                            using (OracleCommand command = new OracleCommand(deleteAgentSqlCommand, LoginWindow.connection))
                            {
                                command.Parameters.Add(":Id", OracleDbType.Int32).Value = idToDelete;

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Wiersz został pomyślnie usunięty");
                                    dataGridView.ClearSelection();
                                    deleteButton.Enabled = false;
                                    deleteRowByKey(idToDelete, "AGENT_ID");
                                    dataGridView.ClearSelection();
                                }
                            }
                        }
                        catch (OracleException ex)
                        {
                            MessageBox.Show("Wystąpił błąd podczas usuwania wiersza: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Wystąpił ogólny błąd: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
            }
        }

        private void disableColumnSorting(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void deleteRowByKey(int key, string columnName)
        {
            DataGridViewRow rowToDelete = null;

            // Przeszukaj wiersze kontrolki DataGridView w poszukiwaniu pasującej wartości klucza
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells[columnName].Value) == key)
                {
                    rowToDelete = row;
                    break;
                }
            }

            // Jeśli znaleziono wiersz, usuń go
            if (rowToDelete != null)
            {
                dataGridView.Rows.Remove(rowToDelete);
            }
        }
    }
}
