#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Ocr
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class OcrEngine 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Globalization.Language RecognizerLanguage
		{
			get
			{
				throw new global::System.NotImplementedException("The member Language OcrEngine.RecognizerLanguage is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Language%20OcrEngine.RecognizerLanguage");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IReadOnlyList<global::Windows.Globalization.Language> AvailableRecognizerLanguages
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<Language> OcrEngine.AvailableRecognizerLanguages is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CLanguage%3E%20OcrEngine.AvailableRecognizerLanguages");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static uint MaxImageDimension
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint OcrEngine.MaxImageDimension is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20OcrEngine.MaxImageDimension");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Media.Ocr.OcrResult> RecognizeAsync(global::Windows.Graphics.Imaging.SoftwareBitmap bitmap)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<OcrResult> OcrEngine.RecognizeAsync(SoftwareBitmap bitmap) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3COcrResult%3E%20OcrEngine.RecognizeAsync%28SoftwareBitmap%20bitmap%29");
		}
#endif
		// Forced skipping of method Windows.Media.Ocr.OcrEngine.RecognizerLanguage.get
		// Forced skipping of method Windows.Media.Ocr.OcrEngine.MaxImageDimension.get
		// Forced skipping of method Windows.Media.Ocr.OcrEngine.AvailableRecognizerLanguages.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool IsLanguageSupported(global::Windows.Globalization.Language language)
		{
			throw new global::System.NotImplementedException("The member bool OcrEngine.IsLanguageSupported(Language language) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20OcrEngine.IsLanguageSupported%28Language%20language%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Media.Ocr.OcrEngine TryCreateFromLanguage(global::Windows.Globalization.Language language)
		{
			throw new global::System.NotImplementedException("The member OcrEngine OcrEngine.TryCreateFromLanguage(Language language) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=OcrEngine%20OcrEngine.TryCreateFromLanguage%28Language%20language%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Media.Ocr.OcrEngine TryCreateFromUserProfileLanguages()
		{
			throw new global::System.NotImplementedException("The member OcrEngine OcrEngine.TryCreateFromUserProfileLanguages() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=OcrEngine%20OcrEngine.TryCreateFromUserProfileLanguages%28%29");
		}
#endif
	}
}
