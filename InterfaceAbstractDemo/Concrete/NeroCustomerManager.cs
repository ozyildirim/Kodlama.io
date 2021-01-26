using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    class NeroCustomerManager:BaseCustomerManager
    {
        public ICustomerCheckService customerCheckService;

        public override void Save(Customer customer)
        {
            base.Save(customer);
        }
    }
}
