// See https://aka.ms/new-console-template for more information
using avaliacao_1PD;

int x = 0;
Validador validador = new Validador();
Carro carro = new Carro();
Combustivel combustivel = new Combustivel();

while (x != 3) {
    Console.Clear();
    Console.WriteLine("Digite 1 para calcular o Combustível: ");
    Console.WriteLine("Digite 2 para Editar os dados: ");
    Console.WriteLine("Digite 3 para Sair: ");
    
    Console.WriteLine(carro.Tipo);
    Console.WriteLine(carro.Proporcao);
    
    string valor = Console.ReadLine();
    x = validador.Parser(valor);
    
    switch (x)
    {
        case 1:
            combustivel.CalculaCombustivel(carro.Proporcao, carro.Tipo);
            break;
        case 2:
            carro.EditarDados();
            break;
        case 3:
            x = 0;
            while (x != 1 &&  x !=2 )
            {
                Console.Clear();
                Console.WriteLine("Deseja realmente sair? 1 - Sim 2 - Não");
                valor = Console.ReadLine();
                x = validador.Parser(valor);
            }
            if (x == 2)
            {
                x = 0;
            } else
            {
                x = 3;
            }
            break;
    }
    
}