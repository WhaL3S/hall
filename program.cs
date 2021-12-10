class MainProgram
    {
        static void Main(string[] args)
        {
            /// Variables
            string c1Type, c2Type, c3Type;
            double c1Length, c2Length, c3Length, 
                   c1Width, c2Width, c3Width, 
                   c1Height, c2Height, c3Height;
            double lengthHall, widthHall;
            double numberOfChair1 = 0,
                   numberOfChair2 = 0,
                   numberOfChair3 = 0;
            double change;

            /// Entering data about the first chair
            Console.WriteLine("Enter the type, length, width and height of the first chair");
            c1Type = Console.ReadLine();
            c1Length = double.Parse(Console.ReadLine());
            c1Width = double.Parse(Console.ReadLine());
            c1Height = double.Parse(Console.ReadLine());

            /// Entering data about the second chair
            Console.WriteLine("Enter the type, length, width and height of the second chair");
            c2Type = Console.ReadLine();
            c2Length = double.Parse(Console.ReadLine());
            c2Width = double.Parse(Console.ReadLine());
            c2Height = double.Parse(Console.ReadLine());

            /// Entering data about the third chair
            Console.WriteLine("Enter the type, length, width and height of the third chair");
            c3Type = Console.ReadLine();
            c3Length = double.Parse(Console.ReadLine());
            c3Width = double.Parse(Console.ReadLine());
            c3Height = double.Parse(Console.ReadLine());

            /// Creation of chair class objects with properties
            Chair c1 = new Chair(c1Type, c1Length, c1Width, c1Height);
            Chair c2 = new Chair(c2Type, c2Length, c2Width, c2Height);
            Chair c3 = new Chair(c3Type, c3Length, c3Width, c3Height);

            Console.WriteLine("_________________________________________________________");

            /// Printing data about the chairs
            c1.PrintData(c1);
            c2.PrintData(c2);
            c3.PrintData(c3);

            Console.Write("_________________________________________________________");

            /// Variables of Area of each chair and calculation of them
            double c1Area, c2Area, c3Area;
            c1Area = c1.Area(c1);
            c2Area = c2.Area(c2);
            c3Area = c3.Area(c3);

            /// Finding and printing the highest chair(s)
            Console.WriteLine("\nChair(s) with the largest area is(are): ");
            if (c1Area >= c2Area && c1Area >= c3Area)
            {
                Console.WriteLine(c1.GetChairType());
            }
            if (c2Area >= c1Area && c2Area >= c3Area)
            {
                Console.WriteLine(c2.GetChairType());
            }
            if (c3Area >= c1Area && c3Area >= c2Area)
            {
                Console.WriteLine(c3.GetChairType());
            }

            Console.WriteLine("_________________________________________________________");
            
            /// Creation of hall class object and giving values 
            lengthHall = 2300;
            widthHall = 500;
            Hall h = new Hall(lengthHall, widthHall);
            Console.WriteLine("The hall has the length of {0} and the width of {1}", h.GetLengthHall(), h.GetWidthHall());
            change = h.GetLengthHall();

            Console.WriteLine("_________________________________________________________");

            /// Checking if the chairs undergo height requirement and calculate the number of chairs
            if (c1.GetChairHeight() <= 50 && c1.GetChairHeight() >= 40)
            {
                Console.WriteLine("{0} type chair is valid for the hall", c1.GetChairType());
                numberOfChair1 = Math.Floor(((h.GetLengthHall() - 300) / 2) / c1.GetChairLength());
                numberOfChair1 = numberOfChair1 * Math.Floor(h.GetWidthHall() / (30 + c1.GetChairWidth())) * 2;
                Console.WriteLine("{0} number of {1} type chairs is enough for the hall\n",
                numberOfChair1, c1.GetChairType());
            }
            else
            {
                Console.WriteLine("{0} type chair is not valid for the hall", c1.GetChairType());
            }

            if (c2.GetChairHeight() <= 50 && c2.GetChairHeight() >= 40)
            {
                Console.WriteLine("{0} type chair is valid for the hall", c2.GetChairType());
                numberOfChair2 = Math.Floor(((h.GetLengthHall() - 300) / 2) / c2.GetChairLength());
                numberOfChair2 = numberOfChair2 * Math.Floor(h.GetWidthHall() / (30 + c2.GetChairWidth())) * 2;
                Console.WriteLine("{0} number of {1} type chairs is enough for the hall\n",
                numberOfChair2, c2.GetChairType());
            }
            else
            {
                Console.WriteLine("{0} type chair is not valid for the hall", c2.GetChairType());
            }

            if (c3.GetChairHeight() <= 50 && c3.GetChairHeight() >= 40)
            {
                Console.WriteLine("{0} type chair is valid for the hall", c3.GetChairType());
                numberOfChair3 = Math.Floor(((h.GetLengthHall() - 300) / 2) / c3.GetChairLength());
                numberOfChair3 = numberOfChair3 * Math.Floor(h.GetWidthHall() / (30 + c3.GetChairWidth())) * 2;
                Console.WriteLine("{0} number of {1} type chairs is enough for the hall",
                numberOfChair3, c3.GetChairType());
            }
            else
            {
                Console.WriteLine("{0} type chair is not valid for the hall", c3.GetChairType());
            }

            Console.WriteLine("_________________________________________________________");

            /// Setting new value to the length of the hall
            h.SetLengthHall(2000);
            Console.WriteLine("The length of the hall set to {0}", h.GetLengthHall());

            /// Calculate the number of chairs, which undergoe hall requirement, after changing hall length
            if (c1.GetChairHeight() <= 50 && c1.GetChairHeight() >= 40)
            {
                numberOfChair1 = Math.Floor(((h.GetLengthHall() - 300) / 2) / c1.GetChairLength());
                numberOfChair1 = numberOfChair1 * Math.Floor(h.GetWidthHall() / (30 + c1.GetChairWidth())) * 2;
            }
            if (c2.GetChairHeight() <= 50 && c2.GetChairHeight() >= 40)
            {
                numberOfChair2 = Math.Floor(((h.GetLengthHall() - 300) / 2) / c2.GetChairLength());
                numberOfChair2 = numberOfChair2 * Math.Floor(h.GetWidthHall() / (30 + c2.GetChairWidth())) * 2;
            }
            if (c3.GetChairHeight() <= 50 && c3.GetChairHeight() >= 40)
            {
                numberOfChair3 = Math.Floor(((h.GetLengthHall() - 300) / 2) / c3.GetChairLength());
                numberOfChair3 = numberOfChair3 * Math.Floor(h.GetWidthHall() / (30 + c3.GetChairWidth())) * 2;
            }

            /// The calculation of the length decrease 
            change = change - h.GetLengthHall();

            Console.Write("_________________________________________________________\n");
            
            if (numberOfChair1 == 0 && numberOfChair2 == 0 && numberOfChair3 == 0)
            {
                /// Exception when none of the chair is suitable to the hall
                Console.WriteLine("None of the given types of chair can be placed in the hall");
            }
            else
            {
                /// Finding which type of chair is needed least for the certain decrease of the hall length
                if (numberOfChair1 == 0 && numberOfChair2 != 0 && numberOfChair3 != 0)
                {
                    if (numberOfChair2 <= numberOfChair3)
                    {
                        Console.WriteLine("{0} type will be needed the least when the length of hall decreases by {1}",
                                        c2.GetChairType(), change);
                    }
                    if (numberOfChair3 <= numberOfChair2)
                    {
                        Console.WriteLine("{0} type will be needed the least when the length of hall decreases by {1}",
                                        c3.GetChairType(), change);
                    }
                }
                else if (numberOfChair2 == 0 && numberOfChair1 != 0 && numberOfChair3 != 0)
                {
                    if (numberOfChair1 <= numberOfChair3)
                    {
                        Console.WriteLine("{0} type will be needed the least when the length of hall decreases by {1}",
                                        c1.GetChairType(), change);
                    }
                    if (numberOfChair3 <= numberOfChair1)
                    {
                        Console.WriteLine("{0} type will be needed the least when the length of hall decreases by {1}",
                                        c3.GetChairType(), change);
                    }
                }
                else if (numberOfChair3 == 0 && numberOfChair1 != 0 && numberOfChair2 != 0)
                {
                    if (numberOfChair1 <= numberOfChair2)
                    {
                        Console.WriteLine("{0} type will be needed the least when the length of hall decreases by {1}",
                                        c1.GetChairType(), change);
                    }
                    if (numberOfChair2 <= numberOfChair1)
                    {
                        Console.WriteLine("{0} type will be needed the least when the length of hall decreases by {1}",
                                        c2.GetChairType(), change);
                    }
                }
                else if (numberOfChair1 == 0 && numberOfChair2 == 0 && numberOfChair3 != 0)
                {
                    Console.WriteLine("{0} type will be needed the least when the length of hall decreases by {1}",
                                        c3.GetChairType(), change);
                }
                else if (numberOfChair1 == 0 && numberOfChair3 == 0 && numberOfChair2 != 0)
                {
                    Console.WriteLine("{0} type will be needed the least when the length of hall decreases by {1}",
                                        c2.GetChairType(), change);
                }
                else if (numberOfChair2 == 0 && numberOfChair3 == 0 && numberOfChair1 != 0)
                {
                    Console.WriteLine("{0} type will be needed the least when the length of hall decreases by {1}",
                                        c1.GetChairType(), change);
                }
                else if (numberOfChair1 != 0 && numberOfChair2 != 0 && numberOfChair3 != 0)
                {
                    if (numberOfChair1 <= numberOfChair2 && numberOfChair1 <= numberOfChair3)
                    {
                        Console.WriteLine("{0} type will be needed the least when the length of hall decreases by {1}",
                                        c1.GetChairType(), change);
                    }
                    if (numberOfChair2 <= numberOfChair1 && numberOfChair2 <= numberOfChair3)
                    {
                        Console.WriteLine("{0} type will be needed the least when the length of hall decreases by {1}",
                                        c2.GetChairType(), change);
                    }
                    if (numberOfChair3 <= numberOfChair1 && numberOfChair3 <= numberOfChair2)
                    {
                        Console.WriteLine("{0} type will be needed the least when the length of hall decreases by {1}",
                                        c3.GetChairType(), change);
                    }
                }
            } 
        }
