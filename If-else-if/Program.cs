﻿using System;

namespace If_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
           int time = DateTime.Now.Hour;

           if(time >=6 && time < 11)
            Console.WriteLine("Günaydın!");
           else if(time <= 18)
            Console.WriteLine("İyi Günler");
           else
            Console.WriteLine("İyi Geceler");  

           string sonuc = time<=18 ? "İYİ GÜNLER" : "İYİ GECELER";
           
           sonuc = time >=6 && time < 11 ? "günaydın" : time <= 18 ? "İyi günler" : "İyi geceler";
           Console.WriteLine(sonuc); 

             

        }
    }
}
