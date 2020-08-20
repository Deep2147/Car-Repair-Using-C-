using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Assignment1_deep_patel
{
    class Methods
    {

        // All methods for the Application 
        public void printMenu(out string input)
        {
            Console.Write("\n-----------------------------------------------------------\n");
            Console.Write("Welcome, Press any key from 1 to 4 as per your requirement:");
            Console.Write("\n***********************************************************\n");
            Console.Write("\nPress 1 to modify vehicle");
            Console.Write("\nPress 2 to modify inventory");
            Console.Write("\nPress 3 to modify repair");
            Console.Write("\nPress 4 or q to exit program\n");
            Console.Write("\n**********************************************************\n");
            input = Console.ReadLine();
        }

        public void printRepair(out string input)
        {
            Console.Write("\n-----------------------------------------------------------\n");
            Console.Write("\nPlease press any key from 1 to 6 as per your requirement:");
            Console.Write("\n***********************************************************\n");
            Console.Write("\nPress 1 to view repair of a vehicle");
            Console.Write("\nPress 2 to add a new Repair activity");
            Console.Write("\nPress 3 to update a Repair activity");
            Console.Write("\nPress 4 to delete a Repair activity");
            Console.Write("\nPress 5 to list all repairable things");
            Console.Write("\nPress 6 to return to main menu or q to exit program\n");
            Console.Write("\n***********************************************************\n");
            input = Console.ReadLine();
        }

        public void Printinventory(out string input)
        {
            Console.Write("\n-----------------------------------------------------------\n");
            Console.Write("\nPlease press any key from 1 to 6 as per your requirement:");
            Console.Write("\n***********************************************************\n");
            Console.Write("\nPress 1 to view inventory for a vehicle");
            Console.Write("\nPress 2 to insert a new Inventory");
            Console.Write("\nPress 3 to update an inventory");
            Console.Write("\nPress 4 to delete an inventory");
            Console.Write("\nPress 5 to list all the inventories");
            Console.Write("\nPress 6 to return to main menu or q to exit program\n");
            Console.Write("\n***********************************************************\n");
            input = Console.ReadLine();
        }

        public void printvehicle(out string input)
        {
            Console.Write("\n-----------------------------------------------------------\n");
            Console.Write("\nPlease press any key from 1 to 6 as per your requirement:");
            Console.Write("\n***********************************************************\n");
            Console.Write("\nPress 1 to list all vehicle");
            Console.Write("\nPress 2 to add a new vehicle");
            Console.Write("\nPress 3 to update a vehicle");
            Console.Write("\nPress 4 to delete a vehicle");
            Console.Write("\nPress 5 to return to main menu or q to exit program\n");
            Console.Write("\n***********************************************************\n");
            input = Console.ReadLine();
        }

        //vehicle method to add vehicle to the List
        public void addvehicle(List<vehicle> vehicle)
        {
            string id, make, model, year, state;
            Console.WriteLine("\nEnter ID: ");
            id = Console.ReadLine();
            var listofvehicle = from vh in vehicle
                                where vh.Id == int.Parse(id)
                                select vh;
            
            Console.WriteLine("\nInsert company of the vehicle: ");
            make = Console.ReadLine();

            Console.WriteLine("\nInsert model of the vehicle: ");
            model = Console.ReadLine();

            Console.WriteLine("\nInsert year : ");
            year = Console.ReadLine();

            Console.WriteLine("\nInsert state : ");
            state = Console.ReadLine();

            vehicle.Add(new vehicle(int.Parse(id), make, model, int.Parse(year), state));

            Console.WriteLine("\nNew vehicle added\n");

        }
        // method to print the vehicle list
        public void printvehicle(List<vehicle> vehicle)
        {
            var listofvehicle = from vh in vehicle
                                select vh;
            foreach (var vh in listofvehicle)
            {
                Console.WriteLine("\nId: " 
                    + vh.Id + "\n Make : " +
                    vh.Make + "\n Model : "
                    + vh.Model + "\n Year :" 
                    + vh.Year + "\n state : " 
                    + vh.State + "\n");
            }
        }

        // Method to remove the vehicle from the list
        public void deletevehicle(List<vehicle> vehicle)
        {
            Console.WriteLine("\nEnter ID to delete vehicle :");
            string id = Console.ReadLine();
            var listofvehicle = from vh in vehicle
                                where vh.Id == int.Parse(id)
                                select vh;


           
            int index = vehicle.FindIndex(intA => intA.Id == int.Parse(id));

            Console.WriteLine("\nThis are the details of vehicle:");

            Console.WriteLine("\nId: " + vehicle[index].Id 
                + "\n Make : " + vehicle[index].Make
                + "\n Model : " + vehicle[index].Model 
                + "\n Year model :" + vehicle[index].Year
                + "\n state : " + vehicle[index].State + "\n");

            Console.WriteLine("\nAre you sure you want to delete (Y/N)?:");
            string inp = Console.ReadLine();
            if (inp.Equals("y") || inp.Equals("Y"))
            {
                vehicle.RemoveAt(index);//removing specified index

                Console.WriteLine("\nvehicle deleted\n");
            }
            else
            {
                Console.WriteLine("\nvehicle is not deleted try again\n");
            }
        }

        public void updatevehicle(List<vehicle> vehicle)
        {
            string id, make, model, year, state;
            Console.WriteLine("\nEnter id to update vehicle :");
            id = Console.ReadLine();

            var listofvehicle = from vh in vehicle
                                 where vh.Id == int.Parse(id)
                                 select vh;
            
            Console.WriteLine("\nprevious Details : ");
            int index = vehicle.FindIndex(intA => intA.Id == int.Parse(id));

            Console.WriteLine("Id: " + vehicle[index].Id 
                + "\n Make : " + vehicle[index].Make
                + "\n Model : " + vehicle[index].Model 
                + "\n Year :" + vehicle[index].Year
                + "\n state : " + vehicle[index].State + "\n");

            Console.WriteLine("insert new information with same ID");

            Console.WriteLine("\nEnter vehicle make: ");
            make = Console.ReadLine();

            Console.WriteLine("\nEnter vehicle model: ");
            model = Console.ReadLine();

            Console.WriteLine("\ninsert year: ");
            year = Console.ReadLine();

            Console.WriteLine("\ninsert state : ");
            state = Console.ReadLine();
            vehicle.RemoveAt(index);
            vehicle.Insert
                (index, new vehicle
                (int.Parse(id), make, model, int.Parse(year), state));
            Console.WriteLine("\nvehicle infromation updated\n");
        }


        public void printInventories(List<inventory> inventoriesList)
        {

            var InventoryList = from inven in inventoriesList
                                select inven;

            foreach (var inven in InventoryList)
            {
                Console.WriteLine("\nId: " + inven.Id
                    + "\n vehicle Id : " + inven.vehicleID 
                    + "\n Number On Hand : "
                    + inven.NumberOnHand 
                    + "\n Price :" + inven.Price + "\nCost : " + inven.Cost + "\n");
            }

        }

        public void printInventoryList(List<inventory> inventoriesList)
        {
            int index;
            do
            {
                Console.WriteLine("\nHow you want to Search Inventory " +
                    "Press 1 for vehicle ID or 2 for (Inventory) ID:");

                string inp = Console.ReadLine();
                if (inp.Equals("1") )
                {
                    Console.WriteLine("\nEnter the ID to preview :");
                    string id = Console.ReadLine();
                    var InventoryList = from inven in inventoriesList
                                        where inven.Id == int.Parse(id)
                                        select inven;


                    Console.WriteLine("\n Details : \n");

                    index = inventoriesList.FindIndex(vh => vh.Id == int.Parse(id));

                    break;
                }

                else if (inp.Equals("2") )
                {
                    Console.WriteLine("\ninsert vehicle ID to view incventory :");
                    string vhId = Console.ReadLine();

                   var InventoryList = from inven in inventoriesList
                                        where inven.vehicleID == int.Parse(vhId)
                                        select inven;

                   

                    Console.WriteLine("\n Details : \n");

                    index = inventoriesList.FindIndex(vh => vh.vehicleID == int.Parse(vhId));
                    break;
                }
                else
                {
                    Console.WriteLine("\n Please enter from following option:\n");
                    continue;
                }


            } while (true);

            Console.WriteLine("\nId: " + inventoriesList[index].Id 
                + "\n vehicle ID : " + inventoriesList[index].vehicleID
                + "\n Number on Hand : " + inventoriesList[index].NumberOnHand 
                + "\n Price :" + inventoriesList[index].Price
                + "\n Cost : " + inventoriesList[index].Cost 
                + "\n");

        }

        public void addInventory(List<inventory> inventoriesList, List<vehicle> vehicle)
        {
            string id, vehicleID, numOnHand, price, cost;
            Console.WriteLine("\nEnter ID: ");
            id = Console.ReadLine();
            var InventoryList = from vh in inventoriesList
                                where vh.Id == int.Parse(id)
                                select vh;


            
            Console.WriteLine("\nEnter vehicleID : ");
            vehicleID = Console.ReadLine();

            string answer = "";
            do
            {
                var vehiclecheck = from vh in vehicle
                                   where vh.Id == int.Parse(vehicleID)
                                   select vh;



                if (!vehiclecheck.Any())
                {
                    Console.WriteLine("\nYour entered vehicle ID is not present in vehicle List");
                    Console.WriteLine("\nYou want to proceed (Y/N)? ");
                    answer = Console.ReadLine();
                    if (!(answer.Equals("X") || answer.Equals("X")))
                    {
                        Console.WriteLine("\nEnter vehicleID : ");
                        vehicleID = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                else
                {
                    break;
                }

            } while (!(answer.Equals("X") || answer.Equals("X")));

            Console.WriteLine("\nInsert Number on Hand: ");
            numOnHand = Console.ReadLine();

            Console.WriteLine("\nInsert Price: ");
            price = Console.ReadLine();

            Console.WriteLine("\nInsert Cost : ");
            cost = Console.ReadLine();

            inventoriesList.Add(new inventory(int.Parse(id),
                int.Parse(vehicleID),
                int.Parse(numOnHand),
                double.Parse(price),
                double.Parse(cost)));

            Console.WriteLine("\nInventory ADDED\n");

        }
        public void updateInventory(List<inventory> inventoriesList)
        {
            string id, vehicleId, numOnHand, price, cost;
            Console.WriteLine("\nEnter the ID to UPDATE :");
            id = Console.ReadLine();
            var InventoryList = from inven in inventoriesList
                                where inven.Id == int.Parse(id)
                                select inven;



            Console.WriteLine("\n Details : ");

            int index = inventoriesList.FindIndex(vh => vh.Id == int.Parse(id));

            Console.WriteLine("\nId: " + inventoriesList[index].Id 
                + "\nvehicle ID : " + inventoriesList[index].vehicleID
                + "\n Number on Hand : " + inventoriesList[index].NumberOnHand 
                + "\n Price :" + inventoriesList[index].Price
                + "\n Cost : " + inventoriesList[index].Cost + "\n");

            Console.WriteLine("Enter new Information:");

            Console.WriteLine("\nInsert vehicleID : ");
            vehicleId = Console.ReadLine();

            Console.WriteLine("\nInsert Number on Hand: ");
            numOnHand = Console.ReadLine();

            Console.WriteLine("\nInsert Price: ");
            price = Console.ReadLine();

            Console.WriteLine("\nInsert Cost : ");
            cost = Console.ReadLine();

            inventoriesList.RemoveAt(index);

            inventoriesList.Insert
                (index, new inventory
                (int.Parse(id), int.Parse(vehicleId), int.Parse(numOnHand), double.Parse(price), int.Parse(cost))); //filling it with new one

            Console.WriteLine("\nInventory UPDATED!!\n");
        }

        public void deleteInventory(List<inventory> inventoriesList)
        {
            Console.WriteLine("\nEnter ID to delete vehicle:");
            string id = Console.ReadLine();
            var InventoryList = from inven in inventoriesList
                                where inven.Id == int.Parse(id)
                                select inven;


            int index = inventoriesList.FindIndex(x => x.Id == int.Parse(id));

            Console.WriteLine("\nThis the details of vehicle that you entered :");

            Console.WriteLine("\nId: " + inventoriesList[index].Id 
                + "\n vehicle ID : " + inventoriesList[index].vehicleID
               + "\n Number on Hand : " + inventoriesList[index].NumberOnHand 
               + "\n Price :" + inventoriesList[index].Price
               + "\n Cost : " + inventoriesList[index].Cost + "\n");


            Console.WriteLine("\nAre you sure you want to delete: (Y/N) ? :");
            string ans = Console.ReadLine();
            if (ans.Equals("y") || ans.Equals("Y") )
            {
                inventoriesList.RemoveAt(index);
                 Console.WriteLine("\nInventory DELETED!!\n");
            }

            else
            {
                Console.WriteLine("\nInventory IS NOT Deleted!!\n");
            }

        }

        public void printAllRepairActivities(List<repair> repairList)
        {

            var RepairList = from rep in repairList
                             select rep;

            foreach (var rep in RepairList)
            {
                Console.WriteLine("\nId: " + rep.Id 
                    + "\n Inventory Id : "
                    + rep.InventoryId 
                    + "\n What to Repair : "
                    + rep.WhatToRepair + "\n");
            }
        }

        public void printRepairActivity(List<repair> repairList)
        {
            int index;
            do
            {
                Console.WriteLine("\nEnter Repair Id :");
                string inp = "2";
                

                if (Int32.Parse(inp) == 2)
                {
                    Console.WriteLine("\nEnter the Repair ID  :");
                    string id = Console.ReadLine();
                    var res = from iven in repairList
                              where iven.Id == int.Parse(id)
                              select iven;


                    while (!repairList.Any())
                    {
                        Console.WriteLine("\nID DOESN'T EXIST.");
                        Console.WriteLine("\nEnter a VALID (Repair) ID : ");
                        id = Console.ReadLine();
                    }

                    Console.WriteLine("\n Details: \n");
                    index = repairList.FindIndex(vh => vh.Id == int.Parse(id));

                    break;
                }
                else
                {
                    Console.WriteLine("\n Please enter within following option ... \n");
                    continue;
                }

            } while (true);

            Console.WriteLine("\nId: " + repairList[index].Id 
                + "\n Inventory Id : "
                + repairList[index].InventoryId 
                + "\n What to Repair : "
                    + repairList[index].WhatToRepair + "\n");
        }
        public void addRepairActivity(List<repair> repairList, List<inventory> inventoriesList)
        {
            string id, inventoryId, whatToRepair;

            Console.WriteLine("\nEnter ID (ID should be unique): ");
            id = Console.ReadLine();


            var replis = from rep in repairList
                         where rep.Id == int.Parse(id)
                         select rep;


          

            Console.WriteLine("\nEnter Inventory ID : ");
            inventoryId = Console.ReadLine();
            string ans = "";
            do
            {
                var inventorycheck = from iven in inventoriesList
                                     where iven.Id == int.Parse(inventoryId)
                                     select iven;

                if (!inventorycheck.Any())
                {
                    Console.WriteLine("\nInventory ID is not valid");
                    Console.WriteLine("\nYou want to proceed (Y/N)? ");
                    ans = Console.ReadLine();
                    if (!(ans.Equals("y") || ans.Equals("y")))
                    {
                        Console.WriteLine("\nEnter Inventory ID : ");
                        inventoryId = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                else
                {
                    break;
                }


            } while (!(ans.Equals("y") || ans.Equals("y")));

            Console.WriteLine("\nInsert What to Repair: ");
            whatToRepair = Console.ReadLine();
            repairList.Add(new repair(int.Parse(id),
               int.Parse(inventoryId),
               whatToRepair));

            Console.WriteLine("\nRepair Activity ADDED!!\n");
        }
        public void updateRepairActivity(List<repair> repairList)
        {
            string id, inventoryId, whatToRepair;

            Console.WriteLine("\nEnter the ID of the Repair Activity you want to UPDATE :");
            id = Console.ReadLine();

            var RepairList = from rep in repairList
                             where rep.Id == int.Parse(id)
                             select rep;


            

            Console.WriteLine("\nOld Details : ");

            int index = repairList.FindIndex(vh => vh.Id == int.Parse(id));

            Console.WriteLine("\nId: " + repairList[index].Id 
                + "\n Inventory Id : "+ repairList[index].InventoryId 
                + "\n What to Repair : "
                    + repairList[index].WhatToRepair 
                    + "\n");

            Console.WriteLine("Enter new Information:");

            Console.WriteLine("\nInsert Inventory ID : ");
            inventoryId = Console.ReadLine();

            Console.WriteLine("\nInsert What to Repair: ");
            whatToRepair = Console.ReadLine();


            repairList.RemoveAt(index);
            repairList.Insert
               (index, new repair
               (int.Parse(id),
               int.Parse(inventoryId),
               whatToRepair));

            Console.WriteLine("\nRepair Activity UPDATED\n");
        }
        public void deleteRepairActivity(List<repair> repairList)
        {
            Console.WriteLine("\nEnter the ID of the Repair Activity you want to DELETE :");
            string id = Console.ReadLine();

            var InventoryList = from iven in repairList
                                where iven.Id == int.Parse(id)
                                select iven;



            int index = repairList.FindIndex(vh => vh.Id == int.Parse(id));

            Console.WriteLine("\nThis the details of Repair Activity that you entered :\n");

            Console.WriteLine("\nId: " + repairList[index].Id 
                + "\n Inventory Id : "
                           + repairList[index].InventoryId 
                           + "\n What to Repair : "
                               + repairList[index].WhatToRepair + "\n");

            Console.WriteLine("\nAre you sure you want to delete:(Y/N) ? :");
            string inp = Console.ReadLine();
            if (inp.Equals("y") || inp.Equals("Y"))
            {
                repairList.RemoveAt(index);

                Console.WriteLine("\nRepair Activity deleted :-)\n");
            }

            else
            {
                Console.WriteLine("\nActivity repair is not Deleted :-(\n");
            }
        }

    }
}
