//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoFinal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Servico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servico()
        {
            this.Parcelas = new HashSet<Parcela>();
        }
    
        public int IdServico { get; set; }
        public System.DateTime DataEntrada { get; set; }
        public string Tipo { get; set; }
        public System.DateTime DataSaida { get; set; }
        public int CarroOficinaIdCarro { get; set; }
    
        public virtual CarroOficina CarroOficina { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parcela> Parcelas { get; set; }
    }
}
