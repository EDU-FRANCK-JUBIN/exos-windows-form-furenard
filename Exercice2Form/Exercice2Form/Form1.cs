using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice2Form
{
    public partial class Form1 : Form
    {
        String result;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                result += btn.Text;
                textBox1.Text += 1;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                result += btn.Text;
                textBox1.Text += 2;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                result += btn.Text;
                textBox1.Text += 3;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                result += btn.Text;
                textBox1.Text += 4;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                result += btn.Text;
                textBox1.Text += 5;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                result += btn.Text;
                textBox1.Text += 6;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                result += btn.Text;
                textBox1.Text += 7;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                result += btn.Text;
                textBox1.Text += 8;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                result += btn.Text;
                textBox1.Text += 9;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            String textePlus;
            if (btn != null)
            {
                result += btn.Text;
                textePlus = btn.Text;
                textBox1.Text += textePlus;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            String texteMoins;
            if (btn != null)
            {
                result += btn.Text;
                texteMoins = btn.Text;
                textBox1.Text += texteMoins;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            String texteMult;
            if (btn != null)
            {
                result += btn.Text;
                texteMult = btn.Text;
                textBox1.Text += texteMult;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            String texteDiv;
            if (btn != null)
            {
                result += btn.Text;
                texteDiv = btn.Text;
                textBox1.Text += texteDiv;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            String texteBox;
            String temp = ""; 
            Char[] tableauCaractere = new char[20];
            double[] tableauNombre = new double[20];
            double resultat = 0;
            int compteurCarac = 0;
            int compteurNbre = 0;
            if (btn != null)
            {
                texteBox = btn.Text;
                textBox1.Text += texteBox;
            }
            foreach (char number in textBox1.Text)
            {
                switch (number)
                {
                case '+':
                        tableauCaractere[compteurCarac] = '+';
                        tableauNombre[compteurNbre] = Convert.ToDouble(temp);
                        compteurNbre ++;
                        compteurCarac++;
                        temp = "";
                        break;
                case '-':
                        tableauCaractere[compteurCarac] = '-';
                        tableauNombre[compteurNbre] = Convert.ToDouble(temp);
                        compteurNbre++;
                        compteurCarac++;
                        temp = "";
                        break;
                case '*':
                        tableauCaractere[compteurCarac] = '*';
                        tableauNombre[compteurNbre] = Convert.ToDouble(temp);
                        compteurNbre++;
                        compteurCarac++;
                        temp = "";
                        break;
                case '/':
                        tableauCaractere[compteurCarac] = '/';
                        tableauNombre[compteurNbre] = Convert.ToDouble(temp);
                        compteurNbre++;
                        compteurCarac++;
                        temp = "";
                        break;
                case '=':
                        break;
                    default:
                        temp += number;
                        break;

                }

            }

            for (int i = 0; i < compteurNbre; i++ )
            {
                switch (tableauCaractere[i])
                {
                    case '+':
                        resultat += (tableauNombre[i] + tableauNombre[i + 1]);
                        break;
                    case '-':
                        resultat += (tableauNombre[i] - tableauNombre[i + 1]);
                        break;
                    case '/':
                        resultat += (tableauNombre[i] / tableauNombre[i + 1]);
                        break;
                    case '*':
                        resultat += (tableauNombre[i] * tableauNombre[i + 1]);
                        break;
                }
            }
            textBox2.Text = resultat+"";
        }
    }
 }

