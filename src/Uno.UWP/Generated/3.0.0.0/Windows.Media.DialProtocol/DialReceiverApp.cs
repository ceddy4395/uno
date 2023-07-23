#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.DialProtocol
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class DialReceiverApp 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Media.DialProtocol.DialReceiverApp Current
		{
			get
			{
				throw new global::System.NotImplementedException("The member DialReceiverApp DialReceiverApp.Current is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DialReceiverApp%20DialReceiverApp.Current");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IDictionary<string, string>> GetAdditionalDataAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IDictionary<string, string>> DialReceiverApp.GetAdditionalDataAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIDictionary%3Cstring%2C%20string%3E%3E%20DialReceiverApp.GetAdditionalDataAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction SetAdditionalDataAsync(global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, string>> additionalData)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction DialReceiverApp.SetAdditionalDataAsync(IEnumerable<KeyValuePair<string, string>> additionalData) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20DialReceiverApp.SetAdditionalDataAsync%28IEnumerable%3CKeyValuePair%3Cstring%2C%20string%3E%3E%20additionalData%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<string> GetUniqueDeviceNameAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> DialReceiverApp.GetUniqueDeviceNameAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cstring%3E%20DialReceiverApp.GetUniqueDeviceNameAsync%28%29");
		}
#endif
		// Forced skipping of method Windows.Media.DialProtocol.DialReceiverApp.Current.get
	}
}
