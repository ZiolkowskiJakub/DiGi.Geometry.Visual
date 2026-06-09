namespace DiGi.Geometry.Visual.Core.Interfaces
{
    /// <summary>
    /// Defines the visual appearance properties for a geometric face.
    /// </summary>
    public interface IFaceAppearance : IAppearance
    {
        /// <summary>
        /// Gets or sets the appearance of the external edges of the face.
        /// </summary>
        public ICurveAppearance? ExternalEdgeAppearance { get; set; }

        /// <summary>
        /// Gets or sets the appearance of the internal edges of the face.
        /// </summary>
        public ICurveAppearance? InternalEdgeAppearance { get; set; }
    }
}