using System;

namespace Recursion
{
    class Recursion
    {
        public static void Fibunche(int a)//סדרת פיבונאצ'י
        {
            int temp = 1, pos = 1,ff;
            
            for (int i = 0; i < a; i++)
            {
                ff = temp + pos;
                Console.Write(ff+",");
                pos = temp;
                temp = ff;
            }
        }
        public static void Fibunche(int a,int temp,int pos)//סדרת פיבונאצ'י ריקורסיבי
        {
             int ff;

            if(a!=1)
            {
                ff = temp + pos;
                Console.Write(ff + ",");
                pos = temp;
                temp = ff;
                Fibunche(--a,temp,pos);
            }
        }
        public static void Reshoni(int a)//הדפסת מספרים ראשוניים עד המספר שהתקבל כפרמטר
        {
            int pos = 0;
            for (int i=1; i <= a; i++)
            {
                    for (int j = 2; j < i; j++)
                    {
                        for (int h = i-1; h >1; h--)
                        {
                            if (i == j * h)
                                pos++;
                        }
                    }
                if(pos==0)
                        Console.Write(i+",");
                pos = 0; 
            }
        }
        public static void Print(int a,int c)//הדפסת מספר מהסוף להתחלה והפוך
        {
            

               if (a == 0)
               {
                    Console.WriteLine();
               }
                else
                {
                    Console.WriteLine(a);//מדפיס ואז מחשב
                    Print(--a,c);
                }
            //----------------------------------------------------------------------------   
              if (a == 1)
                Console.Write("");
            else
            {
                
                Print(--a,c);   //מדפיס ותוך כדי מדפיס
                Console.WriteLine(a);

            }
                if(a==c-1)
            Console.WriteLine(a+1);
        }
        public static int NAseret(int a)//הפונקצייה מחשבת את העצרת של המספר שהתקבל
        {
            if (a == 0)
            {
                return 1;
            }
            else
                return a * NAseret(a - 1);
        }
        static void Main()
        {

            Console.WriteLine(NAseret(5));
            

        }
    }
}
