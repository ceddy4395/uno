#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Chat
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class ChatSyncManager 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Chat.ChatSyncConfiguration Configuration
		{
			get
			{
				throw new global::System.NotImplementedException("The member ChatSyncConfiguration ChatSyncManager.Configuration is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ChatSyncConfiguration%20ChatSyncManager.Configuration");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Chat.ChatSyncManager.Configuration.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction AssociateAccountAsync(global::Windows.Security.Credentials.WebAccount webAccount)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ChatSyncManager.AssociateAccountAsync(WebAccount webAccount) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20ChatSyncManager.AssociateAccountAsync%28WebAccount%20webAccount%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction UnassociateAccountAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ChatSyncManager.UnassociateAccountAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20ChatSyncManager.UnassociateAccountAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool IsAccountAssociated(global::Windows.Security.Credentials.WebAccount webAccount)
		{
			throw new global::System.NotImplementedException("The member bool ChatSyncManager.IsAccountAssociated(WebAccount webAccount) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20ChatSyncManager.IsAccountAssociated%28WebAccount%20webAccount%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void StartSync()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Chat.ChatSyncManager", "void ChatSyncManager.StartSync()");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction SetConfigurationAsync(global::Windows.ApplicationModel.Chat.ChatSyncConfiguration configuration)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ChatSyncManager.SetConfigurationAsync(ChatSyncConfiguration configuration) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20ChatSyncManager.SetConfigurationAsync%28ChatSyncConfiguration%20configuration%29");
		}
#endif
	}
}
