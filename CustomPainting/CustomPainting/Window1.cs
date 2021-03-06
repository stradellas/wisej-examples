﻿
using System;
using System.Drawing;
using Wisej.Web;

namespace CustomPainting
{
	public partial class Window1 : Form
	{
		public Window1()
		{
			InitializeComponent();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Tag = "redraw";
            button1.Invalidate(false);

        }

        private void button1_Paint(object sender, PaintEventArgs e)
		{
            Button _button = (Button)sender;
            if (_button.Tag != null)
            {
                e.Graphics.FillRectangle(Brushes.Yellow, new Rectangle(10, 10, this.button1.Width / 10, this.button1.Height - 20));
            }
		}
	}
}
