namespace OnlineTickets.Web.Areas.Administration.Controllers
{
    using OnlineTickets.Common;
    using OnlineTickets.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
