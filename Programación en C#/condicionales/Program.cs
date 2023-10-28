using System.Linq.Expressions;
// 1. Crea un programa que determine si dos variables de tipo numérico son iguales o no.
static void ej0(){
    int a=1;
    int b=2;
    if(a==b){
        Console.WriteLine("Son iguales");
    }else{
        Console.WriteLine("No son iguales");
    }
}
// 2. Crea un programa que determine si un número entero es par o impar (pista: usar la operación %).
static void ej1(){
    int a=1;
    if(a%2==0){
        Console.WriteLine("Es par");
    }else{
        Console.WriteLine("Es impar");
    }
}
// 3. Crea un programa que determine si una variable de tipo numérico es positiva, negativa o cero.
static void ej2(){
    int a=1;
    if(a>0){
        Console.WriteLine("Es positivo");
    }else if(a<0){
        Console.WriteLine("Es negativo");
    }else{
        Console.WriteLine("Es cero");
    }
}
// 4. Crear un programa que determine si un número es menor que 0, o que está entre 0 y 50, o entre 51 y 100 o por encima de 100.
static void ej3(){
    int a=1;
    if(a<0){
        Console.WriteLine("Es menor que 0");
    }else if(a>=0 && a<=50){
        Console.WriteLine("Está entre 0 y 50");
    }else if(a>=51 && a<=100){
        Console.WriteLine("Está entre 51 y 100");
    }else{
        Console.WriteLine("Es mayor que 100");
    }
}
// 5. Crea un programa que determine si una letra es vocal o consonante.
static void ej4(){
    char a='a';
    if(a=='a' || a=='e' || a=='i' || a=='o' || a=='u'){
        Console.WriteLine("Es vocal");
    }else{
        Console.WriteLine("Es consonante");
    }
}
// 6. Crea un programa que determine si, dado sus tres ángulos, se puede formar un triángulo (pista: un triángulo se forma cuando sus tres ángulos suman 180º).
static void ej5(){
    int a=60;
    int b=60;
    int c=60;
    if(a+b+c==180){
        Console.WriteLine("Es un triángulo");
    }else{
        Console.WriteLine("No es un triángulo");
    }
}
// 7. Crea un programa que determine a partir de dos números cuál es el mayor y cuál es el menor o que imprima que son iguales si así lo son.
static void ej6(){
    int a=1;
    int b=2;
    if(a>b){
        Console.WriteLine("El mayor es a");
    }else if(a<b){
        Console.WriteLine("El mayor es b");
    }else{
        Console.WriteLine("Son iguales");
    }
}
// 8. Crea un programa que encuentre el número mayor a partir de tres números dados.
static void ej7(){
    int a=1;
    int b=2;
    int c=3;
    if(a>b && a>c){
        Console.WriteLine("El mayor es a");
    }else if(b>a && b>c){
        Console.WriteLine("El mayor es b");
    }else if(c>a && c>b){
        Console.WriteLine("El mayor es c");
    }else{
        Console.WriteLine("Son iguales");
    }
}
// 9. Crea un programa que imprima por orden alfabético tres cadena de caracteres o strings dados y que imprima si son o no iguales dichos tres strings.
static void ej8(){
    string a="a";
    string b="b";
    string c="c";
    if(a==b && a==c){
        Console.WriteLine("Son iguales");
    }else if(a==b){
        Console.WriteLine("a y b son iguales");
    }else if(a==c){
        Console.WriteLine("a y c son iguales");
    }else if(b==c){
        Console.WriteLine("b y c son iguales");
    }else{
        Console.WriteLine("Son diferentes");
    }
}
// 10. Crea un programa que determine si una persona está en edad de trabajar.
static void ej9(){
    int edad=18;
    if(edad>=18){
        Console.WriteLine("Es mayor de edad");
    }else{
        Console.WriteLine("Es menor de edad");
    }
}
// 11. Dado dos enteros, calcula la suma. Si el resultado está entre 10 y 19 (ambos incluídos), imprime 20. Si no, imprime la suma.
static void ej10(){
    int a=1;
    int b=2;
    int suma=a+b;
    if(suma>=10 && suma<=19){
        Console.WriteLine("20");
    }else{
        Console.WriteLine(suma);
    }
}
// 12. Dado tres enteros, devuelve verdadero si no aparece ni un 1 y ni un 3.
static void ej11(){
    int a=1;
    int b=2;
    int c=3;
    if(a!=1 && a!=3 && b!=1 && b!=3 && c!=1 && c!=3){
        Console.WriteLine("Verdadero");
    }else{
        Console.WriteLine("Falso");
    }
}
// 13. Dado cinco enteros, devuelve verdadero si aparece alguna vez 3 enteros impares consecutivos.
static void ej12(){
    int a=1;
    int b=2;
    int c=3;
    int d=4;
    int e=5;
    if((a%2!=0 && b%2!=0 && c%2!=0) || (b%2!=0 && c%2!=0 && d%2!=0) || (c%2!=0 && d%2!=0 && e%2!=0)){
        Console.WriteLine("Verdadero");
    }else{
        Console.WriteLine("Falso");
    }
}
// 14. Elimina todas las vocales dada una cadena, o string, de cinco caracteres.
static void ej13(){
    string a="aeiou";
    string b="";
    for(int i=0;i<a.Length;i++){
        if(a[i]!='a' && a[i]!='e' && a[i]!='i' && a[i]!='o' && a[i]!='u'){
            b+=a[i];
        }
    }
    Console.WriteLine(b);
}
// 15. Detecta la primera aparición de un entero a partir de una serie de cinco enteros devolviendo el índice con su posición.
static void ej14(){
    int[] a={1,2,3,4,5};
    int b=3;
    for(int i=0;i<a.Length;i++){
        if(a[i]==b){
            Console.WriteLine(i);
            break;
        }
    }
}
// 16. Dadas dos series de tres enteros, comprueba si todos los enteros de la primera serie aparecen en alguno de los enteros de la segunda serie.
static void ej15(){
    int[] a={1,2,3};
    int[] b={1,2,3,4,5};
    bool c=true;
    for(int i=0;i<a.Length;i++){
        if(a[i]!=b[i]){
            c=false;
            break;
        }
    }
    Console.WriteLine(c);
}
// 17. Convierte de centímetros a metros y vicerversa.
static void ej16(){
    int a=1;
    int b=100;
    Console.WriteLine(a*100);
    Console.WriteLine(b/100);
}
// hay un error en la numeración de los ejercicios, ha aparecido el 20 después del 17
// 20. Dados dos enteros positivos, imprime el valor más cercano a 21 sin sobrepasarse. Imprime 0 si los dos enteros son mayores que 21.
static void ej17(){
    int a=1;
    int b=2;
    if(a>21 && b>21){
        Console.WriteLine("0");
    }else if(a>21){
        Console.WriteLine(b);
    }else if(b>21){
        Console.WriteLine(a);
    }else if(a>21 && b>21){
        Console.WriteLine("0");
    }else if(21-a>21-b){
        Console.WriteLine(b);
    }else{
        Console.WriteLine(a);
    }
}
// 18. Dados dos enteros positivos, imprime el valor más cercano a 21 sin sobrepasarse. Imprime 0 si los dos enteros son mayores que 21.
static void ej18(){
    int a=1;
    int b=2;
    if(a>21 && b>21){
        Console.WriteLine("0");
    }else if(a>21){
        Console.WriteLine(b);
    }else if(b>21){
        Console.WriteLine(a);
    }else if(a>21 && b>21){
        Console.WriteLine("0");
    }else if(21-a>21-b){
        Console.WriteLine(b);
    }else{
        Console.WriteLine(a);
    }
}
// 19. Determina en una partida finalizada de tres en raya si gana O, gana X o hay empate.
static void ej19(){
    char[,] a={{'x','x','x'},{'o','o','o'},{'x','x','x'}};
    bool b=false;
    for(int i=0;i<3;i++){
        if(a[i,0]==a[i,1] && a[i,1]==a[i,2]){
            b=true;
            break;
        }
    }
    for(int i=0;i<3;i++){
        if(a[0,i]==a[1,i] && a[1,i]==a[2,i]){
            b=true;
            break;
        }
    }
    if(a[0,0]==a[1,1] && a[1,1]==a[2,2]){
        b=true;
    }
    if(a[0,2]==a[1,1] && a[1,1]==a[2,0]){
        b=true;
    }
    if(b){
        Console.WriteLine("Hay ganador");
    }else{
        Console.WriteLine("Hay empate");
    }
}
// 20. Determina si un entero (mayor que 0 y menor que 10 000) al leerlo contiene la palabra cinco.
static void ej20(){
    int a=5000;
    string b=a.ToString();
    bool c=false;
    for(int i=0;i<b.Length;i++){
        if(b[i]=='5'){
            c=true;
            break;
        }
    }
    if(c){
        Console.WriteLine("Contiene un 5");
    }else{
        Console.WriteLine("No contiene un 5");
    }
}