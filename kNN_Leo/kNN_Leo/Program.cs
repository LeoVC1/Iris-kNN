using System;
using System.Collections.Generic;

namespace kNN_Leo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            float[] array = { 1.2f, 3.3f, 5.4f, 1.4f, 7.2f };

            array = TimSort.timSort(array, array.Length);
            //TimSort.printArray(array, array.Length);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\180976\Desktop\iris.txt");

            List<Flor> flores = new List<Flor>();

            for(int i = 0; i < lines.Length; i++)
            {
                string[] aux;
                aux = lines[i].Split(',');
                Vector2 sepala = new Vector2(float.Parse(aux[0]), float.Parse(aux[1]));
                Vector2 petala = new Vector2(float.Parse(aux[2]), float.Parse(aux[3]));
                string type = aux[4];

                flores.Add(new Flor(type, sepala, petala));
            }

            do
            {

            }

            Console.ReadKey();
        }
    }
}

