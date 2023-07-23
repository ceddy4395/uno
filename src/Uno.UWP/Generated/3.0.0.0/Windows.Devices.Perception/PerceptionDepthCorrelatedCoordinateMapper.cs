#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Perception
{
	// This type is deprecated. Consider not implementing it.
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class PerceptionDepthCorrelatedCoordinateMapper 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.Point MapPixelToTarget(global::Windows.Foundation.Point sourcePixelCoordinate, global::Windows.Devices.Perception.PerceptionDepthFrame depthFrame)
		{
			throw new global::System.NotImplementedException("The member Point PerceptionDepthCorrelatedCoordinateMapper.MapPixelToTarget(Point sourcePixelCoordinate, PerceptionDepthFrame depthFrame) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Point%20PerceptionDepthCorrelatedCoordinateMapper.MapPixelToTarget%28Point%20sourcePixelCoordinate%2C%20PerceptionDepthFrame%20depthFrame%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void MapPixelsToTarget(global::Windows.Foundation.Point[] sourceCoordinates, global::Windows.Devices.Perception.PerceptionDepthFrame depthFrame, global::Windows.Foundation.Point[] results)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Perception.PerceptionDepthCorrelatedCoordinateMapper", "void PerceptionDepthCorrelatedCoordinateMapper.MapPixelsToTarget(Point[] sourceCoordinates, PerceptionDepthFrame depthFrame, Point[] results)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction MapRegionOfPixelsToTargetAsync(global::Windows.Foundation.Rect region, global::Windows.Devices.Perception.PerceptionDepthFrame depthFrame, global::Windows.Foundation.Point[] targetCoordinates)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction PerceptionDepthCorrelatedCoordinateMapper.MapRegionOfPixelsToTargetAsync(Rect region, PerceptionDepthFrame depthFrame, Point[] targetCoordinates) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20PerceptionDepthCorrelatedCoordinateMapper.MapRegionOfPixelsToTargetAsync%28Rect%20region%2C%20PerceptionDepthFrame%20depthFrame%2C%20Point%5B%5D%20targetCoordinates%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction MapAllPixelsToTargetAsync(global::Windows.Devices.Perception.PerceptionDepthFrame depthFrame, global::Windows.Foundation.Point[] targetCoordinates)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction PerceptionDepthCorrelatedCoordinateMapper.MapAllPixelsToTargetAsync(PerceptionDepthFrame depthFrame, Point[] targetCoordinates) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20PerceptionDepthCorrelatedCoordinateMapper.MapAllPixelsToTargetAsync%28PerceptionDepthFrame%20depthFrame%2C%20Point%5B%5D%20targetCoordinates%29");
		}
#endif
	}
}
