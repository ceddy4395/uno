#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Imaging
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class SoftwareBitmapSource : global::Windows.UI.Xaml.Media.ImageSource,global::System.IDisposable
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public SoftwareBitmapSource() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Imaging.SoftwareBitmapSource", "SoftwareBitmapSource.SoftwareBitmapSource()");
		}
#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Imaging.SoftwareBitmapSource.SoftwareBitmapSource()
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction SetBitmapAsync(global::Windows.Graphics.Imaging.SoftwareBitmap softwareBitmap)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction SoftwareBitmapSource.SetBitmapAsync(SoftwareBitmap softwareBitmap) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20SoftwareBitmapSource.SetBitmapAsync%28SoftwareBitmap%20softwareBitmap%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Imaging.SoftwareBitmapSource", "void SoftwareBitmapSource.Dispose()");
		}
#endif
		// Processing: System.IDisposable
	}
}
