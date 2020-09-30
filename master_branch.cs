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

		Console.WriteLine("Enter x1, y1, x2 and y2 one after the another of line two");
                int u1=Convert.ToInt32(Console.ReadLine());
                int v1=Convert.ToInt32(Console.ReadLine());
                int u2=Convert.ToInt32(Console.ReadLine());
                int v2=Convert.ToInt32(Console.ReadLine());

		double length2=Math.Sqrt((u1-u2)*(u1-u2)+(v1-v2)*(v1-v2));

		if(length==length2)
			Console.WriteLine("Both the lines are equal in length");
		else
			Console.WriteLine("The lines are not equal in length");
	}
}
