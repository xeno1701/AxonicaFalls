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
    public partial class LoadingScreen : Form
    {
        MainUI MainUI = new MainUI();
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer MyTimer = new System.Windows.Forms.Timer();
            MyTimer.Interval = (3000);
            MyTimer.Tick += new EventHandler(runMainUI);
            MyTimer.Start();

        }

        void runMainUI(object sender, EventArgs eArgs)
        {
            try
            {
                MainUI.Show();
            }
            catch
            {
                Application.Exit();
            }
            Close();
        }
    }
}
