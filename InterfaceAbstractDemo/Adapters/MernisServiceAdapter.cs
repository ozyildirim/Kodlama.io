using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisService;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public async bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName, customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}
