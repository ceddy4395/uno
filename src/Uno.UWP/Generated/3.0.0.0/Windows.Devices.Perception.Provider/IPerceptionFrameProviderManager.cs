#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Perception.Provider
{
	// This type is deprecated. Consider not implementing it.
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial interface IPerceptionFrameProviderManager : global::System.IDisposable
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Windows.Devices.Perception.Provider.IPerceptionFrameProvider GetFrameProvider(global::Windows.Devices.Perception.Provider.PerceptionFrameProviderInfo frameProviderInfo);
#endif
	}
}
