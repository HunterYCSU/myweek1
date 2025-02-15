
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public static class ShapeColourHelper
    {

        public static Shape AddColour(Shape s)
        {
            string[] colours = { "Yellow", "Red", "Blue", "Green", "Orange" };
            Random random = new Random();
            int randomIndex = random.Next(0, colours.Length);
            string colourRandom = colours[randomIndex];

            s.Colour = colourRandom;

            return s;
        }

        public static Shape ChangeColour(Shape s)
        {
            s.Colour = "Blue";

            return s;
        }

    }
}
