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

            Vendedor palinkas = new Vendedor(1, "Palinkas", 0.2);
            Venda venda1 = new Venda(7, 700);

            palinkas.registrarVenda(1, venda1);

            equipe.addVendedor(palinkas);


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
                        Console.WriteLine("Cadastrar");
                        break;
                    case 2:
                        int Id;
                        Console.WriteLine("Consultar");
                        Console.WriteLine("Digite o ID do vendedor: ");
                        
                        Id = int.Parse(Console.ReadLine());
                        Vendedor vendedor = new Vendedor(Id, "", 0);
                        
                        vendedor = equipe.searchVendedor(vendedor);
                        
                        if(vendedor.Id == 0)
                        {
                            Console.WriteLine("Vendedor não encontrado");
                        }
                        else
                        {
                            Console.WriteLine(vendedor.ToString());
                        }

                        break;
                    case 3:
                        Console.WriteLine("Excluir vendedor");
                        break;
                    case 4:
                        Console.WriteLine("Registrar venda");
                        break;
                    case 5:
                        Console.WriteLine("Listar vendedores");
                        break;
                    default:
                        Console.WriteLine("opção invalida");
                        break;

                }

            }

            //
        }
    }
}
