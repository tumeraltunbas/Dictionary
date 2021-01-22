using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> numberName = new MyDictionary<int, string>();
            numberName.Add(22, "Tumer");
            numberName.Add(9, "Güven");
            numberName.Add(30, "Ersin");
        }
    }
}
