using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_8
{
    public partial class FormProcess : Form
    {
        public FormProcess()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Hiện Form giữa màn hình
            DisplayProcesses(); // Gòi hàm hiển thị danh sách tiến trình luôn khi form hiện
        }

        // Hàm hiển thị danh sách tiến trình 
        private void DisplayProcesses()
        {
            // Lấy danh sách các tiến trình
            Process[] processes = Process.GetProcesses();

            // Duyệt qua danh sách tiến trình và thêm vào DataGridView
            foreach (Process process in processes)
            {
                int rowIndex = dataGridView1.Rows.Add(); // Thêm hàng
                dataGridView1.Rows[rowIndex].Cells["Process_ID"].Value = process.Id; // Thêm ID
                dataGridView1.Rows[rowIndex].Cells["Process_Name"].Value = process.ProcessName; // Thêm Tên
            }
            // TextBox_EnterName.Clear(); 
        }

        // Ô nhập và lọc tiến trình dựa trên ô nhập
        private void TextBox_EnterName_TextChanged(object sender, EventArgs e)
        {
            // Gọi hàm lọc và hiển thị danh sách tiến trình dựa trên ô nhập
            FilterAndDisplayProcesses(TextBox_EnterName.Text);
        }

        // Hàm lọc và hiển thị danh sách tiến trình dựa trên ô nhập
        private void FilterAndDisplayProcesses(string filterText)
        {
            dataGridView1.Rows.Clear();
            Process[] allProcesses = Process.GetProcesses();
            IEnumerable<Process> filteredProcesses = allProcesses
                .Where(process => process.ProcessName.Contains(filterText, StringComparison.OrdinalIgnoreCase));

            // Vòng lặp hiển thị lần lượt những tiến trình dựa theo tên đã lọc
            foreach (Process process in filteredProcesses)
            {
                int rowIndex = dataGridView1.Rows.Add(); // Thêm hàng
                dataGridView1.Rows[rowIndex].Cells["Process_ID"].Value = process.Id; // Hiện ID vào bảng
                dataGridView1.Rows[rowIndex].Cells["Process_Name"].Value = process.ProcessName; // Hiển tên vào bảng
            }
        }

        // Nút mở tiến trình
        private void Open_Button_Click(object sender, EventArgs e)
        {
            // Lấy tên tiến trình từ ô nhập textBox
            string processName = TextBox_EnterName.Text;

            // Kiểm tra xem tên tiến trình có được nhập hay không
            if (!string.IsNullOrWhiteSpace(processName))
            {
                try
                {
                    // Mở tiến trình đó
                    Process.Start(processName);
                }
                catch (Exception ex) // Nếu lỗi thông báo lỗi và mã lỗi
                {
                    MessageBox.Show("Không thể mở tiến trình. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {   // Chưa nhập tên thì đưa ra thông báo
                MessageBox.Show("Vui lòng nhập tên tiến trình để mở.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //   TextBox_EnterName.Clear(); // Mở xong thì xóa trắng ô nhập
        }

        // Nút đóng tiến trình
        private void Close_Button_Click_1(object sender, EventArgs e)
        {
            // Lấy tên tiến trình từ TextBox
            string processName = TextBox_EnterName.Text;
            // Kiểm tra xem tên tiến trình có được nhập hay không
            if (!string.IsNullOrWhiteSpace(processName))
            {
                try
                {   // Tìm tất cả các tiến trình với tên cụ thể
                    Process[] processes = Process.GetProcessesByName(processName);

                    // Kiểm tra xem có tiến trình nào không
                    if (processes.Length > 0)
                    {
                        // Đóng từng tiến trình
                        foreach (Process process in processes)
                        {
                            process.CloseMainWindow(); // Đóng cửa sổ chính
                            process.WaitForExit();     // Đợi đến khi tiến trình thoát hoàn toàn
                        }
                        // Đưa ra thông báo khi đóng tiến trình xong
                        MessageBox.Show("Đã đóng tiến trình thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {   // Đưa ra thông báo nếu không có tiến trình nào để đóng
                        MessageBox.Show("Không tìm thấy tiến trình để đóng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {   // Đưa ra thông báo khi đóng lỗi, và đưa ra mã lỗi
                    MessageBox.Show("Không thể đóng tiến trình. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {   // Đưa ra thông báo nếu chưa nhập tên tiến trình
                MessageBox.Show("Vui lòng nhập tên tiến trình để đóng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            TextBox_EnterName.Clear(); // Đóng xong xóa trắng ô nhập
        }

        // Nút làm mới
        private void Refresh_Button_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); // Xóa sạch danh sách trong bảng
            DisplayProcesses();         // Gọi hàm hiển thị danh sách tiến trình
            TextBox_EnterName.Clear();  // Xóa nội dung trong ô nhập
        }

        // Nút hiển thị thông tin ổ đĩa
        private void Disk_Button_Click(object sender, EventArgs e)
        {
            // Lấy thông tin về tất cả các ổ đĩa trên máy tính
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            // Tạo một chuỗi văn bản để chứa thông tin về dung lượng ổ đĩa
            string driveInfoMessage = "Information about disk capacity:\n";
            // Lặp qua từng ổ đĩa và thêm thông tin vào chuỗi
            foreach (DriveInfo drive in allDrives)
            {
                driveInfoMessage += $"{drive.Name} - Total capacity: {FormatBytes(drive.TotalSize)}" +
                    $", Free space: {FormatBytes(drive.AvailableFreeSpace)}\n";
            }
            // Hiển thị thông báo
            MessageBox.Show(driveInfoMessage, "Drive information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Hàm chuyển đổi dung lượng từ byte sang đơn vị đo
        private string FormatBytes(long bytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            while (bytes >= 1024 && order < sizes.Length - 1)
            {
                order++;
                bytes = bytes / 1024;
            }
            return $"{bytes:0.##} {sizes[order]}";
        }
    }
}
