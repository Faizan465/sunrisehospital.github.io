#pragma checksum "C:\Users\faizan\sunrisehospital\Views\FAQ\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "787d71bfaf9112287c083d7526d7f7ba421a2c34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FAQ_Index), @"mvc.1.0.view", @"/Views/FAQ/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FAQ/Index.cshtml", typeof(AspNetCore.Views_FAQ_Index))]
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
#line 1 "C:\Users\faizan\sunrisehospital\Views\_ViewImports.cshtml"
using sunrisehospital;

#line default
#line hidden
#line 2 "C:\Users\faizan\sunrisehospital\Views\_ViewImports.cshtml"
using sunrisehospital.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"787d71bfaf9112287c083d7526d7f7ba421a2c34", @"/Views/FAQ/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f5067512f89a531aa0bb340d7e9039d052836b9", @"/Views/_ViewImports.cshtml")]
    public class Views_FAQ_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-Controller", "Services", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-Action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-Controller", "OurDoctor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-blue blue-hover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 316, true);
            WriteLiteral(@"<div id=""breadcrumb"" class=""division"">
				<div class=""container"">
					<div class=""row"">						
						<div class=""col"">
							<div class="" breadcrumb-holder"">

								<!-- Breadcrumb Nav -->
								<nav aria-label=""breadcrumb"">
								  	<ol class=""breadcrumb"">
								    	<li class=""breadcrumb-item"">");
            EndContext();
            BeginContext(316, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0acce08b8e042d1aab684af146f7bcf", async() => {
                BeginContext(365, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(373, 10738, true);
            WriteLiteral(@"</li>
								    	<li class=""breadcrumb-item active"" aria-current=""page"">FAQs</li>
								  	</ol>
								</nav>

								<!-- Title -->
								<h4 class=""h4-sm steelblue-color"">FAQs</h4>

							</div>
						</div>
					</div>  <!-- End row -->	
				</div>	<!-- End container -->		
			</div>	<!-- END BREADCRUMB -->	




			<!-- FAQs PAGE
			============================================= -->
			<section id=""faqs-page"" class=""wide-80 faqs-section division"">
				<div class=""container"">
					<div class=""row"">


						<!-- QUESTIONS HOLDER -->
				 		<div class=""col-lg-8"">
				 			<div class=""questions-holder pr-30"">

				 				<!-- Title -->
				 				<h3 class=""h3-md steelblue-color"">Frequently Asked Questions</h3>

				 				<!-- Text -->
							

								<!-- QUESTIONS ACCORDION -->	
								<div id=""accordion"" role=""tablist"">


									<!-- CATEGORY TITLE  -->	
									<h5 class=""h5-xl blue-color"">1. General Questions</h5>


									<!-- ACCORDION CARD #1 -->
				");
            WriteLiteral(@" 					<div class=""card"">

				 						<!-- Card Title -->
									    <div class=""card-header"" role=""tab"" id=""headingOne"">
									      	<h5 class=""h5-xs"">
									       		<a data-toggle=""collapse"" href=""#collapseOne"" role=""button"" aria-expanded=""true"" aria-controls=""collapseOne"">
									         		How can I contact a patient in the Intensive Care Unit?
									        	</a>
									    	 </h5>
									    </div>

									    <!-- Card Content -->
									    <div id=""collapseOne"" class=""collapse show"" role=""tabpanel"" aria-labelledby=""headingOne"" data-parent=""#accordion"">
									     	<div class=""card-body"">
		
												<!-- Text -->	
												<p>Intensive Care Unit patients have no phones in their rooms. Intensive Care Unit nurses will relay information to immediate family members only.
												</p>

									     	</div>
									   	</div>

									</div>	<!-- END ACCORDION CARD #1 -->


									<!-- ACCORDION CARD #2 -->
									<div class=""card"">

			");
            WriteLiteral(@"							<!-- Card Title -->
									    <div class=""card-header"" role=""tab"" id=""headingTwo"">
									      	<h5 class=""h5-xs"">
									       	    <a class=""collapsed"" data-toggle=""collapse"" href=""#collapseTwo"" role=""button"" aria-expanded=""false"" aria-controls=""collapseTwo"">
									          		What are the different medical specialties the hospital has to offer?
									        	</a>
									     	 </h5>
									    </div>

									    <!-- Card Content -->
									    <div id=""collapseTwo"" class=""collapse"" role=""tabpanel"" aria-labelledby=""headingTwo"" data-parent=""#accordion"">
									      	<div class=""card-body"">

									      		<p>Kindly refer to the section under various specialties offered by the hospital as displayed on the website.
												</p>
									        
									     	 </div>
									    </div>

									</div>	<!-- END ACCORDION CARD #2 -->


									<!-- ACCORDION CARD #3 -->
									<div class=""card"">

									 	<!-- Card Title -->
									    ");
            WriteLiteral(@"<div class=""card-header"" role=""tab"" id=""headingThree"">
									      	<h5 class=""h5-xs"">
									        	<a class=""collapsed"" data-toggle=""collapse"" href=""#collapseThree"" role=""button"" aria-expanded=""false"" aria-controls=""collapseThree"">
									         		What other services are available to patients while at Sunrise?
									        	</a>
									     	 </h5>
									    </div>

									    <!-- Card Content -->
									    <div id=""collapseThree"" class=""collapse"" role=""tabpanel"" aria-labelledby=""headingThree"" data-parent=""#accordion"">
									      	<div class=""card-body"">
									        
									      		<!-- Text -->	
												<p>Patients may park their personal vehicles on hospital grounds, but must register them through Security Services. Parking is free and available in the parking lot. Patients and their families are asked to observe parking restrictions, which are clearly marked. Illegally parked vehicles will be towed at the owner's expense.
												</p>
										");
            WriteLiteral(@"					
												<!-- List -->
												<ul class=""content-list"">
															
													<li>
														<p>Public restrooms are located  Front  building.
														</p>
													</li>

												

												</ul>

									      	</div>
									    </div>

									</div>	  <!-- END ACCORDION CARD #3 -->


									<!-- ACCORDION CARD #4 -->
									 <!-- END ACCORDION CARD #4 -->


									<!-- CATEGORY TITLE  -->	
									<h5 class=""h5-xl blue-color"">2. Medical Treatment Questions</h5>


									<!-- ACCORDION CARD #5 -->
									<div class=""card"">

									 	<!-- Card Title -->
									    <div class=""card-header"" role=""tab"" id=""headingFive"">
									      	<h5 class=""h5-xs"">
									        	<a data-toggle=""collapse"" href=""#collapseFive"" role=""button"" aria-expanded=""false"" aria-controls=""collapseFive"">
									         	Who will guide me during the process of my treatment?
									        	</a>
									     	 </h5>
									    </");
            WriteLiteral(@"div>

									    <!-- Card Content -->
									    <div id=""collapseFive"" class=""collapse"" role=""tabpanel"" aria-labelledby=""headingFive"" data-parent=""#accordion"">
									      	<div class=""card-body"">
									        
												<!-- Text -->   
												<p> Not just the medical physicians but each and every person involved with Sunrise Hospital is there to guide you in the best possible way. Sunrise Hospital teams a dedicated set of medical physicians and paramedical staff right at the quality service of our patients. Not only this, but we are also equipped with the finest machineries and technology that is beneficial and essential for the patient care.
												</p>

									      	</div>
									    </div>

									</div>	  <!-- END ACCORDION CARD #5 -->


									<!-- ACCORDION CARD #6 -->
									<div class=""card"">

									 	<!-- Card Title -->
									    <div class=""card-header"" role=""tab"" id=""headingSix"">
									      	<h5 class=""h5-xs"">
									        	<");
            WriteLiteral(@"a class=""collapsed"" data-toggle=""collapse"" href=""#collapseSix"" role=""button"" aria-expanded=""false"" aria-controls=""collapseSix"">
									         		In what ways Sunrise maintains the quality parameters in healthcare?
									        	</a>
									     	 </h5>
									    </div>

									    <!-- Card Content -->
									    <div id=""collapseSix"" class=""collapse"" role=""tabpanel"" aria-labelledby=""headingSix"" data-parent=""#accordion"">
									      	<div class=""card-body"">
									        
												<!-- Text -->   
												<p> When it comes to quality, we take it as a necessity than just an option! Maintaining quality in equipment, professionals, facilities, costs and ethics is a healthy concern for Indus. Indus hospitals have dedicated staff for facilitating quality management requirements in the hospital premise.
												</p>

									      	</div>
									    </div>

									</div>	  <!-- END ACCORDION CARD #6 -->


									<!-- ACCORDION CARD #7 -->
				 					

		");
            WriteLiteral(@"							<!-- ACCORDION CARD #8 -->
										<!-- END ACCORDION CARD #8 -->


									<!-- ACCORDION CARD #9 -->
									


									<!-- CATEGORY TITLE  -->	
									<h5 class=""h5-xl blue-color"">3. Emergency Help Questions</h5>


									<!-- ACCORDION CARD #10 -->
									<div class=""card"">

									 	<!-- Card Title -->
									    <div class=""card-header"" role=""tab"" id=""headingTen"">
									      	<h5 class=""h5-xs"">
									        	<a data-toggle=""collapse"" href=""#collapseTen"" role=""button"" aria-expanded=""false"" aria-controls=""collapseTen"">
									         		What procedures will I have in the Emergency Department?
									        	</a>
									     	 </h5>
									    </div>

									    <!-- Card Content -->
									    <div id=""collapseTen"" class=""collapse"" role=""tabpanel"" aria-labelledby=""headingTen"" data-parent=""#accordion"">
									      	<div class=""card-body"">
									        
									      		<!-- Text -->														
												<p>Treatments and p");
            WriteLiteral(@"rocedures may include lab work, radiological studies, CAT scans, ultrasound, EKG for cardiac review, medication administration and physician evaluations.
												</p>

									      	</div>
									    </div>

									</div>	  <!-- END ACCORDION CARD #10 -->


									<!-- ACCORDION CARD #11 -->
									

									<!-- ACCORDION CARD #12 -->
									<div class=""card no-border"">

									 	<!-- Card Title -->
									    <div class=""card-header"" role=""tab"" id=""headingTwelve"">
									      	<h5 class=""h5-xs"">
									        	<a class=""collapsed"" data-toggle=""collapse"" href=""#collapseTwelve"" role=""button"" aria-expanded=""false"" aria-controls=""collapseTwelve"">
									         	How is the Emergency Department staffed?
									        	</a>
									     	 </h5>
									    </div>

									    <!-- Card Content -->
									    <div id=""collapseTwelve"" class=""collapse"" role=""tabpanel"" aria-labelledby=""headingTwelve"" data-parent=""#accordion"">
									      	<div class=""");
            WriteLiteral(@"card-body"">
									        
									      		<!-- Text -->
												<p>The department is staffed with emergency medicine physicians and nurses, physician assistants, technicians, CNAs and unit coordinators along with specialists from the laboratory, cardiology, respiratory and radiology departments. 
												</p>   
												  
												<!-- Text -->   
												

									      	</div>
									    </div>

									</div>	  <!-- END ACCORDION CARD #12 -->


								</div>	<!-- END QUESTIONS ACCORDION -->	


				 			</div>
				 		</div>   <!--END QUESTIONS HOLDER -->


				 		<!-- SIDEBAR -->
						<aside id=""sidebar"" class=""col-lg-4"">


							<!-- TEXT WIDGET -->						
							<div id=""txt-widget"" class=""sidebar-div mb-50"">
										
								<!-- Title -->
								<h5 class=""h5-sm steelblue-color"">Sunrise Hospital</h5>

								<!-- Head of Clinic -->
								<div class=""txt-widget-unit mb-15 clearfix d-flex align-items-center"">
								
									<!-- Ava");
            WriteLiteral(@"tar -->
									<div class=""txt-widget-avatar"">
										<img src=""images/head-of-clinic.jpg"" alt=""testimonial-avatar"">
									</div>

									<!-- Data -->
									<div class=""txt-widget-data"">
										<h5 class=""h5-md steelblue-color"">Dr. Abhinav Katiyar</h5>	
										<span>Director</span>	
										<p class=""blue-color"">+91 </p>	
									</div>

								</div>	<!-- End Head of Clinic -->	
								
								<!-- Text -->
								

								<!-- Button -->
								");
            EndContext();
            BeginContext(11111, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58c398abfd9c425b8f88a69b6b2b5f68", async() => {
                BeginContext(11193, 10, true);
                WriteLiteral("Learn More");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11207, 1364, true);
            WriteLiteral(@"
																		
							</div>	<!-- END TEXT WIDGET -->

								
							<!-- SIDEBAR TABLE -->
							<div class=""sidebar-table blue-table sidebar-div mb-50"">

								<!-- Title -->
								<h5 class=""h5-md"">Working Time</h5>

								<!-- Text -->
							

								<!-- Table -->
								<table class=""table"">
									<tbody>
									    <tr>
									      	<td>Mon – Wed</td>
									      	<td> - </td>
									      	<td class=""text-right"">9:00 AM - 10:00 PM</td>
									    </tr>
									    <tr>
									      	<td>Thursday</td>
									      	<td> - </td>
									      	<td class=""text-right"">9:00 AM - 10 : 00 PM</td>
									    </tr>
									     <tr>
									      	<td>Fri - sat </td>
									      	<td> - </td>
									      	<td class=""text-right"">9:00 AM - 10:00 PM</td>
									    </tr>
									    <tr class=""last-tr"">
									      	<td> Sun</td>
									      	<td>-</td>
									      	<td class=""text-right"">CLOSED</td>
									   	 </tr");
            WriteLiteral(@">
									  </tbody>
								</table>

								<!-- Title -->
								

							</div>	<!-- END SIDEBAR TABLE -->


							<!-- SIDEBAR TIMETABLE -->
							


						</aside>   <!-- END SIDEBAR -->
						

					</div>     <!-- End row -->		
				</div>	    <!-- End container -->
			</section>	 <!-- END FAQs PAGE -->

	");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
