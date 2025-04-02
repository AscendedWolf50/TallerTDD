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
        public override bool Execute()
        {
            foreach (var child in Children)
            {
                if (child.Execute())
                    return true;
            }
            return false;
        }
    }
}