using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            string opcQ;

            Console.WriteLine("Cadastra Paciente ------ [1]");
            
            Console.WriteLine("Listar Paciente -------- [2]");
            
            Console.WriteLine("Atender Paciente ------- [3]");
            
            Console.WriteLine("Alterar Dados Paciente - [4]");
            
            Console.WriteLine("Encerrar Operação ------ [Q]");
       
            Console.WriteLine("Escolha uma opção: ");
            opc = int.Parse(Console.ReadLine());

            if(opc == 1)
            {
                Console.WriteLine("Paciente Cadstrado");
            }else if(opc == 2)
            {
                Console.WriteLine("Paciente Listado");
            }
            else if (opc == 3)
            {
                Console.WriteLine("Paciente Atendido");
            }
            else if (opc == 4)
            {
                Console.WriteLine("Dados do Paciente Alterado");
            }


            Console.ReadKey();
        }
    }
}
