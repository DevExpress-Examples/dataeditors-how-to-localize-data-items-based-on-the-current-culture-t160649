' Developer Express Code Central Example:
' Best practices to change the current Culture in ASP.NET MVC Application using ComboBox Extension
' 
' This code example implements the approaches described in the
' http://www.devexpress.com/scid=T108044 knowledge base article. Please refer to
' the article above for implementation details.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T108173

Imports Microsoft.VisualBasic
Imports Localization.Models
Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Linq
Imports System.Threading
Imports System.Web
Imports System.Web.Mvc

Namespace Localization.Controllers
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Dim model = New Data With {.ID = 0, .Name = String.Empty}
			Return View(model)
		End Function

		<HttpPost> _
		Public Function Post(ByVal model As Data) As ActionResult
			Return View("Index", model)
		End Function
	End Class
End Namespace
