namespace formLogin
{
    partial class FormSale
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAmoung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.la_change = new System.Windows.Forms.Label();
            this.la_recive = new System.Windows.Forms.Label();
            this.la_total = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.b_Sale = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b_Dot = new System.Windows.Forms.Button();
            this.b_Clear = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.la_amount = new System.Windows.Forms.Label();
            this.la_product = new System.Windows.Forms.Label();
            this.tID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nu_count = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_count)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.pName,
            this.pAmoung,
            this.pPrice,
            this.total});
            this.dataGridView1.Location = new System.Drawing.Point(32, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 215);
            this.dataGridView1.TabIndex = 91;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "pID";
            this.Column1.HeaderText = "รหัส";
            this.Column1.Name = "Column1";
            // 
            // pName
            // 
            this.pName.DataPropertyName = "pName";
            this.pName.HeaderText = "รายการสินค้า";
            this.pName.Name = "pName";
            // 
            // pAmoung
            // 
            this.pAmoung.DataPropertyName = "pAmoung";
            this.pAmoung.HeaderText = "จำนวน";
            this.pAmoung.Name = "pAmoung";
            // 
            // pPrice
            // 
            this.pPrice.DataPropertyName = "pPrice";
            this.pPrice.HeaderText = "ราคา";
            this.pPrice.Name = "pPrice";
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "รวม";
            this.total.Name = "total";
            // 
            // la_change
            // 
            this.la_change.AutoSize = true;
            this.la_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_change.ForeColor = System.Drawing.Color.Tomato;
            this.la_change.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.la_change.Location = new System.Drawing.Point(466, 505);
            this.la_change.Name = "la_change";
            this.la_change.Size = new System.Drawing.Size(40, 25);
            this.la_change.TabIndex = 90;
            this.la_change.Text = "....";
            // 
            // la_recive
            // 
            this.la_recive.AutoSize = true;
            this.la_recive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_recive.ForeColor = System.Drawing.Color.Tomato;
            this.la_recive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.la_recive.Location = new System.Drawing.Point(466, 480);
            this.la_recive.Name = "la_recive";
            this.la_recive.Size = new System.Drawing.Size(40, 25);
            this.la_recive.TabIndex = 89;
            this.la_recive.Text = "....";
            // 
            // la_total
            // 
            this.la_total.AutoSize = true;
            this.la_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_total.ForeColor = System.Drawing.Color.Tomato;
            this.la_total.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.la_total.Location = new System.Drawing.Point(466, 455);
            this.la_total.Name = "la_total";
            this.la_total.Size = new System.Drawing.Size(40, 25);
            this.la_total.TabIndex = 88;
            this.la_total.Text = "....";
            this.la_total.Click += new System.EventHandler(this.la_total_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Tomato;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(387, 505);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 25);
            this.label10.TabIndex = 87;
            this.label10.Text = "เงินทอน";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Tomato;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(387, 480);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 25);
            this.label9.TabIndex = 86;
            this.label9.Text = "รับเงิน";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Tomato;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(387, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 25);
            this.label8.TabIndex = 85;
            this.label8.Text = "รวม";
            // 
            // b_Sale
            // 
            this.b_Sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Sale.Location = new System.Drawing.Point(581, 409);
            this.b_Sale.Name = "b_Sale";
            this.b_Sale.Size = new System.Drawing.Size(180, 41);
            this.b_Sale.TabIndex = 84;
            this.b_Sale.Text = "sale";
            this.b_Sale.UseVisualStyleBackColor = true;
            this.b_Sale.Click += new System.EventHandler(this.b_Sale_Click_1);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.Location = new System.Drawing.Point(705, 362);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(56, 41);
            this.b0.TabIndex = 83;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click_1);
            // 
            // b_Dot
            // 
            this.b_Dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Dot.Location = new System.Drawing.Point(643, 362);
            this.b_Dot.Name = "b_Dot";
            this.b_Dot.Size = new System.Drawing.Size(56, 41);
            this.b_Dot.TabIndex = 82;
            this.b_Dot.UseVisualStyleBackColor = true;
            this.b_Dot.Click += new System.EventHandler(this.b_Dot_Click_1);
            // 
            // b_Clear
            // 
            this.b_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Clear.Location = new System.Drawing.Point(581, 362);
            this.b_Clear.Name = "b_Clear";
            this.b_Clear.Size = new System.Drawing.Size(56, 41);
            this.b_Clear.TabIndex = 81;
            this.b_Clear.Text = "C";
            this.b_Clear.UseVisualStyleBackColor = true;
            this.b_Clear.Click += new System.EventHandler(this.b_Clear_Click_1);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Location = new System.Drawing.Point(705, 315);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(56, 41);
            this.b9.TabIndex = 80;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click_1);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(643, 315);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(56, 41);
            this.b8.TabIndex = 79;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click_1);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(581, 315);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(56, 41);
            this.b7.TabIndex = 78;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click_1);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Location = new System.Drawing.Point(705, 268);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(56, 41);
            this.b6.TabIndex = 77;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click_1);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(643, 268);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(56, 41);
            this.b5.TabIndex = 76;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click_1);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(581, 268);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(56, 41);
            this.b4.TabIndex = 75;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click_1);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(705, 221);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(56, 41);
            this.b3.TabIndex = 74;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click_1);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(643, 221);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(56, 41);
            this.b2.TabIndex = 73;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click_1);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(581, 221);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(56, 41);
            this.b1.TabIndex = 72;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click_1);
            // 
            // bOk
            // 
            this.bOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOk.Location = new System.Drawing.Point(568, 171);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(56, 32);
            this.bOk.TabIndex = 71;
            this.bOk.Text = "ok";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click_1);
            // 
            // la_amount
            // 
            this.la_amount.AutoSize = true;
            this.la_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_amount.ForeColor = System.Drawing.Color.Tomato;
            this.la_amount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.la_amount.Location = new System.Drawing.Point(489, 171);
            this.la_amount.Name = "la_amount";
            this.la_amount.Size = new System.Drawing.Size(68, 31);
            this.la_amount.TabIndex = 70;
            this.la_amount.Text = "......";
            // 
            // la_product
            // 
            this.la_product.AutoSize = true;
            this.la_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_product.ForeColor = System.Drawing.Color.Tomato;
            this.la_product.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.la_product.Location = new System.Drawing.Point(187, 170);
            this.la_product.Name = "la_product";
            this.la_product.Size = new System.Drawing.Size(68, 31);
            this.la_product.TabIndex = 69;
            this.la_product.Text = "......";
            // 
            // tID
            // 
            this.tID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tID.Location = new System.Drawing.Point(163, 102);
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(100, 38);
            this.tID.TabIndex = 68;
            this.tID.TextChanged += new System.EventHandler(this.tID_TextChanged);
            this.tID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tID_KeyDown);
            this.tID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tID_KeyUp_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(396, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 31);
            this.label5.TabIndex = 67;
            this.label5.Text = "จำนวน";
            // 
            // nu_count
            // 
            this.nu_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nu_count.Location = new System.Drawing.Point(484, 102);
            this.nu_count.Name = "nu_count";
            this.nu_count.Size = new System.Drawing.Size(35, 38);
            this.nu_count.TabIndex = 66;
            this.nu_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nu_count.ValueChanged += new System.EventHandler(this.nu_count_ValueChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(394, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 31);
            this.label4.TabIndex = 65;
            this.label4.Text = "จำนวน";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(26, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 31);
            this.label3.TabIndex = 64;
            this.label3.Text = "รายการสินค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(44, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 31);
            this.label2.TabIndex = 62;
            this.label2.Text = "รหัสสินค้า";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 85);
            this.panel1.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(98, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sale";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::formLogin.Properties.Resources._7_11;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.la_change);
            this.Controls.Add(this.la_recive);
            this.Controls.Add(this.la_total);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.b_Sale);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b_Dot);
            this.Controls.Add(this.b_Clear);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.la_amount);
            this.Controls.Add(this.la_product);
            this.Controls.Add(this.tID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nu_count);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSale";
            this.Text = "FormSale";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_count)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAmoung;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label la_change;
        private System.Windows.Forms.Label la_recive;
        private System.Windows.Forms.Label la_total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button b_Sale;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b_Dot;
        private System.Windows.Forms.Button b_Clear;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Label la_amount;
        private System.Windows.Forms.Label la_product;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nu_count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}