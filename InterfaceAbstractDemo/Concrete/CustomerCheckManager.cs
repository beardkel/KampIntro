﻿using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    internal class CustomerCheckManager : ICustomerCheckService
    {
        public void CheckIfRealPerson(Customer customer)
        {
            
        }
    }
}
