using System;
using System.Collections.Generic;
using System.Linq;



namespace Assignment1_deep_patel
{
    class Program
    {
        ///// //////////////////////Console main function////////////////////////////////////////////////
        
        
        static void Main(string[] args)
        {
            Methods meth = new Methods();
            List<vehicle> vehicle = new List<vehicle>();
            List<repair> repairList = new List<repair>();
            List<inventory> inventoriesList = new List<inventory>();
            vehicle.Add(new vehicle(0001, "Supra", "GR", 2000, "used"));
            vehicle.Add(new vehicle(2000, "Mustang", "GT", 2020, "Fresh"));
            vehicle.Add(new vehicle(0300, "Lamborghini", "aventador", 2017, "used"));
            vehicle.Add(new vehicle(0040, "Vpier", "V10", 2018, "Fresh"));
            repairList.Add(new repair(50, 2, "wheels"));
            repairList.Add(new repair(20, 6, "hood"));
            repairList.Add(new repair(75, 3, "headlight"));
            repairList.Add(new repair(87, 7, "Engine"));
            inventoriesList.Add(new inventory(2, 0040, 21, 454000.99, 340000.60));
            inventoriesList.Add(new inventory(6, 0300, 22, 555500.00, 456000.00));
            inventoriesList.Add(new inventory(7, 2000, 23, 180003.20, 124700.99));
            inventoriesList.Add(new inventory(3, 0001, 23, 400400.99, 900003.56));

            int s = 1;
            string input;

            while (s == 1)
            {
                
                meth.printMenu(out input);

                    if(input.Equals("1"))
                {
                    do { 
                    meth.printvehicle(out input);
                        switch (input)
                        {
                            case "1":
                                Console.WriteLine("\n**********LIST FOR VEHICLES************\n");
                                meth.printvehicle(vehicle);
                                Console.WriteLine("\nPress **[V]** to get vehicle-Menu OR **[M]** " +
                                    "to get Main-Menu \n **[Q]** to Exit Program: ");
                                input = Console.ReadLine();
                                break;

                            case "2":
                                meth.addvehicle(vehicle);
                                Console.WriteLine("\n**********LIST FOR VEHICLES************\\n");
                                meth.printvehicle(vehicle);
                                Console.WriteLine("\nPress **[V]** to get vehicle-Menu OR **[M]** " +
                                    "to get Main-Menu \n **[Q]** to Exit Program: ");
                                input = Console.ReadLine();
                                break;

                            case "3":
                                meth.updatevehicle(vehicle);
                                Console.WriteLine("\n**********LIST FOR VEHICLES************\\n");
                                meth.printvehicle(vehicle);
                                Console.WriteLine("\nPress **[V]** to get vehicle-Menu OR **[M]** " +
                                    "to get Main-Menu \n **[Q]** to Exit Program: ");
                                input = Console.ReadLine();
                                break;

                            case "4":
                                meth.deletevehicle(vehicle);
                                Console.WriteLine("\n**********LIST FOR VEHICLES************\\n");
                                meth.printvehicle(vehicle);
                                Console.WriteLine("\nPress **[V]** to get vehicle-Menu OR **[M]** " +
                                    "to get Main-Menu \n **[Q]** to Exit Program: ");
                                input = Console.ReadLine();
                                break;

                            case "5":
                                break;

                            case "q":
                                Console.Write("Program ends!");
                                System.Environment.Exit(0);
                                break;

                            case "Q":
                                Console.Write("Program ends!");
                                System.Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Press provided key");
                                continue;
                                break;



                        }

                    } while (input.Equals("v") || input.Equals("V"));

                    if (input.Equals("q") || input.Equals("Q")) 
                    {

                        Console.Write("Program ended!");
                        break;
                    }
                }

                else if (input.Equals("2"))
                {
                   
                    do
                    {
                        meth.Printinventory(out input);
                        switch (input)
                        {

                            case "1":
                                meth.printInventoryList(inventoriesList);
                                Console.WriteLine("\nPress **[M]** to get Main-Menu OR **[I]** " +
                                    "to get Inventory \n **[Q]** to Exit Program: ");
                                input = Console.ReadLine();
                                break;
                            case "2":
                                meth.addInventory(inventoriesList, vehicle);
                                Console.WriteLine("\n**********LIST FOR VEHICLES************\n");
                                meth.printInventories(inventoriesList);
                                Console.WriteLine("\nPress **[M]** to get Main-Menu OR **[I]** " +
                                    "to get Inventory \n **[Q]** to Exit Program: ");
                                input = Console.ReadLine();
                                break;
                            case "3":
                                meth.updateInventory(inventoriesList);
                                Console.WriteLine("\n**********LIST FOR VEHICLES************\n");
                                meth.printInventories(inventoriesList);
                                Console.WriteLine("\nPress **[M]** to get Main-Menu OR **[I]** " +
                                    "to get Inventory \n **[Q]** to Exit Program: ");
                                input = Console.ReadLine();
                                break;
                            case "4":
                                meth.deleteInventory(inventoriesList);
                                Console.WriteLine("\n**********LIST FOR VEHICLES************\n");
                                meth.printInventories(inventoriesList);
                                Console.WriteLine("\nPress **[M]** to get Main-Menu OR **[I]** " +
                                    "to get Inventory \n **[Q]** to Exit Program: ");
                                input = Console.ReadLine();
                                break;
                            case "5":
                                Console.WriteLine("\n**********LIST FOR VEHICLES************\n");
                                meth.printInventories(inventoriesList);
                                Console.WriteLine("\nPress **[M]** to get Main-Menu OR **[I]** " +
                                    "to get Inventory \n **[Q]** to Exit Program: ");
                                input = Console.ReadLine();
                                break;
                            case "6":
                                System.Environment.Exit(0);
                                break;
                            case "q":
                                System.Environment.Exit(0);
                                Console.WriteLine("you've got been left");
                                break;
                            case "Q":
                                System.Environment.Exit(0);
                                Console.WriteLine("you've got been left");
                                break;

                            default:
                                Console.WriteLine("wrong Input");
                                break;





                        }

                    } while (input.Equals("i") || input.Equals("I"));

                    if (input.Equals("q") || input.Equals("Q")) 
                    {

                        Console.Write("program exited!");
                        break;
                    }
                }
                else if (input.Equals("3"))
                {
                    


                    do
                    {
                        meth.printRepair(out input);
                        switch (input)
                        {
                            case "1":
                                meth.printRepairActivity(repairList);
                                Console.WriteLine("\nPress **[M]** to get Menu OR **[R]** " +
                                    "to get repair_Menu \n **[Q]** to Exit Program: ");
                                input = Console.ReadLine();
                                break;
                            case "2":
                                meth.addRepairActivity(repairList, inventoriesList);
                                Console.WriteLine("\n************List for Repair Activity ***********\n");
                                meth.printAllRepairActivities(repairList);
                                Console.WriteLine("\nPress **[M]** to get Menu OR **[R]** " +
                                    "to get repair_Menu \n **[Q]** to Exit Program: ");
                                input = Console.ReadLine();
                                break;
                            case "3":
                                meth.updateRepairActivity(repairList);
                                Console.WriteLine("\n------Repair Activity List------\n");
                                meth.printAllRepairActivities(repairList);
                                Console.WriteLine("\nPress **[M]** to get Menu OR **[R]** " +
                                    "to get repair_Menu \n **[Q]** to Exit Program: ");
                                input = Console.ReadLine();
                                break;
                            case "4":
                                meth.deleteRepairActivity(repairList);
                                Console.WriteLine("\n************List for Repair Activity ***********\n");
                                meth.printAllRepairActivities(repairList);
                                Console.WriteLine("\nPress **[M]** to get Menu OR **[R]** " +
                                    "to get repair_Menu \n **[Q]** to Exit Program: ");
                                input = Console.ReadLine();
                                break;
                            case "5":
                                Console.WriteLine("\n************List for Repair Activity ***********\n");
                                meth.printAllRepairActivities(repairList);
                                Console.WriteLine("\nPress **[M]** to get Menu OR **[R]** " +
                                    "to get repair_Menu \n **[Q]** to Exit Program: ");
                                input = Console.ReadLine();
                                break;
                            case "6":
                                System.Environment.Exit(0);
                                break;

                            default:
                                Console.WriteLine("Invalid Input");
                                System.Environment.Exit(0);
                                break;



                        }

                    } while (input.Equals("r") || input.Equals("R"));

                    if (input.Equals("q") || input.Equals("Q")) 
                    {

                        Console.Write("Program finished!");
                        break;
                    }

                }
                else if (input.Equals("q") || input.Equals("Q") ||input.Equals("4"))
                {
                    Console.Write("program finished!");
                    break;
                }

                else
                {
                    Console.Write("Please choose one:");
                    Console.ReadKey();
                    continue;

                }

                Console.WriteLine("While loop end");
                
            }

            Console.ReadKey();

        }

    }
}






    




            