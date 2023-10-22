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

// 5. Crea un array/lista con cinco elementos e inserta en el primer índice, tercero y último tres números. Por último, imprime de nuevo el array, o lista,.

// 6. Convierte un array/lista de números que sean de tipo cadena de caracteres a tipo número real.

// 7. Crea un array/lista e imprime en pantalla el número de elementos.

// 8. Crea un array/lista de números de tipo número real, ordénalos e imprime dicho array, o lista, por pantalla.

// 9. Crea un array/lista de números de tipo cadena de caracteres, ordénalos e imprime dicho array, o lista, por pantalla.

// 10. Crea un array/lista de números de tipo número real, ordénalos al revés e imprime dicho array, o lista, por pantalla.