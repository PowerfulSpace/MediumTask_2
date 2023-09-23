using SOLID_SingleResponsibilityPrinciple.Models;

namespace SOLID_SingleResponsibilityPrinciple.Interfaces
{
    interface IPhoneValidator
    {
        bool IsValid(Phone phone);
    }
}
