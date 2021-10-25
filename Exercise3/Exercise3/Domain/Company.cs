using Bogus;
using System;

namespace Exercise3.Domain
{
     class Company : Employee
     {

         public string Name()
         {
             string companyName = new Bogus.DataSets.Company().CompanyName();
             return companyName;
         }
         public string[] CreateNameList()
         {
             int count = Count();
             string[] nameList = new string[count];
             for (int i = 0; i < nameList.Length; i++)
             {
                 nameList[i] = CreateId();
             }
             return nameList;
         }
         
         public string Country()
         {
             string companyCountry = new Bogus.DataSets.Address().County();
             return companyCountry;
         }
         public string[] CreateCountryList()
         {
             int count = Count();
             string[] countryList = new string[count];
             for (int i = 0; i < countryList.Length; i++)
             {
                 countryList[i] = CreateId();
             }
             return countryList;
         }
                 
         
         public string City()
         {
             string companyCity = new Bogus.DataSets.Address().City();
             return companyCity;
         }
         public string[] CreateCityList()
         {
             int count = Count();
             string[] сityList = new string[count];
             for (int i = 0; i < сityList.Length; i++)
             {
                 сityList[i] = CreateId();
             }
             return сityList;
         }
         public string CompanyAddress()
         {
             string companyAddress = new Bogus.DataSets.Address().FullAddress();
             return companyAddress;
         }
         public string[] CreateAddressList()
         {
             int count = Count();
             string[] addressList = new string[count];
             for (int i = 0; i < addressList.Length; i++)
             {
                 addressList[i] = CreateId();
             }
             return addressList;
             
         }
     }
}