namespace day2
{
    partial class AddCatalog
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
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addCatalog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(314, 122);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(179, 23);
            this.txt_desc.TabIndex = 0;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(314, 82);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(179, 23);
            this.txt_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Catalog Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Catalog Description";
            // 
            // btn_addCatalog
            // 
            this.btn_addCatalog.Location = new System.Drawing.Point(178, 178);
            this.btn_addCatalog.Name = "btn_addCatalog";
            this.btn_addCatalog.Size = new System.Drawing.Size(111, 23);
            this.btn_addCatalog.TabIndex = 4;
            this.btn_addCatalog.Text = "Add Catalog";
            this.btn_addCatalog.UseVisualStyleBackColor = true;
            this.btn_addCatalog.Click += new System.EventHandler(this.btn_addCatalog_Click);
            // 
            // AddCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_addCatalog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_desc);
            this.Name = "AddCatalog";
            this.Text = "AddCatalog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_desc;
        private TextBox txt_name;
        private Label label1;
        private Label label2;
        private Button btn_addCatalog;
    }
}