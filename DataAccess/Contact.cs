//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System.ComponentModel.DataAnnotations;
    [MetadataType(typeof(Validations.ContactValidation))]
    public partial class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string SecondPhone { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}
