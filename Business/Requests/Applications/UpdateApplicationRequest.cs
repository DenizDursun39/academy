﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Applications
{
    public class UpdateApplicationRequest
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public int CourseId { get; set; }
        public int StatusId { get; set; }
    }
}
