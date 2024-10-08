﻿using System;
using System.Runtime.Intrinsics.Arm;

// Simple ATM of 4 users
// made by Ajnur
// 25.01.2023

public class cardHolder
{
    // Eigenschaften

    String cardNum;
    int pin;
    String firstName;
    String lastName;
    double balance;

    // Konstruktur
    public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    // Getter (get)
    public String getNum()
    {
        return cardNum;
    }
    public int getPin()
    {
        return pin;
    }
    public String getFirstName()
    {
        return firstName;
    }
    public String getLastName()
    {
        return lastName;
    }
    public double getBalance()
    {
        return balance;
    }

    // Setter (set)
    public void setNum(String newCardNum)
    {
        cardNum = newCardNum;
    }
    public void setPin(int newPin)
    {
        pin = newPin;
    }
    public void setFirstName(String newFirstName)
    {
        firstName = newFirstName;
    }
    public void setLastName(String newLastName)
    {
        lastName = newLastName;
    }
    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    





    // MAIN METHODE

    public static void Main(String[] args)
    {
        // 1. Option (Deposit)

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much && would you like to deposit? ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            Console.WriteLine("Thank you for your $$. Your new balance is: " + currentUser.getBalance());
        }

        // 2. Option (withdraw)

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to withdraw: ");
            double withdrawal = Double.Parse(Console.ReadLine());
            //Check if the user has enough money
            if (currentUser.getBalance() < withdrawal)
            {
                Console.WriteLine("Insufficient balance :(");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("You're good to go! Thank you :)");
            }
        }

        // 3. Option (Show balance)

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance: " + currentUser.getBalance());
        }

        // 4-Optionen auswahl Funktion

        void printOptions()
        {
            Console.WriteLine("\nPlease choose from one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }


        // Gefakte Datenbank (List = eingebener datentyp der sagt, eine Liste zu erstellen)

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("4532761841325802", 4321, "Ashley", "Jones", 321.13));
        cardHolders.Add(new cardHolder("4532201841325802", 6112, "Frida", "Dickersen", 531.19));
        cardHolders.Add(new cardHolder("87532761841325802", 6912, "Elmar", "Dickersen", 831.19));
        cardHolders.Add(new cardHolder("5432761841325802", 3112, "Yane", "Dickersen", 931.19));
        

        // Prompt user

        Console.WriteLine("Welcome to SimpleATM");
        Console.WriteLine("--------------------\n");
        Console.WriteLine("Please insert your debit card: ");
        String debitCardNum = "";
        cardHolder currentUser;         // Neues Objekt erzeugen


        while (true)                    // Endlosschleife (try-catch = Fehlerausfinden)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                // Check mit der Datenbank
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if (currentUser != null) { break; }
                else { Console.WriteLine("Card not recognized. Please try again!"); }
            }
            catch
            {
                Console.WriteLine("Card not recognized. Please try again!");
            }
        }


        // Überprüfung PIN

        Console.WriteLine("\nPlease enter your pin: ");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if (userPin == currentUser.getPin())
                {
                    break;
                }
                else { Console.WriteLine("Incorrect pin. Please try again."); }
            }
            catch
            {
                Console.WriteLine("Incorrect pin. Please try again.");
            }
        }
        Console.WriteLine("\nWelcome " + currentUser.getFirstName());


        // 4-Optionen aufruf -aus der Wahl vom Benutzer

        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { }
            if (option == 1) { deposit(currentUser); }
            else if (option == 2) { withdraw(currentUser); }
            else if (option == 3) { balance(currentUser); }
            else if (option == 4) { break; }
            else { option = 0; }
        }
        while (option != 4);
        Console.WriteLine("Thank you! Have a nice day :)");
    }
}

