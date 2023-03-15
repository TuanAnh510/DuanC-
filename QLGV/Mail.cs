using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net.Mail;
using System.IO;
namespace QLGV
{
    public partial class Mail : DevExpress.XtraEditors.XtraForm
    {
        string[] str2 = new string[30];
        public Mail()
        {
            InitializeComponent();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
                MailMessage mail = new MailMessage(txtTo.Text, txtFrom.Text, txtTieude.Text, txtNoiDung.Text);
                mail.IsBodyHtml = true;
                SmtpClient client = new SmtpClient(smtp.Text);
                client.Host = "smtp.gmail.com";
                client.UseDefaultCredentials = false;
                client.Port = 587;   // thêm vào credential vì SMTP server cần nó để biết được email + password của email đó mà bạn đang dùng
                client.Credentials = new System.Net.NetworkCredential(txtFrom.Text, txtPass.Text);
                client.EnableSsl = true; //vì ta cần thiết lập kết nối SSL với SMTP server nên cần gán nó bằng true
                client.Send(mail);
                MessageBox.Show("Đã gửi tin nhắn thành công!", "Thành Công", MessageBoxButtons.OK);
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}