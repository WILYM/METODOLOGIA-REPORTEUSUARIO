﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace METODOLOGIAS
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = int.Parse(TEXTN1.Text);
            if (A >10000 || A< 0)
            {
                report.Text = "USUARIO NO EXISTE....";
            }
            else
                report.Text = "REPORTE GENERADO....!!!!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TEXTN1.Text = "";
            report.Text = "";
        }
    }
}
