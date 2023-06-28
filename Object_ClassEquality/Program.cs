// See https://aka.ms/new-console-template for more information

using Object_ClassEquality;

#region Default
//PointR r1 = new PointR { X = 100, Y = 200};
//PointR r2 = new PointR { X = 100, Y = 200 };

//Console.WriteLine($"Records equal = {r1 == r2}"); // true
//Console.WriteLine($"Records Equal equal = {r1.Equals(r2)}"); // true

//PointC c1 = new PointC { X = 100, Y = 200 }; 
//PointC c2 = new PointC { X = 100, Y = 200 }; 

//Console.WriteLine($"Class equal = {c1 == c2}"); // false
//Console.WriteLine($"Class Equal equal = {c1.Equals(c2)}"); // false

//PointS s1 = new PointS { X = 100, Y = 200 };
//PointS s2 = new PointS { X = 100, Y = 200 };

//// The == and != operators can't operate on a struct unless the struct explicitly overloads them.
//Console.WriteLine($"Struct Equal = {s1 == s2}"); // true
//Console.WriteLine($"Struct Equal equal = {s1.Equals(s2)}"); // true
#endregion

// ---------------------------------------- |

//PointC c1 = new PointC { X = 100, Y = 200 }; 
//PointC c2 = new PointC { X = 100, Y = 200 };

//Console.WriteLine($"Class equal = {c1 == c2}"); 
//Console.WriteLine($"Class Equal equal = {c1.Equals(c2)}");

//Console.WriteLine($"c1 Hash Code is: {c1.GetHashCode()}");
//Console.WriteLine($"c2 Hash Code is: {c2.GetHashCode()}");


// --------------------------------------------- |


#region Integer Hash Codes
//int x = 123;
//int y = 297;

//Console.WriteLine($"X Hash Code is: {x.GetHashCode()}");
//Console.WriteLine($"Y Hash Code is: {y.GetHashCode()}");
#endregion

#region String Hash Code
//string str1 = "Hello";
//string str2 = "Hullo";

//Console.WriteLine($"str 1 Hash Code is: {str1.GetHashCode()}");
//Console.WriteLine($"str 2 Hash Code is: {str2.GetHashCode()}");

#endregion

#region  With Dictionary

PointC c1 = new PointC() { X = 100, Y = 200 };
PointC c2 = new PointC() { X = 100, Y = 300 };

Dictionary<PointC, string> dict = new Dictionary<PointC, string>();

Console.WriteLine("Before add");
dict.Add(c1, "c1");
dict.Add(c2, "c2");

PointC test = new PointC { X=100, Y=300 };

Console.WriteLine("Before lookup");
if (dict.ContainsKey(test))
    Console.WriteLine(dict[test]);
else
    Console.WriteLine("Not Found");

#endregion