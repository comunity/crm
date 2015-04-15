using CEP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CepCrmIntegration
{
    interface FeedbackService
    {
        // Returns case ID
        // The contact ID is in feedback.User.CrmContactId. If the contact does not exist in CRM a ConflictException must be thrown.
        string RegisterFeedback(Feedback feedback);

        // Returns null if no response
        string GetFeedbackResponse(string caseId);
    }
}
