#pragma checksum "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HTQC_KhachHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27fa73acde0f1ef8a95f9a5e7f8934ec259b1b85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Nhom11.QLQC.Pages.Pages_HTQC_KhachHang), @"mvc.1.0.razor-page", @"/Pages/HTQC_KhachHang.cshtml")]
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
#line 1 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Nhom11.QLQC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Nhom11.QLQC.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HTQC_KhachHang.cshtml"
using global::QLQC.DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27fa73acde0f1ef8a95f9a5e7f8934ec259b1b85", @"/Pages/HTQC_KhachHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b39bf525f09de2fceaa200944ecf09c0e81b8ae", @"/Pages/_ViewImports.cshtml")]
    public class Pages_HTQC_KhachHang : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("<h1 style=\"text-align:center; margin-bottom : 20px\">Tìm Loại quảng cáo đối tác đã dùng qua</h1>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27fa73acde0f1ef8a95f9a5e7f8934ec259b1b853972", async() => {
                WriteLiteral(@"
        <div style=""display:inline-block; margin-left : 32%"">
            <label>Tìm theo tên khách hàng</label>
            <input type=""radio"" name=""a"" value=""tkh"" class=""form-control"" />
        </div>
        <div style=""display: inline-block; margin-left : 50px"">
            <label>Tìm theo mã khách hàng</label>
            <input type=""radio"" name=""a"" value=""mkh"" class=""form-control"" />
        </div>
        <div style=""margin-left : 32%;margin-right : 30%;margin-top : 20px"">
            <label style=""display: inline-block"">Nhập tên hoặc mã khách hàng</label>
            <input style=""margin-left :110px"" type=""submit"" value=""Tìm kiếm"" class=""btn btn-primary"" />
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
#line 24 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HTQC_KhachHang.cshtml"
 if (Request.Method.ToUpper() == "GET")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-success table-condensed"">
        <tr style=""text-align:center"">
            <th>Mã Loai</th>
            <th>Hình thức</th>
            <th>Mô tả</th>
            <th>Mã khách hàng</th>
            <th>Tên khách hàng</th>
        </tr>
    </table>
");
#nullable restore
#line 35 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HTQC_KhachHang.cshtml"
}
else if (Request.Method.ToUpper() == "POST")
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HTQC_KhachHang.cshtml"
     if (@Model.gt != "")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-success table-condensed"">
            <tr style=""text-align:center"">
                <th>Mã Loai</th>
                <th>Hình thức</th>
                <th>Mô tả</th>
                <th>Mã khách hàng</th>
                <th>Tên khách hàng</th>

            </tr>
");
#nullable restore
#line 50 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HTQC_KhachHang.cshtml"
             foreach (LoaiQcDTO lqc in Model.lstlqc)
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr style=\"text-align:center\">\r\n            <td>");
#nullable restore
#line 53 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HTQC_KhachHang.cshtml"
           Write(lqc.MaLoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 54 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HTQC_KhachHang.cshtml"
           Write(lqc.HinhThuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 55 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HTQC_KhachHang.cshtml"
           Write(lqc.MoTa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td>\r\n");
#nullable restore
#line 57 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HTQC_KhachHang.cshtml"
                 foreach (KhachHangDTO q in Model.lstkh)
                 {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HTQC_KhachHang.cshtml"
               Write(q.MaKH);

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HTQC_KhachHang.cshtml"
                           
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n             <td>\r\n");
#nullable restore
#line 63 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HTQC_KhachHang.cshtml"
                 foreach (KhachHangDTO q in Model.lstkh)
                 {
                    
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HTQC_KhachHang.cshtml"
               Write(q.TenKH);

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HTQC_KhachHang.cshtml"
                            
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 70 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HTQC_KhachHang.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 72 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HTQC_KhachHang.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-success table-condensed"">
            <tr style=""text-align:center"">
                <th>Mã Loai</th>
                <th>Hình thức</th>
                <th>Mô tả</th>
                <th>Mã khách hàng</th>
                <th>Tên khách hàng</th>
            </tr>
        </table>
");
#nullable restore
#line 84 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HTQC_KhachHang.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HTQC_KhachHang.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nhom11.QLQC.Pages.HTQC_KhachHangModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.HTQC_KhachHangModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.HTQC_KhachHangModel>)PageContext?.ViewData;
        public Nhom11.QLQC.Pages.HTQC_KhachHangModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
