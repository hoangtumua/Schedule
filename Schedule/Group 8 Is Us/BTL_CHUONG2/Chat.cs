using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Group_8
{
    public partial class Chat : Form
    {
        private BackgroundWorker backgroundWorker;

        public Chat()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Xử lý nền
            string message = e.Argument as string;
            // Giả sử ngủ
            Thread.Sleep(2);
            // Trả kết quả về cho RunWorkerCompleted
            e.Result = message;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Khi xử lý nền hoàn tất, cập nhật UI
            if (e.Result != null)
            {
                string message = e.Result.ToString();

                // Hiển thị kết quả trên cả hai RichTextBox
                UpdateRichTextBox(richTextBox1, message);
                UpdateRichTextBox(richTextBox2, message);
            }
        }

        // Phương thức cập nhật RichTextBox từ một luồng khác
        private void UpdateRichTextBox(RichTextBox richTextBox, string message)
        {
            if (richTextBox.InvokeRequired)
            {
                // Nếu đang ở trên một luồng khác, sử dụng phương thức Invoke để thực hiện trên luồng chính.
                richTextBox.Invoke(new Action(() => UpdateRichTextBox(richTextBox, message)));
            }
            else
            {
                // Nếu đang ở trên luồng chính, thêm nội dung vào RichTextBox.
                richTextBox.AppendText(message + Environment.NewLine);
            }
        }
        private void Send1_Button_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu BackgroundWorker đang chạy
            if (!backgroundWorker.IsBusy)
            {
                // Lấy nội dung từ TextBox
                string message = textBox1.Text;
                string formattedMessage = "One: " + message;

                // Truyền nội dung đến BackgroundWorker để xử lý
                backgroundWorker.RunWorkerAsync(formattedMessage);
            }
            textBox1.Clear();  // Làm mới ô textbox1
        }

        private void Send2_Button_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu BackgroundWorker đang chạy
            if (!backgroundWorker.IsBusy)
            {
                // Lấy nội dung từ TextBox
                string message = textBox2.Text;
                string formattedMessage = "Two: " + message;
                // Truyền nội dung đến BackgroundWorker để xử lý
                backgroundWorker.RunWorkerAsync(formattedMessage);
            }
            textBox2.Clear(); // Làm mới ô textbox2

        }

    }
}
