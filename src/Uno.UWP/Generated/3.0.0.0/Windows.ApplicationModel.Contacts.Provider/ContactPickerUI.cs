#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Contacts.Provider
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class ContactPickerUI 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<string> DesiredFields
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<string> ContactPickerUI.DesiredFields is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3Cstring%3E%20ContactPickerUI.DesiredFields");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Contacts.ContactSelectionMode SelectionMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member ContactSelectionMode ContactPickerUI.SelectionMode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ContactSelectionMode%20ContactPickerUI.SelectionMode");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IList<global::Windows.ApplicationModel.Contacts.ContactFieldType> DesiredFieldsWithContactFieldType
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<ContactFieldType> ContactPickerUI.DesiredFieldsWithContactFieldType is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IList%3CContactFieldType%3E%20ContactPickerUI.DesiredFieldsWithContactFieldType");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Contacts.Provider.AddContactResult AddContact(string id, global::Windows.ApplicationModel.Contacts.Contact contact)
		{
			throw new global::System.NotImplementedException("The member AddContactResult ContactPickerUI.AddContact(string id, Contact contact) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AddContactResult%20ContactPickerUI.AddContact%28string%20id%2C%20Contact%20contact%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void RemoveContact(string id)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.Provider.ContactPickerUI", "void ContactPickerUI.RemoveContact(string id)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool ContainsContact(string id)
		{
			throw new global::System.NotImplementedException("The member bool ContactPickerUI.ContainsContact(string id) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20ContactPickerUI.ContainsContact%28string%20id%29");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Contacts.Provider.ContactPickerUI.DesiredFields.get
		// Forced skipping of method Windows.ApplicationModel.Contacts.Provider.ContactPickerUI.SelectionMode.get
		// Forced skipping of method Windows.ApplicationModel.Contacts.Provider.ContactPickerUI.ContactRemoved.add
		// Forced skipping of method Windows.ApplicationModel.Contacts.Provider.ContactPickerUI.ContactRemoved.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Contacts.Provider.AddContactResult AddContact(global::Windows.ApplicationModel.Contacts.Contact contact)
		{
			throw new global::System.NotImplementedException("The member AddContactResult ContactPickerUI.AddContact(Contact contact) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AddContactResult%20ContactPickerUI.AddContact%28Contact%20contact%29");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Contacts.Provider.ContactPickerUI.DesiredFieldsWithContactFieldType.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.ApplicationModel.Contacts.Provider.ContactPickerUI, global::Windows.ApplicationModel.Contacts.Provider.ContactRemovedEventArgs> ContactRemoved
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.Provider.ContactPickerUI", "event TypedEventHandler<ContactPickerUI, ContactRemovedEventArgs> ContactPickerUI.ContactRemoved");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.Provider.ContactPickerUI", "event TypedEventHandler<ContactPickerUI, ContactRemovedEventArgs> ContactPickerUI.ContactRemoved");
			}
		}
#endif
	}
}
