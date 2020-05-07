using System;
using System.IO;

namespace OOP_Lab_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fromFile = new StreamReader("D:\\input.txt");
            string sentence = fromFile.ReadLine();
            fromFile.Close();
            Console.WriteLine(sentence);
            Console.WriteLine("Введіть рядок");
            string s = Console.ReadLine();
            
            string[] s1 = s.Split();
            int j = 0;
           
            for (int i = 0; i < s.Length; i++)
            {
                char[] c = s1[i].ToCharArray();
                if (c[0] == 'a' || c[0] == 'o' || c[0] == 'e' || c[0] == 'y' || c[0] == 'u' || c[0] == 'i')
                {
                    File.AppendAllText("D:\\output.txt", string.Join(" ",s1[i]));

                }
            }
        }
    }
}
