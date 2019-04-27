using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class List : IDictionary
    {
        bool IDictionary.search()
        {
            Console.WriteLine("Ich bin die Suchfunktion der Listenfunktion");
            return true;
        }
    }

    //MultiSetUnsorted
    class MultiSetUnsortedL : List, IDictionary
    {

        bool IDictionary.search()
        {
            Console.WriteLine("Ich bin die Suchfunktion der Multi Set Unsorted List");
            return true;
        }

    }

    //SetUnsorted
    class SetUnsortedL : MultiSetUnsortedL, IDictionary
    {

        bool IDictionary.search()
        {
            Console.WriteLine("Ich bin die Suchfunktion der Set Unsorted List");
            return true;
        }

    }


    //Multi Set Sorted
    class MulitSetSortedL : List, IDictionary
    {
        bool IDictionary.search()
        {
            Console.WriteLine("Ich bin die Suchfunktion der Multi Set Sorted List");
            return true;
        }

    }

    //Multi Set Sorted
    class SetSortedL : MulitSetSortedL, IDictionary
    {
        bool IDictionary.search()
        {
            Console.WriteLine("Ich bin die Suchfunktion der Set Sorted List");
            return true;
        }

    }



}