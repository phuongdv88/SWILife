﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWIBLL.Models
{
    public class Company : BaseModel
    {
        public long CompanyId { get; set; }
        public string Name { get; set; }
        public string PrimaryPhone { get; set; }
        public string SecondaryPhone { get; set; }
        public string FaxNumber { get; set; }
        public string Address { get; set; }
        public string CountryOfOrigin { get; set; }
        public string WebSite { get; set; }
        public string KeyTechnologies { get; set; }
        public string ServiceContractTerms { get; set; }
        public string Industry { get; set; } //computer game, computer hardware, computer networking, sofware, consumer electronics, it and services, internet, nanotechnology, network security, online media, semiconductors, telecommunications, end users, biotechnology, electrical/ electrical manufacturing, wireless
        public string ABC { get; set; }
        public bool IsActive { get; set; }
        public string MiscNotes { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Department { get; set; }
        public bool IsHot { get; set; }
        public DateTime ContractSigingTime { get; set; }
        public string ScanLink { get; set; }
        public long UserId { get; set; }

        public string UserName { get; set;}
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Company()
        {

        }

        ~Company()
        {

        }
    }
}
