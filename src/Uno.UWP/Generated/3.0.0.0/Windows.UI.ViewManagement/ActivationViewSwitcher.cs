#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.ViewManagement
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class ActivationViewSwitcher 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction ShowAsStandaloneAsync(int viewId)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ActivationViewSwitcher.ShowAsStandaloneAsync(int viewId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20ActivationViewSwitcher.ShowAsStandaloneAsync%28int%20viewId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction ShowAsStandaloneAsync(int viewId, global::Windows.UI.ViewManagement.ViewSizePreference sizePreference)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ActivationViewSwitcher.ShowAsStandaloneAsync(int viewId, ViewSizePreference sizePreference) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20ActivationViewSwitcher.ShowAsStandaloneAsync%28int%20viewId%2C%20ViewSizePreference%20sizePreference%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool IsViewPresentedOnActivationVirtualDesktop(int viewId)
		{
			throw new global::System.NotImplementedException("The member bool ActivationViewSwitcher.IsViewPresentedOnActivationVirtualDesktop(int viewId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20ActivationViewSwitcher.IsViewPresentedOnActivationVirtualDesktop%28int%20viewId%29");
		}
#endif
	}
}
