#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
#endif
	public partial class ItemsControlAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer,global::Windows.UI.Xaml.Automation.Provider.IItemContainerProvider
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ItemsControlAutomationPeer(global::Windows.UI.Xaml.Controls.ItemsControl owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer", "ItemsControlAutomationPeer.ItemsControlAutomationPeer(ItemsControl owner)");
		}
#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer.ItemsControlAutomationPeer(Windows.UI.Xaml.Controls.ItemsControl)
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.UI.Xaml.Automation.Peers.ItemAutomationPeer CreateItemAutomationPeer(object item)
		{
			throw new global::System.NotImplementedException("The member ItemAutomationPeer ItemsControlAutomationPeer.CreateItemAutomationPeer(object item) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ItemAutomationPeer%20ItemsControlAutomationPeer.CreateItemAutomationPeer%28object%20item%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		protected virtual global::Windows.UI.Xaml.Automation.Peers.ItemAutomationPeer OnCreateItemAutomationPeer(object item)
		{
			throw new global::System.NotImplementedException("The member ItemAutomationPeer ItemsControlAutomationPeer.OnCreateItemAutomationPeer(object item) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ItemAutomationPeer%20ItemsControlAutomationPeer.OnCreateItemAutomationPeer%28object%20item%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.UI.Xaml.Automation.Provider.IRawElementProviderSimple FindItemByProperty(global::Windows.UI.Xaml.Automation.Provider.IRawElementProviderSimple startAfter, global::Windows.UI.Xaml.Automation.AutomationProperty automationProperty, object value)
		{
			throw new global::System.NotImplementedException("The member IRawElementProviderSimple ItemsControlAutomationPeer.FindItemByProperty(IRawElementProviderSimple startAfter, AutomationProperty automationProperty, object value) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IRawElementProviderSimple%20ItemsControlAutomationPeer.FindItemByProperty%28IRawElementProviderSimple%20startAfter%2C%20AutomationProperty%20automationProperty%2C%20object%20value%29");
		}
#endif
		// Processing: Windows.UI.Xaml.Automation.Provider.IItemContainerProvider
	}
}
