#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class RadialControllerMenu 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool IsEnabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool RadialControllerMenu.IsEnabled is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20RadialControllerMenu.IsEnabled");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Input.RadialControllerMenu", "bool RadialControllerMenu.IsEnabled");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IList<global::Windows.UI.Input.RadialControllerMenuItem> Items
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<RadialControllerMenuItem> RadialControllerMenu.Items is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IList%3CRadialControllerMenuItem%3E%20RadialControllerMenu.Items");
			}
		}
#endif
		// Forced skipping of method Windows.UI.Input.RadialControllerMenu.Items.get
		// Forced skipping of method Windows.UI.Input.RadialControllerMenu.IsEnabled.get
		// Forced skipping of method Windows.UI.Input.RadialControllerMenu.IsEnabled.set
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.UI.Input.RadialControllerMenuItem GetSelectedMenuItem()
		{
			throw new global::System.NotImplementedException("The member RadialControllerMenuItem RadialControllerMenu.GetSelectedMenuItem() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=RadialControllerMenuItem%20RadialControllerMenu.GetSelectedMenuItem%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void SelectMenuItem(global::Windows.UI.Input.RadialControllerMenuItem menuItem)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Input.RadialControllerMenu", "void RadialControllerMenu.SelectMenuItem(RadialControllerMenuItem menuItem)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool TrySelectPreviouslySelectedMenuItem()
		{
			throw new global::System.NotImplementedException("The member bool RadialControllerMenu.TrySelectPreviouslySelectedMenuItem() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20RadialControllerMenu.TrySelectPreviouslySelectedMenuItem%28%29");
		}
#endif
	}
}
