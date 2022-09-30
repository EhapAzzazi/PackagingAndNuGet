namespace NumericSystem.Base
{
    /// <summary>
    /// Class that act as the base class for all number system
    /// </summary>
    public abstract class Base
    {
        /// <summary>
        /// The Value property represents a Value that needs to be converted
        /// for this instance.
        /// </summary>
        public string? Value { get; protected set; }   
    }
}
