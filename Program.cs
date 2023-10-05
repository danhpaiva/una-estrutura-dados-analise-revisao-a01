// Declaração de Variáveis que vamos utilizar no Algoritmo
string nome = string.Empty, cartaoVacinaEmDia = string.Empty, teveSintomasRecentemente = string.Empty,
teveContatoComPessoasSintomaticas = string.Empty, estaRetornandoViagem = string.Empty, orientacaoFinal = string.Empty;
int idade, contador = 0, porcentagemInfeccao = 0;
bool erroTentativas = false;

Console.WriteLine("\tRelatório Auxiliar de Controle de Infecções");

Console.WriteLine("\nInforme o seu nome: ");
nome = Console.ReadLine().ToUpper();

Console.WriteLine("\nInforme a sua idade: ");
idade = int.Parse(Console.ReadLine());

// Começo as perguntas de sim e nao, que serão importantes na lógica de porcentagem
do
{
    Console.WriteLine("\nSeu cartão de vacina está em dia? Digite SIM ou NAO ?");
    cartaoVacinaEmDia = Console.ReadLine().ToUpper();

    if (cartaoVacinaEmDia == "SIM" || cartaoVacinaEmDia == "NAO") { break; }
    else
    {
        contador++;
        Console.WriteLine("\nDigito inválido! Digite 'SIM' ou 'NAO'.");
        if (contador == 3)
        {
            erroTentativas = true;
            break;
        }
    }
} while (true);

// Reseto o contador porque vamos utilizá-lo novamente
contador = 0;

// Valido se continuo perguntando ou se vou direto para a mensagem final
if (erroTentativas == false)
{
    do
    {
        Console.WriteLine("\nTeve algum dos sintomas recentemente?(dor de cabeça, febre, náusea, dor articular, gripe)" +
                  "\nDigite SIM ou NAO");
        teveSintomasRecentemente = Console.ReadLine().ToUpper();

        if (teveSintomasRecentemente == "SIM" || teveSintomasRecentemente == "NAO") { break; }
        else
        {
            contador++;
            Console.WriteLine("\nDigito inválido! Digite SIM ou NAO.");
            if (contador == 3)
            {
                erroTentativas = true;
                break;
            }
        }
    } while (true);
}

contador = 0;

if (erroTentativas == false)
{
    do
    {
        Console.WriteLine("\nTeve contato com pessoas com sintomas gripais nos últimos dias?" +
                    "\nDigite SIM ou NAO");

        teveContatoComPessoasSintomaticas = Console.ReadLine().ToUpper();

        if (teveContatoComPessoasSintomaticas == "SIM" || teveContatoComPessoasSintomaticas == "NAO") { break; }
        else
        {
            contador++;
            Console.WriteLine("\nDigito inválido! Digite SIM ou NAO.");
            if (contador == 3)
            {
                erroTentativas = true;
                break;
            }
        }
    } while (true);
}

contador = 0;

if (erroTentativas == false)
{
    do
    {
        Console.WriteLine("\nEstá retornando de viagem realizada no exterior?" +
                  "\nDigite SIM ou NAO");
        estaRetornandoViagem = Console.ReadLine().ToUpper();

        if (estaRetornandoViagem == "SIM" || estaRetornandoViagem == "NAO") { break; }
        else
        {
            contador++;
            Console.WriteLine("\nDígito inválido! Digite SIM ou NAO.");
            if (contador == 3)
            {
                erroTentativas = true;
                break;
            }
        }
    } while (true);
}

// Valido se imprimo a mensagem de erro baseado se a pessoa erro em suas tentativas
if (erroTentativas == true)
    Console.WriteLine("\nNão foi possível realizar o diagnóstico. \nGentileza procurar ajuda médica caso apareça algum sintoma.");

else
{
    // Começo a incrementar a porcentagem de acordo com as perguntas respondidas
    if (estaRetornandoViagem == "SIM") { porcentagemInfeccao += 30; }

    if (cartaoVacinaEmDia == "NAO") { porcentagemInfeccao += 10; }

    if (teveSintomasRecentemente == "SIM") { porcentagemInfeccao += 30; }

    if (teveContatoComPessoasSintomaticas == "SIM") { porcentagemInfeccao += 30; }

    // Verifico se a pessoa está retornando de viagem e imprimo as informações
    if (estaRetornandoViagem == "SIM") { orientacaoFinal = "Você ficará sob observação por 05 dias."; }
    else
    {
        // Verifico a porcentagem de infecção para imprimir a orientação final de acordo com a porcentagem
        if (porcentagemInfeccao >= 90)
            orientacaoFinal = "\nPaciente crítico! Gentileza aguardar em lockdown por 10 dias para ser acompanhado.";

        else if (porcentagemInfeccao <= 30)
            orientacaoFinal = "\nPaciente sob observação. \nCaso apareça algum sintoma, gentileza buscar assistência médica.";

        else if (porcentagemInfeccao <= 60)
            orientacaoFinal = "\nPaciente com risco de estar infectado. \nGentileza aguardar em lockdown por 02 dias para ser acompanhado.";

        // Agora é o cenário entre 61% e 89%, diagnosticado na prática feita em aula
        else
            orientacaoFinal = "\nPaciente com alto risco de estar infectado. \nGentileza aguardar em lockdown por 05 dias para ser acompanhado.";
    }

    // Imprimo a mensagem final do programa
    Console.WriteLine("\nNome: " + nome);
    Console.WriteLine("Idade: " + idade + " anos");
    Console.WriteLine("Cartão Vacinal em Dia: " + cartaoVacinaEmDia);
    Console.WriteLine("Teve sintomas recentemente: " + teveSintomasRecentemente);
    Console.WriteLine("Teve contato com pessoas infectadas: " + teveContatoComPessoasSintomaticas);
    Console.WriteLine("Esta retornando de viagem: " + estaRetornandoViagem);
    Console.WriteLine($"Porcentagem infecção: {porcentagemInfeccao} %");
    Console.WriteLine("Orientação Final: " + orientacaoFinal);
}

Console.WriteLine("\nPesquisa concluída.");
Console.ReadLine();