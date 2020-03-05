using System;

namespace Pie_Estimator
{
    class PieEstimatorProgram
    {

        public static Tuple<double,double> GetCoordinateTuple(Random r)
        {
            double A = 0.0;
            double B = 0.0;



            return Tuple.Create(A, B); 
        }

        public static double Radius(double X, double Y) => Math.Sqrt(X * X + Y * Y);
     

        public static void EstimatePI()
        {
           //Initialize random values
            Random r = new Random(); //Instantiating the object "r" from the class "random"
            int maxValue = 10;
     
            
            for (int exponent = 1; exponent < maxValue; exponent++)
            {
                //reset counters
                int inCircle = 0;//If you initialized the in-circle count outside of this loop, the counter would not clear after each iteration and you would end up with an invalid answer due to the counter accumulating more counts than it should
                int iterations;

                //run through monte carlo method
                for (iterations = 0; iterations < Math.Pow(10, exponent); iterations++)
                {
                    double X = r.NextDouble();//using a random generator for doubles automatically chooses between 0 and 1; for integer random numbers you can speficy the range in the parentheses
                    double Y = r.NextDouble();//if you want a double from a range greater than 0 - 1, then multiply the result of the random double by the number at the top of the range (if the range is 0 - 25, multiple the random double by 25 to get values in between 0 - 25)
                    double Z = Radius(X, Y);
                    //hits += Z <= 1 ? 1 : 0;
                    if (Z <= 1)
                    {
                        inCircle++;
                    }
                }

                //print the result
                Console.WriteLine(4d * (double)inCircle / (double)iterations);
            }
           
        }



        static void Main(string[] args)
        {
            Console.WriteLine("PI Estimator");
            EstimatePI();

        }
    }
}
