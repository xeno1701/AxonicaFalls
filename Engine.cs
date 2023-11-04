using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxonicaFalls
{
    public partial class MainUI : Form
    {
        public MainUI()
        {

            InitializeComponent();
            Room temproom;
            /*
             Max chars for text 78
            temproom.provcode = Province.Judium;
            temproom.code = ;
            temproom.name = "";
            temproom.desc = ""; 
            temproom.picname = "";
            temproom.radiolevel = ;
            temproom.pathN = ;
            temproom.pathNE = ;
            temproom.pathNW = ;
            temproom.pathE = ;
            temproom.pathW = ;
            temproom.pathS = ;
            temproom.pathSE = ;
            temproom.pathSW = ;
            temproom.items = new List<Item>();
            temproom.roomevents = new List<Event>();
            Rooms.Add(temproom);
            */

            temproom.provcode = Province.Judium;
            temproom.roomcode = 0;
            temproom.name = "Fountain";
            temproom.desc = "The centre of town. All paths in your story lead from here.";
            temproom.picname = @"room0.png";
            temproom.radiolevel = 0;
            temproom.pathN = 1;
            temproom.pathNE = 6;
            temproom.pathNW = -1;
            temproom.pathE = 4;
            temproom.pathW = 2;
            temproom.pathS = 3;
            temproom.pathSE = 5;
            temproom.pathSW = -1;
            temproom.items = new List<Item>();
            temproom.roomevents = new List<Event>();
            Rooms.Add(temproom);


            temproom.provcode = Province.Judium;
            temproom.roomcode = 1;
            temproom.name = "Tavern";
            temproom.desc = "The life and soul of social gatherings in Judium. The music is local, light, live and lovely.";
            temproom.picname = @"room1.png";
            temproom.radiolevel = 0;
            temproom.pathN = -1;
            temproom.pathNE = -1;
            temproom.pathNW = -1;
            temproom.pathE = -1;
            temproom.pathW = -1;
            temproom.pathS = 0;
            temproom.pathSE = -1;
            temproom.pathSW = -1;
            temproom.items = new List<Item>();
            temproom.roomevents = new List<Event>();
            Rooms.Add(temproom);


            temproom.provcode = Province.Judium;
            temproom.roomcode = 2;
            temproom.name = "Library";
            temproom.desc = "The largest building in Judium, working as a Library and a Town Hall.";
            temproom.picname = @"room2.png";
            temproom.radiolevel = 0;
            temproom.pathN = -1;
            temproom.pathNE = -1;
            temproom.pathNW = -1;
            temproom.pathE = 0;
            temproom.pathW = -1;
            temproom.pathS = -1;
            temproom.pathSE = -1;
            temproom.pathSW = -1;
            temproom.items = new List<Item>();
            temproom.roomevents = new List<Event>();
            Rooms.Add(temproom);

            temproom.provcode = Province.Judium;
            temproom.roomcode = 3;
            temproom.name = "Restaurant";
            temproom.desc = "The best place for a proper cooked meal in Judium. You eat for less money as your aunt owns it.";
            temproom.picname = @"room3.png";
            temproom.radiolevel = 0;
            temproom.pathN = 0;
            temproom.pathNE = -1;
            temproom.pathNW = -1;
            temproom.pathE = -1;
            temproom.pathW = -1;
            temproom.pathS = -1;
            temproom.pathSE = -1;
            temproom.pathSW = -1;
            temproom.items = new List<Item>();
            temproom.roomevents = new List<Event>();
            Rooms.Add(temproom);

            temproom.provcode = Province.Judium;
            temproom.roomcode = 4;
            temproom.name = "Store";
            temproom.desc = "Your parents' store. A sort of pawn shop various odds and ends.";
            temproom.picname = @"room4.png";
            temproom.radiolevel = 0;
            temproom.pathN = -1;
            temproom.pathNE = -1;
            temproom.pathNW = -1;
            temproom.pathE = -1;
            temproom.pathW = 0;
            temproom.pathS = -1;
            temproom.pathSE = -1;
            temproom.pathSW = -1;
            temproom.items = new List<Item>();
            temproom.roomevents = new List<Event>();
            Rooms.Add(temproom);

            temproom.provcode = Province.Judium;
            temproom.roomcode = 5;
            temproom.name = "Shelter";
            temproom.desc = "A large metal hatch to the shelter. The war makes this place the scariest and the safest at the same time.";
            temproom.picname = @"room5.png";
            temproom.radiolevel = 0;
            temproom.pathN = -1;
            temproom.pathNE = 0;
            temproom.pathNW = -1;
            temproom.pathE = -1;
            temproom.pathW = -1;
            temproom.pathS = -1;
            temproom.pathSE = -1;
            temproom.pathSW = -1;
            temproom.items = new List<Item>();
            temproom.roomevents = new List<Event>();
            Rooms.Add(temproom);

            temproom.provcode = Province.Judium;
            temproom.roomcode = 6;
            temproom.name = "Trail";
            temproom.desc = "The path out of Judium, away to the city. Don't let the danger hold you back.";
            temproom.picname = @"room2.png";
            temproom.radiolevel = 0;
            temproom.pathN = -1;
            temproom.pathNE = -1; //new path room
            temproom.pathNW = -1;
            temproom.pathE = -1;
            temproom.pathW = -1;
            temproom.pathS = -1;
            temproom.pathSE = 0;
            temproom.pathSW = -1;
            temproom.items = new List<Item>();
            temproom.roomevents = new List<Event>();
            Rooms.Add(temproom);




            Item tempitem;

            tempitem.code = 1;
            tempitem.name = "Gold Coins";
            tempitem.text = "The coins were legal tender, detailed with text and images of the kingdom.";
            tempitem.type = ItemType.Generic;
            tempitem.startroom = 1;
            tempitem.itemradiolevel = 0.5;
            tempitem.availability = false;
            itemlist.Add(tempitem);
            avaliableitems.Add(tempitem);

            tempitem.code = 2;
            tempitem.name = "Small Coin Wallet";
            tempitem.text = "The handcrafted leather coin wallet was mildly aged and was perfect for throwing thiefs off the tracks if they wanted to steal something...";
            tempitem.type = ItemType.Generic;
            tempitem.startroom = 1;
            tempitem.itemradiolevel = 0.7;
            tempitem.availability = false;
            itemlist.Add(tempitem);
            playersinv.Add(tempitem);
            avaliableitems.Add(tempitem);


            foreach (Item i in itemlist)
            {
                foreach (Room r in Rooms)
                {
                    if (i.startroom == r.roomcode)
                    {
                        r.items.Add(i);
                    }
                }
            }

            player.health = 20;
            player.atk = 0;
            player.def = 0;
            player.money = 0;
            player.currentroom = Rooms[0];
        }
        // Rooms
        public List<Room> Rooms = new List<Room>();
        // Items
        public List<Item> itemlist = new List<Item>();
        public List<Item> avaliableitems = new List<Item>();
        // Player
        public PlayableChar player;
        public List<Item> playersinv = new List<Item>();

        string[] PickPhrases = { "PICK", "GRAB", "GET", "HUNT", "SCAVENGE", "ADD" };
        string[] ConnectPhrases = { "AND", "FOR", "TO", "BUT", "OR", "UP", "THE" };



        public enum ItemType
        {
            Affector = 0, //These items are like armour
            Generic = 1, //These items are like pebbles
            Food = 2,
            Weapon = 3,

        }
        public struct Item
        {
            public int code;
            public string name;
            public string text;
            public ItemType type;
            public int startroom;
            public bool availability;
            public double itemradiolevel;
        }
        public struct Room
        {
            public Province provcode;
            public int roomcode;
            public string name;
            public string desc;
            public string picname;
            public double radiolevel;
            public int pathN;
            public int pathNE;
            public int pathNW;
            public int pathS;
            public int pathSE;
            public int pathSW;
            public int pathW;
            public int pathE;
            public List<Item> items;
            public List<Event> roomevents;
        }
        public struct Event
        {
            public int initlocation; //-1 if its not a location starter
            public int inititem; //-1 if its not an item starter
            public string description;
            public int resultitem;
        }

        public enum Province
        {
            Judium = 0
        }
        public struct Token
        {
            public string original;
            public string processed;
        }

        public struct PlayableChar
        {
            public Room currentroom;
            public double health;
            public double radiolevel;
            public double atk;
            public double def;
            public double money;
        }


        public void Lexer(string inputstring)
        {
            string[] splitter = inputstring.Split(' ');
            List<Token> tokens = new List<Token>();
            for (int i = 0; i < splitter.Length; i++)
            {
                Token temptoken;
                temptoken.original = splitter[i];
                temptoken.processed = splitter[i].ToUpper();
                tokens.Add(temptoken);
            }
            foreach (Token token in tokens)
            {
                foreach (string str in ConnectPhrases)
                {
                    if (token.processed == str)
                    {
                        tokens.Remove(token);
                    }
                }

            }
            if (LexerSearch(PickPhrases, tokens))
            {
                PickUp();
            }

        }

        bool LexerSearch(string[] phrasebook, List<Token> tokens)
        {
            foreach (Token token in tokens)
            {
                foreach (string str in phrasebook)
                {
                    if (token.processed == str)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        void PickUp()
        {
            clOut("tesstinggg");
        }

        public void clOut(string output)
        {
            outputBox.Text += output + Environment.NewLine;
            int maxLines = 9;
            if (outputBox.Text.Split('\n').Length > maxLines)
            {
                int index = outputBox.Text.IndexOf(Environment.NewLine);
                outputBox.Text = outputBox.Text.Substring(index + Environment.NewLine.Length);
            }

        }
        public void cOut(string output)
        {

            outputBox.Text += output;
            int maxLines = 9;
            if (outputBox.Text.Split('\n').Length > maxLines)
            {
                int index = outputBox.Text.IndexOf(Environment.NewLine);
                outputBox.Text = outputBox.Text.Substring(index + Environment.NewLine.Length);
            }
        }

        void Go(int index)
        {
            switch (index)
            {
                case 0: //north
                    roomSwitcher(player.currentroom.pathN);
                    break;
                case 1: //north east
                    roomSwitcher(player.currentroom.pathNE);
                    break;
                case 2: //north west
                    roomSwitcher(player.currentroom.pathNW);
                    break;
                case 3: //east
                    roomSwitcher(player.currentroom.pathE);
                    break;
                case 4: //west
                    roomSwitcher(player.currentroom.pathW);
                    break;
                case 5: //south
                    roomSwitcher(player.currentroom.pathS);
                    break;
                case 6: //south east
                    roomSwitcher(player.currentroom.pathSE);
                    break;
                case 7: //south west
                    roomSwitcher(player.currentroom.pathSW);
                    break;
            }
            UpdateUI();
        }
        void roomSwitcher(int switcher)
        {
            if (switcher == -1)
            {
                invalidchoice(0);
            }
            else
            {
                player.currentroom = Rooms.ElementAt(switcher);
            }
        }
        void invalidchoice(int choice)
        {
            switch (choice)
            {
                case 0:
                    clOut("Sorry that path is blocked.");
                    break;
            }

        }
    }
}
