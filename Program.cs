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

            
            Vendedores equipe = new Vendedores(2);

            Vendedor palinkas = new Vendedor(1, "palinkas", 0.2);
            Vendedor carol = new Vendedor(2, "carol", 0.3);
            Vendedor leal = new Vendedor(3, "leal", 0.5);

            Venda venda1 = new Venda(3, 300);
            Venda venda2 = new Venda(2, 100);

            palinkas.registrarVenda(1, venda1);
            carol.registrarVenda(1, venda2);

            Console.WriteLine(equipe.addVendedor(palinkas) ? "otimo(Y)" : "deuruim");
            Console.WriteLine(equipe.addVendedor(carol) ? "otimo(Y)" : "deuruim");
            Console.WriteLine(equipe.addVendedor(leal) ? "otimo(Y)" : "deuruim");

            Vendedor corna = equipe.searchVendedor(new Vendedor(2, "", 0));
            Console.WriteLine("consulta:" + corna.ToString());

            Console.WriteLine("o valor eh: " + equipe.valorVendas());

            Console.WriteLine("o valor da comissao eh: " + equipe.valorComissao());

            
            Console.WriteLine(equipe.addVendedor(leal) ? "otimo(Y)" : "deuruim");

            Console.WriteLine("o valor eh: " + equipe.valorVendas());

            Console.WriteLine("o valor da comissao eh: " + equipe.valorComissao());

            Console.WriteLine("\n\n========================================================================\n\n");

            foreach (Vendedor vendedor in equipe.OsVendedores)
            {
                Console.WriteLine(vendedor.ToString() + "\n\n");
            }


            
            {



                int resposta = 0;
                while (true) 
                
                { 

                Console.WriteLine("\n0 - Finalizar programa\n1- Cadastrar vendedor\n2- Consultar vendedor\n3- Excluir vendedor\n4- Registrar venda\n5- Listar vendedores");
                Console.WriteLine("Digite o número correspondente a opção desejada: ");
                resposta = int.Parse(Console.ReadLine());
                
                    switch (resposta)
                    {
                        case 0:
                            Environment.Exit(0);
                            break;
                        case 1:
                            Vendedores vendedor = new Vendedores(10);
                            Console.WriteLine(vendedor.searchVendedor(palinkas));
                            
                    }
                
                }
            }

            Console.ReadKey();

            //
        }
    }
}
