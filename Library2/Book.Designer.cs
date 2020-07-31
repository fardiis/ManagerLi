namespace Library2
{
    partial class Book
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
            this.btnadd = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btngroup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(545, 608);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(631, 12);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(186, 65);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "اضافه";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.Btnadd_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(631, 386);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(243, 180);
            this.treeView1.TabIndex = 5;
            // 
            // txtsearch
            // 
            this.txtsearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtsearch.Location = new System.Drawing.Point(631, 282);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(204, 22);
            this.txtsearch.TabIndex = 6;
            this.txtsearch.Text = "search";
            this.txtsearch.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(631, 102);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(186, 65);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "حذف";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(631, 193);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(186, 65);
            this.btnedit.TabIndex = 8;
            this.btnedit.Text = "ویرایش";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.Btnedit_Click);
            // 
            // btngroup
            // 
            this.btngroup.Location = new System.Drawing.Point(751, 601);
            this.btngroup.Name = "btngroup";
            this.btngroup.Size = new System.Drawing.Size(121, 59);
            this.btngroup.TabIndex = 9;
            this.btngroup.Text = "دسته ها";
            this.btngroup.UseVisualStyleBackColor = true;
            this.btngroup.Click += new System.EventHandler(this.Btngroup_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 59);
            this.button1.TabIndex = 10;
            this.button1.Text = "بازسازی";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.radioButton1.Location = new System.Drawing.Point(757, 322);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(66, 21);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "نام کتاب";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(751, 359);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton2.Size = new System.Drawing.Size(76, 21);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.Text = "نام نویسنده";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(613, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "صفحه اصلی";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 707);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btngroup);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Book";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btngroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button2;
    }
}