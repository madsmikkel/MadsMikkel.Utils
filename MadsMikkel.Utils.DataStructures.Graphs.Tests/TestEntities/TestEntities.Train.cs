namespace MadsMikkel.Utils.DataStructures.Graphs.Tests.TestEntities
{
	/// <summary>
	/// Represents a train with a train number.
	/// </summary>
	public class Line
	{
		/// <summary>
		/// Initializes a new instance of this calls with the specified train number.
		/// </summary>
		/// <param name="number">The train number.</param>
		public Line( string number )
		{
			No = number;
		}

		/// <summary>
		/// Initializes a new instance of this class, with train number 000.
		/// </summary>
		public Line() : this( "000" ) { }

		/// <summary>
		/// Gets or set the train number.
		/// </summary>
		public string No { get; set; }

		public override string ToString()
		{
			return $"Line: {No}\n";
		}
	}

	/// <summary>
	/// Represents a train with a train number.
	/// </summary>
	public class Station
	{
		/// <summary>
		/// Initializes a new instance of this calls with the specified train number.
		/// </summary>
		/// <param name="number">The train number.</param>
		public Station(string name)
		{
			Name = name;
		}

		/// <summary>
		/// Initializes a new instance of this class, with train number 000.
		/// </summary>
		public Station() : this("000") { }

		/// <summary>
		/// Gets or set the train number.
		/// </summary>
		public string Name { get; set; }

		public override string ToString()
		{
			return $"Station: {Name}\n";
		}
	}
}