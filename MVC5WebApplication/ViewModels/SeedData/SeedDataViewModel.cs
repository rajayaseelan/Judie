﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC5Models;

namespace MVC5WebApplication.ViewModels.SeedData
{
    public class SeedDataViewModel : TransactionalInformation 
    {
        public List<Customer> Customers;
    }
}