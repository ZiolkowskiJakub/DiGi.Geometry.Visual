namespace DiGi.Geometry.Visual.Core.Interfaces
{
    /// <summary>
    /// Defines the visual appearance properties for a mesh geometry.
    /// </summary>
    public interface IMeshAppearance : IAppearance
    {
        /// <summary>
        /// Gets or sets the appearance of the boundary edges of the mesh.
        /// </summary>
        public ICurveAppearance? BoundaryEdgeAppearance { get; set; }

        /// <summary>
        /// Gets or sets the appearance of the auxiliary edges of the mesh.
        /// </summary>
        public ICurveAppearance? AuxiliaryEdgeAppearance { get; set; }
    }
}