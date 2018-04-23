// Developer Express Code Central Example:
// Best practices to change the current Culture in ASP.NET MVC Application using ComboBox Extension
// 
// This code example implements the approaches described in the
// http://www.devexpress.com/scid=T108044 knowledge base article. Please refer to
// the article above for implementation details.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=T108173

using Localization.Content;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Web;

namespace Localization.Models
{
    public class Data
    {
        public int ID { get; set; }

        [Required(ErrorMessageResourceName = "RequiredValidationMessage", ErrorMessageResourceType = typeof(LocalizationText))]
        public string Name { get; set; }
        public static List<Data> GetTestData()
        {
            List<Data> l = new List<Data>();
            l.Add(new Data() { ID = 0, Name = "Incomplete" });
            l.Add(new Data() { ID = 1, Name = "Labels missing" });
            l.Add(new Data() { ID = 2, Name = "Complete" });
            l.Add(new Data() { ID = 3, Name = "Sent" });
            l.Add(new Data() { ID = 4, Name = "Released" });
            return l;
        }
    }
    public static class LocalizerHelper
    {
        public static string GetPath()
        {
            var culture = Thread.CurrentThread.CurrentUICulture;
            string letters = culture.TwoLetterISOLanguageName;
            if (String.IsNullOrWhiteSpace(letters))
                return String.Empty;
            return HttpContext.Current.Server.MapPath(String.Format("~/App_Data/States.{0}.xml", letters));

        }
        public static string GetLocalizedText(string originalText)
        {
            ResourceManager rm = new ResourceManager(typeof(LocalizationText));
            var preparedText = originalText.Replace(" ", string.Empty);
            try
            {
                return rm.GetString(preparedText);
            }
            catch (Exception)
            {


            }
            return string.Empty;
        }
    }
}