using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HaberSistemi.Data.Model
{
    [Table("Kullanici")]
   public class Kullanici
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(150,ErrorMessage ="Lüften 50 kararterden fazla girmeyiniz !")]
        [Display(Name ="Ad Soyad")] 

        public string AdSoyad { get; set; }
        [Display(Name ="E-Mail")]
        [Required]//zorunlu alan yaptık
        [RegularExpression("^([a-zA-Z0-9_\\.]+)@([a-zA-Z0-9_\\.]+)([a-zA-Z]{2,5})$",ErrorMessage ="Geçerli bir Mail adresi giriniz !")]
        public string Email { get; set; }
        [Required]
        [Display(Name ="Şifre")]
        [DataType(DataType.Password)] //şifre tipini belirledik
        [MaxLength(16, ErrorMessage = "Lüften 16 kararterden fazla girmeyiniz !")]
        public string Sifre { get; set; }
        [Display(Name ="Kayıt Tarihi")]
        public DateTime KayitTarihi { get; set; }
        [Display(Name ="Aktif")]
        public bool Aktif { get; set; }

        public virtual Rol Rol { get; set; }

    }
}
