using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Management.OrderForm
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 25; i++)
            {
                // Đặt tên cho nút theo thứ tự
                Button btn = this.Controls.Find("button" + i.ToString(), true).FirstOrDefault() as Button;

                // Gán sự kiện Click chung cho mọi nút
                btn.Click += CommonButtonClick;
            }
        }

        private void CommonButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                int buttonNumber = int.Parse(clickedButton.Name.Substring(6)); // Lấy số từ tên nút
                OpenNewForm(buttonNumber);
            }
        }

        private void OpenNewForm(int buttonNumber)
        {
            // Tạo form mới và chuyển thông tin nếu cần
            Payment newForm = new Payment();
            newForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
