﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseConnectionWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.universityDataSet.Students);
            // TODO: This line of code loads data into the 'universityDataSet.Teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.universityDataSet.Teachers);
            // TODO: This line of code loads data into the 'universityDataSet.Rostra' table. You can move, or remove it, as needed.
            this.rostraTableAdapter.Fill(this.universityDataSet.Rostra);

        }
    }
}
