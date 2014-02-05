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
                 Email = "", 
                 ApplicationId = new Guid(""), 
                 Password = "" 
             });
             if (response.Success)
                 Console.WriteLine("Contact Full Name: " + response.ContactView.FullName);
             else
                 Console.WriteLine(response.Message);
             Console.ReadLine();
        }
    }
}
