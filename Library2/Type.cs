using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library2
{
    public partial class Type : Form
    {
        public Type()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        private void Type_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
           dt=
                db.Select("select * from tbl_type");
            dataGridView1.DataSource = dt;
        }
       

        private void Btnadd_Click(object sender, EventArgs e)
        {
            if (db.Exe("insert tbl_type(type) values (N'" + txtname.Text + "')") == true)

                txtname.Text = "";

            
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.Select("select * from tbl_book where type=" + textBox2.Text);
            if (dt.Rows.Count == 0)
            {
                if (db.Exe("delete from tbl_type where id =" + textBox2.Text))
                {
                    Type_Load(sender, e);
                   textBox2.Text = "";
                }
            }
            else
                MessageBox.Show(".دسته ای مورد نظر قابل حذف نیست", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
    }

