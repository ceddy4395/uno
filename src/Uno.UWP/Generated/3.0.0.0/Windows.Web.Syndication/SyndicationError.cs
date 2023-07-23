#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Web.Syndication
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public static partial class SyndicationError 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Web.Syndication.SyndicationErrorStatus GetStatus(int hresult)
		{
			throw new global::System.NotImplementedException("The member SyndicationErrorStatus SyndicationError.GetStatus(int hresult) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SyndicationErrorStatus%20SyndicationError.GetStatus%28int%20hresult%29");
		}
#endif
	}
}
