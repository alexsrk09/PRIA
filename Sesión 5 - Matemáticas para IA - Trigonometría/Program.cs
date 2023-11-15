// 1. Convierte π/6, π/4, π/3, π/2, 2π/3, 3π/4, π, 3π/2 y 2π radianes a grados (fórmula) en C# (Math.PI).
static void ej0(double radianes){
    double grados=radianes*180/Math.PI;
    Console.WriteLine("{0} radianes son {1} grados",radianes,grados);

}
// 2. Convierte 30°, 45°, 60°, 90°, 120°, 135°, 180°, 270° y 360° a radianes (fórmula) en C# (Math.PI).
static void ej1(double grados){
    double radianes=grados*Math.PI/180;
    Console.WriteLine("{0} grados son {1} radianes",grados,radianes);
}
// 3. Calcula el seno y el coseno desde 0° hasta 360° (0°, 1°, 2°, 3°...) en C# mediante un bucle.
static void ej2(){
    for(int i=0;i<=360;i++){
        double radianes=i*Math.PI/180;
        Console.WriteLine("El seno de {0} grados es {1}",i,Math.Sin(radianes));
        Console.WriteLine("El coseno de {0} grados es {1}",i,Math.Cos(radianes));
    }
}
// 4. Haz cinco ejemplos en C# de las funciones tangente, arcoseno, arcocoseno y arcotangente.
static void ej3(){
    Console.WriteLine("El arcoseno de 0.5 es {0}",Math.Asin(0.5));
    Console.WriteLine("El arcocoseno de 0.5 es {0}",Math.Acos(0.5));
    Console.WriteLine("El arcotangente de 0.5 es {0}",Math.Atan(0.5));
    Console.WriteLine("La tangente de 0.5 es {0}",Math.Tan(0.5));
    Console.WriteLine("La tangente de 0.5 es {0}",Math.Tan(0.5));
}
// 5. Calcula el ángulo entre los vectores 2D a⃗(1, 1) y b⃗(-2, 0) y entre v⃗(1, 1) y w⃗(1, -1) en C#.
static void ej4(){
    Vector2 a=new Vector2(1,1);
    Vector2 b=new Vector2(-2,0);
    Vector2 v=new Vector2(1,1);
    Vector2 w=new Vector2(1,-1);
    Console.WriteLine("El angulo entre a y b es {0}",Math.Acos((a.x*b.x+a.y*b.y)/(Math.Sqrt(Math.Pow(a.x,2)+Math.Pow(a.y,2))*Math.Sqrt(Math.Pow(b.x,2)+Math.Pow(b.y,2)))));
    Console.WriteLine("El angulo entre v y w es {0}",Math.Acos((v.x*w.x+v.y*w.y)/(Math.Sqrt(Math.Pow(v.x,2)+Math.Pow(v.y,2))*Math.Sqrt(Math.Pow(w.x,2)+Math.Pow(w.y,2)))));
}
// 6. Calcula el ángulo entre los vectores 3D a⃗(9, 2, 7) y b⃗(4, 8, 10) y entre v⃗(-3, 5, -1) y w⃗(4, -1, 6) en C#.
static void ej5(){
    Vector3 a=new Vector3(9,2,7);
    Vector3 b=new Vector3(4,8,10);
    Vector3 v=new Vector3(-3,5,-1);
    Vector3 w=new Vector3(4,-1,6);
    Console.WriteLine("El angulo entre a y b es {0}",Math.Acos((a.x*b.x+a.y*b.y+a.z*b.z)/(Math.Sqrt(Math.Pow(a.x,2)+Math.Pow(a.y,2)+Math.Pow(a.z,2))*Math.Sqrt(Math.Pow(b.x,2)+Math.Pow(b.y,2)+Math.Pow(b.z,2)))));
    Console.WriteLine("El angulo entre v y w es {0}",Math.Acos((v.x*w.x+v.y*w.y+v.z*w.z)/(Math.Sqrt(Math.Pow(v.x,2)+Math.Pow(v.y,2)+Math.Pow(v.z,2))*Math.Sqrt(Math.Pow(w.x,2)+Math.Pow(w.y,2)+Math.Pow(w.z,2)))));
}