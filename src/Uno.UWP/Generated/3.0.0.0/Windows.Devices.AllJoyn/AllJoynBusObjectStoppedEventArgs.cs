#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.AllJoyn
{
	// This type is deprecated. Consider not implementing it.
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class AllJoynBusObjectStoppedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public int Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member int AllJoynBusObjectStoppedEventArgs.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=int%20AllJoynBusObjectStoppedEventArgs.Status");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public AllJoynBusObjectStoppedEventArgs(int status) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.AllJoyn.AllJoynBusObjectStoppedEventArgs", "AllJoynBusObjectStoppedEventArgs.AllJoynBusObjectStoppedEventArgs(int status)");
		}
#endif
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynBusObjectStoppedEventArgs.AllJoynBusObjectStoppedEventArgs(int)
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynBusObjectStoppedEventArgs.Status.get
	}
}
