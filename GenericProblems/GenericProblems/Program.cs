int[] arr = { 7, 6, 3, 8, 5 };  
double[] arr1 = {5.2, 4.6, 7.4, 6.4, 8.4};
string[] arr2 = { "Apple", "Peach", "Banana", "Oragne", "Guava" };
GenericProblems.Generic<int> maxInteger = new GenericProblems.Generic<int>(arr);
GenericProblems.Generic<double> maxDouble = new GenericProblems.Generic<double>(arr1);
GenericProblems.Generic<string> maxString = new GenericProblems.Generic<string>(arr2);
maxInteger.printMax();
maxDouble.printMax();
maxString.printMax();

