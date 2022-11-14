// See https://aka.ms/new-console-template for more information

using LabQuestions14_11_22;

/// Q.) 1. PassengerNames

//string[] arr = new string[10];

//int choice;

//var names = new PassengerNames();

//char flag = 'y';
//names.EnterData();


//while (flag == 'y')
//{
//    Console.WriteLine(" 1.Ascending Order \n 2. Descending Order \n 3.Search Names \n 4.Split Names \n 5.Print Duplicates \n 6.Print Length of Names");
//    Console.Write("\n Enter the choice : ");
//    choice = int.Parse(Console.ReadLine());

//    switch (choice)
//    {
//        case 1:
//            names.AscendingOrder();
//            break;
//        case 2:
//            names.DescendingOrder();
//            break;
//        case 3:
//            names.SearchNames();
//            break;
//        case 4:
//            names.SplitNames();
//            break;
//        case 5:
//            names.PrintDuplicates();
//            break;
//        case 6:
//            names.PrintLength();
//            break;

//        default:
//            Console.WriteLine("Invalid Choice");
//            break;
//    }

//    Console.WriteLine("\n Do you want to continue(Y/N)");
//    flag = char.Parse(Console.ReadLine());
//}

/// Q.) 2. FlightFares


//var f = new FlightFares();

//f.BookingTime = "10 AM";
//Console.WriteLine(f.BookingTime);
//f.FlightFare = 100;

///Q.) 4. PassengerDateofBirth


//var A = new PDateofBirth();
//A.SetData();
//A.GetData();
//A.Details();

///Q.) 5. FlightEvenOrOdd

var flight = new FlightEvenOdd();
flight.Assign();