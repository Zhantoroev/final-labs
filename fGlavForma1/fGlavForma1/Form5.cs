using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fGlavForma1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tamojnaDataSet5.Сумма". При необходимости она может быть перемещена или удалена.
            this.суммаTableAdapter.Fill(this.tamojnaDataSet5.Сумма);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tamojnaDataSet4.Налог". При необходимости она может быть перемещена или удалена.
            this.налогTableAdapter.Fill(this.tamojnaDataSet4.Налог);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tamojnaDataSet3.Экспорт". При необходимости она может быть перемещена или удалена.
            this.экспортTableAdapter.Fill(this.tamojnaDataSet3.Экспорт);

        }
    }
}
