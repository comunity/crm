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
        string RegisterEmailFault(EmailFault fault);

        IEnumerable<FaultProgressNote> GetNewProgressForFaultSince(DateTime? timeOfLastProgressNote, string caseId);

        FaultState GetFaultState(string caseId);
    }
}
