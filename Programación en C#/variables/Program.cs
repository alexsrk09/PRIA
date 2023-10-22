using System.Linq.Expressions;

//  1.Crea un programa que imprima la cadena de caracteres (o string) ¡Hola, mundo! en pantalla.
static void ej0(){
Console.WriteLine("Hello, World!");
}
// 2.Inicializa una variable (es decir, crea una variable con un identificador determinado y dale un valor) de tipo número real e imprime dicha variable en pantalla (se tendrán que ver el valor de esa variable).
static void ej1(){
    int variable=0;
    Console.WriteLine(variable);
}

// 3. Inicializa dos variables, con identificadores edad y altura, e imprímelas junto en el mensaje: Tengo edad años y mido altura cm (se tienen que ver los dos valores dados).
static void ej2(){
    int edad=45;
    float altura=3.8f;
    Console.WriteLine("Tengo "+edad+" años y mido "+altura+" cm");
}


// 4. Inicializa dos variables de tipo número entero, súma las variables e imprime el resultado por pantalla.
static void ej3(){
    int a=45;
    int b=3;
    Console.WriteLine("resultado="+a+b+"");
}

// 5. Inicializa cuatro variables, una de cada tipo de variable básico, e imprímelas todas en un mismo mensaje.
static void ej4(){
    int a=45;
    float b=3.45f;
    bool c=false;
    char d='s';
    Console.WriteLine("resultado="+a+" "+b+" "+c+" "+d);
}

// 6. Inicializa una variable radio y calcula la circunferencia guardando el resultado en la variable circunferencia. Fórmula: 2 · п · radio.
static void ej5(){
    float radio=3.45f;
    Console.WriteLine("resultado="+Math.PI*2*radio);
}

// 7. Inicializa una variable radio y calcula el área de un círculo guardando el resultado en la variable area. Fórmula: п · radio · radio.
static void ej6(){
    float radio=3.46565f;
    Console.WriteLine("resultado="+Math.PI*radio*radio);
}

// 8. Convierte una variable con identificador latitud de tipo cadena de caracteres y con valor -234.62 a tipo número real. Réstale a la variable el valor 21.34 e imprime finalmente dicha variable.
static void ej7(){
    string latitud ="-234,62";
    try{
        Console.WriteLine("resultado= "+(float.Parse(latitud)-31.24f));
    }
    catch(Exception e){
        Console.WriteLine("número no válido");
    }
}
// 9. Inicializa una variable celsius, calcula su equivalente a grados Fahrenheit e ímprimelo por pantalla. Fórmula: fahrenheit = (celsius * 1.8) + 32.
static void ej8(){
    float celsius=47;
    Console.WriteLine("resultado= "+(celsius*1.8f +32));
}
// 10. Inicializa una variable fahrenheit, calcula su equivalente a grados Celsius e ímprimelo por pantalla. Fórmula: celsius = (fahrenheit - 32) / 1.8.
static void ej9(){
    float fahrenheit=116.6f;
    Console.WriteLine("resultado= "+(fahrenheit-32)/1.8f);
}

// 11. Dado tres enteros, súmalos e imprime el resultado.
static void ej10(){
    int a=45;
    int b=3;
    int c=4;
    Console.WriteLine("resultado= "+a+b+c);
}
// 12. Realiza un conversor de Fahrenheit a Celsius.
static void ej11a(){
    float celsius=47;
    Console.WriteLine("resultado= "+(celsius*1.8f +32));
}
static void ej11b(){
    float fahrenheit=116.6f;
    Console.WriteLine("resultado= "+(fahrenheit-32)/1.8f);
}
// 13. Calcula el área y el perímetro de un rectángulo dado sus lados.
static void ej12(){
    int a=45;
    int b=3;
    Console.WriteLine("area= "+a*b+" perimetro= "+(2*a+2*b));
}
// 14. Concatena dos números, convierte el resultado a entero y súmale 5.
static void ej13(){
    string a="2";
    string b="3";
    Console.WriteLine("resultado= "+(int.Parse(a)+int.Parse(b)+5));
}
// 15. Multiplica tres enteros, concatena el resultado con un 4 al final y divide el resultado por 2.
static void ej14(){
    int a=1;
    int b=1;
    int c=1;
    Console.WriteLine("resultado= "+int.Parse((a*b*c)+"4")/2);
}
// 16. Dado un entero, indica con un 0 si el número es par y con un 1 si el número es impar
static void ej15(){
    int a=1;
    Console.WriteLine("resultado= "+a%2);
}
// 17. Dados cinco enteros, indica con un 0 si el número es par y con un 1 si el número es impar.
static void ej16(){
    int a=1;
    int b=1;
    int c=1;
    int d=1;
    int e=1;
    Console.WriteLine("resultado= "+a%2+b%2+c%2+d%2+e%2);
}
// 18. Imprime GNU si el número recibido es impar.
static void ej17(){
    int a=1;
    Console.WriteLine("resultado= "+(a%2==1?"GNU":""));
}
