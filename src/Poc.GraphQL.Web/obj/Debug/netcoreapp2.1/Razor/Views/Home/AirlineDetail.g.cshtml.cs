#pragma checksum "C:\src\Poc.GraphQL\src\Poc.GraphQL.Web\Views\Home\AirlineDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ea1a18ebabf58eca90763ee663ecf1df142a6bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Poc.GraphQL.Web.Views.Home.Views_Home_AirlineDetail), @"mvc.1.0.view", @"/Views/Home/AirlineDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AirlineDetail.cshtml", typeof(Poc.GraphQL.Web.Views.Home.Views_Home_AirlineDetail))]
namespace Poc.GraphQL.Web.Views.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ea1a18ebabf58eca90763ee663ecf1df142a6bd", @"/Views/Home/AirlineDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d70d32edffdd56c102acd2993a07f80dfd45fdc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AirlineDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Poc.GraphQL.Web.Models.AirlineModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddReview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 52, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-3\">\r\n        ");
            EndContext();
            BeginContext(96, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a111d6d45ff34ac2b633bcb9656bb0a6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 106, "~/images/", 106, 9, true);
#line 4 "C:\src\Poc.GraphQL\src\Poc.GraphQL.Web\Views\Home\AirlineDetail.cshtml"
AddHtmlAttributeValue("", 115, Model.LogoFileName, 115, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(158, 120, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-9\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <h3>");
            EndContext();
            BeginContext(279, 10, false);
#line 9 "C:\src\Poc.GraphQL\src\Poc.GraphQL.Web\Views\Home\AirlineDetail.cshtml"
               Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(289, 125, true);
            WriteLiteral("</h3>\r\n            </div>\r\n        </div>\r\n        <div class=\"row mb-3\">\r\n            <div class=\"col-12\">\r\n                ");
            EndContext();
            BeginContext(415, 17, false);
#line 14 "C:\src\Poc.GraphQL\src\Poc.GraphQL.Web\Views\Home\AirlineDetail.cshtml"
           Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(432, 139, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row mb-4\">\r\n            <div class=\"col-3\">\r\n                In the world since: ");
            EndContext();
            BeginContext(572, 20, false);
#line 19 "C:\src\Poc.GraphQL\src\Poc.GraphQL.Web\Views\Home\AirlineDetail.cshtml"
                               Write(Model.CreatedAt.Year);

#line default
#line hidden
            EndContext();
            BeginContext(592, 78, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-3\">\r\n                Stars: ");
            EndContext();
            BeginContext(671, 12, false);
#line 22 "C:\src\Poc.GraphQL\src\Poc.GraphQL.Web\Views\Home\AirlineDetail.cshtml"
                  Write(Model.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(683, 90, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-3\">\r\n                Number Of Planes: $");
            EndContext();
            BeginContext(774, 20, false);
#line 25 "C:\src\Poc.GraphQL\src\Poc.GraphQL.Web\Views\Home\AirlineDetail.cshtml"
                              Write(Model.NumberOfPlanes);

#line default
#line hidden
            EndContext();
            BeginContext(794, 107, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <h6>Reviews:</h6>\r\n        <div id=\"reviews\"></div>\r\n        ");
            EndContext();
            BeginContext(901, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b36c08ce5e164c6b9aa423f6444b5b7c", async() => {
                BeginContext(959, 12, true);
                WriteLiteral("Add a review");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-airlineId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "C:\src\Poc.GraphQL\src\Poc.GraphQL.Web\Views\Home\AirlineDetail.cshtml"
                                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["airlineId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-airlineId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["airlineId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(975, 93, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<script src=\"https://unpkg.com/apollo-client-browser@1.9.0\"></script>\r\n");
            EndContext();
            BeginContext(1068, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1556f233277c4023a7a70d3aa2b6a191", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1104, 120, true);
            WriteLiteral("\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js\"></script>\r\n<script>\r\n    renderReviews(");
            EndContext();
            BeginContext(1225, 8, false);
#line 37 "C:\src\Poc.GraphQL\src\Poc.GraphQL.Web\Views\Home\AirlineDetail.cshtml"
             Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1233, 13, true);
            WriteLiteral(");\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Poc.GraphQL.Web.Models.AirlineModel> Html { get; private set; }
    }
}
#pragma warning restore 1591