namespace day2
{
    partial class ChangePassword
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
            this.txt_oldPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_newPass = new System.Windows.Forms.TextBox();
            this.btn_changePass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_oldPass
            // 
            this.txt_oldPass.Location = new System.Drawing.Point(377, 154);
            this.txt_oldPass.Name = "txt_oldPass";
            this.txt_oldPass.Size = new System.Drawing.Size(147, 23);
            this.txt_oldPass.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "New password";
            // 
            // txt_newPass
            // 
            this.txt_newPass.Location = new System.Drawing.Point(377, 202);
            this.txt_newPass.Name = "txt_newPass";
            this.txt_newPass.Size = new System.Drawing.Size(147, 23);
            this.txt_newPass.TabIndex = 2;
            // 
            // btn_changePass
            // 
            this.btn_changePass.Location = new System.Drawing.Point(266, 275);
            this.btn_changePass.Name = "btn_changePass";
            this.btn_changePass.Size = new System.Drawing.Size(125, 23);
            this.btn_changePass.TabIndex = 4;
            this.btn_changePass.Text = "Change Password";
            this.btn_changePass.UseVisualStyleBackColor = true;
            this.btn_changePass.Click += new System.EventHandler(this.btn_changePass_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_changePass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_newPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_oldPass);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_oldPass;
        private Label label1;
        private Label label2;
        private TextBox txt_newPass;
        private Button btn_changePass;
    }
}