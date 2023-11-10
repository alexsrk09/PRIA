using System.Linq.Expressions;
//1.  Crea un programa que:
// Sume todos los elementos (de tipo numérico) de un array, o lista, mediante un bucle.
// Multiplique todos los elementos (de tipo numérico) de un array, o lista, mediante un bucle.

static void ej0(){
    int[] a={1,2,3,4,5};
    int suma=0;
    int mult=1;
    for(int i=0;i<a.Length;i++){
        suma+=a[i];
        mult*=a[i];
    }
    Console.WriteLine("Suma: "+suma);
    Console.WriteLine("Multiplicación: "+mult);
}
// 2. Genera una tabla de multiplicar, del 1 al 10, de un número entero dado.
static void ej1(){
    int a=5;
    for(int i=1;i<=10;i++){
        Console.WriteLine(a+"x"+i+"="+(a*i));
    }
}
// 3. Imprime en pantalla, solo usando un bucle, todos los números del 0 al 99 excepto el 3, el 6 y el 11.
static void ej2(){
    for(int i=0;i<100;i++){
        if(i!=3 && i!=6 && i!=11){
            Console.WriteLine(i);
        }
    }
}
// 4. Multiplica todos los números impares existentes desde 1 hasta un número dado.
static void ej3(){
    int a=5;
    int mult=1;
    for(int i=1;i<=a;i++){
        if(i%2!=0){
            mult*=i;
        }
    }
    Console.WriteLine("Multiplicación: "+mult);
}
// 5. Suma todos los dígitos de un número dado.
static void ej4(){
    int a=12345;
    int suma=0;
    while(a>0){
        suma+=a%10;
        a/=10;
    }
    Console.WriteLine("Suma: "+suma);
}
// 6. Imprime en pantalla si un entero dado es primo o no. Un número primo es un entero mayor que 1 que solo se puede dividir por 1 y por sí mismo.
static void ej5(){
    int a=7;
    bool primo=true;
    for(int i=2;i<a;i++){
        if(a%i==0){
            primo=false;
            break;
        }
    }
    if(primo){
        Console.WriteLine("Es primo");
    }else{
        Console.WriteLine("No es primo");
    }
}
// 7. Imprime en pantalla todos los números primos desde el 2, incluído, hasta un entero dado.
static void ej6(){
    int a=7;
    for(int i=2;i<=a;i++){
        bool primo=true;
        for(int j=2;j<i;j++){
            if(i%j==0){
                primo=false;
                break;
            }
        }
        if(primo){
            Console.WriteLine(i);
        }
    }
}
// 8. Imprime en pantalla, solo usando un bucle, el siguiente patrón:
static void ej7(){
    string cadena="";
    for(int i=1;i<=9;i++){
        // la cadena siempre tendrá los caracteres con la longitud de i
        cadena+="*";
        // Console.WriteLine(cadena);
        // reemplaza el caracter * por el valor de i
        Console.WriteLine(cadena.Replace("*",i.ToString()));
    }
}
ej7();