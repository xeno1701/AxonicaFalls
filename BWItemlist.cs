﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxonicaFalls
{
    public partial class BWItemlist : Form
    {
        public BWItemlist(List<MainUI.Item> playerinv)
        {
            InitializeComponent();

            INVLIST.Items.Clear();
            foreach (MainUI.Item item in playerinv)
            {
                INVLIST.Items.Add(item.name);
            }
            
        }

        private void invMenuPopout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
