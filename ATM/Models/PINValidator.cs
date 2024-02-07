using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Models
{
    public class PINValidator
    {
        public bool ValidatePIN(string enteredPIN, string correctPIN)
        {
            return enteredPIN == correctPIN;
        }
    }
}
