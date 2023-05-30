
namespace ubezpieczenia
{
    partial class LoginWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.pictureBoxLoginPage = new System.Windows.Forms.PictureBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginPage)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordLabel.Location = new System.Drawing.Point(165, 208);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(89, 31);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Hasło";
            // 
            // loginInput
            // 
            this.loginInput.BackColor = System.Drawing.Color.White;
            this.loginInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginInput.Location = new System.Drawing.Point(272, 138);
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(200, 38);
            this.loginInput.TabIndex = 1;
            // 
            // passwordInput
            // 
            this.passwordInput.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordInput.Location = new System.Drawing.Point(272, 205);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(200, 38);
            this.passwordInput.TabIndex = 2;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // pictureBoxLoginPage
            // 
            this.pictureBoxLoginPage.Image = global::ubezpieczenia.Properties.Resources.loginPage;
            this.pictureBoxLoginPage.Location = new System.Drawing.Point(0, -1);
            this.pictureBoxLoginPage.Name = "pictureBoxLoginPage";
            this.pictureBoxLoginPage.Size = new System.Drawing.Size(706, 427);
            this.pictureBoxLoginPage.TabIndex = 7;
            this.pictureBoxLoginPage.TabStop = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginLabel.Location = new System.Drawing.Point(165, 141);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(85, 31);
            this.loginLabel.TabIndex = 8;
            this.loginLabel.Text = "Login";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginButton.Location = new System.Drawing.Point(308, 270);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(124, 39);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Zaloguj";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(706, 424);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.loginInput);
            this.Controls.Add(this.pictureBoxLoginPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginWindow";
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox loginInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.PictureBox pictureBoxLoginPage;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button loginButton;
    }
}

