#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Capture.Frames
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class DepthMediaFrame 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.Capture.Frames.DepthMediaFrameFormat DepthFormat
		{
			get
			{
				throw new global::System.NotImplementedException("The member DepthMediaFrameFormat DepthMediaFrame.DepthFormat is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DepthMediaFrameFormat%20DepthMediaFrame.DepthFormat");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.Capture.Frames.MediaFrameReference FrameReference
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaFrameReference DepthMediaFrame.FrameReference is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MediaFrameReference%20DepthMediaFrame.FrameReference");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.Capture.Frames.VideoMediaFrame VideoMediaFrame
		{
			get
			{
				throw new global::System.NotImplementedException("The member VideoMediaFrame DepthMediaFrame.VideoMediaFrame is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=VideoMediaFrame%20DepthMediaFrame.VideoMediaFrame");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint MaxReliableDepth
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint DepthMediaFrame.MaxReliableDepth is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20DepthMediaFrame.MaxReliableDepth");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint MinReliableDepth
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint DepthMediaFrame.MinReliableDepth is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20DepthMediaFrame.MinReliableDepth");
			}
		}
#endif
		// Forced skipping of method Windows.Media.Capture.Frames.DepthMediaFrame.FrameReference.get
		// Forced skipping of method Windows.Media.Capture.Frames.DepthMediaFrame.VideoMediaFrame.get
		// Forced skipping of method Windows.Media.Capture.Frames.DepthMediaFrame.DepthFormat.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper TryCreateCoordinateMapper(global::Windows.Media.Devices.Core.CameraIntrinsics cameraIntrinsics, global::Windows.Perception.Spatial.SpatialCoordinateSystem coordinateSystem)
		{
			throw new global::System.NotImplementedException("The member DepthCorrelatedCoordinateMapper DepthMediaFrame.TryCreateCoordinateMapper(CameraIntrinsics cameraIntrinsics, SpatialCoordinateSystem coordinateSystem) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DepthCorrelatedCoordinateMapper%20DepthMediaFrame.TryCreateCoordinateMapper%28CameraIntrinsics%20cameraIntrinsics%2C%20SpatialCoordinateSystem%20coordinateSystem%29");
		}
#endif
		// Forced skipping of method Windows.Media.Capture.Frames.DepthMediaFrame.MaxReliableDepth.get
		// Forced skipping of method Windows.Media.Capture.Frames.DepthMediaFrame.MinReliableDepth.get
	}
}
