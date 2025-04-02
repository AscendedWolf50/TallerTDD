using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerBT.BT
{
    public abstract class Composite : Node
    {
        public List<Node> children = new List<Node>(); // Lista de hijos

        public void AddChild(Node node)
        {
            children.Add(node);
        }
    }
}
