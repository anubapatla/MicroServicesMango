using System.ComponentModel.DataAnnotations;

namespace Mango.Services.CouponAPi.Model
{
    public class Coupon
    {
        [Key]
        public int CouponId { get; set; }
        [Required]
        public string CouponCode { get; set; }
        [Required]
        public int DiscountAmount { get; set; }
        public int MinAmount { get; set; }
      



    }
}
