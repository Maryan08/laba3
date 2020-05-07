using System;
using System.IO;

namespace OOP_Lab_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть діапазон чисел");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            StreamReader fromFile = new StreamReader("D:\\222.txt");

            string sentence = fromFile.ReadLine();
            fromFile.Close();
            Console.WriteLine(sentence);
            string[] s1 = sentence.Split();
            float[] arr = new float[s1.Length];
            float[] arr1 = new float[s1.Length];
            int j = 0;
            for(int i = 0; i < s1.Length; i++)
                
            {
                arr[i] = float.Parse(s1[i]);
                if (arr[i] >= a && arr[i] <= b)
                {

                    arr1[j] = arr[i];
                    Console.WriteLine("arr[{0}]= {1}", j, arr1[j]);
                    string s2 = Convert.ToString(arr1[j]);
                    File.AppendAllText("D:\\222.txt", string.Join(" ",s2));
                    j++;
                   
                }
            }
        
            

           
        }
    }
}
