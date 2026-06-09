using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Visual.Planar.Classes
{
    /// <summary>
    /// Represents a visual representation of a 2D segment, combining its geometry with appearance properties.
    /// </summary>
    public class VisualSegment2D : Visual<Segment2D, IPointAppearance>, IVisualSegment2D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisualSegment2D"/> class with specified geometry and appearance.
        /// </summary>
        /// <param name="geometry">The 2D segment geometry.</param>
        /// <param name="appearance">The visual appearance settings for the points of the segment.</param>
        public VisualSegment2D(Segment2D? geometry, IPointAppearance? appearance)
            : base(geometry, appearance)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualSegment2D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data to initialize the visual segment.</param>
        public VisualSegment2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualSegment2D"/> class by copying another <see cref="VisualSegment2D"/> object.
        /// </summary>
        /// <param name="visualSegment2D">The source visual segment to copy from.</param>
        public VisualSegment2D(VisualSegment2D? visualSegment2D)
            : base(visualSegment2D)
        {
        }
    }
}