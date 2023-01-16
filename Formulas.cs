using System;

namespace MathematicalFormulas
{
    public class Formulas
    {
        // Simple Interest method accepts three arguments, all may be of integer, decimal or double data types
        // e.g SimpleInterest(2800, 2.3, 2);
        public static double SimpleInterest(double principalAmount, double interestRate, double time)
        {
            double result = (principalAmount * interestRate * time) / 100;
            return result;
        }


        // Compound Interest method accepts three arguments, all may be of integer, decimal or double data types
        // e.g CompoundInterest(5600, 2.3, 10.2);
        public static double CompoundInterest(double principalAmount, double interestRate, double time)
        {
            double result = principalAmount * Math.Pow(1 + (interestRate / 100), time);
            return result;
        }


        // Volume Of Trapezium method accepts three arguments, all may be of integer, decimal or double data types
        // e.g VolumeOfTrapezium(4.5, 5, 8.5);
        public static double VolumeOfTrapezium(double height, double upperBaseLength, double lowerBaseLength)
        {
            double result = ((upperBaseLength + lowerBaseLength) * height) / 2;
            return result;
        }


        // Volume Of Parallelogram method accepts two arguments, all may be of integer, decimal or double data types
        // e.g VolumeOfParallelogram(10.2, 4.2);
        public static double VolumeOfParallelogram(double baseLength, double height)
        {
            double result = baseLength * height;
            return result;
        }


        // Volume Of Cuboid method accepts three arguments, all may be of integer, decimal or double data types
        // e.g VolumeOfCuboid(2.3, 5, 10.2);
        public static double VolumeOfCuboid(double length, double width, double height)
        {
            double result = length * width * height;
            return result;
        }


        // Volume Of Cylinder method accepts two arguments, all may be of integer, decimal or double data types
        // e.g VolumeOfCylinder(2.3, 5);
        public static double VolumeOfCylinder(double radius, double height)
        {
            double result = Math.PI * Math.Pow(radius, 2) * height;
            return result;
        }


        // Volume Of Cone method accepts two arguments, all may be of integer, decimal or double data types
        // e.g VolumeOfCone(2.3, 5);
        public static double VolumeOfCone(double radius, double height)
        {
            double result = (Math.PI * Math.Pow(radius, 2) * height) / 3;
            return result;
        }
    }
}
