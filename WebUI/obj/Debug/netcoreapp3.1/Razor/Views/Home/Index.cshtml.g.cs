#pragma checksum "D:\.NET\Fiorello\WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b701d4754b4699ab93a430e0c2fd81f1f09cb06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\.NET\Fiorello\WebUI\Views\Home\Index.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.NET\Fiorello\WebUI\Views\Home\Index.cshtml"
using WebUI.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b701d4754b4699ab93a430e0c2fd81f1f09cb06", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("sign"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\.NET\Fiorello\WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>

      <!-- SLIDER START -->

      <section class=""flowers-slider"">
        <div
          id=""carouselExampleDark""
          class=""carousel carousel-dark slide""
          data-bs-ride=""carousel""
        >
          <div class=""carousel-indicators"">
            <button
              type=""button""
              data-bs-target=""#carouselExampleDark""
              data-bs-slide-to=""0""
              class=""active""
              aria-current=""true""
              aria-label=""Slide 1""
            ></button>
            <button
              type=""button""
              data-bs-target=""#carouselExampleDark""
              data-bs-slide-to=""1""
              aria-label=""Slide 2""
            ></button>
            <button
              type=""button""
              data-bs-target=""#carouselExampleDark""
              data-bs-slide-to=""2""
              aria-label=""Slide 3""
            ></button>
          </div>
          <div class=""carousel-inner"">
");
#nullable restore
#line 41 "D:\.NET\Fiorello\WebUI\Views\Home\Index.cshtml"
                     for(int i=0;i<Model.Sliders.Count;i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 1203, "\"", 1250, 2);
            WriteAttributeValue("", 1211, "carousel-item", 1211, 13, true);
#nullable restore
#line 43 "D:\.NET\Fiorello\WebUI\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1224, i == 0 ? "active" : "", 1225, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bs-interval=\"5000\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8b701d4754b4699ab93a430e0c2fd81f1f09cb065799", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1337, "~/images/flower-slider/", 1337, 23, true);
#nullable restore
#line 45 "D:\.NET\Fiorello\WebUI\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1360, Model.Sliders[i].Url, 1360, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                       <div class=\"carousel-caption d-none d-md-block\">\r\n                        ");
#nullable restore
#line 51 "D:\.NET\Fiorello\WebUI\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.Summary.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <p>\r\n                          ");
#nullable restore
#line 53 "D:\.NET\Fiorello\WebUI\Views\Home\Index.cshtml"
                     Write(Model.Summary.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <h2>\r\n                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8b701d4754b4699ab93a430e0c2fd81f1f09cb068128", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1832, "~/images/flower-slider/", 1832, 23, true);
#nullable restore
#line 57 "D:\.NET\Fiorello\WebUI\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1855, Model.Summary.Sign, 1855, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </h2>\r\n                      </div>\r\n                    </div>\r\n");
#nullable restore
#line 63 "D:\.NET\Fiorello\WebUI\Views\Home\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            
            
          </div>
          <button
            class=""carousel-control-prev""
            type=""button""
            data-bs-target=""#carouselExampleDark""
            data-bs-slide=""prev""
          >
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""visually-hidden"">Previous</span>
          </button>
          <button
            class=""carousel-control-next""
            type=""button""
            data-bs-target=""#carouselExampleDark""
            data-bs-slide=""next""
          >
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""visually-hidden"">Next</span>
          </button>
        </div>
      </section>

      <!-- SLIDER END -->

      <!-- FLOWER-ITEMS START -->

      <section class=""flowers"">
        <div class=""container"">
          <div class=""row"">
            <div class=""filter"">
              <ul class=""filter-left col-6"">
         ");
            WriteLiteral(@"       <li data-filter=""*"">ALL</li>
                <li data-filter="".cactuses"">CACTUSES</li>
                <li data-filter="".exotic"">EXOTIC</li>
                <li data-filter="".greens"">GREENS</li>
                <li data-filter="".popular"">POPULAR</li>
                <li data-filter="".various"">VARIOUS</li>
                <li data-filter="".winter"">WINTER</li>
              </ul>

              <div class=""filter-right col-6"">
                <div class=""filter-dropdown"">
                  <a href=""#"">FILTER <i class=""fa-solid fa-caret-down""></i></a>
                  <div class=""filter-dropdown-content"">
                    <div class=""row"">
                      <div class=""sort-by col-6"">
                        <span>Sort By</span>
                          <a href=""#"">Default</a>
                          <a href=""#"">Popularity</a>
                          <a href=""#"">Newness</a>
                          <a href=""#"">Price:Low to High</a>
                          <a href=""#"">Pr");
            WriteLiteral(@"ice:High to Low</a>
                      </div>
                      <div class=""price-range col-6"">
                        <span>Price Range</span>
                          <a href=""#"">All</a>
                          <a href=""#"">$0-10$</a>
                          <a href=""#"">10$-20$</a>
                          <a href=""#"">20$-30$</a>
                          <a href=""#"">30$-40$</a>
                          <a href=""#"">40$+</a>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div class=""row"">
            <div class=""flower-cards"">
              <div class=""card-item col-3"">
                <div class=""inner-card cactuses"" data-id=""1"">
                  <div class=""card-image"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-14-img.jpg"" alt=""card image"">
                  </div>
                  <div cl");
            WriteLiteral(@"ass=""card-title"">
                    <p>Majesty Palm</p>
                  </div>
                  <div class=""add-to-card"">
                   <a href=""#"">Add to Card</a>
                   <a href=""#"">$259</a>
                  </div>
                </div>
              </div>
              <div class=""card-item col-3"">
                <div class=""inner-card popular exotic"" data-id=""2"">
                  <div class=""card-image"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-13-img.jpg"" alt=""card image"">
                  </div>
                  <div class=""card-title"">
                    <p>FoxGlove Flower</p>
                  </div>
                  <div class=""add-to-card"">
                   <a href=""#"">Add to Card</a>
                   <a href=""#"">$233</a>
                  </div>
                </div>
              </div>
              <div class=""card-item col-3"">
                <div class=""inner-card various cactus");
            WriteLiteral(@"es"" data-id=""3"">
                  <div class=""card-image"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/shop-10-img.jpg"" alt=""card image"">
                  </div>
                  <div class=""card-title"">
                    <p>Sweet Alyssum</p>
                  </div>
                  <div class=""add-to-card"">
                   <a href=""#"">Add to Card</a>
                   <a href=""#"">$299</a>
                  </div>
                </div>
              </div>
              <div class=""card-item col-3"">
                <div class=""inner-card exotic"" data-id=""4"">
                  <div class=""card-image"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-11-img.jpg"" alt=""card image"">
                  </div>
                  <div class=""card-title"">
                    <p>Spring Snowflake</p>
                  </div>
                  <div class=""add-to-card"">
                   <a ");
            WriteLiteral(@"href=""#"">Add to Card</a>
                   <a href=""#"">$159</a>
                  </div>
                </div>
              </div>
              <div class=""card-item col-3"">
                <div class=""inner-card popular"" data-id=""5"">
                  <div class=""card-image"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-12-img.jpg"" alt=""card image"">
                  </div>
                  <div class=""card-title"">
                    <p>Scarlet Sage</p>
                  </div>
                  <div class=""add-to-card"">
                   <a href=""#"">Add to Card</a>
                   <a href=""#"">$264</a>
                  </div>
                </div>
              </div>
              <div class=""card-item col-3"">
                <div class=""inner-card winter cactuses"" data-id=""6"">
                  <div class=""card-image"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-9-i");
            WriteLiteral(@"mg.jpg"" alt=""card image"">
                  </div>
                  <div class=""card-title"">
                    <p>Rock Soapwort</p>
                  </div>
                  <div class=""add-to-card"">
                   <a href=""#"">Add to Card</a>
                   <a href=""#"">$428</a>
                  </div>
                </div>
              </div>
              <div class=""card-item col-3"">
                <div class=""inner-card greens winter"" data-id=""7"">
                  <div class=""card-image"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-8-img.jpg"" alt=""card image"">
                  </div>
                  <div class=""card-title"">
                    <p>Summer Savory</p>
                  </div>
                  <div class=""add-to-card"">
                   <a href=""#"">Add to Card</a>
                   <a href=""#"">$156</a>
                  </div>
                </div>
              </div>
              <div clas");
            WriteLiteral(@"s=""card-item col-3"" >
                <div class=""inner-card greens"" data-id=""8"">
                  <div class=""card-image"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-7-img.jpg"" alt=""card image"">
                  </div>
                  <div class=""card-title"">
                    <p>Wild Roses</p>
                  </div>
                  <div class=""add-to-card"">
                   <a href=""#"">Add to Card</a>
                   <a href=""#"">$309</a>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>

      <!-- FLOWER-ITEMS END -->
      
    </main>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
