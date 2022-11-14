
//using System.Security.Cryptography;
//using System.Xml.Linq;

//namespace csproject
//{

//    public enum Categories { BODY, BRAIN, STOMACH }
//    interface IItemSelect
//    {
//        string Selection();
//    }
//    public delegate bool ItemSelect();


//    class Program
//    {

//        static void Main(string[] args)
//        {
//            OrganicShop organicShop = new OrganicShop();

//            Console.WriteLine("BASE SHOP CATALOG \n ");
//            Console.WriteLine(organicShop.ToString());

//            Console.WriteLine("SORTED SHOP CATALOG \n ");
//            organicShop.Sort();
//            Console.WriteLine(organicShop.ToString());

//            Console.WriteLine("ITEMS WITH PRICE BIGGER THAN 800");
//            organicShop.Selection();
//        }

//    }

//    class OrganicShop : IItemSelect
//    {
//        private List<ShopItem> shopItems = new List<ShopItem>();

//        public void DefaultInit()
//        {

//            shopItems.Add(new ShopItem("Tibetan Meditation", Categories.BRAIN, 140));
//            shopItems.Add(new ShopItem("Pure-Oath", Categories.STOMACH, 40));
//            shopItems.Add(new ShopItem("PeelMySkin", Categories.BODY, 20));
//            shopItems.Add(new ShopItem("Quino-Ice", Categories.STOMACH, 15));
//            shopItems.Add(new ShopItem("Mother Eath", Categories.BRAIN, 180));
//            shopItems.Add(new ShopItem("Acupuncture Set", Categories.BODY, 193));
//            shopItems.Add(new ShopItem("BirdSeeds", Categories.STOMACH, 11));
//            shopItems.Add(new ShopItem("Poo Shampoo", Categories.BODY, 22));
//            shopItems.Add(new ShopItem("Tofu", Categories.STOMACH, 9));
//            shopItems.Add(new ShopItem("Refined Tofu", Categories.STOMACH, 20));
//            shopItems.Add(new ShopItem("Mind Cristal", Categories.BRAIN, 130));
//            shopItems.Add(new ShopItem("BeetRoot", Categories.STOMACH, 3));
//        }

//        public OrganicShop()
//        {
//            DefaultInit();
//        }

//        public override string ToString()
//        {
//            string retValue = string.Empty;

//            foreach (ShopItem i in shopItems)
//            {
//                retValue += i.ToString();
//            }

//            return retValue;
//        }



//        public void Sort()
//        {
//            shopItems.Sort();
//        }

//        //interface impl
//        public string Selection()
//        {
//            if (shopItems.Count == 0) return " ";

//            string retValue = string.Empty;

//            foreach (ShopItem i in shopItems)
//            {
//                if (i.Price > 100)
//                {
//                    retValue += i.ToString();
//                }
//            }
//            Console.WriteLine(retValue);
//            return retValue;
//        }




//    }

//    class ShopItem : IComparable
//    {
//        private string m_title;
//        private Categories m_category;
//        private int m_price;

//        public ShopItem(string t, Categories c, int p)
//        {
//            Price = p;
//            Title = t;
//            Category = c;

//        }

//        public string Title { set => this.m_title = value; get => this.m_title; }
//        public Categories Category { set => this.m_category = value; get => this.m_category; }
//        public int Price { set => this.m_price = value; get => this.m_price; }


//        public override string ToString()
//        {
//            return (" Title=" + Title + "," + " Category=" + Category + "," + " Price=" + Price + "\n");
//        }

//        public int CompareTo(object obj)
//        {
//            return Price.CompareTo((obj as ShopItem).Price);
//        }

//    }

//}
