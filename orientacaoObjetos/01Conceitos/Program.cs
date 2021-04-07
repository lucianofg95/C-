using System;

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciar um método
            pessoa obj = new pessoa();
            obj.nome = "Luciano";
            obj.idade = "25";
            obj.mensagem();
        }
    }
}
