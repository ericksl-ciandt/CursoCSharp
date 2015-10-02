using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    public enum TipoCambio {
        Manual, Automatico
    }
    public enum TipoCor
    {
        Branco, Preto, Vermelho,  Cinza
    }
    public class Carro
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int Rodas { get; set; }
        public int Portas { get; set; }
        public string Motor { get; set; }
        public bool Farol { get; set; }
        public TipoCambio Cambio { get; set; }
        public TipoCor Cor { get; set; }
    }
}
