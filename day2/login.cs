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
    public partial class login : Form
    {
        dbContext db;
      public int id_user;
        public login()
        {
            InitializeComponent();
            db = new dbContext();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string EmailUser=txt_userName.Text;
            string password=txt_password.Text;

            var user=db.Author?.Where(a=> a.Email == EmailUser).FirstOrDefault();
            var passUser=user?.Password.ToString();

           
            //MessageBox.Show(id_user.ToString());
            if (user != null)
            {
                if (password==passUser)
                {
                    this.Hide();
                    //AllPosts allPosts= new AllPosts();
                    AllPosts allposts = new AllPosts();

                    allposts.user_id = user.Id;

                    allposts.ShowDialog();
                }
                else
                {
                    lab_wrongPass.Text = "wrong password";
                }
            }

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
