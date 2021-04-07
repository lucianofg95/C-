using System;

class Pessoa
{
    // Atributos das pessoas
    public string nome;
    public double altura;

    public double peso; 

    // Métodos

    public double imc()
    {
        return (peso / (altura*altura));
    }

    public string situacao(double imc)
    {
        if (imc > 0 && imc < 18.5)
        {
            return ("abaixo do peso");
        }       
        else if (imc > 18.5 && imc < 25)
        {        
            return("peso normal");
        }
        else if (imc > 25 && imc < 30)
         {
            return("Acima do peso");
        } 
        else if (imc > 30 && imc < 35)
         {
            return("Obesidade I");
        }         
        else if (imc > 35 && imc < 40)
         {
            return("Obesidade II");
        }         
        else if (imc >= 40)
         {
            return("Obesidade III");
        } else{return("Número Inválido");}
    }
    public void mensagem()
    {
        double obterimc = imc();
        string obtersituacao = situacao(obterimc);

        Console.WriteLine("O peso de " + nome + " é " + peso + " kg e sua altura é " + altura + " e seu IMC é considerado " + obtersituacao);
    }

}