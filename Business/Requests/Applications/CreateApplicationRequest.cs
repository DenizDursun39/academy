﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Applications
{
    public class CreateApplicationRequest
    {
        public int ApplicantId { get; set; }
        public int CourseId { get; set; }
        public int StatusId { get; set; }
    }
}
