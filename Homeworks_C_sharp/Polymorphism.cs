using System;

namespace _01
{
    class Polymorphism
    {
        static void Main(string[] args)
        {
            
           Frind[] allFrinds = new Frind[4];
            allFrinds[0] = new Tal("Tal Swisa", "302859921", "Qirit shmona");
            allFrinds[1] = new Shay("Shay Swisa", "302859913", "Qirit shmona");
            allFrinds[2] = new Moshe("Moshe Pereze", "305256426", "Qirit shmona");
            allFrinds[3] = new Yair("Yair Pinhas", "301879811", "Qirit shmona");
           Console.WriteLine("frinds skills:");
            for (int i = 0; i < allFrinds.Length; i++)
            {
                Console.WriteLine(allFrinds[i]);
                allFrinds[i].Skills();
            }
        }
    }
    public class Frind
    {
        private string name;
        private string id;
        private string livein;

        public Frind(string name,string id,string livein)
        {
            this.name = name;
            this.id = id;
            this.livein=livein;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public void setid(string id)
        {
            this.id = id;
        }
        public void seth(string livein)
        {
            this.livein = livein;
        }
        public string getname()
        {
            return this.name;
        }
        public string getid()
        {
            return this.id;
        }
        public string getlivein()
        {
            return this.livein;
        }
        public override string ToString()
        {
            string st;
            st = "Name:" + this.name + "\nID:" + this.id + "\nFrom:"+this.livein;
                    
            return st;
        }
        public virtual void Skills()
        {
            Console.WriteLine("No skills");
        }

    }
    public class Tal : Frind
    {
        private string talskill;
        public Tal(string name,string id,string liv) : base(name, id, liv)
        {
            this.talskill ="Tal skills";
        }
        public void settal(string a)
        {
            this.talskill = a;
        }
        public string gettal()
        {
            return this.talskill;
        }
        public override string ToString()
        {
            string st;
            st = "Name:" + this.getname() + "\nID:" + this.getid() + "\nFrom:" + this.getlivein()+"\n"+this.talskill;

            return st;
        }
        public override void Skills()
        {
            int c = 2;
            string a = "\a";
            for (int i = 0; i < 5; i++)
            {
              Console.WriteLine(a);
                
                c *= 45;
                Console.WriteLine(c);
            }
            
        }
    }

    public class Shay : Tal
    {
        private string profession;
        public Shay(string name, string id, string liv) : base(name,id,liv) 
        {
            this.settal("Shay sckils");
            this.profession = "Programming";

        }
        public void SetPro(string pro)
        {
            this.profession = pro;
        }
        public string GetPro()
        {
            return this.profession;
        }
        public override void Skills()
        {
            int a, b;
            Console.WriteLine("input two numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            a = (a + b) * 10;
            Console.WriteLine(a);
            
        }
        public override string ToString()
        {
            string st="";
            st += "Name:" + this.getname() + "\nID:" + this.getid() + "\nFrom:" + this.getlivein() + "\nProfession:" + this.GetPro()+"\n"+ this.gettal();
            
            return st;
        }
    }
    public class Moshe : Shay
    {
        public Moshe(string name, string id, string liv) : base(name, id, liv)
        {
            this.settal("Moshe skills");
            this.SetPro("Programming");
        }
        public override void Skills()
        {
            string a, b,c="";
            Console.WriteLine("input two strings");
            a = Console.ReadLine();
            b = Console.ReadLine();
            c = a.Substring(0, 2) + b.Substring(b.Length - 2);
            Console.WriteLine(c);
        }
        public override string ToString()
        {
            string st;
            st = "Name:" + this.getname() + "\nID:" + this.getid() + "\nFrom:" + this.getlivein() + "\nProfession:" + this.GetPro() + "\n" + this.gettal() ;

            return st;
        }
    }
    public class Yair : Moshe
    {
        public Yair(string name, string id, string liv) : base(name, id, liv)
        {
            this.settal("Yair skillse");
            this.SetPro("Programming");
        }
        public override void Skills()
        {
            int a, b,c;
            Console.WriteLine("input two numbers");
            a =int.Parse(Console.ReadLine());
            b =int.Parse(Console.ReadLine());
            c = a%b;
            Console.WriteLine(c);
        }
        public override string ToString()
        {
            string st;
            st = "Name:" + this.getname() + "\nID:" + this.getid() + "\nFrom:" + this.getlivein() + "\nProfession:" + this.GetPro() + "\n" + this.gettal(); 

            return st;
        }
    }

}
