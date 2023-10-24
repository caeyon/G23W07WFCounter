namespace G23W07WFCounter
{

    public partial class Form1 : Form
    {
        private int Count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void onAdd(object sender, EventArgs e)
        {
            label1.Text = $"{++Count}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Count > 0)
            {
                label1.Text = (--Count).ToString();
            }
        }
    }
}