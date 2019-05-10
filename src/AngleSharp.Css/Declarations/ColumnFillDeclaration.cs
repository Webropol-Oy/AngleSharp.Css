namespace AngleSharp.Css.Declarations
{
    using System;
    using static ValueConverters;

    static class ColumnFillDeclaration
    {
        public static String Name = PropertyNames.ColumnFill;

        public static IValueConverter Converter = Or(ColumnFillConverter, AssignInitial(InitialValues.ColumnFillDecl));

        public static PropertyFlags Flags = PropertyFlags.Animatable;
    }
}
