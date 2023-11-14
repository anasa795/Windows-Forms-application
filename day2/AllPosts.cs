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
    public partial class AllPosts : Form
    {
        public int user_id { get; set; }
        dbContext db;
        public AllPosts()
        {
            InitializeComponent();
            db=new dbContext();
        }

        private void AllPosts_Load(object sender, EventArgs e)
        {

            dgv_AllPosts.DataSource = db.Posts.Select(p => new { Author = p.Author.UserName, Description = p.Description, Date = p.date, Time = p.time.HasValue ? p.time.Value.ToString("HH:mm") : null }).ToList();
        }
        private void myPostsBtn_Click(object sender, EventArgs e)
        {
            dgv_AllPosts.DataSource = db.Posts.Where(p => p.AuthorId == user_id).Select(p => new { Author = p.Author.UserName, Description = p.Description, Time = p.time.HasValue ? p.time.Value.ToString("HH:mm") : null }).ToList();
        }

        private void myProfileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            btn_updProfile myProfile = new btn_updProfile();
            myProfile.Profile_id = user_id;

            myProfile.ShowDialog();
        }
    }
}
