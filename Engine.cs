using static AxonicaFalls.Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AxonicaFalls
{
    public class Engine
    {
        MainUI mainUI;
        public Engine()
        {
            Room temproom;
            /*
             Max chars for text 78
            Rooms[].provcode = Province.Judium;
            Rooms[].code = ;
            Rooms[].name = "";
            Rooms[].desc = ""; 
            Rooms[].picname = "";
            Rooms[].radiolevel = ;
            Rooms[].pathN = ;
            Rooms[].pathNE = ;
            Rooms[].pathNW = ;
            Rooms[].pathE = ;
            Rooms[].pathW = ;
            Rooms[].pathS = ;
            Rooms[].pathSE = ;
            Rooms[].pathSW = ;
            Rooms[].items = new List<Item>();
            Rooms[].roomevents = new List<Event>();
            */

            Rooms[0].provcode = Province.Judium;
            Rooms[0].roomcode = 0;
            Rooms[0].name = "Fountain";
            Rooms[0].desc = "The centre of town. All paths in your story lead from here.";
            Rooms[0].picname = @"room0.png";
            Rooms[0].radiolevel = 0;
            Rooms[0].pathN = 1;
            Rooms[0].pathNE = 6;
            Rooms[0].pathNW = -1;
            Rooms[0].pathE = 4;
            Rooms[0].pathW = 2;
            Rooms[0].pathS = 3;
            Rooms[0].pathSE = -1;
            Rooms[0].pathSW = -1;
            Rooms[0].items = new List<Item>();
            Rooms[0].roomevents = new List<Event>();


            Rooms[1].provcode = Province.Judium;
            Rooms[1].roomcode = 1;
            Rooms[1].name = "Tavern";
            Rooms[1].desc = "The life and soul of social gatherings in Judium. The music is local, light, live and lovely.";
            Rooms[1].picname = @"room1.png";
            Rooms[1].radiolevel = 0;
            Rooms[1].pathN = -1;
            Rooms[1].pathNE = -1;
            Rooms[1].pathNW = -1;
            Rooms[1].pathE = -1;
            Rooms[1].pathW = -1;
            Rooms[1].pathS = 0;
            Rooms[1].pathSE = -1;
            Rooms[1].pathSW = -1;
            Rooms[1].items = new List<Item>();
            Rooms[1].roomevents = new List<Event>();


            Rooms[2].provcode = Province.Judium;
            Rooms[2].roomcode = 2;
            Rooms[2].name = "Library";
            Rooms[2].desc = "The largest building in Judium, working as a Library and a Town Hall.";
            Rooms[2].picname = @"room2.png";
            Rooms[2].radiolevel = 0;
            Rooms[2].pathN = -1;
            Rooms[2].pathNE = -1;
            Rooms[2].pathNW = -1;
            Rooms[2].pathE = 0;
            Rooms[2].pathW = -1;
            Rooms[2].pathS = -1;
            Rooms[2].pathSE = -1;
            Rooms[2].pathSW = -1;
            Rooms[2].items = new List<Item>();
            Rooms[2].roomevents = new List<Event>();






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
        public Room[] Rooms = new Room[7];
        // Items
        public List<Item> itemlist = new List<Item>();
        public List<Item> avaliableitems = new List<Item>();
        // Player
        public PlayableChar player;
        public List<Item> playerinv = new List<Item>();

        string[] LookPhrases = { "LOOK", "OBSERVE", "VIEW", "PEER", "GLANCE", "EXPLORE"};
        string[] ConnectPhrases = { "AND", "FOR", "TO", "BUT", "OR"};
 


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


        public void Lexer()
        {
            string[] splitter = mainUI.inputBox.Text.Split(' ');
            List<Token> tokens = new List<Token>();
            for (int i = 0; i < tokens.Count; i++)
            {
                Token temptoken;
                temptoken.original = splitter[i];
                temptoken.processed = splitter[i].ToUpper();
                tokens.Add(temptoken);
            }
            foreach (Token token in tokens)
            {
                foreach (string str in ConnectPhrases){
                    if (token.processed == str)
                    {
                        tokens.Remove(token);
                    }
                }
                
            }
            foreach (Token token in tokens)
            {
                foreach(string str in LookPhrases) 
                { 
                    if (token.processed == str)
                    {
                        LookAround();
                    }
                }
            }

        }

        bool LexerSearch(string[] phrasebook, Token token)
        {
            for (int i = 0;i < phrasebook.Length;i++)
            {
                if (token.processed == phrasebook[i])
                {
                    return true;
                }
            }
            return false;
        }

        void LookAround()
        {
            mainUI.clOut("Yess");
        }
    }
}
