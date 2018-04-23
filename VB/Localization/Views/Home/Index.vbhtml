@ModelType Localization.Models.Data
@Imports Localization.Models
@Code
    Dim obj As System.Xml.Linq.XDocument = System.Xml.Linq.XDocument.Load(LocalizerHelper.GetPath())
End Code
<h2>@LocalizationText.HomePageTitle</h2>

@Using (Html.BeginForm("Post", "Home", FormMethod.Post))
    Html.DevExpress().TextBox(
        Sub(settings)
            settings.Name = "Name"
            settings.Width = 200
            settings.ShowModelErrors = True
            settings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
        End Sub).Bind(Model.Name).GetHtml()
    @Html.DevExpress().RadioButtonList(Sub(rs)
    
                                           rs.Name = "rb1"
                                           rs.Properties.ValueField = "ID"
                                           rs.Properties.TextField = "Name"
                                           rs.Properties.ValueType = GetType(Integer)

                                       End Sub).BindToXML(LocalizerHelper.GetPath(), "//State").GetHtml()
    @Html.DevExpress().ComboBox(Sub(cmbs)

                                    cmbs.Name = "combo1"
                                    cmbs.Properties.ValueField = "ID"
                                    cmbs.Properties.TextField = "Name"
                                    cmbs.Properties.ValueType = GetType(Integer)

                                End Sub).BindList(obj.Descendants("State").Select(Function(x) New With
{
    .ID = x.Attribute("ID").Value,
    .Name = x.Attribute("Name").Value
})).GetHtml()
    @Html.DevExpress().ComboBox(Sub(cmbs)
                                     cmbs.Name = "combo2"
                                     cmbs.Properties.ValueField = "ID"
                                     cmbs.Properties.TextField = "Name"
                                     cmbs.PreRender = Sub(s, e)
                                                          Dim combo As MVCxComboBox = TryCast(s, MVCxComboBox)
                                                          For Each item As ListEditItem In combo.Items
                                                              Dim newText = LocalizerHelper.GetLocalizedText(item.Text)
                                                              item.Text = newText
                                                          Next item
                                                      End Sub
                                     cmbs.Properties.ValueType = GetType(Integer)
End Sub).BindList(Data.GetTestData()).GetHtml()
    Html.DevExpress().Button(
        Sub(settings)
            settings.Name = "Submit"
            settings.Text = "Submit"
            settings.UseSubmitBehavior = True
        End Sub).GetHtml()
End Using