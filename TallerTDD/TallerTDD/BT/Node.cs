using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerBT.BT
{
    public abstract class Node
    {
        protected List<Node> children = new List<Node>();

        public abstract bool Execute();

        public void AddChild(Node child)
        {
            children.Add(child);
        }
    }
}
