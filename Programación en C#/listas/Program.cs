using System.Linq.Expressions;

// 1. Crea un array o una lista con cinco elementos e imprime en pantalla el primer, tercer y último elemento.
static void ej0(){
    int[] vector={1,2,3,4,5};
    Console.WriteLine(vector[0]+" "+vector[2]+" "+vector[4]);
}
// 2. Crea un array o una lista con cinco elementos de tipo número real y suma todos sus elementos e imprime el resultado por pantalla.
static void ej1(){
    float[] vector={1.2f,2.3f,3.4f,4.5f,5.6f};
    float suma=0;
    for(int i=0;i<vector.Length;i++){
        suma+=vector[i];
    }
    Console.WriteLine(suma);
}
// 3. Crea un array/lista con cinco elementos de tipo número real y multiplica todos sus elementos e imprime el resultado por pantalla.
static void ej2(){
    float[] vector={1.2f,2.3f,3.4f,4.5f,5.6f};
    float suma=1;
    for(int i=0;i<vector.Length;i++){
        suma*=vector[i];
    }
    Console.WriteLine(suma);
}
// 4. Crea un array/lista con cinco elementos y elimina el primer, tercer y último elemento. Por último, imprime de nuevo el array, o lista,.
static void ej3(){
    List<int> vector=new List<int>{1,2,3,4,5};
    vector.RemoveAt(0);
    vector.RemoveAt(1);
    vector.RemoveAt(2);
    foreach(int i in vector){
        Console.WriteLine(i);
    }
}

// 5. Crea un array/lista con cinco elementos e inserta en el primer índice, tercero y último tres números. Por último, imprime de nuevo el array, o lista,.
static void ej4(){
    List<int> vector=new List<int>{1,2,3,4,5};
    vector.Insert(0,6);
    vector.Insert(2,7);
    vector.Insert(4,8);
    foreach(int i in vector){
        Console.WriteLine(i);
    }
}

// 6. Convierte un array/lista de números que sean de tipo cadena de caracteres a tipo número real.
static void ej5(){
    List<string> vector=new List<string>{"1","2","3","4","5"};
    List<float> vector2=new List<float>();
    foreach(string i in vector){
        vector2.Add(float.Parse(i));
    }
    foreach(float i in vector2){
        Console.WriteLine(i);
    }
}

// 7. Crea un array/lista e imprime en pantalla el número de elementos.
static void ej6(){
    List<int> vector=new List<int>{1,2,3,4,5};
    Console.WriteLine(vector.Count);
}

// 8. Crea un array/lista de números de tipo número real, ordénalos e imprime dicho array, o lista, por pantalla.
static void ej7(){
    List<float> vector=new List<float>{1.2f,2.3f,3.4f,4.5f,5.6f};
    vector.Sort();
    foreach(float i in vector){
        Console.WriteLine(i);
    }
}

// 9. Crea un array/lista de números de tipo cadena de caracteres, ordénalos e imprime dicho array, o lista, por pantalla.
static void ej8(){
    List<string> vector=new List<string>{"1","2","3","4","5"};
    vector.Sort();
    foreach(string i in vector){
        Console.WriteLine(i);
    }
}

// 10. Crea un array/lista de números de tipo número real, ordénalos al revés e imprime dicho array, o lista, por pantalla.
static void ej9(){
    List<float> vector=new List<float>{1.2f,2.3f,3.4f,4.5f,5.6f};
    vector.Reverse();
    foreach(float i in vector){
        Console.WriteLine(i);
    }
}
// 12. En una matriz 3x3 de enteros, muestra la suma más alta de los números de una fila.
static void ej10(){
    int[,] matriz=new int[3,3]{{1,2,3},{4,5,6},{7,8,9}};
    int suma=0;
    int suma2=0;
    int suma3=0;
    for(int i=0;i<3;i++){
        suma+=matriz[0,i];
        suma2+=matriz[1,i];
        suma3+=matriz[2,i];
    }
    if(suma>suma2 && suma>suma3){
        Console.WriteLine(suma);
    }else if(suma2>suma && suma2>suma3){
        Console.WriteLine(suma2);
    }else{
        Console.WriteLine(suma3);
    }
}
// 13. Muestra la fila de una matriz 3x3 de enteros cuya suma de números sea la más alta.
static void ej11(){
    int[,] matriz=new int[3,3]{{1,2,3},{4,5,6},{7,8,9}};
    int suma=0;
    int suma2=0;
    int suma3=0;
    for(int i=0;i<3;i++){
        suma+=matriz[0,i];
        suma2+=matriz[1,i];
        suma3+=matriz[2,i];
    }
    if(suma>suma2 && suma>suma3){
        for(int i=0;i<3;i++){
            Console.WriteLine(matriz[0,i]);
        }
    }else if(suma2>suma && suma2>suma3){
        for(int i=0;i<3;i++){
            Console.WriteLine(matriz[1,i]);
        }
    }else{
        for(int i=0;i<3;i++){
            Console.WriteLine(matriz[2,i]);
        }
    }
}
// 14. Dado un número almacenado en una lista con más de 10 dígitos, suma los 3 primeros dígitos y los 3 últimos dígitos.
static void ej12(){
    List<int> vector=new List<int>{1,2,3,4,5,6,7,8,9,10};
    int suma=0;
    int suma2=0;
    for(int i=0;i<3;i++){
        suma+=vector[i];
        suma2+=vector[vector.Count-1-i];
    }
    Console.WriteLine(suma+suma2);
}
ej12();
// 15. Dada una serie de palabras, ordénalas alfabéticamente.
static void ej13(){
    List<string> vector=new List<string>{"hola","adios","buenas","tardes"};
    vector.Sort();
    foreach(string i in vector){
        Console.WriteLine(i);
    }
}
// 16. Dada una serie de palabras, ordénalas alfabéticamente al revés (de z a a). A continuación, muestra el resultado final exceptuando la primera palabra y las tres últimas palabras.
static void ej14(){
    List<string> vector=new List<string>{"hola","adios","buenas","tardes"};
    vector.Sort();
    vector.Reverse();
    for(int i=1;i<vector.Count-3;i++){
        Console.WriteLine(vector[i]);
    }
}
// 17. Dada una lista impar de enteros ordenados, muestra la mediana.
static void ej15(){
    List<int> vector=new List<int>{1,2,3,4,5,6,7,8,9};
    Console.WriteLine(vector[vector.Count/2]);
}