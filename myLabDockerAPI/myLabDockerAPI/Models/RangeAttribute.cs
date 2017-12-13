namespace myLabDockerAPI.Models
{
    /// <summary>
    /// Specifies an Attribute with Range Fields.
    /// </summary>
    public class RangeAttribute : ItemAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        public float LowerValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float HigherValue { get; set; }

    }
}
