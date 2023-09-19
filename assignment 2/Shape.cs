using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    internal abstract class Shape
    {
       public abstract void calculateArea();
    }
    class Circle : Shape
    {
        double radius,area;
        public override void calculateArea()
        {
            Console.Write("Enter radius of circle: ");
            radius=Convert.ToDouble(Console.ReadLine());
            area = 3.14 * radius * radius;
            Console.WriteLine("Area of circle is: "+area);
        }
        /*static void Main(string[] args) { 
            Circle obj = new Circle();
            Rectangle objRectangle = new Rectangle();
            objRectangle.calculateArea();
            obj.calculateArea();    
        }*/
    }
    class Rectangle: Shape
    {
        double length, width,area;
        public override void calculateArea()
        {
            Console.Write("Enter length and width of rectanle: ");
            length = Convert.ToDouble(Console.ReadLine());
            width= Convert.ToDouble(Console.ReadLine());
            area = length * width;
            Console.WriteLine("Area of rectangle is: " + area);
        }
    }
}
