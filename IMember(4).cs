﻿//CAB301 assessment 1 - 2022
//The specification of Member ADT

using System;
using System.Collections.Generic;
using System.Text;

interface IMember
{
    // Get and set the first name of this member
    public string FirstName
    {
        get;
        set;
    }
    // Get and set the last name of this member
    public string LastName
    {
        get;
        set;
    }

    // Get and set the contact number of this member
    // A valid contact phone number has 10 digits and its first digit is 0
    public string ContactNumber
    {
        get;
        set; //contact number must be valid 
    }

    // Get and set a pin for this member
    // A pin is valid if it is a number which has a minimal of 4 and a maximal of 6 digits
    public string Pin
    {
        get;
        set; //pin must be valid 
    }

    // Define how to comapre two member objects
    // This member's full name is compared to another member's full name 
    // Pre-condition: nil
    // Post-condition: return -1 if this member's full name is less than another's full name in dictionary order
    //                 return 0, if this member's full name equals to another's full name in dictionary order
    //                 return +1, of this member's full name is greater than another's full name in dictionary order
    public int CompareTo(IMember member);


    // Check if a contact phone number is valid. A contact phone number is valid if it has 10 digits and the first digit is 0.
    // Pre-condition: nil
    // Post-condition: return true, if the phone number id valid; retuns false otherwise.

    public static bool IsValidContactNumber(string phonenumber)
    {
        // To be implemented by students in Phase 1
        int validLength = 10;
        int firstDigit = '0';

        for (int i = 0; i < phonenumber.Length; i++)
        {
            if (phonenumber.Length == validLength && phonenumber[0] == firstDigit)
            {
               
                return true;
            }
            else
            {
               
                return false;
            }
        }

        return true;
    }

    // Check if a pin is valid. A pin is valid if it is a number which has a minimal of 4 and a maximal of 6 digits.
    // Pre-condition: nil
    // Post-condition: return true, if the pin valid; retuns false otherwise.
    public static bool IsValidPin(string pin)
    {
        // To be implemented by students in Phase 1
        int max = 6;
        int min = 4;

        for (int i = 0; i < pin.Length; i++)
        {
            if (pin.Length >= min && pin.Length <= max)
            {
               
                return true;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
    // Return a string containing the first name, last name and contact number of this memeber
    // Pre-condition: nil
    // Post-condition: a  string containing the first name, last name, and contact number of this member is returned
    public string ToString();
}

