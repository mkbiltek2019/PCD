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
    
    public partial class comentario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public comentario()
        {
            this.respuestas = new HashSet<respuesta>();
        }
    
        public long id { get; set; }
        public int id_documento { get; set; }
        public int id_grupo { get; set; }
        public int id_usuario { get; set; }
        public string comentario1 { get; set; }
        public System.DateTime fecha_publicacion { get; set; }
    
        public virtual documento documento { get; set; }
        public virtual grupos grupos { get; set; }
        public virtual usuario usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<respuesta> respuestas { get; set; }
    }
}