//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Numtema_Gestion_Client
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rappel
    {
        public int ID_Rappel { get; set; }
        public Nullable<int> ID_Client { get; set; }
        public Nullable<System.DateTime> Date_du_Rappel { get; set; }
        public string Description { get; set; }
        public Nullable<int> Numéro_de_Rappel { get; set; }
    
        public virtual Client Client { get; set; }
    }
}
