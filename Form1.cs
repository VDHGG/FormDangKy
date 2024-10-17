using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLoginWithCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsValidEmail (string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool IsValidPassWord (string password)
        {
            return password.Length >= 8 && Regex.IsMatch(password, @"[!@#$%^&*(),.?""':{}|<>]");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string email = TextEmail.Text;
            string password = TextMatKhau.Text;

            if (!IsValidEmail(email))
            {
                HienThi.Text = "Thất bại: Email không hợp lệ!";
            }
            else if (!IsValidPassWord(password))
            {
                HienThi.Text = "Thất bại: Mật khẩu phải ít nhất 8 ký tự và có 1 ký tự đặc biệt!";
            }
            else
            {
                HienThi.Text = "Đăng ký thành công!";
            }
        }
    }
}
