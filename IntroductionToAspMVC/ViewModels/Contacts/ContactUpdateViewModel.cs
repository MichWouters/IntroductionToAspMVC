﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.ViewModels.Contacts
{
    public class ContactUpdateViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Emailadres { get; set; }

        public string Telephone { get; set; }

        public int AddressId { get; set; }

        public string Street { get; set; }

        public int Number { get; set; }

        public int Bus { get; set; }

        public string PostalCode { get; set; }

        public string City { get; set; }
    }
}