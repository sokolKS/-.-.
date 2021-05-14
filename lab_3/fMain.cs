using System;
using System.Windows.Forms;

namespace lab_3
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbX1.Text) ||
                string.IsNullOrEmpty(tbX2.Text)) {
                tbY.Text = "Не введено даних!";
                return;
            }
            double x1 = double.Parse(tbX1.Text);
            double x2 = double.Parse(tbX2.Text);
            double aver = (x1 + x2) / 2;
            double y = Math.Sin((x1 - x2) / Math.Pow(x1 + 53 * x2, 2));
            this.chart1.Series[0].Points.AddXY(aver, y);
            tbY.Text = y.ToString("0.####");
            tbA.Text = aver.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbY.Text = string.Empty;
            tbA.Text = string.Empty;
            tbX1.Text = string.Empty;
            tbX2.Text = string.Empty;
            this.chart1.Series[0].Points.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
