namespace MadsMikkel.Utils.DataStructures.Graphs.Tests.TestEntities
{
	/// <summary>
	/// Represents a train with a train number.
	/// </summary>
	public class Train
	{
		/// <summary>
		/// Initializes a new instance of this calls with the specified train number.
		/// </summary>
		/// <param name="number">The train number.</param>
		public Train( string number )
		{
			No = number;
		}

		/// <summary>
		/// Initializes a new instance of this class, with train number 000.
		/// </summary>
		public Train() : this( "000" ) { }

		/// <summary>
		/// Gets or set the train number.
		/// </summary>
		public string No { get; set; }
	}
}