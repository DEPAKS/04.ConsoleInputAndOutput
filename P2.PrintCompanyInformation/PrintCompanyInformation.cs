using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAdd = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNum = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNum = Console.ReadLine();

        if (faxNum == "")
        {
            faxNum = "No fax";
        }

        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager First name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager Last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone number: ");
        string managerPhone = Console.ReadLine();
        
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("{0}\n" + "Address: " + "{1}\n" + "Tel.: " + "{2}" + Environment.NewLine + "Fax: " + "{3}\n" + "Web site: " + "{4}\n" + "Manager: " + "{5}{6}\n" + "(" + "age: " + "{7}" + "," + "tel.: " + "{8}" + ")", companyName, companyAdd, phoneNum, faxNum, webSite, managerFirstName, managerLastName, managerAge, managerPhone);
        Console.WriteLine();
    }
}










//Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}", companyName, companyAdd, phoneNum, faxNum, webSite, managerFirstName, managerLastName, managerAge, managerPhone);

        //string company = "Company name: ";
        //string comName = "Software University";
        //string companyAdd = "Company address: ";
        //string address = "15-18 Tintyava, Sofia";
        //string phone = "Phone number: ";
        //string phoneNumber = "+359 899 55 55 92";
        //string fax = "Fax number: ";
        //string faxNum = null;
        //string webSite = "Web Site: ";
        //string webAdd = "http://softuni.bg";
        //string managersFName = "Manager First Name: ";
        //string name = "Svetlin";
        //string managersLName = "Manager Last Name: ";
        //string lName = "Nakov";
        //string managersAge = "Manager age: ";
        //byte age = 25;
        //string managersPhone = "Manager phone: ";
        //string phoneNumM = "+359 2 981 981";
        
        //Console.WriteLine();
        //Console.WriteLine("{0,-35} | {1,-35} |", company, comName);
        //Console.WriteLine("{0,-35} | {1,-35} |", companyAdd, address);
        //Console.WriteLine("{0,-35} | {1,-35} |", phone, phoneNumber);
        //Console.WriteLine("{0,-35} | {1,-35} |", fax, faxNum);
        //Console.WriteLine("{0,-35} | {1,-35} |", webSite, webAdd);
        //Console.WriteLine("{0,-35} | {1,-35} |", managersFName, name);
        //Console.WriteLine("{0,-35} | {1,-35} |", managersLName, lName);
        //Console.WriteLine("{0,-35} | {1,-35} |", managersAge, age);
        //Console.WriteLine("{0,-35} | {1,-35} |", managersPhone, phoneNumM);
        //Console.WriteLine();



        

