using System;
using System.Numerics;

// ej 1: Define interpolación lineal (en adelante lerp), describe este ejemplo y ejecuta y explíca este código.

// La interpolación lineal (lerp) es un método que permite encontrar un valor intermedio entre dos valores dados, basándose en un 
// factor de ponderación (weight) que va de 0.0 a 1.0. Este factor indica la proporción de influencia que tienen los dos valores 
// extremos en el resultado final.

// En el código proporcionado, la función lerp toma tres parámetros:

// from: El valor inicial de la interpolación.
// to: El valor final de la interpolación.
// weight: Un valor en el rango de 0.0 a 1.0 que representa la cantidad de interpolación.

// La fórmula utilizada para la interpolación lineal es:
// result = from + ((to - from) * weight);

// Ahora, veamos el ejemplo proporcionado:
// En este ejemplo, se tienen dos valores iniciales valorInicial y valorFinal, que son 0 y 20, respectivamente. 
// Luego, se realiza la interpolación lineal utilizando la función lerp con tres pesos diferentes (0.5, 0.25 y 0.75) y se 
// almacenan los resultados en las variables valorInterpolado1, valorInterpolado2 y valorInterpolado3.

// 2.Calcula en C# tres valores intermedios mediante lerp (código) desde 0 hasta 10 (solución: 2.5, 5 y 7.5)

float lerp(float from, float to, float weight){
    return from + ((to - from) * weight);
}

void ej1(){
    float valorInicial = 0;
    float valorFinal = 10;
    float valorInterpolado1 = lerp(valorInicial, valorFinal, 0.5f);
    float valorInterpolado2 = lerp(valorInicial, valorFinal, 0.25f);
    float valorInterpolado3 = lerp(valorInicial, valorFinal, 0.75f);

    Console.WriteLine("Valor interpolado 1: " + valorInterpolado1);
    Console.WriteLine("Valor interpolado 2: " + valorInterpolado2);
    Console.WriteLine("Valor interpolado 3: " + valorInterpolado3);
}

// 3.Calcula en C# 100 valores intermedios mediante lerp (código) desde 0 hasta 80 mediante un bucle.

void ej2(){
    float valorInicial = 0;
    float valorFinal = 80;
    float valorInterpolado;

    for (int i = 0; i <= 100; i++){
        valorInterpolado = lerp(valorInicial, valorFinal, i / 100.0f);
        Console.WriteLine("Valor interpolado " + i + ": " + valorInterpolado);
    }
}

// 4.Calcula en C# 100 vectores intermedios mediante lerp (Vector2.Lerp) desde a⃗(-5, -20) hasta b⃗(10, 25).

void ej3(){
    Vector2 a = new Vector2(-5, -20);
    Vector2 b = new Vector2(10, 25);
    Vector2 vectorInterpolado;

    for (int i = 0; i <= 100; i++){
        vectorInterpolado = Vector2.Lerp(a, b, i / 100.0f);
        Console.WriteLine("Vector interpolado " + i + ": " + vectorInterpolado);
    }
}

//5. Calcula en C# 100 vectores intermedios mediante lerp (Vector3.Lerp) desde a⃗(1, 3, 2) hasta b⃗(8, 10, 9).

void ej4(){
    Vector3 a = new Vector3(1, 3, 2);
    Vector3 b = new Vector3(8, 10, 9);
    Vector3 vectorInterpolado;

    for (int i = 0; i <= 100; i++){
        vectorInterpolado = Vector3.Lerp(a, b, i / 100.0f);
        Console.WriteLine("Vector interpolado " + i + ": " + vectorInterpolado);
    }
}


