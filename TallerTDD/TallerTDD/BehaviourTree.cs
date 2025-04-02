using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerBT.BT;

namespace TallerTDD
{
    public class BehaviourTree
    {
        private Node root;

        public void SetRoot(Node newRoot)
        {
            if (root != null)
            {
                throw new ArgumentException("El árbol de comportamiento solo puede tener un único Root.");
            }
            root = newRoot;
        }

        public bool Execute() => root?.Execute() ?? false;
    }
}
