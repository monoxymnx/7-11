using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formLogin
{
    public partial class userForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=344-13;Initial Catalog=7-11;Integrated Security=True;Encrypt=False");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public userForm()
        {
            InitializeComponent();
        }
        private void parameter()
        {
            cmd.Parameters.AddWithValue("ID", t_id.Text);
            cmd.Parameters.AddWithValue("Name", t_name.Text);
            cmd.Parameters.AddWithValue("Lastname", t_last.Text);
            cmd.Parameters.AddWithValue("Email", t_email.Text);
            cmd.Parameters.AddWithValue("Username", t_username.Text);
            cmd.Parameters.AddWithValue("Password", t_password.Text);
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._7_11DataSet);

        }

        private void userForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_7_11DataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this._7_11DataSet.users);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                t_id.Text = row.Cells[0].Value.ToString();
                t_name.Text = row.Cells[1].Value.ToString();
                t_last.Text = row.Cells[2].Value.ToString();
                t_email.Text = row.Cells[3].Value.ToString();
                t_username.Text = row.Cells[4].Value.ToString();
                t_password.Text = row.Cells[5].Value.ToString();
            }
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE users SET userID=@ID,userFname=@Name,userLname=@Lastname, userEmail=@Email ,userName=@Username, userPwD=@Password WHERE userID=@ID", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Updated!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.usersTableAdapter.Fill(this._7_11DataSet.users);
                }
                else
                {
                    MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO users (userID,userFname,userLname,userEmail,userName,userPwD)VALUES(@ID,@Name,@Lastname,@Email,@Username,@Password)", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Insert OK!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.usersTableAdapter.Fill(this._7_11DataSet.users);
                }
                else
                {
                    MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM users WHERE userID=@ID", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Delete!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.usersTableAdapter.Fill(this._7_11DataSet.users);
                }
                else
                {
                    MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }
    }
}
