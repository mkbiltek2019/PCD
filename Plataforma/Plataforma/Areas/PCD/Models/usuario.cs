//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Plataforma.Areas.PCD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuario()
        {
            this.documentos_profe = new HashSet<documentos_profe>();
            this.log_visitas = new HashSet<log_visitas>();
            this.colegios = new HashSet<colegio>();
            this.cursos = new HashSet<curso>();
            this.libros = new HashSet<libro>();
            this.permisos = new HashSet<permiso>();
            this.roles = new HashSet<role>();
            this.grupos = new HashSet<grupos>();
            this.comentarios = new HashSet<comentario>();
            this.respuestas = new HashSet<respuesta>();
            this.niveles = new HashSet<nivele>();
            this.log_visitas_documentousuario = new HashSet<log_visitas_documentousuario>();
            this.log_visitas_cursousuario = new HashSet<log_visitas_cursousuario>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Nullable<int> telefono { get; set; }
        public Nullable<int> telefono_2 { get; set; }
        public string correo { get; set; }
        public string correo_2 { get; set; }
        public string informacion_opcional { get; set; }
        public Nullable<System.DateTime> fecha_primer_ingreso { get; set; }
        public Nullable<bool> bloqueado { get; set; }
        public Nullable<bool> logueado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<documentos_profe> documentos_profe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<log_visitas> log_visitas { get; set; }
        public virtual notificacione notificacione { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<colegio> colegios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<curso> cursos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<libro> libros { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<permiso> permisos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<role> roles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<grupos> grupos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comentario> comentarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<respuesta> respuestas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nivele> niveles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<log_visitas_documentousuario> log_visitas_documentousuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<log_visitas_cursousuario> log_visitas_cursousuario { get; set; }
    }
}