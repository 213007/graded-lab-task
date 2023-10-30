using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _213007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            String result;

            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "")
            {

                if (comboBox1.SelectedIndex == 0)
                {


                    if (comboBox2.SelectedIndex == 0)
                    {
                        if (comboBox3.SelectedIndex == 0)
                        {
                            textBox2.Text = textBox1.Text;
                        }
                        else if (comboBox3.SelectedIndex == 1)
                        {
                            float a = float.Parse(textBox1.Text) / 60;
                            textBox2.Text = a.ToString();
                        }
                        else
                        {
                            float a = float.Parse(textBox1.Text) / 3600;
                            textBox2.Text = a.ToString();
                        }
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        if (comboBox3.SelectedIndex == 0)
                        {
                            float a = float.Parse(textBox1.Text) * 60;
                            textBox2.Text = a.ToString();

                        }
                        else if (comboBox3.SelectedIndex == 1)
                        {
                            textBox2.Text = textBox1.Text;
                        }
                        else
                        {
                            float a = float.Parse(textBox1.Text) / 60;
                            textBox2.Text = a.ToString();
                        }
                    }
                    else
                    {
                        if (comboBox3.SelectedIndex == 0)
                        {
                            float a = float.Parse(textBox1.Text) * 3600;
                            textBox2.Text = a.ToString();

                        }
                        else if (comboBox3.SelectedIndex == 1)
                        {
                            float a = float.Parse(textBox1.Text) * 60;
                            textBox2.Text = a.ToString();
                        }
                        else
                        {
                            textBox2.Text = textBox1.Text;

                        }
                    }

                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        if (comboBox3.SelectedIndex == 0)
                        {
                            textBox2.Text = textBox1.Text;
                        }
                        else if (comboBox3.SelectedIndex == 1)
                        {
                            float a = (float)(float.Parse(textBox1.Text) * (144));
                            textBox2.Text = a.ToString();
                        }
                        else
                        {
                            float a = (float)(float.Parse(textBox1.Text) * (0.092903));
                            textBox2.Text = a.ToString();
                        }
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        if (comboBox3.SelectedIndex == 0)
                        {
                            float a = (float)(float.Parse(textBox1.Text) * (0.00694444));
                            textBox2.Text = a.ToString();

                        }
                        else if (comboBox3.SelectedIndex == 1)
                        {
                            textBox2.Text = textBox1.Text;
                        }
                        else
                        {
                            float a = (float)(float.Parse(textBox1.Text) * (0.00064516));
                            textBox2.Text = a.ToString();
                        }
                    }
                    else
                    {
                        if (comboBox3.SelectedIndex == 0)
                        {
                            float a = (float)(float.Parse(textBox1.Text) * (10.7639));
                            textBox2.Text = a.ToString();

                        }
                        else if (comboBox3.SelectedIndex == 1)
                        {
                            float a = (float)(float.Parse(textBox1.Text) * (1550));
                            textBox2.Text = a.ToString();
                        }
                        else
                        {
                            textBox2.Text = textBox1.Text;

                        }
                    }

                }
                else if (comboBox1.SelectedIndex == 2)
                {

                    if (comboBox2.SelectedIndex == 0)
                    {
                        if (comboBox3.SelectedIndex == 0)
                        {
                            textBox2.Text = textBox1.Text;
                        }
                        else if (comboBox3.SelectedIndex == 1)
                        {
                            float a = (float)(float.Parse(textBox1.Text) * (1000));
                            textBox2.Text = a.ToString();
                        }
                        else
                        {
                            float a = (float)(float.Parse(textBox1.Text) * (100000));
                            textBox2.Text = a.ToString();
                        }
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        if (comboBox3.SelectedIndex == 0)
                        {
                            float a = (float)(float.Parse(textBox1.Text) / (1000));
                            textBox2.Text = a.ToString();

                        }
                        else if (comboBox3.SelectedIndex == 1)
                        {
                            textBox2.Text = textBox1.Text;
                        }
                        else
                        {
                            float a = (float)(float.Parse(textBox1.Text) * (100));
                            textBox2.Text = a.ToString();
                        }
                    }
                    else
                    {
                        if (comboBox3.SelectedIndex == 0)
                        {
                            float a = (float)(float.Parse(textBox1.Text) / (100000));
                            textBox2.Text = a.ToString();

                        }
                        else if (comboBox3.SelectedIndex == 1)
                        {
                            float a = (float)(float.Parse(textBox1.Text) / (100));
                            textBox2.Text = a.ToString();
                        }
                        else
                        {
                            textBox2.Text = textBox1.Text;

                        }
                    }
                }
                else
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        if (comboBox3.SelectedIndex == 0)
                        {
                            textBox2.Text = textBox1.Text;
                        }
                        else if (comboBox3.SelectedIndex == 1)
                        {
                            float a = (float)(float.Parse(textBox1.Text) * (1.8) + (32.0));
                            textBox2.Text = a.ToString();
                        }
                        else
                        {
                            float a = (float)(float.Parse(textBox1.Text) + (273.15));
                            textBox2.Text = a.ToString();
                        }
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        if (comboBox3.SelectedIndex == 0)
                        {
                            float a = (float)((float.Parse(textBox1.Text) - (32.0)) * (0.5555555556));
                            textBox2.Text = a.ToString();

                        }
                        else if (comboBox3.SelectedIndex == 1)
                        {
                            textBox2.Text = textBox1.Text;
                        }
                        else
                        {
                            float a = (float)((float.Parse(textBox1.Text) - (32.0)) * (0.5555555556) + (273.15));
                            textBox2.Text = a.ToString();
                        }
                    }
                    else
                    {
                        if (comboBox3.SelectedIndex == 0)
                        {
                            float a = (float)(float.Parse(textBox1.Text) - (273.15));
                            textBox2.Text = a.ToString();

                        }
                        else if (comboBox3.SelectedIndex == 1)
                        {
                            float a = (float)((float.Parse(textBox1.Text) - (273.15)) * (1.8) + (32.0));
                            textBox2.Text = a.ToString();
                        }
                        else
                        {
                            textBox2.Text = textBox1.Text;

                        }
                    }
                }
            }
            else
            {
                label3.Text = "Please fill all credentials";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox2.Items.Add("Seconds");
                comboBox2.Items.Add("Minuites");
                comboBox2.Items.Add("Hour");
                comboBox3.Items.Add("Seconds");
                comboBox3.Items.Add("Minuites");
                comboBox3.Items.Add("Hours");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox2.Items.Add("Feet");
                comboBox2.Items.Add("Inch");
                comboBox2.Items.Add("Meter");
                comboBox3.Items.Add("Feet");
                comboBox3.Items.Add("Inch");
                comboBox3.Items.Add("Meter");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox2.Items.Add("Kilometer");
                comboBox2.Items.Add("Meter");
                comboBox2.Items.Add("Centimeter");
                comboBox3.Items.Add("Kilometer");
                comboBox3.Items.Add("Meter");
                comboBox3.Items.Add("Centimeter");
            }
            else
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox2.Items.Add("Celsius");
                comboBox2.Items.Add("Fahrenheit");
                comboBox2.Items.Add("Kelvin");
                comboBox3.Items.Add("Celsius");
                comboBox3.Items.Add("Fahrenheit");
                comboBox3.Items.Add("Kelvin");

            }
        }
    }
}
