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
// Luego, imprime en pantalla, usando solo dos bucles, el siguiente patrón:
// Y un carajo, si el otro me has hecho hacerlo en un bucle, este tambien
static void ej7_1(){
    string cadena="";
    int longitud=9;
    for(int i=1;i<=9;i++){
        
        if(i/2+1<9/2)cadena+="*";
        else cadena=cadena.Remove(cadena.Length-1);
        Console.WriteLine(cadena);
    }
}
// 9. Imprime los números que sean divisibles por 7 y por 5 entre el rango 1500 y 2700 (ambos incluidos).
static void ej8(){
    for(int i=1500;i<=2700;i++){
        if(i%7==0 && i%5==0){
            Console.WriteLine(i);
        }
    }
}
// 10. Muestra en pantalla el número de ocurrencias de cada dígito en un número entero. Por ejemplo, para el número entero 116242320 imprimir que hay 2 unos, 3 doses, etc.
static void ej9(){
    int a=116242320;
    int[] ocurrencias=new int[10];
    while(a>0){
        ocurrencias[a%10]++;
        a/=10;
    }
    for(int i=0;i<ocurrencias.Length;i++){
        Console.WriteLine("El número "+i+" aparece "+ocurrencias[i]+" veces");
    }
}
// 11. Dada una serie de enteros, súmalos e imprime el resultado..
static void ej10(){
    int[] a={1,2,3,4,5};
    int suma=0;
    for(int i=0;i<a.Length;i++){
        suma+=a[i];
    }
    Console.WriteLine("Suma: "+suma);
}
// 12. Dado un string o cadena de caracteres, muestra solo sus consonantes.
static void ej11(){
    string cadena="hola";
    string consonantes="";
    for(int i=0;i<cadena.Length;i++){
        if(cadena[i]!='a' && cadena[i]!='e' && cadena[i]!='i' && cadena[i]!='o' && cadena[i]!='u'){
            consonantes+=cadena[i];
        }
    }
    Console.WriteLine(consonantes);
}
// 13. Dado una serie de enteros, devuelve verdadero si no aparece ni un 1 y ni un 3.
static void ej12(){
    int[] a={1,2,3,4,5};
    bool no13=true;
    for(int i=0;i<a.Length;i++){
        if(a[i]==1 || a[i]==3){
            no13=false;
            break;
        }
    }
    if(no13){
        Console.WriteLine("No hay 1 ni 3");
    }else{
        Console.WriteLine("Hay 1 o 3");
    }
}
// 14. Dado una serie de enteros, devuelve verdadero si aparece alguna vez 3 enteros impares consecutivos.
static void ej13(){
    int[] a={1,2,3,4,5};
    bool tresImpares=false;
    for(int i=0;i<a.Length-2;i++){
        if(a[i]%2!=0 && a[i+1]%2!=0 && a[i+2]%2!=0){
            tresImpares=true;
            break;
        }
    }
    if(tresImpares){
        Console.WriteLine("Hay 3 impares consecutivos");
    }else{
        Console.WriteLine("No hay 3 impares consecutivos");
    }
}
// 15. Muestra la suma de los dígitos de 2 elevado a n, siendo n un número natural.
static void ej14(){
    int n=5;
    int suma=0;
    int a=(int)Math.Pow(2,n);
    while(a>0){
        suma+=a%10;
        a/=10;
    }
    Console.WriteLine("Suma: "+suma);
}
// 16. Determina si los enteros dados están aumentando constantemente.
static void ej15(){
    int[] a={1,2,3,4,5};
    bool aumentando=true;
    for(int i=0;i<a.Length-1;i++){
        if(a[i]>a[i+1]){
            aumentando=false;
            break;
        }
    }
    if(aumentando){
        Console.WriteLine("Aumentando");
    }else{
        Console.WriteLine("No aumentando");
    }
}
// 17. Devuelve el entero más grande adyacente a un cero.
static void ej16(){
    int[] a={1,2,3,4,5};
    int max=0;
    for(int i=0;i<a.Length-1;i++){
        if(a[i]==0){
            max=Math.Max(a[i-1],a[i+1]);
        }
    }
    Console.WriteLine("Max: "+max);
}
// 18. Muestra los dígitos, ordenados de menor a mayor, que aparecen exactamente tres veces.
static void ej17(){
    int[] a={1,2,3,4,5};
    int[] ocurrencias=new int[10];
    for(int i=0;i<a.Length;i++){
        ocurrencias[a[i]]++;
    }
    for(int i=0;i<ocurrencias.Length;i++){
        if(ocurrencias[i]==3){
            Console.WriteLine(i);
        }
    }
}
// 19. Muestra los enteros, ordenados de menor a mayor, que aparecen exactamente tres veces.
static void ej18(){
    int[] a={1,2,3,4,5};
    int[] ocurrencias=new int[10];
    for(int i=0;i<a.Length;i++){
        ocurrencias[a[i]]++;
    }
    for(int i=0;i<ocurrencias.Length;i++){
        if(ocurrencias[i]==3){
            Console.WriteLine(i);
        }
    }
}
// 20. Imprime la suma de enteros recibidos pero ignorando los subconjuntos que empiecen por 6 y terminen en 7. Siempre habrá un 7 después de un 6.
static void ej19(){
    int[] a={1,2,3,4,5};
    int suma=0;
    bool ignorar=false;
    for(int i=0;i<a.Length;i++){
        if(a[i]==6){
            ignorar=true;
        }
        if(!ignorar){
            suma+=a[i];
        }
        if(a[i]==7){
            ignorar=false;
        }
    }
    Console.WriteLine("Suma: "+suma);
}
// 21. Imprime los enteros recibidos reorganizados de tal manera que después de un 3 haya un 4. Los treses no pueden cambiar de posición.
static void ej20(){
    int[] a={1,2,3,4,5};
    int[] b=new int[a.Length];
    int pos=0;
    for(int i=0;i<a.Length;i++){
        if(a[i]==3){
            b[pos++]=a[i];
            b[pos++]=4;
        }else{
            b[pos++]=a[i];
        }
    }
    for(int i=0;i<b.Length;i++){
        Console.WriteLine(b[i]);
    }
}
// 22. Siendo x, y y n enteros positivos para la ecuación (1/x) + (1/y) = (1/n), encuentra el número de soluciones dado un entero z tal que x < y <= z.
static void ej21(){
    int z=5;
    int soluciones=0;
    for(int x=1;x<z;x++){
        for(int y=x+1;y<=z;y++){
            if((1.0/x)+(1.0/y)==(1.0/z)){
                soluciones++;
            }
        }
    }
    Console.WriteLine("Soluciones: "+soluciones);
}