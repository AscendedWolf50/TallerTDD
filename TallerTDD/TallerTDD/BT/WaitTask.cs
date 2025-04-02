using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerBT.BT
{
    public class WaitTask : TaskNode
    {
        private float segundos;

        public WaitTask(float segundos)
        {
            this.segundos = segundos;
        }

        public override bool Execute()
        {
            int milisegundos = (int)(segundos * 1000);
            Console.WriteLine($"Esperando {segundos} segundos...");
            Thread.Sleep(milisegundos);
            return true;
        }
    }
}
