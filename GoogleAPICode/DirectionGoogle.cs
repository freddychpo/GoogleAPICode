

//Metodo para obtener la direccion en formato json
public void GetDirectionJsonAsync(LatLng location, LatLng destination)
{
    //Origin of the route 
    string str_origin = "origin" + location.Latitude + "," + location.Longitude;

    //Destination of route
    string str_destination = "destination" + destination.Latitude + "," + destination.Longitude;

    //node
    string node = "node-driving";

    //Building the parameters to the webservice
    string parameters = str_origin + "&" + str_destination + "&" + "&" + node;

    //Output format
    string output = "json";

    string key = mapkey;

    //Building the final url string 
    string url = "https://maps.googleapis.com/maps/api/directions" + output + "?" + paremeters + key;

    string json = "";
    json = await GetGeoJsonAsyn(url);

    return json;
}