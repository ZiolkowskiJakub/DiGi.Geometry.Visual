using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Visual.Spatial.Classes
{
    /// <summary>
    /// Represents a 3D visual segment that combines a <see cref="Segment3D"/> geometry with an <see cref="ICurveAppearance"/>.
    /// </summary>
    public class VisualSegment3D : Visual<Segment3D, ICurveAppearance>, IVisualSegment3D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisualSegment3D"/> class with the specified geometry and appearance.
        /// </summary>
        /// <param name="geometry">The 3D segment geometry.</param>
        /// <param name="appearance">The curve appearance settings.</param>
        public VisualSegment3D(Segment3D? geometry, ICurveAppearance? appearance)
            : base(geometry, appearance)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualSegment3D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the visual segment data.</param>
        public VisualSegment3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualSegment3D"/> class by copying another <see cref="VisualSegment3D"/> instance.
        /// </summary>
        /// <param name="visualSegment3D">The source visual segment to copy from.</param>
        public VisualSegment3D(VisualSegment3D? visualSegment3D)
            : base(visualSegment3D)
        {
        }
    }
}