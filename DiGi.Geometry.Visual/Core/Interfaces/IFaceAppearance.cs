namespace DiGi.Geometry.Visual.Core.Interfaces
{
    public interface IFaceAppearance : IAppearance
    {
        public ICurveAppearance? ExternalEdgeAppearance { get; set; }

        public ICurveAppearance? InternalEdgeAppearance { get; set; }
    }
}