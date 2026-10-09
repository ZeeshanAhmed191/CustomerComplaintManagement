using System;
using Microsoft.Xrm.Sdk;

namespace ComplaintPlugin
{
    public class ComplaintPluginClass : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            IPluginExecutionContext context =
                (IPluginExecutionContext)serviceProvider.GetService(
                    typeof(IPluginExecutionContext));

            IOrganizationServiceFactory serviceFactory =
                (IOrganizationServiceFactory)serviceProvider.GetService(
                    typeof(IOrganizationServiceFactory));

            IOrganizationService service =
                serviceFactory.CreateOrganizationService(context.UserId);


            if (context.InputParameters.Contains("Target") &&
                context.InputParameters["Target"] is Entity)
            {
                Entity complaint =
                    (Entity)context.InputParameters["Target"];

                OptionSetValue priority =
                    complaint.GetAttributeValue<OptionSetValue>("za_priority");

                if (priority != null && priority.Value == 4)
                {
                    complaint["za_status"] = new OptionSetValue(2);
                   
                }
            }
        }
    }
}