namespace DiGi.Geometry.Visual.Core.Interfaces
{
    public interface ISurfaceAppearance : IAppearance
    {
        public ICurveAppearance? CurveAppearance { get; set; }
    }
}