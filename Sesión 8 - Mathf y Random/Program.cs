// 1. Calcula el valor absoluto de un número usando la función Mathf.Abs de Unity.
void ej0()
{
    int num = -5;
    Debug.Log(Mathf.Abs(num));
}
// 2. Calcula el máximo valor entre dos números usando la función Mathf.Max de Unity.
void ej1()
{
    int num1 = 5;
    int num2 = 10;
    Debug.Log(Mathf.Max(num1, num2));
}
// 3. Calcula el mínimo valor entre dos números usando la función Mathf.Min de Unity.
void ej2()
{
    int num1 = 5;
    int num2 = 10;
    Debug.Log(Mathf.Min(num1, num2));
}
// 4. Calcula la potencia de un número usando la función Mathf.Pow de Unity.
void ej3()
{
    int num = 5;
    int potencia = 2;
    Debug.Log(Mathf.Pow(num, potencia));
}
// 5. Calcula el logaritmo de un número con base 10, 2 y e usando Mathf.Log10 y Mathf.Log de Unity.
void ej4()
{
    int num = 5;
    Debug.Log(Mathf.Log10(num));
    Debug.Log(Mathf.Log(num, 2));
    Debug.Log(Mathf.Log(num));
}
// 6. Redondea un número al entero más cercano usando la función Mathf.Round de Unity.
void ej5()
{
    float num = 5.5f;
    Debug.Log(Mathf.Round(num));
}
// 7. Redondea un número al entero más bajo usando la función Mathf.Floor de Unity.
void ej6()
{
    float num = 5.5f;
    Debug.Log(Mathf.Floor(num));
}
// 8. Redondea un número al entero más alto usando la función Mathf.Ceil de Unity.
void ej7()
{
    float num = 5.5f;
    Debug.Log(Mathf.Ceil(num));
}
// 9. Ajuste un número a un rango específico usando la función Mathf.Clamp de Unity.
void ej8()
{
    float num = 5.5f;
    Debug.Log(Mathf.Clamp(num, 0, 10));
}
// 10. Ajusta un número entre 0 y 1 (ambos incluidos) usando la función Mathf.Clamp01 de Unity.
void ej9()
{
    float num = 5.5f;
    Debug.Log(Mathf.Clamp01(num));
}
// 11. Genera cien números aleatorios flotantes entre 0 y 1 (ambos incluidos) con Random.value de Unity.
void ej10()
{
    for (int i = 0; i < 100; i++)
    {
        Debug.Log(Random.value);
    }
}
// 12. Repite la actividad anterior pero con Random.Range de Unity.
void ej11()
{
    for (int i = 0; i < 100; i++)
    {
        Debug.Log(Random.Range(0, 1));
    }
}
// 13. Genera un número aleatorio flotante entre -1 y 5 con Random de Unity y muéstralo con 2 decimales.
void ej12()
{
    Debug.Log(Mathf.Round(Random.Range(-1, 5) * 100f) / 100f);
}
// 14. Genera veinte enteros aleatorios entre -10 y 100 (ambos incluidos) con la clase Random de Unity.
void ej13()
{
    for (int i = 0; i < 20; i++)
    {
        Debug.Log(Random.Range(-10, 100));
    }
}