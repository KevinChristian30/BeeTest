// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BeeTest.Pages.Tests
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
#line 4 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Tests\TestDetails.razor"
using BeeTest.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Tests\TestDetails.razor"
using BeeTest.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Tests\TestDetails.razor"
using BeeTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Tests\TestDetails.razor"
using BeeTest.Services.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthenticatedLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/tests/{id}")]
    public partial class TestDetails : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Tests\TestDetails.razor"
       
    [Parameter]
    public string id { get; set; }

    [CascadingParameter]
    private Task<AuthenticationState> authenticationState { get; set; }

    private bool IsLoading = false;
    private Test test = new Test();
    private Test oldTestData = new Test();
    private List<Question> questions = new List<Question>();

    protected override async Task OnInitializedAsync()
    {
        var authState = await authenticationState;
        AuthStateProvider.AllowAdminOnly(authState, navigationManager);

        test = await testService.Get(int.Parse(id));
        questions = await questionService.GetQuestionsByTestId(int.Parse(id));

        oldTestData.Name = test.Name;
        oldTestData.PassingScore = test.PassingScore;

        await base.OnInitializedAsync();
    }

    private async Task Save()
    {
        if (test.Name == oldTestData.Name && test.PassingScore == oldTestData.PassingScore)
        {
            await js.InvokeVoidAsync("alert", "You didn't Change Anything");
            return;
        }

        IsLoading = true;
        await Task.Delay(1);

        if (!(await AreFormValuesValid()))
        {
            IsLoading = false;
            await Task.Delay(1);

            return;
        }

        if (await testService.AddOrUpdate(test))
        {
            oldTestData.Name = test.Name;

            await js.InvokeVoidAsync("alert", "Test Updated Successfully");
        } else await js.InvokeVoidAsync("alert", "Couldn't Update Test");

        IsLoading = false;
        await Task.Delay(1);
    }

    private async Task<bool> AreFormValuesValid()
    {
        if (test.Name == null || test.Name == "")
        {
            await js.InvokeVoidAsync("alert", "Test Name can't be empty");
            return false;
        }

        Test testThatHasTheSameName = await testService.Get(test.Name);
        if (test.Name != oldTestData.Name && testThatHasTheSameName != null)
        {
            await js.InvokeVoidAsync("alert", "Test Name is Already Taken");
            return false;
        }

        if (test.PassingScore > 100 || test.PassingScore < 1)
        {
            await js.InvokeVoidAsync("alert", "Test Passing Score Must be Between 1 and 100");
            return false;
        }

        return true;
    }

    private void NavigateToAddQuestionPage()
    {
        navigationManager.NavigateTo($"/tests/{id}/questions/add", true);
    }

    private async Task RemoveQuestion(Question question)
    {
        IsLoading = true;

        bool isSucessful = await questionService.Delete(question.Id);
        IsLoading = false;

        if (isSucessful) questions.Remove(question);
        else await js.InvokeVoidAsync("alert", "Question Deletion Failed");
    }

    private void NavigateToEditPage(int id)
    {
        navigationManager.NavigateTo($"/questions/{id}/edit", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IQuestionService questionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITestService testService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
