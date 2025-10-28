using Restaurante;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Restaurante
{
    public class Mesa
    {
        public int NumeroMesa { get; private set; } // Set é privado: Número não muda após a criação
        public Cliente? ClienteAtual { get; private set; } // Armazena o Cliente (null se livre)
        public bool EstaDisponivel { get; private set; } // Set é privado: Estado só muda por método

        // Construtor: Uma mesa nova começa disponível
        public Mesa(int numeroMesa)
        {
            NumeroMesa = numeroMesa;
            EstaDisponivel = true;
            ClienteAtual = null;
        }

        // Método de Ação: Tenta fazer a reserva
        public bool Reservar(Cliente cliente)
        {
            if (EstaDisponivel)
            {
                ClienteAtual = cliente;
                EstaDisponivel = false;
                Console.WriteLine($"\n[SUCESSO] Mesa {NumeroMesa} reservada para {cliente.Nome}.");
                return true;
            }
            else
            {
                Console.WriteLine($"\n[ERRO] A Mesa {NumeroMesa} já está reservada por {ClienteAtual?.Nome}.");
                return false;
            }
        }

        // Método de Ação: Libera a mesa
        public void Liberar()
        {
            if (!EstaDisponivel)
            {
                Console.WriteLine($"\n[INFO] Mesa {NumeroMesa} liberada. Cliente: {ClienteAtual?.Nome}");
                ClienteAtual = null;
                EstaDisponivel = true;
            }
            else
            {
                Console.WriteLine($"\n[INFO] Mesa {NumeroMesa} já estava livre.");
            }
        }

        public string ObterStatus()
        {
            return $"Mesa {NumeroMesa}: {(EstaDisponivel ? "LIVRE" : "OCUPADA por " + ClienteAtual?.Nome)}";
        }

    }
}
