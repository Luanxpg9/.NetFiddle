// See https://aka.ms/new-console-template for more information

/* Code Snipet: Date Comparision
 * 
 

DateTime DataPrazo = new DateTime(2022, 08, 24);
DateTime DataInicio = new DateTime(2022, 08, 22);
DateTime DataPassou = new DateTime(2022, 08, 25);

List<DateTime> Lista = new List<DateTime> { DataInicio, DataPassou };

foreach (var data in Lista)
{
    if (data > DataPrazo)
    {
        Console.WriteLine("A data passou do prazo: " + data);
    }
    else
    {
       Console.WriteLine("A data não passou do prazo: " + data);
    }
}
*/

/* Code Snipet: Finding exact string on array of strings
 * 

var listNames = new List<String>();
listNames.Add("Joao F.");
listNames.Add("Stir H.");
listNames.Add("Jhon K.");
listNames.Add("Human H.");

var listName2 = listNames.Where(x => x.Equals("Joao F."));
foreach (var name in listName2)
{
    Console.WriteLine(name);
}
*/

/* Code Snipet: Check for valid field
                // name -> size[200]+regex[words+white space]
                // email -> size[200]+regex[words+special characters]
                // password -> size[100]
                 

using System.Text.RegularExpressions;
var Name = "Luan Barbosa";
var Email = "luan@email.com";
var SystemEmail = "segurança@system";
var Password = "Fr%1238/*-+.";

// Checking if fields are null
if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password)) throw new ArgumentException("Email, name or password can't be empty or null");

// Checking for size
if (Name.Length >= 200) throw new ArgumentException("Name must have less than 200 characters");
if (Email.Length >= 200) throw new ArgumentException("Email must have less than 200 characters");
if (Password.Length >= 100) throw new ArgumentException("Password must have less than 100 characters");

// Checking if matches the regex

// Test for Name
var nameParser = new Regex(@"(^[\w\s]*$)");

var nameMatches = nameParser.Matches(Name);
if (!(nameMatches.Count > 0)) throw new ArgumentException("Please enter a valid name without special characters");

// Test for email
var emailParser = new Regex(@"(^[\w@._-]*$)");

var emailMatches = emailParser.Matches(Email);
if (!(emailMatches.Count > 0)) throw new ArgumentException("Please enter a valid email!");
*/

/* Conde Snipet: String size count
 * 
 * 
 
var str = "Daenerys Stormborn of House Targaryen, the First of Her Name, Queen of the Andals and the First Men, Protector of the Seven Kingdoms, the Mother of Dragons, the Khaleesi of the Great Grass Sea, the Unburnt, the Breaker of Chains.";

Console.WriteLine(str.Length);
*/

/* Code Snipet: Regex for words limited to Alphanumeric characters + some special characters
 * 
 * 
using System.Text.RegularExpressions;

string[] valid_strings = { "Testandoasadfcvx", "Teste A+Teste2é13 basd", "Téèstândoççç aaa" };
string[] invalid_strings = { "Testandoasadfçcvx*", "%Teste A Teste 213 basd", "-Téèstândoççç aaa" };

var regexParse = new Regex(@"(^[\w\s@_=+-]*$)");

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
*/

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