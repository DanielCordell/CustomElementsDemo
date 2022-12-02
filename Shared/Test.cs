using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Shared
{
    public class Test : ComponentBase
    {
        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
            Console.WriteLine("Test");
        }
    }
}
