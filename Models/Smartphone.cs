namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        // Campos privados
        private string modelo;
        private string imei;
        private int memoria;

        // Propriedades públicas para acessar os campos privados
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string IMEI
        {
            get { return imei; }
            set { imei = value; }
        }

        public int Memoria
        {
            get { return memoria; }
            set { memoria = value; }
        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
