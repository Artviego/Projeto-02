namespace WinFormsApp1
{
    partial class FormLogin
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            btnLogin = new Button();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkRed;
            label2.Font = new Font("Rede Globo", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(80, 90);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 4;
            label2.Text = "Faith No More";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkRed;
            label1.Font = new Font("Rede Globo", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(80, 42);
            label1.Name = "label1";
            label1.Size = new Size(103, 48);
            label1.TabIndex = 3;
            label1.Text = "FNM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 148);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 183);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 223);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 7;
            label5.Text = "Senha";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(71, 145);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(148, 23);
            txtNome.TabIndex = 8;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(71, 220);
            txtSenha.MaxLength = 8;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(127, 23);
            txtSenha.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(71, 180);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(148, 23);
            txtEmail.TabIndex = 10;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.IndianRed;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(92, 294);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "ENTRAR";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Location = new Point(-7, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 127);
            panel1.TabIndex = 12;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(150, 334);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(57, 15);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cadastrar";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 334);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 14;
            label6.Text = "Não possui login?";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 368);
            Controls.Add(label6);
            Controls.Add(linkLabel1);
            Controls.Add(btnLogin);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNome;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Button btnLogin;
        private Panel panel1;
        private LinkLabel linkLabel1;
        private Label label6;
    }
}