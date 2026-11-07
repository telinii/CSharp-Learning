Console.Write("Digite seu nome: ");
string? nome = Console.ReadLine();

Console.Write("Digite sua formação e/ou se está cursando algo e oquê: ");
string? formacao = Console.ReadLine();

Console.WriteLine("Vamos começar com alguns emojis no terminal: ");
Console.WriteLine("Escola uma opção de emoji: ");
Console.WriteLine("1 2 3");
int escolha = int.TryParse(Console.ReadLine()!, out int result) ? result : 0;
if (escolha == 1)
//emoji de um fantasma (com caracteress ASCII)
{
    Console.WriteLine(" .^. ");
    Console.WriteLine("|   |");
    Console.WriteLine("|o o|");
    Console.WriteLine("|   |");
    Console.WriteLine("| O |");
}
else if (escolha == 2)
// emoji de gato (com caracteres ASCII)
{
    Console.WriteLine(".^___^.");
    Console.WriteLine("|     |");
    Console.WriteLine("|ò   ó|");
    Console.WriteLine("|  1  |");
    Console.WriteLine("|`=-=´|");
    Console.WriteLine(" |___| ");
}
else if (escolha == 3)
// emoji de coracao (com caracteres ASCII)
{
    Console.WriteLine(" ***o_ _o*** ");
    Console.WriteLine("******|******");
    Console.WriteLine("*************");
    Console.WriteLine(" *********** ");
    Console.WriteLine("  *********  ");
    Console.WriteLine("   *******   ");
    Console.WriteLine("    *****    ");
    Console.WriteLine("     ***     ");
    Console.WriteLine("      *      ");
}





// comando para executar o projeto no terminal:
// dotnet run
// erros comuns podem ocorrer se o arquivo não estiver dentro de um projeto .NET válido.
// como criar um projeto .NET válido:
// 1. Abra o terminal e navegue até o diretório onde deseja criar o projeto
// 2. Execute o comando: dotnet new console -n NomeDoProjeto
// 3. Navegue até o diretório do projeto: cd NomeDoProjeto
// 4. Substitua o conteúdo do arquivo Program.cs pelo código acima
// 5. Execute o programa com o comando: dotnet run