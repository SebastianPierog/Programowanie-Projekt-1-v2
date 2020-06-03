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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var PizzaBaza= new Pizzeria())
            {
                List<Pizze> pizze = new List<Pizze>()
                {
                    new Pizze{
                        NazwaPizzy="Margherita",
                        CenaJednostkowa="14.90",
                        Ilosc=2,
                        Składniki="sos pomidorowy, ser, oregano"
                    },
                    new Pizze
                    {
                        NazwaPizzy="Prosciutto",
                        Składniki="sos pomidorowy, ser, szynka, oregano",
                        CenaJednostkowa="14.90",
                        Ilosc=3
                    },
                    new Pizze
                    {
                        NazwaPizzy="Salame",
                        Składniki="sos pomidorowy, ser, salami, oregano",
                        CenaJednostkowa="14.90",
                        Ilosc=1
                    },
                    new Pizze
                    {
                        NazwaPizzy="Parma",
                        Składniki="sos pomidorowy, ser, szynka parmeńska, rukola, pomidorki",
                        CenaJednostkowa="19.90",
                        Ilosc=4
                    }
                };
                foreach (var item in pizze)
                {
                    PizzaBaza.Pizzunie.Add(item);
                 
                }
                PizzaBaza.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var pizzerka= new Pizzeria())
            {
                tekstDlaPizzy.Text = "";
                foreach (var item in pizzerka.Pizzunie)
                {
                    tekstDlaPizzy.Text += $"Id: {item.Id}, Nazwa: {item.NazwaPizzy}, Ilość: {item.Ilosc}, Cena: {item.CenaJednostkowa}, Składniki: {item.Składniki}\n";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dodawanie = new DodawniePizzek();
            dodawanie.Closed += (s, args) => this.Close();
            dodawanie.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var nazwa = MnieSzukaj.Text;
            tekstDlaPizzy.Text = "";

            using (var p = new Pizzeria())
            {
                foreach (var item in p.Pizzunie)
                {
                    if (nazwa==item.NazwaPizzy)
                    {
                        tekstDlaPizzy.Text += $"Id: {item.Id}, Nazwa: {item.NazwaPizzy}, Ilość: {item.Ilosc}, Cena: {item.CenaJednostkowa}, Składniki: {item.Składniki}\n";
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var nazwa = SzukajSkladnik.Text;
            tekstDlaPizzy.Text = "";

            using (var p = new Pizzeria())
            {
                foreach (var item in p.Pizzunie)
                {
                    if (item.Składniki.Contains(nazwa))
                    {
                        tekstDlaPizzy.Text += $"Id: {item.Id}, Nazwa: {item.NazwaPizzy}, Ilość: {item.Ilosc}, Cena: {item.CenaJednostkowa}, Składniki: {item.Składniki}\n";
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.Hide();
            var usuwanie = new Usuwanie();
            usuwanie.Closed += (s, args) => this.Close();
            usuwanie.Show();
        }
    }
}
