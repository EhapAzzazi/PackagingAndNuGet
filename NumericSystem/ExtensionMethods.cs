namespace NumericSystem.Base
{
    /// <summary>
    /// Class that contains extension methods to convert number from one base to another</summary> 
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Guard to validate ser input 
        /// </summary>
        /// <param name="source">
        /// the string to validate
        /// </param>
        /// <param name="allowedchars">
        /// The Allowed Character set as a string value
        /// </param>
        /// <param name="kind">
        /// This parameter helps identifying which number system input violate the rules
        /// </param> 
        /// <exception cref="System.InvalidOperationException">
        /// Thrown when <paramref name="source" has at least one character that does not exist in the characters of  <paramref name="allowedchars"/>
        /// </exception>
        public static void Guard (this string source, string allowedchars, NumericKinds kind)
        {
            foreach (char letter in source)
            {
                if(!allowedchars.Contains(letter))
                    throw new InvalidOperationException($"this {letter} at [{source}] is not compitable with {kind} System."); 
            }
        }

        /// <summary>
        /// Extension Method to convert the decimal value of <paramref name="source"/> to <paramref name="toBase"/> 
        /// </summary> 
        /// <param name="source">
        /// Number system Instance to convert
        /// </param> 
        /// <returns>A string value as a result of conversion from decimal system to binary</returns>
        public static string ToBinary(this Base source) => source.To(NumericKinds.BINARY);

        /// <summary>
        /// Extension Method to convert the decimal value of <paramref name="source"/> to <paramref name="toBase"/> 
        /// </summary> 
        /// <param name="source">
        /// Number system Instance to convert
        /// </param> 
        /// <returns>A string value as a result of conversion from decimal system to octal</returns>
        public static string ToOctal(this Base source) => source.To(NumericKinds.OCTAL);

        /// <summary>
        /// Extension Method to convert the decimal value of <paramref name="source"/> to <paramref name="toBase"/> 
        /// </summary> 
        /// <param name="source">
        /// Number system Instance to convert
        /// </param> 
        /// <returns>A string value as a result of conversion from decimal system to hexadecimal</returns>
        public static string ToHexaDecimal(this Base source) => source.To(NumericKinds.HEXADECIMAL);

        /// <summary>
        /// Extension Method to convert the hexadecimal value of <paramref name="source"/> to <paramref name="toBase"/> 
        /// </summary> 
        /// <param name="source">
        /// Number system Instance to convert
        /// </param> 
        /// <returns>A string value as a result of conversion from hexadecimal system to decimal</returns>
        public static string ToDecimal(this Base source) => source.To(NumericKinds.DECIMAL);

        /// <summary>
        /// Extension Method to convert <typeparamref name="T"/><paramref name="source"/> to <paramref name="toBase"/> 
        /// </summary> 
        /// <param name="source">
        /// Number system Instance to convert
        /// </param>
        /// <param name="toBase">
        /// enum value that represent the number system
        /// </param> 
        /// <returns>A string value as a result of conversion</returns>
        public static string To<T>(this T source, NumericKinds tokind) where T: Base
        {
            NumericKinds fromkind;
            switch (source) // Source.Value
            {
                case BinarySystem: fromkind = NumericKinds.BINARY; break;
                case OctalSystem: fromkind = NumericKinds.OCTAL; break;
                case DecimalSystem: fromkind = NumericKinds.DECIMAL; break;
                case HexaDecimalSystem: fromkind = NumericKinds.HEXADECIMAL; break;
                default: fromkind = NumericKinds.DECIMAL;  break;
            }
            return Convert.ToString(Convert.ToInt32(source.Value, (int)(fromkind)), (int)(tokind)).ToUpper();
            // 1- القيمة اللي انت دخلتها ف الاول بتدخل على ToInt32 
            // علشان يحولها من الشكل اللي انت اديتهوله سواء 
            // Binary - Decimal - HexaDecimal - Octal
            // لـ Primitive Integer Value 
            // 2- بعد العملية الاولى وانه بقى Integar
            // القيمة دي بتدخل ع ToString علشان يحولها من ال Integar للشكل اللي انت حددته ف To(NumericKinds.Binary) مثلا
            // ف الاخر بيطلعلك بالشكل اللي انت طلبته
        }
    }
}