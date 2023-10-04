// 'name' is a varibale and 'MyName' is the value
string name = "MyName";
// int stores integers
int age = 12; 
// double could have decimal
double score = 80.5;
// or could be false
bool isValid = true; 

//To print in the console
Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Score: " + score);
Console.WriteLine("IsValid: " + isValid);

// ----------- practice more here -------------

string s1 = ""; // you could define whatever string here
string s2 = "123"; // same here some random integere inside double quote
string firstName = "fName";
string lastName = "lName";
string fullName = firstName + "-" + lastName; // would be "fname - lname"

int length = fullName.Length; //length of the fullName (how many chars!)
string convertToString = length.ToString(); //convert int to string using ToString method (built in method)

int num1 = 1;
int num2 = 2;
int sum = num1 + num2; // sum
int mul = sum * sum; // multiply
int divide = num2 / num1; // divide
int remainder = num2 % num1;
int calc = (num1 + num2) / mul * 10; //mathematical experssion

double d0 = 5;
double d1 = 1.1;
double d2 = 2.2;
double d3 = d1 + d2;

bool b1 = true;
bool b2 = false;

// ----------- mor advanced topics in case you are intersted! -------------

double double1 = 1.9;
int int1 = 10;

// you can not implicitly convert here, if you write the code below, compiler breaks
// int result = double1 + int1;

// you can fix it by explicit casting
int int_result = (int)double1 + int1; // result = 11 (decimal is ignored!)

double double_result = double1 + int1; // now the result = 11.9 because int can be casted to double implicitly

// ------

string string1 = "120"; // we have a string here, but we know it has integer as a value
int int_result1 = int.Parse(string1); // we can parse string to int becomes 120

string string2 = "a123"; //we don't have a pure string here
//int int_result2 = int.Parse(string2); // it will throw an exception because cannot parse
