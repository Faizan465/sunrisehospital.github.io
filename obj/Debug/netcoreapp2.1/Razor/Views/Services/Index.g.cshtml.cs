#pragma checksum "C:\Users\faizan\sunrisehospital\Views\Services\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebc2999890784d2bfffa3fb02a63b8fa473f5644"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Index), @"mvc.1.0.view", @"/Views/Services/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Services/Index.cshtml", typeof(AspNetCore.Views_Services_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebc2999890784d2bfffa3fb02a63b8fa473f5644", @"/Views/Services/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f5067512f89a531aa0bb340d7e9039d052836b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-Controller", "Services", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-Action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 317, true);
            WriteLiteral(@"	<div id=""breadcrumb"" class=""division"">
				<div class=""container"">
					<div class=""row"">						
						<div class=""col"">
							<div class="" breadcrumb-holder"">

								<!-- Breadcrumb Nav -->
								<nav aria-label=""breadcrumb"">
								  	<ol class=""breadcrumb"">
								    	<li class=""breadcrumb-item"">");
            EndContext();
            BeginContext(317, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c31326edb8c6428bbdc0ff56ba64cd78", async() => {
                BeginContext(366, 4, true);
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
            BeginContext(374, 25418, true);
            WriteLiteral(@"</li>
								    	<li class=""breadcrumb-item active"" aria-current=""page"">Our Services</li>
								  	</ol>
								</nav>

								<!-- Title -->
								<h4 class=""h4-sm steelblue-color"">Our Services</h4>

							</div>
						</div>
					</div>  <!-- End row -->	
				</div>	<!-- End container -->		
			</div>	<!-- END BREADCRUMB -->	




			<!-- TABS-2
			============================================= -->
			<section id=""tabs-2"" class=""wide-100 tabs-section division"">
				<div class=""container"">	
				 	<div class=""row"">


				 		<!-- TABS NAVIGATION -->
				 		<div class=""col-lg-4"">
							<div id=""tabs-nav"" class=""list-group text-center clearfix"">
							    <ul class=""nav nav-pills"" id=""pills-tab"" role=""tablist"">

							    	<!-- TAB-1 LINK -->
								  	<li class=""nav-item icon-xs"">
								    	<a class=""nav-link active"" id=""tab11-list"" data-toggle=""pill"" href=""#tab-11"" role=""tab"" aria-controls=""tab-11"" aria-selected=""true"">
								    		ECG
								    	</a>
								");
            WriteLiteral(@"  	</li>

								  	<!-- TAB-2 LINK -->
									<li class=""nav-item icon-xs"">
									    <a class=""nav-link"" id=""tab12-list"" data-toggle=""pill"" href=""#tab-12"" role=""tab"" aria-controls=""tab-12"" aria-selected=""false"">
									      Pathology
									    </a>
									</li>

									<!-- TAB-3 LINK -->
									<li class=""nav-item icon-xs"">
									    <a class=""nav-link"" id=""tab13-list"" data-toggle=""pill"" href=""#tab-13"" role=""tab"" aria-controls=""tab-13"" aria-selected=""false"">
									   24X7 Emergency
									    </a>
									</li>

									<!-- TAB-4 LINK -->
									<li class=""nav-item icon-xs"">
									    <a class=""nav-link"" id=""tab14-list"" data-toggle=""pill"" href=""#tab-14"" role=""tab"" aria-controls=""tab-14"" aria-selected=""false"">
									       X-Ray Diagnostic
									    </a>
									</li>

								</ul>

							</div>	
						</div>	<!-- END TABS NAVIGATION -->


						<!-- TABS CONTENT -->
				 		<div class=""col-lg-8"">
							<div class=""tab-content"" id=""pi");
            WriteLiteral(@"lls-tabContent"">


								<!-- TAB-1 CONTENT -->
								<div class=""tab-pane fade show active"" id=""tab-11"" role=""tabpanel"" aria-labelledby=""tab11-list"">									
									<!-- Title -->
									<h3 class=""h3-md steelblue-color"">Routine Medical Care</h3>

									<!-- Text -->
									<p>Sapien gravida donec enim ipsum blandit porta justo integer odio velna vitae auctor
									   integer congue magna at pretium  purus pretium ligula rutrum itae laoreet augue in 
									   cubilia laoreet an augue egestas ipsum vitae emo ligula vitae arcu mollis blandit ultrice
									   ligula egestas magna suscipit
									</p>

									<!-- Image -->
									<div class=""tab-img"">
										<img class=""img-fluid"" src=""images/pediatrics_1000x500.jpg"" alt=""tab-image"" />
									</div>

									<!-- Text -->
									<p>An enim nullam tempor sapien gravida donec enim ipsum blandit
									   porta justo integer odio velna vitae auctor integer congue magna at pretium 
									   purus pret");
            WriteLiteral(@"ium ligula rutrum itae laoreet augue in cubilia laoreet an augue 
									   egestas ipsum vitae emo ligula vitae arcu mollis blandit ultrice ligula egestas 
									   magna suscipit
									</p>

									<!-- Options List -->
									<div class=""row"">

										<div class=""col-xl-6"">

											<!-- Option #1 -->
											<div class=""box-list"">							
												<div class=""box-list-icon blue-color""><i class=""fas fa-angle-double-right""></i></div>
												<p>Nemo ipsam egestas volute and turpis dolores quaerat massa suscipit, luctus neque</p>							
											</div>

											<!-- Option #2 -->
											<div class=""box-list"">	
												<div class=""box-list-icon blue-color""><i class=""fas fa-angle-double-right""></i></div>
												<p>Magna massa suscipit, luctus neque purus and ipsum neque dolor primis luctus tempor</p>			
											</div>

											<!-- Option #3 -->
											<div class=""box-list"">	
												<div class=""box-list-icon blue-color""><i clas");
            WriteLiteral(@"s=""fas fa-angle-double-right""></i></div>
												<p>An enim nullam tempor at pretium blandit</p>				
											</div>

										</div>

										<div class=""col-xl-6"">

											<!-- Option #4 -->
											<div class=""box-list"">	
												<div class=""box-list-icon blue-color""><i class=""fas fa-angle-double-right""></i></div>
												<p>Magna massa suscipit, luctus neque purus and ipsum neque dolor primis luctus tempor</p>			
											</div>

											<!-- Option #5 -->
											<div class=""box-list"">							
												<div class=""box-list-icon blue-color""><i class=""fas fa-angle-double-right""></i></div>
												<p>An enim nullam tempor at pretium blandit</p>							
											</div>

											<!-- Option #6 -->
											<div class=""box-list"">	
												<div class=""box-list-icon blue-color""><i class=""fas fa-angle-double-right""></i></div>
												<p>Magna massa suscipit, luctus neque purus and ipsum neque dolor primis luctus tempor</p>			
											<");
            WriteLiteral(@"/div>

										</div>

									</div>	<!-- End Options List -->

									<!-- Button -->
									<a href=""service-1.html"" class=""btn btn-blue blue-hover mt-30"">View More Details</a>

								</div>	<!-- END TAB-1 CONTENT -->


								<!-- TAB-2 CONTENT -->
								<div class=""tab-pane fade"" id=""tab-12"" role=""tabpanel"" aria-labelledby=""tab12-list"">

									<!-- Title -->
									<h3 class=""h3-md steelblue-color"">Full Blood Picture</h3>

									<!-- Text -->
									<p>Sapien gravida donec enim ipsum blandit porta justo integer odio velna vitae auctor
									   integer congue magna at pretium  purus pretium ligula rutrum itae laoreet augue in 
									   cubilia laoreet an augue egestas ipsum vitae emo ligula vitae arcu mollis blandit ultrice
									   ligula egestas magna suscipit
									</p>

									<!-- Image -->
									<div class=""tab-img"">
										<img class=""img-fluid"" src=""images/hematology_1000x500.jpg"" alt=""tab-image"" />
									</div>

									<");
            WriteLiteral(@"!-- Text -->
									<p>An enim nullam tempor sapien gravida donec enim ipsum blandit
									   porta justo integer odio velna vitae auctor integer congue magna at pretium 
									   purus pretium ligula rutrum itae laoreet augue in cubilia laoreet an augue 
									   egestas ipsum vitae emo ligula vitae arcu mollis blandit ultrice ligula egestas 
									   magna suscipit
									</p>

									<!-- Options List -->
									<div class=""row"">

										<div class=""col-xl-6"">

											<!-- Option #1 -->
											<div class=""box-list"">							
												<div class=""box-list-icon blue-color""><i class=""fas fa-angle-double-right""></i></div>
												<p>Nemo ipsam egestas volute and turpis dolores quaerat massa suscipit, luctus neque</p>							
											</div>

											<!-- Option #2 -->
											<div class=""box-list"">	
												<div class=""box-list-icon blue-color""><i class=""fas fa-angle-double-right""></i></div>
												<p>Magna massa suscipit, luctus neque p");
            WriteLiteral(@"urus and ipsum neque dolor primis luctus tempor</p>			
											</div>

											<!-- Option #3 -->
											<div class=""box-list"">	
												<div class=""box-list-icon blue-color""><i class=""fas fa-angle-double-right""></i></div>
												<p>An enim nullam tempor at pretium blandit</p>				
											</div>

										</div>

										<div class=""col-xl-6"">

											<!-- Option #4 -->
											<div class=""box-list"">	
												<div class=""box-list-icon blue-color""><i class=""fas fa-angle-double-right""></i></div>
												<p>Magna massa suscipit, luctus neque purus and ipsum neque dolor primis luctus tempor</p>			
											</div>

											<!-- Option #5 -->
											<div class=""box-list"">							
												<div class=""box-list-icon blue-color""><i class=""fas fa-angle-double-right""></i></div>
												<p>An enim nullam tempor at pretium blandit</p>							
											</div>

											<!-- Option #6 -->
											<div class=""box-list"">	
												<div ");
            WriteLiteral(@"class=""box-list-icon blue-color""><i class=""fas fa-angle-double-right""></i></div>
												<p>Magna massa suscipit, luctus neque purus and ipsum neque dolor primis luctus tempor</p>			
											</div>

										</div>

									</div>	<!-- End Options List -->

									<!-- Button -->
									<a href=""service-1.html"" class=""btn btn-blue blue-hover mt-30"">View More Details</a>
										
								</div>	<!-- END TAB-2 CONTENT -->


								<!-- TAB-3 CONTENT -->
								<div class=""tab-pane fade"" id=""tab-13"" role=""tabpanel"" aria-labelledby=""tab13-list"">

									<!-- Title -->
									<h3 class=""h3-md steelblue-color"">MRI Diagnostic</h3>

									<!-- Text -->
									<p>Sapien gravida donec enim ipsum blandit porta justo integer odio velna vitae auctor
									   integer congue magna at pretium  purus pretium ligula rutrum itae laoreet augue in 
									   cubilia laoreet an augue egestas ipsum vitae emo ligula vitae arcu mollis blandit ultrice
									   ligula egestas ma");
            WriteLiteral(@"gna suscipit
									</p>

									<!-- Image -->
									<div class=""tab-img"">
										<img class=""img-fluid"" src=""images/mri_1000x500.jpg"" alt=""tab-image"" />
									</div>

									<!-- Text -->
									<p>An enim nullam tempor sapien gravida donec enim ipsum blandit
									   porta justo integer odio velna vitae auctor integer congue magna at pretium 
									   purus pretium ligula rutrum itae laoreet augue in cubilia laoreet an augue 
									   egestas ipsum vitae emo ligula vitae arcu mollis blandit ultrice ligula egestas 
									   magna suscipit
									</p>

									<!-- Options List -->
									<div class=""row"">

										<div class=""col-xl-6"">

											<!-- Option #1 -->
											<div class=""box-list"">							
												<div class=""box-list-icon blue-color""><i class=""fas fa-angle-double-right""></i></div>
												<p>Nemo ipsam egestas volute and turpis dolores quaerat massa suscipit, luctus neque</p>							
											</div>

											<!-- O");
            WriteLiteral(@"ption #2 -->
											<div class=""box-list"">	
												<div class=""box-list-icon blue-color""><i class=""fas fa-angle-double-right""></i></div>
												<p>Magna massa suscipit, luctus neque purus and ipsum neque dolor primis luctus tempor</p>			
											</div>

											<!-- Option #3 -->
											<div class=""box-list"">	
												<div class=""box-list-icon blue-color""><i class=""fas fa-angle-double-right""></i></div>
												<p>An enim nullam tempor at pretium blandit</p>				
											</div>

										</div>

										<div class=""col-xl-6"">

											<!-- Option #4 -->
											<div class=""box-list"">	
												<div class=""box-list-icon blue-color""><i class=""fas fa-angle-double-right""></i></div>
												<p>Magna massa suscipit, luctus neque purus and ipsum neque dolor primis luctus tempor</p>			
											</div>

											<!-- Option #5 -->
											<div class=""box-list"">							
												<div class=""box-list-icon blue-color""><i class=""fas fa-angle");
            WriteLiteral(@"-double-right""></i></div>
												<p>An enim nullam tempor at pretium blandit</p>							
											</div>

											<!-- Option #6 -->
											<div class=""box-list"">	
												<div class=""box-list-icon blue-color""><i class=""fas fa-angle-double-right""></i></div>
												<p>Magna massa suscipit, luctus neque purus and ipsum neque dolor primis luctus tempor</p>			
											</div>

										</div>

									</div>	<!-- End Options List -->

									<!-- Button -->
									<a href=""service-1.html"" class=""btn btn-blue blue-hover mt-30"">View More Details</a>
										
								</div>	<!-- END TAB-3 CONTENT -->


								<!-- TAB-4 CONTENT -->
								<div class=""tab-pane fade"" id=""tab-14"" role=""tabpanel"" aria-labelledby=""tab14-list"">

									<!-- Title -->
									<h3 class=""h3-md steelblue-color"">X-Ray Diagnostic</h3>

									<!-- Text -->
									<p>Sapien gravida donec enim ipsum blandit porta justo integer odio velna vitae auctor
									   integer congue ");
            WriteLiteral(@"magna at pretium  purus pretium ligula rutrum itae laoreet augue in 
									   cubilia laoreet an augue egestas ipsum vitae emo ligula vitae arcu mollis blandit ultrice
									   ligula egestas magna suscipit
									</p>

									<!-- Image -->
									<div class=""tab-img"">
										<img class=""img-fluid"" src=""images/x-ray_1000x500.jpg"" alt=""tab-image"" />
									</div>

									<!-- Text -->
									<p>An enim nullam tempor sapien gravida donec enim ipsum blandit
									   porta justo integer odio velna vitae auctor integer congue magna at pretium 
									   purus pretium ligula rutrum itae laoreet augue in cubilia laoreet an augue 
									   egestas ipsum vitae emo ligula vitae arcu mollis blandit ultrice ligula egestas 
									   magna suscipit
									</p>

									<!-- Options List -->
									<div class=""row"">

										<div class=""col-xl-6"">

											<!-- Option #1 -->
											<div class=""box-list"">							
												<div class=""box-list-icon blue");
            WriteLiteral(@"-color""><i class=""fas fa-angle-double-right""></i></div>
												<p>Nemo ipsam egestas volute and turpis dolores quaerat massa suscipit, luctus neque</p>							
											</div>

											<!-- Option #2 -->
											<div class=""box-list"">	
												<div class=""box-list-icon blue-color""><i class=""fas fa-angle-double-right""></i></div>
												<p>Magna massa suscipit, luctus neque purus and ipsum neque dolor primis luctus tempor</p>			
											</div>

											<!-- Option #3 -->
											<div class=""box-list"">	
												<div class=""box-list-icon blue-color""><i class=""fas fa-angle-double-right""></i></div>
												<p>An enim nullam tempor at pretium blandit</p>				
											</div>

										</div>

										<div class=""col-xl-6"">

											<!-- Option #4 -->
											<div class=""box-list"">	
												<div class=""box-list-icon blue-color""><i class=""fas fa-angle-double-right""></i></div>
												<p>Magna massa suscipit, luctus neque purus and ipsum neq");
            WriteLiteral(@"ue dolor primis luctus tempor</p>			
											</div>

											<!-- Option #5 -->
											<div class=""box-list"">							
												<div class=""box-list-icon blue-color""><i class=""fas fa-angle-double-right""></i></div>
												<p>An enim nullam tempor at pretium blandit</p>							
											</div>

											<!-- Option #6 -->
											<div class=""box-list"">	
												<div class=""box-list-icon blue-color""><i class=""fas fa-angle-double-right""></i></div>
												<p>Magna massa suscipit, luctus neque purus and ipsum neque dolor primis luctus tempor</p>			
											</div>

										</div>

									</div>	<!-- End Options List -->

									<!-- Button -->
									<a href=""service-1.html"" class=""btn btn-blue blue-hover mt-30"">View More Details</a>
									
								</div>	<!-- END TAB-4 CONTENT -->


							</div>	<!-- END TABS CONTENT -->


			 			</div>	
				 	</div>     <!-- End row -->	
				</div>     <!-- End container -->	
			</section>	<!-- END TABS-2");
            WriteLiteral(@" -->




			<!-- TESTIMONIALS-2
			============================================= -->
			<section id=""reviews-2"" class=""bg-lightgrey wide-100 reviews-section division"">
				<div class=""container"">


					<!-- SECTION TITLE -->	
					<div class=""row"">	
						<div class=""col-lg-10 offset-lg-1 section-title"">		

							<!-- Title 	-->	
							<h3 class=""h3-md steelblue-color"">What Our Patients Say</h3>	

							<!-- Text -->
							<p>Aliquam a augue suscipit, luctus neque purus ipsum neque dolor primis libero at tempus, 
							   blandit posuere ligula varius congue cursus porta feugiat
							</p>
										
						</div> 
					</div>	 <!-- END SECTION TITLE -->
				
					
					<!-- TESTIMONIALS CONTENT -->
					<div class=""row"">
						<div class=""col-md-12"">					
							<div class=""owl-carousel owl-theme reviews-holder"">

						
								<!-- TESTIMONIAL #1 -->
								<div class=""review-2"">
									<div class=""review-txt text-center"">

										<!-- Quote -->
										<");
            WriteLiteral(@"div class=""quote""><img src=""images/quote.png"" alt=""quote-img"" /></div>	

										<!-- Author Avatar -->
										<div class=""testimonial-avatar"">
											<img src=""images/review-author-1.jpg"" alt=""testimonial-avatar"">
										</div>
																
										<!-- Testimonial Text -->
										<p>Etiam sapien sem at sagittis congue an augue massa varius egestas a suscipit
										   magna undo tempus aliquet porta vitae
										</p>	

										<!-- Testimonial Author -->
										<div class=""review-author"">
											<h5 class=""h5-sm"">Scott Boxer</h5>	
											<span>Programmer</span>	
										</div>							
																
									</div>						
								</div>	<!--END  TESTIMONIAL #1 -->
						
						
								<!-- TESTIMONIAL #2 -->
								<div class=""review-2"">
									<div class=""review-txt text-center"">

										<!-- Quote -->
										<div class=""quote""><img src=""images/quote.png"" alt=""quote-img"" /></div>	

										<!-- Author Avatar -->
										<");
            WriteLiteral(@"div class=""testimonial-avatar"">
											<img src=""images/review-author-2.jpg"" alt=""testimonial-avatar"">
										</div>
																
										<!-- Testimonial Text -->
										<p>Mauris donec ociis magnisa a sapien etiam sapien congue augue egestas et ultrice
										   vitae purus diam integer congue magna ligula egestas
										</p>										

										<!-- Testimonial Author -->
										<div class=""review-author"">
											<h5 class=""h5-sm"">Penelopa Peterson</h5>	
											<span>Project Manager</span>	
										</div>

									</div>						
								</div>	<!-- END TESTIMONIAL #2 -->
						
						
								<!-- TESTIMONIAL #3 -->
								<div class=""review-2"">
									<div class=""review-txt text-center"">

										<!-- Quote -->
										<div class=""quote""><img src=""images/quote.png"" alt=""quote-img"" /></div>	

										<!-- Author Avatar -->
										<div class=""testimonial-avatar"">
											<img src=""images/review-author-3.jpg"" alt=""testimonial-avata");
            WriteLiteral(@"r"">
										</div>
																
										<!-- Testimonial Text -->
										<p>At sagittis congue augue an egestas magna ipsum vitae purus ipsum primis undo cubilia
										   laoreet augue	   
										</p>

										<!-- Testimonial Author -->
										<div class=""review-author"">
											<h5 class=""h5-sm"">M.Scanlon</h5>	
											<span>Photographer</span>	
										</div>

									</div>						
								</div>	<!-- END TESTIMONIAL #3 -->


								<!-- TESTIMONIAL #4 -->
								<div class=""review-2"">
									<div class=""review-txt text-center"">

										<!-- Quote -->
										<div class=""quote""><img src=""images/quote.png"" alt=""quote-img"" /></div>

										<!-- Author Avatar -->
										<div class=""testimonial-avatar"">
											<img src=""images/review-author-4.jpg"" alt=""testimonial-avatar"">
										</div>	
																
										<!-- Testimonial Text -->
										<p>Mauris donec ociis magnis sapien etiam sapien congue augue pretium ligula 
");
            WriteLiteral(@"										   a lectus aenean magna mauris
										</p>

										<!-- Testimonial Author -->
										<div class=""review-author"">
											<h5 class=""h5-sm"">Jeremy Kruse</h5>	
											<span>Graphic Designer</span>	
										</div>
					
									</div>						
								</div>	<!-- END TESTIMONIAL #4 -->
								
								
								<!-- TESTIMONIAL #5 -->
								<div class=""review-2"">
									<div class=""review-txt text-center"">

										<!-- Quote -->
										<div class=""quote""><img src=""images/quote.png"" alt=""quote-img"" /></div>	

										<!-- Author Avatar -->
										<div class=""testimonial-avatar"">
											<img src=""images/review-author-5.jpg"" alt=""testimonial-avatar"">
										</div>
																
										<!-- Testimonial Text -->
										<p>An augue in cubilia laoreet magna suscipit egestas magna ipsum at purus ipsum
										   primis in augue ulta ligula egestas
										</p>

										<!-- Testimonial Author -->
										<div class=""review-");
            WriteLiteral(@"author"">
											<h5 class=""h5-sm"">Evelyn Martinez</h5>	
											<span>Senior UX/UI Designer</span>	
										</div>						
																
									</div>						
								</div>	<!-- END TESTIMONIAL #5 -->
								
								
								<!-- TESTIMONIAL #6 -->
								<div class=""review-2"">
									<div class=""review-txt text-center"">

										<!-- Quote -->
										<div class=""quote""><img src=""images/quote.png"" alt=""quote-img"" /></div>

										<!-- Author Avatar -->
										<div class=""testimonial-avatar"">
											<img src=""images/review-author-6.jpg"" alt=""testimonial-avatar"">
										</div>	
																
										<!-- Testimonial Text -->
										<p>An augue cubilia laoreet undo magna at risus suscipit egestas magna an ipsum ligula
										   vitae and purus ipsum primis
										</p>

										<!-- Testimonial Author -->
										<div class=""review-author"">
											<h5 class=""h5-sm"">Dan Hodges</h5>	
											<span>Internet Surfer</span>	
						");
            WriteLiteral(@"				</div>

									</div>						
								</div>	<!-- END TESTIMONIAL #6 -->
								
								
								<!-- TESTIMONIAL #7 -->
								<div class=""review-2"">
									<div class=""review-txt text-center"">

										<!-- Quote -->
										<div class=""quote""><img src=""images/quote.png"" alt=""quote-img"" /></div>	

										<!-- Author Avatar -->
										<div class=""testimonial-avatar"">
											<img src=""images/review-author-7.jpg"" alt=""testimonial-avatar"">
										</div>
																
										<!-- Testimonial Text -->
										<p>Augue egestas volutpat egestas augue in cubilia laoreet magna suscipit luctus
										   and dolor blandit vitae
										</p>

										<!-- Testimonial Author -->
										<div class=""review-author"">
											<h5 class=""h5-sm"">Isabel M.</h5>	
											<span>SEO Manager</span>	
										</div>

									</div>						
								</div>	<!-- END TESTIMONIAL #7 -->


								<!-- TESTIMONIAL #8 -->
								<div class=""review-2"">
				");
            WriteLiteral(@"					<div class=""review-txt text-center"">

										<!-- Quote -->
										<div class=""quote""><img src=""images/quote.png"" alt=""quote-img"" /></div>	

										<!-- Author Avatar -->
										<div class=""testimonial-avatar"">
											<img src=""images/review-author-8.jpg"" alt=""testimonial-avatar"">
										</div>
																
										<!-- Testimonial Text -->
										<p>Augue egestas volutpat egestas augue in cubilia laoreet magna suscipit luctus
										   and dolor blandit vitae
										</p>

										<!-- Testimonial Author -->
										<div class=""review-author"">
											<h5 class=""h5-sm"">Alex Ross</h5>	
											<span>Patient</span>	
										</div>							
																
									</div>						
								</div>	<!-- END TESTIMONIAL #8 -->


								<!-- TESTIMONIAL #9-->
								<div class=""review-2"">
									<div class=""review-txt text-center"">

										<!-- Quote -->
										<div class=""quote""><img src=""images/quote.png"" alt=""quote-img"" /></div>");
            WriteLiteral(@"

										<!-- Author Avatar -->
										<div class=""testimonial-avatar"">
											<img src=""images/review-author-9.jpg"" alt=""testimonial-avatar"">
										</div>	
																
										<!-- Testimonial Text -->
										<p>Augue egestas volutpat egestas augue in cubilia laoreet magna suscipit luctus
										   magna dolor neque vitae 								   
										</p>

										<!-- Testimonial Author -->
										<div class=""review-author"">
											<h5 class=""h5-sm"">Alisa Milano</h5>	
											<span>Housewife</span>	
										</div>
						
									</div>						
								</div>	<!-- END TESTIMONIAL #9 -->

							
							</div>
						</div>									
					</div>	<!-- END TESTIMONIALS CONTENT --> 
							
						
				</div>	   <!-- End container -->
			</section>	 <!-- END TESTIMONIALS-2 -->




			<!-- BANNER-5
			============================================= -->
			<section id=""banner-5"" class=""pt-100 banner-section division"">
				<div class=""container"">


");
            WriteLiteral(@"					<!-- SECTION TITLE -->	
					<div class=""row"">	
						<div class=""col-lg-10 offset-lg-1 section-title"">		

							<!-- Title 	-->	
							<h3 class=""h3-md steelblue-color"">Certified and Experienced Doctors</h3>	

							<!-- Text -->
							<p>Aliquam a augue suscipit, luctus neque purus ipsum neque dolor primis libero at tempus, 
							   blandit posuere ligula varius congue cursus porta feugiat
							</p>
										
						</div> 
					</div>


					<!-- BANNER IMAGE -->
					<div class=""row"">
						<div class=""col-lg-10 offset-lg-1"">
							<div class=""banner-5-img wow fadeInUp"" data-wow-delay=""0.4s"">
								<img class=""img-fluid"" src=""images/image-07.png"" alt=""banner-image"" />
							</div>
						</div>
					</div>


				</div>	   <!-- End container -->	
			</section>	<!-- END BANNER-5 -->

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
