// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

string[] valid_strings = { "Testandoasadfcvx", "Teste A+Teste2é13 basd", "Téèstândoççç aaa" };
string[] invalid_strings = { "Testandoasadfçcvx*", "%Teste A Teste 213 basd", "-Téèstândoççç aaa" };

var regexParse = new Regex(@"(^[\w\s_=+-]*$)");

Console.WriteLine("_______________________\nTesting for valid strings!");
// Testing for valid strings
foreach (string s in valid_strings)
{
    Console.WriteLine("Listing matches for: " + s);
    var matches = regexParse.Matches(s).ToArray();
    foreach (Match match in matches)
    {
        Console.WriteLine(match);
    }
}

Console.WriteLine("_______________________\nTesting for invalid strings!");

// Testing for invalid string
foreach (string s in invalid_strings)
{
    Console.WriteLine("Listing matches for: " + s);
    var matches = regexParse.Matches(s).ToArray();
    foreach (Match match in matches)
    {
        Console.WriteLine(match);
    }
}

/* Code Snipet: Regex for routes limited to Alphanumeric characters
 * 
 * 
using System.Text.RegularExpressions;

string[] valid_routes = {"/testroute1", "/test/route3", "/test/route4/", "/params/*"};
string[] invalid_routes = { "testroute", "test/testrout/*" };

var regexParse = new Regex(@"^(/)([a-zA-Z0-9/_ -])+(/)?");

// Testing valid routes
foreach (string route in valid_routes)
{
    Console.WriteLine("Listing matcher for: " + route);
    var matches = regexParse.Matches(route).ToArray();
    foreach (Match match in matches)
    {
        Console.WriteLine(match);
    }
}

// Testing invalid routes
foreach (string route in invalid_routes)
{
    Console.WriteLine("Listing matcher for: " + route);
    var matches = regexParse.Matches(route).ToArray();
    foreach (Match match in matches)
    {
        Console.WriteLine(match);
    }
}
*/

/* Code Snipet: Reading jsonfile with NewtonsoftJson and Dynamic variables
 * 
 * 
using Newtonsoft.Json;

string text = File.ReadAllText(@"C:\Users\luan.barbosa\Desktop\SGP 3\SGP_Parametros\sgp-parametros\Fiddle\Object String.json");



dynamic listParams = JsonConvert.DeserializeObject(text);

Console.WriteLine(listParams.param[0]);


public class Param
{
    public string name;
    public string value;
}
*/