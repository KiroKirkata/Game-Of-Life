﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public class Rectangle
    {
        private int height;
        private int width;
        private string color;

        public int Width
        {
            get { return this.width; }
            set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    this.width = 1;
                }
            }
        }
        public int Height
        {
            get { return this.height; }
            set
            {
                if (value > 0)
                {
                    this.height = value;
                }
                else
                {
                    this.height = 1;
                }
            }
        }
        public string Color
        {
            get { return this.color; }
            set
            {
                if (value != null)
                {
                    this.color = value;
                }
                else
                {
                    this.color = "colorless";
                }
            }
        }

        public Rectangle(int width, int height, string color)
        {
            this.Width = width;
            this.Height = height;
            this.Color = color;
        }
        public int CalcArea()
        {
            return this.Width * this.Height;
        }
    }
}
