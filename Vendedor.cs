using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED2.ATV1
{
    public class Vendedor
    {
        private int id;
        private string nome;
        private double percComissao;
        private Venda[] asVendas;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public double PercComissao { get => percComissao; set => percComissao = value; }
        public Venda[] AsVendas { get => asVendas; }

        public Vendedor(int id, string nome, double percComissao)
        {
            this.id = id;
            this.nome = nome;
            this.percComissao = percComissao;
            this.asVendas = new Venda[31];

            for(int i = 0; i < 31; i++)
            {
                this.asVendas[i] = new Venda();
            }
        }

        public Vendedor() : this(0, "", 0)
        {
        }

        public void registrarVenda(int dia, Venda venda)
        {

            this.asVendas[dia-1] = venda;
        }

        public double valorVendas()
        {
            double somaVendas = 0;
            foreach(Venda venda in this.asVendas)
            {
                somaVendas += venda.Valor;
               
            }

            return somaVendas;
        }

        public double valorComissao()
        {
            return valorVendas() * percComissao;
        }

        public override bool Equals(object obj)
        {
            return this.id == ((Vendedor)obj).id;
        }


        public override string ToString()
        {
            return "\n\nID: " + this.id + "\nNome: " + this.nome + "\nValor das vendas: " + valorVendas() + "\nvalor da comissão: " + valorComissao() +
                "\nvalor das vendas diarias: " + valorVendas() / 31;
        }


    }
}
