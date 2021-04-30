using System;

namespace MissionNetCoreCSharp01
{
    class Program
    {
        static void Main(string[] args)
        {
            var conditional = new Conditionals();
            //conditional.TernaryConditionalOperator();

            var loops = new Loops();
            //loops.WhileStatement();

            var collections = new Collections();
            collections.DictionaryCollection();
        }
    }
}
