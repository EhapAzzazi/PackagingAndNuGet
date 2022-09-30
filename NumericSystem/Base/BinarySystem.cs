namespace NumericSystem.Base
{
    /// <summary>Class that represent the binary number system</summary> 
    public class BinarySystem : Base
    {
        /// <summary>
        /// Initializes a new instance of the Metigator.NumberSystem.Models.BinarySystem class to the value indicated
        ///     by a specified string parameter
        /// </summary> 
        /// <param name="value">
        /// string that hold the value of the Binary system Instance
        /// </param>  
        public BinarySystem(string value) //Valid value = 01
        {
            value.Guard("01", NumericKinds.BINARY);
            this.Value = value;
        }
    }
}
