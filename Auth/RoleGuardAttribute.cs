using MedicalStore.Models;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MedicalStore.Auth
{
    public class RoleGuardAttribute: ActionFilterAttribute
    {
        private readonly UserRole[] roles;
        public RoleGuardAttribute(UserRole[] roles)
        {
            this.roles = roles;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            context.ActionArguments["roles"] = this.roles;
        }
    }
}
