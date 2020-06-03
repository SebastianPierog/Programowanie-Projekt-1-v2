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
    public partial class Usuwanie : Form
    {
        public Usuwanie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            var NazwaPizzy = textBox1.Text;
            

           
            using (var pizz = new Pizzeria())
            {
                foreach (var item in pizz.Pizzunie)
                {
                    if (NazwaPizzy==item.NazwaPizzy)
                    {
                        pizz.Pizzunie.Remove(item);
                    }
                }
                pizz.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var powrot = new Form1();
            powrot.Closed += (s, args) => this.Close();
            powrot.Show();
        }
    }
}
