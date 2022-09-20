﻿using BeyondElvisOperator;

void MyMethod(Person person)
{
    string postcode = "UNKNOWN";

    // if (person != null && person.Address != null && person.Address.PostCode != null)
    //     person.Address.PostCode = postcode;

    // C# 6.0 > postcode = person?.Address?.PostCode;

    if (person != null)
    {
        if (HasMedicalRecord(person) && person.Address != null)
        {
            CheckAddress(person.Address);
            if (person.Address.PostCode != null)
                postcode = person.Address.PostCode.ToString();
        }
    }
}

void CheckAddress(Address address)
{
    
}

bool HasMedicalRecord(object p)
{
    return true;
}

MyMethod(new Person());