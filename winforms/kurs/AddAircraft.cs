using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs
{
    public partial class AddAircraft : Form
    {
        private BindingList<Factory> factories;
        public Aircraft aircraft;
        public AddAircraft()
        {
            InitializeComponent();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                aircraft = new Aircraft(
                    factories[listBox1.SelectedIndex],
                    textBox1.Text,
                    numericUpDown4.Value,
                    textBox5.Text,
                    Decimal.ToInt32(numericUpDown1.Value),
                    Decimal.ToByte(numericUpDown3.Value),
                    dateTimePicker1.Value
                    );
                if (checkBox1.Checked)
                {
                    aircraft.Build(DateTime.Today);
                }
                else 
                aircraft.Build();
            }

            else
            {
                MessageBox.Show("Добавьте фабрику");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (aircraft != null)
            {
                aircraft.Route = new Route(numericUpDown2.Value, richTextBox1.Text);
            }
            else
            {
                MessageBox.Show("Создайте самолет");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (aircraft != null)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }

            else
            {
                MessageBox.Show("Создайте самолет");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            factories = new BindingList<Factory>();
            factories.Add(new Factory("Фабрика 1"));
            factories.Add(new Factory("Фабрика 2"));
            listBox1.DataSource = factories;
            listBox1.DisplayMember = "Name";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
