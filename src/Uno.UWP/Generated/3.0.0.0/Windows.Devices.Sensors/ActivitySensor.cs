#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class ActivitySensor 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string DeviceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ActivitySensor.DeviceId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20ActivitySensor.DeviceId");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint MinimumReportInterval
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint ActivitySensor.MinimumReportInterval is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20ActivitySensor.MinimumReportInterval");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public double PowerInMilliwatts
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ActivitySensor.PowerInMilliwatts is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=double%20ActivitySensor.PowerInMilliwatts");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IList<global::Windows.Devices.Sensors.ActivityType> SubscribedActivities
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<ActivityType> ActivitySensor.SubscribedActivities is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IList%3CActivityType%3E%20ActivitySensor.SubscribedActivities");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Sensors.ActivityType> SupportedActivities
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<ActivityType> ActivitySensor.SupportedActivities is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CActivityType%3E%20ActivitySensor.SupportedActivities");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Sensors.ActivitySensorReading> GetCurrentReadingAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ActivitySensorReading> ActivitySensor.GetCurrentReadingAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CActivitySensorReading%3E%20ActivitySensor.GetCurrentReadingAsync%28%29");
		}
#endif
		// Forced skipping of method Windows.Devices.Sensors.ActivitySensor.SubscribedActivities.get
		// Forced skipping of method Windows.Devices.Sensors.ActivitySensor.PowerInMilliwatts.get
		// Forced skipping of method Windows.Devices.Sensors.ActivitySensor.DeviceId.get
		// Forced skipping of method Windows.Devices.Sensors.ActivitySensor.SupportedActivities.get
		// Forced skipping of method Windows.Devices.Sensors.ActivitySensor.MinimumReportInterval.get
		// Forced skipping of method Windows.Devices.Sensors.ActivitySensor.ReadingChanged.add
		// Forced skipping of method Windows.Devices.Sensors.ActivitySensor.ReadingChanged.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Sensors.ActivitySensor> GetDefaultAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ActivitySensor> ActivitySensor.GetDefaultAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CActivitySensor%3E%20ActivitySensor.GetDefaultAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string GetDeviceSelector()
		{
			throw new global::System.NotImplementedException("The member string ActivitySensor.GetDeviceSelector() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20ActivitySensor.GetDeviceSelector%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Sensors.ActivitySensor> FromIdAsync(string deviceId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ActivitySensor> ActivitySensor.FromIdAsync(string deviceId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CActivitySensor%3E%20ActivitySensor.FromIdAsync%28string%20deviceId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Sensors.ActivitySensorReading>> GetSystemHistoryAsync(global::System.DateTimeOffset fromTime)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<ActivitySensorReading>> ActivitySensor.GetSystemHistoryAsync(DateTimeOffset fromTime) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CActivitySensorReading%3E%3E%20ActivitySensor.GetSystemHistoryAsync%28DateTimeOffset%20fromTime%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Sensors.ActivitySensorReading>> GetSystemHistoryAsync(global::System.DateTimeOffset fromTime, global::System.TimeSpan duration)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<ActivitySensorReading>> ActivitySensor.GetSystemHistoryAsync(DateTimeOffset fromTime, TimeSpan duration) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CActivitySensorReading%3E%3E%20ActivitySensor.GetSystemHistoryAsync%28DateTimeOffset%20fromTime%2C%20TimeSpan%20duration%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Devices.Sensors.ActivitySensor, global::Windows.Devices.Sensors.ActivitySensorReadingChangedEventArgs> ReadingChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.ActivitySensor", "event TypedEventHandler<ActivitySensor, ActivitySensorReadingChangedEventArgs> ActivitySensor.ReadingChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.ActivitySensor", "event TypedEventHandler<ActivitySensor, ActivitySensorReadingChangedEventArgs> ActivitySensor.ReadingChanged");
			}
		}
#endif
	}
}
