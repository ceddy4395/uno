#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Capture.Frames
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class MultiSourceMediaFrameReference : global::System.IDisposable
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.Capture.Frames.MediaFrameReference TryGetFrameReferenceBySourceId(string sourceId)
		{
			throw new global::System.NotImplementedException("The member MediaFrameReference MultiSourceMediaFrameReference.TryGetFrameReferenceBySourceId(string sourceId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MediaFrameReference%20MultiSourceMediaFrameReference.TryGetFrameReferenceBySourceId%28string%20sourceId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Capture.Frames.MultiSourceMediaFrameReference", "void MultiSourceMediaFrameReference.Dispose()");
		}
#endif
		// Processing: System.IDisposable
	}
}
