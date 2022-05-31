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
    public partial class Employees : Form
    {
        private object jq6tpek05;

        public Employees()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tamojnaDataSet2.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.tamojnaDataSet2.Employees);

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            
            comboBox1.DisplayMember = "Tamojna";
            comboBox1.ValueMember = "Id_Tam";

            Customs child = new Customs();
            Departments child4 = new Departments();
            Positions child2 = new Positions();
            Ranks child3 = new Ranks();

            if (comboBox1.Text == "Customs") { Customs.Show(); }
            {
                if (comboBox1.Text == "Departments") { Departments.Show(); }
            }
            {
                if (comboBox1.Text == "Positions") { Positions.Show(); }
            }
            {
                if (comboBox1.Text == "Ranks") { Ranks.Show(); }

            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }

    internal class Ranks
    {
        internal static void Show()
        {
            throw new NotImplementedException();
        }
    }

    internal class Positions
    {
        internal static void Show()
        {
            throw new NotImplementedException();
        }
    }

    internal class Departments
    {
        internal static void Show()
        {
            throw new NotImplementedException();
        }
    }
}
