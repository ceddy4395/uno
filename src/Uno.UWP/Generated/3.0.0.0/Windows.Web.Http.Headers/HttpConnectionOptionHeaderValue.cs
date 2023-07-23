#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Web.Http.Headers
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class HttpConnectionOptionHeaderValue : global::Windows.Foundation.IStringable
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string Token
		{
			get
			{
				throw new global::System.NotImplementedException("The member string HttpConnectionOptionHeaderValue.Token is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20HttpConnectionOptionHeaderValue.Token");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public HttpConnectionOptionHeaderValue(string token) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Web.Http.Headers.HttpConnectionOptionHeaderValue", "HttpConnectionOptionHeaderValue.HttpConnectionOptionHeaderValue(string token)");
		}
#endif
		// Forced skipping of method Windows.Web.Http.Headers.HttpConnectionOptionHeaderValue.HttpConnectionOptionHeaderValue(string)
		// Forced skipping of method Windows.Web.Http.Headers.HttpConnectionOptionHeaderValue.Token.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public override string ToString()
		{
			throw new global::System.NotImplementedException("The member string HttpConnectionOptionHeaderValue.ToString() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20HttpConnectionOptionHeaderValue.ToString%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Web.Http.Headers.HttpConnectionOptionHeaderValue Parse(string input)
		{
			throw new global::System.NotImplementedException("The member HttpConnectionOptionHeaderValue HttpConnectionOptionHeaderValue.Parse(string input) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=HttpConnectionOptionHeaderValue%20HttpConnectionOptionHeaderValue.Parse%28string%20input%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool TryParse(string input, out global::Windows.Web.Http.Headers.HttpConnectionOptionHeaderValue connectionOptionHeaderValue)
		{
			throw new global::System.NotImplementedException("The member bool HttpConnectionOptionHeaderValue.TryParse(string input, out HttpConnectionOptionHeaderValue connectionOptionHeaderValue) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20HttpConnectionOptionHeaderValue.TryParse%28string%20input%2C%20out%20HttpConnectionOptionHeaderValue%20connectionOptionHeaderValue%29");
		}
#endif
	}
}
