using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cif_ve_tek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("HATA boş bırakmayınız");
            }

            else
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
                textBox1.Focus();


                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (Convert.ToInt32(listBox1.Items[i]) % 2 == 0)
                    {
                        listBox2.Items.Add(listBox1.Items[i]);
                    }

                    else
                    {
                        listBox3.Items.Add(listBox1.Items[i]);
                    }
                }
                listBox1.Items.Clear();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            /*
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                if (Convert.ToInt32(listBox1.Items[i]) % 2 == 0)
                {
                    listBox2.Items.Add(listBox1.Items[i]);
                }

                else
                {
                    listBox3.Items.Add(listBox1.Items[i]);
                }
            }
            listBox1.Items.Clear();
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("HATA boş bırakmayınız");
            }

            else
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
                textBox1.Focus();

                int i = 0;
                while (i < listBox1 .Items.Count)
                {
                    if (Convert.ToInt32(listBox1.Items[i]) % 2 == 0)
                    {
                        listBox2.Items.Add(listBox1.Items[i]);
                    }

                    else
                    {
                        listBox3.Items.Add(listBox1.Items[i]);
                    }
                    
                    
                    
                    i++;
                }
                
                
                
                
                listBox1.Items.Clear();
            }
        }
    }
}
