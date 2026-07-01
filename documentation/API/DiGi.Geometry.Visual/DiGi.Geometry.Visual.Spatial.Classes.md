#### [DiGi\.Geometry\.Visual](index.md 'index')

## DiGi\.Geometry\.Visual\.Spatial\.Classes Namespace
### Classes

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualMesh3D'></a>

## VisualMesh3D Class

Represents a 3D mesh visualization that combines geometric data with visual appearance settings\.

```csharp
public class VisualMesh3D : DiGi.Geometry.Visual.Core.Classes.Visual<DiGi.Geometry.Spatial.Classes.Mesh3D, DiGi.Geometry.Visual.Core.Interfaces.IMeshAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisualMesh3D, DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D<DiGi.Geometry.Spatial.Classes.Mesh3D, DiGi.Geometry.Visual.Core.Interfaces.IMeshAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D, DiGi.Geometry.Visual.Core.Interfaces.IVisual, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Geometry.Visual.Core.Interfaces.IVisual<DiGi.Geometry.Spatial.Classes.Mesh3D, DiGi.Geometry.Visual.Core.Interfaces.IMeshAppearance>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<DiGi.Geometry.Spatial.Classes.Mesh3D>, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject<DiGi.Geometry.Spatial.Classes.Mesh3D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [Visual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') → [DiGi\.Geometry\.Visual\.Core\.Classes\.Visual&lt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')[,](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[IMeshAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IMeshAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IMeshAppearance')[&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>') → VisualMesh3D

Implements [IVisualMesh3D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualMesh3D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualMesh3D'), [DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D&lt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D\<T,X\>')[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')[,](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D\<T,X\>')[IMeshAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IMeshAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IMeshAppearance')[&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D\<T,X\>'), [IVisual3D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D'), [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual&lt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')[,](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[IMeshAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IMeshAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IMeshAppearance')[&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject-1 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject-1 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject\`1')
### Constructors

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualMesh3D.VisualMesh3D(DiGi.Geometry.Spatial.Classes.Mesh3D,DiGi.Geometry.Visual.Core.Interfaces.IMeshAppearance)'></a>

## VisualMesh3D\(Mesh3D, IMeshAppearance\) Constructor

Initializes a new instance of the [VisualMesh3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualMesh3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualMesh3D') class with specified geometry and appearance\.

```csharp
public VisualMesh3D(DiGi.Geometry.Spatial.Classes.Mesh3D? geometry, DiGi.Geometry.Visual.Core.Interfaces.IMeshAppearance? appearance);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualMesh3D.VisualMesh3D(DiGi.Geometry.Spatial.Classes.Mesh3D,DiGi.Geometry.Visual.Core.Interfaces.IMeshAppearance).geometry'></a>

`geometry` [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

The 3D mesh geometry\.

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualMesh3D.VisualMesh3D(DiGi.Geometry.Spatial.Classes.Mesh3D,DiGi.Geometry.Visual.Core.Interfaces.IMeshAppearance).appearance'></a>

`appearance` [IMeshAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IMeshAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IMeshAppearance')

The visual appearance settings for the mesh\.

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualMesh3D.VisualMesh3D(DiGi.Geometry.Visual.Spatial.Classes.VisualMesh3D)'></a>

## VisualMesh3D\(VisualMesh3D\) Constructor

Initializes a new instance of the [VisualMesh3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualMesh3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualMesh3D') class by copying another [VisualMesh3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualMesh3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualMesh3D') instance\.

```csharp
public VisualMesh3D(DiGi.Geometry.Visual.Spatial.Classes.VisualMesh3D? visualMesh3D);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualMesh3D.VisualMesh3D(DiGi.Geometry.Visual.Spatial.Classes.VisualMesh3D).visualMesh3D'></a>

`visualMesh3D` [VisualMesh3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualMesh3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualMesh3D')

The source visual mesh to copy from\.

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualMesh3D.VisualMesh3D(System.Text.Json.Nodes.JsonObject)'></a>

## VisualMesh3D\(JsonObject\) Constructor

Initializes a new instance of the [VisualMesh3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualMesh3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualMesh3D') class from a JSON object\.

```csharp
public VisualMesh3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualMesh3D.VisualMesh3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the visualization data\.

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPoint3D'></a>

## VisualPoint3D Class

Represents a visual representation of a 3D point, combining its spatial geometry with appearance properties\.

```csharp
public class VisualPoint3D : DiGi.Geometry.Visual.Core.Classes.Visual<DiGi.Geometry.Spatial.Classes.Point3D, DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisualPoint3D, DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D<DiGi.Geometry.Spatial.Classes.Point3D, DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D, DiGi.Geometry.Visual.Core.Interfaces.IVisual, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Geometry.Visual.Core.Interfaces.IVisual<DiGi.Geometry.Spatial.Classes.Point3D, DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<DiGi.Geometry.Spatial.Classes.Point3D>, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject<DiGi.Geometry.Spatial.Classes.Point3D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [Visual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') → [DiGi\.Geometry\.Visual\.Core\.Classes\.Visual&lt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[,](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[IPointAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance')[&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>') → VisualPoint3D

Implements [IVisualPoint3D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualPoint3D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualPoint3D'), [DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D&lt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D\<T,X\>')[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[,](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D\<T,X\>')[IPointAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance')[&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D\<T,X\>'), [IVisual3D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D'), [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual&lt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[,](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[IPointAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance')[&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject-1 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject-1 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject\`1')
### Constructors

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPoint3D.VisualPoint3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance)'></a>

## VisualPoint3D\(Point3D, IPointAppearance\) Constructor

Initializes a new instance of the [VisualPoint3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPoint3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPoint3D') class with specified geometry and appearance\.

```csharp
public VisualPoint3D(DiGi.Geometry.Spatial.Classes.Point3D? geometry, DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance? appearance);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPoint3D.VisualPoint3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance).geometry'></a>

`geometry` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The 3D point geometry\.

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPoint3D.VisualPoint3D(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance).appearance'></a>

`appearance` [IPointAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance')

The visual appearance settings for the point\.

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPoint3D.VisualPoint3D(DiGi.Geometry.Visual.Spatial.Classes.VisualPoint3D)'></a>

## VisualPoint3D\(VisualPoint3D\) Constructor

Initializes a new instance of the [VisualPoint3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPoint3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPoint3D') class by copying another [VisualPoint3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPoint3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPoint3D') instance\.

```csharp
public VisualPoint3D(DiGi.Geometry.Visual.Spatial.Classes.VisualPoint3D? visualPoint2D);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPoint3D.VisualPoint3D(DiGi.Geometry.Visual.Spatial.Classes.VisualPoint3D).visualPoint2D'></a>

`visualPoint2D` [VisualPoint3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPoint3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPoint3D')

The source visual point to copy from\.

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPoint3D.VisualPoint3D(System.Text.Json.Nodes.JsonObject)'></a>

## VisualPoint3D\(JsonObject\) Constructor

Initializes a new instance of the [VisualPoint3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPoint3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPoint3D') class from a JSON object\.

```csharp
public VisualPoint3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPoint3D.VisualPoint3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to initialize the visual point\.

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonal3D'></a>

## VisualPolygonal3D Class

Represents a visual representation of a 3D polygonal geometry with associated curve appearance\.

```csharp
public class VisualPolygonal3D : DiGi.Geometry.Visual.Core.Classes.Visual<DiGi.Geometry.Spatial.Interfaces.IPolygonal3D, DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisualPolygonal3D, DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D<DiGi.Geometry.Spatial.Interfaces.IPolygonal3D, DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D, DiGi.Geometry.Visual.Core.Interfaces.IVisual, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Geometry.Visual.Core.Interfaces.IVisual<DiGi.Geometry.Spatial.Interfaces.IPolygonal3D, DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<DiGi.Geometry.Spatial.Interfaces.IPolygonal3D>, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject<DiGi.Geometry.Spatial.Interfaces.IPolygonal3D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [Visual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') → [DiGi\.Geometry\.Visual\.Core\.Classes\.Visual&lt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[,](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')[&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>') → VisualPolygonal3D

Implements [IVisualPolygonal3D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualPolygonal3D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualPolygonal3D'), [DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D&lt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D\<T,X\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[,](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D\<T,X\>')[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')[&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D\<T,X\>'), [IVisual3D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D'), [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual&lt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[,](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')[&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject-1 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject-1 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject\`1')
### Constructors

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonal3D.VisualPolygonal3D(DiGi.Geometry.Spatial.Classes.Polygon3D,DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance)'></a>

## VisualPolygonal3D\(Polygon3D, ICurveAppearance\) Constructor

Initializes a new instance of the [VisualPolygonal3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonal3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPolygonal3D') class with specified geometry and appearance\.

```csharp
public VisualPolygonal3D(DiGi.Geometry.Spatial.Classes.Polygon3D? geometry, DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance? appearance);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonal3D.VisualPolygonal3D(DiGi.Geometry.Spatial.Classes.Polygon3D,DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance).geometry'></a>

`geometry` [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')

The 3D polygon geometry\.

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonal3D.VisualPolygonal3D(DiGi.Geometry.Spatial.Classes.Polygon3D,DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance).appearance'></a>

`appearance` [ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')

The curve appearance settings\.

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonal3D.VisualPolygonal3D(DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonal3D)'></a>

## VisualPolygonal3D\(VisualPolygonal3D\) Constructor

Initializes a new instance of the [VisualPolygonal3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonal3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPolygonal3D') class by copying an existing instance\.

```csharp
public VisualPolygonal3D(DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonal3D? visualPolygonal3D);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonal3D.VisualPolygonal3D(DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonal3D).visualPolygonal3D'></a>

`visualPolygonal3D` [VisualPolygonal3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonal3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPolygonal3D')

The source visual polygonal object to copy from\.

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonal3D.VisualPolygonal3D(System.Text.Json.Nodes.JsonObject)'></a>

## VisualPolygonal3D\(JsonObject\) Constructor

Initializes a new instance of the [VisualPolygonal3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonal3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPolygonal3D') class from a JSON object\.

```csharp
public VisualPolygonal3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonal3D.VisualPolygonal3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the visual polygonal data\.

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonalFace3D'></a>

## VisualPolygonalFace3D Class

Represents a visual representation of a 3D polygonal face, combining its geometry and appearance\.

```csharp
public class VisualPolygonalFace3D : DiGi.Geometry.Visual.Core.Classes.Visual<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D, DiGi.Geometry.Visual.Core.Interfaces.IFaceAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisualPolygonalFace3D, DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D, DiGi.Geometry.Visual.Core.Interfaces.IFaceAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D, DiGi.Geometry.Visual.Core.Interfaces.IVisual, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Geometry.Visual.Core.Interfaces.IVisual<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D, DiGi.Geometry.Visual.Core.Interfaces.IFaceAppearance>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [Visual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') → [DiGi\.Geometry\.Visual\.Core\.Classes\.Visual&lt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[,](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[IFaceAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IFaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IFaceAppearance')[&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>') → VisualPolygonalFace3D

Implements [IVisualPolygonalFace3D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualPolygonalFace3D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualPolygonalFace3D'), [DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D&lt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D\<T,X\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[,](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D\<T,X\>')[IFaceAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IFaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IFaceAppearance')[&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D\<T,X\>'), [IVisual3D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D'), [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual&lt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[,](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[IFaceAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IFaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IFaceAppearance')[&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject-1 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject-1 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject\`1')
### Constructors

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonalFace3D.VisualPolygonalFace3D(DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Visual.Core.Interfaces.IFaceAppearance)'></a>

## VisualPolygonalFace3D\(IPolygonalFace3D, IFaceAppearance\) Constructor

Initializes a new instance of the [VisualPolygonalFace3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonalFace3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPolygonalFace3D') class with specified geometry and appearance\.

```csharp
public VisualPolygonalFace3D(DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? geometry, DiGi.Geometry.Visual.Core.Interfaces.IFaceAppearance? appearance);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonalFace3D.VisualPolygonalFace3D(DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Visual.Core.Interfaces.IFaceAppearance).geometry'></a>

`geometry` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The 3D polygonal face geometry\.

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonalFace3D.VisualPolygonalFace3D(DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,DiGi.Geometry.Visual.Core.Interfaces.IFaceAppearance).appearance'></a>

`appearance` [IFaceAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IFaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IFaceAppearance')

The appearance settings for the face\.

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonalFace3D.VisualPolygonalFace3D(DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonalFace3D)'></a>

## VisualPolygonalFace3D\(VisualPolygonalFace3D\) Constructor

Initializes a new instance of the [VisualPolygonalFace3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonalFace3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPolygonalFace3D') class by copying another [VisualPolygonalFace3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonalFace3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPolygonalFace3D') object\.

```csharp
public VisualPolygonalFace3D(DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonalFace3D? visualPolygonalFace3D);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonalFace3D.VisualPolygonalFace3D(DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonalFace3D).visualPolygonalFace3D'></a>

`visualPolygonalFace3D` [VisualPolygonalFace3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonalFace3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPolygonalFace3D')

The source visual polygonal face to copy from\.

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonalFace3D.VisualPolygonalFace3D(System.Text.Json.Nodes.JsonObject)'></a>

## VisualPolygonalFace3D\(JsonObject\) Constructor

Initializes a new instance of the [VisualPolygonalFace3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonalFace3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPolygonalFace3D') class from a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public VisualPolygonalFace3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonalFace3D.VisualPolygonalFace3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the visual polygonal face data\.

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualSegment3D'></a>

## VisualSegment3D Class

Represents a 3D visual segment that combines a [DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') geometry with an [ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')\.

```csharp
public class VisualSegment3D : DiGi.Geometry.Visual.Core.Classes.Visual<DiGi.Geometry.Spatial.Classes.Segment3D, DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisualSegment3D, DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D<DiGi.Geometry.Spatial.Classes.Segment3D, DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D, DiGi.Geometry.Visual.Core.Interfaces.IVisual, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject, DiGi.Geometry.Visual.Core.Interfaces.IVisual<DiGi.Geometry.Spatial.Classes.Segment3D, DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<DiGi.Geometry.Spatial.Classes.Segment3D>, DiGi.Geometry.Object.Spatial.Interfaces.IGeometry3DObject<DiGi.Geometry.Spatial.Classes.Segment3D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [Visual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') → [DiGi\.Geometry\.Visual\.Core\.Classes\.Visual&lt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[,](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')[&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>') → VisualSegment3D

Implements [IVisualSegment3D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualSegment3D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualSegment3D'), [DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D&lt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D\<T,X\>')[DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[,](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D\<T,X\>')[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')[&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D\<T,X\>'), [IVisual3D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual3D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual3D'), [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject'), [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual&lt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[,](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')[&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject-1 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject\`1')[DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.spatial.interfaces.igeometry3dobject-1 'DiGi\.Geometry\.Object\.Spatial\.Interfaces\.IGeometry3DObject\`1')
### Constructors

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualSegment3D.VisualSegment3D(DiGi.Geometry.Spatial.Classes.Segment3D,DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance)'></a>

## VisualSegment3D\(Segment3D, ICurveAppearance\) Constructor

Initializes a new instance of the [VisualSegment3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualSegment3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualSegment3D') class with the specified geometry and appearance\.

```csharp
public VisualSegment3D(DiGi.Geometry.Spatial.Classes.Segment3D? geometry, DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance? appearance);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualSegment3D.VisualSegment3D(DiGi.Geometry.Spatial.Classes.Segment3D,DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance).geometry'></a>

`geometry` [DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The 3D segment geometry\.

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualSegment3D.VisualSegment3D(DiGi.Geometry.Spatial.Classes.Segment3D,DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance).appearance'></a>

`appearance` [ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')

The curve appearance settings\.

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualSegment3D.VisualSegment3D(DiGi.Geometry.Visual.Spatial.Classes.VisualSegment3D)'></a>

## VisualSegment3D\(VisualSegment3D\) Constructor

Initializes a new instance of the [VisualSegment3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualSegment3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualSegment3D') class by copying another [VisualSegment3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualSegment3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualSegment3D') instance\.

```csharp
public VisualSegment3D(DiGi.Geometry.Visual.Spatial.Classes.VisualSegment3D? visualSegment3D);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualSegment3D.VisualSegment3D(DiGi.Geometry.Visual.Spatial.Classes.VisualSegment3D).visualSegment3D'></a>

`visualSegment3D` [VisualSegment3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualSegment3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualSegment3D')

The source visual segment to copy from\.

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualSegment3D.VisualSegment3D(System.Text.Json.Nodes.JsonObject)'></a>

## VisualSegment3D\(JsonObject\) Constructor

Initializes a new instance of the [VisualSegment3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualSegment3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualSegment3D') class from a JSON object\.

```csharp
public VisualSegment3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Spatial.Classes.VisualSegment3D.VisualSegment3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the visual segment data\.