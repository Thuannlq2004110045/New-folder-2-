﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormQLSanPham : Form
    {
        public FormQLSanPham()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQLNhanVien formQLNhanVien = new FormQLNhanVien();
            formQLNhanVien.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
