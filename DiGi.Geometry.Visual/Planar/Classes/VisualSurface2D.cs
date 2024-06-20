using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Text.Json.Nodes;


namespace DiGi.Geometry.Visual.Planar.Classes
{
    public abstract class VisualSurface2D<T> : Visual<T, ISurfaceAppearance>, IVisualSurface2D<T> where T : ISurface2D
    {
        public VisualSurface2D(T geometry, ISurfaceAppearance appearance)
            :base(geometry, appearance)
        {

        }

        public VisualSurface2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public VisualSurface2D(VisualSurface2D visualSurface2D)
            :base(visualSurface2D)
        {

        }
    }

    public class VisualSurface2D : VisualSurface2D<ISurface2D>, IVisualSurface2D
    {
        public VisualSurface2D(ISurface2D geometry, ISurfaceAppearance appearance)
            : base(geometry, appearance)
        {

        }

        public VisualSurface2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public VisualSurface2D(VisualSurface2D visualSurface2D)
            : base(visualSurface2D)
        {

        }
    }
}
