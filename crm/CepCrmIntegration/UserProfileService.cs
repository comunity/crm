using CEP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CepCrmIntegration
{
    interface UserProfileService
    {
        // Returns CRM contact ID
        string RegisterContact(UserProfile user);

        void UpdateContact(UserProfile user);

        UserProfile GetContact(string contactId);
    }
}
