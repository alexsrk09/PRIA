// 1. Crea una clase llamada Punto con dos propiedades/atributos denominados x e y, con constructor y con cuatro métodos 
// (getter y setter), uno para obtener x, otro para obtener y, otro para modificar x y otro método para modificar y. Crea 
// 3 instancias/objetos de la clase Punto y ejecuta en ellos los cuatro métodos creados.
void ej0()
{
    Punto punto1 = new Punto(1, 2);
    Punto punto2 = new Punto(3, 4);
    Punto punto3 = new Punto(5, 6);

    Console.WriteLine("Punto 1: " + punto1.getX() + ", " + punto1.getY());
    Console.WriteLine("Punto 2: " + punto2.getX() + ", " + punto2.getY());
    Console.WriteLine("Punto 3: " + punto3.getX() + ", " + punto3.getY());

    punto1.setX(10);
    punto1.setY(20);
    punto2.setX(30);
    punto2.setY(40);
    punto3.setX(50);
    punto3.setY(60);

    Console.WriteLine("Punto 1: " + punto1.getX() + ", " + punto1.getY());
    Console.WriteLine("Punto 2: " + punto2.getX() + ", " + punto2.getY());
    Console.WriteLine("Punto 3: " + punto3.getX() + ", " + punto3.getY());
}


// 2. Crea una clase llamada Linea con cuatro propiedades/atributos denominados x1, x2, y1 e y2, con constructor y 
// con un método que obtenga el punto medio del segmento usando dichas propiedades/atributos. Crea 3 instancias/objetos 
// de la clase Linea y ejecuta en ellos el método creado.

void ej1()
{
    Linea linea1 = new Linea(1, 2, 3, 4);
    Linea linea2 = new Linea(5, 6, 7, 8);
    Linea linea3 = new Linea(9, 10, 11, 12);

    Console.WriteLine("Linea 1: " + linea1.getX1() + ", " + linea1.getY1() + ", " + linea1.getX2() + ", " + linea1.getY2());
    Console.WriteLine("Linea 2: " + linea2.getX1() + ", " + linea2.getY1() + ", " + linea2.getX2() + ", " + linea2.getY2());
    Console.WriteLine("Linea 3: " + linea3.getX1() + ", " + linea3.getY1() + ", " + linea3.getX2() + ", " + linea3.getY2());

    Console.WriteLine("Punto medio de la linea 1: " + linea1.getPuntoMedio());
    Console.WriteLine("Punto medio de la linea 2: " + linea2.getPuntoMedio());
    Console.WriteLine("Punto medio de la linea 3: " + linea3.getPuntoMedio());
}


// 3. Crea una clase llamada Rectangulo con dos propiedades/atributos denominados longitud y ancho, con constructor y 
// con un método que calcule el area del rectángulo usando dichas propiedades/atributos. Crea 3 instancias/objetos de la clase 
// Rectangulo y ejecuta en ellos el método creado.

void ej2()
{
    Rectangulo rectangulo1 = new Rectangulo(1, 2, new Punto(1, 2));
    Rectangulo rectangulo2 = new Rectangulo(3, 4, new Punto(3, 4));
    Rectangulo rectangulo3 = new Rectangulo(5, 6, new Punto(5, 6));

    Console.WriteLine("Rectangulo 1: " + rectangulo1.getLongitud() + ", " + rectangulo1.getAncho());
    Console.WriteLine("Rectangulo 2: " + rectangulo2.getLongitud() + ", " + rectangulo2.getAncho());
    Console.WriteLine("Rectangulo 3: " + rectangulo3.getLongitud() + ", " + rectangulo3.getAncho());

    Console.WriteLine("Area del rectangulo 1: " + rectangulo1.area());
    Console.WriteLine("Area del rectangulo 2: " + rectangulo2.area());
    Console.WriteLine("Area del rectangulo 3: " + rectangulo3.area());
}
// 4. Crea una clase llamada Circulo con una propiedad/atributo denominado radio, con constructor y con dos métodos que calculen el 
// area del círculo y la circunferencia del círculo usando dichas propiedades/atributos. Crea 3 instancias/objetos de la clase Circulo 
// y ejecuta en ellos los dos métodos creados.

void ej3()
{
    Circulo circulo1 = new Circulo(1, new Punto(1, 2));
    Circulo circulo2 = new Circulo(2, new Punto(3, 4));
    Circulo circulo3 = new Circulo(3, new Punto(5, 6));

    Console.WriteLine("Circulo 1: " + circulo1.getRadio());
    Console.WriteLine("Circulo 2: " + circulo2.getRadio());
    Console.WriteLine("Circulo 3: " + circulo3.getRadio());

    Console.WriteLine("Area del circulo 1: " + circulo1.area());
    Console.WriteLine("Area del circulo 2: " + circulo2.area());
    Console.WriteLine("Area del circulo 3: " + circulo3.area());

    Console.WriteLine("Circunferencia del circulo 1: " + circulo1.getCircunferencia());
    Console.WriteLine("Circunferencia del circulo 2: " + circulo2.getCircunferencia());
    Console.WriteLine("Circunferencia del circulo 3: " + circulo3.getCircunferencia());
}
// 5. Crea una clase llamada Estudiante con dos propiedades/atributos denominados nombre y notas (array/lista), con constructor y 
// con métodos que obtenga el nombre, modifique el nombre, obtenga las notas, modifique las notas y, por último, que obtenga la media 
// de esas notas y las muestre. Crea 3 instancias/objetos de la clase Estudiante y ejecuta en ellos el método creado.
 
void ej4(){
    Estudiante estudiante1 = new Estudiante("Estudiante 1", new List<int> { 1, 2, 3, 4, 5 });
    Estudiante estudiante2 = new Estudiante("Estudiante 2", new List<int> { 6, 7, 8, 9, 10 });
    estudiante1.setNotas(new List<int> { 10, 9, 8, 7, 6 });
    estudiante2.setNotas(new List<int> { 5, 4, 3, 2, 1 });
    Console.WriteLine("Estudiante 1: " + estudiante1.getNombre() + ", " + estudiante1.getNotas() + ", " + estudiante1.getMedia());
    Console.WriteLine("Estudiante 2: " + estudiante2.getNombre() + ", " + estudiante2.getNotas() + ", " + estudiante2.getMedia());
}

// 6. Crea una función que reciba dos parámetros de entrada de tipo clase Punto (realizado en ejercicio 01) y que devuelva la distancia euclídea entre esos dos puntos. 
// Ejecuta 3 llamadas de ejemplo de la función creada.

void ej5()
{
    Punto punto1 = new Punto(1, 2);
    Punto punto2 = new Punto(3, 4);
    Punto punto3 = new Punto(5, 6);

    Console.WriteLine("Distancia euclidea entre el punto 1 y el punto 2: " + punto1.distanciaEuclidea(punto2));
    Console.WriteLine("Distancia euclidea entre el punto 2 y el punto 3: " + punto2.distanciaEuclidea(punto3));
    Console.WriteLine("Distancia euclidea entre el punto 3 y el punto 1: " + punto3.distanciaEuclidea(punto1));
}

// 7. Crea una clase llamada Linea2D con dos propiedades/atributos denominados p1 y p2 de tipo clase Punto (realizado en ejercicio 01) 
// y con dos métodos, uno que obtenga el punto medio del segmento y otro que obtenga la distancia euclídea, ambos usando dichas 
// propiedades/atributos. Crea 3 instancias/objetos de la clase Linea2D y ejecuta en ellos los dos métodos creado.

void ej6()
{
    Linea2D linea1 = new Linea2D(new Punto(1, 2), new Punto(3, 4));
    Linea2D linea2 = new Linea2D(new Punto(5, 6), new Punto(7, 8));
    Linea2D linea3 = new Linea2D(new Punto(9, 10), new Punto(11, 12));

    Console.WriteLine("Linea 1: " + linea1.getP1() + ", " + linea1.getP2());
    Console.WriteLine("Linea 2: " + linea2.getP1() + ", " + linea2.getP2());
    Console.WriteLine("Linea 3: " + linea3.getP1() + ", " + linea3.getP2());

    Console.WriteLine("Punto medio de la linea 1: " + linea1.getPuntoMedio());
    Console.WriteLine("Punto medio de la linea 2: " + linea2.getPuntoMedio());
    Console.WriteLine("Punto medio de la linea 3: " + linea3.getPuntoMedio());

    Console.WriteLine("Distancia euclidea de la linea 1: " + linea1.distanciaEuclidea());
    Console.WriteLine("Distancia euclidea de la linea 2: " + linea2.distanciaEuclidea());
    Console.WriteLine("Distancia euclidea de la linea 3: " + linea3.distanciaEuclidea());
}

// 8. Crea una clase llamada Forma con una propiedad/atributo denominada centro de tipo clase Punto y un método que se 
// llame area y que devuelva un número, por ejemplo 0. A continuación, crea dos clases llamadas Rectangulo y Circulo 7
// (realizados en ejercicios 03 y 04) que hereden de la clase Forma ya creada. Crea 3 instancias/objetos de las clases 
// Rectangulo, Circulo, de la clase que hereda Forma y ejecuta sus métodos.

void ej7()
{
    Forma forma1 = new Forma(new Punto(1, 2));
    Circulo forma2 = new Circulo(3 , new Punto(4, 5));
    Rectangulo forma3 = new Rectangulo(4, 5 , new Punto(6, 7));
    Console.WriteLine("Forma 1: " + forma1.getCentro().getX() + ", " + forma1.getCentro().getY());
    Console.WriteLine("Forma 2: " + forma2.getCentro().getX() + ", " + forma2.getCentro().getY());
    Console.WriteLine("Forma 3: " + forma3.getCentro().getX() + ", " + forma3.getCentro().getY());

    Console.WriteLine("Area de la forma 1: " + forma1.area());
    Console.WriteLine("Area de la forma 2: " + forma2.area());
    Console.WriteLine("Area de la forma 3: " + forma3.area());
}
// 9. Crea una función que reciba un parámetro de entrada de tipo array/lista, con identificador grupos, de tamaño 3 cuyos 
// elementos sean de tipo array/lista de clase Estudiante (realizado en ejercicio 05). La función tiene que devolver el índice 
// del array/lista grupos cuyo promedio de notas del grupo de estudiantes sea el más alto. Ejecuta 1 llamada de ejemplo de la 
// función creada.

// Por ejemplo, hay tres grupos de Bachillerato con 25 alumnos cada uno. Cada grupo será un array/lista de 25 estudiantes 
// (25 objetos/instancias de la clase Estudiante) que se añadirá al array/lista grupos inicialmente vacío. Cada estudiante 
// tiene su media final, pero lo que queremos es la media de todo ese grupo de estudiantes y compararlos con los otros grupos. 
// Lo que buscamos finalmente es conocer qué grupo de bachillerato tiene los alumnos con mejor promedio de nota. Si se va a usar 
// este ejemplo en el ejercicio, no es necesario tantos alumnos (5 por grupo sería más que suficiente).

void ej8()
{
    List<Estudiante> grupo1 = new List<Estudiante>();
    List<Estudiante> grupo2 = new List<Estudiante>();
    List<Estudiante> grupo3 = new List<Estudiante>();

    grupo1.Add(new Estudiante("Estudiante 1", new List<int> { 1, 2, 3, 4, 5 }));
    grupo1.Add(new Estudiante("Estudiante 2", new List<int> { 6, 7, 8, 9, 10 }));
    grupo1.Add(new Estudiante("Estudiante 3", new List<int> { 10, 9, 8, 7, 6 }));
    grupo1.Add(new Estudiante("Estudiante 4", new List<int> { 5, 4, 3, 2, 1 }));
    grupo1.Add(new Estudiante("Estudiante 5", new List<int> { 1, 2, 3, 4, 5 }));

    grupo2.Add(new Estudiante("Estudiante 6", new List<int> { 1, 2, 3, 4, 5 }));
    grupo2.Add(new Estudiante("Estudiante 7", new List<int> { 6, 7, 8, 9, 10 }));
    grupo2.Add(new Estudiante("Estudiante 8", new List<int> { 10, 9, 8, 7, 6 }));
    grupo2.Add(new Estudiante("Estudiante 9", new List<int> { 5, 4, 3, 2, 1 }));
    grupo2.Add(new Estudiante("Estudiante 10", new List<int> { 1, 2, 3, 4, 5 }));

    grupo3.Add(new Estudiante("Estudiante 11", new List<int> { 1, 2, 3, 4, 5 }));
    grupo3.Add(new Estudiante("Estudiante 12", new List<int> { 6, 7, 8, 9, 10 }));
    grupo3.Add(new Estudiante("Estudiante 13", new List<int> { 10, 9, 8, 10, 6 }));
    grupo3.Add(new Estudiante("Estudiante 14", new List<int> { 5, 10, 3, 10, 10 }));
    grupo3.Add(new Estudiante("Estudiante 15", new List<int> { 10, 10, 10, 10, 5 }));

    List<List<Estudiante>> grupos = new List<List<Estudiante>>();
    grupos.Add(grupo1);
    grupos.Add(grupo2);
    grupos.Add(grupo3);

    Console.WriteLine("El grupo con mejor media es el grupo " + getMejorGrupo(grupos));
}

int getMejorGrupo(List<List<Estudiante>> grupos)
{
    float mejorMedia = 0;
    int mejorGrupo = 0;

    for (int i = 0; i < grupos.Count; i++)
    {
        float media = 0;

        foreach (Estudiante estudiante in grupos[i])
        {
            media += estudiante.getMedia();
        }

        media /= grupos[i].Count;

        if (media > mejorMedia)
        {
            mejorMedia = media;
            mejorGrupo = i;
        }
    }

    return mejorGrupo;
}

// 10. Crea una clase C que herede de una clase B y que la clase B herede de A. La clase C heredará todos 
// los métodos y atributos de B y B de A. Como mínimo, una función de A, de B y de C tienen que tener el 
// mismo nombre pero que hagan cosas distintas. Crea 3 instancias/objetos de las clases A, B y C y ejecuta 
// todos los métodos que hayas creado.

void ej9()
{
    C c = new C();
    B b = new B();
    A a = new A();

    c.metodo();
    b.metodo();
    a.metodo();
}
// CLASES

// 1 y 6.
class Punto
{
    private int x;
    private int y;

    public Punto(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public int getX()
    {
        return x;
    }

    public int getY()
    {
        return y;
    }

    public void setX(int x)
    {
        this.x = x;
    }

    public void setY(int y)
    {
        this.y = y;
    }

    public float distanciaEuclidea(Punto punto)
    {
        return (float)Math.Sqrt(Math.Pow(punto.getX() - x, 2) + Math.Pow(punto.getY() - y, 2));
    }
}

// 8.
class Forma
{
    private Punto centro;

    public Forma(Punto centro)
    {
        this.centro = centro;
    }

    public Punto getCentro()
    {
        return centro;
    }

    public float area()
    {
        return 0;
    }
}
// 2.
class Linea
{
    private int x1;
    private int y1;
    private int x2;
    private int y2;

    public Linea(int x1, int y1, int x2, int y2)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    public int getX1()
    {
        return x1;
    }

    public int getY1()
    {
        return y1;
    }

    public int getX2()
    {
        return x2;
    }

    public int getY2()
    {
        return y2;
    }

    public Punto getPuntoMedio()
    {
        return new Punto((x1 + x2) / 2, (y1 + y2) / 2);
    }
}
// 3.
class Rectangulo : Forma
{
    private int longitud;
    private int ancho;

    public Rectangulo(int longitud, int ancho, Punto punto) : base(punto)
    {
        this.longitud = longitud;
        this.ancho = ancho;
    }

    public int getLongitud()
    {
        return longitud;
    }

    public int getAncho()
    {
        return ancho;
    }

    public int area()
    {
        return longitud * ancho;
    }
}
// 4.
class Circulo : Forma
{
    private int radio;

    public Circulo(int radio, Punto punto) : base(punto)
    {
        this.radio = radio;
    }

    public int getRadio()
    {
        return radio;
    }

    public float area()
    {
        return (float)Math.PI * radio * radio;
    }

    public float getCircunferencia()
    {
        return (float)Math.PI * radio * 2;
    }
}

// 5.
class Estudiante
{
    private string nombre;
    private List<int> notas;

    public Estudiante(string nombre, List<int> notas)
    {
        this.nombre = nombre;
        this.notas = notas;
    }

    public string getNombre()
    {
        return nombre;
    }

    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public List<int> getNotas()
    {
        return notas;
    }

    public void setNotas(List<int> notas)
    {
        this.notas = notas;
    }

    public float getMedia()
    {
        float media = 0;

        foreach (int nota in notas)
        {
            media += nota;
        }

        return media / notas.Count;
    }
}

// 7.
class Linea2D
{
    private Punto p1;
    private Punto p2;

    public Linea2D(Punto p1, Punto p2)
    {
        this.p1 = p1;
        this.p2 = p2;
    }

    public Punto getP1()
    {
        return p1;
    }

    public Punto getP2()
    {
        return p2;
    }

    public Punto getPuntoMedio()
    {
        return new Punto((p1.getX() + p2.getX()) / 2, (p1.getY() + p2.getY()) / 2);
    }

    public float distanciaEuclidea()
    {
        return (float)Math.Sqrt(Math.Pow(p2.getX() - p1.getX(), 2) + Math.Pow(p2.getY() - p1.getY(), 2));
    }
}

// 10.
class A
{
    public void metodo()
    {
        Console.WriteLine("A");
    }
}

class B : A
{
    public void metodo()
    {
        Console.WriteLine("B");
    }
}

class C : B
{
    public void metodo()
    {
        Console.WriteLine("C");
    }
}
