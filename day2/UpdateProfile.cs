using day2.Models;
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
    public partial class UpdateProfile : Form
    {
        dbContext db;
        public int Profile_id { get; set; }

        Author author;
        public UpdateProfile()
        {
            InitializeComponent();
            db= new dbContext();
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {
            author = db.Author.Where(a => a.Id == Profile_id).FirstOrDefault();
            txt_userName.Text = author.UserName;
            txt_email.Text = author.Email;
            txt_age.Text=author.Age.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            author.UserName= txt_userName.Text;
            author.Email= txt_email.Text;
            author.Age =int.Parse( txt_age.Text);
            txt_age.Text=txt_email.Text=txt_userName.Text="";
            db.SaveChanges();
            this.Hide();
            login login = new login();
            login.ShowDialog();

        }
    }
}
