using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ReverseString
    {//reverse a string

       
        static void Main(string[] args)
        {
            string ReverseString(string givenstring)
            {
                char[] newstring = givenstring.ToCharArray();
                char set;

                Console.WriteLine(givenstring);
                for (int i = 0; i < givenstring.Length; i++)
                {
                    set = givenstring[givenstring.Length - (1 + i)];
                    newstring[i] = set;
                    
                }
             
              string returnstring = new string(newstring);
                return returnstring;
            }

            string wit = ReverseString("thishfbe");
            Console.WriteLine(wit);
            string gep = ReverseString("hihihihi");
            Console.WriteLine(gep);
            string pleb = ReverseString("mymothersaid");
            Console.WriteLine(pleb);

            Console.Read();
        }
    }
}
