using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static AxonicaFalls.MainUI;

namespace AxonicaFalls
{
    public partial class MainUI
    {
        public MainUI()
        {
            InitializeComponent();

            Room temproom;
            temproom = new Room(Province.Judium, 0, "Fountain", "The centre of town. All paths in your story lead from here.", 0, 1, 6, -1, 4, 2, 3, 5, -1);
            Rooms.Add(temproom);
            temproom = new Room(Province.Judium, 1, "Tavern", "The life and soul of social gatherings in Judium. The music is local, light, live and lovely.", 0, -1, -1, -1, -1, -1, 0, -1, -1);
            Rooms.Add(temproom);
            temproom = new Room(Province.Judium, 2, "Library", "The largest building in Judium, working as a Library and a Town Hall.", 0, -1, -1, -1, 0, -1, -1, -1, -1);
            Rooms.Add(temproom);
            temproom = new Room(Province.Judium, 3, "Diner", "The best place for a proper cooked meal in Judium. You eat for less money as your aunt owns it.", 0, 0, -1, -1, -1, -1, -1, -1, -1);
            Rooms.Add(temproom);
            temproom = new Room(Province.Judium, 4, "Store", "Your parents' store. A sort of pawn shop various odds and ends.", 0, -1, -1, -1, -1, -1, -1, -1, 0);
            Rooms.Add(temproom);
            temproom = new Room(Province.Judium, 5, "Shelter", "\"A large metal hatch to the shelter. The war makes this place the scariest and the safest at the same time.", 0, -1, 0, -1, -1, -1, -1, -1, -1);
            Rooms.Add(temproom);
            temproom = new Room(Province.Judium, 6, "Trail", "The path out of Judium, away to the city. Don't let the danger hold you back.", 0, -1, -1, -1, -1, 0, -1, -1, -1);
            Rooms.Add(temproom);

            Item tempitem;
            List<int> tempcomfinedfrom = new List<int>();
            tempitem = new Item(1, "Gold Coins", "The coins were legal tender, detailed with text and images of the kingdom.", ItemType.Generic, 1, false, 0, tempcomfinedfrom);
            itemlist.Add(tempitem);
            avaliableitems.Add(tempitem);
            tempitem = new Item(1, "Small Coin Wallet", "The handcrafted leather coin wallet was mildly aged and was perfect for throwing thiefs off the tracks if they wanted to steal something...", ItemType.Generic, 1, false, 0, tempcomfinedfrom);
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
        string[] SpeakPhrases = { "SPEAK", "TALK", "CHAT"};
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
            public List<int> combinedfrom;

            public Item(int code, string name, string text, ItemType type, int startroom, bool availability, double itemradiolevel, List<int> combinedfrom)
            {
                this.code = code;
                this.name = name;
                this.text = text;
                this.type = type;
                this.startroom = startroom;
                this.availability = availability;
                this.itemradiolevel = itemradiolevel;
                this.combinedfrom = combinedfrom;
            }
        }
        public struct Room
        {
            public Province provcode;
            public int roomcode;
            public string name;
            public string desc;
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

            public Room(Province provcode, int roomcode, string name, string desc, double radiolevel, int pathN, int pathNE, int pathNW, int pathS, int pathSE, int pathSW, int pathE, int pathW)
            {
                this.provcode = provcode;
                this.roomcode = roomcode;
                this.name = name;
                this.desc = desc;
                this.radiolevel = radiolevel;
                this.pathN = pathN;
                this.pathNE = pathNE;
                this.pathNW = pathNW;
                this.pathS = pathS;
                this.pathSE = pathSE;
                this.pathSW = pathSW;
                this.pathE = pathE;
                this.pathW = pathW;
                this.items = new List<Item>();
                this.roomevents = new List<Event>();
            }
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
            for (int i = 0; i < tokens.Count; i++)
            {
                foreach (string str in ConnectPhrases)
                {
                    if (tokens[i].processed == str)
                    {
                        tokens.RemoveAt(i);
                    }
                }

            }
            if (LexerSearch(PickPhrases, tokens))
            {
                tokens.RemoveAt(0);
                inputBox.Clear();
                PickUp(tokens);

                
            }

            if (LexerSearch(SpeakPhrases, tokens))
            {
                SpeakTo();
            }

        }
        void SpeakTo()
        {
            
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

        void PickUp(List<Token> tokens)
        {
            bool founditem = false;
            string join = "";
            foreach (Token token in tokens)
            {
                join += token.processed + " ";  
            }
            join = join.Trim();
                foreach(Item item in player.currentroom.items)
                {
                    if(join == item.name.ToUpper())
                    {
                        playersinv.Add(item);
                        player.currentroom.items.Remove(item);
                        clOut(("You picked up "+ item.name + "."));
                        founditem = true;
                        break;
                    }
                }

            if (!founditem)
            {
                string itemsearchedfor = "";
                foreach (Token token in tokens)
                {
                    itemsearchedfor += token.original + " ";
                }
               clOut("You couldn't see " + itemsearchedfor + "nearby.");
            }
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
