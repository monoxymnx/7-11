namespace formLogin
{
    partial class productType
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
            this.product_typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_typeTableAdapter = new formLogin._7_11DataSetTableAdapters.product_typeTableAdapter();
            this.tableAdapterManager = new formLogin._7_11DataSetTableAdapters.TableAdapterManager();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_edit = new System.Windows.Forms.Button();
            this.b_add = new System.Windows.Forms.Button();
            this.t_name = new System.Windows.Forms.TextBox();
            this.t_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._7_11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // _7_11DataSet
            // 
            this._7_11DataSet.DataSetName = "_7_11DataSet";
            this._7_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product_typeBindingSource
            // 
            this.product_typeBindingSource.DataMember = "product_type";
            this.product_typeBindingSource.DataSource = this._7_11DataSet;
            // 
            // product_typeTableAdapter
            // 
            this.product_typeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.product_typeTableAdapter = this.product_typeTableAdapter;
            this.tableAdapterManager.Product1TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = formLogin._7_11DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // b_delete
            // 
            this.b_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.b_delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.b_delete.Location = new System.Drawing.Point(677, 96);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(79, 25);
            this.b_delete.TabIndex = 22;
            this.b_delete.Text = "Delete";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click_1);
            // 
            // b_edit
            // 
            this.b_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.b_edit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.b_edit.Location = new System.Drawing.Point(677, 65);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(79, 25);
            this.b_edit.TabIndex = 21;
            this.b_edit.Text = "Edit";
            this.b_edit.UseVisualStyleBackColor = true;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click_1);
            // 
            // b_add
            // 
            this.b_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.b_add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.b_add.Location = new System.Drawing.Point(677, 28);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(79, 25);
            this.b_add.TabIndex = 20;
            this.b_add.Text = "Add";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // t_name
            // 
            this.t_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.t_name.Location = new System.Drawing.Point(300, 53);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(132, 31);
            this.t_name.TabIndex = 19;
            // 
            // t_ID
            // 
            this.t_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.t_ID.Location = new System.Drawing.Point(55, 53);
            this.t_ID.Name = "t_ID";
            this.t_ID.Size = new System.Drawing.Size(132, 31);
            this.t_ID.TabIndex = 18;
            this.t_ID.TextChanged += new System.EventHandler(this.t_ID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(191, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 39);
            this.label3.TabIndex = 17;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 39);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIDDataGridViewTextBoxColumn,
            this.tNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.product_typeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 395);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tIDDataGridViewTextBoxColumn
            // 
            this.tIDDataGridViewTextBoxColumn.DataPropertyName = "tID";
            this.tIDDataGridViewTextBoxColumn.HeaderText = "รหัสหมวดหมู่";
            this.tIDDataGridViewTextBoxColumn.Name = "tIDDataGridViewTextBoxColumn";
            // 
            // tNameDataGridViewTextBoxColumn
            // 
            this.tNameDataGridViewTextBoxColumn.DataPropertyName = "tName";
            this.tNameDataGridViewTextBoxColumn.HeaderText = "ชื่อ";
            this.tNameDataGridViewTextBoxColumn.Name = "tNameDataGridViewTextBoxColumn";
            // 
            // productType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 522);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_edit);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.t_name);
            this.Controls.Add(this.t_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "productType";
            this.Text = "productType";
            this.Load += new System.EventHandler(this.productType_Load);
            ((System.ComponentModel.ISupportInitialize)(this._7_11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _7_11DataSet _7_11DataSet;
        private System.Windows.Forms.BindingSource product_typeBindingSource;
        private _7_11DataSetTableAdapters.product_typeTableAdapter product_typeTableAdapter;
        private _7_11DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.TextBox t_name;
        private System.Windows.Forms.TextBox t_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNameDataGridViewTextBoxColumn;
    }
}