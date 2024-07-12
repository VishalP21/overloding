using overloding;

overlode overlode = new();

overlode.addcity("vadodra");

List <string> city_name = new List<string>();
city_name.Add("anand");
city_name.Add("nadiad");
city_name.Add("dahod");

overlode.addcity(city_name);

foreach (string p in overlode.cities)
{
    Console.WriteLine(p);
}

overlode.find("anand","vadodra");