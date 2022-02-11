// See https://aka.ms/new-console-template for more information
using System;
using ExemploPOO.Models;

namespace ExemploPoo
{
    class Program
    {
        static void Main (string [] args)
        {
            pessoa p1= new pessoa();
            
            p1.Nome="Nathan";
            p1.Idade=20;

            p1.Apresentar();

        }
    }
}