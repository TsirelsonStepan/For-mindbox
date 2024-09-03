namespace LibraryForMindbox
{
    public static class FindShapeArea
    {
        public static double Circle(double radius)
        {
            try
            {
                double area = radius * radius * Math.PI;
                return area;
            }
            catch
            {
                return 0d;
            }
        }

        public static double Triangle(double[] sides)
        {
            try
            {
                double area;
                Array.Sort(sides); 
                if (sides[0] * sides[0] == sides[1] * sides[2] * sides[1] * sides[2])
                {
                    area = sides[1] * sides[2] / 2d;
                }
                else
                {
                    double half_p = (sides[0] + sides[1] + sides[2]) / 2d;
                    area = Math.Sqrt(half_p * (half_p - sides[0]) * (half_p - sides[1]) * (half_p - sides[2]));
                }
                return area;                
            }
            catch
            {
                return 0d;
            }
        }
    }
}