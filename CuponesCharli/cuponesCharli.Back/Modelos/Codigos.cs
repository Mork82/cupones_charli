using System;
using System.Collections.Generic;



namespace cuponesCharli.Back.Modelos
{
    public partial class Codigos
    {
        public int Id { get; set; }
        public int? Codigo { get; set; }
        public int? Usuario { get; set; }
        public DateTime? FechaAsignacion { get; set; }
        public int? Contador { get; set; }
    }
}
