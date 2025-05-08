Optimizely PinPoint
===================
Map widget for setting coordinates in Optimizely CMS using OpenStreetMap.
Released under the MIT license (http://opensource.org/licenses/MIT)

Getting started
===============
1.  Ensure your Startup class accepts IConfiguration in its constructor & register the Map Widget using IConfiguration:

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

2.  Add settings to appsettings.json, example:

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

3.  Add a property of type MapsCoordinates or RequiredMapsCoordinates to a Page- or BlockType.
    RequiredMapsCoordinates requires that coordinates are set before the content can be published. 
    MapsCoordinates allows content to be published without coordinates being set. Example:
    
    public virtual MapsCoordinates Map { get; set; }