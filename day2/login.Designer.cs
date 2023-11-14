namespace day2
{
    partial class login
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
            this.login_btn = new System.Windows.Forms.Button();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_wrongPass = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(384, 185);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "Log in";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(335, 87);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(192, 23);
            this.txt_userName.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(335, 128);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(192, 23);
            this.txt_password.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // lab_wrongPass
            // 
            this.lab_wrongPass.AutoSize = true;
            this.lab_wrongPass.ForeColor = System.Drawing.Color.IndianRed;
            this.lab_wrongPass.Location = new System.Drawing.Point(368, 159);
            this.lab_wrongPass.Name = "lab_wrongPass";
            this.lab_wrongPass.Size = new System.Drawing.Size(0, 15);
            this.lab_wrongPass.TabIndex = 5;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(303, 185);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lab_wrongPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.login_btn);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button login_btn;
        private TextBox txt_userName;
        private TextBox txt_password;
        private Label label1;
        private Label label2;
        private Label lab_wrongPass;
        private Button btn_Close;
    }
}