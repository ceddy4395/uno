#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Playback
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class PlaybackMediaMarker 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string MediaMarkerType
		{
			get
			{
				throw new global::System.NotImplementedException("The member string PlaybackMediaMarker.MediaMarkerType is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20PlaybackMediaMarker.MediaMarkerType");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string Text
		{
			get
			{
				throw new global::System.NotImplementedException("The member string PlaybackMediaMarker.Text is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20PlaybackMediaMarker.Text");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.TimeSpan Time
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan PlaybackMediaMarker.Time is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=TimeSpan%20PlaybackMediaMarker.Time");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public PlaybackMediaMarker(global::System.TimeSpan value) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.PlaybackMediaMarker", "PlaybackMediaMarker.PlaybackMediaMarker(TimeSpan value)");
		}
#endif
		// Forced skipping of method Windows.Media.Playback.PlaybackMediaMarker.PlaybackMediaMarker(System.TimeSpan)
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public PlaybackMediaMarker(global::System.TimeSpan value, string mediaMarketType, string text) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.PlaybackMediaMarker", "PlaybackMediaMarker.PlaybackMediaMarker(TimeSpan value, string mediaMarketType, string text)");
		}
#endif
		// Forced skipping of method Windows.Media.Playback.PlaybackMediaMarker.PlaybackMediaMarker(System.TimeSpan, string, string)
		// Forced skipping of method Windows.Media.Playback.PlaybackMediaMarker.Time.get
		// Forced skipping of method Windows.Media.Playback.PlaybackMediaMarker.MediaMarkerType.get
		// Forced skipping of method Windows.Media.Playback.PlaybackMediaMarker.Text.get
	}
}
