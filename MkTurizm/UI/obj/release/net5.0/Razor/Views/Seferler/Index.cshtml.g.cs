#pragma checksum "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f217d535cd028bb94da10b07d787cd0230ca6005"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seferler_Index), @"mvc.1.0.view", @"/Views/Seferler/Index.cshtml")]
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
#line 1 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f217d535cd028bb94da10b07d787cd0230ca6005", @"/Views/Seferler/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d79ad08d11418ded2b13adb4a9b2619d15bb23", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Seferler_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.BusService>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\Index.cshtml"
  
    ViewData["Title"] = "SeferBilgileri";
    Layout = "~/Views/Shared/Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://d3rh8btizouuof.cloudfront.net/css/cssPmk?v=207\">\r\n<div id=\"fh5co-features\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-12 animate-box"">
                        <div class=""row"" id=""gidisBoxSticky"">
                            <div class=""damper"" style=""box-shadow: rgba(0, 0, 0, 0.48) 0px 0px 5px 0px; position: unset; top: unset; z-index: unset;"">
                                <div class=""col-md-12 gidisbox"" id=""gidis-box"">
                                    <h1 class=""gidisheadh3 colorfff  "">
                                        <span class=""hidden-xs hidden-sm gidishead"">Gidiş </span>
                                        <span class=""hidden-xs hidden-sm"">
                                            <a style=""color:#fff;text-decoration:none !important;"" href=""https://www.pamukkale.com.tr/otobus-bileti/istanbul-esenler/"">");
#nullable restore
#line 19 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\Index.cshtml"
                                                                                                                                                                  Write(item.ToCity.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                        </span>
                                        &nbsp; - &nbsp;
                                        <span class=""hidden-xs hidden-sm"">
                                            <a style=""color:#fff;text-decoration:none !important;"" href=""#"">");
#nullable restore
#line 23 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\Index.cshtml"
                                                                                                       Write(item.FromCity.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                        </span>
                                    </h1>
                                    <button type=""submit"" class=""btn btn-pam mt0 inputseferdegis hidden-xs hidden-sm"" style=""min-width:95px;"" id=""gidisdegisiklik""><b>Sefer Değiştir</b></button>
                                </div>
                                <div class=""row hidden-md hidden-lg"" style=""background: #ddd;  padding: 3px; margin: 0px;"">
                                    <a href=""#"">
                                        <div class=""col-xs-2"" style=""text-align: center;  height: 30px; padding: 5px 0px;""> </div>
                                    </a>
                                </div>
                            </div>
                            <div class=""col-md-12 pd05"">
                                <div class="" row sefer-list-kutu"">
                                    <div class=""col-md-2 col-xs-3 sefer-list-kutu-tarih koltuk-secmobile"" data-firma="""" data-id=""3590892"" da");
            WriteLiteral("ta-tarih=\"2022-05-11 23:00:00\" data-fiyat=\"279\">\r\n                                        <div class=\"sefersaat\" title=\"Sefer Saati 23:00\">");
#nullable restore
#line 37 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\Index.cshtml"
                                                                                     Write(((DateTime)item.Date).ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                        <span class=\"sefertarih  hidden-xs\" data-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 2786, "\"", 2794, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""padding: 0px 3px 2px 0px; font-weight: 500; color: #e20613 !important; background: #d1d1d1;-webkit-border-radius: 3px;-moz-border-radius: 3px;border-radius: 3px;"" data-original-title=""Tahmini Yolculuk Süresi""><i class=""fa fa-clock-o"" aria-hidden=""true"" style=""padding-right: 2px;""></i>");
#nullable restore
#line 38 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\Index.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                          Write(((DateTime)item.Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                    <div class=""col-md-6 col-sm-6 col-xs-6 pd0 koltuk-secmobile"" data-firma="""" data-id=""3590892"" data-tarih=""2022-05-11 23:00:00"" data-fiyat=""279"">
                                        <div class=""col-md-5 col-sm-12 col-xs-12 sefer-list-kutu-model pdb10bilet pdt10bilet text-center mobilmt hidden-xs hidden-sm"" style=""border: none; background-image: url('https://d3rh8btizouuof.cloudfront.net/images/jumbologo5.png'); background-size: cover; min-height: 62px; background-position: center;"">
                                            <div class=""aracmodel pd0"">
                                            </div>
                                        </div>
                                        <div class=""col-md-5 col-sm-12 col-xs-12 sefer-list-kutu-model pdb10bilet pdt10bilet text-center mobilmt hidden-md hidden-lg"" style=""margin-top:0;background: url('https://d3rh8btizouuof.cloudfront.net/images/jumbologo5.png'); min-");
            WriteLiteral(@"height: 45px;background-position-x: center;background-size: cover;"">
                                            <div class=""aracmodel pd0"">
                                            </div>
                                        </div>
                                        <div class=""col-md-7 col-sm-7 col-xs-12 sefer-list-kutu-donanim pdb10bilet pdt10bilet aracdonanim hidden-xs hidden-sm mobilmt img-hover"">
                                            <img src=""https://d3rh8btizouuof.cloudfront.net/images/features/iconnewjumbo/zenginikram.png"" height=""27""");
            BeginWriteAttribute("alt", " alt=\"", 4731, "\"", 4737, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-bottom:3px; margin-right:3px;\" data-original-title=\"Zengin ikram menüsü\" data-html=\"true\" data-toggle=\"tooltip\"><img src=\"https://d3rh8btizouuof.cloudfront.net/images/features/iconnewjumbo/zamankazandirir.png\" height=\"27\"");
            BeginWriteAttribute("alt", " alt=\"", 4974, "\"", 4980, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-bottom:5px; margin-right:3px;\" data-original-title=\"Zaman kazandırır\" data-html=\"true\" data-toggle=\"tooltip\"><img src=\"https://d3rh8btizouuof.cloudfront.net/images/features/iconnewjumbo/geniskoltuk.png\" height=\"27\"");
            BeginWriteAttribute("alt", " alt=\"", 5210, "\"", 5216, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-bottom:5px; margin-right:3px;\" data-original-title=\"Geniş koltuk aralığı\" data-html=\"true\" data-toggle=\"tooltip\"><img src=\"https://d3rh8btizouuof.cloudfront.net/images/features/iconnewjumbo/bebekkoltugu.png\" height=\"27\"");
            BeginWriteAttribute("alt", " alt=\"", 5451, "\"", 5457, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-bottom:5px; margin-right:3px;\" data-original-title=\"Bebek koltuğu\" data-html=\"true\" data-toggle=\"tooltip\"><img src=\"https://d3rh8btizouuof.cloudfront.net/images/features/iconnewjumbo/tv.png\" height=\"27\"");
            BeginWriteAttribute("alt", " alt=\"", 5675, "\"", 5681, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-bottom:5px; margin-right:3px;\" data-original-title=\"Canlı tv\" data-html=\"true\" data-toggle=\"tooltip\"><img src=\"https://d3rh8btizouuof.cloudfront.net/images/features/iconnewjumbo/220priz.png\" height=\"27\"");
            BeginWriteAttribute("alt", " alt=\"", 5899, "\"", 5905, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-bottom:5px; margin-right:3px;\" data-original-title=\"220V priz\" data-html=\"true\" data-toggle=\"tooltip\"><img src=\"https://d3rh8btizouuof.cloudfront.net/images/features/iconnewjumbo/android.png\" height=\"27\"");
            BeginWriteAttribute("alt", " alt=\"", 6124, "\"", 6130, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-bottom:5px; margin-right:3px;\" data-original-title=\"Android ekran\" data-html=\"true\" data-toggle=\"tooltip\"><img src=\"https://d3rh8btizouuof.cloudfront.net/images/features/iconnewjumbo/10incekran.png\" height=\"27\"");
            BeginWriteAttribute("alt", " alt=\"", 6356, "\"", 6362, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-bottom:5px; margin-right:3px;\" data-original-title=\"10 İnç büyük ekran\" data-html=\"true\" data-toggle=\"tooltip\"><img src=\"https://d3rh8btizouuof.cloudfront.net/images/features/iconnewjumbo/wifi.png\" height=\"27\"");
            BeginWriteAttribute("alt", " alt=\"", 6587, "\"", 6593, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""margin-bottom:5px; margin-right:3px;"" data-original-title=""Ücretsiz internet bağlantısı"" data-html=""true"" data-toggle=""tooltip"">
                                        </div>
                                        <div class=""col-md-12 col-xs-12 col-sm-12 pd0 biletaciklama hidden-xs hidden-sm"">
                                            <i style=""color: #ffffff; font-size: 18px; position: absolute; left:15px; top:4px;"" class=""fa fa-angle-double-right "" aria-hidden=""true""></i>
                                            Peron 41-44
                                        </div>
                                    </div>
                                    <div class=""col-md-2 col-xs-3 col-sm-3 internetbilet mobilmt mobilmt2 koltuk-secmobile"" data-firma="""" data-id=""3590892"" data-tarih=""2022-05-11 23:00:00"" data-fiyat=""279"">
                                        <p class=""internetfiyat "" style=""line-height:0.5;font-size: 15px;margin: 0; color:#888; font-weight:normal;"">&nbsp;</p><p class=""in");
            WriteLiteral("ternetfiyat \" style=\"line-height:1.1;\">");
#nullable restore
#line 58 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\Index.cshtml"
                                                                                                                                                                                                             Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<small style=\"font-size: 16px;\"> TL</small></p>\r\n                                    </div>\r\n                                    <div class=\"col-md-2 col-xs-3 col-sm-3 sefersec sefersecdolu hidden-xs hidden-sm\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 7923, "\"", 7966, 2);
            WriteAttributeValue("", 7930, "/Seferler/BiletAl/", 7930, 18, true);
#nullable restore
#line 61 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\Index.cshtml"
WriteAttributeValue("", 7948, item.BusServiceId, 7948, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-pam koltuk-sec\"> SEFER SEÇ</a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 67 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.BusService>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591