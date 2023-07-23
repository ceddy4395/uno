#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Web.Http.Headers
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class HttpCookiePairHeaderValue : global::Windows.Foundation.IStringable
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member string HttpCookiePairHeaderValue.Value is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20HttpCookiePairHeaderValue.Value");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Web.Http.Headers.HttpCookiePairHeaderValue", "string HttpCookiePairHeaderValue.Value");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string HttpCookiePairHeaderValue.Name is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20HttpCookiePairHeaderValue.Name");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public HttpCookiePairHeaderValue(string name) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Web.Http.Headers.HttpCookiePairHeaderValue", "HttpCookiePairHeaderValue.HttpCookiePairHeaderValue(string name)");
		}
#endif
		// Forced skipping of method Windows.Web.Http.Headers.HttpCookiePairHeaderValue.HttpCookiePairHeaderValue(string)
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public HttpCookiePairHeaderValue(string name, string value) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Web.Http.Headers.HttpCookiePairHeaderValue", "HttpCookiePairHeaderValue.HttpCookiePairHeaderValue(string name, string value)");
		}
#endif
		// Forced skipping of method Windows.Web.Http.Headers.HttpCookiePairHeaderValue.HttpCookiePairHeaderValue(string, string)
		// Forced skipping of method Windows.Web.Http.Headers.HttpCookiePairHeaderValue.Name.get
		// Forced skipping of method Windows.Web.Http.Headers.HttpCookiePairHeaderValue.Value.get
		// Forced skipping of method Windows.Web.Http.Headers.HttpCookiePairHeaderValue.Value.set
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public override string ToString()
		{
			throw new global::System.NotImplementedException("The member string HttpCookiePairHeaderValue.ToString() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20HttpCookiePairHeaderValue.ToString%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Web.Http.Headers.HttpCookiePairHeaderValue Parse(string input)
		{
			throw new global::System.NotImplementedException("The member HttpCookiePairHeaderValue HttpCookiePairHeaderValue.Parse(string input) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=HttpCookiePairHeaderValue%20HttpCookiePairHeaderValue.Parse%28string%20input%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool TryParse(string input, out global::Windows.Web.Http.Headers.HttpCookiePairHeaderValue cookiePairHeaderValue)
		{
			throw new global::System.NotImplementedException("The member bool HttpCookiePairHeaderValue.TryParse(string input, out HttpCookiePairHeaderValue cookiePairHeaderValue) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20HttpCookiePairHeaderValue.TryParse%28string%20input%2C%20out%20HttpCookiePairHeaderValue%20cookiePairHeaderValue%29");
		}
#endif
	}
}
