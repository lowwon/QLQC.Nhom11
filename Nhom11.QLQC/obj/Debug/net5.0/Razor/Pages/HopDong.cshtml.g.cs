#pragma checksum "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea256364168b8338f77cbd4584a52442497a49d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Nhom11.QLQC.Pages.Pages_HopDong), @"mvc.1.0.razor-page", @"/Pages/HopDong.cshtml")]
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
#line 2 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
using global::QLQC.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea256364168b8338f77cbd4584a52442497a49d7", @"/Pages/HopDong.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b39bf525f09de2fceaa200944ecf09c0e81b8ae", @"/Pages/_ViewImports.cshtml")]
    public class Pages_HopDong : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("<script>\r\n    var dataHd = ");
#nullable restore
#line 8 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
            Write(Html.Raw(JsonSerializer.Serialize(Model.lst)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea256364168b8338f77cbd4584a52442497a49d74272", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-2 form-group"">
            <label>Mã hợp đồng:</label>
            <input type=""text"" id=""mhd"" name=""mhd"" class=""form-control"" />
        </div>
        <div class=""col-3 form-group"">
            <label>Mã nhân viên thực hiện: </label>
            <input type=""text"" id=""mnv"" name=""mnv"" class=""form-control"" />
        </div>
        <div class=""col-2 form-group"">
            <label>Mã khách hàng: </label>
            <input type=""text"" id=""mkh"" name=""mkh"" class=""form-control"" />
        </div>
        <div class=""col-1 form-group"">
            <br />
            <input style=""margin-top: 5px; margin-left: -25px"" type=""submit"" class=""btn btn-primary"" value=""Tìm kiếm"" />
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
            WriteLiteral(@"
<br />
<div class=""text-center"">
    <h2 style=""display: inline-block""><b>Danh sách Hợp đồng</b></h2>
    <input style=""float: right"" onclick=""openHopDong(null)"" type=""button"" class=""btn btn-outline-success"" value=""Thêm mới"" />
    <div style=""text-align:left"" id=""divModalAdd"" class=""modal"" tabindex=""-1"" role=""dialog"">
        <div class=""modal-dialog modal-lg"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Hợp đồng - <span id=""spanidA""></span></h5>
                    <button type=""button"" class=""btn-close"" data-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label for=""txtmhd"">Mã hợp đồng</label>
                        <input type=""text"" class=""form-control"" id=""txtmhdA"" aria-describedby=""Help"" placeholder=""Nhập mã hợp đồng"">
                    </div>
            ");
            WriteLiteral(@"        <div class=""form-group"">
                        <label for=""txtmnk"">Ngày ký </label>
                        <input type=""datetime-local"" class=""form-control"" id=""txtnkA"" />
                    </div>
                    <div class=""form-group"">
                        <label>Mã nhân viên</label>
                        <input type=""text"" class=""form-control"" id=""txtmnvA"" />
                    </div>
                    <div class=""form-group"">
                        <label>Mã khách hàng</label>
                        <input type=""text"" class=""form-control"" id=""txtmkhA"" />
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                        <button type=""button"" onclick=""addHopDong()"" class=""btn btn-outline-success"">Add</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
#nullable restore
#line 67 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
 if (Request.Method.ToUpper() == "GET")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-success table-condensed"">
        <tr>
            <th>Mã hợp đồng</th>
            <th>Ngày ký kết</th>
            <th>Mã nhân viên thực hiện</th>
            <th>Mã đối tác</th>
            <th>Tác vụ</th>
        </tr>
");
#nullable restore
#line 77 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
         foreach (HopDongDTO hd in Model.lst)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr id=\"trHd@hd.MaHd\" style=\"text-align:center\">\r\n                <th>");
#nullable restore
#line 80 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
               Write(hd.MaHD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 81 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
               Write(hd.NgayKy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 82 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
               Write(hd.MaNV);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 83 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
               Write(hd.MaKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>\r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3651, "\"", 3685, 3);
            WriteAttributeValue("", 3661, "openHopDong(\'", 3661, 13, true);
#nullable restore
#line 85 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
WriteAttributeValue("", 3674, hd.MaHD, 3674, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3682, "\');", 3682, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-secondary btn-sm\">Sửa</button>\r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3783, "\"", 3826, 3);
            WriteAttributeValue("", 3793, "deleteHopDong(\'", 3793, 15, true);
#nullable restore
#line 86 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
WriteAttributeValue("", 3808, hd.MaHD.Trim(), 3808, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3823, "\';)", 3823, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger btn-sm\">Xóa</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 89 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 91 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
}

else if (Request.Method.ToUpper() == "POST")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-success table-condensed"">
        <tr>
            <th>Mã hợp đồng</th>
            <th>Ngày ký kết</th>
            <th>Mã nhân viên thực hiện</th>
            <th>Mã đối tác</th>
            <th>Tác vụ</th>
        </tr>
");
#nullable restore
#line 103 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
         foreach (HopDongDTO hd in Model.lst)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"text-align:center\">\r\n                <th>");
#nullable restore
#line 106 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
               Write(hd.MaHD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 107 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
               Write(hd.NgayKy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 108 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
               Write(hd.MaNV);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 109 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
               Write(hd.MaKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>\r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4569, "\"", 4602, 3);
            WriteAttributeValue("", 4579, "openHopDong(\'", 4579, 13, true);
#nullable restore
#line 111 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
WriteAttributeValue("", 4592, hd.MaHD, 4592, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4600, "\')", 4600, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-secondary btn-sm\">Sửa</button>\r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4700, "\"", 4742, 3);
            WriteAttributeValue("", 4710, "deleteHopDong(\'", 4710, 15, true);
#nullable restore
#line 112 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
WriteAttributeValue("", 4725, hd.MaHD.Trim(), 4725, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4740, "\')", 4740, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger btn-sm\">Xóa</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 115 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 117 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""text-align:left"" id=""divModal"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Hợp đồng - <span id=""spanid""></span></h5>
                <button type=""button"" class=""btn-close"" data-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <div class=""form-group"">
                    <label for=""txtmhd"">Mã hợp đồng</label>
                    <input type=""text"" class=""form-control"" id=""txtmhd"" aria-describedby=""Help"" placeholder=""Nhập mã hợp đồng"">
                </div>
                <div class=""form-group"">
                    <label for=""txtnk"">Ngày ký </label>
                    <input type=""datetime-local"" class=""form-control"" id=""txtnk"" />
                </div>
                <div class=""form-group"">
                    <label>Mã nhân viên</label>
");
            WriteLiteral(@"                    <input type=""text"" class=""form-control"" id=""txtmnv"" />
                </div>
                <div class=""form-group"">
                    <label>Khách hàng</label>
                    <input type=""text"" class=""form-control"" id=""txtmkh"" />
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" onclick=""saveHopDong()"" class=""btn btn-primary"">Save changes</button>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nhom11.QLQC.Pages.HopDongModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.HopDongModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.HopDongModel>)PageContext?.ViewData;
        public Nhom11.QLQC.Pages.HopDongModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
