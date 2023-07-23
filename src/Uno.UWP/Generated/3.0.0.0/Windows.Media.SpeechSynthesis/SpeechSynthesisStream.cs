#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.SpeechSynthesis
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class SpeechSynthesisStream : global::Windows.Storage.Streams.IRandomAccessStreamWithContentType,global::Windows.Storage.Streams.IContentTypeProvider,global::Windows.Storage.Streams.IRandomAccessStream,global::Windows.Storage.Streams.IOutputStream,global::System.IDisposable,global::Windows.Storage.Streams.IInputStream,global::Windows.Media.Core.ITimedMetadataTrackProvider
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<global::Windows.Media.Core.TimedMetadataTrack> TimedMetadataTracks
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<TimedMetadataTrack> SpeechSynthesisStream.TimedMetadataTracks is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CTimedMetadataTrack%3E%20SpeechSynthesisStream.TimedMetadataTracks");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<global::Windows.Media.IMediaMarker> Markers
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<IMediaMarker> SpeechSynthesisStream.Markers is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CIMediaMarker%3E%20SpeechSynthesisStream.Markers");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string ContentType
		{
			get
			{
				throw new global::System.NotImplementedException("The member string SpeechSynthesisStream.ContentType is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20SpeechSynthesisStream.ContentType");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ulong Size
		{
			get
			{
				throw new global::System.NotImplementedException("The member ulong SpeechSynthesisStream.Size is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ulong%20SpeechSynthesisStream.Size");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.SpeechSynthesis.SpeechSynthesisStream", "ulong SpeechSynthesisStream.Size");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool CanRead
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool SpeechSynthesisStream.CanRead is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20SpeechSynthesisStream.CanRead");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool CanWrite
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool SpeechSynthesisStream.CanWrite is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20SpeechSynthesisStream.CanWrite");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ulong Position
		{
			get
			{
				throw new global::System.NotImplementedException("The member ulong SpeechSynthesisStream.Position is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ulong%20SpeechSynthesisStream.Position");
			}
		}
#endif
		// Forced skipping of method Windows.Media.SpeechSynthesis.SpeechSynthesisStream.Markers.get
		// Forced skipping of method Windows.Media.SpeechSynthesis.SpeechSynthesisStream.Size.get
		// Forced skipping of method Windows.Media.SpeechSynthesis.SpeechSynthesisStream.Size.set
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Storage.Streams.IInputStream GetInputStreamAt(ulong position)
		{
			throw new global::System.NotImplementedException("The member IInputStream SpeechSynthesisStream.GetInputStreamAt(ulong position) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IInputStream%20SpeechSynthesisStream.GetInputStreamAt%28ulong%20position%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Storage.Streams.IOutputStream GetOutputStreamAt(ulong position)
		{
			throw new global::System.NotImplementedException("The member IOutputStream SpeechSynthesisStream.GetOutputStreamAt(ulong position) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IOutputStream%20SpeechSynthesisStream.GetOutputStreamAt%28ulong%20position%29");
		}
#endif
		// Forced skipping of method Windows.Media.SpeechSynthesis.SpeechSynthesisStream.Position.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void Seek(ulong position)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.SpeechSynthesis.SpeechSynthesisStream", "void SpeechSynthesisStream.Seek(ulong position)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Storage.Streams.IRandomAccessStream CloneStream()
		{
			throw new global::System.NotImplementedException("The member IRandomAccessStream SpeechSynthesisStream.CloneStream() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IRandomAccessStream%20SpeechSynthesisStream.CloneStream%28%29");
		}
#endif
		// Forced skipping of method Windows.Media.SpeechSynthesis.SpeechSynthesisStream.CanRead.get
		// Forced skipping of method Windows.Media.SpeechSynthesis.SpeechSynthesisStream.CanWrite.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.SpeechSynthesis.SpeechSynthesisStream", "void SpeechSynthesisStream.Dispose()");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperationWithProgress<global::Windows.Storage.Streams.IBuffer, uint> ReadAsync(global::Windows.Storage.Streams.IBuffer buffer, uint count, global::Windows.Storage.Streams.InputStreamOptions options)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperationWithProgress<IBuffer, uint> SpeechSynthesisStream.ReadAsync(IBuffer buffer, uint count, InputStreamOptions options) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperationWithProgress%3CIBuffer%2C%20uint%3E%20SpeechSynthesisStream.ReadAsync%28IBuffer%20buffer%2C%20uint%20count%2C%20InputStreamOptions%20options%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperationWithProgress<uint, uint> WriteAsync(global::Windows.Storage.Streams.IBuffer buffer)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperationWithProgress<uint, uint> SpeechSynthesisStream.WriteAsync(IBuffer buffer) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperationWithProgress%3Cuint%2C%20uint%3E%20SpeechSynthesisStream.WriteAsync%28IBuffer%20buffer%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<bool> FlushAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> SpeechSynthesisStream.FlushAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cbool%3E%20SpeechSynthesisStream.FlushAsync%28%29");
		}
#endif
		// Forced skipping of method Windows.Media.SpeechSynthesis.SpeechSynthesisStream.ContentType.get
		// Forced skipping of method Windows.Media.SpeechSynthesis.SpeechSynthesisStream.TimedMetadataTracks.get
		// Processing: Windows.Storage.Streams.IRandomAccessStreamWithContentType
		// Processing: Windows.Storage.Streams.IRandomAccessStream
		// Processing: System.IDisposable
		// Processing: Windows.Storage.Streams.IInputStream
		// Processing: Windows.Storage.Streams.IOutputStream
		// Processing: Windows.Storage.Streams.IContentTypeProvider
		// Processing: Windows.Media.Core.ITimedMetadataTrackProvider
	}
}
