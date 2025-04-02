using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TallerBT.BT
{
    public class Selector : Composite
    {
        private Agent agent;
        private float distanciaValida;
        private Vector2 objetivo;

        public Selector(Agent agent, float distanciaValida, Vector2 objetivo)
        {
            this.agent = agent;
            this.distanciaValida = distanciaValida;
            this.objetivo = objetivo;
        }

        public override bool Execute()
        {
            // Si estamos FUERA de la distancia válida, ejecutamos los hijos
            if (agent.DistanciaAlObjetivo(objetivo) > distanciaValida)
            {
                Console.WriteLine("El objetivo está fuera de la distancia válida. Ejecutando hijos...");

                foreach (Node child in children)
                {
                    if (child.Execute())
                    {
                        return true;
                    }
                }
                return false;
            }

            Console.WriteLine("El objetivo está dentro de la distancia válida.");
            return true;
        }
    }
}