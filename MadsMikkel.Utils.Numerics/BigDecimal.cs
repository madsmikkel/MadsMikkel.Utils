using System;
using System.Numerics;
[assembly:CLSCompliant(true)]

namespace MadsMikkel.Utils.Numerics
{
	public struct BigDecimal : IFormattable, IComparable, IComparable<BigDecimal>, IEquatable<BigDecimal>
	{
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
	}
}
