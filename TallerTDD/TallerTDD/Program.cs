using System;
using System.Numerics;
using TallerBT.BT;

partial class Program
{
    static void Main(string[] args)
    {
        Agent agent = new Agent(new Vector2(0, 0));
        Vector2 objetivo = new Vector2(10, 0);
        Vector2 puntoInicio = agent.Posicion; // Guarda la posición inicial
        float distanciaValida = 1.0f;
        float tiempoEspera = 1.0f;

        // Tareas para ir al objetivo
        MoveToTarget moveToTarget = new MoveToTarget(agent, objetivo, distanciaValida);
        WaitTask waitAtTarget = new WaitTask(tiempoEspera);

        // Tareas para volver al inicio
        MoveToTarget moveToStart = new MoveToTarget(agent, puntoInicio, distanciaValida);
        WaitTask waitAtStart = new WaitTask(tiempoEspera);

        // Secuencia cíclica: Ir -> Esperar -> Volver -> Esperar
        Sequence cycleSequence = new Sequence();
        cycleSequence.AddChild(moveToTarget);
        cycleSequence.AddChild(waitAtTarget);
        cycleSequence.AddChild(moveToStart);
        cycleSequence.AddChild(waitAtStart);

        // Raíz del árbol (ejecuta el ciclo infinito)
        Root root = new Root(cycleSequence);

        Console.WriteLine("=== Ciclo Iniciado ===");
        Console.WriteLine($"Posición inicial: {agent.Posicion}");
        Console.WriteLine($"Objetivo: {objetivo}");
        Console.WriteLine($"Distancia válida: {distanciaValida}");
        Console.WriteLine("----------------------");

        // Bucle infinito controlado (presiona ESC para salir)
        while (true)
        {
            Console.WriteLine("Esperando 2 segundos antes de iniciar el movimiento...");
            Thread.Sleep(2000); 

            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                Console.WriteLine("\n=== Ciclo Detenido ===");
                break;
            }

            Console.WriteLine("Ejecutando root...");
            root.Execute();
            System.Threading.Thread.Sleep(50);
        }

    }
}