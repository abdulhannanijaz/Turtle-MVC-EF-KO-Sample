//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClanNinjaEquipment.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ninja
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ninja()
        {
            this.NinjaEquipment = new HashSet<NinjaEquipment>();
        }
    
        public long NinjaID { get; set; }
        public Nullable<int> ClanID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Age { get; set; }
        public string Picture { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<bool> IsExperienced { get; set; }
        public Nullable<bool> IsAlive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.Guid> NinjaGUID { get; set; }
    
        public virtual Clan Clan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NinjaEquipment> NinjaEquipment { get; set; }
    }
}
