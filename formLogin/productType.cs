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
    public partial class productType : Form
    {
        public productType()
        {
            InitializeComponent();
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
    }
}
