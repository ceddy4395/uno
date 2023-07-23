#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
#endif
	public partial class DelegatedInkTrailVisual : global::Windows.UI.Composition.Visual
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint AddTrailPoints(global::Windows.UI.Composition.InkTrailPoint[] inkPoints)
		{
			throw new global::System.NotImplementedException("The member uint DelegatedInkTrailVisual.AddTrailPoints(InkTrailPoint[] inkPoints) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20DelegatedInkTrailVisual.AddTrailPoints%28InkTrailPoint%5B%5D%20inkPoints%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint AddTrailPointsWithPrediction(global::Windows.UI.Composition.InkTrailPoint[] inkPoints, global::Windows.UI.Composition.InkTrailPoint[] predictedInkPoints)
		{
			throw new global::System.NotImplementedException("The member uint DelegatedInkTrailVisual.AddTrailPointsWithPrediction(InkTrailPoint[] inkPoints, InkTrailPoint[] predictedInkPoints) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20DelegatedInkTrailVisual.AddTrailPointsWithPrediction%28InkTrailPoint%5B%5D%20inkPoints%2C%20InkTrailPoint%5B%5D%20predictedInkPoints%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void RemoveTrailPoints(uint generationId)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.DelegatedInkTrailVisual", "void DelegatedInkTrailVisual.RemoveTrailPoints(uint generationId)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void StartNewTrail(global::Windows.UI.Color color)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.DelegatedInkTrailVisual", "void DelegatedInkTrailVisual.StartNewTrail(Color color)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Composition.DelegatedInkTrailVisual Create(global::Windows.UI.Composition.Compositor compositor)
		{
			throw new global::System.NotImplementedException("The member DelegatedInkTrailVisual DelegatedInkTrailVisual.Create(Compositor compositor) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DelegatedInkTrailVisual%20DelegatedInkTrailVisual.Create%28Compositor%20compositor%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Composition.DelegatedInkTrailVisual CreateForSwapChain(global::Windows.UI.Composition.Compositor compositor, global::Windows.UI.Composition.ICompositionSurface swapChain)
		{
			throw new global::System.NotImplementedException("The member DelegatedInkTrailVisual DelegatedInkTrailVisual.CreateForSwapChain(Compositor compositor, ICompositionSurface swapChain) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DelegatedInkTrailVisual%20DelegatedInkTrailVisual.CreateForSwapChain%28Compositor%20compositor%2C%20ICompositionSurface%20swapChain%29");
		}
#endif
	}
}
