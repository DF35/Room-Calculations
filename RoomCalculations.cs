using System;

namespace Calculate_Volume_of_a_room
{
    public class Room
    {
        double length;
        double width;
        double height;

        public Room(double enteredLength, double enteredWidth, double enteredHeight)
        {
            length = enteredLength;
            width = enteredWidth;
            height = enteredHeight;
        }

        public double Area()
        {
            double area = length * width;
            return area;
        }

        public double PaintNeeded()
        {
            double paintNeeded = (((width * height) * 2) + ((length * height) * 2)) / 5;
            return paintNeeded;
        }

        public double Volume()
        {
            double volume = length * width * height;
            return volume;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Taking the dimensions as an input
            double length = 0;
            double width = 0;
            double height = 0;

            bool lengthValidated = false;
            bool widthValidated = false;
            bool heightValidated = false;

            while (lengthValidated == false)
            {
                Console.WriteLine("Please enter the length of the room in metres");
                string enteredLength = Console.ReadLine();

                if (!double.TryParse(enteredLength, out double dEnteredLength))
                {
                    Console.WriteLine("Invalid input: Please enter a number \n");
                }
                else if (dEnteredLength <= 0)
                {
                    Console.WriteLine("Please enter a valid value (greater than 0) \n");
                }
                else
                {
                    length = Convert.ToDouble(enteredLength);
                    lengthValidated = true;
                }
            }

            while (widthValidated == false)
            {
                Console.WriteLine("\nPlease enter the width of the room in metres");
                string enteredWidth = Console.ReadLine();

                if (!double.TryParse(enteredWidth, out double dEnteredWidth))
                {
                    Console.WriteLine("Invalid input: Please enter a number \n");
                }
                else if (dEnteredWidth <= 0)
                {
                    Console.WriteLine("Please enter a valid value (greater than 0) \n");
                }
                else
                {
                    width = Convert.ToDouble(enteredWidth);
                    widthValidated = true;
                }
            }

            while (heightValidated == false)
            {
                Console.WriteLine("\nPlease enter the height of the room in metres");
                string enteredHeight = Console.ReadLine();

                if (!double.TryParse(enteredHeight, out double dEnteredHeight))
                {
                    Console.WriteLine("Invalid input: Please enter a number \n");
                }
                else if (dEnteredHeight <= 0)
                {
                    Console.WriteLine("Please enter a valid value (greater than 0) \n");
                }
                else
                {
                    height = Convert.ToDouble(enteredHeight);
                    heightValidated = true;
                }
            }

            Room userRoom = new Room(length, width, height);
            double area = userRoom.Area();
            double paintNeeded = userRoom.PaintNeeded();
            double volume = userRoom.Volume();

            Console.WriteLine($"\nThe area of the floor is {area} square metres");
            Console.WriteLine($"\nTo paint your walls you would need {paintNeeded} litres of paint (Provided that one litre covers 5 square metres)");
            Console.WriteLine($"\nThe volume of the room is {volume} cubic metres");

        }
    }
}
