#pragma checksum "C:\Users\harsh\Downloads\EmailReminder-master\EmailReminder-master\EmailReminder.WebApp\Shared\Components\ReminderForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10870eba0ba32fe75f7acf20dbfe151c8bace06d"
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
#nullable restore
#line 1 "C:\Users\harsh\Downloads\EmailReminder-master\EmailReminder-master\EmailReminder.WebApp\Shared\Components\ReminderForm.razor"
using EmailReminder.Shared.Models;

#line default
#line hidden
#nullable disable
    public partial class ReminderForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "reminder-form");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\harsh\Downloads\EmailReminder-master\EmailReminder-master\EmailReminder.WebApp\Shared\Components\ReminderForm.razor"
                     reminder

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\harsh\Downloads\EmailReminder-master\EmailReminder-master\EmailReminder.WebApp\Shared\Components\ReminderForm.razor"
                                             HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddMarkupContent(14, "\n            ");
                __builder2.AddMarkupContent(15, "<label for=\"EmailAddress\">Email Address</label>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "id", "EmailAddress");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\harsh\Downloads\EmailReminder-master\EmailReminder-master\EmailReminder.WebApp\Shared\Components\ReminderForm.razor"
                                                                           reminder.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => reminder.EmailAddress = __value, reminder.EmailAddress))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => reminder.EmailAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\n\n        ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "\n            ");
                __builder2.AddMarkupContent(27, "<label for=\"Message\">Title</label>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(28);
                __builder2.AddAttribute(29, "id", "Message");
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\harsh\Downloads\EmailReminder-master\EmailReminder-master\EmailReminder.WebApp\Shared\Components\ReminderForm.razor"
                                                                          reminder.Message

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => reminder.Message = __value, reminder.Message))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => reminder.Message));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\n\n        ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, "\n            ");
                __builder2.AddMarkupContent(39, "<label for=\"DateTime\">Date and Time</label>\n            ");
                __Blazor.EmailReminder.WebApp.Shared.Components.ReminderForm.TypeInference.CreateInputDate_0(__builder2, 40, 41, "DateTime", 42, "form-control", 43, 
#nullable restore
#line 22 "C:\Users\harsh\Downloads\EmailReminder-master\EmailReminder-master\EmailReminder.WebApp\Shared\Components\ReminderForm.razor"
                                                                       reminder.DateTime

#line default
#line hidden
#nullable disable
                , 44, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => reminder.DateTime = __value, reminder.DateTime)), 45, () => reminder.DateTime);
                __builder2.AddMarkupContent(46, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\n\n        ");
                __builder2.AddMarkupContent(48, "<button class=\"btn btn-primary\" type=\"submit\">Create Reminder</button>\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\harsh\Downloads\EmailReminder-master\EmailReminder-master\EmailReminder.WebApp\Shared\Components\ReminderForm.razor"
       
    private Reminder reminder = new Reminder();

    private async void HandleValidSubmit()
    {
        try
        {
            var result = await _emailReminderService.CreateReminderAsync(reminder);
        }
        catch
        {
            base.StateHasChanged();
        }
        reminder = new Reminder();
        base.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmailReminder.WebApp.Services.EmailReminderService _emailReminderService { get; set; }
    }
}
namespace __Blazor.EmailReminder.WebApp.Shared.Components.ReminderForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
