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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        private void Btnadd_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Text = "Add";
            addUser.ShowDialog();
        }

        private void User_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.Select("select id,fname,lname,tel from tbl_user");
            dataGridView1.DataSource = dt;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id =int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            DataTable dt = new DataTable();
            dt = db.Select("select from tbl_user where id=" + id );
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            //int id =int.Parse( dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //if (db.Exe("delete from tbl_user where id=" + id) == true)
            //{
            //    User_Load(sender, e);
            //}
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            DataTable dt = new DataTable();
            dt = db.Select("select * from tbl_depository where idborrower=" + id);
            if (dt.Rows.Count == 0)
            {
                dt = db.Select("select * from tbl_user where id=" + id);
                string name;
                name = dt.Rows[0].ItemArray[1].ToString();
                name += dt.Rows[0].ItemArray[2].ToString();
                name += dt.Rows[0].ItemArray[3].ToString();
                if (db.Exe("delete from tbl_user where id=" + id) == true)
                {
                    User_Load(sender, e);

                }
            }
            else
                MessageBox.Show(".کاربر مورد نظر بدهکار است", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    

    private void Btnedit_Click(object sender, EventArgs e)
    {
        AddUser addUser = new AddUser();
        addUser.Text = "Edit";
        addUser.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        addUser.txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        addUser.txtfamily.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        addUser.txttell.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        addUser.ShowDialog();

    }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string strname="";
            if (radioButton1.Checked)
            
                strname = "fname";
            
            else if (radioButton2.Checked)

                strname = "lname";
            
            dt=db.Select("select  id,fname,lname,tel from tbl_user where "+ strname + " like '%'+N'" + txtsearch.Text + "'+ '%' ");
            dataGridView1.DataSource = dt;

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            User_Load(sender, e);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.ShowDialog();
        }
    }
}
