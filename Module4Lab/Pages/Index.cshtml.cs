using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module4Lab.Pages;

public class IndexModel : PageModel
{
    //Attributes - varibles that describe the class 
    //Hold data for the class 
    [BindProperty]
    public string[] Shows {get; set;} = new strings[3];
    public string[] SampleShows {get; set;}     
    public bool ShowResults {get; set;} = false;
    //method that is called when homepage


    public void OnGet()
    {
        SampleShows = new string[] {"A Christmas Carol", "Hamlet", "The Crucible"};
    } //end method

    public IActionResult OnPost()
    {
        //inialize the sample shows array so that it has the some values as
        //it did in the OnGet() method
        SampleShows = new string[] {"A Christmas Carol", "Hamlet", "The Crucible"};
        
        //Set 
        ShowResults = true;

        //Return the page that is displayed (that is the IActionResult object)
    } //end method
}
