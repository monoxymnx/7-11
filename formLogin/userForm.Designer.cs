namespace formLogin
{
    partial class userForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._7_11DataSet = new formLogin._7_11DataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new formLogin._7_11DataSetTableAdapters.usersTableAdapter();
            this.tableAdapterManager = new formLogin._7_11DataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPwdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_username = new System.Windows.Forms.TextBox();
            this.t_email = new System.Windows.Forms.TextBox();
            this.t_name = new System.Windows.Forms.TextBox();
            this.t_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_last = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_edit = new System.Windows.Forms.Button();
            this.b_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._7_11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // _7_11DataSet
            // 
            this._7_11DataSet.DataSetName = "_7_11DataSet";
            this._7_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this._7_11DataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.product_typeTableAdapter = null;
            this.tableAdapterManager.Product1TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = formLogin._7_11DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.userFnameDataGridViewTextBoxColumn,
            this.userLnameDataGridViewTextBoxColumn,
            this.userEmailDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.userPwdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 395);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "ไอดี";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // userFnameDataGridViewTextBoxColumn
            // 
            this.userFnameDataGridViewTextBoxColumn.DataPropertyName = "userFname";
            this.userFnameDataGridViewTextBoxColumn.HeaderText = "ชื่อ";
            this.userFnameDataGridViewTextBoxColumn.Name = "userFnameDataGridViewTextBoxColumn";
            // 
            // userLnameDataGridViewTextBoxColumn
            // 
            this.userLnameDataGridViewTextBoxColumn.DataPropertyName = "userLname";
            this.userLnameDataGridViewTextBoxColumn.HeaderText = "นามสกุล";
            this.userLnameDataGridViewTextBoxColumn.Name = "userLnameDataGridViewTextBoxColumn";
            // 
            // userEmailDataGridViewTextBoxColumn
            // 
            this.userEmailDataGridViewTextBoxColumn.DataPropertyName = "userEmail";
            this.userEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.userEmailDataGridViewTextBoxColumn.Name = "userEmailDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "userName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "ชื่อผู้ใช้";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // userPwdDataGridViewTextBoxColumn
            // 
            this.userPwdDataGridViewTextBoxColumn.DataPropertyName = "userPwd";
            this.userPwdDataGridViewTextBoxColumn.HeaderText = "รหัสผ่าน";
            this.userPwdDataGridViewTextBoxColumn.Name = "userPwdDataGridViewTextBoxColumn";
            // 
            // t_username
            // 
            this.t_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.t_username.Location = new System.Drawing.Point(352, 91);
            this.t_username.Name = "t_username";
            this.t_username.Size = new System.Drawing.Size(105, 31);
            this.t_username.TabIndex = 18;
            // 
            // t_email
            // 
            this.t_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.t_email.Location = new System.Drawing.Point(123, 91);
            this.t_email.Name = "t_email";
            this.t_email.Size = new System.Drawing.Size(105, 31);
            this.t_email.TabIndex = 17;
            // 
            // t_name
            // 
            this.t_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.t_name.Location = new System.Drawing.Point(243, 44);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(132, 31);
            this.t_name.TabIndex = 16;
            // 
            // t_id
            // 
            this.t_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.t_id.Location = new System.Drawing.Point(54, 40);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(132, 31);
            this.t_id.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(236, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 39);
            this.label5.TabIndex = 14;
            this.label5.Text = "ชื่อผู้ใช้";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(379, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 39);
            this.label4.TabIndex = 13;
            this.label4.Text = "นามสกุล";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(190, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 39);
            this.label3.TabIndex = 12;
            this.label3.Text = "ชื่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(5, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID";
            // 
            // t_last
            // 
            this.t_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.t_last.Location = new System.Drawing.Point(502, 48);
            this.t_last.Name = "t_last";
            this.t_last.Size = new System.Drawing.Size(105, 31);
            this.t_last.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Email";
            // 
            // t_password
            // 
            this.t_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.t_password.Location = new System.Drawing.Point(588, 91);
            this.t_password.Name = "t_password";
            this.t_password.Size = new System.Drawing.Size(105, 31);
            this.t_password.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(463, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 39);
            this.label6.TabIndex = 21;
            this.label6.Text = "รหัสผ่าน";
            // 
            // b_delete
            // 
            this.b_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.b_delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.b_delete.Location = new System.Drawing.Point(677, 209);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(79, 25);
            this.b_delete.TabIndex = 25;
            this.b_delete.Text = "Delete";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_edit
            // 
            this.b_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.b_edit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.b_edit.Location = new System.Drawing.Point(677, 169);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(79, 25);
            this.b_edit.TabIndex = 24;
            this.b_edit.Text = "Edit";
            this.b_edit.UseVisualStyleBackColor = true;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click);
            // 
            // b_add
            // 
            this.b_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.b_add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.b_add.Location = new System.Drawing.Point(677, 132);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(79, 25);
            this.b_add.TabIndex = 23;
            this.b_add.Text = "Add";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 522);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_edit);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.t_password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.t_last);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_username);
            this.Controls.Add(this.t_email);
            this.Controls.Add(this.t_name);
            this.Controls.Add(this.t_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userForm";
            this.Text = "userForm";
            this.Load += new System.EventHandler(this.userForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._7_11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _7_11DataSet _7_11DataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private _7_11DataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private _7_11DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPwdDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox t_username;
        private System.Windows.Forms.TextBox t_email;
        private System.Windows.Forms.TextBox t_name;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_last;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.Button b_add;
    }
}