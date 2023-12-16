﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Applicants
{
    public class ListApplicantResponse
    {
        public int Id { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserNationalIdentity { get; set; }
        public DateTime UserDateOfBirth { get; set; }
        public string UserEmail { get; set; }
    }
}
