
namespace Restaurante
{
    public class Restaurante
    {
        private Mesa[] mesas;

        public Restaurante(int totalMesas)
        {
            // Inicializa o array e INSTANCIA CADA OBJETO MESA
            mesas = new Mesa[totalMesas];
            for (int i = 0; i < totalMesas; i++)
            {
                mesas[i] = new Mesa(i + 1); // Cria mesas de 1 até 'totalMesas'
            }
            Console.WriteLine($"\nRestaurante inicializado com {totalMesas} mesas.");
        }

        public Mesa? BuscarMesa(int numeroMesa)
        {
            // Verifica se o número da mesa está dentro do limite do array
            if (numeroMesa < 1 || numeroMesa > mesas.Length)
            {
                Console.WriteLine("\n[AVISO] Número de mesa inválido.");
                return null;
            }
            // Retorna a mesa correta (índice é numero - 1)
            return mesas[numeroMesa - 1];
        }

        public void ExibirTodasMesas()
        {
            Console.WriteLine("\n=== STATUS GERAL DAS MESAS ===");
            foreach (var mesa in mesas)
            {
                Console.WriteLine(mesa.ObterStatus());
            }
            Console.WriteLine("==============================");
        }
    }
}
