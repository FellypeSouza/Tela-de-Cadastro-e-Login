namespace TelaDeCadastroELogin.Views
{
    partial class UserInfoPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.alterPasswordButton = new System.Windows.Forms.Button();
            this.alterDataButton = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.checkPasswordPanel = new System.Windows.Forms.Panel();
            this.checkPassword = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.checkPasswordTextbox = new System.Windows.Forms.TextBox();
            this.alterUserPasswordPanel = new System.Windows.Forms.Panel();
            this.sendNewPassword = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.newUserPasswordTextbox = new System.Windows.Forms.TextBox();
            this.checkPasswordPanel.SuspendLayout();
            this.alterUserPasswordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dados cadastrados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome de usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(8, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de registro: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(8, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Senha:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordLabel.Location = new System.Drawing.Point(56, 78);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(40, 17);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "1234";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateLabel.Location = new System.Drawing.Point(122, 104);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(80, 17);
            this.dateLabel.TabIndex = 10;
            this.dateLabel.Text = "20/07/2025";
            // 
            // alterPasswordButton
            // 
            this.alterPasswordButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.alterPasswordButton.FlatAppearance.BorderSize = 0;
            this.alterPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alterPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterPasswordButton.ForeColor = System.Drawing.SystemColors.Control;
            this.alterPasswordButton.Location = new System.Drawing.Point(11, 208);
            this.alterPasswordButton.Name = "alterPasswordButton";
            this.alterPasswordButton.Size = new System.Drawing.Size(249, 26);
            this.alterPasswordButton.TabIndex = 11;
            this.alterPasswordButton.Text = "ALTERAR SENHA";
            this.alterPasswordButton.UseVisualStyleBackColor = false;
            this.alterPasswordButton.Click += new System.EventHandler(this.alterPasswordButton_Click);
            // 
            // alterDataButton
            // 
            this.alterDataButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.alterDataButton.FlatAppearance.BorderSize = 0;
            this.alterDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alterDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterDataButton.ForeColor = System.Drawing.SystemColors.Control;
            this.alterDataButton.Location = new System.Drawing.Point(11, 250);
            this.alterDataButton.Name = "alterDataButton";
            this.alterDataButton.Size = new System.Drawing.Size(249, 26);
            this.alterDataButton.TabIndex = 12;
            this.alterDataButton.Text = "ALTERAR DADOS";
            this.alterDataButton.UseVisualStyleBackColor = false;
            this.alterDataButton.Click += new System.EventHandler(this.alterDataButton_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteUser.FlatAppearance.BorderSize = 0;
            this.DeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUser.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteUser.Location = new System.Drawing.Point(11, 294);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(249, 26);
            this.DeleteUser.TabIndex = 13;
            this.DeleteUser.Text = "EXCLUIR CONTA";
            this.DeleteUser.UseVisualStyleBackColor = false;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameLabel.Location = new System.Drawing.Point(124, 52);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(53, 17);
            this.usernameLabel.TabIndex = 14;
            this.usernameLabel.Text = "Fellype";
            // 
            // checkPasswordPanel
            // 
            this.checkPasswordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkPasswordPanel.Controls.Add(this.checkPassword);
            this.checkPasswordPanel.Controls.Add(this.label5);
            this.checkPasswordPanel.Controls.Add(this.checkPasswordTextbox);
            this.checkPasswordPanel.Location = new System.Drawing.Point(34, 134);
            this.checkPasswordPanel.Name = "checkPasswordPanel";
            this.checkPasswordPanel.Size = new System.Drawing.Size(200, 100);
            this.checkPasswordPanel.TabIndex = 15;
            this.checkPasswordPanel.Visible = false;
            // 
            // checkPassword
            // 
            this.checkPassword.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.checkPassword.FlatAppearance.BorderSize = 0;
            this.checkPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.checkPassword.Location = new System.Drawing.Point(42, 59);
            this.checkPassword.Name = "checkPassword";
            this.checkPassword.Size = new System.Drawing.Size(104, 26);
            this.checkPassword.TabIndex = 12;
            this.checkPassword.Text = "ENVIAR";
            this.checkPassword.UseVisualStyleBackColor = false;
            this.checkPassword.Click += new System.EventHandler(this.checkPassword_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Insira sua senha";
            // 
            // checkPasswordTextbox
            // 
            this.checkPasswordTextbox.Location = new System.Drawing.Point(12, 32);
            this.checkPasswordTextbox.Name = "checkPasswordTextbox";
            this.checkPasswordTextbox.Size = new System.Drawing.Size(171, 20);
            this.checkPasswordTextbox.TabIndex = 0;
            // 
            // alterUserPasswordPanel
            // 
            this.alterUserPasswordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alterUserPasswordPanel.Controls.Add(this.sendNewPassword);
            this.alterUserPasswordPanel.Controls.Add(this.label6);
            this.alterUserPasswordPanel.Controls.Add(this.newUserPasswordTextbox);
            this.alterUserPasswordPanel.Location = new System.Drawing.Point(34, 134);
            this.alterUserPasswordPanel.Name = "alterUserPasswordPanel";
            this.alterUserPasswordPanel.Size = new System.Drawing.Size(200, 100);
            this.alterUserPasswordPanel.TabIndex = 16;
            this.alterUserPasswordPanel.Visible = false;
            // 
            // sendNewPassword
            // 
            this.sendNewPassword.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sendNewPassword.FlatAppearance.BorderSize = 0;
            this.sendNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendNewPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.sendNewPassword.Location = new System.Drawing.Point(42, 58);
            this.sendNewPassword.Name = "sendNewPassword";
            this.sendNewPassword.Size = new System.Drawing.Size(104, 26);
            this.sendNewPassword.TabIndex = 12;
            this.sendNewPassword.Text = "ENVIAR";
            this.sendNewPassword.UseVisualStyleBackColor = false;
            this.sendNewPassword.Click += new System.EventHandler(this.sendNewPassword_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Insira sua nova senha";
            // 
            // newUserPasswordTextbox
            // 
            this.newUserPasswordTextbox.Location = new System.Drawing.Point(12, 32);
            this.newUserPasswordTextbox.Name = "newUserPasswordTextbox";
            this.newUserPasswordTextbox.Size = new System.Drawing.Size(171, 20);
            this.newUserPasswordTextbox.TabIndex = 0;
            // 
            // UserInfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 332);
            this.Controls.Add(this.alterUserPasswordPanel);
            this.Controls.Add(this.checkPasswordPanel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.alterDataButton);
            this.Controls.Add(this.alterPasswordButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserInfoPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserInfoPage";
            this.Load += new System.EventHandler(this.UserInfoPage_Load);
            this.checkPasswordPanel.ResumeLayout(false);
            this.checkPasswordPanel.PerformLayout();
            this.alterUserPasswordPanel.ResumeLayout(false);
            this.alterUserPasswordPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button alterPasswordButton;
        private System.Windows.Forms.Button alterDataButton;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Panel checkPasswordPanel;
        private System.Windows.Forms.Button checkPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox checkPasswordTextbox;
        private System.Windows.Forms.Panel alterUserPasswordPanel;
        private System.Windows.Forms.Button sendNewPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox newUserPasswordTextbox;
    }
}