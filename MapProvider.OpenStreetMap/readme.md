# PinPoint for Optimizely
Map widget for setting coordinates in Optimizely CMS using OpenStreetMap maps.

## Pictures
<img src="https://raw.githubusercontent.com/preciofishbone/Optimizely-PinPoint/refs/heads/main/Pictures/Rosenhaga-osm-bild2.png" width="800">

## Getting started

### 1. Install the Map Provider

```bash
dotnet add package PinPoint.MapProvider.OpenStreetMap
```

### 2. Ensure your Startup class accepts IConfiguration in its constructor & register the Map Widget using IConfiguration:
```csharp
public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }
	
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddEditorMapWidget(_configuration);
    }
}
```

### 3. Add settings to appsettings.json, example:
```json
  "MapSettings": {
    "BaseUrl": "https://localhost:5000",
    "ApiTileUrl": "https://tile.openstreetmap.org",
    "ApiAutoCompleteUrl": "https://photon.komoot.io/api",
    "ApiSearchUrl": "https://nominatim.openstreetmap.org/search",
    "SearchPrefix": [ "Stockholm", "Halmstad", "" ],
    "DefaultLatitude": "58.39612293232598",
    "DefaultLongitude": "13.85600308041494",
    "DefaultZoom": "10",
    "MaxZoom": "17",
    "MinZoom": "8",
    "MapProviderName": "OpenStreetMap"
  },
```

### 4. Add a property of type MapsCoordinates or RequiredMapsCoordinates to a Page- or BlockType.
RequiredMapsCoordinates requires that coordinates are set before the content can be published. 
MapsCoordinates allows content to be published without coordinates being set. Example:
```csharp    
    public virtual MapsCoordinates Map { get; set; }
```

## Feedback
If you have any feedback, suggestions or contributions, please create an issue in the [Github repository](https://github.com/preciofishbone/Optimizely-PinPoint).
