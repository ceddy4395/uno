#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.SmartCards
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class SmartCardConnection : global::System.IDisposable
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.Streams.IBuffer> TransmitAsync(global::Windows.Storage.Streams.IBuffer command)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IBuffer> SmartCardConnection.TransmitAsync(IBuffer command) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIBuffer%3E%20SmartCardConnection.TransmitAsync%28IBuffer%20command%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.SmartCards.SmartCardConnection", "void SmartCardConnection.Dispose()");
		}
#endif
		// Processing: System.IDisposable
	}
}
