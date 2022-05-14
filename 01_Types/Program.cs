// Comments
/*
    -Clarify code
        -detailing different concepts
        -Refrence
    -communicate to other developers / future you
    Track history
*/

// Single Line

/*
    Multi-line
*/

/*
    Solution
    when we create a solution file, the basic implementation of the command will grab the name of the parent dirrectory and assign it to the solution that it is generating.
        -In our case: dotnet new sln = csharpFundamentals.sln
        -2 ways to start it:
            -dotnet new sln -n [name.sln]
            -dotnet new sln (while inside folder)

    the solution will go on to group together the bulk of our notes

    what is in the package?
        -cproj: CSharp project file - holds the SDK (Software Development Kit) for us to run our projects.
        -obj [folder]: Various packages that help our code run (not a high concern rn)
        - cs: Where we right our code.
*/

/*
    Variables

    datatype variableName = value;

    - Must start with datatype and be given a name.
    - doesn't need to be assigned a value right away.
*/

/*
    Booleans
    - bool: 1 byte
        -stores true/false value
*/

/*
    characters
        -char: 2 bytes
         -stores single character/letter, surrounded by a single quote ''
*/
bool isdeclared = true;
bool isnotdeclared;
// console.writeline(isnotdeclared); breaks our build because a default value is not provided.

isnotdeclared = false;
Console.WriteLine(isnotdeclared);



// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

char a = 'a';
char sym = '?';
char num = '7';
char white =' ';
char specialchar = '\n';


/*
 String
 - string: 2 bytes per character
    -stores a sequence of characters, surrounded by double quotes "".

*/

string sample = "sample";
System.Console.WriteLine(sample);

/*
 numbers
  - int: 4 bytes
  -long: 8 bytes
*/

byte exapmle = 255; // anything betweeen 0 - 255 due to binary code
sbyte min = -128; // between -128 - 127 (128 X 2 while accounting for zero)
short example2 = 32767; // max
int intmin = -2147483648; 
Int32 intmax = 2147483647; // fits a 32-bit \
long longExp = 9223372036854775807;
Int64 longmin = -9223372036854775808;

byte numbyte = 25;
System.Console.WriteLine(numbyte);

// casting
System.Console.WriteLine((char) numbyte); // we are translating the byte into a character. this changes the value into the lis of characters.
System.Console.WriteLine((long) numbyte);