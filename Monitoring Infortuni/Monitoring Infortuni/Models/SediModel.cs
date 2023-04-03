using System;
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
        [DisplayName("Data Ultimo Infortunio")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        [DisplayName("Stato Di Attenzione")]
        public bool Attenzione { get; set; }

    }
}