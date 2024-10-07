using System.Data;
using System.Threading;
using Group_8;
namespace Group_8
{
    public partial class FormAlgorithm : Form
    {
        public FormAlgorithm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Hiện giữa màn hình 
            this.Algorithm_Choose.SelectedItem = "FCFS"; // Giá trị mặc định 
        }

        // Hàm ẩn đi Quantum nếu không chọn thuật toán Round Robin
        private void Algorithm_Choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedAlgorithmIndex = Algorithm_Choose.SelectedIndex;
            if (selectedAlgorithmIndex == 1)
            {
                Quantum_Label.Show();
                Quantum_Select.Show();
            }
            else
            {
                Quantum_Label.Hide();
                Quantum_Select.Hide();
            }
        }

        // Khai báo
        List<Process> processes = new(); // danh sách
        List<Process> queue = new(); // hàng đợi
        readonly List<int> cpu = new();
        int currentTime = 0;        // Thời gian hiện tại
        int processesLength = 0; // số lượng tiến trình
        int quantum = 0; // quantum time

        // Lớp đại diện cho thông tin của một tiến trình
        public class Process
        {
            public int Id { get; set; }
            public int ArrivalTime { get; set; }
            public int BurstTime { get; set; }
            public int RemainingTime { get; set; }
            public int WaitingTime { get; set; }
            public int TurnAroundTime { get; set; }
            public int CompletedTime { get; set; }
            public Color Color { get; set; }

            public Process(int id, int arrivalTime, int burstTime)
            {
                Id = id - 1;
                ArrivalTime = arrivalTime;
                BurstTime = burstTime;
                RemainingTime = burstTime;
                Random rand = new();
                Color = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
            }

            // Định nghĩa các thông số của tiến trình
            public void UseBurst()
            {
                RemainingTime--;
            }

            public void TurnAroundTimeResult()
            {
                TurnAroundTime = CompletedTime - ArrivalTime;
            }

            public void WaitingTimeResult()
            {
                WaitingTime = TurnAroundTime - BurstTime;
            }

            public void Done(int timeCount)
            {
                CompletedTime = timeCount;
                TurnAroundTimeResult();
                WaitingTimeResult();
            }
        }

        // Nút thêm tiến trình
        private void Add_Button_Click(object sender, EventArgs e)
        {
            int index = List_Process.Rows.Count;
            int arrivalTime = int.Parse(Arrival_Time.Text.ToString());
            int burstTime = int.Parse(Burst_Time.Text.ToString());
            List_Process.Rows.Add(index, arrivalTime, burstTime);
            Arrival_Time.Clear();
            Burst_Time.Clear();
        }

        // Nút gỡ tiến trình
        private void Remove_Button_Click(object sender, EventArgs e)
        {
            if (List_Process.SelectedRows.Count > 0)
            {
                int selectedIndex = List_Process.SelectedRows[0].Index;
                List_Process.Rows.RemoveAt(selectedIndex);
                if (selectedIndex < processes.Count)
                {
                    processes.RemoveAt(selectedIndex);
                    processesLength = processes.Count;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo nè!", MessageBoxButtons.OK);
            }
        }

        // Nút làm mới
        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            List_Process.Rows.Clear();
            Arrival_Time.Clear();
            Burst_Time.Clear();
            AVG_Waiting_Time.Clear();
            Reset();
        }

        // Hàm làm mới giá trị
        private void Reset()
        {
            processes.Clear();
            queue.Clear();
            cpu.Clear();
            currentTime = 0;
            Gantt_Chart.Controls.Clear();
            AVG_Waiting_Time.Clear();
        }

        // Nút chạy chương trình
        private void Run_Button_Click(object sender, EventArgs e)
        {
            Reset(); // Đặt lại các giá trị ban đ
            GetProcess(); // Lấy danh sách tiến trình
            if (processesLength != 0)
            {
                int choose = Algorithm_Choose.SelectedIndex;
                switch (choose)
                {
                    case 0:
                        FCFS();
                        break;
                    case 1:
                        quantum = Convert.ToInt32(Quantum_Select.Value);
                        if (quantum == 0)
                        {
                            MessageBox.Show("Chưa chọn thời gian quantum!", "Thông báo nè!", MessageBoxButtons.OK);
                            return;
                        }
                        RR();
                        break;
                    case 2:
                        SJF();
                        break;
                    case 3:
                        SRTN();
                        break;
                }
                Result();     // Hiện kết quả vào bảng
                GanttChart(); // Hiện biểu đồ Gantt     
            }
            else
                MessageBox.Show("Vui lòng nhập dữ liệu của tiến trình!", "Thông báo nè!", MessageBoxButtons.OK);
        }

        // Hàm lấy danh sách tiến trình từ bảng vào danh sách tiến trình
        private void GetProcess()
        {
            for (int i = 0; i < List_Process.Rows.Count - 1; i++)
            {
                DataGridViewRow row = List_Process.Rows[i];
                int id = Convert.ToInt32(row.Cells[0].Value);
                int arrivalTime = Convert.ToInt32(row.Cells[1].Value);
                int burstTime = Convert.ToInt32(row.Cells[2].Value);
                processes.Add(new Process(id, arrivalTime, burstTime));
            }
            processesLength = processes.Count;
        }

        // Hàm thuật toán First Come First Served
        private void FCFS()
        {
            while (true)
            {   // Duyệt tiến trình trong danh sách
                foreach (Process process in processes)
                {
                    // Nếu thời điểm đến của tiến trình bằng với thời điểm hiện tại
                    if (process.ArrivalTime == currentTime)
                    {
                        queue.Add(process); // Thêm tiến trình vào hàng đợi 
                        processesLength--;  // Giảm số lượng danh sách tiến trình
                    }
                }
                int queueLength = queue.Count; // Lấy độ dài của hàng đợi
                // Nếu cả hàng đợi và danh sách tiến trình đều rỗng, thoát khỏi vòng lặp
                if (queueLength == 0 && processesLength == 0) break;
             
                if (queueLength > 0) // Nếu hàng đợi vẫn còn 
                {
                    // Sử dụng CPU cho tiến trình ở đầu hàng đợi
                    queue[0].UseBurst();     // Giảm thời gian dùng CPU
                    cpu.Add(queue[0].Id); // Thêm ID cho tiến trình

                    if (queue[0].RemainingTime == 0) // Nếu đã chạy xong
                    {
                        queue[0].Done(currentTime + 1); // Kết thúc tiến trình
                        queue.Remove(queue[0]);      // Loại bỏ khỏi hàng đợi
                    }
                }
               currentTime++; // Tăng thời gian hiện tại lên 
            }
        }

        // Hàm thuật Round Robin
        private void RR()
        {        
            int r = quantum;
            while (true)
            {
                foreach (Process process in processes)
                {
                    if (process.ArrivalTime == currentTime) // Kiểm tra tiến trình tới chưa
                    {
                        queue.Add(process); // Thêm vào hàng đợi
                        processesLength--;  // Giảm số lượng danh sách
                    }
                }
                if (queue.Count > 0)
                { 
                    if (r == 0)  // Kiểm tra xem quantum còn lại của tiến trình hiện tại
                    {                     
                        r = quantum;            // Reset quantum
                        queue.Add(queue[0]);    // đưa tiến trình hiện tại vào cuối hàng đợi
                        queue.Remove(queue[0]);
                    }
                    queue[0].UseBurst();        // Tiến trình hiện tại sử dụng CPU
                    cpu.Add(queue[0].Id);      // Thêm ID vào danh sách CPU để theo dõi thứ tự xử lý
                    if (queue[0].RemainingTime == 0) // Nếu tiến trình đã hoàn thành
                    {
                        queue[0].Done(currentTime + 1); // Kết thúc tiến trình 
                        queue.Remove(queue[0]);         // Loại bỏ hàng đợi
                        r = quantum; // Đặt lại  quantum cho tiến trình mới 
                    }
                    else
                    {
                        r--;  // Giảm quantum khi tiến trình chưa hoàn thành
                    }
                }
                else if (processesLength == 0)
                {
                    break; // Thoát vòng lặp nếu đã xong
                }
                currentTime++; // Tăng thời gian hiện tại
            }
        }

        // Hàm thuật toán Shortest Job First
        private void SJF()
        {
            bool isFirstArrival = true; // Biến đánh dấu xem đã xảy ra lần đến đầu tiên hay chưa
            while (true)
            {
                // Duyệt qua tất cả các tiến trình trong danh sách
                foreach (Process process in processes)
                {
                    // Nếu thời điểm đến của tiến trình bằng với thời điểm hiện tại
                    if (process.ArrivalTime == currentTime)
                    {
                        queue.Add(process); // Thêm tiến trình vào hàng đợi
                        processesLength--;  // Giảm danh sách tiến trình
                    }
                }
                if (queue.Count > 0) // Nếu hàng đợi vẫn còn tiến trình
                {
                    // Nếu là lần đầu tiên xuất hiện tiến trình
                    if (isFirstArrival)
                    {
                        // Sắp xếp hàng đợi theo Burst Time
                        queue = queue.OrderBy(p => p.BurstTime).ToList();
                        isFirstArrival = false;
                    }
                    queue[0].UseBurst(); // Cho tiến trình đầu tiên chạy CPU
                    cpu.Add(queue[0].Id); // Thêm ID
                    if (queue[0].RemainingTime == 0) // Nếu đã chạy xong
                    {
                        queue[0].Done(currentTime + 1); // Hoàn thành tiến trình
                        queue.Remove(queue[0]);         // Loại bỏ hàng đợi
                        if (queue.Count > 0)  // Nếu còn tiến trình trong hàng đợi
                            queue = queue.OrderBy(p => p.BurstTime).ToList(); // sắp xếp lại theo Burst
                    }
                }
                else if (processesLength == 0) // Danh sách rỗng
                {   
                    break; // Thoát khỏi vòng lặp 
                }
                currentTime++; // Tăng thời gian hiện tại
            }
        }

        // Hàm thuật toán Shortest Remaining Time Next
        private void SRTN()
        {
            while (true)
            {
                // Duyệt qua tất cả các tiến trình trong danh sách
                foreach (Process process in processes)
                {
                    // Nếu thời điểm đến của tiến trình bằng với thời điểm hiện tại
                    if (process.ArrivalTime == currentTime)
                    {
                        queue.Add(process); // Thêm tiến trình vào hàng đợi
                        processesLength--; //  Giảm độ dài của danh sách tiến trình

                        // Sắp xếp lại hàng đợi theo thời gian còn lại tăng dần
                        queue = queue.OrderBy(p => p.RemainingTime).ToList();
                    }
                }
                if (queue.Count > 0) // Nếu hàng đợi có ít nhất một tiến trình

                {
                    // Sử dụng CPU cho tiến trình có thời gian còn lại ngắn nhất
                    queue[0].UseBurst();
                    // Thêm ID của tiến trình vào danh sách CPU
                    cpu.Add(queue[0].Id);
                    // Nếu thời gian còn lại của tiến trình bằng 0
                    if (queue[0].RemainingTime == 0)
                    {
                        // Hoàn thành tiến trình và loại bỏ khỏi hàng đợi
                        queue[0].Done(currentTime + 1);
                        queue.Remove(queue[0]);
                    }
                }
                // Nếu cả hàng đợi và danh sách tiến trình đều rỗng, thoát khỏi vòng lặp
                else if (processesLength == 0)
                {
                    break;
                }
                currentTime++; // Tăng thời điểm hiện tại lên 
            }
        }

        // Hàm hiển thị kết quả
        private void Result()
        {
            List_Process.Rows.Clear();
            processes = processes.OrderBy(process => process.ArrivalTime).ToList();
            int totalWaitingTime = 0;
            foreach (Process p in processes)
            {
                int index = p.Id + 1;
                int arrivalTime = p.ArrivalTime;
                int burstTime = p.BurstTime;
                int completedTime = p.CompletedTime;
                int turnAroundTime = p.TurnAroundTime;
                int waitingTime = p.WaitingTime;
                totalWaitingTime += waitingTime;
                List_Process.Rows.Add(index, arrivalTime, burstTime,
                $"{completedTime} - {arrivalTime} = {turnAroundTime}",
                $"{turnAroundTime} - {burstTime} = {waitingTime}");
            }
            AVG_Waiting_Time.Text = Math.Round(totalWaitingTime * 1.0 / processes.Count, 4).ToString();
        }

        // Hàm hiển thị biểu đồ Gantt
        private void GanttChart()
        {
            Gantt_Chart.Controls.Clear();
            int x = 0;
            int y = 0;
            int height = 70;
            Gantt_Chart.Padding = new Padding(0, height, 0, 0);
            int previousProcessId = -1;
            int currentTime = processes[cpu[0]].ArrivalTime;
            foreach (int i in cpu)
            {
                // thêm panel cho process
                Panel processPanel = new()
                {
                    Location = new Point(x, y),
                    Size = new Size(60, height),
                    BackColor = processes[i].Color,
                    BorderStyle = BorderStyle.None
                };

                // Kiểm tra xem tiến trình hiện tại có khác với tiến trình trước không
                if (previousProcessId != processes[i].Id)
                {
                    // Thêm nhãn có tên quy trình vào bảng quy trình
                    Label processLabel = new()
                    {
                        Text = $"P{processes[i].Id + 1}",
                        ForeColor = Color.Black,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill
                    };

                    processPanel.Controls.Add(processLabel);
                    Gantt_Chart.Controls.Add(processPanel);
                }
                else
                {
                    Gantt_Chart.Controls.Add(processPanel);
                }   

                // Kiểm tra xem tiến trình hiện tại có khác với tiến trình trước không
                if (previousProcessId != processes[i].Id)
                {
                    // Thêm bảng thời gian bên dưới bảng quy trình
                    Panel timePanel = new()
                    {
                        Location = new Point(x, y + height),
                        Size = new Size(60, height),
                        BackColor = Color.White,
                        BorderStyle = BorderStyle.None
                    };

                    // Thêm nhãn thời gian thực hiện vào bảng thời gian
                    Label timeLabel = new()
                    {
                        Text = $"{currentTime}",
                        ForeColor = Color.Black,
                        TextAlign = ContentAlignment.TopLeft,
                        Dock = DockStyle.Fill
                    };

                    timePanel.Controls.Add(timeLabel);
                    Gantt_Chart.Controls.Add(timePanel);
                }

                x += 60;

                // Cập nhật id tiến trình trước đó
                previousProcessId = processes[i].Id;
                currentTime++;
            }

            // Thêm bảng thời gian cuối cùng
            Panel finalTimePanel = new()
            {
                Location = new Point(x, y + height),
                Size = new Size(60, height),
                BackColor = Color.White,
                BorderStyle = BorderStyle.None
            };

            // Thêm nhãn thời gian thực hiện vào bảng thời gian cuối cùng
            Label finalTimeLabel = new()
            {
                Text = $"{currentTime}",
                Dock = DockStyle.Fill
            };

            finalTimePanel.Controls.Add(finalTimeLabel);
            Gantt_Chart.Controls.Add(finalTimePanel);
        }

    }
}
        // Khép đôi mi thật lâu
        // Nguyện mãi bên cạnh nhau
        // Yêu say đắm như ngày đầu !!!...
