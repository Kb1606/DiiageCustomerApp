﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caltec.StudentInfoProject.Business.Dto
{
    public class SchoolFeesDto
    {
        public long Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string? PaymentMethod { get; set; }
        public string? PaymentReference { get; set; }
        public string? PaymentStatus { get; set; }
        public string? PaymentNote { get; set; }
        public string ClassName { get; set; }
        public long ClassId { get; set; }
        public string StudentId { get; set; }
    }
}
