using SportCompanion.Core.Models;

namespace WindowsFormsApp2.Helpers
{
    public static class ColorConverter
    {
        public static System.Drawing.Color ToDrawingColor(Color color)
        {
            System.Drawing.Color result = default;

            if (color != null)
            {
                result = System.Drawing.Color.FromArgb(color.A, color.R, color.G, color.B);
            }

            return result;
        }

        public static Color FromDrawingColor(System.Drawing.Color color)
        {
            Color result = null;

            if (color != null)
            {
                result = new Color
                {
                    Name = color.Name,
                    A = color.A,
                    R = color.R,
                    G = color.G,
                    B = color.B
                };
            }

            return result;
        }
    }
}