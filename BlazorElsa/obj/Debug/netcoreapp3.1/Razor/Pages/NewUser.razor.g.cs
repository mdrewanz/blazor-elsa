#pragma checksum "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\Pages\NewUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8083b41c0bd5cf3cf482499f88007904bb6de495"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorElsa.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\_Imports.razor"
using BlazorElsa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\_Imports.razor"
using BlazorElsa.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\Pages\NewUser.razor"
using BlazorElsa.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\Pages\NewUser.razor"
using Elsa.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\Pages\NewUser.razor"
using Elsa.Activities.Workflows.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\Pages\NewUser.razor"
using Elsa.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/newuser")]
    public partial class NewUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-signup");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\Pages\NewUser.razor"
                      RegistrationModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\Pages\NewUser.razor"
                                                         HandleFormSubmission

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "hidden", 
#nullable restore
#line 9 "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\Pages\NewUser.razor"
                                                                                        ShowConfirmation

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "<h1 class=\"h3 mb-3 font-weight-normal\">Please register</h1>\r\n\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "type", "text");
                __builder2.AddAttribute(14, "id", "name");
                __builder2.AddAttribute(15, "placeholder", "Name");
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\Pages\NewUser.razor"
                                                       RegistrationModel.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RegistrationModel.Name = __value, RegistrationModel.Name))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => RegistrationModel.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "type", "email");
                __builder2.AddAttribute(23, "id", "email");
                __builder2.AddAttribute(24, "placeholder", "Email");
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\Pages\NewUser.razor"
                                                         RegistrationModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RegistrationModel.Email = __value, RegistrationModel.Email))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => RegistrationModel.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "type", "password");
                __builder2.AddAttribute(32, "id", "password");
                __builder2.AddAttribute(33, "placeholder", "Password");
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\Pages\NewUser.razor"
                                                               RegistrationModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RegistrationModel.Password = __value, RegistrationModel.Password))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => RegistrationModel.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "type", "password");
                __builder2.AddAttribute(41, "id", "repeatPassword");
                __builder2.AddAttribute(42, "placeholder", "Repeat password");
                __builder2.AddAttribute(43, "class", "form-control");
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\Pages\NewUser.razor"
                                                                     RegistrationModel.RepeatPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RegistrationModel.RepeatPassword = __value, RegistrationModel.RepeatPassword))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => RegistrationModel.RepeatPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n\r\n        ");
                __builder2.AddMarkupContent(48, "<button type=\"submit\" class=\"btn btn-lg btn-primary btn-block\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\r\n\r\n    ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "hidden", 
#nullable restore
#line 24 "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\Pages\NewUser.razor"
                   !ShowConfirmation

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(52, "\r\n        Thanks for signing up! Please check your email.\r\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\mdrewanz\source\repos\LEARN\BlazorElsa\BlazorElsa\Pages\NewUser.razor"
       

    private RegistrationModel RegistrationModel { get; set; } = new RegistrationModel();
    private bool ShowConfirmation { get; set; } = false;

    private async Task HandleFormSubmission()
    {
        var input = new Variables();

        input.SetVariable("RegistrationModel", RegistrationModel);

        await WorkflowInvoker.TriggerSignalAsync("RegisterUser", input);

        ShowConfirmation = true;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWorkflowInvoker WorkflowInvoker { get; set; }
    }
}
#pragma warning restore 1591
