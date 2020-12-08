using System;

namespace סקר
{
    class Survey
    {
        private int noRead;
        private int readHalf;
        private int[] books;
        public Survey()
        {
            this.noRead = 0;
            this.readHalf = 0;
            this.books = new int[50];
        }
        public void SetNoRead()
        {
            this.noRead++;
        }
        public void SetReadHalf()
        {
            this.readHalf++;
        }
        public void SetBooks(int i)
        {
            this.books[i]++;
        }
        public int GetNoRead()
        {
            return this.noRead;
        }
        public int GetReadHalf()
        {
            return this.readHalf;
        }
        public int[] GetBooks()
        {
            return this.books;
        }
        public bool func(int [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == 0)
                    return false;
            return true;
        }
        static void Main()
        {
            string st="";
            Survey p = new Survey();
            int a, count = 0, count1 = 0, count2 = 0;
            while (st != "@@@")
            {
                    Console.WriteLine("Hallo.. survey of the 50 best books in the world\n\ninput your fall name");
                    st = Console.ReadLine();
                if (st != "@@@")
                {
                    for (int i = 0; i < p.books.Length; i++)
                    {
                        do
                        {
                            Console.WriteLine("Have you read book number: {0}", i + 1 +
                                "\nif yes click on 1 if no click on 0");
                            a = int.Parse(Console.ReadLine());
                        }
                        while (a != 0 && a != 1);
                        if (a == 1)
                        {
                            p.SetBooks(i);
                            count++;
                        }
                    }
                    if (count >= p.GetBooks().Length / 2)
                        p.SetReadHalf();
                    if (count == 0)
                        p.SetNoRead();
                    count = 0;
                }
                Console.Clear();
            }
            for (int i = 0; i < p.books.Length; i++)
            {
                if (count1 < p.GetBooks()[i])
                {
                    count1 = p.GetBooks()[i];
                    count2 = i+1;
                }
            }
            Console.WriteLine("Number of books read:"+count1+"\nBook number:"+count2);
            Console.WriteLine("Number of pepole have no read nathing: "+p.GetNoRead());
            Console.WriteLine("Nunber of pepole have read hlaf: "+p.GetReadHalf());
        }
    }
}
