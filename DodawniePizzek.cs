using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_v2
{
    public partial class DodawniePizzek : Form
    {
        public DodawniePizzek()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var powrot = new Form1();
            powrot.Closed += (s, args) => this.Close();
            powrot.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Pizza = new Pizze()
            {
                NazwaPizzy = textBox1.Text,
                CenaJednostkowa = textBox2.Text,
                Składniki = textBox3.Text,
                Ilosc = Int32.Parse(textBox4.Text)

            };
            using (var pizz= new Pizzeria())
            {
                pizz.Pizzunie.Add(Pizza);
                pizz.SaveChanges();
            }
        }
    }
}
