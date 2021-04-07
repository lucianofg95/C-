using System;

class pessoa
{
    // Atributos

    public string nome;
    public string idade;

    // Métodos 
    public void mensagem() // void significa que não haverá retorno neste método
    {
        Console.WriteLine("Olá "+"você tem "+idade+" anos");
    }

}