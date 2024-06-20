using DiGi.Geometry.Visual.Core.Classes;

namespace DiGi.Geometry.Visual.Core.Interfaces
{
    public interface ISurfaceAppearance : IAppearance
    {
        public CurveAppearance CurveAppearance { get; set; }
    }
}
