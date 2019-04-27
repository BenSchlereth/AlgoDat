using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Array : IDictionary
    {
        bool IDictionary.search()
        {
            Console.WriteLine("Ich bin die Suchfunktion der Arrays");
            return true;
        }
    }

    //MultiSetUnsorted
    class MultiSetUnsorted : Array, IDictionary
    {

        bool IDictionary.search()
        {
            Console.WriteLine("Ich bin die Suchfunktion des Multi Set Unsorted Array");
            return true;
        }

    }

    //SetUnsorted
    class SetUnsorted : MultiSetUnsorted, IDictionary
    {

        bool IDictionary.search()
        {
            Console.WriteLine("Ich bin die Suchfunktion des Set Unsorted Arrays");
            return true;
        }

    }


    //Multi Set Sorted
    class MulitSetSorted : Array, IDictionary
    {
        bool IDictionary.search()
        {
            Console.WriteLine("Ich bin die Suchfunktion des Multi Set Sorted Arrays");
            return true;
        }

    }

    //Multi Set Sorted
    class SetSorted : MulitSetSorted, IDictionary
    {
        bool IDictionary.search()
        {
            Console.WriteLine("Ich bin die Suchfunktion des Set Sorted Arrays");
            return true;
        }

    }



}