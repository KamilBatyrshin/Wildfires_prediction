using System.Windows.Forms;

namespace POJAR_GUI2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_area_Click(object sender, EventArgs e)
        {
            ResultsForm form2 = new ResultsForm();
            form2.ShowDialog();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_Title_Click(object sender, EventArgs e)
        {

        }

        private void button_date_Click(object sender, EventArgs e)
        {
            ResultsForm_date form2 = new ResultsForm_date();
            form2.ShowDialog();
        }
    }
}