//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ErpSigmaVenda.conexão
{
    using System;
    using System.Collections.Generic;
    
    public partial class cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cliente()
        {
            this.venda = new HashSet<venda>();
        }
    
        public int idcliente { get; set; }
        public string nomeCompleto { get; set; }
        public string email { get; set; }
        public string registro { get; set; }
        public System.DateTime dataNascimento { get; set; }
        public int idendereco { get; set; }
        public string sexo { get; set; }
        public string seguimento { get; set; }
    
        public virtual endereco endereco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venda> venda { get; set; }
    }
}
