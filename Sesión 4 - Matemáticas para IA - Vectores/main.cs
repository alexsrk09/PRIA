// 1. Ve este vídeo de inicio a fin y explica en un comentario de C# qué es un vector y sus propiedades.

// Un vector es un objeto matemático que tiene magnitud y dirección. Puedes pensar en él como una flecha en un espacio tridimensional, donde la longitud de la flecha representa la magnitud del vector y la dirección de la flecha indica hacia dónde apunta.
// Las propiedades clave de un vector incluyen:
// Magnitud (o norma): Es la longitud del vector y se denota comúnmente por |v| o "||v||". Se calcula utilizando el teorema de Pitágoras en un sistema de coordenadas cartesianas.
// Dirección: Indica hacia dónde apunta el vector en el espacio. Puede describirse utilizando ángulos o mediante la proporción de sus componentes en un sistema de coordenadas.

// 2. Calcula en C# las coordenadas de un vector que va del punto A(1, 4) a B(6, 6); hazlo también de B a A.
static void ej0(){
    int[] a={1,4};
    int[] b={6,6};
    int[] c={b[0]-a[0],b[1]-a[1]};
    int[] d={a[0]-b[0],a[1]-b[1]};
    Console.WriteLine("El vector AB es: ({0},{1})",c[0],c[1]);
    Console.WriteLine("El vector BA es: ({0},{1})",d[0],d[1]);

}
// 3. Define los vectores con coordenadas a⃗ (3, 2), b⃗ (1, 1) y c⃗ (4, 5) con la estructura Vector2 de C#.
static void ej1(){
    Vector2 a=new Vector2(3,2);
    Vector2 b=new Vector2(1,1);
    Vector2 c=new Vector2(4,5);
    Console.WriteLine("El vector a es: ({0},{1})",a.x,a.y);
    Console.WriteLine("El vector b es: ({0},{1})",b.x,b.y);
    Console.WriteLine("El vector c es: ({0},{1})",c.x,c.y);
}
// 4. Ve este vídeo de inicio a fin y programa con Vector2 de C# todos los ejemplos que aparecen en él.
// modulo de 2 vectores con vector 2
static void ej2_1(){
    Vector2 a=new Vector2(3,2);
    Vector2 b=new Vector2(1,1);
    Console.WriteLine("El modulo de a es: {0}",Math.Sqrt(Math.Pow(a.x,2)+Math.Pow(a.y,2)));
    Console.WriteLine("El modulo de b es: {0}",Math.Sqrt(Math.Pow(b.x,2)+Math.Pow(b.y,2)));
}
// calculo de la suma de 2 vectores con vector 2
static void ej2_2(){
    Vector2 a=new Vector2(3,2);
    Vector2 b=new Vector2(1,1);
    Console.WriteLine("La suma de a y b es: ({0},{1})",a.x+b.x,a.y+b.y);
}
// 5. Dado a(5, -2, 4) y b(-1, -7, 3), calcula en C# con Vector3: |a|, |b|, a+b, a-b, 2·a, a·b, a â, ^b y si ab.
// |a|
static void ej3_1(){
    Vector3 a=new Vector3(5,-2,4);
    Console.WriteLine("El modulo de a es: {0}",Math.Sqrt(Math.Pow(a.x,2)+Math.Pow(a.y,2)+Math.Pow(a.z,2)));
}
// |b|
static void ej3_2(){
    Vector3 b=new Vector3(-1,-7,3);
    Console.WriteLine("El modulo de b es: {0}",Math.Sqrt(Math.Pow(b.x,2)+Math.Pow(b.y,2)+Math.Pow(b.z,2)));
}
// a+b
static void ej3_3(){
    Vector3 a=new Vector3(5,-2,4);
    Vector3 b=new Vector3(-1,-7,3);
    Console.WriteLine("La suma de a y b es: ({0},{1},{2})",a.x+b.x,a.y+b.y,a.z+b.z);
}
// a-b
static void ej3_4(){
    Vector3 a=new Vector3(5,-2,4);
    Vector3 b=new Vector3(-1,-7,3);
    Console.WriteLine("La resta de a y b es: ({0},{1},{2})",a.x-b.x,a.y-b.y,a.z-b.z);
}
// 2·a
static void ej3_5(){
    Vector3 a=new Vector3(5,-2,4);
    Console.WriteLine("El doble de a es: ({0},{1},{2})",2*a.x,2*a.y,2*a.z);
}
// a·b
static void ej3_6(){
    Vector3 a=new Vector3(5,-2,4);
    Vector3 b=new Vector3(-1,-7,3);
    Console.WriteLine("El producto escalar de a y b es: {0}",a.x*b.x+a.y*b.y+a.z*b.z);
}

