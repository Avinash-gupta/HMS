using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.app.models
{
    public class DelegateInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DelegateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
