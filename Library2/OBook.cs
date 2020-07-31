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
    public partial class OBook : Form
    {
        public OBook()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        private void AddBook_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.Select("select *from tbl_type");
            dataGridView1.DataSource = dt;
           

        }

        private void Btnsabt_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (this.Text == "Add")
            {
              
                id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                if (db.Exe("insert into tbl_book(name,writer,type) values (N'" + txtname.Text + "',N'" + txtwriter.Text + "','" + id + "')") == true) 
                {
                    txtname.Text = txtwriter.Text = "";
                }
            }

            else
            {
               
                id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                if (db.Exe("update tbl_book set name = N'" + txtname.Text + "',writer = N'" + txtwriter.Text + "' , type = '" + id + "'where id ='" + int.Parse(txtid.Text) + "'") == true)
                {
                    txtname.Text = txtwriter.Text = txtid.Text = "";
                }

            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txtid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
