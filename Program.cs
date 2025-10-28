using Restaurante;
class Program
{
    static void Main(string[] args)
    {
        Restaurante.Restaurante meuRestaurante = new Restaurante.Restaurante(5); // 5 Mesas


        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Sistema de Reservas ===\n");

            meuRestaurante.ExibirTodasMesas(); // Exibe o status atual

            Console.WriteLine("\nOpções:");
            Console.WriteLine(" [1-5] - Reservar Mesa");
            Console.WriteLine(" [L]   - Liberar Mesa");
            Console.WriteLine(" [0]   - Sair");

            Console.Write("\nDigite a opção: ");
            string? entrada = Console.ReadLine()?.ToUpper();

            if (entrada == "0")
                break;

            if (entrada == "L")
            {
                Console.Write("Digite o número da mesa para liberar (1 a 5): ");
                if (int.TryParse(Console.ReadLine(), out int numLiberar))
                {
                    Mesa? mesa = meuRestaurante.BuscarMesa(numLiberar);
                    mesa?.Liberar();
                }
                else
                {
                    Console.WriteLine("\n[ERRO] Entrada inválida para liberar.");
                }
            }

            else if (int.TryParse(entrada, out int numeroMesa))
            {
                Mesa? mesaParaReservar = meuRestaurante.BuscarMesa(numeroMesa);

                if (mesaParaReservar != null)
                {
                    if (mesaParaReservar.EstaDisponivel)
                    {
                        Console.Write("Digite o nome do cliente: ");
                        string? nome = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(nome))
                        {
                            // Cria o objeto Cliente e reservar
                            Cliente novoCliente = new Cliente(nome);
                            mesaParaReservar.Reservar(novoCliente);
                        }
                        else
                        {
                            Console.WriteLine("\n[ERRO] Nome do cliente não pode ser vazio.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"\n[AVISO] A Mesa {numeroMesa} já está reservada.");
                    }
                }
            }
            else
            {
                Console.WriteLine("\n[ERRO] Opção de menu inválida.");
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        Console.WriteLine("\nSistema de reservas encerrado.");
    }
}