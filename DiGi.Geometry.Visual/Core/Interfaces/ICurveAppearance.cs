namespace DiGi.Geometry.Visual.Core.Interfaces
{
    /// <summary>
    /// Defines the visual appearance characteristics for a geometric curve.
    /// </summary>
    public interface ICurveAppearance : IPointAppearance
    {
        /// <summary>
        /// Gets or sets the point appearance settings associated with the curve, such as those used for endpoints or control points.
        /// </summary>
        public IPointAppearance? PointAppearance { get; set; }
    }
}