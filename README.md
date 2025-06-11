# PinPoint for Optimizely
Map widget for setting coordinates in Optimizely CMS through map of choice with Leaflet.js.<br/>

## Pictures
<div>
  <img src="Pictures/Lantmateriet-AutoComplete-1.png" width="400">
  <img src="Pictures/OSM-AutoComplete-1.png" width="400">
</div>

## Summary
The solution consists of 3 different project types.<br/>
`MapCore` contains shared logic between providers and Core Map files required to render the Leaflet map<br/>
`MapProvider.*provider*` contains a ProviderService that implements provider-specific settings.<br/>
`MapDemo` contains a demo website for testing the Map Widget.<br/>

The project has been tested with **Optimizely Alloy**, **Optimizely Decoupled MusicFestival** & **Optimizely Empty Project**.
MusicFestival is a sample project that uses the Content Delivery API in a headless CMS structure. https://github.com/episerver/musicfestival-vue-template

# Get started
1. Follow the specific Map Provider installation instructions:
   - For [OpenStreetMap](MapProvider.OpenStreetMap)
   - For [Lantmäteriet](MapProvider.Lantmateriet)
1. Start the project and browse to the Optimizely UI, default: http://localhost:8081/Util/Login (or port 5000)
1. Create a new page or block of the type that has the `MapsCoordinates` property
1. Test the PinPoint widget in the editor view

# Dev setup
1. Clone the repository
1. Run the `create-database.bat` to create an empty database
1. Open the solution and start the `MapDemo` project 
1. Create an admin user in the Optimizely UI: http://localhost:8081/Util/Login (or port 5000)
1. Create a new page in the Optimizely UI Edit-panel
1. Test the PinPoint widget in the editor view

> Note: The add-on does not include any template rendering, for example to show a map to site visitors. It only focuses on the CMS editing experience.

# Contributing
Thanks for your interest in contributing! There are many ways to contribute to this project. Get started [here](./CONTRIBUTING.md).

# Special thanks
[Ted&Gustaf](https://github.com/tedgustaf) for providing [GoogleMapsEditor](https://github.com/tedgustaf/optimizely-google-maps-editor/) which has inspired this project.<br/>
[Leaflet](https://leafletjs.com/) for providing the Leaflet map library.<br/>
[OpenStreetMap](https://www.openstreetmap.org/) for providing free and reliable map data.<br/>
[MightyLittleGeodesy](https://github.com/bjornsallarp/MightyLittleGeodesy) for providing an open source library to convert coordinate systems.<br/>
</br>
All of these projects are outstanding in their own right and have greatly contributed to the development of this project.
