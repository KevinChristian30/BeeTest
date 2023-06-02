#pragma checksum "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\CheckboxesQuestionForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "835a29d4fb372ac69f209dad12873c1c7efd206b"
// <auto-generated/>
#pragma warning disable 1591
namespace BeeTest.Pages.Components.QuestionForms
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
#line 1 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\CheckboxesQuestionForm.razor"
using BeeTest.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\CheckboxesQuestionForm.razor"
using BeeTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\CheckboxesQuestionForm.razor"
using BeeTest.Models.QuestionDetail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\CheckboxesQuestionForm.razor"
using BeeTest.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\CheckboxesQuestionForm.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    public partial class CheckboxesQuestionForm : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 13 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\CheckboxesQuestionForm.razor"
 if (IsLoading)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::BeeTest.Pages.Components.LoadingView>(0);
            __builder.CloseComponent();
#nullable restore
#line 16 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\CheckboxesQuestionForm.razor"
} else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "form");
            __builder.AddAttribute(2, "class", "question-form");
            __builder.AddAttribute(3, "b-x3iqv3qq66");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "id", "question-title");
            __builder.AddAttribute(6, "b-x3iqv3qq66");
            __builder.AddMarkupContent(7, "<label for=\"title\" b-x3iqv3qq66>Question Title</label>\r\n            ");
            __builder.OpenElement(8, "textarea");
            __builder.AddAttribute(9, "id", "title");
            __builder.AddAttribute(10, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\CheckboxesQuestionForm.razor"
                                         NewQuestion.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewQuestion.Title = __value, NewQuestion.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(12, "b-x3iqv3qq66");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "id", "choices-container");
            __builder.AddAttribute(16, "b-x3iqv3qq66");
            __builder.AddMarkupContent(17, "<div id=\"top\" b-x3iqv3qq66><h6 b-x3iqv3qq66>Choices</h6></div>\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "id", "bottom");
            __builder.AddAttribute(20, "b-x3iqv3qq66");
#nullable restore
#line 28 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\CheckboxesQuestionForm.razor"
                 foreach (var keyValuePair in QuestionDetail.CheckboxQuestionData)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "line");
            __builder.AddAttribute(23, "b-x3iqv3qq66");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "checkbox");
            __builder.AddAttribute(26, "checked", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\CheckboxesQuestionForm.razor"
                                                       keyValuePair.Value.IsTrue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => keyValuePair.Value.IsTrue = __value, keyValuePair.Value.IsTrue));
            __builder.SetUpdatesAttributeName("checked");
            __builder.AddAttribute(28, "b-x3iqv3qq66");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "textarea");
            __builder.AddAttribute(31, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\CheckboxesQuestionForm.razor"
                                          keyValuePair.Value.Statement

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => keyValuePair.Value.Statement = __value, keyValuePair.Value.Statement));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(33, "b-x3iqv3qq66");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenComponent<global::BeeTest.Pages.Components.Button>(35);
            __builder.AddAttribute(36, "Text", (object)("Remove"));
            __builder.AddAttribute(37, "OnClick", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, 
#nullable restore
#line 33 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\CheckboxesQuestionForm.razor"
                                                         () => RemoveDetailData(@keyValuePair.Key)

#line default
#line hidden
#nullable disable
            ))));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\CheckboxesQuestionForm.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenComponent<global::BeeTest.Pages.Components.Button>(39);
            __builder.AddAttribute(40, "Text", (object)("Add Choice"));
            __builder.AddAttribute(41, "OnClick", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, 
#nullable restore
#line 38 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\CheckboxesQuestionForm.razor"
                                           AddNewDetailData

#line default
#line hidden
#nullable disable
            ))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenComponent<global::BeeTest.Pages.Components.Button>(43);
            __builder.AddAttribute(44, "Text", (object)("Add Question"));
            __builder.AddAttribute(45, "OnClick", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, 
#nullable restore
#line 39 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\CheckboxesQuestionForm.razor"
                                             Save

#line default
#line hidden
#nullable disable
            ))));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\CheckboxesQuestionForm.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\CheckboxesQuestionForm.razor"
       
    [Parameter]
    public int TestId { get; set; }

    private Question NewQuestion = new Question();
    private CheckboxesQuestionDetail QuestionDetail = new CheckboxesQuestionDetail();

    private bool IsLoading = false;

    protected override void OnInitialized()
    {
        ResetFormValues();

        base.OnInitialized();
    }

    private void AddNewDetailData()
    {
        int newKey = QuestionDetail.CheckboxQuestionData.Count() + 1;
        while (true)
        {
            if (QuestionDetail.CheckboxQuestionData.ContainsKey(newKey))
            {
                newKey++;
                continue;
            }

            QuestionDetail.CheckboxQuestionData.Add(
                newKey,
                new CheckboxesQuestionDetail.Data()
            );

            break;
        }
    }

    private async Task RemoveDetailData(int key)
    {
        if (QuestionDetail.CheckboxQuestionData.Count() <= 2)
        {
            await js.InvokeVoidAsync("alert", "You must have at least 2 choices, if your question is a boolean, try making a boolean question instead");
            return;
        }

        QuestionDetail.CheckboxQuestionData.Remove(key);
    }

    private async Task Save()
    {
        if (!(await AreFormValuesValid())) return;

        IsLoading = true;
        await Task.Delay(1);

        NewQuestion.Id = 0;
        NewQuestion.Details = QuestionDetail.ToJSONString();
        NewQuestion.Test = await testService.Get(TestId);
        NewQuestion.QuestionType = await questionTypeService.Get("Checkboxes");

        if (await questionService.AddOrUpdate(NewQuestion))
        {
            await js.InvokeVoidAsync("alert", "Question Added Successfully");

            ResetFormValues();
        }
        else await js.InvokeVoidAsync("alert", "Couldn't Save Question");

        IsLoading = false;
        await Task.Delay(1);
    }

    private async Task<bool> AreFormValuesValid()
    {
        if (NewQuestion.Title == null || NewQuestion.Title == "")
        {
            await js.InvokeVoidAsync("alert", "Question title must be filled");
            return false;
        }

        bool hasOneTrue = false;
        foreach (var keyValuePair in QuestionDetail.CheckboxQuestionData)
        {
            if (keyValuePair.Value.Statement == null || keyValuePair.Value.Statement == "")
            {
                await js.InvokeVoidAsync("alert", "Every choice should have a statement");
                return false;
            }

            if (keyValuePair.Value.IsTrue) hasOneTrue = true;
        }

        if (!hasOneTrue)
        {
            await js.InvokeVoidAsync("alert", "The question must have at least 1 true statement");
            return false;
        }

        return true;
    }

    private void ResetFormValues()
    {
        NewQuestion = new Question();
        NewQuestion.Title = "Manakah dari pernyataan ini yang benar?";

        QuestionDetail.CheckboxQuestionData = new Dictionary<int, CheckboxesQuestionDetail.Data>();
        for (int i = 0; i < 2; i++) AddNewDetailData();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IQuestionService questionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IQuestionTypeService questionTypeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITestService testService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
