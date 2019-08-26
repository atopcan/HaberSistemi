using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaberSistemi.Data.Model
{
    [Table("Rol")] //tablomuzu oluşturduk
   public class Rol
    {
        [Key]
        public int ID { get; set; }
       [Display(Name="Rol Adı :")] //attribute
       [MinLength(3,ErrorMessage ="Lütfen 3 karakterden fazla değer giriniz !"),MaxLength(150,ErrorMessage ="Lütfen 150 karakterden az değer  giriniz !")]
        public string RolAdi { get; set; }

    }
}
