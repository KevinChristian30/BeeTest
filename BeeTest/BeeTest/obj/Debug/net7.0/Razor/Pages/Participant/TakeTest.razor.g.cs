#pragma checksum "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\TakeTest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48672a7829d61c66db9fde2925baad168d93ccd8"
// <auto-generated/>
#pragma warning disable 1591
namespace BeeTest.Pages.Participant
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using BeeTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using BeeTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\TakeTest.razor"
using BeeTest.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\TakeTest.razor"
using BeeTest.Pages.Components.Gates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\TakeTest.razor"
using BeeTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\TakeTest.razor"
using BeeTest.Pages.Components.QuestionAnswerCard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\TakeTest.razor"
using BeeTest.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\TakeTest.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\TakeTest.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\TakeTest.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\TakeTest.razor"
using BeeTest.Pages.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthenticatedLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/tests/{scheduleId}/take")]
    public partial class TakeTest : global::Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::BeeTest.Pages.Components.Gates.ParticipantOnlyGate>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(2);
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "BeeTest | Test");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
            __builder.AddAttribute(7, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(8, "nav");
                __builder2.AddAttribute(9, "b-vxjl0dk2jh");
                __builder2.OpenElement(10, "h6");
                __builder2.AddAttribute(11, "b-vxjl0dk2jh");
#nullable restore
#line (32,18)-(32,27) 26 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\TakeTest.razor"
__builder2.AddContent(12, test.Name);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "h6");
                __builder2.AddAttribute(15, "b-vxjl0dk2jh");
                __builder2.AddContent(16, "Server Time: ");
#nullable restore
#line (33,31)-(33,41) 26 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\TakeTest.razor"
__builder2.AddContent(17, serverTime);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n        <br b-vxjl0dk2jh><br b-vxjl0dk2jh><br b-vxjl0dk2jh>\r\n\r\n        ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "question-answer-card-container");
                __builder2.AddAttribute(21, "b-vxjl0dk2jh");
#nullable restore
#line 38 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\TakeTest.razor"
             foreach (TemporaryAnswers temporaryAnswer in temporaryAnswers)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "question-answer-card");
                __builder2.AddAttribute(24, "b-vxjl0dk2jh");
                __builder2.OpenComponent<global::BeeTest.Pages.Components.QuestionAnswerCard.QuestionAnswerCardFactory>(25);
                __builder2.AddAttribute(26, "TemporaryAnswers", (object)(
#nullable restore
#line 41 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\TakeTest.razor"
                                                                  temporaryAnswer

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 43 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\TakeTest.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\TakeTest.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationState { get; set; }

    [Parameter]
    public string scheduleId { get; set; }

    private Test test = new Test();
    private List<TemporaryAnswers> temporaryAnswers = new List<TemporaryAnswers>();

    private HubConnection? hubConnection;
    private Timer? timer;
    private string serverTime = DateTime.Now.ToString();

    protected override async Task OnInitializedAsync()
    {
        string currentUserEmail = AuthStateProvider.GetCurrentUserEmail(await authenticationState);

        User participant = await userService.Get(currentUserEmail);
        temporaryAnswers = await temporaryAnswersService.Get(participant.Id, int.Parse(scheduleId));

        await SetServerTimeConnection();

        await base.OnInitializedAsync();
    }

    private async Task SetServerTimeConnection()
    {
        hubConnection = new HubConnectionBuilder()
           .WithUrl(navigationManager.ToAbsoluteUri("/clockhub"))
           .WithAutomaticReconnect()
           .Build();

        hubConnection.On<string>("ReceiveMessage", (time) =>
        {
            serverTime = time;
        });

        timer = new System.Threading.Timer(async _ =>  
        {
            if (hubConnection != null)
            {
                await hubConnection.SendAsync("SendMessage");
            }

            await InvokeAsync(StateHasChanged);
        }, null, 0, 1000);

        await hubConnection.StartAsync();
    }

    public async ValueTask DisposeAsync()
    {
        if (hubConnection != null)
        {
            await hubConnection.DisposeAsync();
        }

        timer?.Dispose();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITemporaryAnswerService temporaryAnswersService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IQuestionService questionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITestService testService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
