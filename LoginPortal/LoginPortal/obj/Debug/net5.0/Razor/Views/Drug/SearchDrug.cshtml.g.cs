#pragma checksum "C:\Users\user\Desktop\Mentor\MailOrderPharmacy1\LoginPortal\LoginPortal\Views\Drug\SearchDrug.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50dde35a95350665de3c44f3d3bc8d8296b1de91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Drug_SearchDrug), @"mvc.1.0.view", @"/Views/Drug/SearchDrug.cshtml")]
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
#line 1 "C:\Users\user\Desktop\Mentor\MailOrderPharmacy1\LoginPortal\LoginPortal\Views\_ViewImports.cshtml"
using LoginPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\Mentor\MailOrderPharmacy1\LoginPortal\LoginPortal\Views\_ViewImports.cshtml"
using LoginPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50dde35a95350665de3c44f3d3bc8d8296b1de91", @"/Views/Drug/SearchDrug.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f653ff198bfaa2d77d8ce748d80eaae20ef1556", @"/Views/_ViewImports.cshtml")]
    public class Views_Drug_SearchDrug : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginPortal.Models.DrugDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\Desktop\Mentor\MailOrderPharmacy1\LoginPortal\LoginPortal\Views\Drug\SearchDrug.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>DrugDetails</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\user\Desktop\Mentor\MailOrderPharmacy1\LoginPortal\LoginPortal\Views\Drug\SearchDrug.cshtml"
       Write(Html.DisplayNameFor(model => model.DrugId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\user\Desktop\Mentor\MailOrderPharmacy1\LoginPortal\LoginPortal\Views\Drug\SearchDrug.cshtml"
       Write(Html.DisplayFor(model => model.DrugId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\user\Desktop\Mentor\MailOrderPharmacy1\LoginPortal\LoginPortal\Views\Drug\SearchDrug.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\user\Desktop\Mentor\MailOrderPharmacy1\LoginPortal\LoginPortal\Views\Drug\SearchDrug.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\user\Desktop\Mentor\MailOrderPharmacy1\LoginPortal\LoginPortal\Views\Drug\SearchDrug.cshtml"
       Write(Html.DisplayNameFor(model => model.Manufacturer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\user\Desktop\Mentor\MailOrderPharmacy1\LoginPortal\LoginPortal\Views\Drug\SearchDrug.cshtml"
       Write(Html.DisplayFor(model => model.Manufacturer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\user\Desktop\Mentor\MailOrderPharmacy1\LoginPortal\LoginPortal\Views\Drug\SearchDrug.cshtml"
       Write(Html.DisplayNameFor(model => model.ManufacturedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\user\Desktop\Mentor\MailOrderPharmacy1\LoginPortal\LoginPortal\Views\Drug\SearchDrug.cshtml"
       Write(Html.DisplayFor(model => model.ManufacturedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\user\Desktop\Mentor\MailOrderPharmacy1\LoginPortal\LoginPortal\Views\Drug\SearchDrug.cshtml"
       Write(Html.DisplayNameFor(model => model.ExpiryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\user\Desktop\Mentor\MailOrderPharmacy1\LoginPortal\LoginPortal\Views\Drug\SearchDrug.cshtml"
       Write(Html.DisplayFor(model => model.ExpiryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\user\Desktop\Mentor\MailOrderPharmacy1\LoginPortal\LoginPortal\Views\Drug\SearchDrug.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\user\Desktop\Mentor\MailOrderPharmacy1\LoginPortal\LoginPortal\Views\Drug\SearchDrug.cshtml"
       Write(Html.DisplayFor(model => model.UnitCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 52 "C:\Users\user\Desktop\Mentor\MailOrderPharmacy1\LoginPortal\LoginPortal\Views\Drug\SearchDrug.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50dde35a95350665de3c44f3d3bc8d8296b1de918285", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginPortal.Models.DrugDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
