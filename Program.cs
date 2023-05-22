int valor;

Console.WriteLine("--- Entrada Válida ---\n");

do
{
    Console.Write("Digite um número entre 1 e 9 (ou 0 para cancelar)...: ");
    valor = Convert.ToInt32(Console.ReadLine());
}
while (valor < 0 || valor > 9);

if (valor == 0)
{
    Console.WriteLine("\nOperação cancelada.");
}
else
{
    Console.WriteLine($"Número selecionado = {valor}");
}

Console.WriteLine("Volte sempre!");