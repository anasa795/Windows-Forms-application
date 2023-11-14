using day2.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day2
{
    public partial class btn_updProfile : Form
    {

        dbContext db;
        public int Profile_id { get; set; }
        Author author;
        public btn_updProfile()
        {
            InitializeComponent();
            db = new dbContext();
        }

        private void MyProfile_Load(object sender, EventArgs e)
        {
             author =db.Author.Where(a=>a.Id== Profile_id).FirstOrDefault();

            txt_name.Text = author.UserName;
            txt_name.ReadOnly= true;
            dgv_postsProfile.DataSource = db.Posts.Where(p => p.AuthorId == Profile_id).Select(p => new { Id = p.Id, Author = p.Author.UserName, Description = p.Description, Date = p.date }).ToList();
            cb_catalog.DataSource=db.Catalog.ToList();
            cb_catalog.ValueMember ="Id";
            cb_catalog.DisplayMember= "Name";
            DisplayImage(author.Photo);

            if(author.Photo != null)
            {
                btn_addPicture.Text = "Update Picture";
            }

            add_btn.Visible = true;
            btn_update.Visible = false;
            btn_delete.Visible = false;

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Post post= new Post();
            post.Title=txt_title.Text;
            post.Bref=txt_bref.Text;
            post.Description=txt_desc.Text;
            post.time=DateTime.Now;
            post.date=DateTime.Now;
            post.AuthorId=Profile_id;
            post.Cat_Id =(int)cb_catalog.SelectedValue;
            db.Posts.Add(post);
            db.SaveChanges();
            txt_bref.Text = txt_desc.Text = txt_title.Text = "";
            dgv_postsProfile.DataSource = db.Posts.Where(p => p.AuthorId == Profile_id).Select(p => new {Id=p.Id, Author = p.Author.UserName, Description = p.Description, Date = p.date }).ToList();


        }
        int id;
        private void dgv_postsProfile_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_postsProfile.SelectedRows[0].Cells[0].Value;

            var p = db.Posts.Where(p=>p.Id== id).FirstOrDefault();

            txt_title.Text = p.Title;
            txt_bref.Text=p.Bref;
            txt_desc.Text = p.Description;
            cb_catalog.SelectedValue = p.Cat_Id;

            add_btn.Visible = false;
            btn_update.Visible = true;
            btn_delete.Visible = true;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Post post = db.Posts.Where(p => p.Id == id).FirstOrDefault();
            post.Id = id;
            post.Title = txt_title.Text;
            post.Bref = txt_bref.Text;
            post.Description = txt_desc.Text;
            post.time = DateTime.Now;
            post.date = DateTime.Now;
            post.AuthorId = Profile_id;
            post.Cat_Id = (int)cb_catalog.SelectedValue;
            db.SaveChanges();
            txt_bref.Text = txt_desc.Text = txt_title.Text = "";
            dgv_postsProfile.DataSource = db.Posts.Where(p => p.AuthorId == Profile_id).Select(p => new { Id = p.Id, Author = p.Author.UserName, Description = p.Description, Date = p.date }).ToList();

            add_btn.Visible = true;
            btn_update.Visible = false;
            btn_delete.Visible = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Post post = db.Posts.Where(p => p.Id == id).FirstOrDefault();
            db.Posts.Remove(post);
            db.SaveChanges();
            txt_bref.Text = txt_desc.Text = txt_title.Text = "";
            dgv_postsProfile.DataSource = db.Posts.Where(p => p.AuthorId == Profile_id).Select(p => new { Id = p.Id, Author = p.Author.UserName, Description = p.Description, Date = p.date }).ToList();

            add_btn.Visible = true;
            btn_update.Visible = false;
            btn_delete.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateProfile updateProfile=new UpdateProfile();
            updateProfile.Profile_id=author.Id;
            this.Hide();
            updateProfile.ShowDialog();
        }

        private void btn_delProfile_Click(object sender, EventArgs e)
        {
           var author= db.Author.Where(a => a.Id == Profile_id).FirstOrDefault();
            login login=new login();
            DialogResult result = MessageBox.Show("Are you sure", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
            db.Author.Remove(author);
            }
            db.SaveChanges();
            this.Hide();
            login.ShowDialog();
        }

        private void btn_chaPass_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Profile_id = author.Id;
            this.Hide();
            changePassword.ShowDialog();
        }

        void DisplayImage(byte[] imageData)
        {

            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream stream = new MemoryStream(imageData))
                {
                    // Create a Bitmap object from the binary image data.
                    Bitmap image = new Bitmap(stream);

                    // Display the image in the PictureBox control.
                    ProfilePicture.Image = image;
                }
            }
          

        }
        private void btn_addPicture_Click(object sender, EventArgs e)
        {
            var author = db.Author.Where(a => a.Id == Profile_id).FirstOrDefault();

           
                // Load the image file from the file system.
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    // Read the image file into a byte array.
                    byte[] imageData = File.ReadAllBytes(imagePath);

                    // Create a new Photo object and set its properties.

                    DisplayImage(imageData);

                    author.Photo = imageData;
                    

                    // Add the newPhoto to the database and save changes.
                    //db.Author.Add(author);
                    db.SaveChanges();

                    MessageBox.Show("Image inserted successfully.");


           
            }
            
        }

        private void btn_allPosts_Click(object sender, EventArgs e)
        {
            AllPosts allPosts=new AllPosts();
            this.Hide();
            allPosts.user_id = Profile_id;

            allPosts.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            login login=new login();
            this.Hide();
            login.ShowDialog(); 
        }

        private void btn_addCatalog_Click(object sender, EventArgs e)
        {
            AddCatalog catalog = new AddCatalog();    
            catalog.user_id= Profile_id;
            this.Hide();
            catalog.ShowDialog();
        }
    }
}
