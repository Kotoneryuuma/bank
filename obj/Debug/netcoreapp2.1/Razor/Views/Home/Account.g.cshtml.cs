#pragma checksum "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/bank/Views/Home/Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "653c1f2897896f4a6d9c545d39fcac2a5509aefa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Account), @"mvc.1.0.view", @"/Views/Home/Account.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Account.cshtml", typeof(AspNetCore.Views_Home_Account))]
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
#line 1 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/bank/Views/_ViewImports.cshtml"
using bank;

#line default
#line hidden
#line 2 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/bank/Views/_ViewImports.cshtml"
using bank.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"653c1f2897896f4a6d9c545d39fcac2a5509aefa", @"/Views/Home/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aed3b53ca3488f519a03a27c031ec8a31a8b6588", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Account : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bank.Models.Account>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "TransactionFormPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 14, true);
            WriteLiteral("\n<h1>Welcome, ");
            EndContext();
            BeginContext(42, 14, false);
#line 3 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/bank/Views/Home/Account.cshtml"
        Write(Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(56, 48, true);
            WriteLiteral("</h1>\n\n<p>Current balance: <span class=\"amount\">");
            EndContext();
            BeginContext(105, 13, false);
#line 5 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/bank/Views/Home/Account.cshtml"
                                    Write(Model.Balance);

#line default
#line hidden
            EndContext();
            BeginContext(118, 13, true);
            WriteLiteral("</span></p>\n\n");
            EndContext();
            BeginContext(131, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c2b830a663e64f7aaaa068b4d080ac92", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 7 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/bank/Views/Home/Account.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.changeForm;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(195, 79, true);
            WriteLiteral("</partial>\n\n<table>\n  <thead>\n    <th>Amount</th>\n    <th>Date</th>\n  </thead>\n");
            EndContext();
#line 14 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/bank/Views/Home/Account.cshtml"
   foreach (History t in Model.History)
  {

#line default
#line hidden
            BeginContext(318, 19, true);
            WriteLiteral("    <tr>\n      <td>");
            EndContext();
            BeginContext(338, 8, false);
#line 17 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/bank/Views/Home/Account.cshtml"
     Write(t.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(346, 16, true);
            WriteLiteral("</td>\n      <td>");
            EndContext();
            BeginContext(363, 6, false);
#line 18 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/bank/Views/Home/Account.cshtml"
     Write(t.Date);

#line default
#line hidden
            EndContext();
            BeginContext(369, 16, true);
            WriteLiteral("</td>\n    </tr>\n");
            EndContext();
#line 20 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/bank/Views/Home/Account.cshtml"
  }

#line default
#line hidden
            BeginContext(389, 8, true);
            WriteLiteral("</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bank.Models.Account> Html { get; private set; }
    }
}
#pragma warning restore 1591
