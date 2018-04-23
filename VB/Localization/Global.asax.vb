﻿' Developer Express Code Central Example:
' Best practices to change the current Culture in ASP.NET MVC Application using ComboBox Extension
' 
' This code example implements the approaches described in the
' http://www.devexpress.com/scid=T108044 knowledge base article. Please refer to
' the article above for implementation details.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T108173

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Linq
Imports System.Threading
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Namespace Localization
	' Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	' visit http://go.microsoft.com/?LinkId=9394801

	Public Class MvcApplication
		Inherits System.Web.HttpApplication
		Public Shared Sub RegisterGlobalFilters(ByVal filters As GlobalFilterCollection)
			filters.Add(New HandleErrorAttribute())
		End Sub

		Public Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

			routes.MapRoute("Default", "{controller}/{action}/{id}", New With {Key .controller = "Home", Key .action = "Index", Key .id = UrlParameter.Optional})

		End Sub

		Protected Sub Application_Start()
			AreaRegistration.RegisterAllAreas()
			RegisterGlobalFilters(GlobalFilters.Filters)
			RegisterRoutes(RouteTable.Routes)
		End Sub

		Protected Sub Application_AcquireRequestState(ByVal sender As Object, ByVal e As EventArgs)
			If Request.Cookies("Culture") IsNot Nothing AndAlso (Not String.IsNullOrEmpty(Request.Cookies("Culture").Value)) Then
				Dim culture As String = Request.Cookies("Culture").Value
				Dim ci As New CultureInfo(culture)
				Thread.CurrentThread.CurrentUICulture = ci
				Thread.CurrentThread.CurrentCulture = ci
			End If
		End Sub
	End Class
End Namespace