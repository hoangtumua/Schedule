namespace Group_8
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Algorithm_Button = new Button();
            Process_Button = new Button();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Thread_Button = new Button();
            groupBox1 = new GroupBox();
            Chat_Button = new Button();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Algorithm_Button
            // 
            Algorithm_Button.BackColor = SystemColors.GradientActiveCaption;
            Algorithm_Button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            Algorithm_Button.ForeColor = Color.FromArgb(0, 0, 64);
            Algorithm_Button.Location = new Point(412, 296);
            Algorithm_Button.Margin = new Padding(5, 6, 5, 6);
            Algorithm_Button.Name = "Algorithm_Button";
            Algorithm_Button.Size = new Size(270, 70);
            Algorithm_Button.TabIndex = 4;
            Algorithm_Button.Text = "Algorithm Scheduling";
            Algorithm_Button.UseVisualStyleBackColor = false;
            Algorithm_Button.Click += Algorithm_Button_Click;
            // 
            // Process_Button
            // 
            Process_Button.BackColor = Color.PeachPuff;
            Process_Button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            Process_Button.ForeColor = Color.FromArgb(0, 0, 64);
            Process_Button.Location = new Point(412, 63);
            Process_Button.Margin = new Padding(5);
            Process_Button.Name = "Process_Button";
            Process_Button.Size = new Size(270, 70);
            Process_Button.TabIndex = 6;
            Process_Button.Text = "Process Manager";
            Process_Button.UseVisualStyleBackColor = false;
            Process_Button.Click += Process_Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaShell;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(168, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(304, 39);
            label1.TabIndex = 7;
            label1.Text = "Operating System";
            // 
            // Thread_Button
            // 
            Thread_Button.BackColor = SystemColors.Info;
            Thread_Button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            Thread_Button.ForeColor = Color.FromArgb(0, 0, 64);
            Thread_Button.Location = new Point(412, 142);
            Thread_Button.Margin = new Padding(4);
            Thread_Button.Name = "Thread_Button";
            Thread_Button.Size = new Size(270, 70);
            Thread_Button.TabIndex = 8;
            Thread_Button.Text = "Thread Simulation";
            Thread_Button.UseVisualStyleBackColor = false;
            Thread_Button.Click += Thread_Button_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaShell;
            groupBox1.Controls.Add(Chat_Button);
            groupBox1.Controls.Add(Process_Button);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Algorithm_Button);
            groupBox1.Controls.Add(Thread_Button);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1, 15);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(691, 380);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // Chat_Button
            // 
            Chat_Button.BackColor = Color.Thistle;
            Chat_Button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            Chat_Button.ForeColor = Color.FromArgb(0, 0, 64);
            Chat_Button.Location = new Point(412, 221);
            Chat_Button.Name = "Chat_Button";
            Chat_Button.Size = new Size(270, 70);
            Chat_Button.TabIndex = 11;
            Chat_Button.Text = "Chat";
            Chat_Button.UseVisualStyleBackColor = false;
            Chat_Button.Click += Chat_Button_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 255, 192);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.MenuHighlight;
            groupBox2.Location = new Point(8, 63);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(399, 307);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Members Of Group 8";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(255, 128, 128);
            label6.Location = new Point(40, 241);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(221, 29);
            label6.TabIndex = 0;
            label6.Text = "Khuất Văn Trường";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(255, 128, 128);
            label5.Location = new Point(40, 177);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(240, 29);
            label5.TabIndex = 0;
            label5.Text = "Nguyễn Quyền Linh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(255, 128, 128);
            label4.Location = new Point(40, 115);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(211, 29);
            label4.TabIndex = 0;
            label4.Text = "Hoàng Đức Mạnh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(255, 128, 128);
            label3.Location = new Point(40, 56);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(233, 29);
            label3.TabIndex = 0;
            label3.Text = "Phạm Thị Minh Chi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 102);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 31);
            label2.TabIndex = 10;
            label2.Text = "Members";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(690, 386);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            MaximumSize = new Size(708, 433);
            MinimumSize = new Size(708, 433);
            Name = "MainForm";
            Text = "Group 8 Is Us";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button Algorithm_Button;
        private Button Process_Button;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button Thread_Button;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button Chat_Button;
    }
}
