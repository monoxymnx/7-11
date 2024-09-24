using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formLogin
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormProduct product = new FormProduct();
            product.MdiParent = this;
            product.Dock = DockStyle.Fill;
            product.Show();
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormSale sale = new FormSale();
            sale.MdiParent = this;
            sale.Dock = DockStyle.Fill;
            sale.Show();
        }

        private void producttypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            productType ProductType = new productType();
            ProductType.MdiParent = this;
            ProductType.Dock = DockStyle.Fill;
            ProductType.Show();
        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            userForm UserForm = new userForm();
            UserForm.MdiParent = this;
            UserForm.Dock = DockStyle.Fill;
            UserForm.Show();
        }
    }
}
