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
    public partial class FormProduct : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=344-13;Initial Catalog=7-11;Integrated Security=True;Encrypt=False");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public FormProduct()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void parameter()
        {
            cmd.Parameters.AddWithValue("id", t_ID.Text);
            cmd.Parameters.AddWithValue("name", t_name.Text);
            cmd.Parameters.AddWithValue("price", t_price.Text);
            cmd.Parameters.AddWithValue("amount", t_amount.Text);
            cmd.Parameters.AddWithValue("type", t_type.Text);
            cmd.Parameters.AddWithValue("search",t_search.Text);
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_7_11DataSet.Product1' table. You can move, or remove it, as needed.
            this.product1TableAdapter.Fill(this._7_11DataSet.Product1);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
                t_ID.Text = row.Cells[0].Value.ToString();
                t_name.Text = row.Cells[1].Value.ToString();
                t_price.Text = row.Cells[2].Value.ToString();
                t_amount.Text = row.Cells[3].Value.ToString();
                t_type.Text = row.Cells[4].Value.ToString();
            }
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE Product1 SET pName=@name,pPrice=@price,pAmoung=@amount WHERE pID=@id", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Updated!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.product1TableAdapter.Fill(this._7_11DataSet.Product1);
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
                cmd = new SqlCommand("INSERT INTO Product1 (pID,pName,pPrice,pAmoung,tID)VALUES(@id,@name,@price,@amount,@type)", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Insert OK!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.product1TableAdapter.Fill(this._7_11DataSet.Product1);
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
                cmd = new SqlCommand("DELETE FROM Product1 WHERE pID=@id", conn);
                parameter();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Delete!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.product1TableAdapter.Fill(this._7_11DataSet.Product1);
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

        private void b_search_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Product1 WHERE pID LIKE @search+'%' OR pName LIKE @search+'%' OR pPrice LIKE @search+'%' OR pAmoung LIKE @search+'%'", conn);
                parameter();
                conn.Open();
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("No data ", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }
    }
}
