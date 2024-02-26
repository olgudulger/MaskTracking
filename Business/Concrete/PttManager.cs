﻿using System;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _applicantService;
        //Mac için visual Studio'da Service Referans eklenmiyor :(
        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "için maske verildi");  
            }
        }
    }
}

