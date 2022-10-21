using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace logowanie
{
    public partial class Form2 : Form
    {
        const String PATH = "C:\\Users\\48668\\source\\repos\\logowanie\\logowanie\\uczniowie.txt";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            filterComboBox.SelectedIndex = 0;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            output.Clear();

            string line;
            try
            {
                StreamReader sr = new StreamReader(PATH);
                line = sr.ReadLine();
                while (line != null)
                {
                    // tuti naddaj wszystko z wyszukiwaniem

                    if (sortComboBox2.SelectedIndex == -1) 
                    {
                        if (filterComboBox.SelectedIndex == 0 && line.Split(' ')[0].ToLower().Contains(filterTextBox.Text.ToString().ToLower()))
                        {
                            //wypisywanie by imie
                            output.Text += line + "\n";
                        }
                        else if (filterComboBox.SelectedIndex == 1 && line.Split(' ')[1].ToLower().Contains(filterTextBox.Text.ToString().ToLower()))
                        {
                            //wypisywanie by nazwisko
                            output.Text += line + "\n";
                        }
                        else if (filterComboBox.SelectedIndex == 2 && line.Split(' ')[2].ToLower().Contains(filterTextBox.Text.ToString().ToLower()))
                        {
                            //wypisywanie by klasa
                            output.Text += line + "\n";
                        }
                    }
                    else if (sortComboBox2.SelectedIndex == 0)//zawiera
                    {
                        if (filterComboBox.SelectedIndex == 0 && line.Split(' ')[0].ToLower().Contains(filterTextBox.Text.ToString().ToLower()))
                        {
                            //wypisywanie by imie
                            output.Text += line + "\n";
                        }
                        else if (filterComboBox.SelectedIndex == 1 && line.Split(' ')[1].ToLower().Contains(filterTextBox.Text.ToString().ToLower()))
                        {
                            //wypisywanie by nazwisko
                            output.Text += line + "\n";
                        }
                        else if (filterComboBox.SelectedIndex == 2 && line.Split(' ')[2].ToLower().Contains(filterTextBox.Text.ToString().ToLower()))
                        {
                            //wypisywanie by klasa
                            output.Text += line + "\n";
                        }
                    }
                    else if (sortComboBox2.SelectedIndex == 1)//równe
                    {
                        if (filterComboBox.SelectedIndex == 0 && line.Split(' ')[0].ToLower() == filterTextBox.Text.ToString().ToLower())
                        {
                            //wypisywanie by imie
                            output.Text += line + "\n";
                        }
                        else if (filterComboBox.SelectedIndex == 1 && line.Split(' ')[1].ToLower() == filterTextBox.Text.ToString().ToLower())
                        {
                            //wypisywanie by nazwisko
                            output.Text += line + "\n";
                        }
                        else if (filterComboBox.SelectedIndex == 2 && line.Split(' ')[2].ToLower() == filterTextBox.Text.ToString().ToLower())
                        {
                            //wypisywanie by klasa
                            output.Text += line + "\n";
                        }

                    }
                    else if(sortComboBox2.SelectedIndex == 2)//początek
                    {
                        if (filterComboBox.SelectedIndex == 0 && line.Split(' ')[0].ToLower().StartsWith(filterTextBox.Text.ToString().ToLower()))
                        {
                            //wypisywanie by imie
                            output.Text += line + "\n";
                        }
                        else if (filterComboBox.SelectedIndex == 1 && line.Split(' ')[1].ToLower().StartsWith(filterTextBox.Text.ToString().ToLower()))
                        {
                            //wypisywanie by nazwisko
                            output.Text += line + "\n";
                        }
                        else if (filterComboBox.SelectedIndex == 2 && line.Split(' ')[2].ToLower().StartsWith(filterTextBox.Text.ToString().ToLower()))
                        {
                            //wypisywanie by klasa
                            output.Text += line + "\n";
                        }
                    }

                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ee)
            {
                Debug.WriteLine("Exception: " + ee.Message);
            }
            finally
            {
                Debug.WriteLine("Executing finally block.");
            }

        }

        private void button1_Click(object sender, EventArgs e)// dodaj ucznia
        {
            // Appending the given texts
            using (StreamWriter sw = File.AppendText(PATH))
            {
                if(textBox1.Text.ToString().Length > 2 && textBox2.Text.ToString().Length > 2 && textBox3.Text.ToString().Length > 2)
                {
                    sw.WriteLine(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }                
            }
        }
    }
}
