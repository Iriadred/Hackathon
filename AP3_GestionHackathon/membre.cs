//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AP3_GestionHackathon
{
    using System;
    using System.Collections.Generic;
    
    public partial class membre
    {
        public int idmembre { get; set; }
        public Nullable<int> idequipe { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
        public Nullable<System.DateTime> datenaissance { get; set; }
        public string lienportfolio { get; set; }
    
        public virtual equipe equipe { get; set; }
    }
}
