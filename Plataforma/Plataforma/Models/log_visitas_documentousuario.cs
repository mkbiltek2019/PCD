//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Plataforma.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class log_visitas_documentousuario
    {
        public int contador { get; set; }
        public int id_documento { get; set; }
        public int id_usuario { get; set; }
        public System.DateTime fecha { get; set; }
    
        public virtual documento documento { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
