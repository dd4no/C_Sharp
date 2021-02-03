using System;
using System.Text;


namespace Strings
{
    class Program
    {
        static void Main()
        {
            string line1 = "You can't always get what you want, ";
            string line2 = "but if you try sometimes, ";
            string line3 = "you get what you need.";

            string lyric = line1 + line2 + line3;
            Console.WriteLine(lyric);
            Console.WriteLine();
            Console.WriteLine("(or if you feel like shouting it:)");
            Console.WriteLine(lyric.ToUpper());
            Console.WriteLine("-------------------------------------------------------------");

            StringBuilder paragraph = new StringBuilder();
            paragraph.Append("Ratz was tending bar, his prosthetic arm jerking monotonously\nas he filled a tray of glasses with draft Kirin. ");
            paragraph.Append("He saw\nCase and smiled, his teeth a webwork of East European steel\nand brown decay. ");
            paragraph.Append("Case found a place at the bar, between the\nunlikely tan on one of Lonny Zone's whores and the crisp naval\nuniform of a tall African whose cheekbones were ridged with\nprecise rows of tribal scars. ");
            paragraph.Append("\"Wage was in here early, with two \njoeboys,\" Ratz said, shoving a draft across the bar with his \ngood hand. ");
            paragraph.Append("\"Maybe some business with you, Case?\"\n");
            paragraph.Append("\tWilliam Gibson -- Neuromancer");

            Console.WriteLine();
            Console.WriteLine(paragraph);
            Console.Read();
        }
    }
}
