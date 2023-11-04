using System.Numerics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace AxonicaFalls
{
    public partial class MainUI : Form
    {
        public void UpdateUI()
        {
            //stats
            playerhealth.Text = player.health.ToString();
            playeratk.Text = player.atk.ToString();
            playerdef.Text = player.def.ToString();
            playermoney.Text = player.money.ToString();

            //room
            RoomNameLabel.Text = player.currentroom.name;
            descLabel.Text = player.currentroom.desc;
            Canvaschanger();

            //minimap
            MinimapUpdater(nButton, player.currentroom.pathN);
            MinimapUpdater(neButton, player.currentroom.pathNE);
            MinimapUpdater(nwButton, player.currentroom.pathNW);
            MinimapUpdater(eButton, player.currentroom.pathE);
            MinimapUpdater(wButton, player.currentroom.pathW);
            MinimapUpdater(sButton, player.currentroom.pathS);
            MinimapUpdater(seButton, player.currentroom.pathSE);
            MinimapUpdater(swButton, player.currentroom.pathSW);

            InventoryUpdater();


        }

        public void MinimapUpdater(Label toUpdate, int index)
        {
            if (index != -1)
            {
                toUpdate.Text = Rooms.ElementAt(index).name;
            }
            else
            {
                toUpdate.Text = "";
            }
        }

        public void Canvaschanger()
        {
            //RoomCanvas.Image = System.Drawing.Image.FromFile(@"C:\Users\dagan\source\repos\AxonicaFalls\" + player.currentroom.picname);
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            outputBox.Text = "";
            UpdateUI();
        }

      

        void InventoryUpdater()
        {
            playerinv.Text = "";

            foreach (Item item in playersinv)
            {
                playerinv.Text += " ⦿ " + item.name + ";\n";
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            Lexer(inputBox.Text);
            UpdateUI();
        }

        private void nButton_Click(object sender, EventArgs e)
        {
            Go(0);
        }

        private void neButton_Click(object sender, EventArgs e)
        {
            Go(1);
        }

        private void eButton_Click(object sender, EventArgs e)
        {
            Go(3);
        }

        private void seButton_Click(object sender, EventArgs e)
        {
            Go(6);
        }

        private void sButton_Click(object sender, EventArgs e)
        {
            Go(5);
        }

        private void swButton_Click(object sender, EventArgs e)
        {
            Go(7);
        }

        private void wButton_Click(object sender, EventArgs e)
        {
            Go(4);
        }

        private void nwButton_Click(object sender, EventArgs e)
        {
            Go(2);
        }
    }
}