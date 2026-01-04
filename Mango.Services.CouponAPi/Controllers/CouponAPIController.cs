using Mango.Services.CouponAPi.Data;
using Mango.Services.CouponAPi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace Mango.Services.CouponAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        public CouponAPIController( AppDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public object Get()
        {
            try
            {
                IEnumerable<Coupon> objList = _db.Coupons.ToList();
                return objList;
            }catch(Exception ex)
            {

            }return null;
        }
    }
}
