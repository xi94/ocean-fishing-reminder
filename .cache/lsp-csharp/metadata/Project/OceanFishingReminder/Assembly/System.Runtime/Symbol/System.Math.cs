#region Assembly System.Runtime, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// System.Runtime.dll
#endregion

using System.Runtime.CompilerServices;

namespace System {
    //
    // Summary:
    //     Provides constants and static methods for trigonometric, logarithmic, and other
    //     common mathematical functions.
    public static class Math {
        //
        // Summary:
        //     Represents the natural logarithmic base, specified by the constant, e.
        public const double E = 2.718281828459045;
        //
        // Summary:
        //     Represents the ratio of the circumference of a circle to its diameter, specified
        //     by the constant, π.
        public const double PI = 3.141592653589793;
        //
        // Summary:
        //     Represents the number of radians in one turn, specified by the constant, τ.
        public const double Tau = 6.283185307179586;

        //
        // Summary:
        //     Returns the absolute value of a single-precision floating-point number.
        //
        // Parameters:
        //   value:
        //     A number that is greater than or equal to Single.MinValue, but less than or equal
        //     to Single.MaxValue.
        //
        // Returns:
        //     A single-precision floating-point number, x, such that 0 ≤ x ≤ Single.MaxValue.
        public static float Abs(float value);
        //
        // Summary:
        //     Returns the absolute value of an 8-bit signed integer.
        //
        // Parameters:
        //   value:
        //     A number that is greater than SByte.MinValue, but less than or equal to SByte.MaxValue.
        //
        //
        // Returns:
        //     An 8-bit signed integer, x, such that 0 ≤ x ≤ SByte.MaxValue.
        //
        // Exceptions:
        //   T:System.OverflowException:
        //     value equals SByte.MinValue.
        [CLSCompliant(false)]
        public static sbyte Abs(sbyte value);
        //
        // Summary:
        //     Returns the absolute value of a 64-bit signed integer.
        //
        // Parameters:
        //   value:
        //     A number that is greater than Int64.MinValue, but less than or equal to Int64.MaxValue.
        //
        //
        // Returns:
        //     A 64-bit signed integer, x, such that 0 ≤ x ≤ Int64.MaxValue.
        //
        // Exceptions:
        //   T:System.OverflowException:
        //     value equals Int64.MinValue.
        public static long Abs(long value);
        //
        // Summary:
        //     Returns the absolute value of a native signed integer.
        //
        // Parameters:
        //   value:
        //     A number that is greater than System.IntPtr.MinValue, but less than or equal
        //     to System.IntPtr.MaxValue.
        //
        // Returns:
        //     A native signed integer, x, such that 0 ≤ x ≤ System.IntPtr.MaxValue.
        public static nint Abs(nint value);
        //
        // Summary:
        //     Returns the absolute value of a 16-bit signed integer.
        //
        // Parameters:
        //   value:
        //     A number that is greater than Int16.MinValue, but less than or equal to Int16.MaxValue.
        //
        //
        // Returns:
        //     A 16-bit signed integer, x, such that 0 ≤ x ≤ Int16.MaxValue.
        //
        // Exceptions:
        //   T:System.OverflowException:
        //     value equals Int16.MinValue.
        public static short Abs(short value);
        //
        // Summary:
        //     Returns the absolute value of a double-precision floating-point number.
        //
        // Parameters:
        //   value:
        //     A number that is greater than or equal to Double.MinValue, but less than or equal
        //     to Double.MaxValue.
        //
        // Returns:
        //     A double-precision floating-point number, x, such that 0 ≤ x ≤ Double.MaxValue.
        public static double Abs(double value);
        //
        // Summary:
        //     Returns the absolute value of a System.Decimal number.
        //
        // Parameters:
        //   value:
        //     A number that is greater than or equal to Decimal.MinValue, but less than or
        //     equal to Decimal.MaxValue.
        //
        // Returns:
        //     A decimal number, x, such that 0 ≤ x ≤ Decimal.MaxValue.
        public static decimal Abs(decimal value);
        //
        // Summary:
        //     Returns the absolute value of a 32-bit signed integer.
        //
        // Parameters:
        //   value:
        //     A number that is greater than Int32.MinValue, but less than or equal to Int32.MaxValue.
        //
        //
        // Returns:
        //     A 32-bit signed integer, x, such that 0 ≤ x ≤ Int32.MaxValue.
        //
        // Exceptions:
        //   T:System.OverflowException:
        //     value equals Int32.MinValue.
        public static int Abs(int value);
        //
        // Summary:
        //     Returns the angle whose cosine is the specified number.
        //
        // Parameters:
        //   d:
        //     A number representing a cosine, where d must be greater than or equal to -1,
        //     but less than or equal to 1.
        //
        // Returns:
        //     An angle, θ, measured in radians, such that 0 ≤ θ ≤ π. -or- System.Double.NaN
        //     if d < -1 or d > 1 or d equals System.Double.NaN.
        public static double Acos(double d);
        //
        // Summary:
        //     Returns the angle whose hyperbolic cosine is the specified number.
        //
        // Parameters:
        //   d:
        //     A number representing a hyperbolic cosine, where d must be greater than or equal
        //     to 1, but less than or equal to System.Double.PositiveInfinity.
        //
        // Returns:
        //     An angle, θ, measured in radians, such that 0 ≤ θ ≤ ∞. -or- System.Double.NaN
        //     if d < 1 or d equals System.Double.NaN.
        public static double Acosh(double d);
        //
        // Summary:
        //     Returns the angle whose sine is the specified number.
        //
        // Parameters:
        //   d:
        //     A number representing a sine, where d must be greater than or equal to -1, but
        //     less than or equal to 1.
        //
        // Returns:
        //     An angle, θ, measured in radians, such that -π/2 ≤ θ ≤ π/2. -or- System.Double.NaN
        //     if d < -1 or d > 1 or d equals System.Double.NaN.
        public static double Asin(double d);
        //
        // Summary:
        //     Returns the angle whose hyperbolic sine is the specified number.
        //
        // Parameters:
        //   d:
        //     A number representing a hyperbolic sine, where d must be greater than or equal
        //     to System.Double.NegativeInfinity, but less than or equal to System.Double.PositiveInfinity.
        //
        //
        // Returns:
        //     An angle, θ, measured in radians. -or- System.Double.NaN if d equals System.Double.NaN.
        public static double Asinh(double d);
        //
        // Summary:
        //     Returns the angle whose tangent is the specified number.
        //
        // Parameters:
        //   d:
        //     A number representing a tangent.
        //
        // Returns:
        //     An angle, θ, measured in radians, such that -π/2 ≤ θ ≤ π/2. -or- System.Double.NaN
        //     if d equals System.Double.NaN, -π/2 rounded to double precision (-1.5707963267949)
        //     if d equals System.Double.NegativeInfinity, or π/2 rounded to double precision
        //     (1.5707963267949) if d equals System.Double.PositiveInfinity.
        public static double Atan(double d);
        //
        // Summary:
        //     Returns the angle whose tangent is the quotient of two specified numbers.
        //
        // Parameters:
        //   y:
        //     The y coordinate of a point.
        //
        //   x:
        //     The x coordinate of a point.
        //
        // Returns:
        //     An angle, θ, measured in radians, such that tan(θ) = y / x, where (x, y) is a
        //     point in the Cartesian plane. Observe the following: - For (x, y) in quadrant
        //     1, 0 < θ < π/2. - For (x, y) in quadrant 2, π/2 < θ ≤ π. - For (x, y) in quadrant
        //     3, -π ≤ θ < -π/2. - For (x, y) in quadrant 4, -π/2 < θ < 0. For points on the
        //     boundaries of the quadrants, the return value is the following: - If y is 0 and
        //     x is not negative, θ = 0. - If y is 0 and x is negative, θ = π. - If y is positive
        //     and x is 0, θ = π/2. - If y is negative and x is 0, θ = -π/2. - If y is 0 and
        //     x is 0, θ = 0. If x or y is System.Double.NaN, or if x and y are either System.Double.PositiveInfinity
        //     or System.Double.NegativeInfinity, the method returns System.Double.NaN.
        public static double Atan2(double y, double x);
        //
        // Summary:
        //     Returns the angle whose hyperbolic tangent is the specified number.
        //
        // Parameters:
        //   d:
        //     A number representing a hyperbolic tangent, where d must be greater than or equal
        //     to -1, but less than or equal to 1.
        //
        // Returns:
        //     An angle, θ, measured in radians, such that -∞ < θ < -1, or 1 < θ < ∞. -or- System.Double.NaN
        //     if d < -1 or d > 1 or d equals System.Double.NaN.
        public static double Atanh(double d);
        //
        // Summary:
        //     Produces the full product of two 32-bit numbers.
        //
        // Parameters:
        //   a:
        //     The first number to multiply.
        //
        //   b:
        //     The second number to multiply.
        //
        // Returns:
        //     The number containing the product of the specified numbers.
        public static long BigMul(int a, int b);
        //
        // Summary:
        //     Produces the full product of two 64-bit numbers.
        //
        // Parameters:
        //   a:
        //     The first number to multiply.
        //
        //   b:
        //     The second number to multiply.
        //
        // Returns:
        //     The full product of the specified numbers.
        public static Int128 BigMul(long a, long b);
        //
        // Summary:
        //     Produces the full product of two unsigned 32-bit numbers.
        //
        // Parameters:
        //   a:
        //     The first number to multiply.
        //
        //   b:
        //     The second number to multiply.
        //
        // Returns:
        //     The number containing the product of the specified numbers.
        [CLSCompliant(false)]
        public static ulong BigMul(uint a, uint b);
        //
        // Summary:
        //     Produces the full product of two unsigned 64-bit numbers.
        //
        // Parameters:
        //   a:
        //     The first number to multiply.
        //
        //   b:
        //     The second number to multiply.
        //
        // Returns:
        //     The full product of the specified numbers.
        [CLSCompliant(false)]
        public static UInt128 BigMul(ulong a, ulong b);
        //
        // Summary:
        //     Produces the full product of two 64-bit numbers.
        //
        // Parameters:
        //   a:
        //     The first number to multiply.
        //
        //   b:
        //     The second number to multiply.
        //
        //   low:
        //     When this method returns, contains the low 64-bit of the product of the specified
        //     numbers.
        //
        // Returns:
        //     The high 64-bit of the product of the specified numbers.
        public static long BigMul(long a, long b, out long low);
        //
        // Summary:
        //     Produces the full product of two unsigned 64-bit numbers.
        //
        // Parameters:
        //   a:
        //     The first number to multiply.
        //
        //   b:
        //     The second number to multiply.
        //
        //   low:
        //     When this method returns, contains the low 64-bit of the product of the specified
        //     numbers.
        //
        // Returns:
        //     The high 64-bit of the product of the specified numbers.
        [CLSCompliant(false)]
        public static ulong BigMul(ulong a, ulong b, out ulong low);
        //
        // Summary:
        //     Returns the largest value that compares less than a specified value.
        //
        // Parameters:
        //   x:
        //     The value to decrement.
        //
        // Returns:
        //     The largest value that compares less than x. -or- System.Double.NegativeInfinity
        //     if x equals System.Double.NegativeInfinity. -or- System.Double.NaN if x equals
        //     System.Double.NaN.
        public static double BitDecrement(double x);
        //
        // Summary:
        //     Returns the smallest value that compares greater than a specified value.
        //
        // Parameters:
        //   x:
        //     The value to increment.
        //
        // Returns:
        //     The smallest value that compares greater than x. -or- System.Double.PositiveInfinity
        //     if x equals System.Double.PositiveInfinity. -or- System.Double.NaN if x equals
        //     System.Double.NaN.
        public static double BitIncrement(double x);
        //
        // Summary:
        //     Returns the cube root of a specified number.
        //
        // Parameters:
        //   d:
        //     The number whose cube root is to be found.
        //
        // Returns:
        //     The cube root of d. -or- System.Double.NaN if d equals System.Double.NaN.
        public static double Cbrt(double d);
        //
        // Summary:
        //     Returns the smallest integral value that is greater than or equal to the specified
        //     decimal number.
        //
        // Parameters:
        //   d:
        //     A decimal number.
        //
        // Returns:
        //     The smallest integral value that is greater than or equal to d. Note that this
        //     method returns a System.Decimal instead of an integral type.
        public static decimal Ceiling(decimal d);
        //
        // Summary:
        //     Returns the smallest integral value that is greater than or equal to the specified
        //     double-precision floating-point number.
        //
        // Parameters:
        //   a:
        //     A double-precision floating-point number.
        //
        // Returns:
        //     The smallest integral value that is greater than or equal to a. If a is equal
        //     to System.Double.NaN, System.Double.NegativeInfinity, or System.Double.PositiveInfinity,
        //     that value is returned. Note that this method returns a System.Double instead
        //     of an integral type.
        public static double Ceiling(double a);
        //
        // Summary:
        //     Returns value clamped to the inclusive range of min and max.
        //
        // Parameters:
        //   value:
        //     The value to be clamped.
        //
        //   min:
        //     The lower bound of the result.
        //
        //   max:
        //     The upper bound of the result.
        //
        // Returns:
        //     value if min ≤ value ≤ max.
        //
        //     -or-
        //
        //     min if value < min.
        //
        //     -or-
        //
        //     max if max < value.
        [CLSCompliant(false)]
        public static nuint Clamp(nuint value, nuint min, nuint max);
        //
        // Summary:
        //     Returns value clamped to the inclusive range of min and max.
        //
        // Parameters:
        //   value:
        //     The value to be clamped.
        //
        //   min:
        //     The lower bound of the result.
        //
        //   max:
        //     The upper bound of the result.
        //
        // Returns:
        //     value if min ≤ value ≤ max. -or- min if value < min. -or- max if max < value.
        [CLSCompliant(false)]
        public static ulong Clamp(ulong value, ulong min, ulong max);
        //
        // Summary:
        //     Returns value clamped to the inclusive range of min and max.
        //
        // Parameters:
        //   value:
        //     The value to be clamped.
        //
        //   min:
        //     The lower bound of the result.
        //
        //   max:
        //     The upper bound of the result.
        //
        // Returns:
        //     value if min ≤ value ≤ max. -or- min if value < min. -or- max if max < value.
        [CLSCompliant(false)]
        public static uint Clamp(uint value, uint min, uint max);
        //
        // Summary:
        //     Returns value clamped to the inclusive range of min and max.
        //
        // Parameters:
        //   value:
        //     The value to be clamped.
        //
        //   min:
        //     The lower bound of the result.
        //
        //   max:
        //     The upper bound of the result.
        //
        // Returns:
        //     value if min ≤ value ≤ max. -or- min if value < min. -or- max if max < value.
        [CLSCompliant(false)]
        public static ushort Clamp(ushort value, ushort min, ushort max);
        //
        // Summary:
        //     Returns value clamped to the inclusive range of min and max.
        //
        // Parameters:
        //   value:
        //     The value to be clamped.
        //
        //   min:
        //     The lower bound of the result.
        //
        //   max:
        //     The upper bound of the result.
        //
        // Returns:
        //     value if min ≤ value ≤ max. -or- min if value < min. -or- max if max < value.
        //     -or- System.Single.NaN if value equals System.Single.NaN.
        public static float Clamp(float value, float min, float max);
        //
        // Summary:
        //     Returns value clamped to the inclusive range of min and max.
        //
        // Parameters:
        //   value:
        //     The value to be clamped.
        //
        //   min:
        //     The lower bound of the result.
        //
        //   max:
        //     The upper bound of the result.
        //
        // Returns:
        //     value if min ≤ value ≤ max. -or- min if value < min. -or- max if max < value.
        [CLSCompliant(false)]
        public static sbyte Clamp(sbyte value, sbyte min, sbyte max);
        //
        // Summary:
        //     Returns value clamped to the inclusive range of min and max.
        //
        // Parameters:
        //   value:
        //     The value to be clamped.
        //
        //   min:
        //     The lower bound of the result.
        //
        //   max:
        //     The upper bound of the result.
        //
        // Returns:
        //     value if min ≤ value ≤ max. -or- min if value <min. -or- max if max < value.
        public static decimal Clamp(decimal value, decimal min, decimal max);
        //
        // Summary:
        //     Returns value clamped to the inclusive range of min and max.
        //
        // Parameters:
        //   value:
        //     The value to be clamped.
        //
        //   min:
        //     The lower bound of the result.
        //
        //   max:
        //     The upper bound of the result.
        //
        // Returns:
        //     value if min ≤ value ≤ max. -or- min if value < min. -or- max if max < value.
        public static long Clamp(long value, long min, long max);
        //
        // Summary:
        //     Returns value clamped to the inclusive range of min and max.
        //
        // Parameters:
        //   value:
        //     The value to be clamped.
        //
        //   min:
        //     The lower bound of the result.
        //
        //   max:
        //     The upper bound of the result.
        //
        // Returns:
        //     value if min ≤ value ≤ max. -or- min if value < min. -or- max if max < value.
        public static int Clamp(int value, int min, int max);
        //
        // Summary:
        //     Returns value clamped to the inclusive range of min and max.
        //
        // Parameters:
        //   value:
        //     The value to be clamped.
        //
        //   min:
        //     The lower bound of the result.
        //
        //   max:
        //     The upper bound of the result.
        //
        // Returns:
        //     value if min ≤ value ≤ max. -or- min if value < min. -or- max if max < value.
        public static short Clamp(short value, short min, short max);
        //
        // Summary:
        //     Returns value clamped to the inclusive range of min and max.
        //
        // Parameters:
        //   value:
        //     The value to be clamped.
        //
        //   min:
        //     The lower bound of the result.
        //
        //   max:
        //     The upper bound of the result.
        //
        // Returns:
        //     value if min ≤ value ≤ max. -or- min if value < min. -or- max if max < value.
        //     -or- System.Double.NaN if value equals System.Double.NaN.
        public static double Clamp(double value, double min, double max);
        //
        // Summary:
        //     Returns value clamped to the inclusive range of min and max.
        //
        // Parameters:
        //   value:
        //     The value to be clamped.
        //
        //   min:
        //     The lower bound of the result.
        //
        //   max:
        //     The upper bound of the result.
        //
        // Returns:
        //     value if min ≤ value ≤ max.
        //
        //     -or-
        //
        //     min if value < min.
        //
        //     -or-
        //
        //     max if max < value.
        public static byte Clamp(byte value, byte min, byte max);
        //
        // Summary:
        //     Returns value clamped to the inclusive range of min and max.
        //
        // Parameters:
        //   value:
        //     The value to be clamped.
        //
        //   min:
        //     The lower bound of the result.
        //
        //   max:
        //     The upper bound of the result.
        //
        // Returns:
        //     value if min ≤ value ≤ max.
        //
        //     -or-
        //
        //     min if value < min.
        //
        //     -or-
        //
        //     max if max < value.
        public static nint Clamp(nint value, nint min, nint max);
        //
        // Summary:
        //     Returns a value with the magnitude of x and the sign of y.
        //
        // Parameters:
        //   x:
        //     A number whose magnitude is used in the result.
        //
        //   y:
        //     A number whose sign is the used in the result.
        //
        // Returns:
        //     A value with the magnitude of x and the sign of y.
        public static double CopySign(double x, double y);
        //
        // Summary:
        //     Returns the cosine of the specified angle.
        //
        // Parameters:
        //   d:
        //     An angle, measured in radians.
        //
        // Returns:
        //     The cosine of d. If d is equal to System.Double.NaN, System.Double.NegativeInfinity,
        //     or System.Double.PositiveInfinity, this method returns System.Double.NaN.
        public static double Cos(double d);
        //
        // Summary:
        //     Returns the hyperbolic cosine of the specified angle.
        //
        // Parameters:
        //   value:
        //     An angle, measured in radians.
        //
        // Returns:
        //     The hyperbolic cosine of value. If value is equal to System.Double.NegativeInfinity
        //     or System.Double.PositiveInfinity, System.Double.PositiveInfinity is returned.
        //     If value is equal to System.Double.NaN, System.Double.NaN is returned.
        public static double Cosh(double value);
        //
        // Summary:
        //     Produces the quotient and the remainder of two unsigned native-size numbers.
        //
        //
        // Parameters:
        //   left:
        //     The dividend.
        //
        //   right:
        //     The divisor.
        //
        // Returns:
        //     The quotient and the remainder of the specified numbers.
        [CLSCompliant(false)]
        [return: TupleElementNames(new[] { "Quotient", "Remainder" })]
        public static (nuint Quotient, nuint Remainder) DivRem(nuint left, nuint right);
        //
        // Summary:
        //     Produces the quotient and the remainder of two unsigned 64-bit numbers.
        //
        // Parameters:
        //   left:
        //     The dividend.
        //
        //   right:
        //     The divisor.
        //
        // Returns:
        //     The quotient and the remainder of the specified numbers.
        [CLSCompliant(false)]
        [return: TupleElementNames(new[] { "Quotient", "Remainder" })]
        public static (ulong Quotient, ulong Remainder) DivRem(ulong left, ulong right);
        //
        // Summary:
        //     Produces the quotient and the remainder of two unsigned 32-bit numbers.
        //
        // Parameters:
        //   left:
        //     The dividend.
        //
        //   right:
        //     The divisor.
        //
        // Returns:
        //     The quotient and the remainder of the specified numbers.
        [CLSCompliant(false)]
        [return: TupleElementNames(new[] { "Quotient", "Remainder" })]
        public static (uint Quotient, uint Remainder) DivRem(uint left, uint right);
        //
        // Summary:
        //     Produces the quotient and the remainder of two unsigned 16-bit numbers.
        //
        // Parameters:
        //   left:
        //     The dividend.
        //
        //   right:
        //     The divisor.
        //
        // Returns:
        //     The quotient and the remainder of the specified numbers.
        [CLSCompliant(false)]
        [return: TupleElementNames(new[] { "Quotient", "Remainder" })]
        public static (ushort Quotient, ushort Remainder) DivRem(ushort left, ushort right);
        //
        // Summary:
        //     Produces the quotient and the remainder of two signed 8-bit numbers.
        //
        // Parameters:
        //   left:
        //     The dividend.
        //
        //   right:
        //     The divisor.
        //
        // Returns:
        //     The quotient and the remainder of the specified numbers.
        [CLSCompliant(false)]
        [return: TupleElementNames(new[] { "Quotient", "Remainder" })]
        public static (sbyte Quotient, sbyte Remainder) DivRem(sbyte left, sbyte right);
        //
        // Summary:
        //     Produces the quotient and the remainder of two signed native-size numbers.
        //
        // Parameters:
        //   left:
        //     The dividend.
        //
        //   right:
        //     The divisor.
        //
        // Returns:
        //     The quotient and the remainder of the specified numbers.
        [return: TupleElementNames(new[] { "Quotient", "Remainder" })]
        public static (nint Quotient, nint Remainder) DivRem(nint left, nint right);
        //
        // Summary:
        //     Calculates the quotient of two 32-bit signed integers and also returns the remainder
        //     in an output parameter.
        //
        // Parameters:
        //   a:
        //     The dividend.
        //
        //   b:
        //     The divisor.
        //
        //   result:
        //     When this method returns, contains the remainder.
        //
        // Returns:
        //     The quotient of the specified numbers.
        //
        // Exceptions:
        //   T:System.DivideByZeroException:
        //     b is zero.
        public static int DivRem(int a, int b, out int result);
        //
        // Summary:
        //     Produces the quotient and the remainder of two signed 64-bit numbers.
        //
        // Parameters:
        //   left:
        //     The dividend.
        //
        //   right:
        //     The divisor.
        //
        // Returns:
        //     The quotient and the remainder of the specified numbers.
        [return: TupleElementNames(new[] { "Quotient", "Remainder" })]
        public static (long Quotient, long Remainder) DivRem(long left, long right);
        //
        // Summary:
        //     Produces the quotient and the remainder of two signed 32-bit numbers.
        //
        // Parameters:
        //   left:
        //     The dividend.
        //
        //   right:
        //     The divisor.
        //
        // Returns:
        //     The quotient and the remainder of the specified numbers.
        [return: TupleElementNames(new[] { "Quotient", "Remainder" })]
        public static (int Quotient, int Remainder) DivRem(int left, int right);
        //
        // Summary:
        //     Produces the quotient and the remainder of two signed 16-bit numbers.
        //
        // Parameters:
        //   left:
        //     The dividend.
        //
        //   right:
        //     The divisor.
        //
        // Returns:
        //     The quotient and the remainder of the specified numbers.
        [return: TupleElementNames(new[] { "Quotient", "Remainder" })]
        public static (short Quotient, short Remainder) DivRem(short left, short right);
        //
        // Summary:
        //     Produces the quotient and the remainder of two unsigned 8-bit numbers.
        //
        // Parameters:
        //   left:
        //     The dividend.
        //
        //   right:
        //     The divisor.
        //
        // Returns:
        //     The quotient and the remainder of the specified numbers.
        [return: TupleElementNames(new[] { "Quotient", "Remainder" })]
        public static (byte Quotient, byte Remainder) DivRem(byte left, byte right);
        //
        // Summary:
        //     Calculates the quotient of two 64-bit signed integers and also returns the remainder
        //     in an output parameter.
        //
        // Parameters:
        //   a:
        //     The dividend.
        //
        //   b:
        //     The divisor.
        //
        //   result:
        //     When this method returns, contains the remainder.
        //
        // Returns:
        //     The quotient of the specified numbers.
        //
        // Exceptions:
        //   T:System.DivideByZeroException:
        //     b is zero.
        public static long DivRem(long a, long b, out long result);
        //
        // Summary:
        //     Returns e raised to the specified power.
        //
        // Parameters:
        //   d:
        //     A number specifying a power.
        //
        // Returns:
        //     The number e raised to the power d. If d equals System.Double.NaN or System.Double.PositiveInfinity,
        //     that value is returned. If d equals System.Double.NegativeInfinity, 0 is returned.
        public static double Exp(double d);
        //
        // Summary:
        //     Returns the largest integral value less than or equal to the specified double-precision
        //     floating-point number.
        //
        // Parameters:
        //   d:
        //     A double-precision floating-point number.
        //
        // Returns:
        //     The largest integral value less than or equal to d. If d is equal to System.Double.NaN,
        //     System.Double.NegativeInfinity, or System.Double.PositiveInfinity, that value
        //     is returned.
        public static double Floor(double d);
        //
        // Summary:
        //     Returns the largest integral value less than or equal to the specified decimal
        //     number.
        //
        // Parameters:
        //   d:
        //     A decimal number.
        //
        // Returns:
        //     The largest integral value less than or equal to d. Note that the method returns
        //     an integral value of type System.Decimal.
        public static decimal Floor(decimal d);
        //
        // Summary:
        //     Returns (x * y) + z, rounded as one ternary operation.
        //
        // Parameters:
        //   x:
        //     The number to be multiplied with y.
        //
        //   y:
        //     The number to be multiplied with x.
        //
        //   z:
        //     The number to be added to the result of x multiplied by y.
        //
        // Returns:
        //     (x * y) + z, rounded as one ternary operation.
        public static double FusedMultiplyAdd(double x, double y, double z);
        //
        // Summary:
        //     Returns the remainder resulting from the division of a specified number by another
        //     specified number.
        //
        // Parameters:
        //   x:
        //     A dividend.
        //
        //   y:
        //     A divisor.
        //
        // Returns:
        //     A number equal to x - (y Q), where Q is the quotient of x / y rounded to the
        //     nearest integer (if x / y falls halfway between two integers, the even integer
        //     is returned). If x - (y Q) is zero, the value +0 is returned if x is positive,
        //     or -0 if x is negative. If y = 0, System.Double.NaN is returned.
        public static double IEEERemainder(double x, double y);
        //
        // Summary:
        //     Returns the base 2 integer logarithm of a specified number.
        //
        // Parameters:
        //   x:
        //     The number whose logarithm is to be found.
        //
        // Returns:
        //     One of the values in the following table.
        //
        //     x parameter – Return value
        //     Default – The base 2 integer log of x; that is, (int)log2(x).
        //     Zero –Int32.MinValue
        //     Equal to System.Double.NaN or System.Double.PositiveInfinity or System.Double.NegativeInfinity
        //     –Int32.MaxValue
        public static int ILogB(double x);
        //
        // Summary:
        //     Returns the natural (base e) logarithm of a specified number.
        //
        // Parameters:
        //   d:
        //     The number whose logarithm is to be found.
        //
        // Returns:
        //     One of the values in the following table.
        //
        //     d parameter – Return value
        //     Positive – The natural logarithm of d; that is, ln d, or log e d
        //     Zero –System.Double.NegativeInfinity
        //     Negative –System.Double.NaN
        //     Equal to System.Double.NaN –System.Double.NaN
        //     Equal to System.Double.PositiveInfinity –System.Double.PositiveInfinity
        public static double Log(double d);
        //
        // Summary:
        //     Returns the logarithm of a specified number in a specified base.
        //
        // Parameters:
        //   a:
        //     The number whose logarithm is to be found.
        //
        //   newBase:
        //     The base of the logarithm.
        //
        // Returns:
        //     One of the values in the following table. (+Infinity denotes System.Double.PositiveInfinity,
        //     -Infinity denotes System.Double.NegativeInfinity, and NaN denotes System.Double.NaN.)
        //
        //
        //     a –newBase Return value
        //     a> 0 – (0 <newBase< 1) -or- (newBase> 1) lognewBase(a)
        //     a< 0 – (any value) NaN
        //     (any value) –newBase< 0 NaN
        //     a != 1 –newBase = 0 NaN
        //     a != 1 –newBase = +Infinity NaN
        //     a = NaN – (any value) NaN
        //     (any value) –newBase = NaN NaN
        //     (any value) –newBase = 1 NaN
        //     a = 0 – 0 <newBase< 1 +Infinity
        //     a = 0 –newBase> 1 -Infinity
        //     a = +Infinity – 0 <newBase< 1 -Infinity
        //     a = +Infinity –newBase> 1 +Infinity
        //     a = 1 –newBase = 0 0
        //     a = 1 –newBase = +Infinity 0
        public static double Log(double a, double newBase);
        //
        // Summary:
        //     Returns the base 10 logarithm of a specified number.
        //
        // Parameters:
        //   d:
        //     A number whose logarithm is to be found.
        //
        // Returns:
        //     One of the values in the following table.
        //
        //     d parameter – Return value
        //     Positive – The base 10 log of d; that is, log 10d.
        //     Zero –System.Double.NegativeInfinity
        //     Negative –System.Double.NaN
        //     Equal to System.Double.NaN –System.Double.NaN
        //     Equal to System.Double.PositiveInfinity –System.Double.PositiveInfinity
        public static double Log10(double d);
        //
        // Summary:
        //     Returns the base 2 logarithm of a specified number.
        //
        // Parameters:
        //   x:
        //     A number whose logarithm is to be found.
        //
        // Returns:
        //     One of the values in the following table.
        //
        //     x parameter – Return value
        //     Positive – The base 2 log of x; that is, log 2x.
        //     Zero –System.Double.NegativeInfinity
        //     Negative –System.Double.NaN
        //     Equal to System.Double.NaN –System.Double.NaN
        //     Equal to System.Double.PositiveInfinity –System.Double.PositiveInfinity
        public static double Log2(double x);
        //
        // Summary:
        //     Returns the larger of two native unsigned integers.
        //
        // Parameters:
        //   val1:
        //     The first of two native unsigned integers to compare.
        //
        //   val2:
        //     The second of two native unsigned integers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is larger.
        [CLSCompliant(false)]
        public static nuint Max(nuint val1, nuint val2);
        //
        // Summary:
        //     Returns the larger of two 64-bit unsigned integers.
        //
        // Parameters:
        //   val1:
        //     The first of two 64-bit unsigned integers to compare.
        //
        //   val2:
        //     The second of two 64-bit unsigned integers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is larger.
        [CLSCompliant(false)]
        public static ulong Max(ulong val1, ulong val2);
        //
        // Summary:
        //     Returns the larger of two 32-bit unsigned integers.
        //
        // Parameters:
        //   val1:
        //     The first of two 32-bit unsigned integers to compare.
        //
        //   val2:
        //     The second of two 32-bit unsigned integers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is larger.
        [CLSCompliant(false)]
        public static uint Max(uint val1, uint val2);
        //
        // Summary:
        //     Returns the larger of two 16-bit unsigned integers.
        //
        // Parameters:
        //   val1:
        //     The first of two 16-bit unsigned integers to compare.
        //
        //   val2:
        //     The second of two 16-bit unsigned integers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is larger.
        [CLSCompliant(false)]
        public static ushort Max(ushort val1, ushort val2);
        //
        // Summary:
        //     Returns the larger of two single-precision floating-point numbers.
        //
        // Parameters:
        //   val1:
        //     The first of two single-precision floating-point numbers to compare.
        //
        //   val2:
        //     The second of two single-precision floating-point numbers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is larger. If val1, or val2, or both val1 and
        //     val2 are equal to System.Single.NaN, System.Single.NaN is returned.
        public static float Max(float val1, float val2);
        //
        // Summary:
        //     Returns the larger of two native signed integers.
        //
        // Parameters:
        //   val1:
        //     The first of two native signed integers to compare.
        //
        //   val2:
        //     The second of two native signed integers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is larger.
        public static nint Max(nint val1, nint val2);
        //
        // Summary:
        //     Returns the larger of two 8-bit signed integers.
        //
        // Parameters:
        //   val1:
        //     The first of two 8-bit signed integers to compare.
        //
        //   val2:
        //     The second of two 8-bit signed integers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is larger.
        [CLSCompliant(false)]
        public static sbyte Max(sbyte val1, sbyte val2);
        //
        // Summary:
        //     Returns the larger of two 32-bit signed integers.
        //
        // Parameters:
        //   val1:
        //     The first of two 32-bit signed integers to compare.
        //
        //   val2:
        //     The second of two 32-bit signed integers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is larger.
        public static int Max(int val1, int val2);
        //
        // Summary:
        //     Returns the larger of two 16-bit signed integers.
        //
        // Parameters:
        //   val1:
        //     The first of two 16-bit signed integers to compare.
        //
        //   val2:
        //     The second of two 16-bit signed integers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is larger.
        public static short Max(short val1, short val2);
        //
        // Summary:
        //     Returns the larger of two double-precision floating-point numbers.
        //
        // Parameters:
        //   val1:
        //     The first of two double-precision floating-point numbers to compare.
        //
        //   val2:
        //     The second of two double-precision floating-point numbers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is larger. If val1, val2, or both val1 and
        //     val2 are equal to System.Double.NaN, System.Double.NaN is returned.
        public static double Max(double val1, double val2);
        //
        // Summary:
        //     Returns the larger of two decimal numbers.
        //
        // Parameters:
        //   val1:
        //     The first of two decimal numbers to compare.
        //
        //   val2:
        //     The second of two decimal numbers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is larger.
        public static decimal Max(decimal val1, decimal val2);
        //
        // Summary:
        //     Returns the larger of two 8-bit unsigned integers.
        //
        // Parameters:
        //   val1:
        //     The first of two 8-bit unsigned integers to compare.
        //
        //   val2:
        //     The second of two 8-bit unsigned integers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is larger.
        public static byte Max(byte val1, byte val2);
        //
        // Summary:
        //     Returns the larger of two 64-bit signed integers.
        //
        // Parameters:
        //   val1:
        //     The first of two 64-bit signed integers to compare.
        //
        //   val2:
        //     The second of two 64-bit signed integers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is larger.
        public static long Max(long val1, long val2);
        //
        // Summary:
        //     Returns the larger magnitude of two double-precision floating-point numbers.
        //
        //
        // Parameters:
        //   x:
        //     The first of two double-precision floating-point numbers to compare.
        //
        //   y:
        //     The second of two double-precision floating-point numbers to compare.
        //
        // Returns:
        //     Parameter x or y, whichever has the larger magnitude. If x, or y, or both x and
        //     y are equal to System.Double.NaN, System.Double.NaN is returned.
        public static double MaxMagnitude(double x, double y);
        //
        // Summary:
        //     Returns the smaller of two 8-bit signed integers.
        //
        // Parameters:
        //   val1:
        //     The first of two 8-bit signed integers to compare.
        //
        //   val2:
        //     The second of two 8-bit signed integers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is smaller.
        [CLSCompliant(false)]
        public static sbyte Min(sbyte val1, sbyte val2);
        //
        // Summary:
        //     Returns the smaller of two native unsigned integers.
        //
        // Parameters:
        //   val1:
        //     The first of two native unsigned integers to compare.
        //
        //   val2:
        //     The second of two native unsigned integers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is smaller.
        [CLSCompliant(false)]
        public static nuint Min(nuint val1, nuint val2);
        //
        // Summary:
        //     Returns the smaller of two 32-bit unsigned integers.
        //
        // Parameters:
        //   val1:
        //     The first of two 32-bit unsigned integers to compare.
        //
        //   val2:
        //     The second of two 32-bit unsigned integers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is smaller.
        [CLSCompliant(false)]
        public static uint Min(uint val1, uint val2);
        //
        // Summary:
        //     Returns the smaller of two 16-bit unsigned integers.
        //
        // Parameters:
        //   val1:
        //     The first of two 16-bit unsigned integers to compare.
        //
        //   val2:
        //     The second of two 16-bit unsigned integers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is smaller.
        [CLSCompliant(false)]
        public static ushort Min(ushort val1, ushort val2);
        //
        // Summary:
        //     Returns the smaller of two single-precision floating-point numbers.
        //
        // Parameters:
        //   val1:
        //     The first of two single-precision floating-point numbers to compare.
        //
        //   val2:
        //     The second of two single-precision floating-point numbers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is smaller. If val1, val2, or both val1 and
        //     val2 are equal to System.Single.NaN, System.Single.NaN is returned.
        public static float Min(float val1, float val2);
        //
        // Summary:
        //     Returns the smaller of two native signed integers.
        //
        // Parameters:
        //   val1:
        //     The first of two native signed integers to compare.
        //
        //   val2:
        //     The second of two native signed integers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is smaller.
        public static nint Min(nint val1, nint val2);
        //
        // Summary:
        //     Returns the smaller of two 64-bit unsigned integers.
        //
        // Parameters:
        //   val1:
        //     The first of two 64-bit unsigned integers to compare.
        //
        //   val2:
        //     The second of two 64-bit unsigned integers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is smaller.
        [CLSCompliant(false)]
        public static ulong Min(ulong val1, ulong val2);
        //
        // Summary:
        //     Returns the smaller of two 32-bit signed integers.
        //
        // Parameters:
        //   val1:
        //     The first of two 32-bit signed integers to compare.
        //
        //   val2:
        //     The second of two 32-bit signed integers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is smaller.
        public static int Min(int val1, int val2);
        //
        // Summary:
        //     Returns the smaller of two 16-bit signed integers.
        //
        // Parameters:
        //   val1:
        //     The first of two 16-bit signed integers to compare.
        //
        //   val2:
        //     The second of two 16-bit signed integers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is smaller.
        public static short Min(short val1, short val2);
        //
        // Summary:
        //     Returns the smaller of two double-precision floating-point numbers.
        //
        // Parameters:
        //   val1:
        //     The first of two double-precision floating-point numbers to compare.
        //
        //   val2:
        //     The second of two double-precision floating-point numbers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is smaller. If val1, val2, or both val1 and
        //     val2 are equal to System.Double.NaN, System.Double.NaN is returned.
        public static double Min(double val1, double val2);
        //
        // Summary:
        //     Returns the smaller of two decimal numbers.
        //
        // Parameters:
        //   val1:
        //     The first of two decimal numbers to compare.
        //
        //   val2:
        //     The second of two decimal numbers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is smaller.
        public static decimal Min(decimal val1, decimal val2);
        //
        // Summary:
        //     Returns the smaller of two 64-bit signed integers.
        //
        // Parameters:
        //   val1:
        //     The first of two 64-bit signed integers to compare.
        //
        //   val2:
        //     The second of two 64-bit signed integers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is smaller.
        public static long Min(long val1, long val2);
        //
        // Summary:
        //     Returns the smaller of two 8-bit unsigned integers.
        //
        // Parameters:
        //   val1:
        //     The first of two 8-bit unsigned integers to compare.
        //
        //   val2:
        //     The second of two 8-bit unsigned integers to compare.
        //
        // Returns:
        //     Parameter val1 or val2, whichever is smaller.
        public static byte Min(byte val1, byte val2);
        //
        // Summary:
        //     Returns the smaller magnitude of two double-precision floating-point numbers.
        //
        //
        // Parameters:
        //   x:
        //     The first of two double-precision floating-point numbers to compare.
        //
        //   y:
        //     The second of two double-precision floating-point numbers to compare.
        //
        // Returns:
        //     Parameter x or y, whichever has the smaller magnitude. If x, or y, or both x
        //     and y are equal to System.Double.NaN, System.Double.NaN is returned.
        public static double MinMagnitude(double x, double y);
        //
        // Summary:
        //     Returns a specified number raised to the specified power.
        //
        // Parameters:
        //   x:
        //     A double-precision floating-point number to be raised to a power.
        //
        //   y:
        //     A double-precision floating-point number that specifies a power.
        //
        // Returns:
        //     The number x raised to the power y.
        public static double Pow(double x, double y);
        //
        // Summary:
        //     Returns an estimate of the reciprocal of a specified number.
        //
        // Parameters:
        //   d:
        //     The number whose reciprocal is to be estimated.
        //
        // Returns:
        //     An estimate of the reciprocal of d.
        public static double ReciprocalEstimate(double d);
        //
        // Summary:
        //     Returns an estimate of the reciprocal square root of a specified number.
        //
        // Parameters:
        //   d:
        //     The number whose reciprocal square root is to be estimated.
        //
        // Returns:
        //     An estimate of the reciprocal square root d.
        public static double ReciprocalSqrtEstimate(double d);
        //
        // Summary:
        //     Rounds a double-precision floating-point value to a specified number of fractional
        //     digits using the specified rounding convention.
        //
        // Parameters:
        //   value:
        //     A double-precision floating-point number to be rounded.
        //
        //   digits:
        //     The number of fractional digits in the return value.
        //
        //   mode:
        //     One of the enumeration values that specifies which rounding strategy to use.
        //
        //
        // Returns:
        //     The number that has digits fractional digits that value is rounded to. If value
        //     has fewer fractional digits than digits, value is returned unchanged.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     digits is less than 0 or greater than 15.
        //
        //   T:System.ArgumentException:
        //     mode is not a valid value of System.MidpointRounding.
        public static double Round(double value, int digits, MidpointRounding mode);
        //
        // Summary:
        //     Rounds a double-precision floating-point value to a specified number of fractional
        //     digits, and rounds midpoint values to the nearest even number.
        //
        // Parameters:
        //   value:
        //     A double-precision floating-point number to be rounded.
        //
        //   digits:
        //     The number of fractional digits in the return value.
        //
        // Returns:
        //     The number nearest to value that contains a number of fractional digits equal
        //     to digits.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     digits is less than 0 or greater than 15.
        public static double Round(double value, int digits);
        //
        // Summary:
        //     Rounds a double-precision floating-point value to the nearest integral value,
        //     and rounds midpoint values to the nearest even number.
        //
        // Parameters:
        //   a:
        //     A double-precision floating-point number to be rounded.
        //
        // Returns:
        //     The integer nearest a. If the fractional component of a is halfway between two
        //     integers, one of which is even and the other odd, then the even number is returned.
        //     Note that this method returns a System.Double instead of an integral type.
        public static double Round(double a);
        //
        // Summary:
        //     Rounds a double-precision floating-point value to an integer using the specified
        //     rounding convention.
        //
        // Parameters:
        //   value:
        //     A double-precision floating-point number to be rounded.
        //
        //   mode:
        //     One of the enumeration values that specifies which rounding strategy to use.
        //
        //
        // Returns:
        //     The integer that value is rounded to. This method returns a System.Double instead
        //     of an integral type.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     mode is not a valid value of System.MidpointRounding.
        public static double Round(double value, MidpointRounding mode);
        //
        // Summary:
        //     Rounds a decimal value to a specified number of fractional digits using the specified
        //     rounding convention.
        //
        // Parameters:
        //   d:
        //     A decimal number to be rounded.
        //
        //   decimals:
        //     The number of decimal places in the return value.
        //
        //   mode:
        //     One of the enumeration values that specifies which rounding strategy to use.
        //
        //
        // Returns:
        //     The number with decimals fractional digits that d is rounded to. If d has fewer
        //     fractional digits than decimals, d is returned unchanged.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     decimals is less than 0 or greater than 28.
        //
        //   T:System.ArgumentException:
        //     mode is not a valid value of System.MidpointRounding.
        //
        //   T:System.OverflowException:
        //     The result is outside the range of a System.Decimal.
        public static decimal Round(decimal d, int decimals, MidpointRounding mode);
        //
        // Summary:
        //     Rounds a decimal value to a specified number of fractional digits, and rounds
        //     midpoint values to the nearest even number.
        //
        // Parameters:
        //   d:
        //     A decimal number to be rounded.
        //
        //   decimals:
        //     The number of decimal places in the return value.
        //
        // Returns:
        //     The number nearest to d that contains a number of fractional digits equal to
        //     decimals.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     decimals is less than 0 or greater than 28.
        //
        //   T:System.OverflowException:
        //     The result is outside the range of a System.Decimal.
        public static decimal Round(decimal d, int decimals);
        //
        // Summary:
        //     Rounds a decimal value to the nearest integral value, and rounds midpoint values
        //     to the nearest even number.
        //
        // Parameters:
        //   d:
        //     A decimal number to be rounded.
        //
        // Returns:
        //     The integer nearest the d parameter. If the fractional component of d is halfway
        //     between two integers, one of which is even and the other odd, the even number
        //     is returned. Note that this method returns a System.Decimal instead of an integral
        //     type.
        //
        // Exceptions:
        //   T:System.OverflowException:
        //     The result is outside the range of a System.Decimal.
        public static decimal Round(decimal d);
        //
        // Summary:
        //     Rounds a decimal value an integer using the specified rounding convention.
        //
        // Parameters:
        //   d:
        //     A decimal number to be rounded.
        //
        //   mode:
        //     One of the enumeration values that specifies which rounding strategy to use.
        //
        //
        // Returns:
        //     The integer that d is rounded to. This method returns a System.Decimal instead
        //     of an integral type.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     mode is not a valid value of System.MidpointRounding.
        //
        //   T:System.OverflowException:
        //     The result is outside the range of a System.Decimal.
        public static decimal Round(decimal d, MidpointRounding mode);
        //
        // Summary:
        //     Returns x * 2^n computed efficiently.
        //
        // Parameters:
        //   x:
        //     A double-precision floating-point number that specifies the base value.
        //
        //   n:
        //     A 32-bit integer that specifies the power.
        //
        // Returns:
        //     x * 2^n computed efficiently.
        public static double ScaleB(double x, int n);
        //
        // Summary:
        //     Returns an integer that indicates the sign of a single-precision floating-point
        //     number.
        //
        // Parameters:
        //   value:
        //     A signed number.
        //
        // Returns:
        //     A number that indicates the sign of value, as shown in the following table.
        //
        //     Return value – Meaning
        //     -1 –value is less than zero.
        //     0 –value is equal to zero.
        //     1 –value is greater than zero.
        //
        // Exceptions:
        //   T:System.ArithmeticException:
        //     value is equal to System.Single.NaN.
        public static int Sign(float value);
        //
        // Summary:
        //     Returns an integer that indicates the sign of an 8-bit signed integer.
        //
        // Parameters:
        //   value:
        //     A signed number.
        //
        // Returns:
        //     A number that indicates the sign of value, as shown in the following table.
        //
        //     Return value – Meaning
        //     -1 –value is less than zero.
        //     0 –value is equal to zero.
        //     1 –value is greater than zero.
        [CLSCompliant(false)]
        public static int Sign(sbyte value);
        //
        // Summary:
        //     Returns an integer that indicates the sign of a 64-bit signed integer.
        //
        // Parameters:
        //   value:
        //     A signed number.
        //
        // Returns:
        //     A number that indicates the sign of value, as shown in the following table.
        //
        //     Return value – Meaning
        //     -1 –value is less than zero.
        //     0 –value is equal to zero.
        //     1 –value is greater than zero.
        public static int Sign(long value);
        //
        // Summary:
        //     Returns an integer that indicates the sign of a native sized signed integer.
        //
        //
        // Parameters:
        //   value:
        //     A signed number.
        //
        // Returns:
        //     A number that indicates the sign of value, as shown in the following table.
        //
        //     Return value – Meaning
        //     -1 –value is less than zero.
        //     0 –value is equal to zero.
        //     1 –value is greater than zero.
        public static int Sign(nint value);
        //
        // Summary:
        //     Returns an integer that indicates the sign of a 16-bit signed integer.
        //
        // Parameters:
        //   value:
        //     A signed number.
        //
        // Returns:
        //     A number that indicates the sign of value, as shown in the following table.
        //
        //     Return value – Meaning
        //     -1 –value is less than zero.
        //     0 –value is equal to zero.
        //     1 –value is greater than zero.
        public static int Sign(short value);
        //
        // Summary:
        //     Returns an integer that indicates the sign of a double-precision floating-point
        //     number.
        //
        // Parameters:
        //   value:
        //     A signed number.
        //
        // Returns:
        //     A number that indicates the sign of value, as shown in the following table.
        //
        //     Return value – Meaning
        //     -1 –value is less than zero.
        //     0 –value is equal to zero.
        //     1 –value is greater than zero.
        //
        // Exceptions:
        //   T:System.ArithmeticException:
        //     value is equal to System.Double.NaN.
        public static int Sign(double value);
        //
        // Summary:
        //     Returns an integer that indicates the sign of a decimal number.
        //
        // Parameters:
        //   value:
        //     A signed decimal number.
        //
        // Returns:
        //     A number that indicates the sign of value, as shown in the following table.
        //
        //     Return value – Meaning
        //     -1 –value is less than zero.
        //     0 –value is equal to zero.
        //     1 –value is greater than zero.
        public static int Sign(decimal value);
        //
        // Summary:
        //     Returns an integer that indicates the sign of a 32-bit signed integer.
        //
        // Parameters:
        //   value:
        //     A signed number.
        //
        // Returns:
        //     A number that indicates the sign of value, as shown in the following table.
        //
        //     Return value – Meaning
        //     -1 –value is less than zero.
        //     0 –value is equal to zero.
        //     1 –value is greater than zero.
        public static int Sign(int value);
        //
        // Summary:
        //     Returns the sine of the specified angle.
        //
        // Parameters:
        //   a:
        //     An angle, measured in radians.
        //
        // Returns:
        //     The sine of a. If a is equal to System.Double.NaN, System.Double.NegativeInfinity,
        //     or System.Double.PositiveInfinity, this method returns System.Double.NaN.
        public static double Sin(double a);
        //
        // Summary:
        //     Returns the sine and cosine of the specified angle.
        //
        // Parameters:
        //   x:
        //     An angle, measured in radians.
        //
        // Returns:
        //     The sine and cosine of x. If x is equal to System.Double.NaN, System.Double.NegativeInfinity,
        //     or System.Double.PositiveInfinity, this method returns System.Double.NaN.
        [return: TupleElementNames(new[] { "Sin", "Cos" })]
        public static (double Sin, double Cos) SinCos(double x);
        //
        // Summary:
        //     Returns the hyperbolic sine of the specified angle.
        //
        // Parameters:
        //   value:
        //     An angle, measured in radians.
        //
        // Returns:
        //     The hyperbolic sine of value. If value is equal to System.Double.NegativeInfinity,
        //     System.Double.PositiveInfinity, or System.Double.NaN, this method returns a System.Double
        //     equal to value.
        public static double Sinh(double value);
        //
        // Summary:
        //     Returns the square root of a specified number.
        //
        // Parameters:
        //   d:
        //     The number whose square root is to be found.
        //
        // Returns:
        //     One of the values in the following table.
        //
        //     d parameter – Return value
        //     Zero or positive – The positive square root of d.
        //     Negative –System.Double.NaN
        //     Equals System.Double.NaN –System.Double.NaN
        //     Equals System.Double.PositiveInfinity –System.Double.PositiveInfinity
        public static double Sqrt(double d);
        //
        // Summary:
        //     Returns the tangent of the specified angle.
        //
        // Parameters:
        //   a:
        //     An angle, measured in radians.
        //
        // Returns:
        //     The tangent of a. If a is equal to System.Double.NaN, System.Double.NegativeInfinity,
        //     or System.Double.PositiveInfinity, this method returns System.Double.NaN.
        public static double Tan(double a);
        //
        // Summary:
        //     Returns the hyperbolic tangent of the specified angle.
        //
        // Parameters:
        //   value:
        //     An angle, measured in radians.
        //
        // Returns:
        //     The hyperbolic tangent of value. If value is equal to System.Double.NegativeInfinity,
        //     this method returns -1. If value is equal to System.Double.PositiveInfinity,
        //     this method returns 1. If value is equal to System.Double.NaN, this method returns
        //     System.Double.NaN.
        public static double Tanh(double value);
        //
        // Summary:
        //     Calculates the integral part of a specified decimal number.
        //
        // Parameters:
        //   d:
        //     A number to truncate.
        //
        // Returns:
        //     The integral part of d; that is, the number that remains after any fractional
        //     digits have been discarded.
        public static decimal Truncate(decimal d);
        //
        // Summary:
        //     Calculates the integral part of a specified double-precision floating-point number.
        //
        //
        // Parameters:
        //   d:
        //     A number to truncate.
        //
        // Returns:
        //     The integral part of d; that is, the number that remains after any fractional
        //     digits have been discarded, or one of the values listed in the following table.
        //
        //
        //     d – Return value
        //     System.Double.NaN –System.Double.NaN
        //     System.Double.NegativeInfinity –System.Double.NegativeInfinity
        //     System.Double.PositiveInfinity –System.Double.PositiveInfinity
        public static double Truncate(double d);
    }
}