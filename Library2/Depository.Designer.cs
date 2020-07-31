namespace Library2
{
    partial class Depository
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
            this.button3 = new System.Windows.Forms.Button();
            this.txtnow = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(53, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 30);
            this.button3.TabIndex = 24;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // txtnow
            // 
            this.txtnow.Location = new System.Drawing.Point(147, 159);
            this.txtnow.Name = "txtnow";
            this.txtnow.Size = new System.Drawing.Size(177, 22);
            this.txtnow.TabIndex = 23;
            this.txtnow.Leave += new System.EventHandler(this.txtnow_Leave);
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(178, 221);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(141, 22);
            this.txtdate.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 220);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "تاریخ برگشت :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 48);
            this.button2.TabIndex = 20;
            this.button2.Text = "ثبت";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 164);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "تاریخ امانت :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "امروز";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(147, 109);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(186, 22);
            this.txtuserid.TabIndex = 17;
            this.txtuserid.Leave += new System.EventHandler(this.txtuserid_Leave);
            // 
            // txtbookid
            // 
            this.txtbookid.Location = new System.Drawing.Point(147, 61);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.Size = new System.Drawing.Size(186, 22);
            this.txtbookid.TabIndex = 16;
            this.txtbookid.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 109);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "شماره کاربر :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 66);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "شماره کتاب :";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(408, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 39);
            this.button4.TabIndex = 25;
            this.button4.Text = "صفحه اصلی";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Depository
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 372);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtnow);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtuserid);
            this.Controls.Add(this.txtbookid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Depository";
            this.Text = "Depository";
            this.Load += new System.EventHandler(this.Depository_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtnow;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.TextBox txtbookid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
    }
}