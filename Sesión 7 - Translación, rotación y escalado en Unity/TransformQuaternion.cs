using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformQuaternion : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        /*

        Ejercicio 1. Crea en Unity un proyecto 2D, crea este sprite, asígnale este script y explica la clase Transform.

        La clase Transform en Unity es esencial para gestionar la posición, rotación y escala de objetos en el espacio 
        tridimensional. Cada objeto en Unity tiene un componente Transform que almacena estas propiedades. Puedes acceder 
        a la posición, rotación y escala a través de las propiedades position, rotation y localScale. Además, cuenta con 
        métodos como Translate para mover el objeto, Rotate para rotarlo, y LookAt para orientarlo hacia un punto específico. 
        Estos métodos facilitan la manipulación de la transformación de objetos en la escena.

        Ejercicio 2. Explica qué es traslación, rotación y escalado y por qué es tan importante en los videojuegos.

        Las transformaciones en videojuegos, como traslación (movimiento), rotación y escalado, son procesos fundamentales 
        para manipular objetos en el espacio tridimensional. Estas operaciones permiten la interactividad, animación, dinámica 
        del juego y creación de entornos visuales inmersivos. Son esenciales para adaptar objetos a la respuesta del jugador, 
        facilitar animaciones realistas, mejorar la jugabilidad y optimizar el rendimiento del juego. En resumen, las 
        transformaciones son herramientas clave para la creación de experiencias de juego dinámicas y visualmente atractivas.

        Ejercicio 3. Describe ángulos de Euler y el problema del bloqueo del cardán cuando se usan ángulos de Euler.

        Los ángulos de Euler son una forma de representar la orientación espacial utilizando tres ángulos para describir la 
        rotación alrededor de ejes perpendiculares. Sin embargo, su uso puede llevar al problema del "bloqueo de cardán", 
        especialmente el gimbal lock, donde ciertos valores pueden resultar en comportamientos inesperados debido a la pérdida 
        de un grado de libertad. Este problema lleva a limitaciones en la representación suave de rotaciones. Para evitar el 
        gimbal lock, se prefieren otras representaciones como cuaterniones, que no sufren de esta singularidad y son más adecuados 
        para la interpolación suave de rotaciones en entornos como los videojuegos. En Unity, aunque los ángulos de Euler son 
        accesibles, internamente se utilizan cuaterniones para representar las rotaciones y evitar estos problemas.

        Ejercicio 4. Define cuaternión y di todas las ventajas de usar cuaterniones para rotar en vez de ángulos de Euler.

        Los cuaterniones son una extensión matemática de los números complejos con cuatro componentes. Al representar rotaciones en 
        comparación con ángulos de Euler, ofrecen ventajas significativas. Evitan el gimbal lock, permiten interpolación suave entre 
        rotaciones, son computacionalmente más eficientes, ocupan menos memoria y son más estables en simulaciones físicas. Su uso se 
        prefiere en programación de videojuegos y gráficos 3D debido a estas ventajas, mejorando la precisión y eficiencia en la 
        manipulación de rotaciones.

        Ejercicio 5. Di las diferencias entre Transform.position y Transform.Translate y translada de ambas maneras.

        En Unity, Transform.position se utiliza para establecer la posición absoluta de un objeto en el espacio tridimensional, 
        mientras que Transform.Translate se utiliza para aplicar un desplazamiento relativo al objeto en relación con su posición 
        actual. Transform.position establece la posición de manera absoluta, mientras que Transform.Translate realiza un 
        desplazamiento relativo. Por ejemplo, Transform.position colocaría un objeto en una ubicación específica, mientras que 
        Transform.Translate movería el objeto desde su posición actual en una cierta dirección.

        Ejercicio 6. Di las diferencias entre Transform.rotation y Transform.Rotate y rota de ambas maneras.

        En Unity, Transform.rotation es una propiedad que representa la rotación absoluta de un objeto mediante un cuaternión. 
        Se utiliza para establecer la orientación exacta del objeto en el espacio. Por otro lado, Transform.Rotate es un método 
        que aplica rotaciones relativas al objeto en relación con su orientación actual. Transform.rotation establece la rotación 
        absoluta utilizando un cuaternión, mientras que Transform.Rotate realiza rotaciones relativas basadas en ángulos específicos.

        */

        Ejercicio5();
        Ejercicio6();
    }

    void Ejercicio5()
    {
        // pero si ya está hecho xD

        // Mueve el objeto 1 unidad/segundo hacia arriba (eje y).
        // transform.Translate(Vector3.up * Time.deltaTime);

        // Mueve el objeto 1 unidad/segundo hacia abajo (eje y).
        // transform.Translate(Vector3.down * Time.deltaTime);

        // Mueve el objeto 1 unidad/segundo hacia la izquierda (eje x).
        // transform.Translate(Vector3.left * Time.deltaTime);

        // Mueve el objeto 1 unidad/segundo hacia la derecha (eje x).
        // transform.Translate(Vector3.right * Time.deltaTime);

        // Mueve el objeto 1 unidad/segundo hacia arriba (eje y).
        // transform.position = transform.position + new Vector3(0, Time.deltaTime, 0);

        // Mueve el objeto 1 unidad/segundo hacia abajo (eje y).
        // transform.position = transform.position + new Vector3(0, -Time.deltaTime, 0);

        // Mueve el objeto 1 unidad/segundo hacia la izquierda (eje x).
        // transform.position = transform.position + new Vector3(-Time.deltaTime, 0, 0);

        // Mueve el objeto 1 unidad/segundo hacia la derecha (eje x).
        // transform.position = transform.position + new Vector3(Time.deltaTime, 0, 0);
    }

    void Ejercicio6()
    {

        // Rota el objeto 90 grados/segundo hacia arriba (eje y).
        // transform.Rotate(Vector3.up * Time.deltaTime * 90);

        // Rota el objeto 90 grados/segundo hacia abajo (eje y).
        // transform.Rotate(Vector3.down * Time.deltaTime * 90);

        // Rota el objeto 90 grados/segundo hacia la izquierda (eje x).
        // transform.Rotate(Vector3.left * Time.deltaTime * 90);

        // Rota el objeto 90 grados/segundo hacia la derecha (eje x).
        // transform.Rotate(Vector3.right * Time.deltaTime * 90);

        // Rota el objeto 90 grados/segundo hacia arriba (eje y).
        // transform.rotation = transform.rotation * Quaternion.Euler(0, Time.deltaTime * 90, 0);

        // Rota el objeto 90 grados/segundo hacia abajo (eje y).
        // transform.rotation = transform.rotation * Quaternion.Euler(0, -Time.deltaTime * 90, 0);

        // Rota el objeto 90 grados/segundo hacia la izquierda (eje x).
        // transform.rotation = transform.rotation * Quaternion.Euler(-Time.deltaTime * 90, 0, 0);

        // Rota el objeto 90 grados/segundo hacia la derecha (eje x).
        // transform.rotation = transform.rotation * Quaternion.Euler(Time.deltaTime * 90, 0, 0);
    }

}
