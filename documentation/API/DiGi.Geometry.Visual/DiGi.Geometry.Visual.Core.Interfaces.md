#### [DiGi\.Geometry\.Visual](index.md 'index')

## DiGi\.Geometry\.Visual\.Core\.Interfaces Namespace
### Interfaces

<a name='DiGi.Geometry.Visual.Core.Interfaces.IAppearance'></a>

## IAppearance Interface

Defines the visual appearance properties for a geometry object\.

```csharp
public interface IAppearance : DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [Appearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Appearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.Appearance')  
↳ [CurveAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.CurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.CurveAppearance')  
↳ [FaceAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.FaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.FaceAppearance')  
↳ [MeshAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.MeshAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.MeshAppearance')  
↳ [PointAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.PointAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.PointAppearance')  
↳ [SurfaceAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.SurfaceAppearance')  
↳ [ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')  
↳ [IFaceAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IFaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IFaceAppearance')  
↳ [IMeshAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IMeshAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IMeshAppearance')  
↳ [IPointAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance')  
↳ [ISurfaceAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance')

Implements [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Geometry.Visual.Core.Interfaces.IAppearance.Color'></a>

## IAppearance\.Color Property

Gets or sets the color of the object\.

```csharp
DiGi.Core.Classes.Color? Color { get; set; }
```

#### Property Value
[DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')

<a name='DiGi.Geometry.Visual.Core.Interfaces.IAppearance.Opacity'></a>

## IAppearance\.Opacity Property

Gets or sets the opacity level of the object\.

```csharp
double Opacity { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Visual.Core.Interfaces.IAppearance.Visible'></a>

## IAppearance\.Visible Property

Gets or sets a value indicating whether the object is visible\.

```csharp
bool Visible { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance'></a>

## ICurveAppearance Interface

Defines the visual appearance characteristics for a geometric curve\.

```csharp
public interface ICurveAppearance : DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance, DiGi.Geometry.Visual.Core.Interfaces.IAppearance, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [CurveAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.CurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.CurveAppearance')

Implements [IPointAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance'), [IAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance.PointAppearance'></a>

## ICurveAppearance\.PointAppearance Property

Gets or sets the point appearance settings associated with the curve, such as those used for endpoints or control points\.

```csharp
DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance? PointAppearance { get; set; }
```

#### Property Value
[IPointAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance')

<a name='DiGi.Geometry.Visual.Core.Interfaces.IFaceAppearance'></a>

## IFaceAppearance Interface

Defines the visual appearance properties for a geometric face\.

```csharp
public interface IFaceAppearance : DiGi.Geometry.Visual.Core.Interfaces.IAppearance, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [FaceAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.FaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.FaceAppearance')

Implements [IAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Geometry.Visual.Core.Interfaces.IFaceAppearance.ExternalEdgeAppearance'></a>

## IFaceAppearance\.ExternalEdgeAppearance Property

Gets or sets the appearance of the external edges of the face\.

```csharp
DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance? ExternalEdgeAppearance { get; set; }
```

#### Property Value
[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')

<a name='DiGi.Geometry.Visual.Core.Interfaces.IFaceAppearance.InternalEdgeAppearance'></a>

## IFaceAppearance\.InternalEdgeAppearance Property

Gets or sets the appearance of the internal edges of the face\.

```csharp
DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance? InternalEdgeAppearance { get; set; }
```

#### Property Value
[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')

<a name='DiGi.Geometry.Visual.Core.Interfaces.IMeshAppearance'></a>

## IMeshAppearance Interface

Defines the visual appearance properties for a mesh geometry\.

```csharp
public interface IMeshAppearance : DiGi.Geometry.Visual.Core.Interfaces.IAppearance, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [MeshAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.MeshAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.MeshAppearance')

Implements [IAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Geometry.Visual.Core.Interfaces.IMeshAppearance.AuxiliaryEdgeAppearance'></a>

## IMeshAppearance\.AuxiliaryEdgeAppearance Property

Gets or sets the appearance of the auxiliary edges of the mesh\.

```csharp
DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance? AuxiliaryEdgeAppearance { get; set; }
```

#### Property Value
[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')

<a name='DiGi.Geometry.Visual.Core.Interfaces.IMeshAppearance.BoundaryEdgeAppearance'></a>

## IMeshAppearance\.BoundaryEdgeAppearance Property

Gets or sets the appearance of the boundary edges of the mesh\.

```csharp
DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance? BoundaryEdgeAppearance { get; set; }
```

#### Property Value
[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')

<a name='DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance'></a>

## IPointAppearance Interface

Defines the visual appearance properties for a point\.

```csharp
public interface IPointAppearance : DiGi.Geometry.Visual.Core.Interfaces.IAppearance, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [CurveAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.CurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.CurveAppearance')  
↳ [PointAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.PointAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.PointAppearance')  
↳ [ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')

Implements [IAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance.Thickness'></a>

## IPointAppearance\.Thickness Property

Gets or sets the thickness of the point\.

```csharp
double Thickness { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance'></a>

## ISurfaceAppearance Interface

Defines the appearance properties for a geometric surface\.

```csharp
public interface ISurfaceAppearance : DiGi.Geometry.Visual.Core.Interfaces.IAppearance, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [SurfaceAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.SurfaceAppearance')

Implements [IAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance.CurveAppearance'></a>

## ISurfaceAppearance\.CurveAppearance Property

Gets or sets the appearance of the curves associated with the surface\.

```csharp
DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance? CurveAppearance { get; set; }
```

#### Property Value
[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')

<a name='DiGi.Geometry.Visual.Core.Interfaces.IVisual'></a>

## IVisual Interface

Defines a contract for an object that can be visually represented within the geometry system\.

```csharp
public interface IVisual : DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject
```

Derived  
↳ [Visual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual')  
↳ [Visual&lt;T,X&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')  
↳ [VisualCollection&lt;T&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection\<T\>')  
↳ [IVisual&lt;T,X&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')  
↳ [IVisualCollection](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualCollection 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualCollection')  
↳ [IVisualCollection&lt;T&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualCollection_T_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualCollection\<T\>')  
↳ [VisualCurve2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D')  
↳ [VisualCurve2D&lt;T&gt;](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D\<T\>')  
↳ [VisualPoint2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPoint2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPoint2D')  
↳ [VisualPolygon2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPolygon2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPolygon2D')  
↳ [VisualPolygonalFace2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPolygonalFace2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPolygonalFace2D')  
↳ [VisualSegment2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSegment2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSegment2D')  
↳ [VisualSurface2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D')  
↳ [VisualSurface2D&lt;T&gt;](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D\<T\>')  
↳ [IVisual2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D')  
↳ [IVisual2D&lt;T,X&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>')  
↳ [IVisual3D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D')  
↳ [IVisual3D&lt;T,X&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D\<T,X\>')  
↳ [IVisualCurve2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualCurve2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualCurve2D')  
↳ [IVisualCurve2D&lt;T&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualCurve2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualCurve2D\<T\>')  
↳ [IVisualMesh3D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualMesh3D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualMesh3D')  
↳ [IVisualPoint2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualPoint2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualPoint2D')  
↳ [IVisualPoint3D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualPoint3D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualPoint3D')  
↳ [IVisualPolygon2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualPolygon2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualPolygon2D')  
↳ [IVisualPolygonal3D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualPolygonal3D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualPolygonal3D')  
↳ [IVisualPolygonalFace2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualPolygonalFace2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualPolygonalFace2D')  
↳ [IVisualPolygonalFace3D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualPolygonalFace3D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualPolygonalFace3D')  
↳ [IVisualSegment2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualSegment2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualSegment2D')  
↳ [IVisualSegment3D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualSegment3D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualSegment3D')  
↳ [IVisualSurface2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualSurface2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualSurface2D')  
↳ [IVisualSurface2D&lt;T&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualSurface2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualSurface2D\<T\>')  
↳ [VisualMesh3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualMesh3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualMesh3D')  
↳ [VisualPoint3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPoint3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPoint3D')  
↳ [VisualPolygonal3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonal3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPolygonal3D')  
↳ [VisualPolygonalFace3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonalFace3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPolygonalFace3D')  
↳ [VisualSegment3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualSegment3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualSegment3D')

Implements [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject')

<a name='DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_'></a>

## IVisual\<T,X\> Interface

Defines a contract for a visual object associated with a specific geometry type and appearance type\.

```csharp
public interface IVisual<T,X> : DiGi.Geometry.Visual.Core.Interfaces.IVisual, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<T>
    where T : DiGi.Geometry.Core.Interfaces.IGeometry
    where X : DiGi.Geometry.Visual.Core.Interfaces.IAppearance
```
#### Type parameters

<a name='DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_.T'></a>

`T`

The type of the underlying geometry, which must implement [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')\.

<a name='DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_.X'></a>

`X`

The type of the appearance, which must implement [IAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance')\.

Derived  
↳ [Visual&lt;T,X&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')  
↳ [VisualCurve2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D')  
↳ [VisualCurve2D&lt;T&gt;](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D\<T\>')  
↳ [VisualPoint2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPoint2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPoint2D')  
↳ [VisualPolygon2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPolygon2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPolygon2D')  
↳ [VisualPolygonalFace2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPolygonalFace2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPolygonalFace2D')  
↳ [VisualSegment2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSegment2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSegment2D')  
↳ [VisualSurface2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D')  
↳ [VisualSurface2D&lt;T&gt;](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D\<T\>')  
↳ [IVisual2D&lt;T,X&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>')  
↳ [IVisual3D&lt;T,X&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D\<T,X\>')  
↳ [IVisualCurve2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualCurve2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualCurve2D')  
↳ [IVisualCurve2D&lt;T&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualCurve2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualCurve2D\<T\>')  
↳ [IVisualMesh3D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualMesh3D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualMesh3D')  
↳ [IVisualPoint2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualPoint2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualPoint2D')  
↳ [IVisualPoint3D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualPoint3D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualPoint3D')  
↳ [IVisualPolygon2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualPolygon2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualPolygon2D')  
↳ [IVisualPolygonal3D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualPolygonal3D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualPolygonal3D')  
↳ [IVisualPolygonalFace2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualPolygonalFace2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualPolygonalFace2D')  
↳ [IVisualPolygonalFace3D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualPolygonalFace3D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualPolygonalFace3D')  
↳ [IVisualSegment2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualSegment2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualSegment2D')  
↳ [IVisualSegment3D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualSegment3D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualSegment3D')  
↳ [IVisualSurface2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualSurface2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualSurface2D')  
↳ [IVisualSurface2D&lt;T&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualSurface2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualSurface2D\<T\>')  
↳ [VisualMesh3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualMesh3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualMesh3D')  
↳ [VisualPoint3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPoint3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPoint3D')  
↳ [VisualPolygonal3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonal3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPolygonal3D')  
↳ [VisualPolygonalFace3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonalFace3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPolygonalFace3D')  
↳ [VisualSegment3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualSegment3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualSegment3D')

Implements [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[T](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_.T 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')
### Properties

<a name='DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_.Appearance'></a>

## IVisual\<T,X\>\.Appearance Property

Gets or sets the visual appearance of the object\.

```csharp
X? Appearance { get; set; }
```

#### Property Value
[X](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_.X 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>\.X')

<a name='DiGi.Geometry.Visual.Core.Interfaces.IVisualCollection'></a>

## IVisualCollection Interface

Represents a collection of visual elements\.

```csharp
public interface IVisualCollection : DiGi.Geometry.Visual.Core.Interfaces.IVisual, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, System.Collections.IEnumerable
```

Derived  
↳ [VisualCollection&lt;T&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection\<T\>')  
↳ [IVisualCollection&lt;T&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualCollection_T_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualCollection\<T\>')

Implements [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')

<a name='DiGi.Geometry.Visual.Core.Interfaces.IVisualCollection_T_'></a>

## IVisualCollection\<T\> Interface

Represents a strongly\-typed collection of visual elements\.

```csharp
public interface IVisualCollection<T> : DiGi.Geometry.Visual.Core.Interfaces.IVisualCollection, DiGi.Geometry.Visual.Core.Interfaces.IVisual, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, System.Collections.IEnumerable
    where T : DiGi.Geometry.Visual.Core.Interfaces.IVisual
```
#### Type parameters

<a name='DiGi.Geometry.Visual.Core.Interfaces.IVisualCollection_T_.T'></a>

`T`

The type of visual elements in the collection, which must implement [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual')\.

Derived  
↳ [VisualCollection&lt;T&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection\<T\>')

Implements [IVisualCollection](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualCollection 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualCollection'), [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')

<a name='DiGi.Geometry.Visual.Core.Interfaces.IVisualObject'></a>

## IVisualObject Interface

Defines the base contract for an object that can be visually represented\.

```csharp
public interface IVisualObject : DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [VisualObject&lt;TVisual,TSerializableObject&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualObject\<TVisual,TSerializableObject\>')  
↳ [IVisualObject&lt;TVisual,TSerializableObject&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualObject_TVisual,TSerializableObject_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject\<TVisual,TSerializableObject\>')  
↳ [IVisualObject&lt;TVisual&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualObject_TVisual_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject\<TVisual\>')

Implements [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Geometry.Visual.Core.Interfaces.IVisualObject_TVisual,TSerializableObject_'></a>

## IVisualObject\<TVisual,TSerializableObject\> Interface

Defines a contract for an object that associates a specific type of visual representation with a serializable data object\.

```csharp
public interface IVisualObject<TVisual,TSerializableObject> : DiGi.Geometry.Visual.Core.Interfaces.IVisualObject<TVisual>, DiGi.Geometry.Visual.Core.Interfaces.IVisualObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
    where TVisual : DiGi.Geometry.Visual.Core.Interfaces.IVisual
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject
```
#### Type parameters

<a name='DiGi.Geometry.Visual.Core.Interfaces.IVisualObject_TVisual,TSerializableObject_.TVisual'></a>

`TVisual`

The type of the visual representation, which must implement [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual')\.

<a name='DiGi.Geometry.Visual.Core.Interfaces.IVisualObject_TVisual,TSerializableObject_.TSerializableObject'></a>

`TSerializableObject`

The type of the serializable object, which must implement [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.

Derived  
↳ [VisualObject&lt;TVisual,TSerializableObject&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualObject\<TVisual,TSerializableObject\>')

Implements [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject&lt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualObject_TVisual_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject\<TVisual\>')[TVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualObject_TVisual,TSerializableObject_.TVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject\<TVisual,TSerializableObject\>\.TVisual')[&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualObject_TVisual_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject\<TVisual\>'), [IVisualObject](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualObject 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Geometry.Visual.Core.Interfaces.IVisualObject_TVisual,TSerializableObject_.Object'></a>

## IVisualObject\<TVisual,TSerializableObject\>\.Object Property

Gets the serializable data object associated with this visual object\.

```csharp
TSerializableObject? Object { get; }
```

#### Property Value
[TSerializableObject](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualObject_TVisual,TSerializableObject_.TSerializableObject 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject\<TVisual,TSerializableObject\>\.TSerializableObject')

<a name='DiGi.Geometry.Visual.Core.Interfaces.IVisualObject_TVisual_'></a>

## IVisualObject\<TVisual\> Interface

Defines a contract for an object associated with a specific type of visual representation\.

```csharp
public interface IVisualObject<TVisual> : DiGi.Geometry.Visual.Core.Interfaces.IVisualObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
    where TVisual : DiGi.Geometry.Visual.Core.Interfaces.IVisual
```
#### Type parameters

<a name='DiGi.Geometry.Visual.Core.Interfaces.IVisualObject_TVisual_.TVisual'></a>

`TVisual`

The type of the visual representation, which must implement [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual')\.

Derived  
↳ [VisualObject&lt;TVisual,TSerializableObject&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualObject\<TVisual,TSerializableObject\>')  
↳ [IVisualObject&lt;TVisual,TSerializableObject&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualObject_TVisual,TSerializableObject_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject\<TVisual,TSerializableObject\>')

Implements [IVisualObject](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualObject 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Geometry.Visual.Core.Interfaces.IVisualObject_TVisual_.Visual'></a>

## IVisualObject\<TVisual\>\.Visual Property

Gets the visual representation associated with this object\.

```csharp
TVisual? Visual { get; }
```

#### Property Value
[TVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualObject_TVisual_.TVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject\<TVisual\>\.TVisual')