#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Data
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial interface IItemsRangeInfo : global::System.IDisposable
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void RangesChanged(global::Windows.UI.Xaml.Data.ItemIndexRange visibleRange, global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.Xaml.Data.ItemIndexRange> trackedItems);
#endif
	}
}
