using avaliacao_1PD;
namespace avaliacao_1PD;


public class Combustivel
{
    public double _alcool;
    public double _gasolina;

    public double gasolina
    {
        get
        {
            return _gasolina;
        }
        set
        {
            _gasolina = value;
        }
    }

    public double alcool
    {
        get { return _alcool; }
        set { _alcool = value; }
    }

    public void CalculaCombustivel(double proporcao = 0.7, int tipo = 1)
    {
        Console.Clear();
        double x = 0;
        string valor;
        if (tipo == 1)
        {
            Validador validador = new Validador();
            while (x != 1)
            {
                while (x == 0)
                {
                    Console.WriteLine("Digite o valor do Álcool: ");
                    valor = Console.ReadLine();
                    x = validador.PaserDouble(valor);
                }
                alcool = x;
                x = 0;
                while (x == 0)
                {
                    Console.WriteLine("Digite o valor da Gasolina: ");
                    valor = Console.ReadLine();
                    x = validador.PaserDouble(valor);
                }
            
            
                gasolina = x;
            
                double resultado = alcool / gasolina;
                Console.Clear();
                Console.WriteLine($"Valor da Gasolina: {gasolina}");
                Console.WriteLine($"Valor do Álcool: {alcool}");
                if (resultado > proporcao)
                {
                    Console.WriteLine("Abasteça com Gasolina");
                }
                else
                {
                    Console.WriteLine("Abasteça com Álcool");
                }
            
                x = 0;

                while (x != 1 && x != 2)
                {
                    Console.WriteLine("Deseja calcular novamente? 1 - Sim 2 - Não");
                    valor = Console.ReadLine();
                    x = validador.Parser(valor);
                }
                x = x == 2 ? 1 : 0;
            }
        } else
        {
            if (tipo == 2)
            {
                Console.WriteLine("O seu carro é a Gasolina, não é possível calcular o combustível");
            }
            else
            {
                Console.WriteLine("O seu carro é a Álcool, não é possível calcular o combustível");
            }
            Console.WriteLine("Pressione Enter para continuar");
            Console.ReadLine();
        }
    }
}