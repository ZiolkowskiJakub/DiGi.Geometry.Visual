namespace DiGi.Geometry.Visual.Core.Interfaces
{
    public interface IMeshAppearance : IAppearance
    {
        public ICurveAppearance? BoundaryEdgeAppearance { get; set; }

        public ICurveAppearance? AuxiliaryEdgeAppearance { get; set; }
    }
}