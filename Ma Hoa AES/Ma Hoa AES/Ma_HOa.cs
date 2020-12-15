using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Ma_Hoa_AES
{
    public partial class Ma_HOa : Form
    {
        Sec_AES aes = new Sec_AES();
        public Ma_HOa()
        {
            InitializeComponent();
        }
        //phần mở rộng
        private void cmdinfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là chương trình mã hóa ", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        // click làm lại ở mã hóa
        private void cmdreset1_Click(object sender, EventArgs e)

        {
            txtencr.Text = "";// nội dung mã hóa
            txtreencr.Text = "";// kết quả mã hóa
        }



        // click làm lại ở mã hóa
        private void cmdreset2_Click(object sender, EventArgs e)  // click làm lại ở mã hóa
        {
            txtdecr.Text = "";// nội dung giải mã
            txtrsdecr.Text = "";// kết quả giải mã
        }




        //button mã hóa
        DateTime timeStartMaHOa = DateTime.Now;
      

        private void cmdmahoa_Click(object sender, EventArgs e)
        {
            if (txtencr.Text != "")
            {
                try
                {
                    txtreencr.Text = aes.Encrypt(txtencr.Text, txtkey1.Text, 128);
                }
                catch
                {
                    MessageBox.Show("Không Mã Hóa được", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Ô Nội Dung không được rỗng", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        DateTime timeEndMaHOa = DateTime.Now;




        //button giaima
        DateTime timeStartGiaiMa = DateTime.Now;
        private void cmddecr_Click(object sender, EventArgs e)
        {
            if (txtdecr.Text != "")
            {
                try
                {
                    txtrsdecr.Text = aes.Decrypt(txtdecr.Text, txtkey2.Text, 128);
                }
                catch
                {
                    MessageBox.Show("Không Giải Mã được", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // khi nội dung  giải mã khác với kết quả mã hóa hoặc khóa sai

                }
            }
            else
            {
                MessageBox.Show("Ô Nội Dung không được rỗng", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // khi nội dung giải mã trống
            }
        }
        DateTime timeEndGiaiMa = DateTime.Now;




        private void Ma_HOa_Load(object sender, EventArgs e)
        {

        }


        private void txtencr_TextChanged(object sender, EventArgs e)
        {

        }
        //Click lấy thời gian Giải mã
        private void Time_Click(object sender, EventArgs e)
        {
            timeStartGiaiMa.ToString("dd-MM-yyyy HH:mm:ss.fffffff");
            timeEndGiaiMa.ToString("dd-MM-yyyy HH:mm:ss.fffffff");

            TimeSpan t2 = timeEndGiaiMa-timeStartGiaiMa;
            Time2.Text = t2.ToString();
        }

        //Click lấy thời gian mã Hóa
        private void button1_Click(object sender, EventArgs e)
        {
            timeStartMaHOa.ToString("dd-MM-yyyy HH:mm:ss.fffffff");
            timeEndMaHOa.ToString("dd-MM-yyyy HH:mm:ss.fffffff");

            TimeSpan t1= (timeEndMaHOa-timeStartMaHOa);
            Time1.Text = t1.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}