#pragma checksum "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong_DoiTac.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94fcf31158463a680b20e8be72d2385f8edf8b71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Nhom11.QLQC.Pages.Pages_HopDong_DoiTac), @"mvc.1.0.razor-page", @"/Pages/HopDong_DoiTac.cshtml")]
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
#line 1 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Nhom11.QLQC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Nhom11.QLQC.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong_DoiTac.cshtml"
using global::QLQC.DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94fcf31158463a680b20e8be72d2385f8edf8b71", @"/Pages/HopDong_DoiTac.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b39bf525f09de2fceaa200944ecf09c0e81b8ae", @"/Pages/_ViewImports.cshtml")]
    public class Pages_HopDong_DoiTac : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("<h1 style=\"text-align:center; margin-bottom : 20px\">Tìm Hợp đồng đối tác đã ký</h1>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94fcf31158463a680b20e8be72d2385f8edf8b714035", async() => {
                WriteLiteral(@"
        <div style=""display:inline-block; margin-left : 32%"">
            <label>Tìm theo tên đối tác</label>
            <input type=""radio"" name=""a"" value=""tkh"" class=""form-control"" />
        </div>
        <div style=""display: inline-block; margin-left : 50px"">
            <label>Tìm theo mã đối tác</label>
            <input type=""radio"" name=""a"" value=""mkh"" class=""form-control"" />
        </div>
        <div style=""margin-left : 30%;margin-right : 30%;margin-top : 20px"">
            <label style=""display: inline-block"">Nhập tên hoặc mã đối tác</label>
            <input style=""margin-left :145px"" type=""submit"" value=""Tìm kiếm"" class=""btn btn-primary"" />
            <input style=""margin-top : 10px;margin-bottom : 20px"" type=""text"" id=""ass"" name=""ass"" class=""form-control"" />
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
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 24 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong_DoiTac.cshtml"
 if (Request.Method.ToUpper() == "GET")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-success table-condensed"">
        <tr style=""text-align:center"">
            <th>Mã hợp đồng</th>
            <th>Ngày ký kết</th>
            <th>Mã nhân viên thực hiện</th>
            <th>Mã đối tác</th>
        </tr>
    </table>
");
#nullable restore
#line 34 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong_DoiTac.cshtml"
}
else if (Request.Method.ToUpper() == "POST")
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong_DoiTac.cshtml"
     if (@Model.gt != "")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-success table-condensed"">
            <tr style=""text-align:center"">
                <th>Mã hợp đồng</th>
                <th>Ngày ký kết</th>
                <th>Mã nhân viên thực hiện</th>
                <th>Mã đối tác</th>
            </tr>
");
#nullable restore
#line 46 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong_DoiTac.cshtml"
             foreach (HopDongDTO hd in Model.lst)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr id=\"trHd@hd.MaHd\" style=\"text-align:center\">\r\n                    <td>");
#nullable restore
#line 49 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong_DoiTac.cshtml"
                   Write(hd.MaHD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong_DoiTac.cshtml"
                   Write(hd.NgayKy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 51 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong_DoiTac.cshtml"
                   Write(hd.MaNV);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 52 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong_DoiTac.cshtml"
                   Write(hd.MaKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 54 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong_DoiTac.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 56 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong_DoiTac.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-success table-condensed"">
            <tr style=""text-align:center"">
                <th>Mã hợp đồng</th>
                <th>Ngày ký kết</th>
                <th>Mã nhân viên thực hiện</th>
                <th>Mã đối tác</th>
            </tr>
        </table>
");
#nullable restore
#line 67 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong_DoiTac.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong_DoiTac.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nhom11.QLQC.Pages.HopDong_DoiTacModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.HopDong_DoiTacModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.HopDong_DoiTacModel>)PageContext?.ViewData;
        public Nhom11.QLQC.Pages.HopDong_DoiTacModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
