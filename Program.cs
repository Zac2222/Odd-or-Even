// Review by Mauricio, good job!

bool runAgain = true;
    while(runAgain == true)
    {
        int num;
        bool isNumber;

        Console.WriteLine("Please enter a number and the program will say if it is even or odd");
        do
        {
            isNumber = int.TryParse(Console.ReadLine(), out num);
            if(isNumber == false)
            {
                Console.WriteLine("Please enter a valid number!");
            }
        }while(isNumber == false);

        if(num % 2 == 0)
        {
            Console.WriteLine(num + " is an even number.");
        }
        else
        {
            Console.WriteLine(num + " is an odd number.");
        }


        string choice = "";
	    Console.WriteLine("Would you like to run again? (y/n)");
        while(choice != "yes" & choice != "y" & choice != "no" & choice != "n")
        {
            choice = Console.ReadLine().ToLower();
        }
        
        if(choice == "y" || choice == "yes")
        {
            runAgain = true;
        }
        else if(choice == "n" || choice == "no")
        {
            runAgain = false;
            Console.WriteLine("Now exiting");
        }
    }
