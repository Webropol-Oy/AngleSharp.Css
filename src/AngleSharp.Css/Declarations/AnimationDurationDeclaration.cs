namespace AngleSharp.Css.Declarations
{
    using AngleSharp.Css.Converters;
    using System;
    using static ValueConverters;

    static class AnimationDurationDeclaration
    {
        public static String Name = PropertyNames.AnimationDuration;

        public static String[] Shorthands = new[]
        {
            PropertyNames.Animation,
        };

        public static IValueConverter Converter = Or(TimeConverter.FromList(), AssignInitial(InitialValues.AnimationDurationDecl));

        public static PropertyFlags Flags = PropertyFlags.None;
    }
}
