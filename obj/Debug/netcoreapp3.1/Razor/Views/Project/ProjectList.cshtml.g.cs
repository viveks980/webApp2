#pragma checksum "C:\Users\vivek\source\repos\WebApplication2\Views\Project\ProjectList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "161e4091f8a94f9f50b0b6de3463931ca41f5eb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_ProjectList), @"mvc.1.0.view", @"/Views/Project/ProjectList.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\vivek\source\repos\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vivek\source\repos\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"161e4091f8a94f9f50b0b6de3463931ca41f5eb7", @"/Views/Project/ProjectList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_ProjectList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication2.Models.user>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "161e4091f8a94f9f50b0b6de3463931ca41f5eb73431", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "C:\Users\vivek\source\repos\WebApplication2\Views\Project\ProjectList.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\vivek\source\repos\WebApplication2\Views\Project\ProjectList.cshtml"
           Write(Html.DisplayNameFor(model => model.projectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\vivek\source\repos\WebApplication2\Views\Project\ProjectList.cshtml"
           Write(Html.DisplayNameFor(model => model.fromDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\vivek\source\repos\WebApplication2\Views\Project\ProjectList.cshtml"
           Write(Html.DisplayNameFor(model => model.toDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\vivek\source\repos\WebApplication2\Views\Project\ProjectList.cshtml"
           Write(Html.DisplayNameFor(model => model.leaderName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\vivek\source\repos\WebApplication2\Views\Project\ProjectList.cshtml"
           Write(Html.DisplayNameFor(model => model.projectStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\vivek\source\repos\WebApplication2\Views\Project\ProjectList.cshtml"
           Write(Html.DisplayNameFor(model => model.projectClient));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\vivek\source\repos\WebApplication2\Views\Project\ProjectList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\vivek\source\repos\WebApplication2\Views\Project\ProjectList.cshtml"
           Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\vivek\source\repos\WebApplication2\Views\Project\ProjectList.cshtml"
           Write(Html.DisplayFor(modelItem => item.projectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\vivek\source\repos\WebApplication2\Views\Project\ProjectList.cshtml"
           Write(Html.DisplayFor(modelItem => item.fromDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\vivek\source\repos\WebApplication2\Views\Project\ProjectList.cshtml"
           Write(Html.DisplayFor(modelItem => item.toDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\vivek\source\repos\WebApplication2\Views\Project\ProjectList.cshtml"
           Write(Html.DisplayFor(modelItem => item.leaderName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\vivek\source\repos\WebApplication2\Views\Project\ProjectList.cshtml"
           Write(Html.DisplayFor(modelItem => item.projectStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\vivek\source\repos\WebApplication2\Views\Project\ProjectList.cshtml"
           Write(Html.DisplayFor(modelItem => item.projectClient));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            WriteLiteral("                <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1982, "\"", 2010, 3);
            WriteAttributeValue("", 1992, "deletefn(", 1992, 9, true);
#nullable restore
#line 61 "C:\Users\vivek\source\repos\WebApplication2\Views\Project\ProjectList.cshtml"
WriteAttributeValue("", 2001, item.id, 2001, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2009, ")", 2009, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n                <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2066, "\"", 2092, 3);
            WriteAttributeValue("", 2076, "editfn(", 2076, 7, true);
#nullable restore
#line 62 "C:\Users\vivek\source\repos\WebApplication2\Views\Project\ProjectList.cshtml"
WriteAttributeValue("", 2083, item.id, 2083, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2091, ")", 2091, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</button>\r\n                \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 66 "C:\Users\vivek\source\repos\WebApplication2\Views\Project\ProjectList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication2.Models.user>> Html { get; private set; }
    }
}
#pragma warning restore 1591
