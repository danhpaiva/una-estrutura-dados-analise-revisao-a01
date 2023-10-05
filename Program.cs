using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagnostico_Aula202310
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Responda as próximas perguntas apenas com SIM ou NÃO.\n");

            string[] respostas = new string[4];
            int count0 = 0, count1 = 0, count2 = 0, count3 = 0, resposta = 0;
            bool erro = false;
            string resultadoRisco = "";
            if (erro == false)
            {
                do
                {
                    Console.WriteLine("Seu cartão de vacina está em dia?");
                    respostas[0] = Console.ReadLine().ToLower();


                    if (respostas[0] != "sim" && respostas[0] != "nao" && respostas[0] != "não")
                    {
                        Console.WriteLine("RESPOSTA INVÁLIDA!!\n");
                    }
                    if (count0 == 3)
                    {
                        Console.WriteLine("Não foi possível realizar o diagnóstico.\nGentileza procurar ajuda médica caso apareça algum sintoma.");
                        erro = true;
                    }
                    count0++;
                } while (respostas[0] != "sim" && respostas[0] != "nao" && respostas[0] != "não" && erro == false);
            }

            if (erro == false)
            {
                do
                {
                    Console.WriteLine("Teve algum dos sintomas recentemente? (dor de cabeça, febre, náusea, dor articular, gripe)");
                    respostas[1] = Console.ReadLine().ToLower();


                    if (respostas[1] != "sim" && respostas[1] != "nao" && respostas[1] != "não")
                    {
                        Console.WriteLine("RESPOSTA INVÁLIDA!!\n");
                    }
                    if (count1 == 3)
                    {
                        Console.WriteLine("Não foi possível realizar o diagnóstico.\nGentileza procurar ajuda médica caso apareça algum sintoma.");
                        break;
                    }
                    count1++;
                } while (respostas[1] != "sim" && respostas[1] != "nao" && respostas[1] != "não");
            }

            if (erro == false)
            {
                do
                {
                    Console.WriteLine("Teve contato com pessoas com sintomas gripais nos últimos dias?");
                    respostas[2] = Console.ReadLine().ToLower();


                    if (respostas[2] != "sim" && respostas[2] != "nao" && respostas[2] != "não")
                    {
                        Console.WriteLine("RESPOSTA INVÁLIDA!!\n");
                    }
                    if (count2 == 3)
                    {
                        Console.WriteLine("Não foi possível realizar o diagnóstico.\nGentileza procurar ajuda médica caso apareça algum sintoma.");
                        break;
                    }
                    count2++;
                } while (respostas[2] != "sim" && respostas[2] != "nao" && respostas[2] != "não");
            }

            if (erro == false)
            {
                do
                {
                    Console.WriteLine("Está retornando de viagem realizada no exterior?");
                    respostas[3] = Console.ReadLine().ToLower();


                    if (respostas[3] != "sim" && respostas[3] != "nao" && respostas[3] != "não")
                    {
                        Console.WriteLine("RESPOSTA INVÁLIDA!!\n");
                    }
                    if (count3 == 3)
                    {
                        Console.WriteLine("Não foi possível realizar o diagnóstico.\nGentileza procurar ajuda médica caso apareça algum sintoma.");
                        break;
                    }
                    count3++;
                } while (respostas[3] != "sim" && respostas[3] != "nao" && respostas[3] != "não");
            }

            int risco = 0;

            if (respostas[0] == "não" || respostas[0] == "nao")
            {
                risco = risco + 10;
            }
            for (int i = 1; i < respostas.Length; i++)
            {

                if (respostas[i] == "sim")
                {
                    risco = risco + 30;
                }
            }

            if (respostas[3] == "sim")
            {
                resultadoRisco = "Você ficará sob observação por 05 dias.";
            }
            else
            {
                if (risco <= 30)
                {
                    resultadoRisco = "Paciente sob observação. Caso apareça algum sintoma, gentileza buscar assistência médica.";
                }
                if (risco > 30 && risco <= 60)
                {
                    resultadoRisco = "Paciente com risco de estar infectado. Gentileza aguardar em lockdown por 02 dias para ser acompanhado.";
                }
                if (risco > 60 && risco <= 89)
                {
                    resultadoRisco = "Paciente com alto risco de estar infectado. Gentileza aguardar em lockdown por 05 dias para ser acompanhado.";
                    if (risco >= 90)
                    {
                        resultadoRisco = "Paciente crítico! Gentileza aguardar em lockdown por 10 dias para ser acompanhado.";
                    }
                }
            }

            Console.WriteLine("\nNome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Cartão de vacina está em dia? " + respostas[0]);
            Console.WriteLine("Teve sintomas recentemente? " + respostas[1]);
            Console.WriteLine("Teve contato com pessoas infectadas? " + respostas[2]);
            Console.WriteLine("Está retornando de viagem? " + respostas[3]);
            Console.WriteLine("Probabilidade de estar infectada: " + risco + "%");
            Console.WriteLine("Orientação final do atendimento: " + resultadoRisco);
            Console.ReadLine();
        }
    }
}
