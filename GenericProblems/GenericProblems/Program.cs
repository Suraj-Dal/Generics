GenericProblems.Generic<int> maxInteger = new GenericProblems.Generic<int>(4, 8, 7);
GenericProblems.Generic<double> maxDouble = new GenericProblems.Generic<double>(7.5, 8.2, 4.2);
GenericProblems.Generic<string> maxString = new GenericProblems.Generic<string>("Apple", "Peach", "Banana");
Console.WriteLine("Max Integer is: " + maxInteger.showMax());
Console.WriteLine("Max Double is: " + maxDouble.showMax());
Console.WriteLine("Max String is: " + maxString.showMax());

