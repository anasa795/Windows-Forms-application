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
    public partial class ChangePassword : Form
    {
        dbContext db;
        public int Profile_id { get; set; }
        public ChangePassword()
        {
            InitializeComponent();
            db=new dbContext();
        }

        private void btn_changePass_Click(object sender, EventArgs e)
        {
            Author author=db.Author.Where(a=>a.Id==Profile_id).FirstOrDefault();
            if (txt_oldPass.Text == author.Password)
            {
                author.Password = txt_newPass.Text;
                login login= new login();
                db.SaveChanges();
                this.Hide();
                login.ShowDialog();
            }

        }
    }
}
