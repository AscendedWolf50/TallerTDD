namespace TallerBT.BT
{
    public class Root : Node
    {
        private Node child;

        public Root(Node rootChild)
        {
            child = rootChild;
        }

        public override bool Execute()
        {
            if (child.Execute())
            {
                child.Reset(); // Reinicia todas las tareas cuando terminan
                return true;
            }
            return false;
        }

        public override void Reset()
        {
            child.Reset(); // Asegura que también se pueda reiniciar manualmente
        }
    }
}


