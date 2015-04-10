# CEP/CRM Integration

Integration specification for integration between the Citizen Engagement Platform and an abstract CRM provider.

The crm folder contains a Visual Studio 2013 solution. 

The CepCrmIntegration project contains three interfaces to be implemented:

- FaultService: Register an e-mail based fault and retrieve progress updates
- FeedbackService: Register feedback and retrieve optional response
- UserProfileService: Register contact and synchronise changes

Integration components will run in-process and should not keep any state other than configuration information.
