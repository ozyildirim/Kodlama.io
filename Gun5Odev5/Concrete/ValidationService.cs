using Gun5Odev5.Abstract;
using Gun5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5Odev5.Concrete
{
    class ValidationService : IValidateService
    {
        public bool Validate(Player player)
        {
            if (player.NationalityId.Length == 11) {
                Console.WriteLine("Player information has been validated by external services. Nationality ID is okay.");
                return true;
            }else
            {
                Console.WriteLine("Information couldn't be validated. Try again.");
                return false;
            }
            
        }
    }
}
