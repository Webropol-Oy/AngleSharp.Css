namespace AngleSharp.Css
{
    using AngleSharp.Css.Dom;
    using AngleSharp.Css.Values;
    using AngleSharp.Dom;
    using System;

    /// <summary>
    /// A collection of initial values for the respective CSS declarations.
    /// </summary>
    static class InitialValues
    {
        public static readonly ICssValue ColorDecl = Color.Black;
        public static readonly ICssValue BackgroundColorDecl = Color.Transparent;
        public static readonly ICssValue BackgroundImageDecl = new Constant<Object>(CssKeywords.None, null);
        public static readonly ICssValue BackgroundRepeatHorizontalDecl = new Identifier(CssKeywords.Repeat);
        public static readonly ICssValue BackgroundRepeatVerticalDecl = new Identifier(CssKeywords.Repeat);
        public static readonly ICssValue BackgroundRepeatDecl = new CssImageRepeatsValue(BackgroundRepeatHorizontalDecl, BackgroundRepeatVerticalDecl);
        public static readonly ICssValue BackgroundPositionXDecl = new Length(0, Length.Unit.Percent);
        public static readonly ICssValue BackgroundPositionYDecl = new Length(0, Length.Unit.Percent);
        public static readonly ICssValue BackgroundPositionDecl = new CssTupleValue(new [] { BackgroundPositionXDecl, BackgroundPositionYDecl });
        public static readonly ICssValue BackgroundSizeDecl = new CssBackgroundSizeValue(new Constant<Length>(CssKeywords.Auto, Length.Auto), new Constant<Length>(CssKeywords.Auto, Length.Auto));
        public static readonly ICssValue BackgroundOriginDecl = new Constant<BoxModel>(CssKeywords.BorderBox, BoxModel.PaddingBox);
        public static readonly ICssValue BackgroundClipDecl = new Constant<BoxModel>(CssKeywords.BorderBox, BoxModel.BorderBox);
        public static readonly ICssValue BackgroundAttachmentDecl = new Constant<BackgroundAttachment>(CssKeywords.Scroll, BackgroundAttachment.Scroll);
        public static readonly ICssValue FontStyleDecl = new Constant<FontStyle>(CssKeywords.Normal, FontStyle.Normal);
        public static readonly ICssValue FontVariantDecl = new Constant<FontVariant>(CssKeywords.Normal, FontVariant.Normal);
        public static readonly ICssValue FontWeightDecl = new Constant<FontWeight>(CssKeywords.Normal, FontWeight.Normal);
        public static readonly ICssValue FontStretchDecl = new Constant<FontStretch>(CssKeywords.Normal, FontStretch.Normal);
        public static readonly ICssValue FontSizeDecl = new Constant<Length>(CssKeywords.Medium, Length.Medium);
        public static readonly ICssValue FontFamilyDecl = new Label("Times New Roman");
        public static readonly ICssValue LineHeightDecl = new Constant<Length>(CssKeywords.Normal, Length.Normal);
        public static readonly ICssValue BorderTopWidthDecl = new Constant<Length>(CssKeywords.Medium, Length.Medium);
        public static readonly ICssValue BorderRightWidthDecl = new Constant<Length>(CssKeywords.Medium, Length.Medium);
        public static readonly ICssValue BorderBottomWidthDecl = new Constant<Length>(CssKeywords.Medium, Length.Medium);
        public static readonly ICssValue BorderLeftWidthDecl = new Constant<Length>(CssKeywords.Medium, Length.Medium);
        public static readonly ICssValue BorderTopStyleDecl = new Constant<LineStyle>(CssKeywords.None, LineStyle.None);
        public static readonly ICssValue BorderRightStyleDecl = new Constant<LineStyle>(CssKeywords.None, LineStyle.None);
        public static readonly ICssValue BorderBottomStyleDecl = new Constant<LineStyle>(CssKeywords.None, LineStyle.None);
        public static readonly ICssValue BorderLeftStyleDecl = new Constant<LineStyle>(CssKeywords.None, LineStyle.None);
        public static readonly ICssValue BorderTopColorDecl = new Constant<Color>(CssKeywords.CurrentColor, Color.CurrentColor);
        public static readonly ICssValue BorderRightColorDecl = new Constant<Color>(CssKeywords.CurrentColor, Color.CurrentColor);
        public static readonly ICssValue BorderBottomColorDecl = new Constant<Color>(CssKeywords.CurrentColor, Color.CurrentColor);
        public static readonly ICssValue BorderLeftColorDecl = new Constant<Color>(CssKeywords.CurrentColor, Color.CurrentColor);
        public static readonly ICssValue ColumnWidthDecl = new Constant<Length>(CssKeywords.Auto, Length.Auto);
        public static readonly ICssValue ColumnCountDecl = new Constant<Length>(CssKeywords.Auto, Length.Auto);
        public static readonly ICssValue ColumnRuleWidthDecl = new Constant<Length>(CssKeywords.Medium, Length.Medium);
        public static readonly ICssValue ColumnRuleStyleDecl = new Constant<LineStyle>(CssKeywords.None, LineStyle.None);
        public static readonly ICssValue ColumnRuleColorDecl = new Constant<Color>(CssKeywords.CurrentColor, Color.CurrentColor);
        public static readonly ICssValue AnimationNameDecl = new Constant<Object>(CssKeywords.None, null);
        public static readonly ICssValue AnimationDurationDecl = Time.Zero;
        public static readonly ICssValue AnimationTimingFunctionDecl = CssCubicBezierValue.Ease;
        public static readonly ICssValue AnimationDelayDecl = Time.Zero;
        public static readonly ICssValue AnimationIterationCountDecl = new Length(1, Length.Unit.None);
        public static readonly ICssValue AnimationDirectionDecl = new Constant<AnimationDirection>(CssKeywords.Normal, AnimationDirection.Normal);
        public static readonly ICssValue AnimationFillModeDecl = new Constant<AnimationFillStyle>(CssKeywords.None, AnimationFillStyle.None);
        public static readonly ICssValue AnimationPlayStateDecl = new Constant<PlayState>(CssKeywords.Running, PlayState.Running);
        public static readonly ICssValue TransitionDelayDecl = Time.Zero;
        public static readonly ICssValue TransitionDurationDecl = Time.Zero;
        public static readonly ICssValue TransitionPropertyDecl = new Identifier(CssKeywords.All);
        public static readonly ICssValue TransitionTimingFunctionDecl = CssCubicBezierValue.Ease;
        public static readonly ICssValue DirectionDecl = new Constant<DirectionMode>(CssKeywords.Ltr, DirectionMode.Ltr);
        public static readonly ICssValue EmptyCellsDecl = new Constant<Boolean>(CssKeywords.Show, true);
        public static readonly ICssValue FlexGrowDecl = new Length(0, Length.Unit.None);
        public static readonly ICssValue FlexShrinkDecl = new Length(1, Length.Unit.None);
        public static readonly ICssValue FlexBasisDecl = new Constant<Length>(CssKeywords.Auto, Length.Auto);
        public static readonly ICssValue FlexWrapDecl = new Constant<FlexWrapMode>(CssKeywords.Nowrap, FlexWrapMode.NoWrap);
        public static readonly ICssValue FlexDirectionDecl = new Constant<FlexDirection>(CssKeywords.Row, FlexDirection.Row);
        public static readonly ICssValue FloatDecl = new Constant<Floating>(CssKeywords.None, Floating.None);
        public static readonly ICssValue BorderSpacingDecl = Length.Zero;
        public static readonly ICssValue BoxDecorationBreakDecl = new Constant<Boolean>(CssKeywords.Slice, false);
        public static readonly ICssValue BoxShadowDecl = new Constant<Object>(CssKeywords.None, null);
        public static readonly ICssValue BoxSizingDecl = new Constant<BoxModel>(CssKeywords.ContentBox, BoxModel.ContentBox);
        public static readonly ICssValue BreakAfterDecl = new Constant<BreakMode>(CssKeywords.Auto, BreakMode.Auto);
        public static readonly ICssValue BreakBeforeDecl = new Constant<BreakMode>(CssKeywords.Auto, BreakMode.Auto);
        public static readonly ICssValue BreakInsideDecl = new Constant<BreakMode>(CssKeywords.Auto, BreakMode.Auto);
        public static readonly ICssValue PageBreakInsideDecl = new Constant<BreakMode>(CssKeywords.Auto, BreakMode.Auto);
        public static readonly ICssValue PageBreakBeforeDecl = new Constant<BreakMode>(CssKeywords.Auto, BreakMode.Auto);
        public static readonly ICssValue PageBreakAfterDecl = new Constant<BreakMode>(CssKeywords.Auto, BreakMode.Auto);
        public static readonly ICssValue BottomDecl = new Constant<Length>(CssKeywords.Auto, Length.Auto);
        public static readonly ICssValue TopDecl = new Constant<Length>(CssKeywords.Auto, Length.Auto);
        public static readonly ICssValue LeftDecl = new Constant<Length>(CssKeywords.Auto, Length.Auto);
        public static readonly ICssValue RightDecl = new Constant<Length>(CssKeywords.Auto, Length.Auto);
        public static readonly ICssValue MinHeightDecl = new Constant<Length>(CssKeywords.Auto, Length.Auto);
        public static readonly ICssValue MinWidthDecl = new Constant<Length>(CssKeywords.Auto, Length.Auto);
        public static readonly ICssValue MaxHeightDecl = new Constant<Object>(CssKeywords.None, null);
        public static readonly ICssValue MaxWidthDecl = new Constant<Object>(CssKeywords.None, null);
        public static readonly ICssValue MarginLeftDecl = Length.Zero;
        public static readonly ICssValue MarginBottomDecl = Length.Zero;
        public static readonly ICssValue MarginRightDecl = Length.Zero;
        public static readonly ICssValue MarginTopDecl = Length.Zero;
        public static readonly ICssValue PaddingLeftDecl = Length.Zero;
        public static readonly ICssValue PaddingBottomDecl = Length.Zero;
        public static readonly ICssValue PaddingRightDecl = Length.Zero;
        public static readonly ICssValue PaddingTopDecl = Length.Zero;
        public static readonly ICssValue CaptionSideDecl = new Constant<Boolean>(CssKeywords.Top, true);
        public static readonly ICssValue CursorDecl = new Constant<SystemCursor>(CssKeywords.Auto, SystemCursor.Auto);
        public static readonly ICssValue OverflowWrapDecl = new Constant<OverflowWrap>(CssKeywords.Normal, OverflowWrap.Normal);
        public static readonly ICssValue WordSpacingDecl = new Constant<Length>(CssKeywords.Normal, Length.Normal);
        public static readonly ICssValue WordBreakDecl = new Constant<WordBreak>(CssKeywords.Normal, WordBreak.Normal);
        public static readonly ICssValue VisibilityDecl = new Constant<Visibility>(CssKeywords.Visible, Visibility.Visible);
        public static readonly ICssValue VerticalAlignDecl = new Constant<VerticalAlignment>(CssKeywords.Baseline, VerticalAlignment.Baseline);
        public static readonly ICssValue OpacityDecl = new Length(1.0, Length.Unit.None);
        public static readonly ICssValue OverflowDecl = new Constant<OverflowMode>(CssKeywords.Visible, OverflowMode.Visible);
        public static readonly ICssValue OutlineWidthDecl = new Constant<Length>(CssKeywords.Medium, Length.Medium);
        public static readonly ICssValue OutlineStyleDecl = new Constant<LineStyle>(CssKeywords.None, LineStyle.None);
        public static readonly ICssValue OutlineColorDecl = new Constant<Color>(CssKeywords.Invert, Color.InvertedColor);
        public static readonly ICssValue TextTransformDecl = new Constant<Object>(CssKeywords.None, null);
        public static readonly ICssValue TextShadowDecl = new Constant<Object>(CssKeywords.None, null);
        public static readonly ICssValue TextRenderingDecl = new Constant<Object>(CssKeywords.Auto, null);
        public static readonly ICssValue TextOverflowDecl = new Constant<OverflowMode>(CssKeywords.Auto, OverflowMode.Clip);
        public static readonly ICssValue TextOrientationDecl = new Constant<Object>(CssKeywords.Mixed, null);
        public static readonly ICssValue TextJustifyDecl = new Constant<TextJustify>(CssKeywords.Auto, TextJustify.Auto);
        public static readonly ICssValue TextIndentDecl = Length.Zero;
        public static readonly ICssValue TextAlignDecl = new Constant<HorizontalAlignment>(CssKeywords.Left, HorizontalAlignment.Left);
        public static readonly ICssValue TextAlignLastDecl = new Constant<TextAlignLast>(CssKeywords.Auto, TextAlignLast.Auto);
        public static readonly ICssValue TextDecorationLineDecl = new Constant<Object>(CssKeywords.None, null);
        public static readonly ICssValue TextDecorationStyleDecl = new Constant<LineStyle>(CssKeywords.Solid, LineStyle.Solid);
        public static readonly ICssValue TextDecorationColorDecl = new Constant<Color>(CssKeywords.CurrentColor, Color.CurrentColor);
        public static readonly ICssValue ListStyleTypeDecl = new Constant<ListStyle>(CssKeywords.Disc, ListStyle.Disc);
        public static readonly ICssValue ListStylePositionDecl = new Constant<ListPosition>(CssKeywords.Outside, ListPosition.Outside);
        public static readonly ICssValue ListStyleImageDecl = new Constant<Object>(CssKeywords.None, null);
        public static readonly ICssValue LineBreakDecl = new Constant<BreakMode>(CssKeywords.Auto, BreakMode.Auto);
        public static readonly ICssValue GridTemplateRowsDecl = new Constant<Object>(CssKeywords.None, null);
        public static readonly ICssValue GridTemplateColumnsDecl = new Constant<Object>(CssKeywords.None, null);
        public static readonly ICssValue GridTemplateAreasDecl = new Constant<Object>(CssKeywords.None, null);
        public static readonly ICssValue GridAutoRowsDecl = new Constant<Object>(CssKeywords.Auto, null);
        public static readonly ICssValue GridAutoColumnsDecl = new Constant<Object>(CssKeywords.Auto, null);
        public static readonly ICssValue GridAutoFlowDecl = new Constant<Boolean>(CssKeywords.Row, false);
        public static readonly ICssValue GridColumnGapDecl = Length.Zero;
        public static readonly ICssValue GridRowGapDecl = Length.Zero;
        public static readonly ICssValue ColumnGapDecl = new Constant<Length>(CssKeywords.Normal, Length.Normal);
        public static readonly ICssValue RowGapDecl = new Constant<Length>(CssKeywords.Normal, Length.Normal);
        public static readonly ICssValue PerspectiveDecl = new Constant<Object>(CssKeywords.None, null);
        public static readonly ICssValue PositionDecl = new Constant<PositionMode>(CssKeywords.Inline, PositionMode.Static);
        public static readonly ICssValue TransformDecl = new Constant<Object>(CssKeywords.None, null);
        public static readonly ICssValue TransformStyleDecl = new Constant<Boolean>(CssKeywords.Flat, true);
        public static readonly ICssValue TableLayoutDecl = new Constant<Boolean>(CssKeywords.Auto, false);
        public static readonly ICssValue ClearDecl = new Constant<ClearMode>(CssKeywords.None, ClearMode.None);
        public static readonly ICssValue ClipDecl = new Constant<Length>(CssKeywords.Auto, Length.Auto);
        public static readonly ICssValue StrokeOpacityDecl = new Length(1, Length.Unit.None);
        public static readonly ICssValue StrokeLinecapDecl = new Constant<StrokeLinecap>(CssKeywords.Butt, StrokeLinecap.Butt);
        public static readonly ICssValue RubyPositionDecl = new Constant<RubyPosition>(CssKeywords.Over, RubyPosition.Over);
        public static readonly ICssValue RubyOverhangDecl = new Constant<RubyOverhangMode>(CssKeywords.None, RubyOverhangMode.None);
        public static readonly ICssValue RubyAlignDecl = new Constant<RubyAlignment>(CssKeywords.SpaceAround, RubyAlignment.SpaceAround);
        public static readonly ICssValue QuotesDecl = new Quote("«", "»");
        public static readonly ICssValue PointerEventsDecl = new Constant<PointerEvent>(CssKeywords.Auto, PointerEvent.Auto);
        public static readonly ICssValue ContentDecl = new Constant<Object>(CssKeywords.Normal, null);
        public static readonly ICssValue CounterIncrementDecl = new Constant<Object>(CssKeywords.None, null);
        public static readonly ICssValue CounterResetDecl = new Constant<Object>(CssKeywords.None, null);
        public static readonly ICssValue DisplayDecl = new Constant<DisplayMode>(CssKeywords.Inline, DisplayMode.Inline);
        public static readonly ICssValue ColumnFillDecl = new Constant<Boolean>(CssKeywords.Balance, true);
        public static readonly ICssValue ColumnSpanDecl = new Constant<Boolean>(CssKeywords.None, false);
        public static readonly ICssValue BackfaceVisibilityDecl = new Constant<Visibility>(CssKeywords.Visible, Visibility.Visible);
        public static readonly ICssValue BorderImageSourceDecl = new Constant<Object>(CssKeywords.None, null);
        public static readonly ICssValue BorderImageSliceDecl = Length.Full;
        public static readonly ICssValue BorderImageWidthDecl = new Length(1, Length.Unit.None);
        public static readonly ICssValue BorderImageOutsetDecl = Length.Zero;
        public static readonly ICssValue BorderImageRepeatDecl = new Constant<BorderRepeat>(CssKeywords.Stretch, BorderRepeat.Stretch);
        public static readonly ICssValue BorderCollapseDecl = new Constant<Boolean>(CssKeywords.Separate, true);
        public static readonly ICssValue AlignSelfDecl = new Constant<FlexContentMode>(CssKeywords.Auto, FlexContentMode.Auto);
        public static readonly ICssValue AlignItemsDecl = new Constant<FlexContentMode>(CssKeywords.Normal, FlexContentMode.Stretch);
        public static readonly ICssValue AlignContentDecl = new Constant<FlexContentMode>(CssKeywords.Normal, FlexContentMode.Stretch);
        public static readonly ICssValue JustifyContentDecl = new Constant<Object>(CssKeywords.Normal, null);
        public static readonly ICssValue JustifyItemsDecl = new Constant<Object>(CssKeywords.Legacy, null);
        public static readonly ICssValue JustifySelfDecl = new Constant<FlexContentMode>(CssKeywords.Auto, FlexContentMode.Auto);
        public static readonly ICssValue UnicodeBidiDecl = new Constant<UnicodeMode>(CssKeywords.Normal, UnicodeMode.Normal);
        public static readonly ICssValue WidowsDecl = new Length(2, Length.Unit.None);
        public static readonly ICssValue OrphansDecl = new Length(2, Length.Unit.None);
        public static readonly ICssValue OrderDecl = new Length(0, Length.Unit.None);
        public static readonly ICssValue ObjectFitDecl = new Constant<ObjectFitting>(CssKeywords.Fill, ObjectFitting.Fill);
        public static readonly ICssValue WhiteSpaceDecl = new Constant<Whitespace>(CssKeywords.Normal, Whitespace.Normal);
        public static readonly ICssValue ZIndexDecl = new Constant<Length>(CssKeywords.Auto, Length.Auto);
    }
}
