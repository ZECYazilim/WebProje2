#pragma checksum "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Urun\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83eba11ba32fd1887731d6db1b0dc223f0c2614c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Urun_Index), @"mvc.1.0.view", @"/Views/Urun/Index.cshtml")]
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
#line 1 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\_ViewImports.cshtml"
using WebProje2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\_ViewImports.cshtml"
using WebProje2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Urun\Index.cshtml"
using WebProje2.Models.Siniflar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83eba11ba32fd1887731d6db1b0dc223f0c2614c", @"/Views/Urun/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cfcda52b9d8b9a8ea934f78be13e53636c84d87", @"/Views/_ViewImports.cshtml")]
    public class Views_Urun_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Urun>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Urun\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<h2>Ürünlerimiz</h2>\r\n<br />\r\n");
#nullable restore
#line 11 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Urun\Index.cshtml"
 using (Html.BeginForm("Index", "Urun", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Ürün Adı : ");
#nullable restore
#line 14 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Urun\Index.cshtml"
              Write(Html.TextBox("search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Ara\" />\r\n    </p>\r\n");
#nullable restore
#line 17 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Urun\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-bordered"">
    <tr>
        <th>Ürün ID</th>
        <th>Ürün Adı</th>
        <th>Ürün Markası</th>
        <th>Stok Sayısı</th>
        <th>Alış Fiyatı</th>
        <th>Satış Fiyatı</th>
        <th>Kategori</th>
        <th>Ürün Görseli</th>
        <th>Ürünü Sil</th>
        <th>Ürünü Güncelle</th>
        <th>Satış Yap</th>
    </tr>
");
#nullable restore
#line 32 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Urun\Index.cshtml"
     foreach (var urun in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 35 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Urun\Index.cshtml"
   Write(urun.UrunID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 36 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Urun\Index.cshtml"
   Write(urun.UrunAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 37 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Urun\Index.cshtml"
   Write(urun.Marka);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 38 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Urun\Index.cshtml"
   Write(urun.Stok);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 39 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Urun\Index.cshtml"
   Write(urun.AlisFiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n    <td>");
#nullable restore
#line 40 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Urun\Index.cshtml"
   Write(urun.SatisFiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n    <td>");
#nullable restore
#line 41 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Urun\Index.cshtml"
   Write(urun.Kategori.KategoriAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><img");
            BeginWriteAttribute("src", " src=\"", 1003, "\"", 1025, 1);
#nullable restore
#line 42 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Urun\Index.cshtml"
WriteAttributeValue("", 1009, urun.UrunGorsel, 1009, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px;height:100px;\" /></td>\r\n    <td>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1090, "\"", 1123, 2);
            WriteAttributeValue("", 1097, "/Urun/UrunSil/", 1097, 14, true);
#nullable restore
#line 44 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Urun\Index.cshtml"
WriteAttributeValue("", 1111, urun.UrunID, 1111, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a>\r\n    </td>\r\n    <td>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1188, "\"", 1223, 2);
            WriteAttributeValue("", 1195, "/Urun/UrunGetir/", 1195, 16, true);
#nullable restore
#line 47 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Urun\Index.cshtml"
WriteAttributeValue("", 1211, urun.UrunID, 1211, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Güncelle</a>\r\n    </td>\r\n    <td>\r\n        <a href=\"/Satis/YeniSatis\" class=\"btn btn-success\">Satış Yap</a>\r\n    </td>\r\n</tr>\r\n");
#nullable restore
#line 53 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Urun\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Urun/YeniUrun/\" class=\"btn btn-info\">Yeni Ürün</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Urun>> Html { get; private set; }
    }
}
#pragma warning restore 1591
