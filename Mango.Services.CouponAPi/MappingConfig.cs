using AutoMapper;
using Mango.Services.CouponAPi.Model;
using Mango.Services.CouponAPi.Model.Dto;


namespace Mango.Services.CouponAPi
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
