﻿using System;
using System.Text;
using System.Web.Mvc;

namespace MyPersonalBlog.Infrastructure
{
    public static partial class Utilities
    {
        public static MvcHtmlString SubstringText(this HtmlHelper html, string text, int maxLength)
        {
            StringBuilder result = new StringBuilder();

            TagBuilder tag = new TagBuilder("p");

            if (text.Length >= maxLength)
            {
                tag.InnerHtml = String.Format("{0} &hellip;", text.Substring(0, maxLength));
            }
            else
            {
                tag.InnerHtml = text;
            }

            result.Append(tag.ToString());
            return MvcHtmlString.Create(result.ToString());
        }
    }
}