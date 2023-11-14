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
    public partial class AddCatalog : Form
    {
        dbContext db;
        public int user_id;
        public AddCatalog()
        {
            InitializeComponent();
            db = new dbContext();
        }

        private void btn_addCatalog_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Name=txt_name.Text;
            catalog.Description=txt_desc.Text;

            db.Catalog.Add(catalog);
            db.SaveChanges();

            txt_desc.Text=txt_name.Text="";

            btn_updProfile myProfil= new btn_updProfile();
            myProfil.Profile_id = user_id;

            MessageBox.Show("Catalog has been Added");

            this.Hide();
            myProfil.ShowDialog();
        }
    }
}
