namespace ColorsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            var temp = sender as RadioButton;
            this.BackColor = temp.ForeColor;
        }
    }
}
