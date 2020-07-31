using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace Library2
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String lpass = Properties.Settings.Default.Pass;
            if(txtlp.Text==lpass)
            {
                Properties.Settings.Default.Pass = txtnp.Text;
                Properties.Settings.Default.Save();
                txtlp.Text = txtnp.Text = "";
            }
        }
        DataBase db = new DataBase();
        public bool SendMail(string strmail, string path)
        {
            try
            {
                MailMessage mm;
                MailAddress from = new MailAddress("fardis.bahry.computer@gmail.com", "فایل پشتیبان", Encoding.UTF8);
                MailAddress to = new MailAddress(strmail);
                mm = new MailMessage(from, to);
                mm.Subject = "Backup From DataBase";
                mm.Body = DateTime.Now.ToShortDateString() + Environment.NewLine + DateTime.Now.ToShortTimeString();
                Attachment a = new Attachment(path, MediaTypeNames.Application.Octet);
                mm.Attachments.Add(a);
                SmtpClient smtpc = new SmtpClient();
                smtpc.Port = 587;
                smtpc.EnableSsl = true;
                smtpc.Host = "smtp.gmail.com";
                smtpc.Credentials = new NetworkCredential("fardis.bahry.computer@gmail.com", "fardis bahry");
                smtpc.Send(mm);
                return true;
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                return false;
            }

        }
      
        private void Button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save...";
            sfd.Filter = "Back File(*.back)|*.back";
            sfd.OverwritePrompt = true;
            if(sfd.ShowDialog()==DialogResult.OK)
            {
                if (db.Exe("backup database ManagerLi to disk='" + sfd.FileName + "'"))
                {
                    MessageBox.Show(".پشتیبان گیری یا موفقیت انجام شد", "True", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Properties.Settings.Default.lastbackup = DateTime.Now.ToShortDateString();
                    if (MessageBox.Show("آیا میل دارید که فایل پشتیبان به پست الکترونیکی شما ارسال شود ؟", "True", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (SendMail(Properties.Settings.Default.mail, sfd.FileName) == true)
                            MessageBox.Show(".فایل پشتیبان با موفقیت ارسال شد", "True", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show(".فایل پشتیبان با موفقیت ارسال نشد", "False", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show(".پشتیبان گیری یا موفقیت انجام نشد", "False", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        
        }

        private void Setting_Load(object sender, EventArgs e)
        {
           txtlb.Text =Properties.Settings.Default.lastbackup ;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Open...";
            op.Filter = "Backup File (*.back)|*.back";
            if(op.ShowDialog()==DialogResult.OK)
            {
                if (db.Exe("alter database ManagerLi set single_user with rollback immediate use master restore database ManagerLi from disk = '" + op.FileName + "' with replace"))
                {
                    MessageBox.Show(".بازگردانی یا موفقیت انجام شد", "True", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(".بازگردانی یا موفقیت انجام نشد", "False", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
            }

        private void Button4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.mail = txtmail.Text;
            Properties.Settings.Default.Save();
        }
    }
    }

