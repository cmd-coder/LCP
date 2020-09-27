class program
{
	static void main()
	{
		Console.WriteLine("Welcome to Comparision Computation Program");
	}
	static void length(int x1, int y1, int x2, int y2)
	{
		return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
	}
	static void equality(int length1, int length2)
	{
		return (length1==length2);
	}
}
