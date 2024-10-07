namespace Group_8
{
    partial class FormAlgorithm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Algorithm_Choose = new ComboBox();
            Add_Button = new Button();
            Refresh_Button = new Button();
            Run_Button = new Button();
            label4 = new Label();
            AVG_Waiting_Time = new TextBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            Arrival_Time = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Burst_Time = new TextBox();
            List_Process = new DataGridView();
            PID = new DataGridViewTextBoxColumn();
            ArrivalTime = new DataGridViewTextBoxColumn();
            BurstTime = new DataGridViewTextBoxColumn();
            TurnAroundTime = new DataGridViewTextBoxColumn();
            WaitingTime = new DataGridViewTextBoxColumn();
            Remove_Button = new Button();
            groupBox2 = new GroupBox();
            Quantum_Select = new NumericUpDown();
            Quantum_Label = new Label();
            label5 = new Label();
            label7 = new Label();
            Gantt_Chart = new Panel();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)List_Process).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Quantum_Select).BeginInit();
            SuspendLayout();
            // 
            // Algorithm_Choose
            // 
            Algorithm_Choose.Dock = DockStyle.Fill;
            Algorithm_Choose.Font = new Font("Segoe UI", 11F);
            Algorithm_Choose.FormattingEnabled = true;
            Algorithm_Choose.Items.AddRange(new object[] { "FCFS", "RR", "SJF", "SRTN" });
            Algorithm_Choose.Location = new Point(3, 30);
            Algorithm_Choose.Name = "Algorithm_Choose";
            Algorithm_Choose.Size = new Size(124, 33);
            Algorithm_Choose.TabIndex = 0;
            Algorithm_Choose.SelectedIndexChanged += Algorithm_Choose_SelectedIndexChanged;
            // 
            // Add_Button
            // 
            Add_Button.BackColor = SystemColors.Info;
            Add_Button.Font = new Font("Adobe Gothic Std B", 10.2F, FontStyle.Bold);
            Add_Button.ForeColor = SystemColors.Highlight;
            Add_Button.Location = new Point(584, 28);
            Add_Button.Name = "Add_Button";
            Add_Button.Size = new Size(118, 54);
            Add_Button.TabIndex = 1;
            Add_Button.Text = "Add";
            Add_Button.UseVisualStyleBackColor = false;
            Add_Button.Click += Add_Button_Click;
            // 
            // Refresh_Button
            // 
            Refresh_Button.BackColor = SystemColors.Info;
            Refresh_Button.Font = new Font("Adobe Gothic Std B", 10.2F, FontStyle.Bold);
            Refresh_Button.ForeColor = SystemColors.Highlight;
            Refresh_Button.Location = new Point(720, 28);
            Refresh_Button.Name = "Refresh_Button";
            Refresh_Button.Size = new Size(118, 54);
            Refresh_Button.TabIndex = 2;
            Refresh_Button.Text = "Refresh";
            Refresh_Button.UseVisualStyleBackColor = false;
            Refresh_Button.Click += Refresh_Button_Click;
            // 
            // Run_Button
            // 
            Run_Button.BackColor = SystemColors.Info;
            Run_Button.Font = new Font("Adobe Gothic Std B", 10.2F, FontStyle.Bold);
            Run_Button.ForeColor = SystemColors.Highlight;
            Run_Button.Location = new Point(720, 102);
            Run_Button.Name = "Run_Button";
            Run_Button.Size = new Size(118, 54);
            Run_Button.TabIndex = 3;
            Run_Button.Text = "Run";
            Run_Button.UseVisualStyleBackColor = false;
            Run_Button.Click += Run_Button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Adobe Gothic Std B", 10.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(531, 531);
            label4.Name = "label4";
            label4.Size = new Size(195, 23);
            label4.TabIndex = 4;
            label4.Text = "Average Waiting Time";
            // 
            // AVG_Waiting_Time
            // 
            AVG_Waiting_Time.BackColor = SystemColors.Window;
            AVG_Waiting_Time.Font = new Font("Segoe UI", 11F);
            AVG_Waiting_Time.Location = new Point(732, 526);
            AVG_Waiting_Time.Name = "AVG_Waiting_Time";
            AVG_Waiting_Time.ReadOnly = true;
            AVG_Waiting_Time.Size = new Size(154, 32);
            AVG_Waiting_Time.TabIndex = 6;
            AVG_Waiting_Time.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightCyan;
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(Algorithm_Choose);
            groupBox3.Font = new Font("Consolas", 13.8F);
            groupBox3.Location = new Point(22, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(130, 74);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightCyan;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(18, 2);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 1;
            label3.Text = "Algorithm";
            // 
            // Arrival_Time
            // 
            Arrival_Time.Font = new Font("Segoe UI", 11F);
            Arrival_Time.Location = new Point(218, 112);
            Arrival_Time.Margin = new Padding(3, 4, 3, 4);
            Arrival_Time.Name = "Arrival_Time";
            Arrival_Time.Size = new Size(115, 32);
            Arrival_Time.TabIndex = 17;
            Arrival_Time.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.BackColor = Color.LightCyan;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(206, 83);
            label1.Name = "label1";
            label1.Size = new Size(142, 29);
            label1.TabIndex = 18;
            label1.Text = "Arrival Time";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.LightCyan;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(383, 83);
            label2.Name = "label2";
            label2.Size = new Size(148, 29);
            label2.TabIndex = 19;
            label2.Text = "Burst Time";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Burst_Time
            // 
            Burst_Time.Font = new Font("Segoe UI", 11F);
            Burst_Time.Location = new Point(398, 112);
            Burst_Time.Margin = new Padding(3, 4, 3, 4);
            Burst_Time.Name = "Burst_Time";
            Burst_Time.Size = new Size(115, 32);
            Burst_Time.TabIndex = 20;
            Burst_Time.TextAlign = HorizontalAlignment.Center;
            // 
            // List_Process
            // 
            List_Process.BackgroundColor = SystemColors.ButtonFace;
            List_Process.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            List_Process.Columns.AddRange(new DataGridViewColumn[] { PID, ArrivalTime, BurstTime, TurnAroundTime, WaitingTime });
            List_Process.GridColor = SystemColors.ControlDark;
            List_Process.Location = new Point(3, 170);
            List_Process.Margin = new Padding(3, 4, 3, 4);
            List_Process.Name = "List_Process";
            List_Process.RowHeadersWidth = 51;
            List_Process.Size = new Size(883, 343);
            List_Process.TabIndex = 21;
            // 
            // PID
            // 
            PID.HeaderText = "ID";
            PID.MinimumWidth = 6;
            PID.Name = "PID";
            PID.Width = 80;
            // 
            // ArrivalTime
            // 
            ArrivalTime.HeaderText = "Arrival Time";
            ArrivalTime.MinimumWidth = 6;
            ArrivalTime.Name = "ArrivalTime";
            ArrivalTime.Width = 150;
            // 
            // BurstTime
            // 
            BurstTime.HeaderText = "Burst Time";
            BurstTime.MinimumWidth = 6;
            BurstTime.Name = "BurstTime";
            BurstTime.Width = 150;
            // 
            // TurnAroundTime
            // 
            TurnAroundTime.HeaderText = "Turn Around Time";
            TurnAroundTime.MinimumWidth = 6;
            TurnAroundTime.Name = "TurnAroundTime";
            TurnAroundTime.Width = 230;
            // 
            // WaitingTime
            // 
            WaitingTime.HeaderText = "Waiting Time";
            WaitingTime.MinimumWidth = 6;
            WaitingTime.Name = "WaitingTime";
            WaitingTime.Width = 220;
            // 
            // Remove_Button
            // 
            Remove_Button.BackColor = SystemColors.Info;
            Remove_Button.Font = new Font("Adobe Gothic Std B", 10.2F, FontStyle.Bold);
            Remove_Button.ForeColor = SystemColors.Highlight;
            Remove_Button.Location = new Point(584, 100);
            Remove_Button.Name = "Remove_Button";
            Remove_Button.Size = new Size(118, 54);
            Remove_Button.TabIndex = 22;
            Remove_Button.Text = "Remove";
            Remove_Button.UseVisualStyleBackColor = false;
            Remove_Button.Click += Remove_Button_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightCyan;
            groupBox2.Controls.Add(Quantum_Select);
            groupBox2.Controls.Add(Quantum_Label);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(882, 177);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            // 
            // Quantum_Select
            // 
            Quantum_Select.Location = new Point(25, 110);
            Quantum_Select.Name = "Quantum_Select";
            Quantum_Select.Size = new Size(130, 32);
            Quantum_Select.TabIndex = 25;
            // 
            // Quantum_Label
            // 
            Quantum_Label.AutoSize = true;
            Quantum_Label.BackColor = Color.LightCyan;
            Quantum_Label.Location = new Point(40, 83);
            Quantum_Label.Name = "Quantum_Label";
            Quantum_Label.Size = new Size(91, 25);
            Quantum_Label.TabIndex = 26;
            Quantum_Label.Text = "Quantum";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightCyan;
            label5.Font = new Font("Adobe Gothic Std B", 13.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(281, 30);
            label5.Name = "label5";
            label5.Size = new Size(151, 29);
            label5.TabIndex = 23;
            label5.Text = "Group 8 Is Us";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Adobe Gothic Std B", 10.8F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(3, 531);
            label7.Name = "label7";
            label7.Size = new Size(104, 23);
            label7.TabIndex = 4;
            label7.Text = "Gantt chart";
            // 
            // Gantt_Chart
            // 
            Gantt_Chart.AutoScroll = true;
            Gantt_Chart.BackColor = SystemColors.Window;
            Gantt_Chart.Location = new Point(3, 569);
            Gantt_Chart.Name = "Gantt_Chart";
            Gantt_Chart.Size = new Size(882, 171);
            Gantt_Chart.TabIndex = 25;
            // 
            // FormAlgorithm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(889, 744);
            Controls.Add(Gantt_Chart);
            Controls.Add(Remove_Button);
            Controls.Add(List_Process);
            Controls.Add(Burst_Time);
            Controls.Add(AVG_Waiting_Time);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(Arrival_Time);
            Controls.Add(Run_Button);
            Controls.Add(Refresh_Button);
            Controls.Add(Add_Button);
            Controls.Add(groupBox2);
            Font = new Font("Segoe UI", 11F);
            MaximumSize = new Size(907, 791);
            MinimumSize = new Size(907, 791);
            Name = "FormAlgorithm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Algorithm Scheduling";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)List_Process).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Quantum_Select).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Add_Button;
        private Button Refresh_Button;
        private Button Run_Button;
        private Label label4;
        private TextBox AVG_Waiting_Time;
        private GroupBox groupBox3;
        private TextBox Arrival_Time;
        private Label label1;
        private Label label2;
        private TextBox Burst_Time;
        private DataGridView List_Process;
        private ComboBox Algorithm_Choose;
        private Button Remove_Button;
        private Label label3;
        private GroupBox groupBox2;
        private Label label7;
        private Label Quantum_Label;
        private NumericUpDown Quantum_Select;
        private Panel Gantt_Chart;
        private DataGridViewTextBoxColumn PID;
        private DataGridViewTextBoxColumn ArrivalTime;
        private DataGridViewTextBoxColumn BurstTime;
        private DataGridViewTextBoxColumn TurnAroundTime;
        private DataGridViewTextBoxColumn WaitingTime;
        private Label label5;
    }
}