﻿namespace Elementary.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Sprache;

    [StructLayout(LayoutKind.Explicit, Pack = 1), Serializable]
    public struct Spin
    {
        internal static char Unit = 'ħ';

        [FieldOffset(0)]
        public readonly byte Denominator;
        [FieldOffset(1)]
        public readonly byte Numerator;

        public Spin(byte numerator, byte denominator)
        {
            this.Denominator = denominator;
            this.Numerator = numerator;
        }

        public static Parser<Spin> Token =
            from _1 in Parse.Char('(').Optional()  // open brace
            from n1 in Parse.Number
            from del in Parse.Char('/') // divider
            from n2 in Parse.Number
            from _2 in Parse.Char(')').Optional()  // closed brace
            from unit in Parse.Char(Unit).Optional()
            select new Spin(byte.Parse(n1), byte.Parse(n2));


        public override string ToString() => $"({Numerator}/{Denominator}){Unit}";



        #region Equality members

        public bool Equals(ElectricCharge other)
            => Denominator == other.Denominator && Numerator == other.Numerator;

        /// <inheritdoc />
        public override bool Equals(object obj)
            => obj is ElectricCharge other && Equals(other);

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Denominator.GetHashCode();
                hashCode = (hashCode * 397) ^ Numerator.GetHashCode();
                return hashCode;
            }
        }


        public static bool operator ==(Spin e1, Spin e2)
        {
            // handle default eq
            if (e1.Denominator == 0 && e1.Numerator == 0)
                return false;
            if (e2.Denominator == 0 && e2.Numerator == 0)
                return false;

            return (e1.Denominator == e2.Denominator) && (e1.Numerator == e2.Numerator);
        }

        public static bool operator !=(Spin e1, Spin e2) => !(e1 == e2);
       
        public static implicit operator string(Spin e) => e.ToString();
        public static implicit operator Spin(string e) => Token.Parse(e);
        #endregion
    }
}