SaqueOtimizado();

void Variaveis()
{
    int number1 = 32;
    long number2 = 64;
    float number3 = 4.0f;
    double number4 = 8.0;
    decimal number5 = 16.0m;
    bool verificacao = false;
    string texto = "nome";
    char letra = 'H';
    var valDinamico = "Hudson";
    const double pi = 3.14;

    Console.WriteLine($"Os números são {number1}, {number2}, {number3}, {number4}, {number5}, {pi}");
    Console.Write($"Os valores são {verificacao}, {texto}, {letra}, {valDinamico}");
}

void SaqueOtimizado()
{
    Console.Write("Digite seu saldo: R$");
    String nSaldo = Console.ReadLine();
    if (decimal.TryParse(nSaldo, out decimal saldo))
    {
        Console.Write("Digite o quanto deseja sacar: R$"); 
        String nSaque = Console.ReadLine();
        if (int.TryParse(nSaque, out int saque))
        {
            if (saque <= saldo)
            {
                int resto = saque;
                int saque200 = saque / 200;
                resto %= 200;
                int saque100 = resto / 100;
                resto %= 100;
                int saque50 = resto / 50;
                resto %= 50;
                int saque20 = resto / 20;
                resto %= 20;
                int saque10 = resto / 10;
                resto %= 10;
                int saque5 = resto / 5;
                resto %= 5;
                int saque2 = resto / 2;

                Console.WriteLine
                    ($"São sacadas:\n" +
                    $"{saque200} notas de R$200;\n" +
                    $"{saque100} notas de R$100;\n" +
                    $"{saque50} notas de R$50;\n" +
                    $"{saque20} notas de R$20;\n" +
                    $"{saque10} notas de R$10;\n" +
                    $"{saque5} notas de R$5;\n" +
                    $"{saque2} notas de R$2.\n" +
                    $"Seu saldo remanescente será de R${saldo - saque}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
        else
        {
            Console.WriteLine("Digite um valor de saque válido");
        }
    }
    else {
        Console.WriteLine("Digite um valor de saldo válido");
    }
}

void Meses()
{
    Console.Write("Digite um número de 1 a 12: ");
    int mes = int.Parse(Console.ReadLine());
    switch (mes)
    {
        case 1:
            Console.WriteLine("Janeiro.");
            break;
        case 2:
            Console.WriteLine("Fevereiro.");
            break;
        case 3:
            Console.WriteLine("Março.");
            break;
        case 4:
            Console.WriteLine("Abril.");
            break;
        case 5:
            Console.WriteLine("Maio.");
            break;
        case 6:
            Console.WriteLine("Junho.");
            break;
        case 7:
            Console.WriteLine("Julho.");
            break;
        case 8:
            Console.WriteLine("Agosto.");
            break;
        case 9:
            Console.WriteLine("Setembro.");
            break;
        case 10:
            Console.WriteLine("Outubro.");
            break;
        case 11:
            Console.WriteLine("Novembro.");
            break;
        case 12:
            Console.WriteLine("Dezembro.");
            break;
        default:
            Console.WriteLine("Digite um número válido.");
            break;
    }
}

void Primo() 
{
    Console.Write("Digite um número inteiro: ");
    int num = int.Parse(Console.ReadLine());
    int sobra = num % 2;
    int i = 3;
    bool primo = true;
   if (num == 2)
    {
        Console.WriteLine("Este número é primo.");
    }
    else if (sobra == 0)
    {
        Console.WriteLine("Este número não é primo.");
    }
    else
    {
        while (i <= (num / 2))
        {
            sobra = num % i;
            if (sobra == 0)
            {
                Console.WriteLine("Este número não é primo.");
                i = num;
                primo = false;
            }
            else
            {
                i = i + 2;
            }
        }
        if (primo)
        {
            Console.WriteLine("Este número é primo.");
        }  
    }
}

void Fibonacci()
{
    int fi1 = 0;
    int fi2 = 1;
    for (int i = 1; i <= 10; i ++)
    { 
        Console.WriteLine(fi1);
        Console.WriteLine(fi2);
        fi1 = fi2 + fi1;
        fi2 = fi1 + fi2;
    }
}
void Piramide()
{
    Console.WriteLine("Digite até que número irá a pirâmide");
    int num = int.Parse(Console.ReadLine());
    int i = 1;
    int j = 1;
    int n = 1;
    do
    {
        while (j <= n)
        { 
            Console.Write(n);
            j++;
        }
        j = 1;
        n++;
        i++;
        Console.WriteLine("");
    }  while (i <= num);
}



