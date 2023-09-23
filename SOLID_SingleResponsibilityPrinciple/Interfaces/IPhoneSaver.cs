using SOLID_SingleResponsibilityPrinciple.Models;

namespace SOLID_SingleResponsibilityPrinciple.Interfaces
{
    interface IPhoneSaver
    {
        void Save(Phone phone, string fileName);
    }
}
