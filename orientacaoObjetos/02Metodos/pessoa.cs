using System;

class Pessoa
{
    // Posso ter vários metodos com o mesmo nome. Porém, eles devem ter parâmetros diferentes

    // Método 01
    public void apresentar()
    {
        Console.WriteLine("Olá");
    }

    // Método 02
    public void apresentar(string nome)
    {
        Console.WriteLine("Olá" + nome);
    }

    // Método 03
    public void apresentar(string nome, string idade)
    {

        Console.WriteLine("Olá " + nome + ", você tem "+ idade +" anos!");
        
    }
    

}