namespace la_segunda_ley_del_movimiento
{
    internal class aceleration: Mass
    {
        protected double a;

        public double A 
        {
            get { return a; } 
            set { a = value; } 
        }
        public aceleration(): base()
        {
            a = 0;
        }

        public override string ToString()
        {
            return " Aceleration: " + a;
        }


    }
}
