//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Toymania.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using Toymania.Models;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web.Mvc;

    public partial class SubCategories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubCategories()
        {
            this.Toy = new HashSet<Toy>();
        }

        [DisplayName("Subcategory")]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubCategoryId { get; set; }
        [DisplayName("Subcategory")]
        public string SCName { get; set; }
        public string Description { get; set; }
        public Nullable<int> CategoryId { get; set; }

        public virtual Categories Categories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Toy> Toy { get; set; }
    }
}