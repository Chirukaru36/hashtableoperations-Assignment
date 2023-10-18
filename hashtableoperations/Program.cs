using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtableoperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashTable1 = new Hashtable();

           
            hashTable1.Add("Key1", "Value1");
            hashTable1.Add("Key2", "Value2");
            hashTable1.Add("Key3", "Value3");

            
            Console.WriteLine("First Hash Table:");
            foreach (DictionaryEntry entry  in hashTable1)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }
            
            
            Hashtable hashTable2 = new Hashtable(hashTable1);




            
            Console.WriteLine("\nSecond Hash Table (copied from the first):");
             

            
            hashTable1.Remove("Key2");

            foreach(DictionaryEntry entry in hashTable2)
            {
                Console.WriteLine(entry.Key + " " + entry.Value );
            }

            Console.ReadLine();

        }

    }
}
 
