using day2.Models;

namespace day2
{
    public partial class Form1 : Form
    {
        dbContext db;
        public Form1()
        {
            InitializeComponent();
            db = new dbContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = db.Posts.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Author author= new Author();
            author.UserName=txt_userName.Text;
            author.Age=int.Parse(txt_age.Text);
            author.Email=txt_email.Text;
            author.Password=txt_Password.Text;

            db.Author.Add(author);
            db.SaveChanges();

            txt_userName.Text =txt_age.Text=txt_email.Text=txt_Password.Text= "";

            this.Hide();
            login login= new login();
            login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}