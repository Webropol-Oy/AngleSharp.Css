﻿namespace AngleSharp.Css.Converters
{
    using AngleSharp.Css.Dom;
    using AngleSharp.Text;
    using System;
    using System.IO;

    sealed class AnyValueConverter : IValueConverter
    {
        public ICssValue Convert(StringSource source)
        {
            var value = source.Content;
            source.Next(value.Length);
            return new AnyValue(value);
        }

        private sealed class AnyValue : ICssValue
        {
            private readonly String _text;

            public AnyValue(String text)
            {
                _text = text;
            }

            public String CssText
            {
                get { return _text; }
            }

            public void ToCss(TextWriter writer, IStyleFormatter formatter)
            {
                writer.Write(_text);
            }
        }
    }
}
