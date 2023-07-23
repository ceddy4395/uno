#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Search
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class SearchQueryLinguisticDetails 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<string> QueryTextAlternatives
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<string> SearchQueryLinguisticDetails.QueryTextAlternatives is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3Cstring%3E%20SearchQueryLinguisticDetails.QueryTextAlternatives");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint QueryTextCompositionLength
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint SearchQueryLinguisticDetails.QueryTextCompositionLength is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20SearchQueryLinguisticDetails.QueryTextCompositionLength");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint QueryTextCompositionStart
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint SearchQueryLinguisticDetails.QueryTextCompositionStart is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20SearchQueryLinguisticDetails.QueryTextCompositionStart");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public SearchQueryLinguisticDetails(global::System.Collections.Generic.IEnumerable<string> queryTextAlternatives, uint queryTextCompositionStart, uint queryTextCompositionLength) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Search.SearchQueryLinguisticDetails", "SearchQueryLinguisticDetails.SearchQueryLinguisticDetails(IEnumerable<string> queryTextAlternatives, uint queryTextCompositionStart, uint queryTextCompositionLength)");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Search.SearchQueryLinguisticDetails.SearchQueryLinguisticDetails(System.Collections.Generic.IEnumerable<string>, uint, uint)
		// Forced skipping of method Windows.ApplicationModel.Search.SearchQueryLinguisticDetails.QueryTextAlternatives.get
		// Forced skipping of method Windows.ApplicationModel.Search.SearchQueryLinguisticDetails.QueryTextCompositionStart.get
		// Forced skipping of method Windows.ApplicationModel.Search.SearchQueryLinguisticDetails.QueryTextCompositionLength.get
	}
}
