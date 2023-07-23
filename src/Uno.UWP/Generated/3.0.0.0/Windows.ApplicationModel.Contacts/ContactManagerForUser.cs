#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Contacts
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class ContactManagerForUser 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Contacts.ContactNameOrder SystemSortOrder
		{
			get
			{
				throw new global::System.NotImplementedException("The member ContactNameOrder ContactManagerForUser.SystemSortOrder is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ContactNameOrder%20ContactManagerForUser.SystemSortOrder");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.ContactManagerForUser", "ContactNameOrder ContactManagerForUser.SystemSortOrder");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Contacts.ContactNameOrder SystemDisplayNameOrder
		{
			get
			{
				throw new global::System.NotImplementedException("The member ContactNameOrder ContactManagerForUser.SystemDisplayNameOrder is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ContactNameOrder%20ContactManagerForUser.SystemDisplayNameOrder");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.ContactManagerForUser", "ContactNameOrder ContactManagerForUser.SystemDisplayNameOrder");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.System.User User
		{
			get
			{
				throw new global::System.NotImplementedException("The member User ContactManagerForUser.User is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=User%20ContactManagerForUser.User");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.Streams.RandomAccessStreamReference> ConvertContactToVCardAsync(global::Windows.ApplicationModel.Contacts.Contact contact)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<RandomAccessStreamReference> ContactManagerForUser.ConvertContactToVCardAsync(Contact contact) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CRandomAccessStreamReference%3E%20ContactManagerForUser.ConvertContactToVCardAsync%28Contact%20contact%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.Streams.RandomAccessStreamReference> ConvertContactToVCardAsync(global::Windows.ApplicationModel.Contacts.Contact contact, uint maxBytes)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<RandomAccessStreamReference> ContactManagerForUser.ConvertContactToVCardAsync(Contact contact, uint maxBytes) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CRandomAccessStreamReference%3E%20ContactManagerForUser.ConvertContactToVCardAsync%28Contact%20contact%2C%20uint%20maxBytes%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Contacts.Contact> ConvertVCardToContactAsync(global::Windows.Storage.Streams.IRandomAccessStreamReference vCard)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<Contact> ContactManagerForUser.ConvertVCardToContactAsync(IRandomAccessStreamReference vCard) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CContact%3E%20ContactManagerForUser.ConvertVCardToContactAsync%28IRandomAccessStreamReference%20vCard%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Contacts.ContactStore> RequestStoreAsync(global::Windows.ApplicationModel.Contacts.ContactStoreAccessType accessType)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ContactStore> ContactManagerForUser.RequestStoreAsync(ContactStoreAccessType accessType) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CContactStore%3E%20ContactManagerForUser.RequestStoreAsync%28ContactStoreAccessType%20accessType%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Contacts.ContactAnnotationStore> RequestAnnotationStoreAsync(global::Windows.ApplicationModel.Contacts.ContactAnnotationStoreAccessType accessType)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ContactAnnotationStore> ContactManagerForUser.RequestAnnotationStoreAsync(ContactAnnotationStoreAccessType accessType) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CContactAnnotationStore%3E%20ContactManagerForUser.RequestAnnotationStoreAsync%28ContactAnnotationStoreAccessType%20accessType%29");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactManagerForUser.SystemDisplayNameOrder.get
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactManagerForUser.SystemDisplayNameOrder.set
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactManagerForUser.SystemSortOrder.get
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactManagerForUser.SystemSortOrder.set
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactManagerForUser.User.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void ShowFullContactCard(global::Windows.ApplicationModel.Contacts.Contact contact, global::Windows.ApplicationModel.Contacts.FullContactCardOptions fullContactCardOptions)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.ContactManagerForUser", "void ContactManagerForUser.ShowFullContactCard(Contact contact, FullContactCardOptions fullContactCardOptions)");
		}
#endif
	}
}
