using CEP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CepCrmIntegration
{
    public interface FaultService
    {
        // Should return a case identifier
        // The contact ID is in fault.User.CrmContactId
        // The EmailAddress field in the fault argument should not be used to update contact information.
        string RegisterEmailFault(EmailFaultLog fault);

        IEnumerable<FaultProgressNote> GetNewProgressForFaultSince(DateTime? timeOfLastProgressNote, string caseId);

        FaultState GetFaultState(string caseId);
    }
}
