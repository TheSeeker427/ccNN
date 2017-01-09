using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccNN
{
    class dataStore
    {
        public static List<string> words { get; set; }

       public static void init()
        {
            words = new List<string>();
        }

        public static string[] test = new string[]{
            "hello .",
            "how are you ?",
            "i am well .",
            "thats good .",
            "are you well ?"};

        public static DataSet toDataSet()
        {
            Random r = new Random();
            int index = r.Next(0, 4);
            string[] wlist = test[index].Split(' ');
            double[] values = new double[10];
            int i = 0;
            foreach(string s in wlist)
            {
                int val = WordLookup(s);
               // Console.WriteLine(val + " " + s);
                if(val >= 0)
                {
                    values[i] = val*.1;
                }
                else
                {
                    addWords(s);
                    values[i] = val * .1;
                }
                i++;
            }
            double[] target = new double[1];
            if(index == 1 || index == 4)
            {
                target = new double[]{ 1 };
            }else
                target = new double[] { 0 };
            DataSet ds = new DataSet(values, target);
            return ds;

        }

        public static double[] toDataSet(String w)
        {
            string[] wlist = w.Split(' ');
            double[] values = new double[10];
            int i = 0;
            foreach (string s in wlist)
            {
                int val = WordLookup(s);
                // Console.WriteLine(val + " " + s);
                if (val >= 0)
                {
                    values[i] = val * .1;
                }
                else
                {
                    addWords(s);
                    values[i] = val * .1;
                }
                
            }

            return values;
        }

        public static void addWords(string w)
        {
            
            foreach(String s in w.Split(' '))
            {
                words.Add(s);
            }
        }

        public static int WordLookup(String word)
        {   
            return words.IndexOf(word);;
        }
    }
}
