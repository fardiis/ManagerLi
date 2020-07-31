using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Library2
{
    public partial class Depository : Form
    {
        public Depository()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();

        private void Depository_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PersianCalendar pc = new PersianCalendar();
            txtnow.Text = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString() + "/" + pc.GetDayOfMonth(DateTime.Now).ToString();
        }

        private void textBox1_Leave(object sender, EventArgs e)
       {
            DataTable dt = new DataTable();
            dt = db.Select("select id from tbl_book where id = " + int.Parse(txtbookid.Text));
            if (dt.Rows.Count == 1)
                txtbookid.BackColor = Color.BlueViolet;
            else if (dt.Rows.Count == 0)
                txtbookid.BackColor = Color.Gray;
        }

    private void txtuserid_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.Select("select id from tbl_user where id =" + int.Parse(txtuserid.Text));
            if (dt.Rows.Count == 1)
               txtuserid.BackColor = Color.BlueViolet;
            else if (dt.Rows.Count == 0)
                txtuserid.BackColor = Color.Gray;
        }

        private void txtnow_Leave(object sender, EventArgs e)
        {
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime dt = DateTime.Now;
            int addm = dt.Day - 10;
            if(addm >=0)

            txtdate.Text= pc.GetYear(dt).ToString() + "/" + pc.GetMonth(dt.AddMonths(1)).ToString() + "/" + pc.GetDayOfMonth(dt.AddDays(10)).ToString();

            else

                txtdate.Text = pc.GetYear(dt).ToString() + "/" + pc.GetMonth(dt).ToString() + "/" + pc.GetDayOfMonth(dt.AddDays(10)).ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if ((txtbookid.BackColor == Color.BlueViolet && txtuserid.BackColor == Color.Gray) && (txtnow.Text != "" && txtdate.Text != "")) ;

            {
              if( db.Exe("insert into tbl_depository (idbook,idborrower,date,maxdate) values ('" + int.Parse(txtbookid.Text) + "','" + int.Parse(txtuserid.Text) + "','" + txtnow.Text + "','" + txtdate.Text + "')")==true);
                {
                    txtbookid.Text = txtuserid.Text = txtnow.Text = txtdate.Text = "";
                    txtbookid.BackColor = txtuserid.BackColor = Color.White;
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.ShowDialog();
        }
    }
}
