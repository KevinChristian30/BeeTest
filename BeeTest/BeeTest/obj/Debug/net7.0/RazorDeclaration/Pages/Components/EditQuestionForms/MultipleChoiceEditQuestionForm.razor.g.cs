// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BeeTest.Pages.Components.EditQuestionForms
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
#line 1 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\MultipleChoiceEditQuestionForm.razor"
using BeeTest.Factories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\MultipleChoiceEditQuestionForm.razor"
using BeeTest.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\MultipleChoiceEditQuestionForm.razor"
using BeeTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\MultipleChoiceEditQuestionForm.razor"
using BeeTest.Models.QuestionDetail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\MultipleChoiceEditQuestionForm.razor"
using BeeTest.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\MultipleChoiceEditQuestionForm.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    public partial class MultipleChoiceEditQuestionForm : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\MultipleChoiceEditQuestionForm.razor"
       
    [Parameter]
    public int QuestionId { get; set; }

    private bool IsLoading = false;

    private Question Question;
    private MultipleChoiceQuestionDetail QuestionDetail;
    private Dictionary<char, string> choices = new Dictionary<char, string>();
    private char key;
    private bool IsAChecked => key == 'a';
    private bool IsBChecked => key == 'b';
    private bool IsCChecked => key == 'c';
    private bool IsDChecked => key == 'd';
    private bool IsEChecked => key == 'e';

    protected override async Task OnInitializedAsync()
    {
        Question = await questionService.Get(QuestionId);
        QuestionDetail = (MultipleChoiceQuestionDetail) QuestionDetailFactory.ParseJSON(Question.QuestionType.Name, Question.Details);

        choices = QuestionDetail.Choices;
        key = QuestionDetail.Key;

        await base.OnInitializedAsync();
    }   

    private async Task Save()
    {
        IsLoading = true;
        await Task.Delay(1);

        if (!(await AreFormValuesValid()))
        {
            IsLoading = false;
            await Task.Delay(1);

            return;
        }

        QuestionDetail.Choices = choices;
        QuestionDetail.Key = key;
        Question.Details = QuestionDetail.ToJSONString();

        if (await questionService.AddOrUpdate(Question))
        {
            await js.InvokeVoidAsync("alert", "Question Save Successfully");
        }
        else await js.InvokeVoidAsync("alert", "Couldn't Save Question");

        IsLoading = false;
        await Task.Delay(1);
    }

    private async Task<bool> AreFormValuesValid()
    {
        if (Question.Title == null || Question.Title == "")
        {
            await js.InvokeVoidAsync("alert", "Question title must be filled");
            return false;
        }

        if (choices['a'] == "" || choices['b'] == "" || choices['c'] == "" || choices['d'] == "" || choices['e'] == "")
        {
            await js.InvokeVoidAsync("alert", "All choices must be filled");
            return false;
        }

        if (key == '\0')
        {
            await js.InvokeVoidAsync("alert", "Question answer key must be chosen");
            return false;
        }

        return true;
    }

    private void UpdateKey(ChangeEventArgs e) => key = e.Value.ToString()[0];

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IQuestionService questionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITestService testService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
