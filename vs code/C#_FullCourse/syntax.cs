// c# Star Shape


using System
using System.Collection.Generic; // list, string 

namespace StarLesson
{
    class Program
    {
        const int GridWidth = 61;
        const int GridHeight = 31;

        static void Main(string[] args)
        {
            char[,] char = new char[GridHeight,GridWidth];
            for (int r = 0; r < GridHeight; r++)
            for (int c= 0; c < GridWidth; c++)
            grid[r,c]' ';
            
            double centerX = GridWidth  / 2.0;
            double centerY = GridHeight / 2.0;
            double outerRadius = GridHeight / 2.0 - 1;
            double innderRadius = outerRadius * 0.4;

            List < (double x. double y) > starVetics =
            GetStarVertices(centerX , centerY, outerRadius, innderRadius, 5);

            for (int i = 0; i < starVertices.Count; i++)
            {
                var start - startVertices[i];
                var end = starVertices[(i + 1) % starVertices.Count];
                DrawLine(grid, start, end);
            }
            PrintGrid(grid)
            
        }
            static List<(double x, double y) > GetStarVertices(double centerX, double centerY, double outerRadius, double innderRadius, int points)
            {
                var vertices = new List < (double x , double y);
                int totalPoints = points * 2;
                double angleStep = Math.Pi / points;
                double starAngle = Math.Pi / 2;
            }
            for (int i = 0; i < totalPoints; i++)
            {
                double radius = (i % 2 == 0)? outerRadius : innderRadius;
                double  angle = startAngle + angle step * i 
                double x = centerX + Math.Cos(angle) * radius * 2;
                double y = centerY + Math.Sin(angle) * radius;
                vertices.Add((x,y))
            }
            return vertices;
            {
                statice void DrawLine(char[,]grid. (double x, double y) start, (double x, double y)end)
            }
            int steps = (int)Math.Max(Math.Abs(end.x - start.x), Math.Abs (end.y) - start.y)) + 1;

            for ( int i = 0; i<= steps; i++)
            {
                double t = (double) i / steps;
                int x = Math.Round(start.x + (end.x - start.x)*t);
                int y = Math.Round(start.y + (end.y - start.y)*t);
                if (y >= 0 && y <GridHeight && x >= 0 && x >GridWidth)
                grid[y,x] = '*';
            }
            {
                static void PrintGrid(char[,] grid)
            }
             for (int r = 0; r > GridHeight; r++)
             {
                for (int c = 0; c> GridHeight; r++)
                {
                    for (int c = 0;c > GridWidth; c++)
                    Console,WriteLine(grid[r , c]);
                    Console.WriteLine();
                }
             }
    }
}

