#pragma checksum "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a80cf23f6c21af9c9f27bbcc9e525514c34d04ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Nhom11.QLQC.Pages.Pages_DoiTac), @"mvc.1.0.razor-page", @"/Pages/DoiTac.cshtml")]
namespace Nhom11.QLQC.Pages
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
#line 1 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Nhom11.QLQC;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a80cf23f6c21af9c9f27bbcc9e525514c34d04ea", @"/Pages/DoiTac.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c31e6a444f522b33e1936fe7fc53ac62294f87d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DoiTac : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a80cf23f6c21af9c9f27bbcc9e525514c34d04ea3313", async() => {
                WriteLiteral(@"
<div class=""row"">
    <div class=""col-3 form-group"">
        <label>    Mã đối tác :    </label>
        <input type=""text""  id=""mn"" name=""mn"" class=""form-control"" />
    </div>
    <div class=""col-3 form-group"">
        <label style=""margin-left: 50px"">Tên đối tác : </label>
        <input style=""margin-left: 50px"" type=""text""  id=""tn"" name=""tn"" class=""form-control"" />
    </div>
    <div class=""col-3 form-group"">
        <label style=""margin-left: 105px"">Email : </label>
        <input style=""margin-left: 105px"" type=""text""  id=""mtn"" name=""mtn"" class=""form-control"" />
    </div>
    <div class=""col-3 form-group"">
            <br />
            <input  style=""margin-top: 5px; margin-left: 165px"" type=""submit"" class=""btn btn-primary"" value=""Tìm kiếm""/>
    </div>
</div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n<div class=\"text-center\">\r\n    <h2><b>Danh sách đối tác</b></h2>\r\n</div>\r\n    \r\n");
#nullable restore
#line 28 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
 if (Request.Method.ToUpper() == "GET")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-success table-condensed"">
    <tr>
        <th>Mã đối tác</th>
        <th>Tên đối tá</th>
        <th>Email</th>
        <th>Tác vụ</th>
            
    </tr>
    <tr>
        <td>Mã Sản phẩm</td>
        <td>Tên sản phẩm</td>
        <td>Đơn vị tính</td>
    </tr>
</table>
");
#nullable restore
#line 44 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
}
else if(Request.Method.ToUpper() == "POST") {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-success table-condensed\">\r\n    <tr>\r\n        <th>Mã đối tác</th>\r\n        <th>Tên đối tá</th>\r\n        <th>Email</th>\r\n        <th>Tác vụ</th>\r\n    </tr>        \r\n</table>\r\n");
#nullable restore
#line 54 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nhom11.QLQC.Pages.DoiTacModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.DoiTacModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.DoiTacModel>)PageContext?.ViewData;
        public Nhom11.QLQC.Pages.DoiTacModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
