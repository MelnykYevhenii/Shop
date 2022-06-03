using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Введіть ім'я")]
        [StringLength(50) ]
        [Required(ErrorMessage = "Довжина ім'я має бути не менше 5 символів")]
        public string name { get; set; }

        [Display(Name = "Введіть призвіще")]
        [StringLength(50)]
        [Required(ErrorMessage = "Довжина призвіща має бути не менше 5 символів")]
        public string surName { get; set; }

        [Display(Name = "Введіть адресу")]
        [StringLength(25)]
        [Required(ErrorMessage = "Довжина адреси має бути не менше 10 символів")]
        public string adress { get; set; }

        [Display(Name = "Введіть номер телефону")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(15)]
        [Required(ErrorMessage = "Довжина номеру телефону має бути не менше 10 символів")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Required(ErrorMessage = "Довжина номеру телефону має бути не менше 10 символів")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }

    }
}
