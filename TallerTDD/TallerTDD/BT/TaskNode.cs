using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerBT.BT
{
    public abstract class TaskNode : Node
    {
       // public abstract bool Execute();
        public override abstract bool Execute();
        // Agregar este método para que las clases hijas puedan sobrescribirlo
        public virtual void Reset() { }
    }
}
