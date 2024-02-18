using System.Drawing;

namespace la_segunda_ley_del_movimiento
{
    internal class Mass
    {
        //propites
        protected double m;

        public double M
        {
            get { return m; }
            set { m = value; }
        }

        //constructor
        public Mass()
        {
            m = 0;
        }


        //Methods
        public override string ToString()
        {
            return "Mass: " + m ;
        }

    }
}
