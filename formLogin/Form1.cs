using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formLogin
{
    public partial class Form1 : Form
    {
        private object tableAdapterManager;
        private object product_typeBindingSource;

        SqlConnection conn = new SqlConnection("Data Source=344-13;Initial Catalog=7-11;Integrated Security=True;Encrypt=False");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from users where userName = '" + t_username.Text + "' AND userPwd = '" + t_password.Text + "'", conn);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                formMain formMain = new formMain();
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid username or password", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                t_username.Text = string.Empty;
        }

        private void t_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_password_TextChanged(object sender, EventArgs e)
        {
               
        }
    }
}
