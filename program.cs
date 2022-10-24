# if_else_if
using System;

namespace if_else_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int time = DateTime.Now.Hour;

        if(time>=6 && time<11)
        Console.WriteLine("Gunaydin!");
        else if (time <= 18)
        Console.WriteLine("iyi Gunler!");
        else
        Console.WriteLine("iyi Geceler!");

        string sonuc = time<=18 ? "iyi Gunler!" : "iyi Geceler!";
        sonuc =time >6 && time<11 ? "Günaydın!" : time<= 18 ? "iyi Gunler!" :"iyi Geceler";
        
        Console.WriteLine(sonuc);

        }
    }
}
