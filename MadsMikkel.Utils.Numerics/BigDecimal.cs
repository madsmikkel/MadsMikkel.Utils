using System;
using System.Numerics;
[assembly: CLSCompliant( true )]

namespace MadsMikkel.Utils.Numerics
{
	public struct BigDecimal : IFormattable, IComparable, IComparable<BigDecimal>, IEquatable<BigDecimal>
	{
		#region Fields
		private BigInteger integral;
		private BigInteger fraction;
		#endregion


		#region Constructors

		#endregion


		#region Methods
		public override bool Equals( object obj )
		{
			return base.Equals( obj );
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string ToString()
		{
			return base.ToString();
		}

		int IComparable<BigDecimal>.CompareTo( BigDecimal other )
		{
			throw new NotImplementedException();
		}

		int IComparable.CompareTo( object obj )
		{
			throw new NotImplementedException();
		}

		bool IEquatable<BigDecimal>.Equals( BigDecimal other )
		{
			throw new NotImplementedException();
		}

		string IFormattable.ToString( string format, IFormatProvider formatProvider )
		{
			throw new NotImplementedException();

		}
		#endregion

		#region Operators
		public static implicit operator BigDecimal( float value )
		{
			throw new NotImplementedException();
		}

		public static implicit operator BigDecimal( double value )
		{
			throw new NotImplementedException();
		}

		public static implicit operator BigDecimal( decimal value )
		{
			throw new NotImplementedException();
		}

		public static implicit operator BigDecimal( BigInteger value )
		{
			throw new NotImplementedException();
		}

		public static explicit operator BigDecimal( byte value )
		{
			throw new NotImplementedException();
		}

		[CLSCompliant( false )]
		public static explicit operator BigDecimal( sbyte value )
		{
			throw new NotImplementedException();
		}

		public static explicit operator BigDecimal( short value )
		{
			throw new NotImplementedException();
		}

		[CLSCompliant( false )]
		public static explicit operator BigDecimal( ushort value )
		{
			throw new NotImplementedException();
		}

		public static explicit operator BigDecimal( int value )
		{
			throw new NotImplementedException();
		}

		public static explicit operator BigDecimal( char value )
		{
			throw new NotImplementedException();
		}

		[CLSCompliant( false )]
		public static explicit operator BigDecimal( uint value )
		{
			throw new NotImplementedException();
		}

		public static explicit operator BigDecimal( long value )
		{
			throw new NotImplementedException();
		}

		[CLSCompliant( false )]
		public static explicit operator BigDecimal( ulong value )
		{
			throw new NotImplementedException();
		}

		public static explicit operator byte( BigDecimal value )
		{
			throw new NotImplementedException();
		}

		[CLSCompliant( false )]
		public static explicit operator sbyte( BigDecimal value )
		{
			throw new NotImplementedException();
		}

		public static explicit operator short( BigDecimal value )
		{
			throw new NotImplementedException();
		}

		[CLSCompliant( false )]
		public static explicit operator ushort( BigDecimal value )
		{
			throw new NotImplementedException();
		}

		public static explicit operator int( BigDecimal value )
		{
			throw new NotImplementedException();
		}

		[CLSCompliant( false )]
		public static explicit operator uint( BigDecimal value )
		{
			throw new NotImplementedException();
		}

		public static explicit operator long( BigDecimal value )
		{
			throw new NotImplementedException();
		}

		[CLSCompliant( false )]
		public static explicit operator ulong( BigDecimal value )
		{
			throw new NotImplementedException();
		}

		public static explicit operator BigInteger( BigDecimal value )
		{
			throw new NotImplementedException();
		}

		public static explicit operator float( BigDecimal value )
		{
			throw new NotImplementedException();
		}

		public static explicit operator double( BigDecimal value )
		{
			throw new NotImplementedException();
		}

		public static explicit operator decimal( BigDecimal value )
		{
			throw new NotImplementedException();
		}

		public static BigDecimal operator +( BigDecimal value )
		{
			return value;
		}

		public static BigDecimal operator -( BigDecimal value )
		{
			throw new NotImplementedException();
		}

		public static BigDecimal operator ++( BigDecimal value )
		{
			throw new NotImplementedException();
		}

		public static BigDecimal operator --( BigDecimal value )
		{
			throw new NotImplementedException();
		}

		public static BigDecimal operator +( BigDecimal op1, BigDecimal op2 )
		{
			throw new NotImplementedException();
		}

		public static BigDecimal operator -( BigDecimal op1, BigDecimal op2 )
		{
			throw new NotImplementedException();
		}

		public static BigDecimal operator *( BigDecimal op1, BigDecimal op2 )
		{
			throw new NotImplementedException();
		}

		public static BigDecimal operator /( BigDecimal op1, BigDecimal op2 )
		{
			throw new NotImplementedException();
		}

		public static BigDecimal operator %( BigDecimal op1, BigDecimal op2 )
		{
			throw new NotImplementedException();
		}

		public static bool operator ==( BigDecimal op1, BigDecimal op2 )
		{
			throw new NotImplementedException();
		}

		public static bool operator !=( BigDecimal op1, BigDecimal op2 )
		{
			throw new NotImplementedException();
		}

		public static bool operator <( BigDecimal op1, BigDecimal op2 )
		{
			throw new NotImplementedException();
		}

		public static bool operator >( BigDecimal op1, BigDecimal op2 )
		{
			throw new NotImplementedException();
		}

		public static bool operator <=( BigDecimal op1, BigDecimal op2 )
		{
			throw new NotImplementedException();
		}

		public static bool operator >=( BigDecimal op1, BigDecimal op2 )
		{
			throw new NotImplementedException();
		}
		#endregion

		#region Nested members
		internal static class BigParser
		{
			public static bool TryParse( string value, out BigDecimal result )
			{
				result = default( BigDecimal );
				return false;
			}			
		}
		internal struct Formatter { }
		#endregion
	}
}
