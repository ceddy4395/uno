#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Payments
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class PaymentResponse 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string PayerEmail
		{
			get
			{
				throw new global::System.NotImplementedException("The member string PaymentResponse.PayerEmail is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20PaymentResponse.PayerEmail");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string PayerName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string PaymentResponse.PayerName is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20PaymentResponse.PayerName");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string PayerPhoneNumber
		{
			get
			{
				throw new global::System.NotImplementedException("The member string PaymentResponse.PayerPhoneNumber is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20PaymentResponse.PayerPhoneNumber");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Payments.PaymentToken PaymentToken
		{
			get
			{
				throw new global::System.NotImplementedException("The member PaymentToken PaymentResponse.PaymentToken is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PaymentToken%20PaymentResponse.PaymentToken");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Payments.PaymentAddress ShippingAddress
		{
			get
			{
				throw new global::System.NotImplementedException("The member PaymentAddress PaymentResponse.ShippingAddress is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PaymentAddress%20PaymentResponse.ShippingAddress");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Payments.PaymentShippingOption ShippingOption
		{
			get
			{
				throw new global::System.NotImplementedException("The member PaymentShippingOption PaymentResponse.ShippingOption is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PaymentShippingOption%20PaymentResponse.ShippingOption");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentResponse.PaymentToken.get
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentResponse.ShippingOption.get
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentResponse.ShippingAddress.get
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentResponse.PayerEmail.get
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentResponse.PayerName.get
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentResponse.PayerPhoneNumber.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction CompleteAsync(global::Windows.ApplicationModel.Payments.PaymentRequestCompletionStatus status)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction PaymentResponse.CompleteAsync(PaymentRequestCompletionStatus status) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20PaymentResponse.CompleteAsync%28PaymentRequestCompletionStatus%20status%29");
		}
#endif
	}
}
