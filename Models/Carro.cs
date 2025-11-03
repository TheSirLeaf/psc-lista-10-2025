namespace Models
{
    public class Carro
    {
        public string Cor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double VelocidadeAtual { get; set; }
        public double Combustivel { get; set; }

        public Carro() { }

        public Carro(string cor, string marca, string modelo, int ano, double velocidadeAtual, double combustivel)
        {
            Cor = cor;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            VelocidadeAtual = velocidadeAtual;
            Combustivel = combustivel;
        }

        public void Ligar() { Console.WriteLine($"{Marca} {Modelo} ({Ano}) ligado."); }
        public void Desligar() { Console.WriteLine($"{Marca} {Modelo} desligado."); }
        public void Acelerar()
        {
            VelocidadeAtual += 10;
            Console.WriteLine($"Acelerando... Velocidade atual: {VelocidadeAtual} km/h");
        }
        public void Frear()
        {
            VelocidadeAtual = System.Math.Max(0, VelocidadeAtual - 10);
            Console.WriteLine($"Freando... Velocidade atual: {VelocidadeAtual} km/h");
        }
        public void Abastecer()
        {
            Combustivel += 20;
            Console.WriteLine($"Abastecido. Combustível agora: {Combustivel} L");
        }
    }
}
