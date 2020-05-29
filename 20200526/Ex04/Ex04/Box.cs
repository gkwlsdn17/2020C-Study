using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex04
{
    class Box
    {
        private double width = 0;
        public double mWidth
        {
            get
            {
                return width;
            }
            set
            {
                if(value > 0)
                {
                    width = value;
                }
                else
                {
                    MessageBox.Show("(너비) 0 이상의 숫자를 입력해주세요");
                }
            }
        }
        private double height = 0;
        public double mHeight
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    MessageBox.Show("(너비) 0 이상의 숫자를 입력해주세요");
                }
            }
        }

        //public Box(double w, double h)
        //{
        //    if(w>0 && h > 0)
        //    {
        //        this.width = w;
        //        this.height = h;
        //    }
        //    else
        //    {
        //        MessageBox.Show("너비와 높이는 양수로 부탁드립니다");
        //    }

        //}
        public double Area()
        {
            return width * height;
        }
        public void setWidth(double w)
        {
            if (w > 0)
                this.width = w;
            else
                MessageBox.Show("양수를 입력하세요");
        }
        public void setHeight(double h)
        {
            if (h > 0)
                this.height = h;
            else
                MessageBox.Show("양수를 입력하세요");
        }
    }
}
