class program
{
	static void main()
	{
		Console.WriteLine("Welcome to Comparision Computation Program");
		Console.WriteLine("Enter x1, y1, x2 and y2 one after the another");
		int x1=Convert.ToInt32(Console.ReadLine());
		int y1=Convert.ToInt32(Console.ReadLine());
		int x2=Convert.ToInt32(Console.ReadLine());
		int y2=Convert.ToInt32(Console.ReadLine());

		double length=Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
		Console.WriteLine("Length of the line segment is: "+length);
	}
}
