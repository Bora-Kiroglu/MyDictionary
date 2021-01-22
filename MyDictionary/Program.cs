using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Notlar1 = new Dictionary <string, int>();
            Notlar1.Add("Ahmet : " , 95 );
            Console.WriteLine(Notlar1.Count);


            MyDictionary<string, int> Notlar2 = new MyDictionary<string, int>();
            Notlar2.Add("Ahmet",95);
            Notlar2.Add("Ali", 80);
            Notlar2.Add("Ayşe", 100);

            Console.WriteLine(Notlar2.Count);



        }
    }

    class MyDictionary<T,T2>
    {
        T[] keys;
        T2[] values;

        T[] tempKeys;
        T2[] tempValues;
        public MyDictionary()
        {
            keys = new T[0];
            values = new T2[0];
        }

        public void Add(T key,T2 value) 
        {
            tempKeys = keys;
            tempValues = values;

            keys = new T[keys.Length+1];
            values = new T2[values.Length+1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

        public int Count
        {
            get { return keys.Length; }
        }

    }


}
