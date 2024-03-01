namespace avaliacao_1PD;
using avaliacao_1PD;
using System;

public class Carro
{
    
    public double RedimentoAlcool { get; set; }
    public double RedimentoGasolina { get; set; }
    public double Proporcao { get; set; }
    Validador validador = new Validador();
    public int Tipo { get; set; }

    public Carro()
    {
        Proporcao = 0.7;
        Tipo = 1;
    }
    
    
    public void EditarDados()
    {
        
        string valor;
        double x = 0;
            while (x == 0)
            {
                Console.Clear();
                Console.WriteLine("Digite o tipo do carro: ");
                Console.WriteLine("1 - Flex");
                Console.WriteLine("2 - Gasolina");
                Console.WriteLine("3 - Álcool");
        
                valor = Console.ReadLine();
                x = validador.Parser(valor);
                if(x == 1)
                {
                    Tipo = 1;
                }
                else if(x == 2)
                {
                    Tipo = 2;
                }
                else if(x == 3)
                {
                    Tipo = 3;
                }
            }
            
            x = 0;

            if (Tipo == 1)
            {
                while (x == 0)
                {
                    Console.WriteLine("Digite o valor do Redimento do Álcool(Km/L): ");
                    valor = Console.ReadLine();
                    x = validador.PaserDouble(valor);
                }
                RedimentoAlcool = x;
                x = 0;
                while (x == 0)
                {
                    Console.WriteLine("Digite o valor do Redimento da Gasolina(Km/L): ");
                    valor = Console.ReadLine();
                    x = validador.PaserDouble(valor);
                }
                RedimentoGasolina = x;
                x = 0;
                
                Proporcao = RedimentoAlcool / RedimentoGasolina;
            } else if (Tipo == 2)
            {
                while (x == 0)
                {
                    Console.WriteLine("Digite o valor do Redimento da Gasolina(Km/L): ");
                    valor = Console.ReadLine();
                    x = validador.PaserDouble(valor);
                }
                RedimentoAlcool = x;
                x = 0;
            } else if (Tipo == 3)
            {
                
                while (x == 0)
                {
                    Console.WriteLine("Digite o valor do Redimento da Gasolina(Km/L): ");
                    valor = Console.ReadLine();
                    x = validador.PaserDouble(valor);
                }
                RedimentoGasolina = x;
                x = 0;
            }
            
            
    }
}