using System;

// Value Type (int)
int a = 10;
int b = a;

b = 20;

Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");

// int is a value type.
// Copying creates a new independent value.

// Reference Type (Array)

int[] arr1 = { 1, 2, 3 };
int[] arr2 = arr1;

arr2[0] = 100;

Console.WriteLine(arr1[0]);
Console.WriteLine(arr2[0]);

// Arrays are reference types.
// Both variables point to the same array.

// Struct

CoordinateStruct s1 = new CoordinateStruct { X = 10, Y = 20 };
CoordinateStruct s2 = s1;

s2.X = 50;

Console.WriteLine($"s1.X = {s1.X}");
Console.WriteLine($"s2.X = {s2.X}");

// Struct is a value type.
// Copying creates a new independent object.

// Class

CoordinateClass c1 = new CoordinateClass { X = 10, Y = 20 };
CoordinateClass c2 = c1;

c2.X = 50;

Console.WriteLine($"c1.X = {c1.X}");
Console.WriteLine($"c2.X = {c2.X}");

// Class is a reference type.
// Both variables point to the same object.