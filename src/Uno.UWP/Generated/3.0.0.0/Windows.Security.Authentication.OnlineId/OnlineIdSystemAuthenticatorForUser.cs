#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Authentication.OnlineId
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class OnlineIdSystemAuthenticatorForUser 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Guid ApplicationId
		{
			get
			{
				throw new global::System.NotImplementedException("The member Guid OnlineIdSystemAuthenticatorForUser.ApplicationId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Guid%20OnlineIdSystemAuthenticatorForUser.ApplicationId");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Security.Authentication.OnlineId.OnlineIdSystemAuthenticatorForUser", "Guid OnlineIdSystemAuthenticatorForUser.ApplicationId");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.System.User User
		{
			get
			{
				throw new global::System.NotImplementedException("The member User OnlineIdSystemAuthenticatorForUser.User is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=User%20OnlineIdSystemAuthenticatorForUser.User");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Security.Authentication.OnlineId.OnlineIdSystemTicketResult> GetTicketAsync(global::Windows.Security.Authentication.OnlineId.OnlineIdServiceTicketRequest request)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<OnlineIdSystemTicketResult> OnlineIdSystemAuthenticatorForUser.GetTicketAsync(OnlineIdServiceTicketRequest request) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3COnlineIdSystemTicketResult%3E%20OnlineIdSystemAuthenticatorForUser.GetTicketAsync%28OnlineIdServiceTicketRequest%20request%29");
		}
#endif
		// Forced skipping of method Windows.Security.Authentication.OnlineId.OnlineIdSystemAuthenticatorForUser.ApplicationId.set
		// Forced skipping of method Windows.Security.Authentication.OnlineId.OnlineIdSystemAuthenticatorForUser.ApplicationId.get
		// Forced skipping of method Windows.Security.Authentication.OnlineId.OnlineIdSystemAuthenticatorForUser.User.get
	}
}
