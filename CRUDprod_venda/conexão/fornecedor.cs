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
    
    public partial class fornecedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fornecedor()
        {
            this.produto_fornecedor = new HashSet<produto_fornecedor>();
        }
    
        public int idfornecedor { get; set; }
        public int idendereco { get; set; }
        public string nome { get; set; }
        public string registro { get; set; }
    
        public virtual endereco endereco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<produto_fornecedor> produto_fornecedor { get; set; }
    }
}
