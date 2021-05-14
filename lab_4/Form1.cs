using System;
using System.Windows.Forms;

namespace lab_4
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddCPU_Click(object sender, EventArgs e)
        {
            Tablet tab = new Tablet();
            fTablet ft = new fTablet(tab);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbTabsInfo.Text +=
                string.Format(
                    "\r\n--------------------------" +
                    "\r\nДані про " + tab.Model +
                    "\r\n--------------------------" +
                    "\r\nПроцесор: " + tab.Processor +
                    "\r\nБатарея: " + tab.Battery + " мА*ч" +
                    "\r\nЧас роботи: " + tab.GetWorkTime().ToString("0.##") + " год" +
                    "\r\nКамера: " + tab.Camera + " Мп" +
                    "\r\nПам'ять: " + tab.Memory + " ГБ" +
                    "\r\nДіагональ: " + tab.Diagonal.ToString("0.0") + "\"" +
                    (tab.Supp5G ? "\r\nЄ 5G" : "\r\nНемає 5G") +
                    (tab.SuppPen ? "\r\nЄ стилус" : "\r\nНемає стилусу"));
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
            "Припинити роботу", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
