using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Net.Mail;
using DevExpress.XtraRichEdit;
using DevExpress.Utils;
using DevExpress.Office.Services;
using System.Net.Mime;
using System.IO;
using DevExpress.XtraRichEdit.Export;
using DevExpress.Office.Utils;
using System.Text.RegularExpressions;

namespace DXSWI
{
    public class Utils
    {
        public static string getRandomAlphaNumeric(int len)
        {
            Random rand = new Random();
            string pool = "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var chars = Enumerable.Range(0, len).Select(x => pool[rand.Next(0, pool.Length - 1)]);
            return new string(chars.ToArray());
        }

        public static DateTime YearWeekDayToDateTime(int year, DayOfWeek day, int week)
        {
            DateTime startOfYear = new DateTime(year, 1, 1);
            // the +7 and %7 stuff is to avoid negative numbers etc.
            int daysToFirstCorrectDay = (((int)day - (int)startOfYear.DayOfWeek) + 7) % 7;
            return startOfYear.AddDays(7 * (week - 1) + daysToFirstCorrectDay);

            //// Show the third Tuesday in 2009. Should be January 20th
            //Console.WriteLine(YearWeekDayToDateTime(2009, DayOfWeek.Tuesday, 3));
        }

        public static string Capitalize(string text)
        {
            return Regex.Replace(text, @"\b[a-z]", delegate (Match m)
            {
                return m.Value.ToUpper();
            });
        }
    }

    public class RichEditMailMessageExporter : IUriProvider
    {
        readonly RichEditControl control;
        readonly MailMessage message;
        List<AttachementInfo> attachments;
        int imageId;

        public RichEditMailMessageExporter(RichEditControl control, MailMessage message)
        {
            Guard.ArgumentNotNull(control, "control");
            Guard.ArgumentNotNull(message, "message");

            this.control = control;
            this.message = message;

        }

        public virtual void Export()
        {
            this.attachments = new List<AttachementInfo>();

            AlternateView htmlView = CreateHtmlView();
            message.AlternateViews.Add(htmlView);
            message.IsBodyHtml = true;
        }

        protected internal virtual AlternateView CreateHtmlView()
        {
            control.BeforeExport += OnBeforeExport;
            string htmlBody = control.Document.GetHtmlText(control.Document.Range, this);
            AlternateView view = AlternateView.CreateAlternateViewFromString(htmlBody, Encoding.UTF8, MediaTypeNames.Text.Html);
            control.BeforeExport -= OnBeforeExport;

            int count = attachments.Count;
            for (int i = 0; i < count; i++)
            {
                AttachementInfo info = attachments[i];
                LinkedResource resource = new LinkedResource(info.Stream, info.MimeType);
                resource.ContentId = info.ContentId;
                view.LinkedResources.Add(resource);
            }
            return view;
        }

        void OnBeforeExport(object sender, BeforeExportEventArgs e)
        {
            HtmlDocumentExporterOptions options = e.Options as HtmlDocumentExporterOptions;
            if (options != null)
            {
                options.Encoding = Encoding.UTF8;
            }
        }


        #region IUriProvider Members

        public string CreateCssUri(string rootUri, string styleText, string relativeUri)
        {
            return String.Empty;
        }
        public string CreateImageUri(string rootUri, OfficeImage image, string relativeUri)
        {
            string imageName = String.Format("image{0}", imageId);
            imageId++;

            OfficeImageFormat imageFormat = GetActualImageFormat(image.RawFormat);
            Stream stream = new MemoryStream(image.GetImageBytes(imageFormat));
            string mediaContentType = OfficeImage.GetContentType(imageFormat);
            AttachementInfo info = new AttachementInfo(stream, mediaContentType, imageName);
            attachments.Add(info);

            return "cid:" + imageName;
        }

        OfficeImageFormat GetActualImageFormat(OfficeImageFormat _officeImageFormat)
        {
            if (_officeImageFormat == OfficeImageFormat.Exif ||
                _officeImageFormat == OfficeImageFormat.MemoryBmp)
                return OfficeImageFormat.Png;
            else
                return _officeImageFormat;
        }
        #endregion
    }

    public class AttachementInfo
    {
        Stream stream;
        string mimeType;
        string contentId;

        public AttachementInfo(Stream stream, string mimeType, string contentId)
        {
            this.stream = stream;
            this.mimeType = mimeType;
            this.contentId = contentId;
        }

        public Stream Stream { get { return stream; } }
        public string MimeType { get { return mimeType; } }
        public string ContentId { get { return contentId; } }
    }
}
