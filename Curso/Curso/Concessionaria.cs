using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    class Concessionaria
    {
        public List<Punto> listPunto()
        {
            List<Carro> list = new List<Carro>();
            Punto carro1 = new Punto();
            carro1.Cambio = TipoCambio.Manual;
            carro1.Portas = 4;
            carro1.Cor = TipoCor.Branco;
            list.Add(carro1);


            Punto carro2 = new Punto();
            carro2.Cambio = TipoCambio.Automatico;
            carro2.Portas = 2;
            carro2.Cor = TipoCor.Preto;
            list.Add(carro2);

        }
        public void Show()
        {
            List<Carro> list = new List<Carro>();

            
        }
    }
}
