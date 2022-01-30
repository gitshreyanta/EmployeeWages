// See https://aka.ms/new-console-template for more information
using EmpolyeeWages;
Console.WriteLine("Hello, World!");
//Emp1 emp1 = new Emp1();
//Emp1 emp2 = new Emp1();
//emp1.Work( "Airtel" , 15, 25, 50 );
//emp2.Work( "Pepsi" , 15, 20, 140);
Emp1 empWage = new Emp1();
//Emp1 Airtel = new Emp1();
//Airtel.Work("Airtel", 15, 25, 50);
//Airtel.computeEmpWage();
//Console.WriteLine(Airtel.ToString());



//Emp1 Pepsi = new Emp1();
//Pepsi.Work("Pepsi", 15, 25, 50);
//Pepsi.computeEmpWage();
//Console.WriteLine(Pepsi.ToString());

empWage.AddCompany("Airtel", 20, 40, 50);
empWage.AddCompany("Pepsi", 20, 40, 100);
empWage.GetWage();







