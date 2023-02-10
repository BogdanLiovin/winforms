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
    public partial class Form1 : Form
    {
        private BindingList<Aircraft> aircrafts = new BindingList<Aircraft>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddAircraft form = new AddAircraft();
            if (form.ShowDialog() == DialogResult.OK)
            {
                aircrafts.Add(form.aircraft);
                richTextBox2.Text = aircrafts[listBox1.SelectedIndex].ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = aircrafts;
            listBox1.DisplayMember = "Number";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                aircrafts[listBox1.SelectedIndex].Refill(100, "Керосин");
                richTextBox2.Text = aircrafts[listBox1.SelectedIndex].ToString();
            }
        }
    }
}
