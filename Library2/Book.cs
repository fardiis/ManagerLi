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
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        private void Btngroup_Click(object sender, EventArgs e)
        {
            Type type = new Type();
            type.ShowDialog();
            this.Hide();
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            OBook addBook = new OBook();
            addBook.Text = "Add";
            addBook.ShowDialog();
            this.Hide();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            //int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //if (db.Exe("delete from tbl_book where id=" + id) == true)
            int id;
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            dt = db.Select("select * from tbl_depository where idbook=" + id);
            if (dt.Rows.Count == 0)
            {
                if (db.Exe("delete from tbl_book where id = " + id) == true)

                    Book_Load(sender, e);
            }
            else
                MessageBox.Show(".کتاب مورد نظر در امانت است", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

           
               
            
        

        private void Book_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            dt = db.Select("select tbl_book.id,tbl_book.name,tbl_book.writer,tbl_type.type from tbl_book inner join tbl_type on tbl_book.type=tbl_type.id");
            dataGridView1.DataSource = dt;
            //----------------------------
          
            dt2 = db.Select("select *from tbl_type");
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                treeView1.Nodes.Add(dt2.Rows[i].ItemArray[1].ToString());
            }

            dt2.Reset();
           
            //dt = db.Select("select *from tbl_book");
            //int id = 0;
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    id= (int)dt.Rows[i].ItemArray[3];
            //    treeView1.Nodes[id].Nodes.Add(dt.Rows[i].ItemArray[0].ToString());

            //}
        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
            //OBook oBook = new OBook();
            //oBook.Text = "Edit";
            //oBook.textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //oBook.textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //oBook.textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //oBook.ShowDialog();
            OBook oBook = new OBook();
            oBook.Text = "Edit";
            oBook.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            oBook.txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            oBook.txtwriter.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
            oBook.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Book_Load(sender, e);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            String strf="";
            if (radioButton1.Checked)
                strf = "name";
            else if (radioButton2.Checked)
                strf = "writer";

            //dt= db.Select("select *from tbl_book where "+strf+" like '%' +   N'"+txtsearch.Text+"' +'%' ");
            dt = db.Select("select tbl_book.id,tbl_book.name,tbl_book.writer,tbl_type.type from tbl_book inner join tbl_type on tbl_book.type = tbl_type.id and " + strf + " like '%' + N'" + txtsearch.Text + "' + '%'");
            dataGridView1.DataSource = dt;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.ShowDialog();
        }
    }
}
