using System;
using System.Windows.Forms;

namespace lab_4
{
    public partial class fTablet : Form
    {
        public Tablet TheTablet;
        public fTablet(Tablet t)
        {
            TheTablet = t;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheTablet.Model = tbModel.Text.Trim();
            TheTablet.Processor = tbProcessor.Text.Trim();
            TheTablet.Battery = int.Parse(tbBattery.Text.Trim());
            TheTablet.Camera = int.Parse(tbCamera.Text.Trim());
            TheTablet.Diagonal = double.Parse(tbDiagonal.Text.Trim());
            TheTablet.Memory = int.Parse(tbMemory.Text.Trim());
            TheTablet.Supp5G = chbSupp5G.Checked;
            TheTablet.SuppPen = chbSuppPen.Checked;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fTablet_Load(object sender, EventArgs e)
        {
            if (TheTablet != null)
            {
                tbModel.Text = TheTablet.Model;
                tbProcessor.Text = TheTablet.Processor;
                tbBattery.Text = TheTablet.Battery.ToString();
                tbCamera.Text = TheTablet.Camera.ToString();
                tbDiagonal.Text = TheTablet.Diagonal.ToString("0.0");
                tbMemory.Text = TheTablet.Memory.ToString();
                chbSupp5G.Checked = TheTablet.Supp5G;
                chbSuppPen.Checked = TheTablet.SuppPen;
            }
        }
    }
}
