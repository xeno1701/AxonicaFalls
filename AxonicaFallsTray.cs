using System;
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
    public partial class AxonicaFallsTray : Form
    {
        LoadingScreen LoadingScreen = new LoadingScreen();

        public AxonicaFallsTray()
        {
            InitializeComponent();
        }

        private void AxonicaFallsTray_Load(object sender, EventArgs e)
        {
            LoadingScreen.Show();

        }
    }
}
