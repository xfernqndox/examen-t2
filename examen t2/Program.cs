int n;
System.Console.WriteLine("¿Cuantas notas desea ingresar?");
n = int.Parse(Console.ReadLine());

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

suma += nota;

if (nota > maxima)
{
    maxima = nota;
}
if (nota < minima)
{
    minima = nota;
}
if (nota >= 12)
{
    aprobados++;
}
}
double promedio = (double)suma / n;
int desaprobados = n - aprobados;
double porcentajeAprobados = (double)aprobados / n * 100;
double porcentajeDesaprobados = (double)desaprobados / n * 100;
System.Console.WriteLine("Reportes de notas:");
System.Console.WriteLine("Promedio: " + promedio);
System.Console.WriteLine("Nota máxima: " + maxima);
System.Console.WriteLine("Nota mínima: " + minima);
System.Console.WriteLine("Aprobados: " + aprobados);
System.Console.WriteLine("Desaprobados: " + desaprobados);
System.Console.WriteLine("Porcentaje de aprobados: " + porcentajeAprobados);
System.Console.WriteLine("Porcentaje de desaprobados: " + porcentajeDesaprobados);
if (porcentajeDesaprobados > 75)
{
    System.Console.WriteLine("Alerta: Más del 75% de los estudiantes han desaprobado.");
}