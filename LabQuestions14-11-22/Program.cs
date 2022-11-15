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
//var time = Console.ReadLine();
//f.FlightFare = 100;

/// Q.) 3. 10FlightFares

//var fare = new Flight();

//int choice;

//fare.EnterData();

//char flag = 'y';


//while (flag == 'y')
//{
//    Console.WriteLine("\n 1.Ascending sort \n 2. Descending Sort \n 3.Search \n 4.Minimum and Maximum value \n 5.duplicates");
//    Console.Write("Enter the choice : ");
//    choice = int.Parse(Console.ReadLine());

//    switch (choice)
//    {
//        case 1:
//            fare.Asort();
//            break;
//        case 2:
//            fare.Dsort();
//            break;
//        case 3:
//            fare.SearchFare();
//            break;
//        case 4:
//            fare.minmaxval();
//            break;
//        case 5:
//            fare.duplicate();
//            break;


//        default:
//            Console.WriteLine("Invalid choice");
//            break;
//    }

//    Console.WriteLine("Do you want to continue(y/n)?");
//    flag = char.Parse(Console.ReadLine());
//}

/// Q.) 4.PassengerDateofBirth


//var A = new PDateofBirth();
//A.SetData();
//A.GetData();
//A.Details();

///Q.) 5. FlightEvenOrOdd


var flight = new FlightEvenOrOdd();

flight.Assign();


///Q.) 12. MergeNameandDestination

//string[] Name = new string[1];
//for (int i = 0; i < Name.Length; i++)
//{
//    Console.WriteLine("Enter your Name");
//    Name[i] = Console.ReadLine();
//}

//string[] Destination = new string[1];
//for (int i = 0; i < Name.Length; i++)
//{
//    Console.WriteLine("Enter your Destination");
//    Destination[i] = Console.ReadLine();
//}


//var Details = new List<string>();
//Details.AddRange(Name);
//Details.AddRange(Destination);
//string[] Display = Details.ToArray();
//Console.WriteLine("Combined Name and Destination is : ");
//foreach (string Combined in Display)
//{
//    Console.WriteLine(Combined);
//}