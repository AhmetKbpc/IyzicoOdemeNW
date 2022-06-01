using AutoMapper;
using Iyzipay.Model;
using North.Core.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace North.Business.MapperProfiles
{
    public class PaymentProfile :Profile
    {
        public PaymentProfile()
        {
            CreateMap<CardModel , PaymentCard>().ReverseMap();
            CreateMap<BasketModel , BasketItem>().ReverseMap();
            CreateMap<AddressModel , Address>().ReverseMap();
            CreateMap<CustomerModel , Buyer>().ReverseMap();
            CreateMap<InstallmentPriceModel , InstallmentPrice>().ReverseMap();
            CreateMap<InstallmentModel , InstallmentDetail>().ReverseMap();
            CreateMap<PaymentResponseModel , Payment>().ReverseMap();
        }
    }
}
