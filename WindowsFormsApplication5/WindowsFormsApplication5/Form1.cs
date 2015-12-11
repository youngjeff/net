using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                if(listBox1.MultiColumn == false)
                {
                    listBox2.Items.Add(listBox1.SelectedItem);
                }
                else
                {
                    foreach(object objectem in listBox1.SelectedItems)
                    {
                        listBox2.Items.Add(objectem);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedIndex != -1)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                listBox1.MultiColumn = true;//控制单选和多选
                listBox1.SelectionMode = SelectionMode.MultiExtended;

            }
            else
            {
                listBox1.MultiColumn = false;
                listBox1.SelectionMode = SelectionMode.One;
            }
        }
    }
}
