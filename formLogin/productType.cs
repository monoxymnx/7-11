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
    public partial class productType : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=344-13;Initial Catalog=7-11;Integrated Security=True;Encrypt=False");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public productType()
        {
            InitializeComponent();
        }

        private void parameter()
        {
            cmd.Parameters.AddWithValue("tID", t_ID.Text);
            cmd.Parameters.AddWithValue("tName", t_name.Text);
        }

        private void product_typeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.product_typeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._7_11DataSet);

        }

        private void productType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_7_11DataSet.product_type' table. You can move, or remove it, as needed.
            this.product_typeTableAdapter.Fill(this._7_11DataSet.product_type);

        }

        private void b_add_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO product_type (tID,tName)VALUES(@tID,@tName)", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Insert OK!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.product_typeTableAdapter.Fill(this._7_11DataSet.product_type);
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

        private void b_edit_Click_1(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE product_type SET tName=@tName WHERE tID=@tID", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Updated!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.product_typeTableAdapter.Fill(this._7_11DataSet.product_type);
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

        private void b_delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM product_type WHERE tID=@tID", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Delete!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.product_typeTableAdapter.Fill(this._7_11DataSet.product_type);
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

        private void t_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                t_ID.Text = row.Cells[0].Value.ToString();
                t_name.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
