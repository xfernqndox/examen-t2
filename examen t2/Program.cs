int CalcularAprobados(int nota)
{
    if (nota >= 12)
    {
        return 1;
    }

    return 0;
}
int n;
System.Console.WriteLine("¿Cuantas notas desea ingresar?");
n = int.Parse(Console.ReadLine());

int[] notas = new int[n];

int suma = 0;
int maxima = 0;
int minima = 20;   
int aprobados = 0;
 for (int i = 0; i < n; i++)
{
    int nota;

    do
    {
        System.Console.WriteLine("Ingrese la nota " + (i + 1) + ":");
        nota = int.Parse(Console.ReadLine());

        if (nota < 0 || nota > 20)
        {
            System.Console.WriteLine("Nota inválida. Por favor, ingrese una nota entre 0 y 20.");
        }
    } while (nota < 0 || nota > 20);

notas[i] = nota;

suma += nota;

if (nota > maxima)
{
    maxima = nota;
}
if (nota < minima)
{
    minima = nota;
}
aprobados += CalcularAprobados(nota);
}
double promedio = (double)suma / n;
int desaprobados = n - aprobados;
double porcentajeAprobados = (double)aprobados / n * 100;
double porcentajeDesaprobados = (double)desaprobados / n * 100;
System.Console.WriteLine("\n--- Reporte del Salón ---");
System.Console.Write("Notas ingresadas: [");
for (int i = 0; i < n; i++)
{
    System.Console.Write(notas[i]);

    if (i < n - 1)
    {
        System.Console.Write(", ");
    }
}
System.Console.WriteLine("]");
System.Console.WriteLine("\nPromedio    : " + 
promedio.ToString("0.00"));
System.Console.WriteLine("Nota máxima: " + maxima);
System.Console.WriteLine("Nota mínima: " + minima);
System.Console.WriteLine("\nAprobados   : " + aprobados +
" (" + porcentajeAprobados.ToString("0.00") + "%)");
System.Console.WriteLine("Desaprobados: " + desaprobados +
" (" + porcentajeDesaprobados.ToString("0.00") + "%)");

if (porcentajeDesaprobados > 75)
{
    System.Console.WriteLine("Alerta: Más del 75% de los estudiantes han desaprobado.");
}