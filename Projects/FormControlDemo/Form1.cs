﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControlDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ((ToolStripMenuItem)menuStrip1.Items[0]).DropDownItems.RemoveAt(0);
        }
        
    }
}
