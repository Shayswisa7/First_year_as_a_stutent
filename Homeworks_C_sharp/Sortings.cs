using System;

namespace Sortings
{
    class Sortings
    {
        public static int [] SelectSort(int [] a)
        {
            int ind,temp;
            for (int i = 0; i < a.Length-1; i++)
            {
                ind = i;
                for (int j = i+1; j < a.Length; j++)
                {
                       if (a[j] < a[ind])
                       {
                           ind = j;
                       }   
                }
                if (i != ind)
                {
                    temp = a[i];
                    a[i] = a[ind];
                    a[ind] = temp;
                }
            }
            return a;
        }
        public static  int[] bubbleSort(int [] arr)
        {
            int temp;
            for (int i = 0; i <= arr.Length-2; i++)
            {
                for (int j = 0; j <= arr.Length-2; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        temp = arr[j+1];
                        arr[j+1] = arr[j];
                        arr[j] = temp;
                        
                    }
                }
                
            }
            return arr;
        }
        public static int[] bucketSort(int [] a,int min ,int max)
        {
            int g=0;
            int[] m =new int[max - min + 1];
            for (int i = 0; i < a.Length; i++)
            {
                m[a[i] - min] += 1;
            }
            for (int i = 0; i < m.Length; i++)
            {
                while (m[i]-- != 0)
                    a[g++] = i+min;
            }
            return a;
        }
        public static int[] Merge(int [] a,int [] b)
        {
            int[] c = new int[a.Length + b.Length];
            int i = 0,k=0,j=0;
            while (i < a.Length && j < b.Length) 
            {
                if (a[i] < b[j])
                    c[k++] = a[i++];
                else
                    c[k++] = b[j++];
            }
            while (i < a.Length)
                    c[k++] = a[i++];
            while (j < b.Length)
                    c[k++] = b[j++];
            return c;
        }
        public static int[] Merge2(int[] c, int first, int mid, int last)
        {
            int j = 0,k=0,f=0,m=0,l=0;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == first)
                    f = i;
                if (c[i] == mid)
                    m = i;
                if (c[i] == last)
                    l = i;
            }
            Console.WriteLine("f"+f+",,,m"+m+",,,l"+l);
            int[] a = new int[m - f + 1];
            int[] b = new int[l - m ];
            int[] h = new int[l - f + 1];
            for (int i = 0; i < c.Length; i++)//מצאית האינדקסים של הפרמטרים שהתקבלו
            {
                if (f <= i && m >= i)  
                    a[j++] = c[i];
                if (m < i && l >= i) 
                    b[k++] = c[i];
            }
             h = Merge(a, b);//קריאה לפונקצייה שממזגת וממינת את המערכים
            return h;

           /* int x = 0, y = 0, z = 0;
            while (x < a.Length && y < b.Length)//מיון מיזוג של שני המערכים
            {
                if (a[x] < b[y])
                    h[z++] = a[x++];
                else
                    h[z++] = b[y++];
              
            }
            while (x < a.Length)
            {
                    h[z++] = a[x++];
            }
            while ( y < b.Length)
            {
                    h[z++] = b[y++];
            }
            return h;*/
        }
 
        public static void Main()
        {
            int[] arr = { 1, 2, 4, 5,3, 74, 455,4, 485 };
            arr = SelectSort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
               if(i<arr.Length-1)
                 Console.Write(arr[i]+",");
               else
                    Console.WriteLine(arr[i]);
            }
        }
    }
}
