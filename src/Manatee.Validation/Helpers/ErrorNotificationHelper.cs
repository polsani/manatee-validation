using System.Collections.Generic;
using Manatee.Validation.ViewModels;
using System.Linq;
using Manatee.Validation.Notifications;

namespace Manatee.Validation.Helpers
{
    public class ErrorNotificationHelper
    {
        public ErrorResponse GenerateErrorResponse(IEnumerable<Notification> notifications)
        {
            var priorityStatusCode = notifications.Min(x => x.HttpStatusCode);
            
            var errorResponse = new ErrorResponse(priorityStatusCode);

            foreach (var notification in notifications)
            {
                errorResponse.Errors.Add(
                    new Error(notification.Property, 
                        notification.Message, 
                        notification.Value, 
                        new ViewModels.Constraint(notification.Constraint.Name, 
                            notification.Constraint.Parameters?.Select(
                                parameter => new ViewModels.Param(parameter.Name, parameter.Value)))));
            }

            return errorResponse;
        }
    }
}