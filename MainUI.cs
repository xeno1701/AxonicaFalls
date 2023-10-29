using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AxonicaFalls
{
    public partial class MainUI : Form
    {
        Engine engine = new Engine();
        public MainUI()
        {
            InitializeComponent();
        }

        public void UpdateUI()
        {
            //stats
            playerhealth.Text = engine.player.health.ToString();
            playeratk.Text = engine.player.atk.ToString();
            playerdef.Text = engine.player.def.ToString();
            playermoney.Text = engine.player.money.ToString();

            //room
            RoomNameLabel.Text = engine.player.currentroom.name;
            descLabel.Text = engine.player.currentroom.desc;
            Canvaschanger();

            //minimap
            MinimapUpdater(nButton, engine.player.currentroom.pathN);
            MinimapUpdater(neButton, engine.player.currentroom.pathNE);
            MinimapUpdater(nwButton, engine.player.currentroom.pathNW);
            MinimapUpdater(eButton, engine.player.currentroom.pathE);
            MinimapUpdater(wButton, engine.player.currentroom.pathW);
            MinimapUpdater(sButton, engine.player.currentroom.pathS);
            MinimapUpdater(seButton, engine.player.currentroom.pathSE);
            MinimapUpdater(swButton, engine.player.currentroom.pathSW);


        }

        public void MinimapUpdater(Label toUpdate, int index)
        {
            if (index != -1)
            {
                toUpdate.Font = new Font(toUpdate.Font, FontStyle.Regular);
                toUpdate.Text = engine.Rooms[index].name;
            }
            else
            {
                toUpdate.Font = new Font(toUpdate.Font, FontStyle.Italic);
                toUpdate.Text = "Blocked";
            }
        }

        public void Canvaschanger()
        {
            RoomCanvas.Image = System.Drawing.Image.FromFile(@"C:\Users\dagan\source\repos\AxonicaFalls\" + engine.player.currentroom.picname);
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            outputBox.Text = "";
            bool keepPlaying = true;
            UpdateUI();
        }

        public void clOut(string output)
        {
            outputBox.Text += output + Environment.NewLine;
            int maxLines = 10;
            if (outputBox.Text.Split('\n').Length > maxLines)
            {
                int index = outputBox.Text.IndexOf(Environment.NewLine);
                outputBox.Text = outputBox.Text.Substring(index + Environment.NewLine.Length);
            }

        }
        public void cOut(string output)
        {
            outputBox.Text += output;
            int maxLines = 10;
            if (outputBox.Text.Split('\n').Length > maxLines)
            {
                int index = outputBox.Text.IndexOf(Environment.NewLine);
                outputBox.Text = outputBox.Text.Substring(index + Environment.NewLine.Length);
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            engine.Lexer(inputBox.Text);
            UpdateUI();
        }
    }
}