using System;

namespace _04ExercioIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();
            obj.nome = "Luciano";
            obj.altura = 1.82;
            obj.peso = 60;
            obj.mensagem();

        }
    }
}
