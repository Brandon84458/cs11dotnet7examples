using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Packt.Shared;
public class BankAccount
{
    public string? AccountName; // instance member
    public decimal Balance; // instance member
    public static decimal InterestRate; // shared member
}