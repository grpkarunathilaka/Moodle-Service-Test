using MoodleServiceTest.MembershipService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoodleServiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
             MembershipUserServiceClient client = new MembershipUserServiceClient();

             UserLoginResponse response = client.UserLogin(new UserLoginRequest() 
             { 
                 Email = "rangagamage@yahoo.com.au", 
                 ApplicationId = new Guid("4302DEA5-144A-4AA8-A6B0-1A693C6CB379"), 
                 Password = "ms40BqzzLC3M1zBofik3SlED+wsBOx7EqE315DJF1YY=" 
             });
             if (response.Success)
                 Console.WriteLine("Contact Full Name: " + response.ContactView.FullName);
             else
                 Console.WriteLine(response.Message);
             Console.ReadLine();
        }
    }
}
