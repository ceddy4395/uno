#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Credentials.UI
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public static partial class UserConsentVerifier 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Security.Credentials.UI.UserConsentVerifierAvailability> CheckAvailabilityAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<UserConsentVerifierAvailability> UserConsentVerifier.CheckAvailabilityAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CUserConsentVerifierAvailability%3E%20UserConsentVerifier.CheckAvailabilityAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Security.Credentials.UI.UserConsentVerificationResult> RequestVerificationAsync(string message)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<UserConsentVerificationResult> UserConsentVerifier.RequestVerificationAsync(string message) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CUserConsentVerificationResult%3E%20UserConsentVerifier.RequestVerificationAsync%28string%20message%29");
		}
#endif
	}
}
