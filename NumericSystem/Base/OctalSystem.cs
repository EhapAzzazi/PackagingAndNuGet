namespace NumericSystem.Base
{
    /// <summary>Class that represent the octal number system</summary> 
    public class OctalSystem : Base
    {
        /// <summary>
        /// Initializes a new instance of the Metigator.NumberSystem.Models.OctalSystem class to the value indicated
        ///    by a specified string parameter
        /// </summary> 
        /// <param name="value">
        /// string that hold the value of the Octal system Instance
        /// </param>  
        public OctalSystem(string value) // Valid value = 01234567
        {
            value.Guard("01234567", NumericKinds.OCTAL);
            this.Value = value;
        }
    }
}
