using SOLID_SingleResponsibilityPrinciple.Models;

namespace SOLID_SingleResponsibilityPrinciple.Interfaces
{
    interface IPhoneBinder
    {
        Phone CreatePhone(string?[] data);
    }
}
