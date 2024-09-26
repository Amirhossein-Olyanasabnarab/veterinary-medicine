﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Owners
{
    public interface IOwnerService 
    {
        Task<OwnerDto> AddNewOwner(string firstName, string lastName, string phoneNumber);
    }
}
