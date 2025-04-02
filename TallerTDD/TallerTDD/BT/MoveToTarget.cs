using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TallerBT.BT
{
    public class MoveToTarget : TaskNode
    {
        private Agent agent;
        private Vector2 objetivo;
        private float distanciaValida;

        public MoveToTarget(Agent agent, Vector2 objetivo, float distanciaValida)
        {
            this.agent = agent;
            this.objetivo = objetivo;
            this.distanciaValida = distanciaValida;
        }

        public override bool Execute()
        {
            if (agent.DistanciaAlObjetivo(objetivo) > distanciaValida)
            {
                agent.MoverHaciaObjetivo(objetivo);
                return false; // Todavía no ha llegado
            }

            Console.WriteLine("El agente ha alcanzado la distancia válida.");
            return true;
        }
    }
}