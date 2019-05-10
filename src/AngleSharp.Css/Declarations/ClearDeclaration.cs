namespace AngleSharp.Css.Declarations
{
    using System;
    using static ValueConverters;

    static class ClearDeclaration
    {
        public static String Name = PropertyNames.Clear;

        public static IValueConverter Converter = Or(ClearModeConverter, AssignInitial(InitialValues.ClearDecl));

        public static PropertyFlags Flags = PropertyFlags.None;
    }
}
