﻿using System;
using System.ComponentModel.DataAnnotations;

namespace College.Service.Entities
{

    public class AddressData
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
    }

}
