using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerBT.BT
{
    public class Sequence : Node
    {
        public override bool Execute()
        {
            foreach (Node child in children)
            {
                if (!child.Execute()) return false;
            }
            return true;
        }
    }
}
