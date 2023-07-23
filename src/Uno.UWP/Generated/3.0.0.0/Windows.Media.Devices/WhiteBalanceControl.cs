#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Devices
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class WhiteBalanceControl 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint Max
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint WhiteBalanceControl.Max is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20WhiteBalanceControl.Max");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint Min
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint WhiteBalanceControl.Min is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20WhiteBalanceControl.Min");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.Devices.ColorTemperaturePreset Preset
		{
			get
			{
				throw new global::System.NotImplementedException("The member ColorTemperaturePreset WhiteBalanceControl.Preset is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ColorTemperaturePreset%20WhiteBalanceControl.Preset");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint Step
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint WhiteBalanceControl.Step is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20WhiteBalanceControl.Step");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool Supported
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool WhiteBalanceControl.Supported is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20WhiteBalanceControl.Supported");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint WhiteBalanceControl.Value is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20WhiteBalanceControl.Value");
			}
		}
#endif
		// Forced skipping of method Windows.Media.Devices.WhiteBalanceControl.Supported.get
		// Forced skipping of method Windows.Media.Devices.WhiteBalanceControl.Preset.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction SetPresetAsync(global::Windows.Media.Devices.ColorTemperaturePreset preset)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WhiteBalanceControl.SetPresetAsync(ColorTemperaturePreset preset) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20WhiteBalanceControl.SetPresetAsync%28ColorTemperaturePreset%20preset%29");
		}
#endif
		// Forced skipping of method Windows.Media.Devices.WhiteBalanceControl.Min.get
		// Forced skipping of method Windows.Media.Devices.WhiteBalanceControl.Max.get
		// Forced skipping of method Windows.Media.Devices.WhiteBalanceControl.Step.get
		// Forced skipping of method Windows.Media.Devices.WhiteBalanceControl.Value.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction SetValueAsync(uint temperature)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WhiteBalanceControl.SetValueAsync(uint temperature) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20WhiteBalanceControl.SetValueAsync%28uint%20temperature%29");
		}
#endif
	}
}
