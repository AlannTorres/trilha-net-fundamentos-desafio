namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = int.Parse(Console.ReadLine()) ;
                decimal valorTotal = precoInicial + (precoPorHora * horas);
                
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string i in veiculos)
                {
                    Console.WriteLine($"{i}");
                } 
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
        public void EditarPlaca()
        {
            Console.WriteLine("Digite a placa do veículo para editar:");
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();

            int index = 0;
            foreach (string veiculo in veiculos)
            {
                if (veiculo == placa)
                {
                    Console.WriteLine("Digite o novo valor da placa:");
                    // Pedir para o usuário digitar a nova placa e armazenar na variável nova_placa
                    veiculos[index] = Console.ReadLine();
                    return;
                }
                index++;
            }
            Console.WriteLine("Veículo não encontrado!");



        }
    }
}