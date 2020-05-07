using System;

namespace OOP_Lab_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть рядок");
            string s = Console.ReadLine();
            char[] c = s.ToCharArray();
            int n = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (c[i] == '.' || c[i] == ',' || c[i] == ';' || c[i] == ':' || c[i] == '—' || c[i] == '!' || c[i] == '?' || c[i] == '"')
                {
                    n++;
                }
            }
            Console.WriteLine("Кількість розділових знаків: {0}", n);
            string[] s1 = s.Split();
            char[] charsToTrim = { '.', ',', ';', ':', '—', '?', '!', '"' };
            for (int i = 0; i < s1.Length; i++)
                
                {
                    string s2 = s1[i].Trim(charsToTrim);
                    char[] t = s2.ToCharArray();
                    if (t.Length % 2 == 0)
                    {
                    
                        Console.Write(s2 + " ");
                    }
                }
        }
    }
}
