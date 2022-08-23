using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED2.ATV1
{
    public class Vendedores
    {
        private int qtde;
        private int max;
        private Vendedor[] osVendedores;

        public int Qtde { get => qtde; }
        public int Max { get => max; }
        public Vendedor[] OsVendedores { get => osVendedores; }


        public Vendedores(int max)
        {
            this.qtde = 0;
            this.max = max;
            this.osVendedores = new Vendedor[this.max];
            for (int i = 0; i < this.max; i++)
            {
                osVendedores[i] = new Vendedor();
            }

        }


        public bool addVendedor(Vendedor V)
        {
            if (this.qtde < this.max)
            {
                osVendedores[this.qtde] = V;
                qtde++;

                return true;
            }
            return false;
        }

        public bool delVendedor(Vendedor V)
        {
            bool podeRemover;
            int i = 0;
            while (i < this.max && !this.osVendedores[i].Equals(V))
            {
                i++;
            }

            podeRemover = (i < this.max);
            if (podeRemover)
            {
                while (i < this.max - 1)
                {
                    this.osVendedores[i] = this.osVendedores[i + 1];
                    i++;
                }
                this.osVendedores[i] = new Vendedor();
                this.qtde--;
            }
            return podeRemover;
        }   


        public Vendedor searchVendedor(Vendedor V)
        {
            Vendedor vendedorEncontrado = new Vendedor();
            foreach(Vendedor vendedorTemp in this.osVendedores)
            {
                if (vendedorTemp.Equals(V))
                {
                    vendedorEncontrado = vendedorTemp;
                    break;
                }
            }
            return vendedorEncontrado;
        }

        public double valorVendas()
        {
            double somaVendas = 0;
            foreach (Vendedor vendedor in this.osVendedores)
            {
                somaVendas += vendedor.valorVendas();

            }

            return somaVendas;
        }

        public double valorComissao()
        {
            double somaComissoes = 0;
            foreach (Vendedor vendedor in this.osVendedores)
            {
                somaComissoes += vendedor.valorComissao();

            }

            return somaComissoes;
        }












    }


}
