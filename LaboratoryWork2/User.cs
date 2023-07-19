using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace LaboratoryWork2
{
    [Serializable]
    public class User
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? FatherName { get; set; }
        public string? Maill { get; set; }
        public string? DateOfBirth { get; set; }
        public string? FamilyStatus { get; set; }
        public string? OtherInformation { get; set; }

        override public string ToString()
        {
            return ($"Ім'я: {Name}\n" +
                $"Прізвище: {Surname}\n" +
                $"Побатькові: {FatherName}\n" +
                $"Стать: {Maill}\n" +
                $"Дата народження: {DateOfBirth}\n" +
                $"Сімейний статус: {FamilyStatus}\n" +
                $"Інша інформація: {OtherInformation}\n");
        }
    }
}
