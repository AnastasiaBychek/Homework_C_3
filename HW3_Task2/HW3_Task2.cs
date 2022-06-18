void distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int d = ((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    double sqr = Math.Sqrt(d);
    double sqr1 = Math.Round(sqr,2);
    Console.WriteLine(sqr1); 
}

distance(7, -5, 0, 1, -1, 9);
