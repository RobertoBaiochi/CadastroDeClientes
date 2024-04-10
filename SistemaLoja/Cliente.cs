using System;

namespace SistemaLoja
{
    internal class Cliente
    {
        public Cliente()
        {
            GerarID();
        }

        public int ID { get; private set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }

        private void GerarID()
        {
            Random randomID = new Random();
            ID = randomID.Next(0, 10000);
        }
    }
}
