// Maps store key-value pairs
//keys are unique
//called dictionary in c#
var dictionary = new Dictionary<string, double>();
//or
var dictionary1 = new Dictionary<string, double>() { { "key1", 2.1 }, { "key2", 2.3 } };

// put(key, value)	Adds (or replaces) a row in the map with the specified key and value.
// myMap.Add(key, value) or myMap[key] = value	
// O(1) 
// Performance of hashing the key (assuming good conflict resolution) and assigning the value

// get(key)	Gets the value for the specified key.	
// myMap[key]
// O(1)
// Performance of hashing the key (assuming good conflict resolution) and getting the associated value

// remove(key)	Removes the row from the map containing the specified key.
// myMap.Remove(key)
// O(1)
// Performance of hashing the key (assuming good conflict resolution) and removing the associated value

// member(key) Determines if "key" is in the map.	
// myMap.ContainsKey(key)	
// O(1)
// Performance of hashing the key (assuming good conflict resolution)

// size()	Returns the number of items in the map.	
// myMap.Count	
// O(1)
// Performance of returning the size of the map

//classes are maps

{
  "timestamp": 1584638006, 
  "message": "success", 
  "iss_position": {
    "longitude": -149.9053,
    "latitude": -35.9225
  }
}
class SpaceStation
{
    public long Timestamp { get; set; }
    public string Message { get; set; }
    public Location IssPosition { get; set; }
}

class Location
{
    public double Longitude { get; set; }
    public double Latitude { get; set; }
}

var spaceStation = JsonSerializer.Deserialize<SpaceStation>(json);
var lon = spaceStation.IssPosition.Longitude;
var lat = spaceStation.IssPosition.Latitude;
Console.WriteLine($"Space Station at Lon: {lon} Lat: {lat}");


//================
{
  "people": [
    { "craft": "ISS", "name": "Andrew Morgan" }, 
    { "craft": "ISS", "name": "Oleg Skripochka" }, 
    { "craft": "ISS", "name": "Jessica Meir" }
  ], 
  "message": "success", 
  "number": 3
}  

class Space
{
    public Person[] People { get; set; }
    public string Message { get; set; }
    public int Number { get; set; }
}

class Person
{
    public string Craft { get; set; }
    public string Name { get; set; }
}


    
// var space = JsonSerializer.Deserialize<Space>(json);
// foreach (var person in space.People)
// {
//     Console.WriteLine(person.Name);
// }

//========

var letters = new[] {'A', 'A', 'B', 'G', 'C', 'G', 'G', 'D', 'B'};
var summaryTable = new Dictionary<char, int>();

foreach (var letter in letters)
{
  // If the letter is not in our summary table yet, add it
  if (!summaryTable.ContainsKey(letter))
  {
    // The key is the letter since we want to summarize how
    // many letters we have.  Since it the first time we 
    // have seen this letter, we will set the value to 1.
    summaryTable[letter] = 1;
  }

  // If the letter is in the table, then update the value
  else
  {
    // We want to increase the value by 1 since we have 
    // already seen this letter before
    summaryTable[letter] += 1;
  }
}

Console.WriteLine(string.Join(", ", summaryTable));
// [A, 2], [B, 2], [G, 3], [C, 1], [D, 1]