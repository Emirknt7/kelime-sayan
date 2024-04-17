using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test20
{
    internal class Program
    {
        static void Main(string[] args)

        {                      //Girilen Cümledeki Kelime Sayısını Bulma


            Console.WriteLine("bir cümle girin");
            string cümkelime = Console.ReadLine();
            string liste = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                           + "abcçdefgğhiıjklmnoöprsştuüvyz"+".?";

            int boşluk= 1;

            for (int i=0;i<cümkelime.Length;i++) {
                if (liste.Contains(cümkelime[i]))
                {
                }
                else
                {
                    boşluk = boşluk + 1;


                }
            } Console.WriteLine(boşluk);
            Console.ReadKey();
        }

    }
}
