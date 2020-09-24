using System;
using System.Collections.Generic;
using System.Text;

namespace Door
{
    public interface IUserValidation
    {
        public bool ValidateEntryRequest(string id);
    }
}
