#pragma checksum "C:\Users\harsh\Downloads\EmailReminder-master\EmailReminder-master\EmailReminder.WebApp\Shared\Components\ReminderCell.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0909ad7c45060cd939ccb4e08faa8e121733979f"
// <auto-generated/>
#pragma warning disable 1591
namespace EmailReminder.WebApp.Shared.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\harsh\Downloads\EmailReminder-master\EmailReminder-master\EmailReminder.WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\harsh\Downloads\EmailReminder-master\EmailReminder-master\EmailReminder.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\harsh\Downloads\EmailReminder-master\EmailReminder-master\EmailReminder.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\harsh\Downloads\EmailReminder-master\EmailReminder-master\EmailReminder.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\harsh\Downloads\EmailReminder-master\EmailReminder-master\EmailReminder.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\harsh\Downloads\EmailReminder-master\EmailReminder-master\EmailReminder.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\harsh\Downloads\EmailReminder-master\EmailReminder-master\EmailReminder.WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\harsh\Downloads\EmailReminder-master\EmailReminder-master\EmailReminder.WebApp\_Imports.razor"
using EmailReminder.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\harsh\Downloads\EmailReminder-master\EmailReminder-master\EmailReminder.WebApp\_Imports.razor"
using EmailReminder.WebApp.Shared;

#line default
#line hidden
#nullable disable
    public partial class ReminderCell : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "reminder-cell");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "h3");
            __builder.AddContent(4, 
#nullable restore
#line 2 "C:\Users\harsh\Downloads\EmailReminder-master\EmailReminder-master\EmailReminder.WebApp\Shared\Components\ReminderCell.razor"
         Date.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n    ");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, 
#nullable restore
#line 3 "C:\Users\harsh\Downloads\EmailReminder-master\EmailReminder-master\EmailReminder.WebApp\Shared\Components\ReminderCell.razor"
        Content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\harsh\Downloads\EmailReminder-master\EmailReminder-master\EmailReminder.WebApp\Shared\Components\ReminderCell.razor"
       
    [Parameter]
    public DateTime Date { get; set; }
    [Parameter]
    public string Content { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
