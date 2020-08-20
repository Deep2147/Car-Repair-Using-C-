using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class repair
{
    private int id;
    private int inventoryID;
    private string whatToRepair;

    public repair(int id, int inventoryID, string whatToRepair)
    {
        Id = id;
        InventoryId = inventoryID;
        WhatToRepair = whatToRepair;
    }

    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }

    public int InventoryId
    {
        get { return this.inventoryID; }
        set { this.inventoryID = value; }
    }

    public string WhatToRepair
    {
        get { return this.whatToRepair; }
        set { this.whatToRepair = value; }
    }
}



