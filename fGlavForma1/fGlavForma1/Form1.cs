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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tamojnaDataSet1.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.tamojnaDataSet1.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tamojnaDataSet.Export". При необходимости она может быть перемещена или удалена.
            this.exportTableAdapter.Fill(this.tamojnaDataSet.Export);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employees f = new Employees();
            f.Show();
        }
    }
}
