using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Object.Core.Interfaces;

namespace DiGi.Geometry.Visual.Core.Interfaces
{
    public interface IVisual<T, X> : IVisual, IGeometryObject<T> where T: IGeometry where X : IAppearance
    {
        T Geometry { get; set; }

        X Appearance { get; set; }
    }

    public interface IVisual: IGuidObject, IGeometryObject
    {

    }
}
