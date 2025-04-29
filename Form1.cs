using System.Data;
using System.Linq.Expressions;

namespace Calculator3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public void btn_sign(Button B)
        {
            label2.Text += B.Tag.ToString();
        }
        public void result(Button B)
        {
            if (label2.Text.ToString() == "0")
            {
                label2.Text = B.Tag.ToString();
                label3.Text = label2.Text;
                return;
            }
            label2.Text += B.Tag.ToString();

            var result = new DataTable().Compute(label2.Text, null);
            double finalResult = Convert.ToDouble(result);
            label3.Text = Convert.ToString(finalResult);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            result((Button)sender);
        }

        private void Btn_sign(object sender, EventArgs e)
        {
            btn_sign((Button)sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = label3.Text;
        }

        private void roundButton17_Click(object sender, EventArgs e)
        {
            label2.Text = "0";
            label3.Text = "0";
        }
    }
}
