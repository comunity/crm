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
        string RegisterFeedback(Feedback feedback);

        // Returns null if no response
        string GetFeedbackResponse(string caseId);
    }
}
