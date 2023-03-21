using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace ChangeColor
{
    public class ChangeMyColor
    {
        Color color = Color.FromArgb(50,50,50);

        public Color NewColorSet()
        {
            return color;
        }
    }
}