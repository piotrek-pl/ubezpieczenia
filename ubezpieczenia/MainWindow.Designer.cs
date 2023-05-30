
namespace ubezpieczenia
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownClient = new System.Windows.Forms.ToolStripDropDownButton();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownAgent = new System.Windows.Forms.ToolStripDropDownButton();
            this.addAgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.clientSurnameTextBox = new System.Windows.Forms.TextBox();
            this.clientStreetTextBox = new System.Windows.Forms.TextBox();
            this.addClientPanel = new System.Windows.Forms.Panel();
            this.clientPostcodeTextBox = new System.Windows.Forms.TextBox();
            this.addClientButton = new System.Windows.Forms.Button();
            this.clientEmailLabel = new System.Windows.Forms.Label();
            this.clientPhoneLabel = new System.Windows.Forms.Label();
            this.clientTownLabel = new System.Windows.Forms.Label();
            this.clientPostcodeLabel = new System.Windows.Forms.Label();
            this.clientStreetLabel = new System.Windows.Forms.Label();
            this.clientSurnameLabel = new System.Windows.Forms.Label();
            this.clientFirstNameLabel = new System.Windows.Forms.Label();
            this.clientEmailTextBox = new System.Windows.Forms.TextBox();
            this.clientPhoneTextBox = new System.Windows.Forms.TextBox();
            this.clientTownTextBox = new System.Windows.Forms.TextBox();
            this.addAgentPanel = new System.Windows.Forms.Panel();
            this.addAgentButton = new System.Windows.Forms.Button();
            this.agentCommissionTextBox = new System.Windows.Forms.TextBox();
            this.agentCommissionLabel = new System.Windows.Forms.Label();
            this.agentEmploymentDateLabel = new System.Windows.Forms.Label();
            this.agentSurnameLabel = new System.Windows.Forms.Label();
            this.agentFirstNameLabel = new System.Windows.Forms.Label();
            this.agentFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.agentSurnameLabelTextBox = new System.Windows.Forms.TextBox();
            this.agentEmploymentDateTextBox = new System.Windows.Forms.TextBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.pictureBoxMainWindow = new System.Windows.Forms.PictureBox();
            this.toolStrip.SuspendLayout();
            this.addClientPanel.SuspendLayout();
            this.addAgentPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownClient,
            this.toolStripDropDownAgent});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(679, 103);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripDropDownClient
            // 
            this.toolStripDropDownClient.AutoSize = false;
            this.toolStripDropDownClient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem,
            this.searchClientToolStripMenuItem});
            this.toolStripDropDownClient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripDropDownClient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripDropDownClient.Image = global::ubezpieczenia.Properties.Resources.client_100x100;
            this.toolStripDropDownClient.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownClient.Name = "toolStripDropDownClient";
            this.toolStripDropDownClient.Size = new System.Drawing.Size(100, 100);
            this.toolStripDropDownClient.Text = "Klient";
            this.toolStripDropDownClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addClientToolStripMenuItem.Text = "Dodaj";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // searchClientToolStripMenuItem
            // 
            this.searchClientToolStripMenuItem.Name = "searchClientToolStripMenuItem";
            this.searchClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchClientToolStripMenuItem.Text = "Wyszukaj";
            this.searchClientToolStripMenuItem.Click += new System.EventHandler(this.searchClientToolStripMenuItem_Click);
            // 
            // toolStripDropDownAgent
            // 
            this.toolStripDropDownAgent.AutoSize = false;
            this.toolStripDropDownAgent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAgentToolStripMenuItem,
            this.searchAgentToolStripMenuItem});
            this.toolStripDropDownAgent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripDropDownAgent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripDropDownAgent.Image = global::ubezpieczenia.Properties.Resources.agent_100x100;
            this.toolStripDropDownAgent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownAgent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownAgent.Name = "toolStripDropDownAgent";
            this.toolStripDropDownAgent.Size = new System.Drawing.Size(100, 100);
            this.toolStripDropDownAgent.Text = "Agent";
            this.toolStripDropDownAgent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // addAgentToolStripMenuItem
            // 
            this.addAgentToolStripMenuItem.Name = "addAgentToolStripMenuItem";
            this.addAgentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addAgentToolStripMenuItem.Text = "Dodaj";
            this.addAgentToolStripMenuItem.Click += new System.EventHandler(this.addAgentToolStripMenuItem_Click);
            // 
            // searchAgentToolStripMenuItem
            // 
            this.searchAgentToolStripMenuItem.Name = "searchAgentToolStripMenuItem";
            this.searchAgentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchAgentToolStripMenuItem.Text = "Wyszukaj";
            this.searchAgentToolStripMenuItem.Click += new System.EventHandler(this.searchAgentToolStripMenuItem_Click);
            // 
            // clientFirstNameTextBox
            // 
            this.clientFirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientFirstNameTextBox.Location = new System.Drawing.Point(149, 30);
            this.clientFirstNameTextBox.Name = "clientFirstNameTextBox";
            this.clientFirstNameTextBox.Size = new System.Drawing.Size(125, 22);
            this.clientFirstNameTextBox.TabIndex = 1;
            // 
            // clientSurnameTextBox
            // 
            this.clientSurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientSurnameTextBox.Location = new System.Drawing.Point(149, 68);
            this.clientSurnameTextBox.Name = "clientSurnameTextBox";
            this.clientSurnameTextBox.Size = new System.Drawing.Size(125, 22);
            this.clientSurnameTextBox.TabIndex = 2;
            // 
            // clientStreetTextBox
            // 
            this.clientStreetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientStreetTextBox.Location = new System.Drawing.Point(149, 108);
            this.clientStreetTextBox.Name = "clientStreetTextBox";
            this.clientStreetTextBox.Size = new System.Drawing.Size(125, 22);
            this.clientStreetTextBox.TabIndex = 3;
            // 
            // addClientPanel
            // 
            this.addClientPanel.Controls.Add(this.clientPostcodeTextBox);
            this.addClientPanel.Controls.Add(this.addClientButton);
            this.addClientPanel.Controls.Add(this.clientEmailLabel);
            this.addClientPanel.Controls.Add(this.clientPhoneLabel);
            this.addClientPanel.Controls.Add(this.clientTownLabel);
            this.addClientPanel.Controls.Add(this.clientPostcodeLabel);
            this.addClientPanel.Controls.Add(this.clientStreetLabel);
            this.addClientPanel.Controls.Add(this.clientSurnameLabel);
            this.addClientPanel.Controls.Add(this.clientFirstNameLabel);
            this.addClientPanel.Controls.Add(this.clientEmailTextBox);
            this.addClientPanel.Controls.Add(this.clientPhoneTextBox);
            this.addClientPanel.Controls.Add(this.clientTownTextBox);
            this.addClientPanel.Controls.Add(this.clientFirstNameTextBox);
            this.addClientPanel.Controls.Add(this.clientSurnameTextBox);
            this.addClientPanel.Controls.Add(this.clientStreetTextBox);
            this.addClientPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addClientPanel.Location = new System.Drawing.Point(163, 112);
            this.addClientPanel.Name = "addClientPanel";
            this.addClientPanel.Size = new System.Drawing.Size(318, 340);
            this.addClientPanel.TabIndex = 5;
            this.addClientPanel.Visible = false;
            // 
            // clientPostcodeTextBox
            // 
            this.clientPostcodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientPostcodeTextBox.Location = new System.Drawing.Point(149, 146);
            this.clientPostcodeTextBox.Name = "clientPostcodeTextBox";
            this.clientPostcodeTextBox.Size = new System.Drawing.Size(125, 22);
            this.clientPostcodeTextBox.TabIndex = 4;
            // 
            // addClientButton
            // 
            this.addClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addClientButton.Location = new System.Drawing.Point(106, 293);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(95, 34);
            this.addClientButton.TabIndex = 8;
            this.addClientButton.Text = "Dodaj";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // clientEmailLabel
            // 
            this.clientEmailLabel.AutoSize = true;
            this.clientEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientEmailLabel.Location = new System.Drawing.Point(17, 256);
            this.clientEmailLabel.Name = "clientEmailLabel";
            this.clientEmailLabel.Size = new System.Drawing.Size(52, 16);
            this.clientEmailLabel.TabIndex = 14;
            this.clientEmailLabel.Text = "E-mail";
            // 
            // clientPhoneLabel
            // 
            this.clientPhoneLabel.AutoSize = true;
            this.clientPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientPhoneLabel.Location = new System.Drawing.Point(17, 221);
            this.clientPhoneLabel.Name = "clientPhoneLabel";
            this.clientPhoneLabel.Size = new System.Drawing.Size(61, 16);
            this.clientPhoneLabel.TabIndex = 13;
            this.clientPhoneLabel.Text = "Telefon";
            // 
            // clientTownLabel
            // 
            this.clientTownLabel.AutoSize = true;
            this.clientTownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientTownLabel.Location = new System.Drawing.Point(17, 185);
            this.clientTownLabel.Name = "clientTownLabel";
            this.clientTownLabel.Size = new System.Drawing.Size(97, 16);
            this.clientTownLabel.TabIndex = 12;
            this.clientTownLabel.Text = "Miejscowość";
            // 
            // clientPostcodeLabel
            // 
            this.clientPostcodeLabel.AutoSize = true;
            this.clientPostcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientPostcodeLabel.Location = new System.Drawing.Point(17, 149);
            this.clientPostcodeLabel.Name = "clientPostcodeLabel";
            this.clientPostcodeLabel.Size = new System.Drawing.Size(103, 16);
            this.clientPostcodeLabel.TabIndex = 11;
            this.clientPostcodeLabel.Text = "Kod pocztowy";
            // 
            // clientStreetLabel
            // 
            this.clientStreetLabel.AutoSize = true;
            this.clientStreetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientStreetLabel.Location = new System.Drawing.Point(17, 111);
            this.clientStreetLabel.Name = "clientStreetLabel";
            this.clientStreetLabel.Size = new System.Drawing.Size(44, 16);
            this.clientStreetLabel.TabIndex = 10;
            this.clientStreetLabel.Text = "Ulica";
            // 
            // clientSurnameLabel
            // 
            this.clientSurnameLabel.AutoSize = true;
            this.clientSurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientSurnameLabel.Location = new System.Drawing.Point(17, 71);
            this.clientSurnameLabel.Name = "clientSurnameLabel";
            this.clientSurnameLabel.Size = new System.Drawing.Size(74, 16);
            this.clientSurnameLabel.TabIndex = 9;
            this.clientSurnameLabel.Text = "Nazwisko";
            // 
            // clientFirstNameLabel
            // 
            this.clientFirstNameLabel.AutoSize = true;
            this.clientFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientFirstNameLabel.Location = new System.Drawing.Point(17, 33);
            this.clientFirstNameLabel.Name = "clientFirstNameLabel";
            this.clientFirstNameLabel.Size = new System.Drawing.Size(37, 16);
            this.clientFirstNameLabel.TabIndex = 8;
            this.clientFirstNameLabel.Text = "Imię";
            // 
            // clientEmailTextBox
            // 
            this.clientEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientEmailTextBox.Location = new System.Drawing.Point(149, 253);
            this.clientEmailTextBox.Name = "clientEmailTextBox";
            this.clientEmailTextBox.Size = new System.Drawing.Size(125, 22);
            this.clientEmailTextBox.TabIndex = 7;
            // 
            // clientPhoneTextBox
            // 
            this.clientPhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientPhoneTextBox.Location = new System.Drawing.Point(149, 218);
            this.clientPhoneTextBox.Name = "clientPhoneTextBox";
            this.clientPhoneTextBox.Size = new System.Drawing.Size(125, 22);
            this.clientPhoneTextBox.TabIndex = 6;
            // 
            // clientTownTextBox
            // 
            this.clientTownTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientTownTextBox.Location = new System.Drawing.Point(149, 182);
            this.clientTownTextBox.Name = "clientTownTextBox";
            this.clientTownTextBox.Size = new System.Drawing.Size(125, 22);
            this.clientTownTextBox.TabIndex = 5;
            // 
            // addAgentPanel
            // 
            this.addAgentPanel.Controls.Add(this.addAgentButton);
            this.addAgentPanel.Controls.Add(this.agentCommissionTextBox);
            this.addAgentPanel.Controls.Add(this.agentCommissionLabel);
            this.addAgentPanel.Controls.Add(this.agentEmploymentDateLabel);
            this.addAgentPanel.Controls.Add(this.agentSurnameLabel);
            this.addAgentPanel.Controls.Add(this.agentFirstNameLabel);
            this.addAgentPanel.Controls.Add(this.agentFirstNameTextBox);
            this.addAgentPanel.Controls.Add(this.agentSurnameLabelTextBox);
            this.addAgentPanel.Controls.Add(this.agentEmploymentDateTextBox);
            this.addAgentPanel.Location = new System.Drawing.Point(160, 112);
            this.addAgentPanel.Name = "addAgentPanel";
            this.addAgentPanel.Size = new System.Drawing.Size(318, 340);
            this.addAgentPanel.TabIndex = 6;
            this.addAgentPanel.Visible = false;
            // 
            // addAgentButton
            // 
            this.addAgentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addAgentButton.Location = new System.Drawing.Point(110, 225);
            this.addAgentButton.Name = "addAgentButton";
            this.addAgentButton.Size = new System.Drawing.Size(95, 34);
            this.addAgentButton.TabIndex = 16;
            this.addAgentButton.Text = "Dodaj";
            this.addAgentButton.UseVisualStyleBackColor = true;
            this.addAgentButton.Click += new System.EventHandler(this.addAgentButton_Click);
            // 
            // agentCommissionTextBox
            // 
            this.agentCommissionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.agentCommissionTextBox.Location = new System.Drawing.Point(152, 168);
            this.agentCommissionTextBox.Name = "agentCommissionTextBox";
            this.agentCommissionTextBox.Size = new System.Drawing.Size(125, 22);
            this.agentCommissionTextBox.TabIndex = 15;
            // 
            // agentCommissionLabel
            // 
            this.agentCommissionLabel.AutoSize = true;
            this.agentCommissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.agentCommissionLabel.Location = new System.Drawing.Point(20, 171);
            this.agentCommissionLabel.Name = "agentCommissionLabel";
            this.agentCommissionLabel.Size = new System.Drawing.Size(66, 16);
            this.agentCommissionLabel.TabIndex = 19;
            this.agentCommissionLabel.Text = "Prowizja";
            // 
            // agentEmploymentDateLabel
            // 
            this.agentEmploymentDateLabel.AutoSize = true;
            this.agentEmploymentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.agentEmploymentDateLabel.Location = new System.Drawing.Point(20, 133);
            this.agentEmploymentDateLabel.Name = "agentEmploymentDateLabel";
            this.agentEmploymentDateLabel.Size = new System.Drawing.Size(129, 16);
            this.agentEmploymentDateLabel.TabIndex = 18;
            this.agentEmploymentDateLabel.Text = "Data zatrudnienia";
            // 
            // agentSurnameLabel
            // 
            this.agentSurnameLabel.AutoSize = true;
            this.agentSurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.agentSurnameLabel.Location = new System.Drawing.Point(20, 93);
            this.agentSurnameLabel.Name = "agentSurnameLabel";
            this.agentSurnameLabel.Size = new System.Drawing.Size(74, 16);
            this.agentSurnameLabel.TabIndex = 17;
            this.agentSurnameLabel.Text = "Nazwisko";
            // 
            // agentFirstNameLabel
            // 
            this.agentFirstNameLabel.AutoSize = true;
            this.agentFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.agentFirstNameLabel.Location = new System.Drawing.Point(20, 55);
            this.agentFirstNameLabel.Name = "agentFirstNameLabel";
            this.agentFirstNameLabel.Size = new System.Drawing.Size(37, 16);
            this.agentFirstNameLabel.TabIndex = 16;
            this.agentFirstNameLabel.Text = "Imię";
            // 
            // agentFirstNameTextBox
            // 
            this.agentFirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.agentFirstNameTextBox.Location = new System.Drawing.Point(152, 52);
            this.agentFirstNameTextBox.Name = "agentFirstNameTextBox";
            this.agentFirstNameTextBox.Size = new System.Drawing.Size(125, 22);
            this.agentFirstNameTextBox.TabIndex = 12;
            // 
            // agentSurnameLabelTextBox
            // 
            this.agentSurnameLabelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.agentSurnameLabelTextBox.Location = new System.Drawing.Point(152, 90);
            this.agentSurnameLabelTextBox.Name = "agentSurnameLabelTextBox";
            this.agentSurnameLabelTextBox.Size = new System.Drawing.Size(125, 22);
            this.agentSurnameLabelTextBox.TabIndex = 13;
            // 
            // agentEmploymentDateTextBox
            // 
            this.agentEmploymentDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.agentEmploymentDateTextBox.Location = new System.Drawing.Point(152, 130);
            this.agentEmploymentDateTextBox.Name = "agentEmploymentDateTextBox";
            this.agentEmploymentDateTextBox.Size = new System.Drawing.Size(125, 22);
            this.agentEmploymentDateTextBox.TabIndex = 14;
            this.agentEmploymentDateTextBox.Enter += new System.EventHandler(this.agentEmploymentDateTextBox_Enter);
            this.agentEmploymentDateTextBox.Leave += new System.EventHandler(this.agentEmploymentDateTextBox_Leave);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.deleteButton);
            this.searchPanel.Controls.Add(this.dataGridView);
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Location = new System.Drawing.Point(12, 109);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(655, 340);
            this.searchPanel.TabIndex = 7;
            this.searchPanel.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteButton.Location = new System.Drawing.Point(282, 284);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(95, 34);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Usuń";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(12, 87);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(632, 172);
            this.dataGridView.TabIndex = 18;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchButton.Location = new System.Drawing.Point(558, 49);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(86, 25);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Wyszukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchTextBox.Location = new System.Drawing.Point(12, 49);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(540, 22);
            this.searchTextBox.TabIndex = 16;
            // 
            // pictureBoxMainWindow
            // 
            this.pictureBoxMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMainWindow.Image = global::ubezpieczenia.Properties.Resources.mountain_car;
            this.pictureBoxMainWindow.Location = new System.Drawing.Point(0, 103);
            this.pictureBoxMainWindow.Name = "pictureBoxMainWindow";
            this.pictureBoxMainWindow.Size = new System.Drawing.Size(679, 361);
            this.pictureBoxMainWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxMainWindow.TabIndex = 8;
            this.pictureBoxMainWindow.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 464);
            this.Controls.Add(this.pictureBoxMainWindow);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.addAgentPanel);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.addClientPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Zalogowano";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.addClientPanel.ResumeLayout(false);
            this.addClientPanel.PerformLayout();
            this.addAgentPanel.ResumeLayout(false);
            this.addAgentPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownClient;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownAgent;
        private System.Windows.Forms.ToolStripMenuItem addAgentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchAgentToolStripMenuItem;
        private System.Windows.Forms.TextBox clientFirstNameTextBox;
        private System.Windows.Forms.TextBox clientSurnameTextBox;
        private System.Windows.Forms.TextBox clientStreetTextBox;
        private System.Windows.Forms.Panel addClientPanel;
        private System.Windows.Forms.Label clientFirstNameLabel;
        private System.Windows.Forms.TextBox clientEmailTextBox;
        private System.Windows.Forms.TextBox clientPhoneTextBox;
        private System.Windows.Forms.TextBox clientTownTextBox;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Label clientEmailLabel;
        private System.Windows.Forms.Label clientPhoneLabel;
        private System.Windows.Forms.Label clientTownLabel;
        private System.Windows.Forms.Label clientPostcodeLabel;
        private System.Windows.Forms.Label clientStreetLabel;
        private System.Windows.Forms.Label clientSurnameLabel;
        private System.Windows.Forms.TextBox clientPostcodeTextBox;
        private System.Windows.Forms.Panel addAgentPanel;
        private System.Windows.Forms.TextBox agentCommissionTextBox;
        private System.Windows.Forms.Label agentCommissionLabel;
        private System.Windows.Forms.Label agentEmploymentDateLabel;
        private System.Windows.Forms.Label agentSurnameLabel;
        private System.Windows.Forms.Label agentFirstNameLabel;
        private System.Windows.Forms.TextBox agentFirstNameTextBox;
        private System.Windows.Forms.TextBox agentSurnameLabelTextBox;
        private System.Windows.Forms.TextBox agentEmploymentDateTextBox;
        private System.Windows.Forms.Button addAgentButton;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.PictureBox pictureBoxMainWindow;
    }
}