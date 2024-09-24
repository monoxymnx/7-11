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
    public partial class userForm : Form
    {
        public userForm()
        {
            InitializeComponent();
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
    }
}
