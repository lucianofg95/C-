using System;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar objeto da classe aluno

            Aluno a = new Aluno();
            a.nome = "Dennis";
            a.nota1 = 10;
            a.nota2 = 9;
            a.messagem();
        }
    }
}
