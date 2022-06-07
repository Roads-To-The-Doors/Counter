using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Plus_Click(object sender, EventArgs e)
        {
            minus_1.Visible = false;

            minus_5.Visible = false;

            minus_10.Visible = false;

            plus_1.Visible = true;

            plus_5.Visible = true;

            plus_10.Visible = true;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            minus_1.Visible = true;

            minus_5.Visible = true;

            minus_10.Visible = true;

            plus_1.Visible = false;

            plus_5.Visible = false;

            plus_10.Visible = false;
        }

        private void plus_1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(Out.Text);

            Out.Text = Convert.ToString(++number);
        }

        private void plus_5_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(Out.Text);

            Out.Text = Convert.ToString(number += 5);
        }

        private void plus_10_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(Out.Text);

            Out.Text = Convert.ToString(number += 10);
        }

        private void minus_1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(Out.Text);

            Out.Text = Convert.ToString(--number);
        }

        private void minus_5_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(Out.Text);

            Out.Text = Convert.ToString(number -= 5);
        }

        private void minus_10_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(Out.Text);

            Out.Text = Convert.ToString(number -= 10);
        }
    }
}
