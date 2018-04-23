﻿' Developer Express Code Central Example:
' Best practices to change the current Culture in ASP.NET MVC Application using ComboBox Extension
' 
' This code example implements the approaches described in the
' http://www.devexpress.com/scid=T108044 knowledge base article. Please refer to
' the article above for implementation details.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T108173

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18408
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
	Imports System
Namespace Localization.Content


	''' <summary>
	'''   A strongly-typed resource class, for looking up localized strings, etc.
	''' </summary>
	' This class was auto-generated by the StronglyTypedResourceBuilder
	' class via a tool like ResGen or Visual Studio.
	' To add or remove a member, edit your .ResX file then rerun ResGen
	' with the /str option, or rebuild your VS project.
	<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()> _
	Public Class LocalizationText

		Private Shared resourceMan As Global.System.Resources.ResourceManager

		Private Shared resourceCulture As Global.System.Globalization.CultureInfo

		<Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")> _
		Friend Sub New()
		End Sub

		''' <summary>
		'''   Returns the cached ResourceManager instance used by this class.
		''' </summary>
		<Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
		Public Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
			Get
				If Object.ReferenceEquals(resourceMan, Nothing) Then
					Dim temp As New Global.System.Resources.ResourceManager("LocalizationText", GetType(LocalizationText).Assembly)
					resourceMan = temp
				End If
				Return resourceMan
			End Get
		End Property

		''' <summary>
		'''   Overrides the current thread's CurrentUICulture property for all
		'''   resource lookups using this strongly typed resource class.
		''' </summary>
		<Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
		Public Shared Property Culture() As Global.System.Globalization.CultureInfo
			Get
				Return resourceCulture
			End Get
			Set(ByVal value As System.Globalization.CultureInfo)
				resourceCulture = value
			End Set
		End Property

		''' <summary>
		'''   Looks up a localized string similar to Home Page Title - Default.
		''' </summary>
		Public Shared ReadOnly Property HomePageTitle() As String
			Get
				Return ResourceManager.GetString("HomePageTitle", resourceCulture)
			End Get
		End Property

		''' <summary>
		'''   Looks up a localized string similar to Menu Item One - Default.
		''' </summary>
		Public Shared ReadOnly Property MenuItemOne() As String
			Get
				Return ResourceManager.GetString("MenuItemOne", resourceCulture)
			End Get
		End Property

		''' <summary>
		'''   Looks up a localized string similar to Menu Item Two - Default.
		''' </summary>
		Public Shared ReadOnly Property MenuItemTwo() As String
			Get
				Return ResourceManager.GetString("MenuItemTwo", resourceCulture)
			End Get
		End Property

		''' <summary>
		'''   Looks up a localized string similar to Error Message - Default.
		''' </summary>
		Public Shared ReadOnly Property RequiredValidationMessage() As String
			Get
				Return ResourceManager.GetString("RequiredValidationMessage", resourceCulture)
			End Get
		End Property
	End Class
End Namespace