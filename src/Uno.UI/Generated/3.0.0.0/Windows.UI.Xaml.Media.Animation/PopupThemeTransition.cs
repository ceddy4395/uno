#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class PopupThemeTransition : global::Windows.UI.Xaml.Media.Animation.Transition
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public double FromVerticalOffset
		{
			get
			{
				return (double)this.GetValue(FromVerticalOffsetProperty);
			}
			set
			{
				this.SetValue(FromVerticalOffsetProperty, value);
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public double FromHorizontalOffset
		{
			get
			{
				return (double)this.GetValue(FromHorizontalOffsetProperty);
			}
			set
			{
				this.SetValue(FromHorizontalOffsetProperty, value);
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty FromHorizontalOffsetProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(FromHorizontalOffset), typeof(double),
			typeof(global::Windows.UI.Xaml.Media.Animation.PopupThemeTransition),
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(double)));
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty FromVerticalOffsetProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(FromVerticalOffset), typeof(double),
			typeof(global::Windows.UI.Xaml.Media.Animation.PopupThemeTransition),
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(double)));
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public PopupThemeTransition() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Animation.PopupThemeTransition", "PopupThemeTransition.PopupThemeTransition()");
		}
#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.PopupThemeTransition.PopupThemeTransition()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.PopupThemeTransition.FromHorizontalOffset.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.PopupThemeTransition.FromHorizontalOffset.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.PopupThemeTransition.FromVerticalOffset.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.PopupThemeTransition.FromVerticalOffset.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.PopupThemeTransition.FromHorizontalOffsetProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.PopupThemeTransition.FromVerticalOffsetProperty.get
	}
}
