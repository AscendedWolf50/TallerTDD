using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerBT.BT
{
    public abstract class TaskNode : Node
    {
        public virtual void AddChild(Node child)
        {
            throw new InvalidOperationException("TaskNode no puede tener hijos.");
        }
    }
}
