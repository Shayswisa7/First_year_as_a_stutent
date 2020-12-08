using System;

namespace _05
{
    public class Card//מחלקת קארד מיצרת לנו קלף מסוג מסויים ועם ערך מסויים
    {

        private string type;
        private int num;


        public Card(string type, int num)
        {
            this.type = type;
            this.num = num;

        }

        public void settype(string type)
        {
            this.type = type;
        }
        
        public void setNum(int num)
        {
            this.num = num;
        }

        public string gettype()
        {
            return this.type;
        }

        public int getNum()
        {
            return this.num;
        }

        public override string ToString()
        {
            string st;
            st = "Type:" + this.type + "\nNumber:" + this.num + "\n\n";
            return st;
        }

    }
    public class Deck//מחלקת חבילה יוצאת אובייקט המרכיב את כל חבילות המחשק 
    {
        private Card[] lev;
        private Card[] yalom;
        private Card[] tiltan;
        private Card[] alee;
        private Card[] allcard;
       
        private int poslev=0;
        private int posy=0;
        private int post=0;
        private int posa=0;
        private int posall=0;

       

        public Deck()
        {
            this.lev = new Card[13];
            this.yalom = new Card[13];
            this.tiltan = new Card[13];
            this.alee = new Card[13];
            this.allcard = new Card[52];

            poslev=12;
            posy=12;
            post=12;
            posa=12;
            posall=0;

        }
        public void setlev(Card a)
        {
            this.lev[this.poslev] =a;
            
            
        }
        public void setyalom(Card a)
        {
            this.yalom[posy] = a;
            
        }
        public void settiltan(Card a)
        {
            tiltan[post] = a;
           
        }
        public void setalee(Card a)
        {
            this.alee[posa] = a;
        }
        public void setall(Card[] a)
        {
            if (a[0].gettype() == "@")
            {
               this.allcard[posall] =new Card(a[this.poslev].gettype(),a[this.poslev].getNum());
                this.poslev--;
            }
            if (a[0].gettype() == "*")
            {
                this.allcard[posall] = new Card(a[this.posy].gettype(), a[this.posy].getNum());
                this.posy--;
            }
            if (a[0].gettype() == "^")
            {
                this.allcard[posall] = new Card(a[this.post].gettype(), a[this.post].getNum());
                this.post--;
            }
            if (a[0].gettype() == "&")
            {
                this.allcard[posall] = new Card(a[this.posa].gettype(), a[this.posa].getNum());
                this.posa--;
            }
            posall++;
        }
        public void setl(int lev)
        {
            poslev = lev;
        }
        public void sety(int y)
        {
            posy = y;
        }
        public void sett(int t)
        {
           post = t;
        }
        public void seta(int a)
        {
            posa = a;
        }
        public void setal(int a)
        {
            posall = a;
        }
        public Card[] getlev()
        {
            return lev;
        }
        public Card[] getyalom()
        {
            return yalom;
        }
        public Card[] gettiltan()
        {
            return tiltan;
        }
        public Card[] getalee()
        {
            return alee;
        }
        public Card[] getall()
        {
            return allcard;
        }
        public int getl()
        {
            return poslev;
        }
        public int gety()
        {
            return posy;
        }
        public int gett()
        {
            return post;
        }
        public int geta()
        {
            return this.posa;
        }
        public int getal()
        {
            return this.posall;
        }
    }
    public class Tast
    {
        public static void insert(Card [] cards,string st)//הפעולה מסדרת חבילת קלפים מעורבבים מאותו הסוג
        {
            int c = 0,b;
           
            Random ran = new Random();
            while (c!=13)
            {
                b = ran.Next(0, 13);
                if (cards[b]==null)
                {
                    cards[b]=new Card(st,c + 1);
                    
                    c++;
                }
            }
            
        }
        
        public static bool game(Card[] card,int c)//פעולה בודקת עם סכום הקלפים שנבחרו מחלקים ב100 ללא שארית
        {
            int temp = 1;
            for (int i = 0; i < c; i++)
            {

                temp += card[i].getNum();
                
            }
            Console.WriteLine(temp);
            if (250 < temp)
                return true;
            return false;
        }
        public static Deck move(Deck p)// פעולה זו מעבירה קלף מהחבילה שהוגרלה
        {
            int a;
            string st;
            Random ran = new Random();

            while (p.getl() != -1 && p.gety() != -1 && p.gett() != -1 && p.geta() != -1)//ימשיך WHILE (-כל עוד פוז של כל אחד מהאברים שונה מ (1
            {
                Console.WriteLine("\t1\t2\t3\t4");
                Console.WriteLine("\t"+p.getlev()[0].gettype() + "\t" + p.getyalom()[0].gettype() + "\t" + p.gettiltan()[0].gettype() + "\t" + p.getalee()[0].gettype());
                Console.WriteLine("\t" + (1+p.getl()) + "\t" + (1+p.gety()) + "\t" + (1+p.gett()) + "\t" + (1+p.geta()));
                Console.WriteLine("to play prss any character:");
                //st = Console.ReadLine();
                a = ran.Next(0, 4);
                Console.WriteLine("Take a card form Deck number:{0}\n\n ",a+1);
                if (a == 0)
                {

                    p.setall(p.getlev());

                }
                else
                if (a == 1)
                {

                    p.setall(p.getyalom());

                }
                else
                if (a == 2)
                {

                    p.setall(p.gettiltan());

                }
                else
                if (a == 3)
                {

                    p.setall(p.getalee());
                }
            }
            Console.WriteLine("\t" + p.getlev()[0].gettype() + "\t" + p.getyalom()[0].gettype() + "\t" + p.gettiltan()[0].gettype() + "\t" + p.getalee()[0].gettype());
            Console.WriteLine("\t" + (1 + p.getl()) + "\t" + (1 + p.gety()) + "\t" + (1 + p.gett()) + "\t" + (1 + p.geta()));
            return p;
        }
        public static void Main()
        {
            
            Deck p = new Deck();// יצירת אובייקט המורכב מחמש חבילות קלפים
            insert(p.getlev(), "@");
            insert(p.getyalom(), "*");
            insert(p.gettiltan(), "^");
            insert(p.getalee(), "&");
            move(p);
            Console.WriteLine(game(p.getall(),p.getal())+"\n");//הדפסת האובייקט
            Console.WriteLine("This is deck number 5:\n");
            for (int i = 0; i < p.getal(); i++)//הצגת החבילה החמישית שהתקבלה
            {
                Console.WriteLine(p.getall()[i]);
            }
        }
    }       
}
