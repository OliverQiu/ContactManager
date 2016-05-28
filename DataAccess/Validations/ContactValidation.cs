using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Validations
{
    public partial class ContactValidation
    {
        [Required(ErrorMessage ="Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Required")]
        [MaxLength(1,ErrorMessage ="Just F or M")]
        public string Sex { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string SecondPhone { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}
