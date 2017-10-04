using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEQUENCE_TEST
{
    class Program
    {



        static void Main(string[] args)
        {

            //string istr = "welcome to plv";
            //string rstr = istr.Replace(" ", "");
            //var lstcnt = new List<char>();
            //var lstrev = new List<char>();
            

            //for (int i = rstr.Length - 1; i >= 0; i--)
            //{

            //    lstcnt.Add(rstr[i]);
            //}

            //for (int i = 0; i < istr.Length;i++ )
            //{

            //    if(istr[i]==' ')
            //    {
            //        lstrev.Insert(i, ' ');

            //    }
            //}
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < lstrev.Count; i++)
            //{
            //    sb.Append(lstrev[i].ToString());
            //}
            //    Console.WriteLine(istr);
            //    Console.WriteLine(sb.ToString());

            //char[] rchararr = rstr.Replace(" ","").ToArray();
            //lstcnt.i

            //rchararr.in

            int[] arr = { 1, 2, 3, 3, 4, 5, 5, 5, 5, 7, 8, 8, 9 };
           

           // arr1=
           // Array.clo(arr, arr1);
            //arr.CopyTo(arr1);

            Array.Sort(arr);
            int[] arr1 = (int[])arr.Clone();
            Array.Copy(arr, arr1, 0);

            foreach(int val in arr1)
            {

                Console.WriteLine(val);
            }
            //StringBuilder sb = new StringBuilder();

            //var lstval = new List<string>();
            //var lstcnt = new List<string>();


            //for(int i=0;i<arr.Length;i++)
            //{
            //    int k = 1;

            //    for(int j=i+1;j<arr.Length;j++)
            //    {
            //        if(arr[i]==arr[j])
            //        {

            //            k = k + 1;
            //        }




            //    }
                

            //    if(k>1)
            //    {
            //        if (lstval.Contains(arr[i].ToString())==true)
            //        { }
            //        else
            //        {
            //            lstval.Add(arr[i].ToString());
            //            lstcnt.Add(k.ToString());
            //            sb.Append(arr[i].ToString() + "Repeats" + k.ToString() + "times");
            //        }
                   

            //    }

            //    k = 1;


            //}
            //Console.WriteLine(sb.ToString());

            Console.ReadLine();

            Console.ReadLine();

            //string str = sb.ToString();
            //int it = Array.IndexOf(arr, "1");
        }
        static bool ContainsA(string findname)
        {
            return findname.Contains("h");
        }
        
    }
}
