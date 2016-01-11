// Copyright (c) ComUnity 2016
// Hans Malherbe <hansm@comunity.co.za>

using CEP;

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
