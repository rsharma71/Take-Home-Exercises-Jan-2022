using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TrainWebApp.Pages
{

    public class ContactFormModel : PageModel
    {
        [TempData]
        public string Details { get; set; }
        [BindProperty]
        public string UserEmail { get; set; } = null!;

        [BindProperty(SupportsGet = true)]
        public string topic { get; set; }

        [BindProperty(SupportsGet = true)]

        public string MessageBody { get; set; } = null!;

        [BindProperty(SupportsGet = true)]
        public string MessageText { get; set; } = null!;
        public void OnGet()
        {

        }


        public IActionResult OnPost()
        {
            Details = $"UserEmail{UserEmail}, Topic {topic} ,MessageText{MessageText},MessageBody{MessageBody}";
            return RedirectToPage(new { UserEmail = UserEmail, topic = topic, MessageText = MessageText, MessageBody = MessageBody });
        }
    }
}


