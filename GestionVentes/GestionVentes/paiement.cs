//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionVentes
{
    using System;
    using System.Collections.Generic;
    
    public partial class paiement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public paiement()
        {
            this.commandes = new HashSet<commande>();
        }
    
        public int numPaiement { get; set; }
        public System.DateTime datePaiement { get; set; }
        public int montantPayé { get; set; }
        public int montantàPayer { get; set; }
        public int montantRestant { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commande> commandes { get; set; }
    }
}