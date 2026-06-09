namespace DiGi.Geometry.Visual.Core.Interfaces
{
    /// <summary>
    /// Defines the appearance properties for a geometric surface.
    /// </summary>
    public interface ISurfaceAppearance : IAppearance
    {
        /// <summary>
        /// Gets or sets the appearance of the curves associated with the surface.
        /// </summary>
        public ICurveAppearance? CurveAppearance { get; set; }
    }
}