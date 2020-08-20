using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class vehicle
{
    private int id;
    private string make;
    private string model;
    private int year;
    private string state;

    public vehicle(int id, string make, string model, int year, string state)
    {
        Id = id;
        Make = make;
        Model = model;
        Year = year;
        State = state;
    }

    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }

    public string Make
    {
        get { return this.make; }
        set { this.make = value; }
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public int Year
    {
        get { return this.year; }
        set { this.year = value; }

    }

    public string State
    {
        get { return this.state; }
        set { this.state = value; }
    }




}
