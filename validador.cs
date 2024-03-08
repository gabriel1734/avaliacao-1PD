namespace avaliacao_1PD;

public class Validador
{
    public int Parser(string valor)
    {
        int resultado = 0;
        try
        {

            resultado = int.Parse(valor);
            List<int> lista = new List<int>();
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            if (!lista.Contains(resultado))
            {
                Console.WriteLine("Digite um valor válido!!![Pressione Enter para continuar]");
                resultado = 0;
                Console.ReadLine();
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine("Digite um valor válido[Pressione Enter para continuar]");
            Console.ReadLine();
        }
        return resultado;
    }
    public double PaserDouble(string valor)
    {
        double resultado = 0;
        try
        {
            resultado = double.Parse(valor);
            if (resultado <= 0)
            {
                Console.WriteLine("Digite um valor válido!!![Pressione Enter para continuar]");
                resultado = 0;
                Console.ReadLine();
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine("Digite um valor válido[Pressione Enter para continuar]");
            Console.ReadLine();
        }
        return resultado;
    }
}