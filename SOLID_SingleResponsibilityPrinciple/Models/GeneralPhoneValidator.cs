using SOLID_SingleResponsibilityPrinciple.Interfaces;

namespace SOLID_SingleResponsibilityPrinciple.Models
{
    class GeneralPhoneValidator : IPhoneValidator
    {
        public bool IsValid(Phone phone) =>
            !string.IsNullOrEmpty(phone.Model) && phone.Price > 0;
    }
}
