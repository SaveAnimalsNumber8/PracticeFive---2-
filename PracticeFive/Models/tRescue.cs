//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracticeFive.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web;

    public partial class tRescue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tRescue()
        {
            this.tComment = new HashSet<tComment>();
            this.FollowRescue = new HashSet<FollowRescue>();
        }

        public HttpPostedFileBase upImg { get; set; }
        public int RescueID { get; set; }
        public int RescueMemberID { get; set; }
        public string RescueTitle { get; set; }
        public string ResCueDone { get; set; }
        public string RescuePictures { get; set; }
        public int RescuePositionCity { get; set; }
        public int RescuePositionCountry { get; set; }
        public string RescueEvent { get; set; }
        public int RescueSpecies { get; set; }
        public string RescueProgress { get; set; }
        public System.DateTime Created_At { get; set; }
    
        public virtual tMember tMember { get; set; }
        public virtual tPosition tPosition { get; set; }
        public virtual tPosition tPosition1 { get; set; }
        public virtual tSpecies tSpecies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tComment> tComment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FollowRescue> FollowRescue { get; set; }
    }
}