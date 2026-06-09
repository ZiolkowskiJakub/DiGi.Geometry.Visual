namespace DiGi.Geometry.Visual.Core.Interfaces
{
    /// <summary>
    /// Defines the visual appearance properties for a point.
    /// </summary>
    public interface IPointAppearance : IAppearance
    {
        /// <summary>
        /// Gets or sets the thickness of the point.
        /// </summary>
        public double Thickness { get; set; }
    }
}