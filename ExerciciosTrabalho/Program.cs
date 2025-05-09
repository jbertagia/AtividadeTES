using System;
using System.Numerics; //necessário utilizar por conta do BigInteger do exercicio número 3

class Program
{
    //Menu para exercicios
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Menu de Exercícios:\n");
            Console.WriteLine(" 1 - Exercício 1");
            Console.WriteLine(" 2 - Exercício 2");
            Console.WriteLine(" 3 - Exercício 3");
            Console.WriteLine(" 4 - Exercício 4");
            Console.WriteLine(" 5 - Exercício 5");
            Console.WriteLine(" 6 - Exercício 6");
            Console.WriteLine(" 7 - Exercício 7");
            Console.WriteLine(" 8 - Exercício 8");
            Console.WriteLine(" 9 - Exercício 9");
            Console.WriteLine("10 - Exercício 10");
            Console.WriteLine(" 0 - Sair");
            Console.WriteLine("\nEscolha uma opção:");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    ExecutarExercicio1();
                    break;
                case "2":
                    ExecutarExercicio2();
                    break;
                case "3":
                    ExecutarExercicio3();
                    break;
                case "4":
                    ExecutarExercicio4();
                    break;
                case "5":
                    ExecutarExercicio5();
                    break;
                case "6":
                    ExecutarExercicio6();
                    break;
                case "7":
                    ExecutarExercicio7();
                    break;
                case "8":
                    ExecutarExercicio8();
                    break;
                case "9":
                    ExecutarExercicio9();
                    break;
                case "10":
                    ExecutarExercicio10();
                    break;
                case "0":
                    continuar = false;
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            if (continuar)
            {
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }
        }
    }

    // Lista de métodos que chamam cada um dos exercícios
    static void ExecutarExercicio1()
    {
        Console.WriteLine("\nExecutando Exercício 1...");
        /*
        1. Validador de Senhas Fortes
        Peça ao usuário que digite uma senha e verifique se ela atende aos seguintes critérios:

        • Mínimo de 8 caracteres
        • Pelo menos uma letra maiúscula
        • Pelo menos um número
        • Pelo menos um caractere especial (ex: !, @, #)
        */

        bool senhaValida = false;

        while (!senhaValida)
        {
            Console.WriteLine("\nValidador de Senhas Fortes");
            Console.WriteLine("\nDigite uma senha para verificar se ela é forte:");

            string senha = Console.ReadLine();
            bool temMaiuscula = false;
            bool temNumero = false;
            bool temEspecial = false;

            foreach (char c in senha)
            {
                if (char.IsUpper(c))
                    temMaiuscula = true;
                else if (char.IsDigit(c))
                    temNumero = true;
                else if ("!@#%&*()_+=-|/?".Contains(c))
                    temEspecial = true;
            }

            if (senha.Length >= 8 && temMaiuscula && temNumero && temEspecial)
            {
                Console.WriteLine("Senha válida!");
                senhaValida = true;
            }
            else
            {
                Console.WriteLine("Senha inválida!");
                Console.WriteLine("Critérios necessários:\n");

                if (senha.Length < 8)
                    Console.WriteLine("- Pelo menos 8 caracteres");
                if (!temMaiuscula)
                    Console.WriteLine("- Pelo menos uma letra maiúscula");
                if (!temNumero)
                    Console.WriteLine("- Pelo menos um número");
                if (!temEspecial)
                    Console.WriteLine("- Pelo menos um caractere especial (!, @, #, etc.)");
            }
        }

        Console.WriteLine("Programa finalizado. Obrigado por inserir uma senha válida!");
        Console.WriteLine("\nExercício 1 concluído!");
    }

    static void ExecutarExercicio2()
    {
        Console.WriteLine("\nExecutando Exercício 2...");
        /*
        2. Tabuada Completa com Laço
        Solicite ao usuário um número e imprima a tabuada completa dele (de 1 a 10),
        utilizando um for.
        */

        // Lógica do exercício 2
        Console.WriteLine("\nDigite o numero desejado para verificar a tabela do mesmo: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n1} X {i} = {n1 * i}");
        }
        Console.WriteLine("\nExercício 2 concluído!");
    }

    static void ExecutarExercicio3()
    {
        Console.WriteLine("\nExecutando Exercício 3...");
        /*
        3. Cálculo de Fatorial com while
        Peça ao usuário um número inteiro positivo e calcule o fatorial desse número usando
        while.
        */

        Console.WriteLine("\nDigite um número inteiro positivo:");

        int numero = int.Parse(Console.ReadLine());
        int contador = numero;
        BigInteger fatorial = 1;

        while (numero < 0)
        {
            Console.WriteLine("Número inválido! Digite um número positivo:");
            numero = int.Parse(Console.ReadLine());
        }

        while (contador > 1)
        {
            fatorial *= contador;
            contador--;
        }

        Console.WriteLine($"\nO fatorial de {numero} é: {fatorial:N0}");
        Console.WriteLine("\nExercício 3 concluído!");
    }

    static void ExecutarExercicio4()
    {
        Console.WriteLine("\nExecutando Exercício 4...");
        /*4. Conversor de Temperaturas com Menu
        Crie um menu com as opções:
        1 - Celsius para Fahrenheit
        2 - Fahrenheit para Celsius
        3 - Sair
        Use switch e while para manter o menu ativo até o usuário sair.
        */

        // Lógica do exercício 4
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.WriteLine("3 - Sair");

            Console.WriteLine("\nDigite a opção desejada: ");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Digite a temperatura em Graus Celsius: ");
                    float celsius = float.Parse(Console.ReadLine());
                    float calculo1 = (celsius * 9f / 5f) + 32;
                    Console.WriteLine($"A temperatura de {celsius}°C em Fahrenheit {calculo1}°F \n");
                    break;
                case 2:
                    Console.WriteLine("Digite a temperatura em Graus Fahrenheit: ");
                    float fahrenheit = float.Parse(Console.ReadLine());
                    float calculo2 = (5f / 9f) * (fahrenheit - 32);
                    Console.WriteLine($"A temperatura de {fahrenheit}°F em Celsius {calculo2}°C \n");
                    break;
                case 3:
                    Console.WriteLine("Saindo de conversor...");
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("\nErro numero informado inexistente");
                    break;
            }
        }
        Console.WriteLine("\nExercício 4 concluído!");
    }

    static void ExecutarExercicio5()
    {
        Console.WriteLine("\nExecutando Exercício 5...");
        /*
        5. Verificador de Palíndromos
        Peça ao usuário para digitar uma palavra ou frase e verifique se ela é um palíndromo
        (lê-se igual de frente para trás e de trás para frente, desconsiderando espaços e acentos).
        */

        Console.WriteLine("\nVerificador de Palíndromos");
        Console.WriteLine("\nDigite uma palavra ou frase:");

        string entrada = Console.ReadLine();
        string textoTratado = entrada.Replace(" ", "").ToLower();
        string textoInvertido = "";
        int i = textoTratado.Length - 1;

        while (i >= 0)
        {
            textoInvertido += textoTratado[i];
            i--;
        }

        if (textoTratado == textoInvertido)
        {
            Console.WriteLine("É um palíndromo!");
        }
        else
        {
            Console.WriteLine("Não é um palíndromo.");
        }
        Console.WriteLine("\nExercício 5 concluído!");
    }

    //Classe para o exercicio 06 dos produtos
    public class Produto
    {
        public string Nome { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, float preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public float valorTotal()
        {
            return Quantidade * Preco;
        }
    }
    static void ExecutarExercicio6()
    {
        Console.WriteLine("\nExecutando Exercício 6...");
        /*
        6. Cadastro Simples de Produtos
        Crie uma classe Produto com propriedades Nome, Preço e Quantidade. Permita ao
        usuário cadastrar 3 produtos e depois liste todos com o valor total em estoque (Preço *
        Quantidade).
        */

        // Lógica do exercício 6
        List<Produto> produtos = new List<Produto>(); // Criação da lista!

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"\nCadastro do produto {i}:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            float preco = float.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade);
            produtos.Add(produto);
        }

        Console.WriteLine("\nProdutos cadastrados:");

        foreach (Produto p in produtos)
        {
            Console.WriteLine($"Nome: {p.Nome}");
            Console.WriteLine($"Preço: R$ {p.Preco:F2}");
            Console.WriteLine($"Quantidade: {p.Quantidade}");
            Console.WriteLine($"Valor total no estoque: R$ {p.valorTotal():F2}\n");
        }

        Console.WriteLine("\nExercício 6 concluído!");
    }

    static void ExecutarExercicio7()
    {
        Console.WriteLine("\nExecutando Exercício 7...");
        /*
        7. Soma de Números Pares de um Array
        Peça ao usuário 10 números e armazene em um array. Depois, calcule a soma apenas
        dos números pares.
        */

        int[] numeros = new int[10];
        int somaPares = 0;
        int i = 0;

        Console.WriteLine("\nDigite 10 números:");

        while (i < 10)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            int numero = int.Parse(Console.ReadLine());

            numeros[i] = numero;

            if (numero % 2 == 0)
            {
                somaPares += numero;
            }

            i++;
        }

        Console.WriteLine($"\nA soma dos números pares é: {somaPares}");
        Console.WriteLine("\nExercício 7 concluído!");
    }

    static void ExecutarExercicio8()
    {
        Console.WriteLine("\nExecutando Exercício 8...");
        /*
        8. Cálculo de IMC com Classificação
        Solicite o peso (kg) e altura (m) do usuário, calcule o IMC e informe a classificação:
        • Abaixo de 18.5: Abaixo do peso
        • 18.5 a 24.9: Peso normal
        • 25 a 29.9: Sobrepeso
        • 30 ou mais: Obesidade
        */

        // Lógica do exercício 8
        Console.Write("Digite o seu peso: ");
        float peso = float.Parse(Console.ReadLine());
        Console.Write("Digite a sua altura: ");
        float altura = float.Parse(Console.ReadLine());

        float imc = peso / (altura * altura);
        string classificacao = "";

        if (imc < 18.5) classificacao = "Abaixo do peso";
        else if (imc > 18.5 && imc < 24.9) classificacao = "Com o Peso normal";
        else if (imc > 25 && imc < 29.9) classificacao = "Sobrepeso";
        else classificacao = "Com Obesidade";

        Console.Write($"\nSeu IMC = {imc} \nE voce está {classificacao}");


        Console.WriteLine("\n\nExercício 8 concluído!");
    }

    static void ExecutarExercicio9()
    {
        Console.WriteLine("\nExecutando Exercício 9...");
        /*
        9. Jogo da Adivinhação
        Gere um número aleatório entre 1 e 100. Peça que o usuário tente adivinhar. Após cada
        tentativa, informe se o número é maior ou menor. Conte o número de tentativas.
        */

        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int tentativas = 0;
        int palpite = 0;

        Console.WriteLine("\nJogo da Adivinhação");
        Console.WriteLine("\nTente adivinhar o número entre 1 e 100!");

        while (palpite != numeroSecreto)
        {
            Console.Write("\nDigite seu palpite: ");
            palpite = int.Parse(Console.ReadLine());
            tentativas++;

            if (palpite < numeroSecreto)
            {
                Console.WriteLine("O número secreto é maior! >");
            }
            else if (palpite > numeroSecreto)
            {
                Console.WriteLine("O número secreto é menor! <");
            }
            else
            {
                Console.WriteLine($"Parabéns! Você acertou o número {numeroSecreto} em {tentativas} tentativas!");
            }
        }
        Console.WriteLine("\nExercício 9 concluído!");
    }

    static void ExecutarExercicio10()
    {
        Console.WriteLine("\nExecutando Exercício 10...");
        /*
        10. Lista de Tarefas (To-Do List)
        Permita que o usuário adicione tarefas a uma lista e, ao final, mostre todas as tarefas
        inseridas. Use List<string> e ofereça uma opção para marcar tarefas como
        concluídas.
        */

        // Lógica do exercício 10
        List<string> tarefas = new List<string>();

        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("\nO que deseja fazer?");
            Console.WriteLine("1- Adicionar tarefas.");
            Console.WriteLine("2- Exibir tarefas.");
            Console.WriteLine("3- Concluir tarefa.");
            Console.WriteLine("4- Encerrar");
            string decisao = Console.ReadLine();

            switch (decisao)
            {
                case "1":
                    Console.WriteLine("Digite suas tarefas (digite 'fim' para parar):");

                    while (true)
                    {
                        Console.Write("Tarefa: ");
                        string tarefa = Console.ReadLine();

                        if (tarefa.ToLower() == "fim")
                            break;

                        tarefas.Add(tarefa);
                    }
                    Console.WriteLine("Tarefas adicionadas.");
                    break;

                case "2":
                    Console.WriteLine("\nLista de tarefas:");
                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} - {tarefas[i]}");
                    }
                    break;

                case "3":
                    Console.WriteLine("\nDigite o número da tarefa que deseja marcar como concluída:");
                    int numero = int.Parse(Console.ReadLine()) - 1;

                    if (numero >= 0 && numero < tarefas.Count)
                    {
                        if (!tarefas[numero].StartsWith("[Concluído] "))
                        {
                            tarefas[numero] = "[Concluído] " + tarefas[numero];
                            Console.WriteLine("Tarefa marcada como concluída!");
                        }
                        else
                        {
                            Console.WriteLine("Essa tarefa já está concluída.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                    }
                    break;

                case "4":
                    continuar = false;
                    Console.WriteLine("Saindo do gerenciador de tarefas...");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }

        Console.WriteLine("\nExercício 10 concluído!");
    }
}
