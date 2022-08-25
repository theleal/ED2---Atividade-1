using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED2.ATV1
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Vendedores equipe = new Vendedores(10);

            //Vendedor palinkas = new Vendedor(1, "Palinkas", 0.2);
            //Venda venda1 = new Venda(7, 700);

            //palinkas.registrarVenda(1, venda1);

            //equipe.addVendedor(palinkas);


            int resposta = -1;
            while (resposta != 0)
            {

                Console.WriteLine("\n0 - Finalizar programa\n1- Cadastrar vendedor\n2- Consultar vendedor\n3- Excluir vendedor\n4- Registrar venda\n5- Listar vendedores");
                Console.WriteLine("Digite o número correspondente a opção desejada: ");
                resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 0:
                        Console.WriteLine("Sair");
                        break;
                    case 1:
                        Cadastrar(equipe);
                        break;
                    case 2:
                        Consultar(equipe);
                        break;
                    case 3:
                        Remover(equipe);
                        break;
                    case 4:
                        Registrar(equipe);
                        break;
                    case 5:
                        Listar(equipe);
                        break;
                    default:
                        Console.WriteLine("opção invalida");
                        break;

                }

            }

            //
        }

        private static void Cadastrar(Vendedores vendedores)
        {
            Console.WriteLine("Cadastrar");

            //Console.WriteLine("Digite o nome do vendedor: ");
            //string nome = Console.ReadLine();

            //Console.WriteLine("Digite o ID do vendedor: ");
            //int Id = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o ID do vendedor: ");
            //double percComissao = double.Parse(Console.ReadLine());

            //Vendedor vendedor = new Vendedor(Id, nome, percComissao);


            Vendedor vendedor = new Vendedor();


            Console.WriteLine("Digite o nome do vendedor: ");
            vendedor.Nome = Console.ReadLine();

            Console.WriteLine("Digite o ID do vendedor: ");
            vendedor.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o percentual do vendedor: ");
            vendedor.PercComissao = double.Parse(Console.ReadLine());

            bool cadastradoComSucesso = vendedores.addVendedor(vendedor);

            if (cadastradoComSucesso)
            {
                Console.WriteLine("Cadastrado com sucesso");
            }

            else
            {
                Console.WriteLine("Limite de vendedores atingido");
            }


        }
        
        private static void Consultar(Vendedores vendedores)
        {
                        
            Vendedor vendedor = new Vendedor();

            Console.WriteLine("Consultar");

            Console.WriteLine("Digite o ID do vendedor: ");

            vendedor.Id = int.Parse(Console.ReadLine());

            vendedor = vendedores.searchVendedor(vendedor);

            if (vendedor.Id == 0)
            {
                Console.WriteLine("Vendedor não encontrado");
            }
            else
            {
                Console.WriteLine(vendedor.ToString());
            }

        }

        private static void Listar(Vendedores vendedores)
        {
            foreach(Vendedor vendedorCadavez in vendedores.OsVendedores)
            {
                if (vendedorCadavez.Id != 0)
                {
                    Console.WriteLine(vendedorCadavez.ToString());
                }
            }
        }

        private static void Registrar(Vendedores vendedores)
        {
            Vendedor vendedor = new Vendedor();
            Venda vendaEspecifica = new Venda();

            Console.WriteLine("Digite o ID do vendedor: ");
            vendedor.Id = int.Parse(Console.ReadLine());

            vendedor = vendedores.searchVendedor(vendedor);

            if (vendedor.Id == 0)
            {
                Console.WriteLine("Vendedor não encontrado");

                return;
            }
            
            Console.WriteLine("Digite o valor: ");
            vendaEspecifica.Valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos produtos vendeu: ");
            vendaEspecifica.Qtde = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o dia que vendeu: ");
            int dia = int.Parse(Console.ReadLine());

            vendedor.registrarVenda(dia, vendaEspecifica);

        }

        private static void Remover(Vendedores vendedores)
        {
            Vendedor vendedorRemovido = new Vendedor();
            
            Console.WriteLine("Digite o ID do vendedor que irá remover: ");
            vendedorRemovido.Id = int.Parse(Console.ReadLine());

            vendedorRemovido = vendedores.searchVendedor(vendedorRemovido);
            
            if (vendedorRemovido.Id == 0)
            {
                Console.WriteLine("Vendedor não encontrado");

                return;
            }

            if (vendedorRemovido.valorVendas() == 0)
            {
                vendedores.delVendedor(vendedorRemovido);
                Console.WriteLine("Vendedor removido com sucesso");

            }

            else
            {
                Console.WriteLine("Vendedor não pôde ser removido, pois há vendas associadas a ele");
            }


        }
    }
}
