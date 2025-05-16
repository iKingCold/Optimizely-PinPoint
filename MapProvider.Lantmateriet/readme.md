# PinPoint for Optimizely
Map widget for setting coordinates in Optimizely CMS using Lantmäteriet maps.

## Pictures
<img src="https://raw.githubusercontent.com/preciofishbone/Optimizely-PinPoint/refs/heads/main/Pictures/Ekens-lantmateriet-bild2.png" width="800">

## Prerequisites
### - API-Key from Lantmäteriet

## Getting started

### 1.  Ensure your Startup class accepts IConfiguration in its constructor & register the Map Widget using IConfiguration:
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

### 2.  Add settings to appsettings.json, example:
```json
  "MapSettings": {
    "BaseUrl": "https://localhost:8081",
    "ApiTileUrl": "https://maps.lantmateriet.se/topowebb/v1.1/wmts/1.0.0/",
    "ApiAutoCompleteUrl": "https://api.lantmateriet.se/distribution/produkter/belagenhetsadress/v4.2/autocomplete/adress",
    "ApiSearchUrl": "https://api.lantmateriet.se/distribution/produkter/belagenhetsadress/v4.2/referens/fritext",
    "SearchPrefix": [ "Stockholm", "Falkenberg", "" ],
    "Identifier": "topowebb",
    "Username": "username",
    "Password": "password",
    "AuthType": "Basic",
    "DefaultLatitude": "58.39612293232598",
    "DefaultLongitude": "13.85600308041494",
    "DefaultZoom": "10",
    "MaxZoom": "17",
    "MinZoom": "8",
    "MapProviderName": "Lantmäteriet"
  },
```

### 3.  Add a property of type MapsCoordinates or RequiredMapsCoordinates to a Page- or BlockType.
RequiredMapsCoordinates requires that coordinates are set before the content can be published. 
MapsCoordinates allows content to be published without coordinates being set. Example:
```csharp    
    public virtual MapsCoordinates Map { get; set; }
```

## Feedback
If you have any feedback, suggestions or contributions, please create an issue in the [Github repository](https://github.com/preciofishbone/Optimizely-PinPoint).
