#pragma checksum "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "373e11e1b343e0687ef049741a602dc5015a7c2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Nhom11.QLQC.Pages.Pages_NhomNhanVien), @"mvc.1.0.razor-page", @"/Pages/NhomNhanVien.cshtml")]
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
#line 2 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
using global::QLQC.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
using Microsoft.AspNetCore.Antiforgery;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"373e11e1b343e0687ef049741a602dc5015a7c2a", @"/Pages/NhomNhanVien.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b39bf525f09de2fceaa200944ecf09c0e81b8ae", @"/Pages/_ViewImports.cshtml")]
    public class Pages_NhomNhanVien : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#nullable restore
#line 7 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
  
    var token = antiforgery.GetAndStoreTokens(HttpContext).RequestToken;

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n    var dataNNv = ");
#nullable restore
#line 14 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
             Write(Html.Raw(JsonSerializer.Serialize(Model.lst)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "373e11e1b343e0687ef049741a602dc5015a7c2a5087", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-2 form-group"">
            <label>      Mã nhóm :    </label>
            <input type=""text"" id=""mn"" name=""mn"" class=""form-control"" />
        </div>
        <div class=""col-2 form-group"">
            <label>Tên nhóm : </label>
            <input type=""text"" id=""tn"" name=""tn"" class=""form-control"" />
        </div>
        <div class=""col-2 form-group"">
            <label>Mã nhóm trưởng : </label>
            <input type=""text"" id=""mnt"" name=""mnt"" class=""form-control"" />
        </div>
        <div class=""col-2 form-group"">
            <br />
            <input style=""margin-top: 5px; margin-left: 70px"" type=""submit"" class=""btn btn-primary"" value=""Tìm kiếm"" />
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
            WriteLiteral("\r\n<br />\r\n<div class=\"text-center\">\r\n    <h2><b>Danh sách nhóm nhân viên</b></h2>\r\n</div>\r\n\r\n<div>\r\n    <button type=\"button\" onclick=\"openModalNNV(null);\" class=\"btn btn-outline-success\"> Thêm mới</button>\r\n</div>\r\n\r\n");
#nullable restore
#line 45 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
 if (Request.Method.ToUpper() == "GET")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table id=\"tbNNV\" class=\"table table-success table-condensed\">\r\n        <tr>\r\n            <th>Mã nhóm</th>\r\n            <th>Tên nhóm</th>\r\n            <th>Mã nhóm trưởng</th>\r\n        </tr>\r\n");
#nullable restore
#line 53 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
         foreach (NhomNhanVienDTO nnv in Model.lst)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 1702, "\"", 1724, 2);
            WriteAttributeValue("", 1707, "trNNv_", 1707, 6, true);
#nullable restore
#line 55 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
WriteAttributeValue("", 1713, nnv.MaNhom, 1713, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-align:center\">\r\n                <td>");
#nullable restore
#line 56 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
               Write(nnv.MaNhom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 57 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
               Write(nnv.TenNhom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 58 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
               Write(nnv.MaNT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>\r\n                    <button style=\"margin-bottom:5px\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1958, "\"", 1996, 3);
            WriteAttributeValue("", 1968, "openModalNNV(\'", 1968, 14, true);
#nullable restore
#line 61 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
WriteAttributeValue("", 1982, nnv.MaNhom, 1982, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1993, "\');", 1993, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Sửa</button>\r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2085, "\"", 2129, 3);
            WriteAttributeValue("", 2095, "deleteNhomNhanVien(\'", 2095, 20, true);
#nullable restore
#line 62 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
WriteAttributeValue("", 2115, nnv.MaNhom, 2115, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2126, "\');", 2126, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Xoá</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 65 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 67 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
}
else if (Request.Method.ToUpper() == "POST")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table id=\"tbNNV\" class=\"table table-success table-condensed\">\r\n        <tr>\r\n            <th>Mã nhóm</th>\r\n            <th>Tên nhóm</th>\r\n            <th>Mã nhóm trưởng</th>\r\n        </tr>\r\n");
#nullable restore
#line 76 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
         foreach (NhomNhanVienDTO nnv in Model.lst)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 2569, "\"", 2591, 2);
            WriteAttributeValue("", 2574, "trNNv_", 2574, 6, true);
#nullable restore
#line 78 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
WriteAttributeValue("", 2580, nnv.MaNhom, 2580, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-align:center\">\r\n                <td>");
#nullable restore
#line 79 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
               Write(nnv.MaNhom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 80 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
               Write(nnv.TenNhom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 81 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
               Write(nnv.MaNT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n\r\n                    <button style=\"margin-bottom:5px\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2825, "\"", 2863, 3);
            WriteAttributeValue("", 2835, "openModalNNV(\'", 2835, 14, true);
#nullable restore
#line 84 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
WriteAttributeValue("", 2849, nnv.MaNhom, 2849, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2860, "\');", 2860, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Sửa</button>\r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2952, "\"", 2996, 3);
            WriteAttributeValue("", 2962, "deleteNhomNhanVien(\'", 2962, 20, true);
#nullable restore
#line 85 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
WriteAttributeValue("", 2982, nnv.MaNhom, 2982, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2993, "\');", 2993, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Xoá</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 88 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 90 "C:\Users\ngoca\OneDrive\Desktop\QLQC.Nhom11\Nhom11.QLQC\Pages\NhomNhanVien.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""divModalNNV"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title""> Nhóm nhân viên - <span id=""spanIdNNv""></span></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""form-group"">
                    <label for=""txtMaNhom"">Mã nhóm</label>
                    <input type=""text"" class=""form-control"" id=""txtMaNhom"" aria-describedby=""MaNhomHelp"">
                    <small id=""MaNhomHelp"" class=""form-text text-muted"">Mã nhóm không được trống !</small>
                </div>
                <div class=""form-group"">
                    <label for=""txtTenNhom"">Tên nhóm</label>
                    <input type=""text"" class");
            WriteLiteral(@"=""form-control"" id=""txtTenNhom"" aria-describedby=""TenNhomHelp"">
                    <small id=""TenNhomHelp"" class=""form-text text-muted"">Tên nhóm nhân viên không được trống !</small>
                </div>
                <div class=""form-group"">
                    <label for=""txtMaNT"">Mã nhóm trưởng</label>
                    <input type=""text"" class=""form-control"" id=""txtMaNT"" aria-describedby=""MaNTHelp"">
                    <small id=""MaNTHelp"" class=""form-text text-muted"">Mã nhóm trưởng không được trống !</small>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" onclick=""saveNhomNhanVien();"" class=""btn btn-primary"">Lưu</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Thoát</button>
            </div>
        </div>
    </div>
</div>


");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAntiforgery antiforgery { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nhom11.QLQC.Pages.NhomNhanVienModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.NhomNhanVienModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.NhomNhanVienModel>)PageContext?.ViewData;
        public Nhom11.QLQC.Pages.NhomNhanVienModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
