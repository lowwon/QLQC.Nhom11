#pragma checksum "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\QuangCao_KhachHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "076b5c6287284d0a0e4aad04fe9e77923441b723"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Nhom11.QLQC.Pages.Pages_QuangCao_KhachHang), @"mvc.1.0.razor-page", @"/Pages/QuangCao_KhachHang.cshtml")]
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
#line 1 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Nhom11.QLQC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Nhom11.QLQC.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\QuangCao_KhachHang.cshtml"
using global::QLQC.DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"076b5c6287284d0a0e4aad04fe9e77923441b723", @"/Pages/QuangCao_KhachHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b39bf525f09de2fceaa200944ecf09c0e81b8ae", @"/Pages/_ViewImports.cshtml")]
    public class Pages_QuangCao_KhachHang : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/QuangCaoVaLoaiQuangCao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1 style=\"text-align:center; margin-bottom : 20px\">Tìm quảng cáo của khách hàng</h1>\r\n<div >\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "076b5c6287284d0a0e4aad04fe9e77923441b7234796", async() => {
                WriteLiteral(@"
		<div style=""display:inline-block; margin-left : 32%"">
			<label>Tìm theo tên khách hàng</label>
			<input type=""radio"" name=""a"" value=""tkh"" class=""form-control"" />
		</div>
		<div style = ""display: inline-block; margin-left : 50px"">
			<label>Tìm theo mã khách hàng</label>
			<input type=""radio"" name=""a"" value=""mkh""  class=""form-control""/>
		</div>
		<div style = ""margin-left : 32%;margin-right : 30%;margin-top : 20px"">
			<label style = ""display: inline-block"">Nhập tên hoặc mã khách hàng</label>
			<input style = ""margin-left :110px"" type=""submit"" value=""Tìm kiếm"" class=""btn btn-primary""/>
			<input style=""margin-top : 10px;margin-bottom : 20px"" type=""text"" id=""ass"" name=""ass"" class=""form-control""/>
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
#line 24 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\QuangCao_KhachHang.cshtml"
 if (Request.Method.ToUpper() == "GET")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-success table-condensed"">
    <tr style=""text-align:center"">
        <th>Mã quảng cáo</th>
        <th>Ngày thành lập</th>
        <th>Ngày kết thúc</th>
        <th>Tổng tiền</th>
        <th>Nhóm thực hiện</th>
        <th>Khách hàng</th>
        <th>Mô tả</th>
        <th>Loại quảng cáo</th>
    </tr>
    </table>
");
#nullable restore
#line 38 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\QuangCao_KhachHang.cshtml"
}
else if(Request.Method.ToUpper() == "POST") {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\QuangCao_KhachHang.cshtml"
         if (@Model.gt != "")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-success table-condensed"">
            <tr style=""text-align:center"">
                <th>Mã quảng cáo</th>
                <th>Ngày thành lập</th>
                <th>Ngày kết thúc</th>
                <th>Số tiền</th>
                <th>Nhóm thực hiện</th>
                <th>Khách hàng</th>
                <th>Mô tả</th>
                <th>Loại quảng cáo</th>
            </tr>
");
#nullable restore
#line 53 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\QuangCao_KhachHang.cshtml"
             foreach (QuangCaoDTO qc in Model.lst)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr id=\"trQc@qc.MaQc\" style=\"text-align:center\">\r\n                    <td>");
#nullable restore
#line 56 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\QuangCao_KhachHang.cshtml"
                   Write(qc.MaQc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 57 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\QuangCao_KhachHang.cshtml"
                   Write(qc.NgBd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 58 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\QuangCao_KhachHang.cshtml"
                   Write(qc.NgKt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 59 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\QuangCao_KhachHang.cshtml"
                   Write(qc.SoTien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 60 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\QuangCao_KhachHang.cshtml"
                   Write(qc.MaNhom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 61 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\QuangCao_KhachHang.cshtml"
                   Write(qc.MaKh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 62 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\QuangCao_KhachHang.cshtml"
                   Write(qc.YeuCau);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 64 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\QuangCao_KhachHang.cshtml"
                         foreach (var q in Model.lst1)
                       {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\QuangCao_KhachHang.cshtml"
                             if(String.Compare(@q.MaQc, @qc.MaQc)==0)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\QuangCao_KhachHang.cshtml"
                           Write(q.MaLoai);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 69 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\QuangCao_KhachHang.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\QuangCao_KhachHang.cshtml"
                             
                        
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "076b5c6287284d0a0e4aad04fe9e77923441b72312132", async() => {
                WriteLiteral("Chi tiết");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 76 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\QuangCao_KhachHang.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n");
#nullable restore
#line 78 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\QuangCao_KhachHang.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-success table-condensed"">
            <tr style=""text-align:center"">
                <th>Mã quảng cáo</th>
                <th>Ngày thành lập</th>
                <th>Ngày kết thúc</th>
                <th>Số tiền</th>
                <th>Nhóm thực hiện</th>
                <th>Khách hàng</th>
                <th>Mô tả</th>
                <th>Loại quảng cáo</th>
            </tr>
            </table>
");
#nullable restore
#line 93 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\QuangCao_KhachHang.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\QuangCao_KhachHang.cshtml"
         
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nhom11.QLQC.Pages.QuangCao_KhachHangModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.QuangCao_KhachHangModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.QuangCao_KhachHangModel>)PageContext?.ViewData;
        public Nhom11.QLQC.Pages.QuangCao_KhachHangModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
