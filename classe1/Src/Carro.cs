using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe1.Carro
{
    public class carro
    {
        int QdtRodas { get; set; }
        string Modelo { get; set; }
        string Cor { get; set; }

        internal string ToString(int v1, string v2, string v3, int v4)
        {
            throw new NotImplementedException();
        }

        int Ano { get; set; }

        public carro()
        {
        }

        public carro(int qdtRodas, string modelo, string cor, int ano)
        {
            QdtRodas = qdtRodas;
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
        }

        public carro(int modelo, int cor)
        {
            Modelo = "Modelo";
            Cor = "cor";
        }

        public override string ToString()
        {
            return $"Modelo: {Modelo} - Cor: {Cor} - Ano: {Ano} - Quantidade de Rodas: {QdtRodas}";
            
        }
    }
}
