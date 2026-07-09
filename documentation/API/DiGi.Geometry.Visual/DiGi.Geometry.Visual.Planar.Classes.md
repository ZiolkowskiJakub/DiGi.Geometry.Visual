#### [DiGi\.Geometry\.Visual](DiGi.Geometry.Visual.Overview.md 'DiGi\.Geometry\.Visual\.Overview')

## DiGi\.Geometry\.Visual\.Planar\.Classes Namespace
### Classes

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCollection2D'></a>

## VisualCollection2D Class

Represents a collection of 2D visual elements\.

```csharp
public class VisualCollection2D : DiGi.Geometry.Visual.Core.Classes.VisualCollection<DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [Visual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') → [DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection&lt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection\<T\>')[IVisual2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D')[&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection\<T\>') → VisualCollection2D
### Constructors

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCollection2D.VisualCollection2D(DiGi.Geometry.Visual.Planar.Classes.VisualCollection2D)'></a>

## VisualCollection2D\(VisualCollection2D\) Constructor

Initializes a new instance of the [VisualCollection2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCollection2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCollection2D') class using another [VisualCollection2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCollection2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCollection2D') object\.

```csharp
public VisualCollection2D(DiGi.Geometry.Visual.Planar.Classes.VisualCollection2D? visualCollection2D);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCollection2D.VisualCollection2D(DiGi.Geometry.Visual.Planar.Classes.VisualCollection2D).visualCollection2D'></a>

`visualCollection2D` [VisualCollection2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCollection2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCollection2D')

The source collection to copy from\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCollection2D.VisualCollection2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_)'></a>

## VisualCollection2D\(IEnumerable\<IVisual2D\>\) Constructor

Initializes a new instance of the [VisualCollection2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCollection2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCollection2D') class using an enumerable of 2D visuals\.

```csharp
public VisualCollection2D(System.Collections.Generic.IEnumerable<DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D>? visual2Ds);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCollection2D.VisualCollection2D(System.Collections.Generic.IEnumerable_DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_).visual2Ds'></a>

`visual2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[IVisual2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 2D visual elements to initialize with\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCollection2D.VisualCollection2D(System.Text.Json.Nodes.JsonObject)'></a>

## VisualCollection2D\(JsonObject\) Constructor

Initializes a new instance of the [VisualCollection2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCollection2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCollection2D') class from a JSON object\.

```csharp
public VisualCollection2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCollection2D.VisualCollection2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the collection data\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D'></a>

## VisualCurve2D Class

Represents a visual representation of a 2D curve using the base [DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icurve2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D') interface\.

```csharp
public class VisualCurve2D : DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D<DiGi.Geometry.Planar.Interfaces.ICurve2D>, DiGi.Geometry.Visual.Planar.Interfaces.IVisualCurve2D, DiGi.Geometry.Visual.Planar.Interfaces.IVisualCurve2D<DiGi.Geometry.Planar.Interfaces.ICurve2D>, DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D<DiGi.Geometry.Planar.Interfaces.ICurve2D, DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D, DiGi.Geometry.Visual.Core.Interfaces.IVisual, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject, DiGi.Geometry.Visual.Core.Interfaces.IVisual<DiGi.Geometry.Planar.Interfaces.ICurve2D, DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<DiGi.Geometry.Planar.Interfaces.ICurve2D>, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject<DiGi.Geometry.Planar.Interfaces.ICurve2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [Visual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') → [DiGi\.Geometry\.Visual\.Core\.Classes\.Visual&lt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icurve2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D')[,](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')[&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>') → [DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D&lt;](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D\<T\>')[DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icurve2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D')[&gt;](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D\<T\>') → VisualCurve2D

Implements [IVisualCurve2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualCurve2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualCurve2D'), [DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualCurve2D&lt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualCurve2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualCurve2D\<T\>')[DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icurve2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D')[&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualCurve2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualCurve2D\<T\>'), [DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D&lt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>')[DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icurve2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D')[,](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>')[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')[&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>'), [IVisual2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D'), [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject'), [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual&lt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icurve2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D')[,](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')[&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icurve2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject-1 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icurve2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject-1 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject\`1')
### Constructors

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D.VisualCurve2D(DiGi.Geometry.Planar.Interfaces.ICurve2D,DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance)'></a>

## VisualCurve2D\(ICurve2D, ICurveAppearance\) Constructor

Initializes a new instance of the [VisualCurve2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D') class with specified geometry and appearance\.

```csharp
public VisualCurve2D(DiGi.Geometry.Planar.Interfaces.ICurve2D? geometry, DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance? appearance);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D.VisualCurve2D(DiGi.Geometry.Planar.Interfaces.ICurve2D,DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance).geometry'></a>

`geometry` [DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icurve2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D')

The underlying 2D curve geometry\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D.VisualCurve2D(DiGi.Geometry.Planar.Interfaces.ICurve2D,DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance).appearance'></a>

`appearance` [ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')

The visual appearance settings for the curve\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D.VisualCurve2D(DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D)'></a>

## VisualCurve2D\(VisualCurve2D\) Constructor

Initializes a new instance of the [VisualCurve2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D') class by copying another [VisualCurve2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D') instance\.

```csharp
public VisualCurve2D(DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D? visualCurve2D);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D.VisualCurve2D(DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D).visualCurve2D'></a>

`visualCurve2D` [VisualCurve2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D')

The source visual curve to copy from\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D.VisualCurve2D(System.Text.Json.Nodes.JsonObject)'></a>

## VisualCurve2D\(JsonObject\) Constructor

Initializes a new instance of the [VisualCurve2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D') class from a JSON object\.

```csharp
public VisualCurve2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D.VisualCurve2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing visual curve data\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_'></a>

## VisualCurve2D\<T\> Class

Represents a visual representation of a 2D curve with associated appearance properties\.

```csharp
public abstract class VisualCurve2D<T> : DiGi.Geometry.Visual.Core.Classes.Visual<T, DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisualCurve2D<T>, DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D<T, DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D, DiGi.Geometry.Visual.Core.Interfaces.IVisual, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject, DiGi.Geometry.Visual.Core.Interfaces.IVisual<T, DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<T>, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject<T>
    where T : DiGi.Geometry.Planar.Interfaces.ICurve2D
```
#### Type parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_.T'></a>

`T`

The type of the geometry, which must implement [DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.icurve2d 'DiGi\.Geometry\.Planar\.Interfaces\.ICurve2D')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [Visual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') → [DiGi\.Geometry\.Visual\.Core\.Classes\.Visual&lt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[T](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_.T 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D\<T\>\.T')[,](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')[&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>') → VisualCurve2D\<T\>

Derived  
↳ [VisualCurve2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D')

Implements [DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualCurve2D&lt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualCurve2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualCurve2D\<T\>')[T](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_.T 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D\<T\>\.T')[&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualCurve2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualCurve2D\<T\>'), [DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D&lt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>')[T](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_.T 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D\<T\>\.T')[,](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>')[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')[&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>'), [IVisual2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D'), [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject'), [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual&lt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[T](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_.T 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D\<T\>\.T')[,](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')[&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[T](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_.T 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject-1 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject\`1')[T](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_.T 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject-1 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject\`1')
### Constructors

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_.VisualCurve2D(DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_)'></a>

## VisualCurve2D\(VisualCurve2D\<T\>\) Constructor

Initializes a new instance of the [VisualCurve2D&lt;T&gt;](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D\<T\>') class by copying another [VisualCurve2D&lt;T&gt;](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D\<T\>') instance\.

```csharp
public VisualCurve2D(DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D<T>? visualCurve2D);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_.VisualCurve2D(DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_).visualCurve2D'></a>

`visualCurve2D` [DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D&lt;](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D\<T\>')[T](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_.T 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D\<T\>\.T')[&gt;](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D\<T\>')

The source visual curve to copy from\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_.VisualCurve2D(System.Text.Json.Nodes.JsonObject)'></a>

## VisualCurve2D\(JsonObject\) Constructor

Initializes a new instance of the [VisualCurve2D&lt;T&gt;](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D\<T\>') class from a JSON object\.

```csharp
public VisualCurve2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_.VisualCurve2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing visual curve data\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_.VisualCurve2D(T,DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance)'></a>

## VisualCurve2D\(T, ICurveAppearance\) Constructor

Initializes a new instance of the [VisualCurve2D&lt;T&gt;](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D\<T\>') class with specified geometry and appearance\.

```csharp
public VisualCurve2D(T? geometry, DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance? appearance);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_.VisualCurve2D(T,DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance).geometry'></a>

`geometry` [T](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_.T 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D\<T\>\.T')

The underlying 2D curve geometry\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_.VisualCurve2D(T,DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance).appearance'></a>

`appearance` [ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')

The visual appearance settings for the curve\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPoint2D'></a>

## VisualPoint2D Class

Represents a visual representation of a 2D point, combining its geometric position with appearance properties\.

```csharp
public class VisualPoint2D : DiGi.Geometry.Visual.Core.Classes.Visual<DiGi.Geometry.Planar.Classes.Point2D, DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisualPoint2D, DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D<DiGi.Geometry.Planar.Classes.Point2D, DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D, DiGi.Geometry.Visual.Core.Interfaces.IVisual, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject, DiGi.Geometry.Visual.Core.Interfaces.IVisual<DiGi.Geometry.Planar.Classes.Point2D, DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<DiGi.Geometry.Planar.Classes.Point2D>, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject<DiGi.Geometry.Planar.Classes.Point2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [Visual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') → [DiGi\.Geometry\.Visual\.Core\.Classes\.Visual&lt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[,](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[IPointAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance')[&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>') → VisualPoint2D

Implements [IVisualPoint2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualPoint2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualPoint2D'), [DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D&lt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[,](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>')[IPointAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance')[&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>'), [IVisual2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D'), [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject'), [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual&lt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[,](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[IPointAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance')[&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject-1 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject\`1')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject-1 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject\`1')
### Constructors

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPoint2D.VisualPoint2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance)'></a>

## VisualPoint2D\(Point2D, IPointAppearance\) Constructor

Initializes a new instance of the [VisualPoint2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPoint2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPoint2D') class with specified geometry and appearance\.

```csharp
public VisualPoint2D(DiGi.Geometry.Planar.Classes.Point2D? geometry, DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance? appearance);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPoint2D.VisualPoint2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance).geometry'></a>

`geometry` [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The 2D point geometry\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPoint2D.VisualPoint2D(DiGi.Geometry.Planar.Classes.Point2D,DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance).appearance'></a>

`appearance` [IPointAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance')

The appearance settings for the point\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPoint2D.VisualPoint2D(DiGi.Geometry.Visual.Planar.Classes.VisualPoint2D)'></a>

## VisualPoint2D\(VisualPoint2D\) Constructor

Initializes a new instance of the [VisualPoint2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPoint2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPoint2D') class by copying another [VisualPoint2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPoint2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPoint2D') object\.

```csharp
public VisualPoint2D(DiGi.Geometry.Visual.Planar.Classes.VisualPoint2D? visualPoint2D);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPoint2D.VisualPoint2D(DiGi.Geometry.Visual.Planar.Classes.VisualPoint2D).visualPoint2D'></a>

`visualPoint2D` [VisualPoint2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPoint2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPoint2D')

The source visual point to copy from\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPoint2D.VisualPoint2D(System.Text.Json.Nodes.JsonObject)'></a>

## VisualPoint2D\(JsonObject\) Constructor

Initializes a new instance of the [VisualPoint2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPoint2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPoint2D') class from a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public VisualPoint2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPoint2D.VisualPoint2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing visual point data\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPolygon2D'></a>

## VisualPolygon2D Class

Represents a visual representation of a 2D polygon, combining its geometric definition with appearance properties\.

```csharp
public class VisualPolygon2D : DiGi.Geometry.Visual.Core.Classes.Visual<DiGi.Geometry.Planar.Classes.Polygon2D, DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisualPolygon2D, DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D<DiGi.Geometry.Planar.Classes.Polygon2D, DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D, DiGi.Geometry.Visual.Core.Interfaces.IVisual, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject, DiGi.Geometry.Visual.Core.Interfaces.IVisual<DiGi.Geometry.Planar.Classes.Polygon2D, DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<DiGi.Geometry.Planar.Classes.Polygon2D>, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject<DiGi.Geometry.Planar.Classes.Polygon2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [Visual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') → [DiGi\.Geometry\.Visual\.Core\.Classes\.Visual&lt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[,](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')[&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>') → VisualPolygon2D

Implements [IVisualPolygon2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualPolygon2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualPolygon2D'), [DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D&lt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>')[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[,](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>')[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')[&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>'), [IVisual2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D'), [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject'), [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual&lt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[,](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')[&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject-1 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject\`1')[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject-1 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject\`1')
### Constructors

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPolygon2D.VisualPolygon2D(DiGi.Geometry.Planar.Classes.Polygon2D,DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance)'></a>

## VisualPolygon2D\(Polygon2D, ICurveAppearance\) Constructor

Initializes a new instance of the [VisualPolygon2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPolygon2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPolygon2D') class with specified geometry and appearance\.

```csharp
public VisualPolygon2D(DiGi.Geometry.Planar.Classes.Polygon2D? geometry, DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance? appearance);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPolygon2D.VisualPolygon2D(DiGi.Geometry.Planar.Classes.Polygon2D,DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance).geometry'></a>

`geometry` [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')

The 2D polygon geometry\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPolygon2D.VisualPolygon2D(DiGi.Geometry.Planar.Classes.Polygon2D,DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance).appearance'></a>

`appearance` [ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')

The curve appearance settings\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPolygon2D.VisualPolygon2D(DiGi.Geometry.Visual.Planar.Classes.VisualPolygon2D)'></a>

## VisualPolygon2D\(VisualPolygon2D\) Constructor

Initializes a new instance of the [VisualPolygon2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPolygon2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPolygon2D') class by copying another [VisualPolygon2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPolygon2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPolygon2D') object\.

```csharp
public VisualPolygon2D(DiGi.Geometry.Visual.Planar.Classes.VisualPolygon2D? visualPolygon2D);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPolygon2D.VisualPolygon2D(DiGi.Geometry.Visual.Planar.Classes.VisualPolygon2D).visualPolygon2D'></a>

`visualPolygon2D` [VisualPolygon2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPolygon2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPolygon2D')

The source visual polygon to copy from\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPolygon2D.VisualPolygon2D(System.Text.Json.Nodes.JsonObject)'></a>

## VisualPolygon2D\(JsonObject\) Constructor

Initializes a new instance of the [VisualPolygon2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPolygon2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPolygon2D') class from a JSON object\.

```csharp
public VisualPolygon2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPolygon2D.VisualPolygon2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing visual polygon data\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPolygonalFace2D'></a>

## VisualPolygonalFace2D Class

Represents a visual representation of a polygonal face in 2D space, combining its geometric definition with surface appearance properties\.

```csharp
public class VisualPolygonalFace2D : DiGi.Geometry.Visual.Core.Classes.Visual<DiGi.Geometry.Planar.Classes.PolygonalFace2D, DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisualPolygonalFace2D, DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D<DiGi.Geometry.Planar.Classes.PolygonalFace2D, DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D, DiGi.Geometry.Visual.Core.Interfaces.IVisual, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject, DiGi.Geometry.Visual.Core.Interfaces.IVisual<DiGi.Geometry.Planar.Classes.PolygonalFace2D, DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<DiGi.Geometry.Planar.Classes.PolygonalFace2D>, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject<DiGi.Geometry.Planar.Classes.PolygonalFace2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [Visual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') → [DiGi\.Geometry\.Visual\.Core\.Classes\.Visual&lt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[,](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[ISurfaceAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance')[&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>') → VisualPolygonalFace2D

Implements [IVisualPolygonalFace2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualPolygonalFace2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualPolygonalFace2D'), [DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D&lt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[,](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>')[ISurfaceAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance')[&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>'), [IVisual2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D'), [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject'), [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual&lt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[,](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[ISurfaceAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance')[&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject-1 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject\`1')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject-1 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject\`1')
### Constructors

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPolygonalFace2D.VisualPolygonalFace2D(DiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance)'></a>

## VisualPolygonalFace2D\(PolygonalFace2D, ISurfaceAppearance\) Constructor

Initializes a new instance of the [VisualPolygonalFace2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPolygonalFace2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPolygonalFace2D') class with the specified geometry and appearance\.

```csharp
public VisualPolygonalFace2D(DiGi.Geometry.Planar.Classes.PolygonalFace2D? geometry, DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance? appearance);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPolygonalFace2D.VisualPolygonalFace2D(DiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance).geometry'></a>

`geometry` [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The polygonal face geometry\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPolygonalFace2D.VisualPolygonalFace2D(DiGi.Geometry.Planar.Classes.PolygonalFace2D,DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance).appearance'></a>

`appearance` [ISurfaceAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance')

The surface appearance to be applied to the face\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPolygonalFace2D.VisualPolygonalFace2D(DiGi.Geometry.Visual.Planar.Classes.VisualPolygonalFace2D)'></a>

## VisualPolygonalFace2D\(VisualPolygonalFace2D\) Constructor

Initializes a new instance of the [VisualPolygonalFace2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPolygonalFace2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPolygonalFace2D') class by copying an existing visual polygonal face\.

```csharp
public VisualPolygonalFace2D(DiGi.Geometry.Visual.Planar.Classes.VisualPolygonalFace2D? visualPolygon2D);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPolygonalFace2D.VisualPolygonalFace2D(DiGi.Geometry.Visual.Planar.Classes.VisualPolygonalFace2D).visualPolygon2D'></a>

`visualPolygon2D` [VisualPolygonalFace2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPolygonalFace2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPolygonalFace2D')

The source visual polygonal face to copy from\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPolygonalFace2D.VisualPolygonalFace2D(System.Text.Json.Nodes.JsonObject)'></a>

## VisualPolygonalFace2D\(JsonObject\) Constructor

Initializes a new instance of the [VisualPolygonalFace2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPolygonalFace2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPolygonalFace2D') class from a JSON object\.

```csharp
public VisualPolygonalFace2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualPolygonalFace2D.VisualPolygonalFace2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data for the visual polygonal face\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSegment2D'></a>

## VisualSegment2D Class

Represents a visual representation of a 2D segment, combining its geometry with appearance properties\.

```csharp
public class VisualSegment2D : DiGi.Geometry.Visual.Core.Classes.Visual<DiGi.Geometry.Planar.Classes.Segment2D, DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisualSegment2D, DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D<DiGi.Geometry.Planar.Classes.Segment2D, DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D, DiGi.Geometry.Visual.Core.Interfaces.IVisual, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject, DiGi.Geometry.Visual.Core.Interfaces.IVisual<DiGi.Geometry.Planar.Classes.Segment2D, DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<DiGi.Geometry.Planar.Classes.Segment2D>, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject<DiGi.Geometry.Planar.Classes.Segment2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [Visual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') → [DiGi\.Geometry\.Visual\.Core\.Classes\.Visual&lt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[,](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[IPointAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance')[&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>') → VisualSegment2D

Implements [IVisualSegment2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualSegment2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualSegment2D'), [DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D&lt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>')[DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[,](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>')[IPointAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance')[&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>'), [IVisual2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D'), [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject'), [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual&lt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[,](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[IPointAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance')[&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject-1 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject\`1')[DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject-1 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject\`1')
### Constructors

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSegment2D.VisualSegment2D(DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance)'></a>

## VisualSegment2D\(Segment2D, IPointAppearance\) Constructor

Initializes a new instance of the [VisualSegment2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSegment2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSegment2D') class with specified geometry and appearance\.

```csharp
public VisualSegment2D(DiGi.Geometry.Planar.Classes.Segment2D? geometry, DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance? appearance);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSegment2D.VisualSegment2D(DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance).geometry'></a>

`geometry` [DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The 2D segment geometry\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSegment2D.VisualSegment2D(DiGi.Geometry.Planar.Classes.Segment2D,DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance).appearance'></a>

`appearance` [IPointAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance')

The visual appearance settings for the points of the segment\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSegment2D.VisualSegment2D(DiGi.Geometry.Visual.Planar.Classes.VisualSegment2D)'></a>

## VisualSegment2D\(VisualSegment2D\) Constructor

Initializes a new instance of the [VisualSegment2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSegment2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSegment2D') class by copying another [VisualSegment2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSegment2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSegment2D') object\.

```csharp
public VisualSegment2D(DiGi.Geometry.Visual.Planar.Classes.VisualSegment2D? visualSegment2D);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSegment2D.VisualSegment2D(DiGi.Geometry.Visual.Planar.Classes.VisualSegment2D).visualSegment2D'></a>

`visualSegment2D` [VisualSegment2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSegment2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSegment2D')

The source visual segment to copy from\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSegment2D.VisualSegment2D(System.Text.Json.Nodes.JsonObject)'></a>

## VisualSegment2D\(JsonObject\) Constructor

Initializes a new instance of the [VisualSegment2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSegment2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSegment2D') class from a JSON object\.

```csharp
public VisualSegment2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSegment2D.VisualSegment2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to initialize the visual segment\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D'></a>

## VisualSurface2D Class

Represents a visual representation of a 2D surface using the generic [DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D') interface\.

```csharp
public class VisualSurface2D : DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D<DiGi.Geometry.Planar.Interfaces.ISurface2D>, DiGi.Geometry.Visual.Planar.Interfaces.IVisualSurface2D, DiGi.Geometry.Visual.Planar.Interfaces.IVisualSurface2D<DiGi.Geometry.Planar.Interfaces.ISurface2D>, DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D<DiGi.Geometry.Planar.Interfaces.ISurface2D, DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D, DiGi.Geometry.Visual.Core.Interfaces.IVisual, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject, DiGi.Geometry.Visual.Core.Interfaces.IVisual<DiGi.Geometry.Planar.Interfaces.ISurface2D, DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<DiGi.Geometry.Planar.Interfaces.ISurface2D>, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject<DiGi.Geometry.Planar.Interfaces.ISurface2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [Visual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') → [DiGi\.Geometry\.Visual\.Core\.Classes\.Visual&lt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D')[,](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[ISurfaceAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance')[&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>') → [DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D&lt;](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D\<T\>')[DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D')[&gt;](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D\<T\>') → VisualSurface2D

Implements [IVisualSurface2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualSurface2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualSurface2D'), [DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualSurface2D&lt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualSurface2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualSurface2D\<T\>')[DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D')[&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualSurface2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualSurface2D\<T\>'), [DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D&lt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>')[DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D')[,](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>')[ISurfaceAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance')[&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>'), [IVisual2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D'), [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject'), [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual&lt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D')[,](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[ISurfaceAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance')[&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject-1 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject\`1')[DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject-1 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject\`1')
### Constructors

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D.VisualSurface2D(DiGi.Geometry.Planar.Interfaces.ISurface2D,DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance)'></a>

## VisualSurface2D\(ISurface2D, ISurfaceAppearance\) Constructor

Initializes a new instance of the [VisualSurface2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D') class with specified geometry and appearance\.

```csharp
public VisualSurface2D(DiGi.Geometry.Planar.Interfaces.ISurface2D? geometry, DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance? appearance);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D.VisualSurface2D(DiGi.Geometry.Planar.Interfaces.ISurface2D,DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance).geometry'></a>

`geometry` [DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D')

The 2D surface geometry\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D.VisualSurface2D(DiGi.Geometry.Planar.Interfaces.ISurface2D,DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance).appearance'></a>

`appearance` [ISurfaceAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance')

The visual appearance of the surface\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D.VisualSurface2D(DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D)'></a>

## VisualSurface2D\(VisualSurface2D\) Constructor

Initializes a new instance of the [VisualSurface2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D') class by copying another visual surface\.

```csharp
public VisualSurface2D(DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D? visualSurface2D);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D.VisualSurface2D(DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D).visualSurface2D'></a>

`visualSurface2D` [VisualSurface2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D')

The source visual surface to copy from\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D.VisualSurface2D(System.Text.Json.Nodes.JsonObject)'></a>

## VisualSurface2D\(JsonObject\) Constructor

Initializes a new instance of the [VisualSurface2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D') class from a JSON object\.

```csharp
public VisualSurface2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D.VisualSurface2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing surface data\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_'></a>

## VisualSurface2D\<T\> Class

Represents an abstract visual representation of a 2D surface\.

```csharp
public abstract class VisualSurface2D<T> : DiGi.Geometry.Visual.Core.Classes.Visual<T, DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisualSurface2D<T>, DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D<T, DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance>, DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D, DiGi.Geometry.Visual.Core.Interfaces.IVisual, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject, DiGi.Geometry.Visual.Core.Interfaces.IVisual<T, DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance>, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<T>, DiGi.Geometry.Object.Planar.Interfaces.IGeometry2DObject<T>
    where T : DiGi.Geometry.Planar.Interfaces.ISurface2D
```
#### Type parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_.T'></a>

`T`

The type of the geometry, which must implement [DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.isurface2d 'DiGi\.Geometry\.Planar\.Interfaces\.ISurface2D')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [Visual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') → [DiGi\.Geometry\.Visual\.Core\.Classes\.Visual&lt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[T](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_.T 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D\<T\>\.T')[,](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[ISurfaceAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance')[&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>') → VisualSurface2D\<T\>

Derived  
↳ [VisualSurface2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D')

Implements [DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualSurface2D&lt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualSurface2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualSurface2D\<T\>')[T](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_.T 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D\<T\>\.T')[&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisualSurface2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisualSurface2D\<T\>'), [DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D&lt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>')[T](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_.T 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D\<T\>\.T')[,](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>')[ISurfaceAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance')[&gt;](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D_T,X_ 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D\<T,X\>'), [IVisual2D](DiGi.Geometry.Visual.Planar.Interfaces.md#DiGi.Geometry.Visual.Planar.Interfaces.IVisual2D 'DiGi\.Geometry\.Visual\.Planar\.Interfaces\.IVisual2D'), [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject'), [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual&lt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[T](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_.T 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D\<T\>\.T')[,](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[ISurfaceAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance')[&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[T](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_.T 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1'), [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject-1 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject\`1')[T](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_.T 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject-1 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject\`1')
### Constructors

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_.VisualSurface2D(DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_)'></a>

## VisualSurface2D\(VisualSurface2D\<T\>\) Constructor

Initializes a new instance of the [VisualSurface2D&lt;T&gt;](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D\<T\>') class by copying another visual surface\.

```csharp
public VisualSurface2D(DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D<T>? visualSurface2D);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_.VisualSurface2D(DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_).visualSurface2D'></a>

`visualSurface2D` [DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D&lt;](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D\<T\>')[T](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_.T 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D\<T\>\.T')[&gt;](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D\<T\>')

The source visual surface to copy from\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_.VisualSurface2D(System.Text.Json.Nodes.JsonObject)'></a>

## VisualSurface2D\(JsonObject\) Constructor

Initializes a new instance of the [VisualSurface2D&lt;T&gt;](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D\<T\>') class from a JSON object\.

```csharp
public VisualSurface2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_.VisualSurface2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing surface data\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_.VisualSurface2D(T,DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance)'></a>

## VisualSurface2D\(T, ISurfaceAppearance\) Constructor

Initializes a new instance of the [VisualSurface2D&lt;T&gt;](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D\<T\>') class with specified geometry and appearance\.

```csharp
public VisualSurface2D(T? geometry, DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance? appearance);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_.VisualSurface2D(T,DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance).geometry'></a>

`geometry` [T](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_.T 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D\<T\>\.T')

The 2D surface geometry\.

<a name='DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_.VisualSurface2D(T,DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance).appearance'></a>

`appearance` [ISurfaceAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance')

The visual appearance of the surface\.