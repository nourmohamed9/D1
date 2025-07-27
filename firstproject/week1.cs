//output
System.Console.WriteLine("hello word");
    Console.WriteLine("Hello, World!");
//input
/*string fullName= System.Console.ReadLine();
int age = Convert.ToInt32(Console.ReadLine());
char gender = Convert.ToChar(Console.ReadLine());
double salary =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("hello" + fullName);
Console.WriteLine($"hello {fullName} , age is: {age} , gender is : {gender} ,salary : {salary}");
//////////////////////////////////////////////  */
/*Console.WriteLine("enter your favorite between 1 and 100");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"no really ,{num} is my favorite");
////////////////////////////////////////////////////// */
/*int studentgrade1 = 100;  //datatype
//collection datatype
int[] student1 = [100, 98, 70, 65];
Console.WriteLine(student1[0]);
Console.WriteLine(student1[^1]);//65   

///////////////////////////////////////////////
/* int[] newStudent = new int[5] { 100, 97 };
newStudent[0] = 0; */
int priceSmall = 25;
int largePrice = 35;
Double tax = 0.06;
string valid = "Estimate are valid for 30 Days";
Console.WriteLine($"Price of small Carpets = {priceSmall} ");
Console.WriteLine($"Price of large Carpets = {largePrice} ");
Console.Write("number Of Small Carpets: ");
int small =Convert.ToInt32(Console.ReadLine());
Console.Write("number Of Large Carpets: ");
 int large = Convert.ToInt32(Console.ReadLine());
int total = (priceSmall * small) + (largePrice * large);
double TotalTax = total * tax;
double finalTotal = total + TotalTax;
Console.WriteLine($"Total estimate : {finalTotal}");
Console.WriteLine(valid);







