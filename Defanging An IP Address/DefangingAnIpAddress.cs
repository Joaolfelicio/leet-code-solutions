using System;

string DefangingIpAddress(string address) 
{
    return address.Replace(".", "[.]");
}