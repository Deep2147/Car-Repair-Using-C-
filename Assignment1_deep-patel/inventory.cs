using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class inventory
{
    private int id;
    private int vehicleId;
    private int numberOnHand;
    private double price;
    private double cost;

    public inventory(int id, int vehicleId, int numberOnHand, double price, double cost)
    {
        Id = id;
        vehicleID = vehicleId;
        NumberOnHand = numberOnHand;
        Price = price;
        Cost = cost;
    }

    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }

    public int vehicleID
    {
        get { return this.vehicleId; }
        set { this.vehicleId = value; }
    }

    public int NumberOnHand
    {
        get { return this.numberOnHand; }
        set { this.numberOnHand = value; }
    }

    public double Price
    {
        get { return this.price; }
        set { this.price = value; }
    }

    public double Cost
    {
        get { return this.cost; }
        set { this.cost = value; }
    }



}


