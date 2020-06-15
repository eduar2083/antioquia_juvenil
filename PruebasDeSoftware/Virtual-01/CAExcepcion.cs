using System;

namespace Virtual_01
{
    public class CAExcepcion : ArgumentException
    {
        public CAExcepcion(string mensaje)
            : base(mensaje)
        {

        }
    }
}
