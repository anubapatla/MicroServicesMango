namespace Mango.Services.CouponAPi.Model.Dto
{
    public class CouponDto
    {
        public int CouponId { get; set; }
        public required string CouponCode { get; set; }
        public int DiscountAmount { get; set; }
        public int MinAmount { get; set; }

    }
}
