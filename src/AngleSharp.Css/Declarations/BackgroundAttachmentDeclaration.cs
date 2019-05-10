namespace AngleSharp.Css.Declarations
{
    using AngleSharp.Css.Converters;
    using System;
    using static ValueConverters;

    static class BackgroundAttachmentDeclaration
    {
        public static String Name = PropertyNames.BackgroundAttachment;

        public static String[] Shorthands = new[]
        {
            PropertyNames.Background,
        };

        public static IValueConverter Converter = Or(BackgroundAttachmentConverter.FromList(), AssignInitial(InitialValues.BackgroundAttachmentDecl));

        public static PropertyFlags Flags = PropertyFlags.None;
    }
}
