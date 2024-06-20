using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;

namespace DiGi.Geometry.Visual.Core.Interfaces
{
    public interface IVisual<T, X> : IVisual where T: IGeometry where X : IAppearance
    {
        T Geometry { get; set; }

        X Appearance { get; set; }
    }

    public interface IVisual: IUniqueObject
    {

    }
}
