namespace SchoolManagementSystem.Web.Views.Shared.Components.LanguageSwitcher;

using Microsoft.AspNetCore.Mvc;
using System.Globalization;

public class LanguageSwitcherViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var currentCulture = CultureInfo.CurrentCulture.Name;
        return View("Default", currentCulture);
    }
}