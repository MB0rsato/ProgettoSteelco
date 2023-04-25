﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Monitoring_Infortuni.Models
{
    public class SediModel
    {
        public int Id { get; set; }
        [DisplayName("Sede")]
        public string Sede { get; set; }
        [DisplayName("Giorni dall'ultimo infortunio")]
        [DataType(DataType.DateTime)]
        public DateTime Data { get; set; }


    }
}