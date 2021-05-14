using System;
using System.Windows.Forms;

namespace lab_6
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvTab.AutoGenerateColumns = false;
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Model";
            column.Name = "Модель";
            column.Width = 130;
            gvTab.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Processor";
            column.Name = "Процесор";
            column.Width = 130;
            gvTab.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Battery";
            column.Name = "Батарея";
            column.Width = 60;
            gvTab.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Camera";
            column.Name = "Камера";
            column.Width = 60;
            gvTab.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Memory";
            column.Name = "Пам'ять";
            column.Width = 60;
            gvTab.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Diagonal";
            column.Name = "Діагональ";
            column.Width = 80;
            gvTab.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Supp5G";
            column.Name = "Підтримка 5G";
            column.Width = 80;
            gvTab.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "SuppPen";
            column.Name = "Підтримка стилусу";
            gvTab.Columns.Add(column);
            bindSrcTab.Add(new Tablet("Samsung Galaxy A8", "Snapdragon 492", 5100, 8, 32, 8, false, false));
            EventArgs args = new EventArgs();
            OnResize(args);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Tablet tab = new Tablet();
            fTablet ft = new fTablet(tab);
            if (ft.ShowDialog() == DialogResult.OK)
                bindSrcTab.Add(tab);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Tablet tab = (Tablet)bindSrcTab.List[bindSrcTab.Position];
            fTablet ft = new fTablet(tab);
            if (ft.ShowDialog() == DialogResult.OK)
                bindSrcTab.List[bindSrcTab.Position] = tab;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?",
            "Видалення запису", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning) == DialogResult.OK)
                bindSrcTab.RemoveCurrent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені",
                "Очищення даних", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
                bindSrcTab.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
                MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
