using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex04
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>() {
                "한글이다옹",
                "감자감자 왕감자",
                "Nulla iusto nam nostrum temporibus voluptatum aut enim possimus consequuntur!"
         };
        public Form1()
        {
            InitializeComponent();
            
           
            list.Add("Vel beatae neque porro natus voluptatum aspernatur?");
            list.Add("Lorem ipsum dolor sit amet consectetur adipisicing elit. Nisi repellat dolorum corrupti minima cumque cupiditate expedita, rerum molestiae accusantium aspernatur voluptatem? Vel beatae neque porro natus voluptatum aspernatur?");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            content.Text = list[new Random().Next(list.Count)];
        }
    }
}
