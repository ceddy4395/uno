#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Calls
{
#if false || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented("__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
#endif
	public partial class PhoneCallHistoryStore 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Calls.PhoneCallHistoryEntry> GetEntryAsync(string callHistoryEntryId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<PhoneCallHistoryEntry> PhoneCallHistoryStore.GetEntryAsync(string callHistoryEntryId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CPhoneCallHistoryEntry%3E%20PhoneCallHistoryStore.GetEntryAsync%28string%20callHistoryEntryId%29");
		}
#endif
#if false || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Calls.PhoneCallHistoryEntryReader GetEntryReader()
		{
			throw new global::System.NotImplementedException("The member PhoneCallHistoryEntryReader PhoneCallHistoryStore.GetEntryReader() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PhoneCallHistoryEntryReader%20PhoneCallHistoryStore.GetEntryReader%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Calls.PhoneCallHistoryEntryReader GetEntryReader(global::Windows.ApplicationModel.Calls.PhoneCallHistoryEntryQueryOptions queryOptions)
		{
			throw new global::System.NotImplementedException("The member PhoneCallHistoryEntryReader PhoneCallHistoryStore.GetEntryReader(PhoneCallHistoryEntryQueryOptions queryOptions) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PhoneCallHistoryEntryReader%20PhoneCallHistoryStore.GetEntryReader%28PhoneCallHistoryEntryQueryOptions%20queryOptions%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction SaveEntryAsync(global::Windows.ApplicationModel.Calls.PhoneCallHistoryEntry callHistoryEntry)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction PhoneCallHistoryStore.SaveEntryAsync(PhoneCallHistoryEntry callHistoryEntry) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20PhoneCallHistoryStore.SaveEntryAsync%28PhoneCallHistoryEntry%20callHistoryEntry%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction DeleteEntryAsync(global::Windows.ApplicationModel.Calls.PhoneCallHistoryEntry callHistoryEntry)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction PhoneCallHistoryStore.DeleteEntryAsync(PhoneCallHistoryEntry callHistoryEntry) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20PhoneCallHistoryStore.DeleteEntryAsync%28PhoneCallHistoryEntry%20callHistoryEntry%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction DeleteEntriesAsync(global::System.Collections.Generic.IEnumerable<global::Windows.ApplicationModel.Calls.PhoneCallHistoryEntry> callHistoryEntries)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction PhoneCallHistoryStore.DeleteEntriesAsync(IEnumerable<PhoneCallHistoryEntry> callHistoryEntries) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20PhoneCallHistoryStore.DeleteEntriesAsync%28IEnumerable%3CPhoneCallHistoryEntry%3E%20callHistoryEntries%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction MarkEntryAsSeenAsync(global::Windows.ApplicationModel.Calls.PhoneCallHistoryEntry callHistoryEntry)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction PhoneCallHistoryStore.MarkEntryAsSeenAsync(PhoneCallHistoryEntry callHistoryEntry) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20PhoneCallHistoryStore.MarkEntryAsSeenAsync%28PhoneCallHistoryEntry%20callHistoryEntry%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction MarkEntriesAsSeenAsync(global::System.Collections.Generic.IEnumerable<global::Windows.ApplicationModel.Calls.PhoneCallHistoryEntry> callHistoryEntries)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction PhoneCallHistoryStore.MarkEntriesAsSeenAsync(IEnumerable<PhoneCallHistoryEntry> callHistoryEntries) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20PhoneCallHistoryStore.MarkEntriesAsSeenAsync%28IEnumerable%3CPhoneCallHistoryEntry%3E%20callHistoryEntries%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<uint> GetUnseenCountAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<uint> PhoneCallHistoryStore.GetUnseenCountAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cuint%3E%20PhoneCallHistoryStore.GetUnseenCountAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction MarkAllAsSeenAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction PhoneCallHistoryStore.MarkAllAsSeenAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20PhoneCallHistoryStore.MarkAllAsSeenAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<uint> GetSourcesUnseenCountAsync(global::System.Collections.Generic.IEnumerable<string> sourceIds)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<uint> PhoneCallHistoryStore.GetSourcesUnseenCountAsync(IEnumerable<string> sourceIds) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cuint%3E%20PhoneCallHistoryStore.GetSourcesUnseenCountAsync%28IEnumerable%3Cstring%3E%20sourceIds%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction MarkSourcesAsSeenAsync(global::System.Collections.Generic.IEnumerable<string> sourceIds)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction PhoneCallHistoryStore.MarkSourcesAsSeenAsync(IEnumerable<string> sourceIds) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20PhoneCallHistoryStore.MarkSourcesAsSeenAsync%28IEnumerable%3Cstring%3E%20sourceIds%29");
		}
#endif
	}
}
