#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
#endif
	public partial class ToolTipService 
	{
		// Skipping already declared property PlacementProperty
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty PlacementTargetProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.RegisterAttached(
			"PlacementTarget", typeof(global::Windows.UI.Xaml.UIElement),
			typeof(global::Windows.UI.Xaml.Controls.ToolTipService),
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.UIElement)));
#endif
		// Skipping already declared property ToolTipProperty
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTipService.PlacementProperty.get
		// Skipping already declared method Windows.UI.Xaml.Controls.ToolTipService.GetPlacement(Windows.UI.Xaml.DependencyObject)
		// Skipping already declared method Windows.UI.Xaml.Controls.ToolTipService.SetPlacement(Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Controls.Primitives.PlacementMode)
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTipService.PlacementTargetProperty.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.UIElement GetPlacementTarget(global::Windows.UI.Xaml.DependencyObject element)
		{
			return (global::Windows.UI.Xaml.UIElement)element.GetValue(PlacementTargetProperty);
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void SetPlacementTarget(global::Windows.UI.Xaml.DependencyObject element, global::Windows.UI.Xaml.UIElement value)
		{
			element.SetValue(PlacementTargetProperty, value);
		}
#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.ToolTipService.ToolTipProperty.get
		// Skipping already declared method Windows.UI.Xaml.Controls.ToolTipService.GetToolTip(Windows.UI.Xaml.DependencyObject)
		// Skipping already declared method Windows.UI.Xaml.Controls.ToolTipService.SetToolTip(Windows.UI.Xaml.DependencyObject, object)
	}
}
