#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5
{
    internal class Program
    {   
        static void Main(string[] args)
        #endregion
        {
            Console.Write("Введите предложение: ");
            OutputArrayOfWords(DividingPhraseIntoWords(Console.ReadLine()));

            Console.Write("Введите предложение: ");
            ArrayReversal();
            Console.ReadKey();
        }
        static string[] DividingPhraseIntoWords(string receprion)
        {
            return receprion.Split(' ');
        }
        static void OutputArrayOfWords(string[] output)
        {
            foreach (var word in output)
                Console.WriteLine(word);
        }
        static void ArrayReversal()
        {
            string[] result = DividingPhraseIntoWords(Console.ReadLine());
            Array.Reverse(result);
            // В задании не было написано вывести фразу, мне просто показалось оно неполным без этого
            foreach (var invertedPhraseInArray in result)
            {
                Console.WriteLine(invertedPhraseInArray);
            }
        }
        #region
    }
}
#endregion