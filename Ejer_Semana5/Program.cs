//Ejercicio#1
 static double CalcularAreaCirculo(double radio)
{
    double area = Math.PI * Math.Pow(radio, 2);
    return area;
}
double radio = 5;
double area = CalcularAreaCirculo(radio);
Console.WriteLine("El área del círculo con radio {0} es {1}", radio, area);

//Ejercicio#2
 static double CalcularPerimetroRectangulo(double ancho, double altura)
{
    double perimetro = 2 * (ancho + altura);
    return perimetro;
}
double ancho = 5;
double altura = 10;
double perimetro = CalcularPerimetroRectangulo(ancho, altura);
Console.WriteLine("El perímetro del rectángulo con ancho {0} y altura {1} es {2}", ancho, altura, perimetro);

//Ejercicio#3
static double CalcularPromedio(List<int> numeros)
{
    double promedio = 0;
    if (numeros.Count > 0)
    {
        foreach (int num in numeros)
        {
            promedio += num;
        }
        promedio /= numeros.Count;
    }
    return promedio;
}
List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };
double promedio = CalcularPromedio(numeros);
Console.WriteLine("El promedio de los números {0} es {1}", string.Join(", ", numeros), promedio);

//Ejercicio#4
static string DeterminarParidad(int numero)
{
    if (numero % 2 == 0)
    {
        return "par";
    }
    else
    {
        return "impar";
    }
}
int numero = 10;
string paridad = DeterminarParidad(numero);
Console.WriteLine("El número {0} es {1}", numero, paridad);

//Ejercicio#5
static string ConvertirMayusculas(string cadena)
{
    string cadenaMayusculas = cadena.ToUpper();
    return cadenaMayusculas;
}

string cadena = "Hola, mundo!";
string cadenaMayusculas = ConvertirMayusculas(cadena);
Console.WriteLine("La cadena original es: {0}", cadena);
Console.WriteLine("La cadena en mayúsculas es: {0}", cadenaMayusculas);

//Ejercicio#6
static double CalcularDistancia(double x1, double y1, double x2, double y2)
{
    double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return distancia;
}
double x1 = 1;
double y1 = 2;
double x2 = 4;
double y2 = 6;
double distancia = CalcularDistancia(x1, y1, x2, y2);
Console.WriteLine("La distancia entre los puntos ({0}, {1}) y ({2}, {3}) es {4}", x1, y1, x2, y2, distancia);

//Ejercicio#7
static int CalcularSumaNaturales(int n)
{
    int suma = 0;
    for (int i = 1; i <= n; i++)
    {
        suma += i;
    }
    return suma;
}
int n = 5;
int suma = CalcularSumaNaturales(n);
Console.WriteLine("La suma de los primeros {0} números naturales es {1}", n, suma);

//Ejercicio#8
static int CalcularFactorial(int f)
{
    int factorial = 1;
    for (int i = 1; i <= f; i++)
    {
        factorial *= i;
    }
    return factorial;
}
int f = 5;
int factorial = CalcularFactorial(f);
Console.WriteLine("El factorial de {0} es {1}", f, factorial);