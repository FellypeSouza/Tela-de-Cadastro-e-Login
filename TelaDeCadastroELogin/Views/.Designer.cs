namespace TelaDeCadastroELogin
{
    partial class MainPage
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmPasswordInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.registerUserButton = new System.Windows.Forms.Button();
            this.clearInputDataButton = new System.Windows.Forms.Button();
            this.conexao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vamos começar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(41, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome de usuário";
            // 
            // usernameInput
            // 
            this.usernameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.usernameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameInput.Location = new System.Drawing.Point(44, 96);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(200, 26);
            this.usernameInput.TabIndex = 2;
            // 
            // passwordInput
            // 
            this.passwordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.passwordInput.Location = new System.Drawing.Point(44, 153);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(200, 26);
            this.passwordInput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(41, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha";
            // 
            // confirmPasswordInput
            // 
            this.confirmPasswordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.confirmPasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.confirmPasswordInput.Location = new System.Drawing.Point(44, 212);
            this.confirmPasswordInput.Name = "confirmPasswordInput";
            this.confirmPasswordInput.Size = new System.Drawing.Size(200, 26);
            this.confirmPasswordInput.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(41, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirmar senha";
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showPasswordCheckBox.Location = new System.Drawing.Point(138, 244);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(105, 19);
            this.showPasswordCheckBox.TabIndex = 7;
            this.showPasswordCheckBox.Text = "Mostrar senha";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // registerUserButton
            // 
            this.registerUserButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.registerUserButton.FlatAppearance.BorderSize = 0;
            this.registerUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUserButton.ForeColor = System.Drawing.SystemColors.Control;
            this.registerUserButton.Location = new System.Drawing.Point(44, 282);
            this.registerUserButton.Name = "registerUserButton";
            this.registerUserButton.Size = new System.Drawing.Size(199, 26);
            this.registerUserButton.TabIndex = 8;
            this.registerUserButton.Text = "REGISTRAR";
            this.registerUserButton.UseVisualStyleBackColor = false;
            this.registerUserButton.Click += new System.EventHandler(this.registerUserButton_Click);
            // 
            // clearInputDataButton
            // 
            this.clearInputDataButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.clearInputDataButton.FlatAppearance.BorderSize = 0;
            this.clearInputDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearInputDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearInputDataButton.ForeColor = System.Drawing.SystemColors.Control;
            this.clearInputDataButton.Location = new System.Drawing.Point(44, 325);
            this.clearInputDataButton.Name = "clearInputDataButton";
            this.clearInputDataButton.Size = new System.Drawing.Size(199, 26);
            this.clearInputDataButton.TabIndex = 9;
            this.clearInputDataButton.Text = "LIMPAR DADOS";
            this.clearInputDataButton.UseVisualStyleBackColor = false;
            this.clearInputDataButton.Click += new System.EventHandler(this.clearInputDataButton_Click);
            // 
            // conexao
            // 
            this.conexao.Location = new System.Drawing.Point(200, 36);
            this.conexao.Name = "conexao";
            this.conexao.Size = new System.Drawing.Size(75, 23);
            this.conexao.TabIndex = 10;
            this.conexao.Text = "conexao";
            this.conexao.UseVisualStyleBackColor = true;
            this.conexao.Click += new System.EventHandler(this.conexao_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 391);
            this.Controls.Add(this.conexao);
            this.Controls.Add(this.clearInputDataButton);
            this.Controls.Add(this.registerUserButton);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.confirmPasswordInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmPasswordInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.Button registerUserButton;
        private System.Windows.Forms.Button clearInputDataButton;
        private System.Windows.Forms.Button conexao;
    }
}

