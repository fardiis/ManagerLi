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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Btnbook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.ShowDialog();
            this.Hide();
        }
       
        DataBase db = new DataBase();
        private void Main_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.Select("select * from tbl_book");
            dataGridView1.DataSource = dt;

       
        }

        private void Btnloan_Click(object sender, EventArgs e)
        {
            Depository depository = new Depository();
            depository.ShowDialog();
        }

        private void Btnuser_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ShowDialog();
            this.Hide();
        }

        private void Btnsetting_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Note note = new Note();
            note.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.ShowDialog();
        }

       

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}  
