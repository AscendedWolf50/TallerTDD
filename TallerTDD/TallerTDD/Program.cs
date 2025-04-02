using System;
using System.Numerics;
using TallerBT.BT;

class Program
{
    static void Main(string[] args)
    {
        Agent agent = new Agent(new Vector2(0, 0));
        Vector2 objetivo = new Vector2(10, 0);
        float distanciaValida = 1.0f;
        float tiempoEspera = 1.0f;

        // Crear tareas
        MoveToTarget moveTask = new MoveToTarget(agent, objetivo, distanciaValida);
        WaitTask waitTask = new WaitTask(tiempoEspera);

        // Selector que verifica la distancia antes de ejecutar su hijo
        Selector validationSelector = new Selector(agent, distanciaValida, objetivo);
        validationSelector.AddChild(moveTask);

        // Otro selector que no evalúa condiciones, solo ejecuta a su hijo
        Selector actionSelector = new Selector(agent, float.MaxValue, objetivo);
        actionSelector.AddChild(validationSelector);  // Solo ejecuta lo que recibe

        // Secuencia que primero evalúa el selector y luego espera
        Sequence sequence = new Sequence();
        sequence.AddChild(actionSelector); // Evalúa y ejecuta movimiento
        sequence.AddChild(waitTask);       // Espera un tiempo

        // Raíz del árbol de comportamiento
        Root root = new Root(sequence);

        // Ejecutar el árbol de comportamiento en bucle
        while (true)
        {
            root.Execute();
        }
    }
}
