using System;
// 1. Crea una función que reciba un parámetro de entrada de tipo entero y que devuelva un booleano con valor true si el número es par y false si es impar. Ejecuta 3 llamadas de ejemplo de la función creada.
void ej0()
{
    Console.WriteLine(esPar(2));
    Console.WriteLine(esPar(3));
    Console.WriteLine(esPar(4));
}
bool esPar(int num)
{
    return num % 2 == 0;
}
// 2. Crea una función que reciba dos parámetros de entrada de tipo númerico y que devuelva el máximo. Ejecuta 3 llamadas de ejemplo de la función creada.
void ej1()
{
    Console.WriteLine(max([2, 3]));
    Console.WriteLine(max([3, 2]));
    Console.WriteLine(max([4, 4]));
}
int max(int[] a)
{
    int max = a[0];
    for (int i = 1; i < a.Length; i++)
    {
        if (a[i] > max)
        {
            max = a[i];
        }
    }
    return max;
}
//  3. Crea una función que reciba dos parámetros de entrada de tipo númerico y que devuelva un array, o lista, con el máximo, el mínimo y la media de esos dos números. Ejecuta 3 llamadas de ejemplo de la función creada.
void ej2()
{
    int[] res = maxMinMedia(2, 3);
    Console.WriteLine(res[0]);
    Console.WriteLine(res[1]);
    Console.WriteLine(res[2]);
}
int[] maxMinMedia(int a, int b)
{
    int[] res = new int[3];
    res[0] = max([a, b]);
    res[1] = min([a, b]);
    res[2] = media([a, b]);
    return res;
}
int min(int[] a)
{
    int min = a[0];
    for (int i = 1; i < a.Length; i++)
    {
        if (a[i] < min)
        {
            min = a[i];
        }
    }
    return min;
}
int media(int[] a)
{
    int sum = 0;
    for (int i = 0; i < a.Length; i++)
    {
        sum += a[i];
    }
    return sum / a.Length;
}
// 4. Crea una función que reciba un parámetro de entrada de tipo array, o lista, de tipo numérico y que devuelva un array, o lista, con la media y con otro array, o lista, con los números ordenados de mayor a menor. Ejecuta 3 llamadas de ejemplo de la función creada.
void ej3()
{
    int[] res = mediaYOrdenados([1, 10, 1]);
    for (int i = 0; i < res.Length; i++)
    {
        if (i == 0) Console.WriteLine("Media: " + res[i]);
        else Console.WriteLine(res[i]);
    }
}
int[] mediaYOrdenados(int[] a)
{
    int[] res = new int[a.Length + 1];
    Array.Sort(a);
    for (int i = 0; i < a.Length; i++)
    {
        res[i + 1] = a[i];
    }
    return res;
}
//  5. Crea una función que reciba un parámetro de entrada de tipo numérico y que devuelva un array, o lista, con todos los dígitos de ese número. Por ejemplo, la función devolverá [3, 4, 4] si la entrada es 344. Ejecuta 3 llamadas de ejemplo de la función creada.
void ej4()
{
    int[] res = digitos(344);
    for (int i = 0; i < res.Length; i++)
    {
        Console.WriteLine(res[i]);
    }
}
int[] digitos(int num)
{
    int[] res = new int[num.ToString().Length];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = num % 10;
        num /= 10;
    }
    Array.Reverse(res);
    return res;
}
// 6. Crea una función que actúe como una calculadora simple. Para ello, la función recibirá tres parámetros de entrada, dos de tipo numérico para los valores y un string o cadena de caracteres para la operación (+, -, * o /). La función devolverá el resultado de la operación elegida entre esos dos números. Ejecuta 3 llamadas de ejemplo de la función creada.
void ej5()
{
    Console.WriteLine(calc(2, 3, "+"));
    Console.WriteLine(calc(2, 3, "-"));
    Console.WriteLine(calc(2, 3, "*"));
    Console.WriteLine(calc(2, 3, "/"));
}
int calc(int a, int b, string op)
{
    switch (op)
    {
        case "+":
            return a + b;
        case "-":
            return a - b;
        case "*":
            return a * b;
        case "/":
            return a / b;
        default:
            return 0;
    }
}
//  7. Crea una función que reciba dos parámetros de entrada de tipo array, o lista, una de ellas de tipo string o cadena de caracteres y la otra de tipo numérico y que devuelva un array, o lista, donde se combine los dos array, o listas, alternativamente. Por ejemplo, la función devolverá ['hola', 3, 'qué', 6, 'tal', -4.5] si las entradas son ['hola', 'qué', 'tal'] y [3, 6, -4.5]. Ejecuta 3 llamadas de ejemplo de la función creada.
void ej6(){
    object[] res = combinar(["hola", "que", "tal"], [3, 6, -4.5f]);
    for (int i = 0; i < res.Length; i++) Console.WriteLine(res[i]);
}
object[] combinar(string[] a, object[] b){
    object[] res = new object[a.Length + b.Length];
    int j = 0;
    for (int i = 0; i < res.Length; i++){
        if (i % 2 == 0) res[i] = a[j];
        else{
            res[i] = b[j];
            j++;
        }
    }
    return res;
}
// 8. Crea una función que reciba un parámetro de entrada de tipo numérico que sea mayor que 5 (la función devolverá 0 si el número es 5 o más pequeño) y que devuelva la suma de todos los números desde 1 hasta n sin contar con los elementos n - 1 ni n - 3. Por ejemplo, la función devolverá 24 si la entrada es 8. Ejecuta 3 llamadas de ejemplo de la función creada.
void ej7()
{
    Console.WriteLine(suma(8));
    Console.WriteLine(suma(9));
    Console.WriteLine(suma(10));
}
int suma(int num)
{
    if (num <= 5) return 0;
    int res = 0;
    for (int i = 1; i <= num; i++) if (i != num - 1 && i != num - 3) res += i;
    return res;
}
// 9. Crea una función que reciba un parámetro de entrada de tipo array, o lista, de tipo string o cadena de caracteres y que imprima los strings dentro de un rectángulo. Por ejemplo, para el array, o lista, ['Me', 'gusta', 'la', 'pizza', 'margherita'] se imprimirá el siguiente rectángulo:

// **************
// * Me         *
// * gusta      *
// * la         *
// * pizza      *
// * margherita *
// **************
void ej8()
{
    string[] a = ["Me", "gusta", "la", "pizza", "margherita"];
    imprimirRectangulo(a);
}
void imprimirRectangulo(string[] a)
{
    int max = 0;
    for (int i = 0; i < a.Length; i++) if (a[i].Length > max) max = a[i].Length;
    string asteriscos = "";
    for (int i = 0; i < max + 4; i++) asteriscos += "*";
    Console.WriteLine(asteriscos);
    for (int i = 0; i < a.Length; i++){
        string espacios = "";
        for (int j = 0; j < max - a[i].Length; j++) espacios += " ";
        Console.WriteLine("* " + a[i] + espacios + " *");
    }
    Console.WriteLine(asteriscos);
}
// 10. Crea una función que reciba un parámetro de entrada de tipo numérico que tenga más de 10 dígitos (la función devolverá 0 si el número tiene 10 o menos dígitos) y que devuelva como salida los 5 dígitos consecutivos con mayor suma. Por ejemplo, la función devolverá 97798 si la entrada es 145436803497798443. Ejecuta 3 llamadas de ejemplo de la función creada.
void ej9(){
    Console.WriteLine(mayorSuma(145436803497798443L));
    Console.WriteLine(mayorSuma(145436803497798443L));
    Console.WriteLine(mayorSuma(145436803497798443L));
}
int mayorSuma(long num){
    if (num.ToString().Length <= 10) return 0;
    int[] digitos = obtenerDigitos(num);
    int max = 0;
    for (int i = 0; i < digitos.Length - 4; i++){
        int suma = 0;
        for (int j = i; j < i + 5; j++)
        {
            suma += digitos[j];
        }
        if (suma > max)
        {
            max = suma;
        }
    }
    return max;
}
int[] obtenerDigitos(long num){
    List<int> digitList = new List<int>();
    while (num > 0){
        digitList.Add((int)(num % 10));
        num /= 10;
    }
    digitList.Reverse();
    return digitList.ToArray();
}
ej9();