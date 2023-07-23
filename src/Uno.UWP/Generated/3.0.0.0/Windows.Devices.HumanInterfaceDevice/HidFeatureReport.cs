#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.HumanInterfaceDevice
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class HidFeatureReport 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Storage.Streams.IBuffer Data
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBuffer HidFeatureReport.Data is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IBuffer%20HidFeatureReport.Data");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.HumanInterfaceDevice.HidFeatureReport", "IBuffer HidFeatureReport.Data");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ushort Id
		{
			get
			{
				throw new global::System.NotImplementedException("The member ushort HidFeatureReport.Id is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ushort%20HidFeatureReport.Id");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.HumanInterfaceDevice.HidFeatureReport.Id.get
		// Forced skipping of method Windows.Devices.HumanInterfaceDevice.HidFeatureReport.Data.get
		// Forced skipping of method Windows.Devices.HumanInterfaceDevice.HidFeatureReport.Data.set
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Devices.HumanInterfaceDevice.HidBooleanControl GetBooleanControl(ushort usagePage, ushort usageId)
		{
			throw new global::System.NotImplementedException("The member HidBooleanControl HidFeatureReport.GetBooleanControl(ushort usagePage, ushort usageId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=HidBooleanControl%20HidFeatureReport.GetBooleanControl%28ushort%20usagePage%2C%20ushort%20usageId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Devices.HumanInterfaceDevice.HidBooleanControl GetBooleanControlByDescription(global::Windows.Devices.HumanInterfaceDevice.HidBooleanControlDescription controlDescription)
		{
			throw new global::System.NotImplementedException("The member HidBooleanControl HidFeatureReport.GetBooleanControlByDescription(HidBooleanControlDescription controlDescription) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=HidBooleanControl%20HidFeatureReport.GetBooleanControlByDescription%28HidBooleanControlDescription%20controlDescription%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Devices.HumanInterfaceDevice.HidNumericControl GetNumericControl(ushort usagePage, ushort usageId)
		{
			throw new global::System.NotImplementedException("The member HidNumericControl HidFeatureReport.GetNumericControl(ushort usagePage, ushort usageId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=HidNumericControl%20HidFeatureReport.GetNumericControl%28ushort%20usagePage%2C%20ushort%20usageId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Devices.HumanInterfaceDevice.HidNumericControl GetNumericControlByDescription(global::Windows.Devices.HumanInterfaceDevice.HidNumericControlDescription controlDescription)
		{
			throw new global::System.NotImplementedException("The member HidNumericControl HidFeatureReport.GetNumericControlByDescription(HidNumericControlDescription controlDescription) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=HidNumericControl%20HidFeatureReport.GetNumericControlByDescription%28HidNumericControlDescription%20controlDescription%29");
		}
#endif
	}
}
