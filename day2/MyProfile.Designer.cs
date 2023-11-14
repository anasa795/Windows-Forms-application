namespace day2
{
    partial class btn_updProfile
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
            this.btn_update = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgv_postsProfile = new System.Windows.Forms.DataGridView();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_bref = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.cb_catalog = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_chaPass = new System.Windows.Forms.Button();
            this.btn_delProfile = new System.Windows.Forms.Button();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.btn_addPicture = new System.Windows.Forms.Button();
            this.btn_allPosts = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_addCatalog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_postsProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(520, 316);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 0;
            this.btn_update.Text = "Update post";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(439, 316);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Add post";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(601, 316);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgv_postsProfile
            // 
            this.dgv_postsProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_postsProfile.Location = new System.Drawing.Point(319, 12);
            this.dgv_postsProfile.Name = "dgv_postsProfile";
            this.dgv_postsProfile.RowTemplate.Height = 25;
            this.dgv_postsProfile.Size = new System.Drawing.Size(469, 223);
            this.dgv_postsProfile.TabIndex = 3;
            this.dgv_postsProfile.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_postsProfile_RowHeaderMouseDoubleClick);
            // 
            // txt_name
            // 
            this.txt_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_name.Location = new System.Drawing.Point(31, 212);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(139, 23);
            this.txt_name.TabIndex = 8;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(319, 273);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(100, 23);
            this.txt_title.TabIndex = 5;
            // 
            // txt_bref
            // 
            this.txt_bref.Location = new System.Drawing.Point(439, 273);
            this.txt_bref.Name = "txt_bref";
            this.txt_bref.Size = new System.Drawing.Size(100, 23);
            this.txt_bref.TabIndex = 6;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(562, 273);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(100, 23);
            this.txt_desc.TabIndex = 7;
            // 
            // cb_catalog
            // 
            this.cb_catalog.FormattingEnabled = true;
            this.cb_catalog.Location = new System.Drawing.Point(667, 273);
            this.cb_catalog.Name = "cb_catalog";
            this.cb_catalog.Size = new System.Drawing.Size(121, 23);
            this.cb_catalog.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bref";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(667, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Catalog";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Update Profil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_chaPass
            // 
            this.btn_chaPass.Location = new System.Drawing.Point(12, 375);
            this.btn_chaPass.Name = "btn_chaPass";
            this.btn_chaPass.Size = new System.Drawing.Size(139, 23);
            this.btn_chaPass.TabIndex = 16;
            this.btn_chaPass.Text = "Change Password";
            this.btn_chaPass.UseVisualStyleBackColor = true;
            this.btn_chaPass.Click += new System.EventHandler(this.btn_chaPass_Click);
            // 
            // btn_delProfile
            // 
            this.btn_delProfile.Location = new System.Drawing.Point(12, 346);
            this.btn_delProfile.Name = "btn_delProfile";
            this.btn_delProfile.Size = new System.Drawing.Size(139, 23);
            this.btn_delProfile.TabIndex = 17;
            this.btn_delProfile.Text = "Delete Profile";
            this.btn_delProfile.UseVisualStyleBackColor = true;
            this.btn_delProfile.Click += new System.EventHandler(this.btn_delProfile_Click);
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Location = new System.Drawing.Point(12, 6);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(179, 200);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePicture.TabIndex = 18;
            this.ProfilePicture.TabStop = false;
            // 
            // btn_addPicture
            // 
            this.btn_addPicture.Location = new System.Drawing.Point(207, 12);
            this.btn_addPicture.Name = "btn_addPicture";
            this.btn_addPicture.Size = new System.Drawing.Size(92, 23);
            this.btn_addPicture.TabIndex = 19;
            this.btn_addPicture.Text = "Add Picture";
            this.btn_addPicture.UseVisualStyleBackColor = true;
            this.btn_addPicture.Click += new System.EventHandler(this.btn_addPicture_Click);
            // 
            // btn_allPosts
            // 
            this.btn_allPosts.Location = new System.Drawing.Point(667, 403);
            this.btn_allPosts.Name = "btn_allPosts";
            this.btn_allPosts.Size = new System.Drawing.Size(121, 23);
            this.btn_allPosts.TabIndex = 20;
            this.btn_allPosts.Text = "Go to All Posts";
            this.btn_allPosts.UseVisualStyleBackColor = true;
            this.btn_allPosts.Click += new System.EventHandler(this.btn_allPosts_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(12, 404);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(139, 23);
            this.btn_logout.TabIndex = 21;
            this.btn_logout.Text = "Log out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_addCatalog
            // 
            this.btn_addCatalog.Location = new System.Drawing.Point(389, 403);
            this.btn_addCatalog.Name = "btn_addCatalog";
            this.btn_addCatalog.Size = new System.Drawing.Size(106, 23);
            this.btn_addCatalog.TabIndex = 22;
            this.btn_addCatalog.Text = "Add Catalog";
            this.btn_addCatalog.UseVisualStyleBackColor = true;
            this.btn_addCatalog.Click += new System.EventHandler(this.btn_addCatalog_Click);
            // 
            // btn_updProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_addCatalog);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_allPosts);
            this.Controls.Add(this.btn_addPicture);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.btn_delProfile);
            this.Controls.Add(this.btn_chaPass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_catalog);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_bref);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.dgv_postsProfile);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.btn_update);
            this.Name = "btn_updProfile";
            this.Text = "MyProfile";
            this.Load += new System.EventHandler(this.MyProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_postsProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_update;
        private Button add_btn;
        private Button btn_delete;
        private DataGridView dgv_postsProfile;
        private TextBox txt_name;
        private TextBox txt_title;
        private TextBox txt_bref;
        private TextBox txt_desc;
        private ComboBox comboBox1;
        private ComboBox cb_catalog;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button btn_chaPass;
        private Button btn_delProfile;
        private PictureBox ProfilePicture;
        private Button btn_addPicture;
        private Button btn_allPosts;
        private Button btn_logout;
        private Button btn_addCatalog;
    }
}