using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models
{
    public class GoogleBookItem
    {
        public string Title { get; set; }
        public List<string> Authors { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public string PreviewLink { get; set; }
        public AccessInfo AccessInfo { get; set; }
    }

    public class AccessInfo
    {
        public FormatInfo Pdf { get; set; }
        public FormatInfo Epub { get; set; }
    }

    public class FormatInfo
    {
        public bool IsAvailable { get; set; }
        public string AcsTokenLink { get; set; }
    }
}
