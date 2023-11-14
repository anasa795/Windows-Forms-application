namespace day2
{
    partial class UpdateProfile
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
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(358, 129);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(170, 23);
            this.txt_userName.TabIndex = 0;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(358, 212);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(170, 23);
            this.txt_email.TabIndex = 1;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(358, 173);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(170, 23);
            this.txt_age.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(285, 271);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // UpdateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_userName);
            this.Name = "UpdateProfile";
            this.Text = "UpdateProfile";
            this.Load += new System.EventHandler(this.UpdateProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_userName;
        private TextBox txt_email;
        private TextBox txt_age;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_update;
    }
}