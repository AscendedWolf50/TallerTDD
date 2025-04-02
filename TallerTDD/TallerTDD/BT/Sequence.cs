using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Sequence : Node
{
    public override bool Execute()
    {
        foreach (var child in children)
        {
            if (!child.ExecuteWithLogging())
            {
                Console.WriteLine($"Fallo en nodo: {child.GetType().Name}");
                return false;
            }
        }
        return true;
    }
}

