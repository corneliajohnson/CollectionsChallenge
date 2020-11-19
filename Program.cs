﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsChallenge
{
  // Define a bank
  public class Bank
  {
    public string Symbol { get; set; }
    public string Name { get; set; }
  }

  // Define a customer
  public class Customer
  {
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
  }

  public class ReportItem
  {
    public string CustomerName { get; set; }
    public string BankName { get; set; }
  }

  public class Program
  {
    public static void Main()
    {
      // Create some banks and store in a List
      List<Bank> banks = new List<Bank>() {
            new Bank(){ Name="First Tennessee", Symbol="FTB"},
            new Bank(){ Name="Wells Fargo", Symbol="WF"},
            new Bank(){ Name="Bank of America", Symbol="BOA"},
            new Bank(){ Name="Citibank", Symbol="CITI"},
        };

      // Create some customers and store in a List
      List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

      /*
          You will need to use the `Where()`
          and `Select()` methods to generate
          instances of the following class.

          public class ReportItem
          {
              public string CustomerName { get; set; }
              public string BankName { get; set; }
          }
      */
      List<ReportItem> millionaireReport = new List<ReportItem>();

      foreach (Customer customer in customers)
      {
        foreach (Bank bank in banks)
        {
          if (bank.Symbol == customer.Bank && customer.Balance >= 1000000)
          {
            millionaireReport.Add(
                new ReportItem()
                {
                  CustomerName = customer.Name,
                  BankName = bank.Name
                });
          }

        }
      }




      foreach (var item in millionaireReport)
      {
        Console.WriteLine($"{item.CustomerName} at {item.BankName}");
      }
    }
  }

}
