#### [DiGi\.Geometry\.Visual](DiGi.Geometry.Visual.Overview.md 'DiGi\.Geometry\.Visual\.Overview')

## DiGi\.Geometry\.Visual\.Core\.Classes Namespace
### Classes

<a name='DiGi.Geometry.Visual.Core.Classes.Appearance'></a>

## Appearance Class

Represents the visual appearance properties of a geometry object, including color, opacity, and visibility\.

```csharp
public abstract class Appearance : DiGi.Core.Classes.SerializableObject, DiGi.Geometry.Visual.Core.Interfaces.IAppearance, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Appearance

Derived  
↳ [FaceAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.FaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.FaceAppearance')  
↳ [MeshAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.MeshAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.MeshAppearance')  
↳ [PointAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.PointAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.PointAppearance')  
↳ [SurfaceAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.SurfaceAppearance')

Implements [IAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Geometry.Visual.Core.Classes.Appearance.Appearance(DiGi.Core.Classes.Color)'></a>

## Appearance\(Color\) Constructor

Initializes a new instance of the [Appearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Appearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.Appearance') class with a specified color\.

```csharp
public Appearance(DiGi.Core.Classes.Color? color);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.Appearance.Appearance(DiGi.Core.Classes.Color).color'></a>

`color` [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')

The color to assign to the appearance\.

<a name='DiGi.Geometry.Visual.Core.Classes.Appearance.Appearance(DiGi.Geometry.Visual.Core.Classes.Appearance)'></a>

## Appearance\(Appearance\) Constructor

Initializes a new instance of the [Appearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Appearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.Appearance') class by copying properties from an existing appearance object\.

```csharp
public Appearance(DiGi.Geometry.Visual.Core.Classes.Appearance? appearance);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.Appearance.Appearance(DiGi.Geometry.Visual.Core.Classes.Appearance).appearance'></a>

`appearance` [Appearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Appearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.Appearance')

The source appearance object to copy from\.

<a name='DiGi.Geometry.Visual.Core.Classes.Appearance.Appearance(System.Text.Json.Nodes.JsonObject)'></a>

## Appearance\(JsonObject\) Constructor

Initializes a new instance of the [Appearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Appearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.Appearance') class from a JSON object\.

```csharp
public Appearance(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.Appearance.Appearance(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the appearance data\.
### Properties

<a name='DiGi.Geometry.Visual.Core.Classes.Appearance.Color'></a>

## Appearance\.Color Property

Gets or sets the color of the appearance\.

```csharp
public DiGi.Core.Classes.Color? Color { get; set; }
```

Implements [Color](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IAppearance.Color 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance\.Color')

#### Property Value
[DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')

<a name='DiGi.Geometry.Visual.Core.Classes.Appearance.Opacity'></a>

## Appearance\.Opacity Property

Gets or sets the opacity of the appearance\.

```csharp
public double Opacity { get; set; }
```

Implements [Opacity](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IAppearance.Opacity 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance\.Opacity')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Visual.Core.Classes.Appearance.Visible'></a>

## Appearance\.Visible Property

Gets or sets a value indicating whether the appearance is visible\.

```csharp
public bool Visible { get; set; }
```

Implements [Visible](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IAppearance.Visible 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance\.Visible')

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Geometry.Visual.Core.Classes.CurveAppearance'></a>

## CurveAppearance Class

Represents the visual appearance settings for a curve, extending point appearance properties\.

```csharp
public class CurveAppearance : DiGi.Geometry.Visual.Core.Classes.PointAppearance, DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance, DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance, DiGi.Geometry.Visual.Core.Interfaces.IAppearance, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Appearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Appearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.Appearance') → [PointAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.PointAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.PointAppearance') → CurveAppearance

Implements [ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance'), [IPointAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance'), [IAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Geometry.Visual.Core.Classes.CurveAppearance.CurveAppearance(DiGi.Core.Classes.Color,double)'></a>

## CurveAppearance\(Color, double\) Constructor

Initializes a new instance of the [CurveAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.CurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.CurveAppearance') class with specified color and thickness\.

```csharp
public CurveAppearance(DiGi.Core.Classes.Color color, double thickness);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.CurveAppearance.CurveAppearance(DiGi.Core.Classes.Color,double).color'></a>

`color` [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')

The color of the curve\.

<a name='DiGi.Geometry.Visual.Core.Classes.CurveAppearance.CurveAppearance(DiGi.Core.Classes.Color,double).thickness'></a>

`thickness` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The line thickness of the curve\.

<a name='DiGi.Geometry.Visual.Core.Classes.CurveAppearance.CurveAppearance(DiGi.Geometry.Visual.Core.Classes.CurveAppearance)'></a>

## CurveAppearance\(CurveAppearance\) Constructor

Initializes a new instance of the [CurveAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.CurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.CurveAppearance') class by copying values from another [CurveAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.CurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.CurveAppearance') instance\.

```csharp
public CurveAppearance(DiGi.Geometry.Visual.Core.Classes.CurveAppearance curveAppearance);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.CurveAppearance.CurveAppearance(DiGi.Geometry.Visual.Core.Classes.CurveAppearance).curveAppearance'></a>

`curveAppearance` [CurveAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.CurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.CurveAppearance')

The source curve appearance to copy from\.

<a name='DiGi.Geometry.Visual.Core.Classes.CurveAppearance.CurveAppearance(System.Text.Json.Nodes.JsonObject)'></a>

## CurveAppearance\(JsonObject\) Constructor

Initializes a new instance of the [CurveAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.CurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.CurveAppearance') class from a JSON object\.

```csharp
public CurveAppearance(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.CurveAppearance.CurveAppearance(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the appearance data\.
### Properties

<a name='DiGi.Geometry.Visual.Core.Classes.CurveAppearance.PointAppearance'></a>

## CurveAppearance\.PointAppearance Property

Gets or sets the appearance settings for points associated with the curve\.

```csharp
public DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance? PointAppearance { get; set; }
```

Implements [PointAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance.PointAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance\.PointAppearance')

#### Property Value
[IPointAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance')

<a name='DiGi.Geometry.Visual.Core.Classes.FaceAppearance'></a>

## FaceAppearance Class

Represents the visual appearance of a face, including surface and edge properties\.

```csharp
public class FaceAppearance : DiGi.Geometry.Visual.Core.Classes.Appearance, DiGi.Geometry.Visual.Core.Interfaces.IFaceAppearance, DiGi.Geometry.Visual.Core.Interfaces.IAppearance, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Appearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Appearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.Appearance') → FaceAppearance

Implements [IFaceAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IFaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IFaceAppearance'), [IAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Geometry.Visual.Core.Classes.FaceAppearance.FaceAppearance(DiGi.Core.Classes.Color,DiGi.Core.Classes.Color,double)'></a>

## FaceAppearance\(Color, Color, double\) Constructor

Initializes a new instance of the [FaceAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.FaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.FaceAppearance') class with specified surface color, edge color, and edge thickness\.

```csharp
public FaceAppearance(DiGi.Core.Classes.Color surfaceColor, DiGi.Core.Classes.Color edgeColor, double edgeThickness);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.FaceAppearance.FaceAppearance(DiGi.Core.Classes.Color,DiGi.Core.Classes.Color,double).surfaceColor'></a>

`surfaceColor` [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')

The color of the face surface\.

<a name='DiGi.Geometry.Visual.Core.Classes.FaceAppearance.FaceAppearance(DiGi.Core.Classes.Color,DiGi.Core.Classes.Color,double).edgeColor'></a>

`edgeColor` [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')

The color of the edges\.

<a name='DiGi.Geometry.Visual.Core.Classes.FaceAppearance.FaceAppearance(DiGi.Core.Classes.Color,DiGi.Core.Classes.Color,double).edgeThickness'></a>

`edgeThickness` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The thickness of the edges\.

<a name='DiGi.Geometry.Visual.Core.Classes.FaceAppearance.FaceAppearance(DiGi.Geometry.Visual.Core.Classes.FaceAppearance)'></a>

## FaceAppearance\(FaceAppearance\) Constructor

Initializes a new instance of the [FaceAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.FaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.FaceAppearance') class by cloning another [FaceAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.FaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.FaceAppearance') object\.

```csharp
public FaceAppearance(DiGi.Geometry.Visual.Core.Classes.FaceAppearance? faceAppearance);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.FaceAppearance.FaceAppearance(DiGi.Geometry.Visual.Core.Classes.FaceAppearance).faceAppearance'></a>

`faceAppearance` [FaceAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.FaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.FaceAppearance')

The source face appearance to copy from\.

<a name='DiGi.Geometry.Visual.Core.Classes.FaceAppearance.FaceAppearance(DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance)'></a>

## FaceAppearance\(SurfaceAppearance\) Constructor

Initializes a new instance of the [FaceAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.FaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.FaceAppearance') class based on a [SurfaceAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.SurfaceAppearance')\.

```csharp
public FaceAppearance(DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance? surfaceAppearance);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.FaceAppearance.FaceAppearance(DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance).surfaceAppearance'></a>

`surfaceAppearance` [SurfaceAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.SurfaceAppearance')

The source surface appearance to derive settings from\.

<a name='DiGi.Geometry.Visual.Core.Classes.FaceAppearance.FaceAppearance(System.Text.Json.Nodes.JsonObject)'></a>

## FaceAppearance\(JsonObject\) Constructor

Initializes a new instance of the [FaceAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.FaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.FaceAppearance') class from a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public FaceAppearance(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.FaceAppearance.FaceAppearance(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing appearance data\.
### Properties

<a name='DiGi.Geometry.Visual.Core.Classes.FaceAppearance.ExternalEdgeAppearance'></a>

## FaceAppearance\.ExternalEdgeAppearance Property

Gets or sets the appearance of the external edges of the face\.

```csharp
public DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance? ExternalEdgeAppearance { get; set; }
```

Implements [ExternalEdgeAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IFaceAppearance.ExternalEdgeAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IFaceAppearance\.ExternalEdgeAppearance')

#### Property Value
[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')

<a name='DiGi.Geometry.Visual.Core.Classes.FaceAppearance.InternalEdgeAppearance'></a>

## FaceAppearance\.InternalEdgeAppearance Property

Gets or sets the appearance of the internal edges of the face\.

```csharp
public DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance? InternalEdgeAppearance { get; set; }
```

Implements [InternalEdgeAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IFaceAppearance.InternalEdgeAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IFaceAppearance\.InternalEdgeAppearance')

#### Property Value
[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')

<a name='DiGi.Geometry.Visual.Core.Classes.MeshAppearance'></a>

## MeshAppearance Class

Represents the visual appearance settings for a mesh, including surface and edge properties\.

```csharp
public class MeshAppearance : DiGi.Geometry.Visual.Core.Classes.Appearance, DiGi.Geometry.Visual.Core.Interfaces.IMeshAppearance, DiGi.Geometry.Visual.Core.Interfaces.IAppearance, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Appearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Appearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.Appearance') → MeshAppearance

Implements [IMeshAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IMeshAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IMeshAppearance'), [IAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Geometry.Visual.Core.Classes.MeshAppearance.MeshAppearance(DiGi.Core.Classes.Color,DiGi.Core.Classes.Color,double)'></a>

## MeshAppearance\(Color, Color, double\) Constructor

Initializes a new instance of the [MeshAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.MeshAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.MeshAppearance') class with specified surface color and boundary edge properties\.

```csharp
public MeshAppearance(DiGi.Core.Classes.Color surfaceColor, DiGi.Core.Classes.Color boundaryEdgeColor, double boundaryEdgeThickness);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.MeshAppearance.MeshAppearance(DiGi.Core.Classes.Color,DiGi.Core.Classes.Color,double).surfaceColor'></a>

`surfaceColor` [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')

The color of the mesh surface\.

<a name='DiGi.Geometry.Visual.Core.Classes.MeshAppearance.MeshAppearance(DiGi.Core.Classes.Color,DiGi.Core.Classes.Color,double).boundaryEdgeColor'></a>

`boundaryEdgeColor` [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')

The color of the boundary edges\.

<a name='DiGi.Geometry.Visual.Core.Classes.MeshAppearance.MeshAppearance(DiGi.Core.Classes.Color,DiGi.Core.Classes.Color,double).boundaryEdgeThickness'></a>

`boundaryEdgeThickness` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The thickness of the boundary edges\.

<a name='DiGi.Geometry.Visual.Core.Classes.MeshAppearance.MeshAppearance(DiGi.Geometry.Visual.Core.Classes.MeshAppearance)'></a>

## MeshAppearance\(MeshAppearance\) Constructor

Initializes a new instance of the [MeshAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.MeshAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.MeshAppearance') class by cloning an existing mesh appearance\.

```csharp
public MeshAppearance(DiGi.Geometry.Visual.Core.Classes.MeshAppearance? meshAppearance);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.MeshAppearance.MeshAppearance(DiGi.Geometry.Visual.Core.Classes.MeshAppearance).meshAppearance'></a>

`meshAppearance` [MeshAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.MeshAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.MeshAppearance')

The source mesh appearance to copy from\.

<a name='DiGi.Geometry.Visual.Core.Classes.MeshAppearance.MeshAppearance(DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance)'></a>

## MeshAppearance\(SurfaceAppearance\) Constructor

Initializes a new instance of the [MeshAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.MeshAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.MeshAppearance') class based on a surface appearance\.

```csharp
public MeshAppearance(DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance? surfaceAppearance);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.MeshAppearance.MeshAppearance(DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance).surfaceAppearance'></a>

`surfaceAppearance` [SurfaceAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.SurfaceAppearance')

The source surface appearance to copy from\.

<a name='DiGi.Geometry.Visual.Core.Classes.MeshAppearance.MeshAppearance(System.Text.Json.Nodes.JsonObject)'></a>

## MeshAppearance\(JsonObject\) Constructor

Initializes a new instance of the [MeshAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.MeshAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.MeshAppearance') class from a JSON object\.

```csharp
public MeshAppearance(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.MeshAppearance.MeshAppearance(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing appearance data\.
### Properties

<a name='DiGi.Geometry.Visual.Core.Classes.MeshAppearance.AuxiliaryEdgeAppearance'></a>

## MeshAppearance\.AuxiliaryEdgeAppearance Property

Gets or sets the appearance of the auxiliary edges of the mesh\.

```csharp
public DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance? AuxiliaryEdgeAppearance { get; set; }
```

Implements [AuxiliaryEdgeAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IMeshAppearance.AuxiliaryEdgeAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IMeshAppearance\.AuxiliaryEdgeAppearance')

#### Property Value
[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')

<a name='DiGi.Geometry.Visual.Core.Classes.MeshAppearance.BoundaryEdgeAppearance'></a>

## MeshAppearance\.BoundaryEdgeAppearance Property

Gets or sets the appearance of the boundary edges of the mesh\.

```csharp
public DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance? BoundaryEdgeAppearance { get; set; }
```

Implements [BoundaryEdgeAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IMeshAppearance.BoundaryEdgeAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IMeshAppearance\.BoundaryEdgeAppearance')

#### Property Value
[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')

<a name='DiGi.Geometry.Visual.Core.Classes.PointAppearance'></a>

## PointAppearance Class

Represents the visual appearance of a point, including its color and thickness\.

```csharp
public class PointAppearance : DiGi.Geometry.Visual.Core.Classes.Appearance, DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance, DiGi.Geometry.Visual.Core.Interfaces.IAppearance, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Appearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Appearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.Appearance') → PointAppearance

Derived  
↳ [CurveAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.CurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.CurveAppearance')

Implements [IPointAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance'), [IAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Geometry.Visual.Core.Classes.PointAppearance.PointAppearance(DiGi.Core.Classes.Color,double)'></a>

## PointAppearance\(Color, double\) Constructor

Initializes a new instance of the [PointAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.PointAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.PointAppearance') class with specified color and thickness\.

```csharp
public PointAppearance(DiGi.Core.Classes.Color color, double thickness);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.PointAppearance.PointAppearance(DiGi.Core.Classes.Color,double).color'></a>

`color` [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')

The color of the point\.

<a name='DiGi.Geometry.Visual.Core.Classes.PointAppearance.PointAppearance(DiGi.Core.Classes.Color,double).thickness'></a>

`thickness` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The thickness of the point\.

<a name='DiGi.Geometry.Visual.Core.Classes.PointAppearance.PointAppearance(DiGi.Geometry.Visual.Core.Classes.PointAppearance)'></a>

## PointAppearance\(PointAppearance\) Constructor

Initializes a new instance of the [PointAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.PointAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.PointAppearance') class by copying another [PointAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.PointAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.PointAppearance') object\.

```csharp
public PointAppearance(DiGi.Geometry.Visual.Core.Classes.PointAppearance pointAppearance);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.PointAppearance.PointAppearance(DiGi.Geometry.Visual.Core.Classes.PointAppearance).pointAppearance'></a>

`pointAppearance` [PointAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.PointAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.PointAppearance')

The source appearance to copy from\.

<a name='DiGi.Geometry.Visual.Core.Classes.PointAppearance.PointAppearance(System.Text.Json.Nodes.JsonObject)'></a>

## PointAppearance\(JsonObject\) Constructor

Initializes a new instance of the [PointAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.PointAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.PointAppearance') class from a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public PointAppearance(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.PointAppearance.PointAppearance(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing appearance data\.
### Properties

<a name='DiGi.Geometry.Visual.Core.Classes.PointAppearance.Thickness'></a>

## PointAppearance\.Thickness Property

Gets or sets the thickness of the point\.

```csharp
public double Thickness { get; set; }
```

Implements [Thickness](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance.Thickness 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance\.Thickness')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance'></a>

## SurfaceAppearance Class

Represents the visual appearance of a surface, including its color and the appearance of its boundary curves\.

```csharp
public class SurfaceAppearance : DiGi.Geometry.Visual.Core.Classes.Appearance, DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance, DiGi.Geometry.Visual.Core.Interfaces.IAppearance, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Appearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Appearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.Appearance') → SurfaceAppearance

Implements [ISurfaceAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance'), [IAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance.SurfaceAppearance(DiGi.Core.Classes.Color,DiGi.Core.Classes.Color,double)'></a>

## SurfaceAppearance\(Color, Color, double\) Constructor

Initializes a new instance of the [SurfaceAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.SurfaceAppearance') class with specified colors and curve thickness\.

```csharp
public SurfaceAppearance(DiGi.Core.Classes.Color surfaceColor, DiGi.Core.Classes.Color curveColor, double curveThickness);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance.SurfaceAppearance(DiGi.Core.Classes.Color,DiGi.Core.Classes.Color,double).surfaceColor'></a>

`surfaceColor` [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')

The color of the surface\.

<a name='DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance.SurfaceAppearance(DiGi.Core.Classes.Color,DiGi.Core.Classes.Color,double).curveColor'></a>

`curveColor` [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')

The color of the boundary curves\.

<a name='DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance.SurfaceAppearance(DiGi.Core.Classes.Color,DiGi.Core.Classes.Color,double).curveThickness'></a>

`curveThickness` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The thickness of the boundary curves\.

<a name='DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance.SurfaceAppearance(DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance)'></a>

## SurfaceAppearance\(SurfaceAppearance\) Constructor

Initializes a new instance of the [SurfaceAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.SurfaceAppearance') class by cloning an existing surface appearance\.

```csharp
public SurfaceAppearance(DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance? surfaceAppearance);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance.SurfaceAppearance(DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance).surfaceAppearance'></a>

`surfaceAppearance` [SurfaceAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.SurfaceAppearance')

The source surface appearance to copy from\.

<a name='DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance.SurfaceAppearance(System.Text.Json.Nodes.JsonObject)'></a>

## SurfaceAppearance\(JsonObject\) Constructor

Initializes a new instance of the [SurfaceAppearance](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.SurfaceAppearance') class from a JSON object\.

```csharp
public SurfaceAppearance(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance.SurfaceAppearance(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing surface appearance data\.
### Properties

<a name='DiGi.Geometry.Visual.Core.Classes.SurfaceAppearance.CurveAppearance'></a>

## SurfaceAppearance\.CurveAppearance Property

Gets or sets the appearance settings for the curves associated with the surface\.

```csharp
public DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance? CurveAppearance { get; set; }
```

Implements [CurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ISurfaceAppearance.CurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ISurfaceAppearance\.CurveAppearance')

#### Property Value
[ICurveAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.ICurveAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.ICurveAppearance')

<a name='DiGi.Geometry.Visual.Core.Classes.Visual'></a>

## Visual Class

Represents a base class for visual objects in the geometry system\.

```csharp
public abstract class Visual : DiGi.Core.Classes.GuidObject, DiGi.Geometry.Visual.Core.Interfaces.IVisual, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → Visual

Derived  
↳ [Visual&lt;T,X&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')  
↳ [VisualCollection&lt;T&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection\<T\>')

Implements [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject')
### Constructors

<a name='DiGi.Geometry.Visual.Core.Classes.Visual.Visual()'></a>

## Visual\(\) Constructor

Initializes a new instance of the [Visual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') class\.

```csharp
public Visual();
```

<a name='DiGi.Geometry.Visual.Core.Classes.Visual.Visual(DiGi.Geometry.Visual.Core.Classes.Visual)'></a>

## Visual\(Visual\) Constructor

Initializes a new instance of the [Visual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') class by copying another visual object\.

```csharp
public Visual(DiGi.Geometry.Visual.Core.Classes.Visual? visual);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.Visual.Visual(DiGi.Geometry.Visual.Core.Classes.Visual).visual'></a>

`visual` [Visual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual')

The source visual object to copy from\.

<a name='DiGi.Geometry.Visual.Core.Classes.Visual.Visual(System.Text.Json.Nodes.JsonObject)'></a>

## Visual\(JsonObject\) Constructor

Initializes a new instance of the [Visual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') class from a JSON object\.

```csharp
public Visual(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.Visual.Visual(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing visual data\.

<a name='DiGi.Geometry.Visual.Core.Classes.Visual_T,X_'></a>

## Visual\<T,X\> Class

Represents a generic base class for visual objects that combine a specific geometry and appearance\.

```csharp
public abstract class Visual<T,X> : DiGi.Geometry.Visual.Core.Classes.Visual, DiGi.Geometry.Visual.Core.Interfaces.IVisual<T, X>, DiGi.Geometry.Visual.Core.Interfaces.IVisual, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject<T>
    where T : DiGi.Geometry.Core.Interfaces.IGeometry
    where X : DiGi.Geometry.Visual.Core.Interfaces.IAppearance
```
#### Type parameters

<a name='DiGi.Geometry.Visual.Core.Classes.Visual_T,X_.T'></a>

`T`

The type of geometry, which must implement [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')\.

<a name='DiGi.Geometry.Visual.Core.Classes.Visual_T,X_.X'></a>

`X`

The type of appearance, which must implement [IAppearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IAppearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [Visual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') → Visual\<T,X\>

Derived  
↳ [VisualCurve2D&lt;T&gt;](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCurve2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCurve2D\<T\>')  
↳ [VisualPoint2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPoint2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPoint2D')  
↳ [VisualPolygon2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPolygon2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPolygon2D')  
↳ [VisualPolygonalFace2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualPolygonalFace2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPolygonalFace2D')  
↳ [VisualSegment2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSegment2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSegment2D')  
↳ [VisualSurface2D&lt;T&gt;](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualSurface2D_T_ 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualSurface2D\<T\>')  
↳ [VisualMesh3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualMesh3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualMesh3D')  
↳ [VisualPoint3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPoint3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPoint3D')  
↳ [VisualPolygonal3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonal3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPolygonal3D')  
↳ [VisualPolygonalFace3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualPolygonalFace3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualPolygonalFace3D')  
↳ [VisualSegment3D](DiGi.Geometry.Visual.Spatial.Classes.md#DiGi.Geometry.Visual.Spatial.Classes.VisualSegment3D 'DiGi\.Geometry\.Visual\.Spatial\.Classes\.VisualSegment3D')

Implements [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual&lt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[T](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_.T 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>\.T')[,](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>')[X](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_.X 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>\.X')[&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>'), [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')[T](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_.T 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1')
### Constructors

<a name='DiGi.Geometry.Visual.Core.Classes.Visual_T,X_.Visual(DiGi.Geometry.Visual.Core.Classes.Visual_T,X_)'></a>

## Visual\(Visual\<T,X\>\) Constructor

Initializes a new instance of the [Visual&lt;T,X&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>') class by copying another visual object\.

```csharp
public Visual(DiGi.Geometry.Visual.Core.Classes.Visual<T,X>? visual);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.Visual_T,X_.Visual(DiGi.Geometry.Visual.Core.Classes.Visual_T,X_).visual'></a>

`visual` [DiGi\.Geometry\.Visual\.Core\.Classes\.Visual&lt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[T](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_.T 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>\.T')[,](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')[X](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_.X 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>\.X')[&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>')

The source visual object to copy from\.

<a name='DiGi.Geometry.Visual.Core.Classes.Visual_T,X_.Visual(System.Text.Json.Nodes.JsonObject)'></a>

## Visual\(JsonObject\) Constructor

Initializes a new instance of the [Visual&lt;T,X&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>') class from a JSON object\.

```csharp
public Visual(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.Visual_T,X_.Visual(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing visual data\.

<a name='DiGi.Geometry.Visual.Core.Classes.Visual_T,X_.Visual(T,X)'></a>

## Visual\(T, X\) Constructor

Initializes a new instance of the [Visual&lt;T,X&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>') class with specified geometry and appearance\.

```csharp
public Visual(T? geometry, X? appearance);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.Visual_T,X_.Visual(T,X).geometry'></a>

`geometry` [T](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_.T 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>\.T')

The geometry to assign to the visual object\.

<a name='DiGi.Geometry.Visual.Core.Classes.Visual_T,X_.Visual(T,X).appearance'></a>

`appearance` [X](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_.X 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>\.X')

The appearance to assign to the visual object\.
### Properties

<a name='DiGi.Geometry.Visual.Core.Classes.Visual_T,X_.Appearance'></a>

## Visual\<T,X\>\.Appearance Property

Gets or sets the appearance of the visual object\.

```csharp
public virtual X? Appearance { get; set; }
```

Implements [Appearance](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual_T,X_.Appearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual\<T,X\>\.Appearance')

#### Property Value
[X](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_.X 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>\.X')

<a name='DiGi.Geometry.Visual.Core.Classes.Visual_T,X_.Geometry'></a>

## Visual\<T,X\>\.Geometry Property

Gets or sets the geometry of the visual object\.

```csharp
public virtual T? Geometry { get; set; }
```

Implements [Geometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject-1.geometry 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject\`1\.Geometry')

#### Property Value
[T](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual_T,X_.T 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\<T,X\>\.T')

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_'></a>

## VisualCollection\<T\> Class

Represents an abstract base class for a collection of visual elements\.

```csharp
public abstract class VisualCollection<T> : DiGi.Geometry.Visual.Core.Classes.Visual, DiGi.Geometry.Visual.Core.Interfaces.IVisualCollection<T>, DiGi.Geometry.Visual.Core.Interfaces.IVisualCollection, DiGi.Geometry.Visual.Core.Interfaces.IVisual, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Geometry.Object.Core.Interfaces.IGeometryObject, System.Collections.IEnumerable
    where T : DiGi.Geometry.Visual.Core.Interfaces.IVisual
```
#### Type parameters

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.T'></a>

`T`

The type of visual elements contained in the collection, which must implement [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [Visual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.Visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') → VisualCollection\<T\>

Derived  
↳ [VisualCollection2D](DiGi.Geometry.Visual.Planar.Classes.md#DiGi.Geometry.Visual.Planar.Classes.VisualCollection2D 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualCollection2D')

Implements [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualCollection&lt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualCollection_T_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualCollection\<T\>')[T](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.T 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection\<T\>\.T')[&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualCollection_T_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualCollection\<T\>'), [IVisualCollection](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualCollection 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualCollection'), [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject'), [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')
### Constructors

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.VisualCollection()'></a>

## VisualCollection\(\) Constructor

Initializes a new instance of the [VisualCollection&lt;T&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection\<T\>') class\.

```csharp
public VisualCollection();
```

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.VisualCollection(DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_)'></a>

## VisualCollection\(VisualCollection\<T\>\) Constructor

Initializes a new instance of the [VisualCollection&lt;T&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection\<T\>') class by copying another visual collection\.

```csharp
public VisualCollection(DiGi.Geometry.Visual.Core.Classes.VisualCollection<T>? visualCollection);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.VisualCollection(DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_).visualCollection'></a>

`visualCollection` [DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection&lt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection\<T\>')[T](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.T 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection\<T\>\.T')[&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection\<T\>')

The source visual collection to copy from\.

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.VisualCollection(System.Collections.Generic.IEnumerable_T_)'></a>

## VisualCollection\(IEnumerable\<T\>\) Constructor

Initializes a new instance of the [VisualCollection&lt;T&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection\<T\>') class with a specified set of visuals\.

```csharp
public VisualCollection(System.Collections.Generic.IEnumerable<T>? visuals);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.VisualCollection(System.Collections.Generic.IEnumerable_T_).visuals'></a>

`visuals` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.T 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The initial collection of visual elements\.

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.VisualCollection(System.Text.Json.Nodes.JsonObject)'></a>

## VisualCollection\(JsonObject\) Constructor

Initializes a new instance of the [VisualCollection&lt;T&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection\<T\>') class from a JSON object\.

```csharp
public VisualCollection(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.VisualCollection(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the collection data\.
### Properties

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.this[DiGi.Core.Classes.GuidReference]'></a>

## VisualCollection\<T\>\.this\[GuidReference\] Property

Gets the visual element associated with the specified unique reference\.

```csharp
public T? this[DiGi.Core.Classes.GuidReference? guidReference] { get; }
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.this[DiGi.Core.Classes.GuidReference].guidReference'></a>

`guidReference` [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')

The unique reference of the visual element to retrieve\.

#### Property Value
[T](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.T 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection\<T\>\.T')
### Methods

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.Add(T)'></a>

## VisualCollection\<T\>\.Add\(T\) Method

Adds a visual element to the collection\.

```csharp
public bool Add(T? value);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.Add(T).value'></a>

`value` [T](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.T 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection\<T\>\.T')

The visual element to add\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the element was successfully added; otherwise, `false`\.

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.Clear()'></a>

## VisualCollection\<T\>\.Clear\(\) Method

Removes all visual elements from the collection\.

```csharp
public void Clear();
```

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.Contains(DiGi.Core.Classes.GuidReference)'></a>

## VisualCollection\<T\>\.Contains\(GuidReference\) Method

Determines whether the collection contains a visual element with the specified unique reference\.

```csharp
public bool Contains(DiGi.Core.Classes.GuidReference? guidReference);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.Contains(DiGi.Core.Classes.GuidReference).guidReference'></a>

`guidReference` [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')

The unique reference to locate in the collection\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the reference is found; otherwise, `false`\.

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.Contains(T)'></a>

## VisualCollection\<T\>\.Contains\(T\) Method

Determines whether the collection contains a specific visual element\.

```csharp
public bool Contains(T? value);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.Contains(T).value'></a>

`value` [T](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.T 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection\<T\>\.T')

The visual element to locate in the collection\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the element is found; otherwise, `false`\.

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.GetEnumerator()'></a>

## VisualCollection\<T\>\.GetEnumerator\(\) Method

Returns an enumerator that iterates through the collection of visual elements\.

```csharp
public System.Collections.Generic.IEnumerator<T> GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

#### Returns
[System\.Collections\.Generic\.IEnumerator&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')[T](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.T 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')  
An enumerator for the collection\.

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.GetValues()'></a>

## VisualCollection\<T\>\.GetValues\(\) Method

Retrieves all visual elements currently stored in the collection\.

```csharp
public System.Collections.Generic.IEnumerable<T>? GetValues();
```

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.T 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
An enumerable collection of visual elements, or `null` if the internal storage is unavailable\.

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.Remove(DiGi.Core.Classes.GuidReference)'></a>

## VisualCollection\<T\>\.Remove\(GuidReference\) Method

Removes the visual element associated with the specified unique reference from the collection\.

```csharp
public bool Remove(DiGi.Core.Classes.GuidReference? guidReference);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.Remove(DiGi.Core.Classes.GuidReference).guidReference'></a>

`guidReference` [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')

The unique reference of the element to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the element was successfully removed; otherwise, `false`\.

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.Remove(T)'></a>

## VisualCollection\<T\>\.Remove\(T\) Method

Removes the specified visual element from the collection\.

```csharp
public bool Remove(T? value);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.Remove(T).value'></a>

`value` [T](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.T 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection\<T\>\.T')

The visual element to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the element was successfully removed; otherwise, `false`\.

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.SetValues(System.Collections.Generic.IEnumerable_T_)'></a>

## VisualCollection\<T\>\.SetValues\(IEnumerable\<T\>\) Method

Replaces the current contents of the collection with a specified set of visual elements\.

```csharp
public void SetValues(System.Collections.Generic.IEnumerable<T>? values);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.SetValues(System.Collections.Generic.IEnumerable_T_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.T 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualCollection\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The new set of visual elements to populate the collection\.
### Explicit Interface Implementations

<a name='DiGi.Geometry.Visual.Core.Classes.VisualCollection_T_.System.Collections.IEnumerable.GetEnumerator()'></a>

## System\.Collections\.IEnumerable\.GetEnumerator\(\) Method

Returns an enumerator that iterates through the collection\.

```csharp
System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

<a name='DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_'></a>

## VisualObject\<TVisual,TSerializableObject\> Class

Represents a generic visual object that pairs a visual representation with a serializable data object\.

```csharp
public class VisualObject<TVisual,TSerializableObject> : DiGi.Core.Classes.GuidObject, DiGi.Geometry.Visual.Core.Interfaces.IVisualObject<TVisual, TSerializableObject>, DiGi.Geometry.Visual.Core.Interfaces.IVisualObject<TVisual>, DiGi.Geometry.Visual.Core.Interfaces.IVisualObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
    where TVisual : DiGi.Geometry.Visual.Core.Interfaces.IVisual
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject
```
#### Type parameters

<a name='DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.TVisual'></a>

`TVisual`

The type of the visual component, which must implement [IVisual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisual')\.

<a name='DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.TSerializableObject'></a>

`TSerializableObject`

The type of the serializable object, which must implement [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → VisualObject\<TVisual,TSerializableObject\>

Implements [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject&lt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualObject_TVisual,TSerializableObject_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject\<TVisual,TSerializableObject\>')[TVisual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.TVisual 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualObject\<TVisual,TSerializableObject\>\.TVisual')[,](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualObject_TVisual,TSerializableObject_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject\<TVisual,TSerializableObject\>')[TSerializableObject](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.TSerializableObject 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualObject\<TVisual,TSerializableObject\>\.TSerializableObject')[&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualObject_TVisual,TSerializableObject_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject\<TVisual,TSerializableObject\>'), [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject&lt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualObject_TVisual_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject\<TVisual\>')[TVisual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.TVisual 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualObject\<TVisual,TSerializableObject\>\.TVisual')[&gt;](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualObject_TVisual_ 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject\<TVisual\>'), [IVisualObject](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualObject 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.VisualObject()'></a>

## VisualObject\(\) Constructor

Initializes a new instance of the [VisualObject&lt;TVisual,TSerializableObject&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualObject\<TVisual,TSerializableObject\>') class\.

```csharp
public VisualObject();
```

<a name='DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.VisualObject(DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_)'></a>

## VisualObject\(VisualObject\<TVisual,TSerializableObject\>\) Constructor

Initializes a new instance of the [VisualObject&lt;TVisual,TSerializableObject&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualObject\<TVisual,TSerializableObject\>') class by copying another visual object\.

```csharp
public VisualObject(DiGi.Geometry.Visual.Core.Classes.VisualObject<TVisual,TSerializableObject>? visualObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.VisualObject(DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_).visualObject'></a>

`visualObject` [DiGi\.Geometry\.Visual\.Core\.Classes\.VisualObject&lt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualObject\<TVisual,TSerializableObject\>')[TVisual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.TVisual 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualObject\<TVisual,TSerializableObject\>\.TVisual')[,](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualObject\<TVisual,TSerializableObject\>')[TSerializableObject](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.TSerializableObject 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualObject\<TVisual,TSerializableObject\>\.TSerializableObject')[&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualObject\<TVisual,TSerializableObject\>')

The source visual object to copy from\.

<a name='DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.VisualObject(System.Text.Json.Nodes.JsonObject)'></a>

## VisualObject\(JsonObject\) Constructor

Initializes a new instance of the [VisualObject&lt;TVisual,TSerializableObject&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualObject\<TVisual,TSerializableObject\>') class from a JSON object\.

```csharp
public VisualObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.VisualObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to initialize the instance\.

<a name='DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.VisualObject(TVisual)'></a>

## VisualObject\(TVisual\) Constructor

Initializes a new instance of the [VisualObject&lt;TVisual,TSerializableObject&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualObject\<TVisual,TSerializableObject\>') class with a specified visual\.

```csharp
public VisualObject(TVisual? visual);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.VisualObject(TVisual).visual'></a>

`visual` [TVisual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.TVisual 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualObject\<TVisual,TSerializableObject\>\.TVisual')

The visual component associated with this object\.

<a name='DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.VisualObject(TVisual,TSerializableObject)'></a>

## VisualObject\(TVisual, TSerializableObject\) Constructor

Initializes a new instance of the [VisualObject&lt;TVisual,TSerializableObject&gt;](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_ 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualObject\<TVisual,TSerializableObject\>') class with a specified visual and serializable object\.

```csharp
public VisualObject(TVisual? visual, TSerializableObject? @object);
```
#### Parameters

<a name='DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.VisualObject(TVisual,TSerializableObject).visual'></a>

`visual` [TVisual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.TVisual 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualObject\<TVisual,TSerializableObject\>\.TVisual')

The visual component associated with this object\.

<a name='DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.VisualObject(TVisual,TSerializableObject).object'></a>

`object` [TSerializableObject](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.TSerializableObject 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualObject\<TVisual,TSerializableObject\>\.TSerializableObject')

The serializable data object associated with this object\.
### Properties

<a name='DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.Object'></a>

## VisualObject\<TVisual,TSerializableObject\>\.Object Property

Gets the serializable data object associated with this visual object\.

```csharp
public TSerializableObject? Object { get; private set; }
```

Implements [Object](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualObject_TVisual,TSerializableObject_.Object 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject\<TVisual,TSerializableObject\>\.Object')

#### Property Value
[TSerializableObject](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.TSerializableObject 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualObject\<TVisual,TSerializableObject\>\.TSerializableObject')

<a name='DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.Visual'></a>

## VisualObject\<TVisual,TSerializableObject\>\.Visual Property

Gets the visual component associated with this visual object\.

```csharp
public TVisual? Visual { get; private set; }
```

Implements [Visual](DiGi.Geometry.Visual.Core.Interfaces.md#DiGi.Geometry.Visual.Core.Interfaces.IVisualObject_TVisual_.Visual 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject\<TVisual\>\.Visual')

#### Property Value
[TVisual](DiGi.Geometry.Visual.Core.Classes.md#DiGi.Geometry.Visual.Core.Classes.VisualObject_TVisual,TSerializableObject_.TVisual 'DiGi\.Geometry\.Visual\.Core\.Classes\.VisualObject\<TVisual,TSerializableObject\>\.TVisual')