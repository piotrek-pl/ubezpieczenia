using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ubezpieczenia
{
    public partial class LoginWindow : Form
    {
        static public OracleConnection connection;
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {
            loginLabel.Parent = pictureBoxLoginPage;
            passwordLabel.Parent = pictureBoxLoginPage;
            loginButton.Parent = pictureBoxLoginPage;
            loginInput.Parent = pictureBoxLoginPage;
            passwordInput.Parent = pictureBoxLoginPage;
            ActiveControl = loginInput;
        }

        public void connect()
        {
            string databaseSource = "localhost:1521/xepdb1";
            string username = loginInput.Text;
            string password = passwordInput.Text;
            string connectionString = $"Data Source={databaseSource};User ID={username};Password={password};";
            //string connectionString = $"Data Source={databaseSource};User ID=ubezpieczenia;Password=ubezpieczenie;";

            connection = new OracleConnection(connectionString);
            try
            {
                connection.Open();
                this.Visible = false;
                    
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();               
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            connect();
        }
    }
}
 