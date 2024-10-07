using Group_8;
namespace Group_8
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Algorithm_Button_Click(object sender, EventArgs e)
        {
            FormAlgorithm formTT = new FormAlgorithm();
            this.Hide();
            formTT.ShowDialog();
            this.Show();
        }

        private void Process_Button_Click(object sender, EventArgs e)
        {
            FormProcess dlg2 = new FormProcess();
            this.Hide();
            dlg2.ShowDialog();
            this.Show();
        }

        private void Thread_Button_Click(object sender, EventArgs e)
        {
            FormThread dlg2 = new FormThread();
            this.Hide();
            dlg2.ShowDialog();
            this.Show();
        }

        private void Chat_Button_Click(object sender, EventArgs e)
        {
            Chat dlg2 = new Chat();
            this.Hide();
            dlg2.ShowDialog();
            this.Show();
        }
    }
}
