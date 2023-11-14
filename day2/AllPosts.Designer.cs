namespace day2
{
    partial class AllPosts
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
            this.myPostsBtn = new System.Windows.Forms.Button();
            this.dgv_AllPosts = new System.Windows.Forms.DataGridView();
            this.myProfileBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllPosts)).BeginInit();
            this.SuspendLayout();
            // 
            // myPostsBtn
            // 
            this.myPostsBtn.Location = new System.Drawing.Point(313, 354);
            this.myPostsBtn.Name = "myPostsBtn";
            this.myPostsBtn.Size = new System.Drawing.Size(75, 23);
            this.myPostsBtn.TabIndex = 0;
            this.myPostsBtn.Text = "My Posts";
            this.myPostsBtn.UseVisualStyleBackColor = true;
            this.myPostsBtn.Click += new System.EventHandler(this.myPostsBtn_Click);
            // 
            // dgv_AllPosts
            // 
            this.dgv_AllPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllPosts.Location = new System.Drawing.Point(12, 12);
            this.dgv_AllPosts.Name = "dgv_AllPosts";
            this.dgv_AllPosts.RowTemplate.Height = 25;
            this.dgv_AllPosts.Size = new System.Drawing.Size(776, 232);
            this.dgv_AllPosts.TabIndex = 1;
            // 
            // myProfileBtn
            // 
            this.myProfileBtn.Location = new System.Drawing.Point(427, 354);
            this.myProfileBtn.Name = "myProfileBtn";
            this.myProfileBtn.Size = new System.Drawing.Size(75, 23);
            this.myProfileBtn.TabIndex = 2;
            this.myProfileBtn.Text = "My Proile";
            this.myProfileBtn.UseVisualStyleBackColor = true;
            this.myProfileBtn.Click += new System.EventHandler(this.myProfileBtn_Click);
            // 
            // AllPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myProfileBtn);
            this.Controls.Add(this.dgv_AllPosts);
            this.Controls.Add(this.myPostsBtn);
            this.Name = "AllPosts";
            this.Text = "AllPosts";
            this.Load += new System.EventHandler(this.AllPosts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllPosts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button myPostsBtn;
        private DataGridView dgv_AllPosts;
        private Button myProfileBtn;
    }
}