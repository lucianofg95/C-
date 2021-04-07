using System;

class Pessoa
{
    // Atributo 
    private string nome = "Juliana";

    // Construtor
    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }


}