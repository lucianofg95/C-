using System;

class Aluno
{   
    // Atributos
    public string nome;
    public double nota1, nota2;

    // Método de média
    public double media()
    {
        return (nota1 + nota2) / 2;
    }

    // Método de Situação
    public string situacao(double media)
    {
        return media >= 7 ? "aprovado" : "reprovado";
    }

    // Mensagem

    public void messagem()
    {
        //Obter a média
        double obtermedia = media();

        //Obter situação 
        string obterSituacao = situacao(obtermedia);

        // situação 
        Console.WriteLine (nome+" está "+obterSituacao + "com média "+ obtermedia);


    }


}