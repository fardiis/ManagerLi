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
    public partial class AddUser : Form
    {
        DataBase db = new DataBase();
        public AddUser()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Text == "Add")
            { 
                if (db.Exe("insert into tbl_user (fname,lname,tel) values (N'" + txtname.Text + "',N'" + txtfamily.Text + "','" + txttell.Text + "')") == true) ;
            txtname.Text = txtfamily.Text = txttell.Text = "";
        }
            else if(Text== "Edit")
            {
                if(db.Exe("update tbl_user set fname=N'" + txtname.Text + "',lname=N'" + txtfamily.Text + "',tel=N'" + txttell.Text + "'where id ="+int.Parse(txtid.Text))==true)
                {
                    txtname.Text = txtfamily.Text = txttell.Text = "";
                }

            }
    }

        private void AddUser_Load(object sender, EventArgs e)
        {
            txtname.Text = txtfamily.Text = txttell.Text ;
        }
    }
}
