#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.NetworkOperators
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class MobileBroadbandAntennaSar 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public int AntennaIndex
		{
			get
			{
				throw new global::System.NotImplementedException("The member int MobileBroadbandAntennaSar.AntennaIndex is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=int%20MobileBroadbandAntennaSar.AntennaIndex");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public int SarBackoffIndex
		{
			get
			{
				throw new global::System.NotImplementedException("The member int MobileBroadbandAntennaSar.SarBackoffIndex is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=int%20MobileBroadbandAntennaSar.SarBackoffIndex");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public MobileBroadbandAntennaSar(int antennaIndex, int sarBackoffIndex) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.NetworkOperators.MobileBroadbandAntennaSar", "MobileBroadbandAntennaSar.MobileBroadbandAntennaSar(int antennaIndex, int sarBackoffIndex)");
		}
#endif
		// Forced skipping of method Windows.Networking.NetworkOperators.MobileBroadbandAntennaSar.MobileBroadbandAntennaSar(int, int)
		// Forced skipping of method Windows.Networking.NetworkOperators.MobileBroadbandAntennaSar.AntennaIndex.get
		// Forced skipping of method Windows.Networking.NetworkOperators.MobileBroadbandAntennaSar.SarBackoffIndex.get
	}
}
