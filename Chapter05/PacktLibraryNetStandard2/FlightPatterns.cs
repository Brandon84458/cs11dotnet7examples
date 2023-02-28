using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Packt.Shared;

public class Passenger
{
        public string? Name { get; set; }
}
public class BuisnessClassPassenger : Passenger
{
    public override string ToString()
    {
        return $"Buisness Class: {Name}";
    }
}
public class FirstClassPassenger : Passenger
{
    public int AirMiles { get; set; }
    public override string ToString()
    {
        return $"First Class with {AirMiles:N0} air miles: {Name}";
    }
}
public class CoachClassPassenger : Passenger
{
    public double CarryOnKG { get; set; }
    public override string ToString()
    {
        return $"Coach class with {CarryOnKG:N2} KG carry on: {Name}";
    }
}