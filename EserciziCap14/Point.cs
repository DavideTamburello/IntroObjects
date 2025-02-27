using System;

namespace EsempiCapitolo14;

public class Point
{
	//campi o fields della classe
	// private double x;
	// private double y;
	double[] coordinates;
	public Point(double x, double y)
	{
		// this.x = x;
		// this.y = y;
		coordinates = new double[2];
		coordinates[0]=x;
		coordinates[1]=y;
	}
	public double X
	{
		get { return coordinates[0]; }
		set { coordinates[0] = value; }
	}
	public double Y
	{
		get { return coordinates[1]; }
		set { coordinates[1] = value; }
	}
	public override string ToString()
	{
		return $"({coordinates[0]},{coordinates[1]})";
	}
	
}