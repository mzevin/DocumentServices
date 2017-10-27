﻿using System;

namespace DocumentServices.Entities
{
    public partial class Case : ICase
    {
        public string ID { get; set; }
        public DateTime? DateOfService { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? EnteredDate { get; set; }
    }
}
