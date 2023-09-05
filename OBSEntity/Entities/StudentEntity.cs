using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSEntity.Entities
{
    public class StudentEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Ad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Soyad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Telefon Numarası")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "E Mail")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır")]
        public string EMail { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Adres")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Sınıf")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır")]
        public string Class { get; set; }
    }
}
