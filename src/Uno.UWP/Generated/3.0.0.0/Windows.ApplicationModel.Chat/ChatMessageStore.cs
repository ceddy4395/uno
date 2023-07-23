#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Chat
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class ChatMessageStore 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Chat.ChatMessageChangeTracker ChangeTracker
		{
			get
			{
				throw new global::System.NotImplementedException("The member ChatMessageChangeTracker ChatMessageStore.ChangeTracker is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ChatMessageChangeTracker%20ChatMessageStore.ChangeTracker");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Chat.ChatMessageStore.ChangeTracker.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction DeleteMessageAsync(string localMessageId)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ChatMessageStore.DeleteMessageAsync(string localMessageId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20ChatMessageStore.DeleteMessageAsync%28string%20localMessageId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction DownloadMessageAsync(string localChatMessageId)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ChatMessageStore.DownloadMessageAsync(string localChatMessageId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20ChatMessageStore.DownloadMessageAsync%28string%20localChatMessageId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Chat.ChatMessage> GetMessageAsync(string localChatMessageId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ChatMessage> ChatMessageStore.GetMessageAsync(string localChatMessageId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CChatMessage%3E%20ChatMessageStore.GetMessageAsync%28string%20localChatMessageId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Chat.ChatMessageReader GetMessageReader()
		{
			throw new global::System.NotImplementedException("The member ChatMessageReader ChatMessageStore.GetMessageReader() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ChatMessageReader%20ChatMessageStore.GetMessageReader%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Chat.ChatMessageReader GetMessageReader(global::System.TimeSpan recentTimeLimit)
		{
			throw new global::System.NotImplementedException("The member ChatMessageReader ChatMessageStore.GetMessageReader(TimeSpan recentTimeLimit) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ChatMessageReader%20ChatMessageStore.GetMessageReader%28TimeSpan%20recentTimeLimit%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction MarkMessageReadAsync(string localChatMessageId)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ChatMessageStore.MarkMessageReadAsync(string localChatMessageId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20ChatMessageStore.MarkMessageReadAsync%28string%20localChatMessageId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction RetrySendMessageAsync(string localChatMessageId)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ChatMessageStore.RetrySendMessageAsync(string localChatMessageId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20ChatMessageStore.RetrySendMessageAsync%28string%20localChatMessageId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction SendMessageAsync(global::Windows.ApplicationModel.Chat.ChatMessage chatMessage)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ChatMessageStore.SendMessageAsync(ChatMessage chatMessage) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20ChatMessageStore.SendMessageAsync%28ChatMessage%20chatMessage%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Chat.ChatMessageValidationResult ValidateMessage(global::Windows.ApplicationModel.Chat.ChatMessage chatMessage)
		{
			throw new global::System.NotImplementedException("The member ChatMessageValidationResult ChatMessageStore.ValidateMessage(ChatMessage chatMessage) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ChatMessageValidationResult%20ChatMessageStore.ValidateMessage%28ChatMessage%20chatMessage%29");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Chat.ChatMessageStore.MessageChanged.add
		// Forced skipping of method Windows.ApplicationModel.Chat.ChatMessageStore.MessageChanged.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Chat.ChatMessage> ForwardMessageAsync(string localChatMessageId, global::System.Collections.Generic.IEnumerable<string> addresses)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ChatMessage> ChatMessageStore.ForwardMessageAsync(string localChatMessageId, IEnumerable<string> addresses) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CChatMessage%3E%20ChatMessageStore.ForwardMessageAsync%28string%20localChatMessageId%2C%20IEnumerable%3Cstring%3E%20addresses%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Chat.ChatConversation> GetConversationAsync(string conversationId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ChatConversation> ChatMessageStore.GetConversationAsync(string conversationId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CChatConversation%3E%20ChatMessageStore.GetConversationAsync%28string%20conversationId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Chat.ChatConversation> GetConversationAsync(string conversationId, global::System.Collections.Generic.IEnumerable<string> transportIds)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ChatConversation> ChatMessageStore.GetConversationAsync(string conversationId, IEnumerable<string> transportIds) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CChatConversation%3E%20ChatMessageStore.GetConversationAsync%28string%20conversationId%2C%20IEnumerable%3Cstring%3E%20transportIds%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Chat.ChatConversation> GetConversationFromThreadingInfoAsync(global::Windows.ApplicationModel.Chat.ChatConversationThreadingInfo threadingInfo)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ChatConversation> ChatMessageStore.GetConversationFromThreadingInfoAsync(ChatConversationThreadingInfo threadingInfo) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CChatConversation%3E%20ChatMessageStore.GetConversationFromThreadingInfoAsync%28ChatConversationThreadingInfo%20threadingInfo%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Chat.ChatConversationReader GetConversationReader()
		{
			throw new global::System.NotImplementedException("The member ChatConversationReader ChatMessageStore.GetConversationReader() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ChatConversationReader%20ChatMessageStore.GetConversationReader%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Chat.ChatConversationReader GetConversationReader(global::System.Collections.Generic.IEnumerable<string> transportIds)
		{
			throw new global::System.NotImplementedException("The member ChatConversationReader ChatMessageStore.GetConversationReader(IEnumerable<string> transportIds) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ChatConversationReader%20ChatMessageStore.GetConversationReader%28IEnumerable%3Cstring%3E%20transportIds%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Chat.ChatMessage> GetMessageByRemoteIdAsync(string transportId, string remoteId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ChatMessage> ChatMessageStore.GetMessageByRemoteIdAsync(string transportId, string remoteId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CChatMessage%3E%20ChatMessageStore.GetMessageByRemoteIdAsync%28string%20transportId%2C%20string%20remoteId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<int> GetUnseenCountAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<int> ChatMessageStore.GetUnseenCountAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cint%3E%20ChatMessageStore.GetUnseenCountAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<int> GetUnseenCountAsync(global::System.Collections.Generic.IEnumerable<string> transportIds)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<int> ChatMessageStore.GetUnseenCountAsync(IEnumerable<string> transportIds) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cint%3E%20ChatMessageStore.GetUnseenCountAsync%28IEnumerable%3Cstring%3E%20transportIds%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction MarkAsSeenAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ChatMessageStore.MarkAsSeenAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20ChatMessageStore.MarkAsSeenAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction MarkAsSeenAsync(global::System.Collections.Generic.IEnumerable<string> transportIds)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ChatMessageStore.MarkAsSeenAsync(IEnumerable<string> transportIds) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20ChatMessageStore.MarkAsSeenAsync%28IEnumerable%3Cstring%3E%20transportIds%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Chat.ChatSearchReader GetSearchReader(global::Windows.ApplicationModel.Chat.ChatQueryOptions value)
		{
			throw new global::System.NotImplementedException("The member ChatSearchReader ChatMessageStore.GetSearchReader(ChatQueryOptions value) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ChatSearchReader%20ChatMessageStore.GetSearchReader%28ChatQueryOptions%20value%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction SaveMessageAsync(global::Windows.ApplicationModel.Chat.ChatMessage chatMessage)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ChatMessageStore.SaveMessageAsync(ChatMessage chatMessage) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20ChatMessageStore.SaveMessageAsync%28ChatMessage%20chatMessage%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<bool> TryCancelDownloadMessageAsync(string localChatMessageId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> ChatMessageStore.TryCancelDownloadMessageAsync(string localChatMessageId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cbool%3E%20ChatMessageStore.TryCancelDownloadMessageAsync%28string%20localChatMessageId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<bool> TryCancelSendMessageAsync(string localChatMessageId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> ChatMessageStore.TryCancelSendMessageAsync(string localChatMessageId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cbool%3E%20ChatMessageStore.TryCancelSendMessageAsync%28string%20localChatMessageId%29");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Chat.ChatMessageStore.StoreChanged.add
		// Forced skipping of method Windows.ApplicationModel.Chat.ChatMessageStore.StoreChanged.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Chat.ChatMessage> GetMessageBySyncIdAsync(string syncId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ChatMessage> ChatMessageStore.GetMessageBySyncIdAsync(string syncId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CChatMessage%3E%20ChatMessageStore.GetMessageBySyncIdAsync%28string%20syncId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.ApplicationModel.Chat.ChatMessageStore, global::Windows.ApplicationModel.Chat.ChatMessageChangedEventArgs> MessageChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Chat.ChatMessageStore", "event TypedEventHandler<ChatMessageStore, ChatMessageChangedEventArgs> ChatMessageStore.MessageChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Chat.ChatMessageStore", "event TypedEventHandler<ChatMessageStore, ChatMessageChangedEventArgs> ChatMessageStore.MessageChanged");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.ApplicationModel.Chat.ChatMessageStore, global::Windows.ApplicationModel.Chat.ChatMessageStoreChangedEventArgs> StoreChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Chat.ChatMessageStore", "event TypedEventHandler<ChatMessageStore, ChatMessageStoreChangedEventArgs> ChatMessageStore.StoreChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Chat.ChatMessageStore", "event TypedEventHandler<ChatMessageStore, ChatMessageStoreChangedEventArgs> ChatMessageStore.StoreChanged");
			}
		}
#endif
	}
}
