namespace DiGi.Geometry.Visual.Core.Interfaces
{
    public interface ICurveAppearance : IPointAppearance
    {
        public IPointAppearance? PointAppearance { get; set; }
    }
}