#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class InkToolbarEraserButton : global::Windows.UI.Xaml.Controls.InkToolbarToolButton
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool IsClearAllVisible
		{
			get
			{
				return (bool)this.GetValue(IsClearAllVisibleProperty);
			}
			set
			{
				this.SetValue(IsClearAllVisibleProperty, value);
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty IsClearAllVisibleProperty { get; } =
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(IsClearAllVisible), typeof(bool),
			typeof(global::Windows.UI.Xaml.Controls.InkToolbarEraserButton),
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public InkToolbarEraserButton() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbarEraserButton", "InkToolbarEraserButton.InkToolbarEraserButton()");
		}
#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarEraserButton.InkToolbarEraserButton()
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarEraserButton.IsClearAllVisible.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarEraserButton.IsClearAllVisible.set
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarEraserButton.IsClearAllVisibleProperty.get
	}
}
