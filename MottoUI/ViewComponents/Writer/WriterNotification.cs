using Microsoft.AspNetCore.Mvc;

namespace MottoUI.ViewComponents.Writer
{
    public class WriterNotification:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
