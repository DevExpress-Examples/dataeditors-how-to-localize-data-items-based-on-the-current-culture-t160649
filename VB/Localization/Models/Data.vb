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
Imports Localization.Content
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Reflection
Imports System.Web
Imports System.Threading
Imports System.Resources

Namespace Localization.Models
    Public Class Data
        Private privateID As Integer
        Public Property ID() As Integer
            Get
                Return privateID
            End Get
            Set(ByVal value As Integer)
                privateID = value
            End Set
        End Property

        Private privateName As String
        <Required(ErrorMessageResourceName:="RequiredValidationMessage", ErrorMessageResourceType:=GetType(LocalizationText))> _
        Public Property Name() As String
            Get
                Return privateName
            End Get
            Set(ByVal value As String)
                privateName = value
            End Set
        End Property
        Public Shared Function GetTestData() As List(Of Data)
            Dim l As New List(Of Data)()
            l.Add(New Data() With {.ID = 0, .Name = "Incomplete"})
            l.Add(New Data() With {.ID = 1, .Name = "Labels missing"})
            l.Add(New Data() With {.ID = 2, .Name = "Complete"})
            l.Add(New Data() With {.ID = 3, .Name = "Sent"})
            l.Add(New Data() With {.ID = 4, .Name = "Released"})
            Return l
        End Function
    End Class
    Public NotInheritable Class LocalizerHelper
        Private Sub New()
        End Sub
        Public Shared Function GetPath() As String
            Dim culture = Thread.CurrentThread.CurrentUICulture
            Dim letters As String = culture.TwoLetterISOLanguageName
            If String.IsNullOrWhiteSpace(letters) Then
                Return String.Empty
            End If
            Return HttpContext.Current.Server.MapPath(String.Format("~/App_Data/States.{0}.xml", letters))

        End Function
        Public Shared Function GetLocalizedText(ByVal originalText As String) As String
            Dim rm As New ResourceManager(GetType(LocalizationText))
            Dim preparedText = originalText.Replace(" ", String.Empty)
            Try
                Return rm.GetString(preparedText)
            Catch e1 As Exception

            End Try
            Return String.Empty
        End Function
    End Class
End Namespace