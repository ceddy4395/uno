#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.AllJoyn
{
	// This type is deprecated. Consider not implementing it.
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class AllJoynAcceptSessionJoinerEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool SameNetwork
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AllJoynAcceptSessionJoinerEventArgs.SameNetwork is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20AllJoynAcceptSessionJoinerEventArgs.SameNetwork");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool SamePhysicalNode
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AllJoynAcceptSessionJoinerEventArgs.SamePhysicalNode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20AllJoynAcceptSessionJoinerEventArgs.SamePhysicalNode");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ushort SessionPort
		{
			get
			{
				throw new global::System.NotImplementedException("The member ushort AllJoynAcceptSessionJoinerEventArgs.SessionPort is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ushort%20AllJoynAcceptSessionJoinerEventArgs.SessionPort");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Devices.AllJoyn.AllJoynTrafficType TrafficType
		{
			get
			{
				throw new global::System.NotImplementedException("The member AllJoynTrafficType AllJoynAcceptSessionJoinerEventArgs.TrafficType is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AllJoynTrafficType%20AllJoynAcceptSessionJoinerEventArgs.TrafficType");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string UniqueName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string AllJoynAcceptSessionJoinerEventArgs.UniqueName is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20AllJoynAcceptSessionJoinerEventArgs.UniqueName");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public AllJoynAcceptSessionJoinerEventArgs(string uniqueName, ushort sessionPort, global::Windows.Devices.AllJoyn.AllJoynTrafficType trafficType, byte proximity, global::Windows.Devices.AllJoyn.IAllJoynAcceptSessionJoiner acceptSessionJoiner) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.AllJoyn.AllJoynAcceptSessionJoinerEventArgs", "AllJoynAcceptSessionJoinerEventArgs.AllJoynAcceptSessionJoinerEventArgs(string uniqueName, ushort sessionPort, AllJoynTrafficType trafficType, byte proximity, IAllJoynAcceptSessionJoiner acceptSessionJoiner)");
		}
#endif
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynAcceptSessionJoinerEventArgs.AllJoynAcceptSessionJoinerEventArgs(string, ushort, Windows.Devices.AllJoyn.AllJoynTrafficType, byte, Windows.Devices.AllJoyn.IAllJoynAcceptSessionJoiner)
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynAcceptSessionJoinerEventArgs.UniqueName.get
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynAcceptSessionJoinerEventArgs.SessionPort.get
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynAcceptSessionJoinerEventArgs.TrafficType.get
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynAcceptSessionJoinerEventArgs.SamePhysicalNode.get
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynAcceptSessionJoinerEventArgs.SameNetwork.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void Accept()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.AllJoyn.AllJoynAcceptSessionJoinerEventArgs", "void AllJoynAcceptSessionJoinerEventArgs.Accept()");
		}
#endif
	}
}
