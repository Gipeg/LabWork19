using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ShapeFactory
    {
        public IShape getShape(string shapeType)
        {
            if(shapeType == null)
            {
                return null;
            }
            if (shapeType.equalsIgnoreCase("CIRCLE"))
            {
                return new Circle();
            }
            else if (shapeType.equalsIgnoreCase("RECTANGLE"))
            {
                return new Rectangle();
            }
            else if (shapeType.EqualsIgnoreCase("SQUARE"))
            {
                return new Square();
            }

            return null;
        }
    }
}
