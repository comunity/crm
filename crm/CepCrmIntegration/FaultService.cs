// Copyright (c) ComUnity 2016
// Hans Malherbe <hansm@comunity.co.za>

using CEP;
using System;
using System.Collections.Generic;

namespace CepCrmIntegration
{
    public interface FaultService
    {
        // Should return a case identifier
        // The contact ID is in fault.User.CrmContactId. If the contact does not exist in CRM a ConflictException must be thrown.
        // The EmailAddress field in the fault argument should not be used to update contact information.
        string RegisterEmailFault(EmailFaultLog fault);

        IEnumerable<FaultProgressNote> GetNewProgressForFaultSince(DateTime? timeOfLastProgressNote, string caseId);

        FaultState GetFaultState(string caseId);
    }
}
