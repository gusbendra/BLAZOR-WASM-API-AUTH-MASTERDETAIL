using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorWaAuHosAgt.Shared.Modeltes
{
    public class Customer
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string AlamatUtama { get; set; }
        public List<Custalamat> Alamat{ get; set; } = new List<Custalamat>();
    }
}
