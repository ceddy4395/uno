#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.PushNotifications
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class PushNotificationChannelManagerForUser 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.System.User User
		{
			get
			{
				throw new global::System.NotImplementedException("The member User PushNotificationChannelManagerForUser.User is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=User%20PushNotificationChannelManagerForUser.User");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Networking.PushNotifications.PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<PushNotificationChannel> PushNotificationChannelManagerForUser.CreatePushNotificationChannelForApplicationAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CPushNotificationChannel%3E%20PushNotificationChannelManagerForUser.CreatePushNotificationChannelForApplicationAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Networking.PushNotifications.PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync(string applicationId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<PushNotificationChannel> PushNotificationChannelManagerForUser.CreatePushNotificationChannelForApplicationAsync(string applicationId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CPushNotificationChannel%3E%20PushNotificationChannelManagerForUser.CreatePushNotificationChannelForApplicationAsync%28string%20applicationId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Networking.PushNotifications.PushNotificationChannel> CreatePushNotificationChannelForSecondaryTileAsync(string tileId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<PushNotificationChannel> PushNotificationChannelManagerForUser.CreatePushNotificationChannelForSecondaryTileAsync(string tileId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CPushNotificationChannel%3E%20PushNotificationChannelManagerForUser.CreatePushNotificationChannelForSecondaryTileAsync%28string%20tileId%29");
		}
#endif
		// Forced skipping of method Windows.Networking.PushNotifications.PushNotificationChannelManagerForUser.User.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Networking.PushNotifications.PushNotificationChannel> CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync(global::Windows.Storage.Streams.IBuffer appServerKey, string channelId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<PushNotificationChannel> PushNotificationChannelManagerForUser.CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync(IBuffer appServerKey, string channelId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CPushNotificationChannel%3E%20PushNotificationChannelManagerForUser.CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync%28IBuffer%20appServerKey%2C%20string%20channelId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Networking.PushNotifications.PushNotificationChannel> CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync(global::Windows.Storage.Streams.IBuffer appServerKey, string channelId, string appId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<PushNotificationChannel> PushNotificationChannelManagerForUser.CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync(IBuffer appServerKey, string channelId, string appId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CPushNotificationChannel%3E%20PushNotificationChannelManagerForUser.CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync%28IBuffer%20appServerKey%2C%20string%20channelId%2C%20string%20appId%29");
		}
#endif
	}
}
