namespace Demo.Classes
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public override string ToString()
        {
            return $"{Real}+{Imaginary}i";
        }

        #region Binary Operator
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = left.Real + right.Real,
                Imaginary = left.Imaginary + right.Imaginary

            };

        }


        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = left.Real - right.Real,
                Imaginary = left.Imaginary - right.Imaginary

            };

        }
        #endregion


        #region Unary Operator
        public static Complex operator ++(Complex C)
        { 
            return new Complex()
            {
                Real = C.Real + 1,
                Imaginary = C.Imaginary+1
            };

        }
        #endregion

        #region Comparison Operator
        public static bool operator >(Complex left, Complex right)
        {
            if (left.Real > right.Real)
                return left.Imaginary > right.Imaginary;
            else
                return left.Real > right.Real;


        }

        public static bool operator <(Complex left, Complex right)
        {
            if (left.Real > right.Real)
                return left.Imaginary > right.Imaginary;
            else
                return left.Real > right.Real;


        }
        #endregion

        #region Casting Operator
        public static /*int*/ explicit operator int(Complex C)
        {
            return C.Real;
        }

        public static /*string*/ explicit operator string(Complex C)
        {
            return C.ToString();
        }
        #endregion

       
    }
}
