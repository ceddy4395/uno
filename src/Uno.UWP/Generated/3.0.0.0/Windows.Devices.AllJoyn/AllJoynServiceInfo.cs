#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.AllJoyn
{
	// This type is deprecated. Consider not implementing it.
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class AllJoynServiceInfo 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string ObjectPath
		{
			get
			{
				throw new global::System.NotImplementedException("The member string AllJoynServiceInfo.ObjectPath is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20AllJoynServiceInfo.ObjectPath");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ushort SessionPort
		{
			get
			{
				throw new global::System.NotImplementedException("The member ushort AllJoynServiceInfo.SessionPort is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ushort%20AllJoynServiceInfo.SessionPort");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string UniqueName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string AllJoynServiceInfo.UniqueName is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20AllJoynServiceInfo.UniqueName");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public AllJoynServiceInfo(string uniqueName, string objectPath, ushort sessionPort) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.AllJoyn.AllJoynServiceInfo", "AllJoynServiceInfo.AllJoynServiceInfo(string uniqueName, string objectPath, ushort sessionPort)");
		}
#endif
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynServiceInfo.AllJoynServiceInfo(string, string, ushort)
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynServiceInfo.UniqueName.get
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynServiceInfo.ObjectPath.get
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynServiceInfo.SessionPort.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.AllJoyn.AllJoynServiceInfo> FromIdAsync(string deviceId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<AllJoynServiceInfo> AllJoynServiceInfo.FromIdAsync(string deviceId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CAllJoynServiceInfo%3E%20AllJoynServiceInfo.FromIdAsync%28string%20deviceId%29");
		}
#endif
	}
}
