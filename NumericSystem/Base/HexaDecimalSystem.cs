using System;

namespace NumericSystem.Base
{
    /// <summary>Class that represent the hexadecimal number system</summary> 
    public class HexaDecimalSystem : Base
    {
        /// <summary>
        /// Initializes a new instance of the Metigator.NumberSystem.Models.HexadecimalSystem class to the value indicated
        /// by a specified string parameter
        /// </summary>
        /// <param name="value">
        /// string that hold the value of the Hexadecimal system Instance
        /// </param>
        public HexaDecimalSystem(string value)// Valid value = 0123456789ABCDEF
        {
            value.ToUpper().Guard("0123456789ABCDEF", NumericKinds.HEXADECIMAL);
            this.Value = value;
        }
    }
}
