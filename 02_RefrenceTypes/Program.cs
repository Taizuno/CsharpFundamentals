/*
Value types vs Reference Types
    - Value Types: have a specific size, and stored in stack memory.
    - Reference Tpes: have a variable size, and stored in heap memory.
*/

// Strings
string something;
string initialized = "This is initialized";

string firstN = "Joe";
string lastN = "Schmoe";

string fullN = firstN + " " + lastN;
System.Console.WriteLine(fullN);

// interpolation
string interpolatedfullN = $"{firstN} {lastN}";
System.Console.WriteLine(interpolatedfullN);

// Collections: a string is technically a collection of characters

char firstL = firstN[0];
System.Console.WriteLine(firstL);

string extraItem = "another string";

string[] stringA ={"Hello", "World","why", "is it", "always","hello world?", extraItem };
System.Console.WriteLine(stringA[1]);
int lengthV = stringA.Length();
System.Console.WriteLine(lengthV);
System.Console.WriteLine(stringA[stringA.Length - 1]);

// list
List<string> listofStrings = new List<string>();
listofStrings.Add("Hello");
listofStrings.Add("World");

List<int> listofInts;

