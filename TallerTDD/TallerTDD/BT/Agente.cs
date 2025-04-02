using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TallerBT.BT
{

    public class Agent
    {
        public Vector2 Posicion { get; private set; }

        public Agent(Vector2 posicionInicial)
        {
            Posicion = posicionInicial;
        }

        public float DistanciaAlObjetivo(Vector2 objetivo)
        {
            return Vector2.Distance(Posicion, objetivo);
        }

        public void MoverHaciaObjetivo(Vector2 objetivo)
        {
            Vector2 direccion = Vector2.Normalize(objetivo - Posicion);
            Posicion += direccion; // Mueve al agente paso a paso
            Console.WriteLine($"Agente se movió a la posición: {Posicion}");
        }
    }
}