using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex02
{
    public partial class Form1 : Form
    {
        public List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
            //int[] array = new int[10];
            //List<int> list = new List<int>() { 1, 2, 3, 4 };
            //foreach(var item in list)
            //{
            //    Console.WriteLine($"item: {item}");
            //}
            //list.Remove(4);
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.RemoveAt(0);

            Random rand = new Random();
            button1.Text = rand.Next(100).ToString();
            button5.Text = button1.Text;

            button2.Text = rand.Next(100).ToString();
            button6.Text = button2.Text;

            button3.Text = rand.Next(100).ToString();
            button7.Text = button3.Text;

            button4.Text = rand.Next(100).ToString();
            button8.Text = button4.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(button1.Text);
            listarr.Text = "";
            foreach (var item in list)
            {
                listarr.Text += item + " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.Add(button2.Text);
            listarr.Text = "";
            foreach (var item in list)
            {
                listarr.Text += item + " ";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            list.Add(button3.Text);
            listarr.Text = "";
            foreach (var item in list)
            {
                listarr.Text += item + " ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.Add(button4.Text);
            listarr.Text = "";
            foreach (var item in list)
            {
                listarr.Text += item + " ";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            list.Remove(button1.Text);
            listarr.Text = "";
            foreach (var item in list)
            {
                listarr.Text += item + " ";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            list.Remove(button2.Text);
            listarr.Text = "";
            foreach (var item in list)
            {
                listarr.Text += item + " ";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            list.Remove(button3.Text);
            listarr.Text = "";
            foreach (var item in list)
            {
                listarr.Text += item + " ";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            list.Remove(button4.Text);
            listarr.Text = "";
            foreach (var item in list)
            {
                listarr.Text += item + " ";
            }
        }
    }
}
