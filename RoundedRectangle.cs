using System.Drawing;

namespace Appthuenha
{
    internal class RoundedRectangle
    {
        private Rectangle clientRectangle;
        private int radius;

        public RoundedRectangle(Rectangle clientRectangle, int radius)
        {
            this.clientRectangle = clientRectangle;
            this.radius = radius;
        }
    }
}