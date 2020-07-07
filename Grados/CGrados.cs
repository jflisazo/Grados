using System;
using System.Collections.Generic;
using System.Text;

namespace Grados
{
    class CGrados
    {
        private float gradosC;

        public void AsignarCentigrados(float gC)
        {
            gradosC = gC;
        }

        public float ObtenerFahrenheit()
        {
            return 9F / 5F * gradosC + 32;
        }

        public float ObtenerCentigrados()
        {
            return gradosC;
        }
    }
}
