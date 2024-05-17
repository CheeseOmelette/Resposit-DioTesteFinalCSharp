using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();
var tresultim = c.Historico();
bool ligado = true;
do {
double num1 = 0;
double num2 = 0;
Console.WriteLine("Bem vindo ao Sistema Calculadora! Por favor, escolha sua operação");
Console.WriteLine("1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n5 - Sair\n");
int opcao = Convert.ToInt32(Console.ReadLine());

switch (opcao) {
    
    case 1: 
    Console.WriteLine("Digite dois números!");
    num1 = Convert.ToDouble(Console.ReadLine());
    num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"\nResultado: {c.Somar(num1, num2)}");
    Console.WriteLine("Histórico Abaixo:");
    for (int i = Math.Max(tresultim.Count - 3, 0); i < tresultim.Count; i++)
    {   
         Console.WriteLine($"{tresultim[i]}");
    }
            
            

    break;

    case 2:
    Console.WriteLine("Digite dois números!");
    num1 = Convert.ToDouble(Console.ReadLine());
    num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"\nResultado: {c.Subtrair(num1, num2)}");
    Console.WriteLine("Histórico Abaixo:");
    for (int i = Math.Max(tresultim.Count - 3, 0); i < tresultim.Count; i++)
    {
         Console.WriteLine($"{tresultim[i]}");
    }
    
    break;


    case 3:
    Console.WriteLine("Digite dois números!");
    num1 = Convert.ToDouble(Console.ReadLine());
    num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"\nResultado: {c.Multiplicar(num1, num2)}");
    Console.WriteLine("Histórico Abaixo:");
    for (int i = Math.Max(tresultim.Count - 3, 0); i < tresultim.Count; i++)
    {
         Console.WriteLine($"{tresultim[i]}");
    }
    
    break;


    

    case 4:
    Console.WriteLine("Digite dois números!");
    num1 = Convert.ToDouble(Console.ReadLine());
    num2 = Convert.ToDouble(Console.ReadLine());
    try { Console.WriteLine($"\n{c.Dividir(num1, num2)}"); } catch (DivideByZeroException errors)
    {
        Console.WriteLine($"\nErro: {errors.Message}");
    }

    Console.WriteLine($"\nResultado: {c.Dividir(num1, num2)}");
    Console.WriteLine("Histórico Abaixo:");
    for (int i = Math.Max(tresultim.Count - 3, 0); i < tresultim.Count; i++)
    {   
         Console.WriteLine($"{tresultim[i]}");
    }
    break;

    case 5:
    ligado = false;
    break;

    default:
    Console.WriteLine("Opção Inválida");
    break;

}


} while (ligado == true);
