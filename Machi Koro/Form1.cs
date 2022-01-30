using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machi_Koro
{
    public partial class Form1 : Form
    {
        private Tafel tafel = new Tafel();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tafel.GenereerKaarten();
            tafel.SpelerToevoegen(4);
            p1_Stats.Text = tafel.players[0].naam + " | Geld:" + tafel.players[0].geld;
            p2_Stats.Text = tafel.players[1].naam + " | Geld:" + tafel.players[1].geld;
            p3_Stats.Text = tafel.players[2].naam + " | Geld:" + tafel.players[2].geld;
            p4_Stats.Text = tafel.players[3].naam + " | Geld:" + tafel.players[3].geld;

            foreach (Kaart kaart in tafel.players[0].hand)
            {
                p1_Hand.Text += kaart.naam + Environment.NewLine;
            }

            foreach (Kaart kaart in tafel.players[1].hand)
            {
                p2_Hand.Text += kaart.naam + Environment.NewLine;
            }

            foreach (Kaart kaart in tafel.players[2].hand)
            {
                p3_Hand.Text += kaart.naam + Environment.NewLine;
            }

            foreach (Kaart kaart in tafel.players[3].hand)
            {
                p4_Hand.Text += kaart.naam + Environment.NewLine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            int rolWaarde;
            rolWaarde = tafel.rollDice();
            textBox1.Text = "Rol 1:\n" + rolWaarde;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int eersteRolWaarde;
            int tweedeRolWaarde;
            eersteRolWaarde = tafel.rollDice();
            textBox1.Text = "Rol 1: " + eersteRolWaarde;
            
            
            tweedeRolWaarde = tafel.rollDice();
            textBox2.Text = "Rol 2: " + tweedeRolWaarde;
        }
    }
}
