using SOLID_SingleResponsibilityPrinciple.Interfaces;

namespace SOLID_SingleResponsibilityPrinciple.Models
{
    class TextPhoneSaver : IPhoneSaver
    {
        public void Save(Phone phone, string fileName)
        {
            using StreamWriter writer = new StreamWriter(fileName, true);
            writer.WriteLine(phone.Model);
            writer.WriteLine(phone.Price);
        }
    }
}
