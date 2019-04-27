using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class BinSearchTree : IDictionary
    {
        bool IDictionary.search()
        {
            Console.WriteLine("Ich bin die Suchfunktion des Binären Suchbaumes");
            return true;
        }
    }

    class AvlTree : BinSearchTree,IDictionary
    {

        bool IDictionary.search()
        {
            Console.WriteLine("Ich bin die Suchfunktion des AVL-Baumes");
            return true;
        }

    }


}
