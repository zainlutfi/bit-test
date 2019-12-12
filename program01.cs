using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            belah("programit");
            carikata("hit bot");
            Console.ReadKey();      
        }

         public static string belah(string kata) {
            String[] dict = new String[6] { "pro", "gram", "merit", "program", "it", "programmer" };
            String output1 = "";
            String  output2 = "";
            int pos = 0;
            int maxpos = 0;
            string processKata = kata;
            string searchitem = "";
          
            for (int i = 0; i < dict.Count()-1; i++)
            {
                pos = processKata.IndexOf(dict[i]);
                if (pos>0)
                {

                    if (i == 0) {
                        searchitem = dict[i];
                        maxpos = pos;
                    }
                    else
                    if (pos>maxpos) {
                        maxpos = pos;
                        searchitem += dict[i];
                    }

                    if (string.IsNullOrEmpty(output1))
                        output1 = dict[i]; 
                    else
                        output1 += "," + dict[i];
                    processKata = processKata.Remove(0, pos);
                }
            }
            Console.WriteLine(output1);

            /*       ----------              */
            processKata = kata;
            output1 = string.Empty;
            for (int i = 0; i < dict.Count() - 1; i++)
            {
                if (i == 0)
                {
                    pos = processKata.IndexOf(dict[0] + dict[1]);
                    if (pos > 0)
                    {
                        if (string.IsNullOrEmpty(output1))
                            output1 = dict[i];
                        else
                            output1 += "," + dict[i];
                        processKata = processKata.Remove(0, pos);
                    }
                }
                else
                {
                    pos = processKata.IndexOf(dict[i]);
                    if (pos > 0)
                    {
                        output1 += "," + dict[i];
                        processKata = processKata.Remove(0, pos);
                    }

                }
            }
            Console.WriteLine(output1);

            /*       ----------              */
            processKata = kata;
            output1 = string.Empty;
            for (int i = 0; i < dict.Count() - 1; i++)
            {
                if (i == 0)
                {
                    pos = processKata.IndexOf(dict[0] + dict[1]);
                    if (pos > 0)
                    {
                        if (string.IsNullOrEmpty(output1))
                            output1 = dict[i];
                        else
                            output1 += "," + dict[i];
                        processKata = processKata.Remove(0, pos);
                    }
                }
                else
                {
                    pos = processKata.IndexOf(dict[i]);
                    if (pos > 0)
                    {
                        output1 += "," + dict[i];
                        processKata = processKata.Remove(0, pos);
                    }

                }
            }
            Console.WriteLine(output1);

            return null;
        }

        public static string carikata(string kata)
        {
            string[] dict = new string[5] { "hot", "dot", "dog", "lot", "log" };
            Regex rx = new Regex("([a-z])(a|i|u|e|o)([a-z])");
            MatchCollection matches = rx.Matches(kata);


            return null;
        }

    }
}
