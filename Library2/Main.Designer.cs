namespace Library2
{
    partial class Main
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
            this.btnuser = new System.Windows.Forms.Button();
            this.btnbook = new System.Windows.Forms.Button();
            this.btnloan = new System.Windows.Forms.Button();
            this.btnsetting = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(541, 555);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnuser
            // 
            this.btnuser.Location = new System.Drawing.Point(654, 29);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(197, 93);
            this.btnuser.TabIndex = 2;
            this.btnuser.Text = "کاربران";
            this.btnuser.UseVisualStyleBackColor = true;
            this.btnuser.Click += new System.EventHandler(this.Btnuser_Click);
            // 
            // btnbook
            // 
            this.btnbook.Location = new System.Drawing.Point(654, 181);
            this.btnbook.Name = "btnbook";
            this.btnbook.Size = new System.Drawing.Size(197, 90);
            this.btnbook.TabIndex = 3;
            this.btnbook.Text = "کتاب ها";
            this.btnbook.UseVisualStyleBackColor = true;
            this.btnbook.Click += new System.EventHandler(this.Btnbook_Click);
            // 
            // btnloan
            // 
            this.btnloan.Location = new System.Drawing.Point(654, 302);
            this.btnloan.Name = "btnloan";
            this.btnloan.Size = new System.Drawing.Size(197, 70);
            this.btnloan.TabIndex = 4;
            this.btnloan.Text = "امانت";
            this.btnloan.UseVisualStyleBackColor = true;
            this.btnloan.Click += new System.EventHandler(this.Btnloan_Click);
            // 
            // btnsetting
            // 
            this.btnsetting.Location = new System.Drawing.Point(654, 498);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Size = new System.Drawing.Size(197, 70);
            this.btnsetting.TabIndex = 5;
            this.btnsetting.Text = "تنظیمات";
            this.btnsetting.UseVisualStyleBackColor = true;
            this.btnsetting.Click += new System.EventHandler(this.Btnsetting_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(654, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "مدیریت حساب";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 705);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsetting);
            this.Controls.Add(this.btnloan);
            this.Controls.Add(this.btnbook);
            this.Controls.Add(this.btnuser);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.Button btnbook;
        private System.Windows.Forms.Button btnloan;
        private System.Windows.Forms.Button btnsetting;
        private System.Windows.Forms.Button button2;
    }
}