﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vyjimky00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a,b,podil;
            if (int.TryParse(textBox1.Text, out a))
            {
                if (int.TryParse(textBox2.Text, out b))
                {
                    if (b != 0)
                    {
                        podil = a / b;
                        MessageBox.Show(podil.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Nelze dělit nulou");
                        textBox2.Focus();
                        textBox2.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Zadejte cislo");
                    textBox2.Focus();
                    textBox2.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Zadejte cislo");
                textBox1.Focus();
                textBox1.SelectAll();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, podil;
            try 
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                podil = a / b;
                MessageBox.Show(podil.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, podil;
            try
            {
                a = int.Parse(textBox1.Text);
                try
                {
                    b = int.Parse(textBox2.Text);
                        podil = a / b;
                        MessageBox.Show("podil je: " + podil);
                }
                catch (FormatException)
                {
                    MessageBox.Show("musíš zadat celé číslo");
                    textBox2.Focus();
                    textBox2.SelectAll();

                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show("Nulou delit nelze.");
                    textBox2.Focus();
                    textBox2.SelectAll();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("musíš zadat celé číslo");
                textBox1.Focus();
                textBox1.SelectAll();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] p = new int[10];
            try
            {
                int index = int.Parse(textBox3.Text);
                p[index] = 100;
                MessageBox.Show("Do prvku pole se zadaným pole bylo zadáno číslo");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Zadej maximálně 9");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Pozor! nejsou ošetřeny výjimky  FormatException a OverflowException
            int a, b, soucin;
            a = int.Parse(textBox4.Text);
            b = int.Parse(textBox5.Text);
            soucin = a * b;
            MessageBox.Show(soucin.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            //V textovém souboru Text.txt jsou v řádcích zapsána celá čísla
            //Sečtěte všechna celá čísla v souboru a jednotlivé řádky průběžně zobrazujte v ListBox
            //Řádky s chybou (není to číslo, číslo mimo rozsah) nebudou do součtu zahrnuty - ošetřete pomocí výjimek


            listBox1.Items.Clear();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //blok using
            //***********
            //Jen přečteme textový soubor a zobrazíme v listBox

            //Notace using, zjednodušuje práci s instancemi tříd pro čtení a zápis do souborů. Blok using nahrazuje blok try a finally.
            //blok finally C# vygeneruje sám a sám zajistí, aby daná instance readeru nebo writeru soubor uzavřela.

            //using nahrazuje pouze try-finally, nikoli catch!.
            //Metodu, ve které se použivá using, musíme stejně volat v try-catch bloku.

            listBox1.Items.Clear();
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //nechceme celočíselně dělit menší číslo větším - sami vyhodíme výjimku ArithmeticException
            

        }
        //Vytvoříme vlastní třídu výjimky - DelitelException - odvozenou od vhodné třídy
        //class DelitelException : ArithmeticException { };

        private void button10_Click(object sender, EventArgs e)
        {
            //nechceme celočíselně dělit menší číslo větším - vyhodíme vlastní výjimku DelitelException
            int x = int.Parse(textBox7.Text);
            int y = int.Parse(textBox8.Text);
            
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //blok finally - proběhne VŽDY!
            //*****************************
            //Zobrazte textový soubor Text.txt v listBox1
            //Pomocí výjimky ošetřete existenci souboru
            listBox1.Items.Clear();
            
            
        }
    }
}
