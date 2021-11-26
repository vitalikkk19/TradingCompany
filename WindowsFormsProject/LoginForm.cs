using BusinessLogic.Concrete;
using DAL.ADO;
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsProject
{
    public partial class LoginForm : Form
    {
        static string connStr = ConfigurationManager.ConnectionStrings["TraidingCompany"].ConnectionString;
        static public PersonDAL pd = new PersonDAL(connStr);
        public AuthManager _authManager = new AuthManager(pd);
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginIn_Click(object sender, EventArgs e)
        {
            string loginUs = textBoxLoginUs.Text;
            string passUs = textBoxPassUs.Text;
            bool p = _authManager.Login(loginUs, passUs);

            if (p == true)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No access!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }


        }

        Point lastPoint;
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.Show();
        }
    }
}
