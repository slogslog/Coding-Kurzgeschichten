namespace ReferenceTypes
{
    public class Flasche
    {
        private bool istvoll;

        public void WirdAusgetrunken()
        {
            istvoll = false;
        }

        public Flasche()
        {
            istvoll = true;
        }

        public override string ToString()
        {
            return istvoll ? "voll" : "leer";
        }
    }
}
