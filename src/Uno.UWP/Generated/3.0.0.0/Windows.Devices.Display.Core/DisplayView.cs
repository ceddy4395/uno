#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Display.Core
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class DisplayView 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Graphics.SizeInt32? ContentResolution
		{
			get
			{
				throw new global::System.NotImplementedException("The member SizeInt32? DisplayView.ContentResolution is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SizeInt32%3F%20DisplayView.ContentResolution");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Display.Core.DisplayView", "SizeInt32? DisplayView.ContentResolution");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Display.Core.DisplayPath> Paths
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<DisplayPath> DisplayView.Paths is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CDisplayPath%3E%20DisplayView.Paths");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IDictionary<global::System.Guid, object> Properties
		{
			get
			{
				throw new global::System.NotImplementedException("The member IDictionary<Guid, object> DisplayView.Properties is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IDictionary%3CGuid%2C%20object%3E%20DisplayView.Properties");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.Display.Core.DisplayView.Paths.get
		// Forced skipping of method Windows.Devices.Display.Core.DisplayView.ContentResolution.get
		// Forced skipping of method Windows.Devices.Display.Core.DisplayView.ContentResolution.set
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void SetPrimaryPath(global::Windows.Devices.Display.Core.DisplayPath path)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Display.Core.DisplayView", "void DisplayView.SetPrimaryPath(DisplayPath path)");
		}
#endif
		// Forced skipping of method Windows.Devices.Display.Core.DisplayView.Properties.get
	}
}
