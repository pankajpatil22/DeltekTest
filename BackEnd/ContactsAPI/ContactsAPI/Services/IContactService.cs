﻿using ContactsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsAPI.Services
{
    public interface IContactService
    {
        List<Contact> GetAllContacts(int page, int pageSize, string search);
        Contact GetContactById(int id);
        Contact CreateContact(Contact contact);
        Contact UpdateContact(int id, Contact contact);
        void DeleteContact(int id);
    }
}
