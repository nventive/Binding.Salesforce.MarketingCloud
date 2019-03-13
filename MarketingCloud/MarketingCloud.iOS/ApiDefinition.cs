using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;
using UserNotifications;
using WebKit;

namespace Binding.Salesforce.MarketingCloud
{
	// @interface ETAnalytics : NSObject
	[BaseType(typeof(NSObject))]
	interface ETAnalytics
	{
		// +(void)trackPageView:(NSString * _Nonnull)url andTitle:(NSString * _Nullable)title andItem:(NSString * _Nullable)item andSearch:(NSString * _Nullable)search;
		[Static]
		[Export("trackPageView:andTitle:andItem:andSearch:")]
		void TrackPageView(string url, [NullAllowed] string title, [NullAllowed] string item, [NullAllowed] string search);

		// +(void)trackCartContents:(PICart * _Nonnull)cart;
		[Static]
		[Export("trackCartContents:")]
		void TrackCartContents(PICart cart);

		// +(void)trackCartConversion:(PIOrder * _Nonnull)order;
		[Static]
		[Export("trackCartConversion:")]
		void TrackCartConversion(PIOrder order);
	}

	// @interface ETCloudPage : NSObject
	[BaseType(typeof(NSObject))]
	interface ETCloudPage
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable messageIdentifier;
		[NullAllowed, Export("messageIdentifier")]
		string MessageIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable messageName;
		[NullAllowed, Export("messageName")]
		string MessageName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable alert;
		[NullAllowed, Export("alert")]
		string Alert { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable category;
		[NullAllowed, Export("category")]
		string Category { get; }

		// @property (readonly, copy, nonatomic) NSArray * _Nullable keyValuePairs;
		[NullAllowed, Export("keyValuePairs", ArgumentSemantic.Copy)]
		NSObject[] KeyValuePairs { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable startDate;
		[NullAllowed, Export("startDate", ArgumentSemantic.Copy)]
		NSDate StartDate { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable endDate;
		[NullAllowed, Export("endDate", ArgumentSemantic.Copy)]
		NSDate EndDate { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteUrlAsString;
		[NullAllowed, Export("siteUrlAsString")]
		string SiteUrlAsString { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable openDirectPayload;
		[NullAllowed, Export("openDirectPayload")]
		string OpenDirectPayload { get; }

		// @property (readonly, getter = isRead, nonatomic) BOOL read;
		[Export("read")]
		bool Read { [Bind("isRead")] get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable subject;
		[NullAllowed, Export("subject")]
		string Subject { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable siteURL;
		[NullAllowed, Export("siteURL", ArgumentSemantic.Copy)]
		NSUrl SiteURL { get; }

		// -(BOOL)markAsDeleted;
		[Export("markAsDeleted")]
		bool MarkAsDeleted { get; }

		// -(BOOL)markAsRead;
		[Export("markAsRead")]
		bool MarkAsRead { get; }
	}

	// @interface ETCloudPageDataSource : NSObject <UITableViewDataSource>
	[BaseType(typeof(NSObject))]
	interface ETCloudPageDataSource : IUITableViewDataSource
	{
		// @property (readonly, copy, nonatomic) NSArray<__kindof ETCloudPage *> * _Nullable messages;
		[NullAllowed, Export("messages", ArgumentSemantic.Copy)]
		ETCloudPage[] Messages { get; }

		// @property (nonatomic, weak) UITableView * _Nullable inboxTableView;
		[NullAllowed, Export("inboxTableView", ArgumentSemantic.Weak)]
		UITableView InboxTableView { get; set; }
	}

	// @interface ETEventMessage : NSObject
	[BaseType(typeof(NSObject))]
	interface ETEventMessage
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable messageIdentifier;
		[NullAllowed, Export("messageIdentifier")]
		string MessageIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable messageName;
		[NullAllowed, Export("messageName")]
		string MessageName { get; }

		// @property (readonly, nonatomic) MobilePushMessageType messageType;
		[Export("messageType")]
		MobilePushMessageType MessageType { get; }

		// @property (readonly, nonatomic) MobilePushContentType contentType;
		[Export("contentType")]
		MobilePushContentType ContentType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable alert;
		[NullAllowed, Export("alert")]
		string Alert { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable sound;
		[NullAllowed, Export("sound")]
		string Sound { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable category;
		[NullAllowed, Export("category")]
		string Category { get; }

		// @property (readonly, copy, nonatomic) NSArray * _Nullable keyValuePairs;
		[NullAllowed, Export("keyValuePairs", ArgumentSemantic.Copy)]
		NSObject[] KeyValuePairs { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable startDate;
		[NullAllowed, Export("startDate", ArgumentSemantic.Copy)]
		NSDate StartDate { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable endDate;
		[NullAllowed, Export("endDate", ArgumentSemantic.Copy)]
		NSDate EndDate { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteUrlAsString;
		[NullAllowed, Export("siteUrlAsString")]
		string SiteUrlAsString { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable openDirectPayload;
		[NullAllowed, Export("openDirectPayload")]
		string OpenDirectPayload { get; }

		// @property (readonly, copy, nonatomic) NSNumber * _Nullable messageLimit;
		[NullAllowed, Export("messageLimit", ArgumentSemantic.Copy)]
		NSNumber MessageLimit { get; }

		// @property (readonly, copy, nonatomic) NSNumber * _Nullable messagesPerPeriod;
		[NullAllowed, Export("messagesPerPeriod", ArgumentSemantic.Copy)]
		NSNumber MessagesPerPeriod { get; }

		// @property (readonly, copy, nonatomic) NSNumber * _Nullable numberOfPeriods;
		[NullAllowed, Export("numberOfPeriods", ArgumentSemantic.Copy)]
		NSNumber NumberOfPeriods { get; }

		// @property (readonly, nonatomic) MobilePushMessageFrequencyUnit periodType;
		[Export("periodType")]
		MobilePushMessageFrequencyUnit PeriodType { get; }

		// @property (readonly, getter = isRollingPeriod, nonatomic) BOOL rollingPeriod;
		[Export("rollingPeriod")]
		bool RollingPeriod { [Bind("isRollingPeriod")] get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable subject;
		[NullAllowed, Export("subject")]
		string Subject { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable siteURL;
		[NullAllowed, Export("siteURL", ArgumentSemantic.Copy)]
		NSUrl SiteURL { get; }
	}

	// @interface ETEventRegion : NSObject
	[BaseType(typeof(NSObject))]
	interface ETEventRegion
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable fenceIdentifier;
		[NullAllowed, Export("fenceIdentifier")]
		string FenceIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSNumber * _Nullable latitude;
		[NullAllowed, Export("latitude", ArgumentSemantic.Copy)]
		NSNumber Latitude { get; }

		// @property (readonly, copy, nonatomic) NSNumber * _Nullable longitude;
		[NullAllowed, Export("longitude", ArgumentSemantic.Copy)]
		NSNumber Longitude { get; }

		// @property (readonly, copy, nonatomic) NSNumber * _Nullable radius;
		[NullAllowed, Export("radius", ArgumentSemantic.Copy)]
		NSNumber Radius { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable proximityUUID;
		[NullAllowed, Export("proximityUUID")]
		string ProximityUUID { get; }

		// @property (readonly, copy, nonatomic) NSNumber * _Nullable majorNumber;
		[NullAllowed, Export("majorNumber", ArgumentSemantic.Copy)]
		NSNumber MajorNumber { get; }

		// @property (readonly, copy, nonatomic) NSNumber * _Nullable minorNumber;
		[NullAllowed, Export("minorNumber", ArgumentSemantic.Copy)]
		NSNumber MinorNumber { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable regionName;
		[NullAllowed, Export("regionName")]
		string RegionName { get; }

		// @property (readonly, nonatomic) BOOL isGeofenceRegion;
		[Export("isGeofenceRegion")]
		bool IsGeofenceRegion { get; }

		// @property (readonly, nonatomic) BOOL isBeaconRegion;
		[Export("isBeaconRegion")]
		bool IsBeaconRegion { get; }

		// @property (readonly, copy, nonatomic) NSArray * _Nullable messages;
		[NullAllowed, Export("messages", ArgumentSemantic.Copy)]
		NSObject[] Messages { get; }
	}

	// @protocol ETGenericUpdateObjectProtocol <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface ETGenericUpdateObjectProtocol
	{
		// @required +(instancetype _Nullable)alloc;
		//[Static, Abstract]
		//[Export("alloc")]
		//[return: NullAllowed]
		//ETGenericUpdateObjectProtocol Alloc();

		// @required -(instancetype _Nullable)initFromDictionary:(NSDictionary * _Nonnull)dict;
		[Export("initFromDictionary:")]
		IntPtr Constructor(NSDictionary dict);

		// @required +(NSString * _Nullable)remoteRoutePath;
		// @optional -(void)setRemoteRoutePath:(NSString * _Nonnull)route;
		//[Static, Abstract]
		//[NullAllowed, Export("remoteRoutePath")]
		//[Verify(MethodToProperty)]
		//string RemoteRoutePath { get; set; }

		// @required -(NSString * _Nonnull)remoteRoutePath;
		[Abstract]
		[Export("remoteRoutePath")]
		string RemoteRoutePath { get; }

		// @required +(NSString * _Nonnull)tableName;
		//[Static, Abstract]
		//[Export("tableName")]
		//[Verify(MethodToProperty)]
		//string TableName { get; }

		// @required -(NSString * _Nonnull)tableName;
		[Abstract]
		[Export("tableName")]
		string TableName { get; }

		// @required -(NSString * _Nonnull)jsonPayloadAsString;
		[Abstract]
		[Export("jsonPayloadAsString")]
		string JsonPayloadAsString { get; }

		// @required -(NSDictionary * _Nonnull)jsonPayloadAsDictionary;
		[Abstract]
		[Export("jsonPayloadAsDictionary")]
		NSDictionary JsonPayloadAsDictionary { get; }

		// @required -(GenericUpdateSendMethod)sendMethod;
		[Abstract]
		[Export("sendMethod")]
		GenericUpdateSendMethod SendMethod { get; }
	}

	// @interface ETGenericUpdate : NSObject
	[BaseType(typeof(NSObject))]
	interface ETGenericUpdate
	{
		// -(GenericUpdateSendMethod)sendMethod;
		[Export("sendMethod")]
		GenericUpdateSendMethod SendMethod { get; }

		// -(NSString * _Nullable)remoteRoutePath;
		[NullAllowed, Export("remoteRoutePath")]
		string RemoteRoutePath { get; }

		// -(NSString * _Nullable)jsonPayloadAsString;
		[NullAllowed, Export("jsonPayloadAsString")]
		string JsonPayloadAsString { get; }

		// -(NSDictionary * _Nullable)jsonPayloadAsDictionary;
		[NullAllowed, Export("jsonPayloadAsDictionary")]
		NSDictionary JsonPayloadAsDictionary { get; }

		// -(void)handleResponseWithSuccess;
		[Export("handleResponseWithSuccess")]
		void HandleResponseWithSuccess();

		// -(void)handleResponseWithFailure;
		[Export("handleResponseWithFailure")]
		void HandleResponseWithFailure();

		// -(BOOL)shouldSaveSelfToDatabase;
		[Export("shouldSaveSelfToDatabase")]
		bool ShouldSaveSelfToDatabase { get; }

		// -(int)dbVersionNumber;
		[Export("dbVersionNumber")]
		int DbVersionNumber { get; }

		// -(NSString * _Nonnull)databaseVersionKey;
		[Export("databaseVersionKey")]
		string DatabaseVersionKey { get; }

		// -(BOOL)generatePersistentDataSchemaInDatabase;
		[Export("generatePersistentDataSchemaInDatabase")]
		bool GeneratePersistentDataSchemaInDatabase { get; }

		// -(BOOL)updateSchemaInDatabase;
		[Export("updateSchemaInDatabase")]
		bool UpdateSchemaInDatabase { get; }

		// -(NSArray * _Nullable)insertQueryArguments;
		[NullAllowed, Export("insertQueryArguments")]
		NSObject[] InsertQueryArguments { get; }

		// -(NSArray * _Nullable)updateQueryArguments;
		[NullAllowed, Export("updateQueryArguments")]
		NSObject[] UpdateQueryArguments { get; }

		// -(NSString * _Nullable)insertQuerySyntax;
		[NullAllowed, Export("insertQuerySyntax")]
		string InsertQuerySyntax { get; }

		// -(NSString * _Nullable)updateQuerySyntax;
		[NullAllowed, Export("updateQuerySyntax")]
		string UpdateQuerySyntax { get; }

		// -(BOOL)insertSelfIntoDatabase;
		[Export("insertSelfIntoDatabase")]
		bool InsertSelfIntoDatabase { get; }

		// -(NSString * _Nonnull)tableName;
		[Export("tableName")]
		string TableName { get; }

		// +(NSString * _Nonnull)tableName;
		//[Static]
		//[Export("tableName")]
		//[Verify(MethodToProperty)]
		//string TableName { get; }

		// +(void)cleanupDatabaseRecords;
		[Static]
		[Export("cleanupDatabaseRecords")]
		void CleanupDatabaseRecords();

		// +(NSDateFormatter * _Nullable)formatterOfCorrectFormat;
		[Static]
		[NullAllowed, Export("formatterOfCorrectFormat")]
		NSDateFormatter FormatterOfCorrectFormat { get; }

		// +(NSDateFormatter * _Nullable)alternativeFormatterOfCorrectFormat;
		[Static]
		[NullAllowed, Export("alternativeFormatterOfCorrectFormat")]
		NSDateFormatter AlternativeFormatterOfCorrectFormat { get; }

		// +(NSDate * _Nullable)dateFromString:(NSString * _Nonnull)dateAsString;
		[Static]
		[Export("dateFromString:")]
		[return: NullAllowed]
		NSDate DateFromString(string dateAsString);

		// +(NSString * _Nullable)stringFromDate:(NSDate * _Nonnull)date;
		[Static]
		[Export("stringFromDate:")]
		[return: NullAllowed]
		string StringFromDate(NSDate date);

		// +(NSNumberFormatter * _Nullable)numberFormatterOfCorrectFormatForDouble;
		[Static]
		[NullAllowed, Export("numberFormatterOfCorrectFormatForDouble")]
		NSNumberFormatter NumberFormatterOfCorrectFormatForDouble { get; }
	}

	// @interface ETLandingPagePresenter : UIViewController <UIWebViewDelegate>
	[BaseType(typeof(UIViewController))]
	interface ETLandingPagePresenter : IUIWebViewDelegate
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull landingPagePath;
		[Export("landingPagePath")]
		string LandingPagePath { get; }

		// -(instancetype _Nullable)initForLandingPageAt:(NSString * _Nonnull)landingPage;
		[Export("initForLandingPageAt:")]
		IntPtr Constructor(string landingPage);

		// -(instancetype _Nullable)initForLandingPageAtWithURL:(NSURL * _Nonnull)landingPage;
		[Export("initForLandingPageAtWithURL:")]
		IntPtr Constructor(NSUrl landingPage);
	}

	// @interface ETLocationManager : NSObject <CLLocationManagerDelegate>
	[BaseType(typeof(NSObject))]
	interface ETLocationManager : ICLLocationManagerDelegate
	{
		// @property (getter = isUpdatingGeofences, nonatomic) BOOL updatingGeofences;
		[Export("updatingGeofences")]
		bool UpdatingGeofences { [Bind("isUpdatingGeofences")] get; set; }

		// +(ETLocationManager * _Nonnull)locationManager __attribute__((deprecated("The locationManager method is deprecated. Please use sharedInstance instead.")));
		[Static]
		[Export("locationManager")]
		ETLocationManager LocationManager { get; }

		// +(instancetype _Nonnull)sharedInstance;
		[Static]
		[Export("sharedInstance")]
		ETLocationManager SharedInstance();

		// -(BOOL)locationEnabled;
		[Export("locationEnabled")]
		bool LocationEnabled { get; }

		// -(void)startWatchingLocation;
		[Export("startWatchingLocation")]
		void StartWatchingLocation();

		// -(void)stopWatchingLocation;
		[Export("stopWatchingLocation")]
		void StopWatchingLocation();

		// -(void)appInForeground;
		[Export("appInForeground")]
		void AppInForeground();

		// -(void)appInBackground;
		[Export("appInBackground")]
		void AppInBackground();

		// -(void)updateLocationAndRetrieveMessages:(CLLocation * _Nonnull)loc forAppState:(LocationUpdateAppState)state;
		[Export("updateLocationAndRetrieveMessages:forAppState:")]
		void UpdateLocationAndRetrieveMessages(CLLocation loc, LocationUpdateAppState state);

		// -(void)monitorRegions:(NSSet<__kindof CLRegion *> * _Nonnull)fences ofRequestType:(ETRegionRequestType)requestType;
		[Export("monitorRegions:ofRequestType:")]
		void MonitorRegions(NSSet<CLRegion> fences, ETRegionRequestType requestType);

		// -(void)stopMonitoringRegions;
		[Export("stopMonitoringRegions")]
		void StopMonitoringRegions();

		// -(NSSet<__kindof CLRegion *> * _Nonnull)monitoredRegions;
		[Export("monitoredRegions")]
		NSSet<CLRegion> MonitoredRegions { get; }

		// -(NSDictionary<NSString *,NSString *> * _Nonnull)lastKnownLocation;
		[Export("lastKnownLocation")]
		NSDictionary<NSString, NSString> LastKnownLocation { get; }

		// -(BOOL)getWatchingLocation;
		[Export("getWatchingLocation")]
		bool WatchingLocation { get; }
	}

	// @interface ETRegion : ETGenericUpdate
	[BaseType(typeof(ETGenericUpdate))]
	interface ETRegion : ObjCRuntime.INativeObject
	{
		// @property (copy, nonatomic) NSString * _Nullable fenceIdentifier;
		[NullAllowed, Export("fenceIdentifier")]
		string FenceIdentifier { get; set; }

		// @property (copy, nonatomic) NSNumber * _Nullable latitude;
		[NullAllowed, Export("latitude", ArgumentSemantic.Copy)]
		NSNumber Latitude { get; set; }

		// @property (copy, nonatomic) NSNumber * _Nullable longitude;
		[NullAllowed, Export("longitude", ArgumentSemantic.Copy)]
		NSNumber Longitude { get; set; }

		// @property (copy, nonatomic) NSNumber * _Nullable radius;
		[NullAllowed, Export("radius", ArgumentSemantic.Copy)]
		NSNumber Radius { get; set; }

		// @property (readonly, copy, nonatomic) NSArray * _Nullable messages;
		[NullAllowed, Export("messages", ArgumentSemantic.Copy)]
		NSObject[] Messages { get; }

		// @property (copy, nonatomic) NSString * _Nullable proximityUUID;
		[NullAllowed, Export("proximityUUID")]
		string ProximityUUID { get; set; }

		// @property (copy, nonatomic) NSNumber * _Nullable majorNumber;
		[NullAllowed, Export("majorNumber", ArgumentSemantic.Copy)]
		NSNumber MajorNumber { get; set; }

		// @property (copy, nonatomic) NSNumber * _Nullable minorNumber;
		[NullAllowed, Export("minorNumber", ArgumentSemantic.Copy)]
		NSNumber MinorNumber { get; set; }

		// @property (readonly, copy, nonatomic) NSNumber * _Nullable entryCount;
		[NullAllowed, Export("entryCount", ArgumentSemantic.Copy)]
		NSNumber EntryCount { get; }

		// @property (readonly, copy, nonatomic) NSNumber * _Nullable exitCount;
		[NullAllowed, Export("exitCount", ArgumentSemantic.Copy)]
		NSNumber ExitCount { get; }

		// @property (copy, nonatomic) NSString * _Nullable regionName;
		[NullAllowed, Export("regionName")]
		string RegionName { get; set; }

		// @property (assign, nonatomic) MobilePushGeofenceType locationType;
		[Export("locationType", ArgumentSemantic.Assign)]
		MobilePushGeofenceType LocationType { get; set; }

		// @property (nonatomic) ETRegionRequestType requestType;
		[Export("requestType", ArgumentSemantic.Assign)]
		ETRegionRequestType RequestType { get; set; }

		// -(instancetype _Nullable)initFromDictionary:(NSDictionary<__kindof NSString *,id> * _Nonnull)dict;
		[Export("initFromDictionary:")]
		IntPtr Constructor(NSDictionary<NSString, NSObject> dict);

		// -(BOOL)isEqualToRegion:(ETRegion * _Nonnull)region;
		[Export("isEqualToRegion:")]
		bool IsEqualToRegion(ETRegion region);

		// -(CLLocation * _Nullable)regionAsLocation;
		[NullAllowed, Export("regionAsLocation")]
		CLLocation RegionAsLocation { get; }

		// -(CLRegion * _Nullable)regionAsCLRegion;
		[NullAllowed, Export("regionAsCLRegion")]
		CLRegion RegionAsCLRegion { get; }

		// -(CLBeaconRegion * _Nullable)regionAsBeaconRegion;
		[NullAllowed, Export("regionAsBeaconRegion")]
		CLBeaconRegion RegionAsBeaconRegion { get; }

		// -(BOOL)isGeofenceRegion;
		[Export("isGeofenceRegion")]
		bool IsGeofenceRegion { get; }

		// -(BOOL)isBeaconRegion;
		[Export("isBeaconRegion")]
		bool IsBeaconRegion { get; }

		// +(ETRegion * _Nullable)getRegionByIdentifier:(NSString * _Nonnull)identifier;
		[Static]
		[Export("getRegionByIdentifier:")]
		[return: NullAllowed]
		ETRegion GetRegionByIdentifier(string identifier);

		// +(ETRegion * _Nullable)getBeaconRegionForRegionWithProximityUUID:(NSString * _Nonnull)proximityUUID andMajorNumber:(NSNumber * _Nonnull)majorNumber andMinorNumber:(NSNumber * _Nonnull)minorNumber;
		[Static]
		[Export("getBeaconRegionForRegionWithProximityUUID:andMajorNumber:andMinorNumber:")]
		[return: NullAllowed]
		ETRegion GetBeaconRegionForRegionWithProximityUUID(string proximityUUID, NSNumber majorNumber, NSNumber minorNumber);

		// +(ETRegion * _Nullable)getBeaconRegionForRegionWithProximityUUID:(NSString * _Nonnull)proximityUUID;
		[Static]
		[Export("getBeaconRegionForRegionWithProximityUUID:")]
		[return: NullAllowed]
		ETRegion GetBeaconRegionForRegionWithProximityUUID(string proximityUUID);

		// +(NSSet<__kindof ETRegion *> * _Nullable)getFencesFromCache;
		[Static]
		[NullAllowed, Export("getFencesFromCache")]
		NSSet<ETRegion> FencesFromCache { get; }

		// +(NSSet<__kindof ETRegion *> * _Nullable)getFencesFromCacheIncludingInactive:(BOOL)getInactive;
		[Static]
		[Export("getFencesFromCacheIncludingInactive:")]
		[return: NullAllowed]
		NSSet<ETRegion> GetFencesFromCacheIncludingInactive(bool getInactive);

		// +(BOOL)invalidateAllRegionsForRequestType:(ETRegionRequestType)requestType;
		[Static]
		[Export("invalidateAllRegionsForRequestType:")]
		bool InvalidateAllRegionsForRequestType(ETRegionRequestType requestType);

		// +(BOOL)invalidateAllRegions;
		[Static]
		[Export("invalidateAllRegions")]
		bool InvalidateAllRegions { get; }

		// +(void)retrieveGeofencesFromET;
		[Static]
		[Export("retrieveGeofencesFromET")]
		void RetrieveGeofencesFromET();

		// +(void)retrieveProximityFromET;
		[Static]
		[Export("retrieveProximityFromET")]
		void RetrieveProximityFromET();

		// +(BOOL)generatePersistentDataSchemaInDatabase;
		[Static]
		[Export("generatePersistentDataSchemaInDatabase")]
		bool GeneratePersistentDataSchemaInDatabase { get; }

		// -(ETEventRegion * _Nullable)regionAsETEventRegion;
		[NullAllowed, Export("regionAsETEventRegion")]
		ETEventRegion RegionAsETEventRegion { get; }
	}

	// @interface ETMessage : ETGenericUpdate
	[BaseType(typeof(ETGenericUpdate))]
	interface ETMessage
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable messageIdentifier;
		[NullAllowed, Export("messageIdentifier")]
		string MessageIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable messageName;
		[NullAllowed, Export("messageName")]
		string MessageName { get; }

		// @property (readonly, nonatomic) MobilePushMessageType messageType;
		[Export("messageType")]
		MobilePushMessageType MessageType { get; }

		// @property (readonly, nonatomic) MobilePushContentType contentType;
		[Export("contentType")]
		MobilePushContentType ContentType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable alert;
		[NullAllowed, Export("alert")]
		string Alert { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable sound;
		[NullAllowed, Export("sound")]
		string Sound { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable badge;
		[NullAllowed, Export("badge")]
		string Badge { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable category;
		[NullAllowed, Export("category")]
		string Category { get; }

		// @property (readonly, copy, nonatomic) NSArray * _Nullable keyValuePairs;
		[NullAllowed, Export("keyValuePairs", ArgumentSemantic.Copy)]
		NSObject[] KeyValuePairs { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable startDate;
		[NullAllowed, Export("startDate", ArgumentSemantic.Copy)]
		NSDate StartDate { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable endDate;
		[NullAllowed, Export("endDate", ArgumentSemantic.Copy)]
		NSDate EndDate { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteIdentifier;
		[NullAllowed, Export("siteIdentifier")]
		string SiteIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteUrlAsString;
		[NullAllowed, Export("siteUrlAsString")]
		string SiteUrlAsString { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable openDirectPayload;
		[NullAllowed, Export("openDirectPayload")]
		string OpenDirectPayload { get; }

		// @property (readonly, nonatomic, strong) ETRegion * _Nullable relatedFence;
		[NullAllowed, Export("relatedFence", ArgumentSemantic.Strong)]
		ETRegion RelatedFence { get; }

		// @property (readonly, copy, nonatomic) NSNumber * _Nullable messageLimit;
		[NullAllowed, Export("messageLimit", ArgumentSemantic.Copy)]
		NSNumber MessageLimit { get; }

		// @property (readonly, copy, nonatomic) NSNumber * _Nullable messagesPerPeriod;
		[NullAllowed, Export("messagesPerPeriod", ArgumentSemantic.Copy)]
		NSNumber MessagesPerPeriod { get; }

		// @property (readonly, copy, nonatomic) NSNumber * _Nullable numberOfPeriods;
		[NullAllowed, Export("numberOfPeriods", ArgumentSemantic.Copy)]
		NSNumber NumberOfPeriods { get; }

		// @property (readonly, nonatomic) MobilePushMessageFrequencyUnit periodType;
		[Export("periodType")]
		MobilePushMessageFrequencyUnit PeriodType { get; }

		// @property (readonly, getter = isRollingPeriod, nonatomic) BOOL rollingPeriod;
		[Export("rollingPeriod")]
		bool RollingPeriod { [Bind("isRollingPeriod")] get; }

		// @property (readonly, copy, nonatomic) NSNumber * _Nullable minTripped;
		[NullAllowed, Export("minTripped", ArgumentSemantic.Copy)]
		NSNumber MinTripped { get; }

		// @property (readonly, getter = isEphemeralMessage, nonatomic) BOOL ephemeralMessage;
		[Export("ephemeralMessage")]
		bool EphemeralMessage { [Bind("isEphemeralMessage")] get; }

		// @property (readonly, nonatomic) CLProximity proximity;
		[Export("proximity")]
		CLProximity Proximity { get; }

		// @property (readonly, nonatomic) NSInteger loiteringSeconds;
		[Export("loiteringSeconds")]
		nint LoiteringSeconds { get; }

		// @property (readonly, nonatomic) BOOL read;
		[Export("read")]
		bool Read { get; }

		// @property (readonly, nonatomic) BOOL active;
		[Export("active")]
		bool Active { get; }

		// @property (copy, nonatomic) NSString * _Nullable notificationID;
		[NullAllowed, Export("notificationID")]
		string NotificationID { get; set; }

		// @property (readonly, nonatomic) BOOL hasShownForBeacon;
		[Export("hasShownForBeacon")]
		bool HasShownForBeacon { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable requestId;
		[NullAllowed, Export("requestId")]
		string RequestId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable messageHash;
		[NullAllowed, Export("messageHash")]
		string MessageHash { get; }

		// @property (readonly, copy, nonatomic) NSNumber * _Nullable statusDirty;
		[NullAllowed, Export("statusDirty", ArgumentSemantic.Copy)]
		NSNumber StatusDirty { get; }

		// -(instancetype _Nullable)initFromDictionary:(NSDictionary<__kindof NSString *,id> * _Nonnull)dict;
		[Export("initFromDictionary:")]
		IntPtr Constructor(NSDictionary<NSString, NSObject> dict);

		// -(instancetype _Nullable)initFromDictionary:(NSDictionary<__kindof NSString *,id> * _Nonnull)dict forFence:(ETRegion * _Nullable)region;
		[Export("initFromDictionary:forFence:")]
		IntPtr Constructor(NSDictionary<NSString, NSObject> dict, [NullAllowed] ETRegion region);

		// -(NSString * _Nullable)subject;
		[NullAllowed, Export("subject")]
		string Subject { get; }

		// -(NSURL * _Nullable)siteURL;
		[NullAllowed, Export("siteURL")]
		NSUrl SiteURL { get; }

		// -(BOOL)messageScheduledForDisplay;
		[Export("messageScheduledForDisplay")]
		bool MessageScheduledForDisplay { get; }

		// -(NSDate * _Nullable)getLastShownDate;
		[NullAllowed, Export("getLastShownDate")]
		NSDate LastShownDate { get; }

		// -(int)getShowCount;
		[Export("getShowCount")]
		int ShowCount { get; }

		// +(NSArray * _Nullable)getCloudPageMessages;
		[Static]
		[NullAllowed, Export("getCloudPageMessages")]
		NSObject[] CloudPageMessages { get; }

		// +(NSInteger)getReadMessageCount;
		[Static]
		[Export("getReadMessageCount")]
		nint ReadMessageCount { get; }

		// +(NSInteger)getUnreadMessageCount;
		[Static]
		[Export("getUnreadMessageCount")]
		nint UnreadMessageCount { get; }

		// +(NSInteger)getMessageCount;
		[Static]
		[Export("getMessageCount")]
		nint MessageCount { get; }

		// +(void)markAllAsRead;
		[Static]
		[Export("markAllAsRead")]
		void MarkAllAsRead();

		// -(BOOL)markAsRead;
		[Export("markAsRead")]
		bool MarkAsRead { get; }

		// -(BOOL)markAsDeleted;
		[Export("markAsDeleted")]
		bool MarkAsDeleted { get; }

		// +(void)trackInboxMessageOpened:(ETCloudPage * _Nonnull)cloudPageInboxMessage;
		[Static]
		[Export("trackInboxMessageOpened:")]
		void TrackInboxMessageOpened(ETCloudPage cloudPageInboxMessage);

		// +(NSArray<__kindof ETMessage *> * _Nullable)getMessagesByContentType:(MobilePushContentType)contentType;
		[Static]
		[Export("getMessagesByContentType:")]
		[return: NullAllowed]
		ETMessage[] GetMessagesByContentType(MobilePushContentType contentType);

		// +(ETMessage * _Nullable)getMessageByIdentifier:(NSString * _Nonnull)identifier;
		[Static]
		[Export("getMessageByIdentifier:")]
		[return: NullAllowed]
		ETMessage GetMessageByIdentifier(string identifier);

		// +(NSArray<__kindof ETMessage *> * _Nullable)getMessagesByType:(MobilePushMessageType)type;
		[Static]
		[Export("getMessagesByType:")]
		[return: NullAllowed]
		ETMessage[] GetMessagesByType(MobilePushMessageType type);

		// +(NSArray<__kindof ETMessage *> * _Nullable)getMessagesForGeofence:(ETRegion * _Nonnull)fence;
		[Static]
		[Export("getMessagesForGeofence:")]
		[return: NullAllowed]
		ETMessage[] GetMessagesForGeofence(ETRegion fence);

		// +(NSArray<__kindof ETMessage *> * _Nullable)getMessagesForGeofence:(ETRegion * _Nonnull)fence andMessageType:(MobilePushMessageType)type;
		[Static]
		[Export("getMessagesForGeofence:andMessageType:")]
		[return: NullAllowed]
		ETMessage[] GetMessagesForGeofence(ETRegion fence, MobilePushMessageType type);

		// +(NSArray<__kindof ETMessage *> * _Nullable)getProximityMessagesForRegion:(ETRegion * _Nonnull)region;
		[Static]
		[Export("getProximityMessagesForRegion:")]
		[return: NullAllowed]
		ETMessage[] GetProximityMessagesForRegion(ETRegion region);

		// +(void)getMessagesFromExactTargetOfMessageType:(MobilePushMessageType)messageType andContentType:(MobilePushContentType)contentType;
		[Static]
		[Export("getMessagesFromExactTargetOfMessageType:andContentType:")]
		void GetMessagesFromExactTargetOfMessageType(MobilePushMessageType messageType, MobilePushContentType contentType);

		// +(BOOL)invalidateAllMessagesForType:(MobilePushMessageType)type;
		[Static]
		[Export("invalidateAllMessagesForType:")]
		bool InvalidateAllMessagesForType(MobilePushMessageType type);

		// +(BOOL)invalidateAllMessagesForContentType:(MobilePushContentType)type;
		[Static]
		[Export("invalidateAllMessagesForContentType:")]
		bool InvalidateAllMessagesForContentType(MobilePushContentType type);

		// -(BOOL)isEqualToMessage:(ETMessage * _Nonnull)message;
		[Export("isEqualToMessage:")]
		bool IsEqualToMessage(ETMessage message);

		// -(ETEventMessage * _Nullable)messageAsETEventMessage;
		[NullAllowed, Export("messageAsETEventMessage")]
		ETEventMessage MessageAsETEventMessage { get; }

		// -(ETCloudPage * _Nullable)messageAsETCloudPage;
		[NullAllowed, Export("messageAsETCloudPage")]
		ETCloudPage MessageAsETCloudPage { get; }
	}

	// @protocol ExactTargetOpenDirectDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface ExactTargetOpenDirectDelegate
	{
		// @required -(void)didReceiveOpenDirectMessageWithContents:(NSString * _Nonnull)payload;
		[Abstract]
		[Export("didReceiveOpenDirectMessageWithContents:")]
		void DidReceiveOpenDirectMessageWithContents(string payload);

		// @optional -(BOOL)shouldDeliverOpenDirectMessageIfAppIsRunning;
		[Export("shouldDeliverOpenDirectMessageIfAppIsRunning")]
		bool ShouldDeliverOpenDirectMessageIfAppIsRunning { get; }
	}

	// @protocol ExactTargetCloudPageWithAlertDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface ExactTargetCloudPageWithAlertDelegate
	{
		// @required -(void)didReceiveCloudPageWithAlertMessageWithContents:(NSString * _Nonnull)payload;
		[Abstract]
		[Export("didReceiveCloudPageWithAlertMessageWithContents:")]
		void DidReceiveCloudPageWithAlertMessageWithContents(string payload);

		// @optional -(BOOL)shouldDeliverCloudPageWithAlertMessageIfAppIsRunning;
		[Export("shouldDeliverCloudPageWithAlertMessageIfAppIsRunning")]
		bool ShouldDeliverCloudPageWithAlertMessageIfAppIsRunning { get; }
	}

	// @interface ETPush : NSObject
	[BaseType(typeof(NSObject))]
	interface ETPush
	{
		// +(instancetype _Nullable)pushManager;
		[Static]
		[Export("pushManager")]
		[return: NullAllowed]
		ETPush PushManager();

		// -(BOOL)configureSDKWithAppID:(NSString * _Nonnull)etAppID andAccessToken:(NSString * _Nonnull)accessToken withAnalytics:(BOOL)analyticsState andLocationServices:(BOOL)locState andProximityServices:(BOOL)proximityState andCloudPages:(BOOL)cpState withPIAnalytics:(BOOL)pIAnalyticsState error:(NSError * _Nullable * _Nullable)configureError;
		[Export("configureSDKWithAppID:andAccessToken:withAnalytics:andLocationServices:andProximityServices:andCloudPages:withPIAnalytics:error:")]
		bool ConfigureSDKWithAppID(string etAppID, string accessToken, bool analyticsState, bool locState, bool proximityState, bool cpState, bool pIAnalyticsState, [NullAllowed] out NSError configureError);

		// -(BOOL)shouldShowLocalAlert;
		[Export("shouldShowLocalAlert")]
		bool ShouldShowLocalAlert { get; }

		// -(id<ExactTargetOpenDirectDelegate> _Nullable)openDirectDelegate;
		// -(void)setOpenDirectDelegate:(id<ExactTargetOpenDirectDelegate> _Nullable)delegate;
		[NullAllowed, Export("openDirectDelegate")]
		ExactTargetOpenDirectDelegate OpenDirectDelegate { get; set; }

		// -(id<ExactTargetCloudPageWithAlertDelegate> _Nullable)cloudPageWithAlertDelegate;
		// -(void)setCloudPageWithAlertDelegate:(id<ExactTargetCloudPageWithAlertDelegate> _Nullable)delegate;
		[NullAllowed, Export("cloudPageWithAlertDelegate")]
		ExactTargetCloudPageWithAlertDelegate CloudPageWithAlertDelegate { get; set; }

		// -(void)updateET;
		[Export("updateET")]
		void UpdateET();

		// -(void)registerForRemoteNotificationsWithDelegate:(id<UNUserNotificationCenterDelegate> _Nullable)delegate options:(UNAuthorizationOptions)options categories:(NSSet<UNNotificationCategory *> * _Nullable)categories completionHandler:(void (^ _Nonnull)(BOOL, NSError * _Nullable))completionHandler;
		[Export("registerForRemoteNotificationsWithDelegate:options:categories:completionHandler:")]
		void RegisterForRemoteNotificationsWithDelegate([NullAllowed] UNUserNotificationCenterDelegate @delegate, UNAuthorizationOptions options, [NullAllowed] NSSet<UNNotificationCategory> categories, Action<bool, NSError> completionHandler);

		// -(void)registeredForRemoteNotificationsWithCompletionHandler:(void (^ _Nonnull)(BOOL, UNAuthorizationOptions))completionHandler;
		[Export("registeredForRemoteNotificationsWithCompletionHandler:")]
		void RegisteredForRemoteNotificationsWithCompletionHandler(Action<bool, UNAuthorizationOptions> completionHandler);

		// -(void)currentUserNotificationSettingsWithCompletionHandler:(void (^ _Nonnull)(UNNotificationSettings * _Nonnull))completionHandler;
		[Export("currentUserNotificationSettingsWithCompletionHandler:")]
		void CurrentUserNotificationSettingsWithCompletionHandler(Action<UNNotificationSettings> completionHandler);

		// -(void)setUserNotificationCenterDelegate:(id<UNUserNotificationCenterDelegate> _Nullable)delegate;
		[Export("setUserNotificationCenterDelegate:")]
		void SetUserNotificationCenterDelegate([NullAllowed] UNUserNotificationCenterDelegate @delegate);

		// -(void)setUserNotificationCenterCategories:(NSSet<UNNotificationCategory *> * _Nullable)categories;
		[Export("setUserNotificationCenterCategories:")]
		void SetUserNotificationCenterCategories([NullAllowed] NSSet<UNNotificationCategory> categories);

		// -(void)getUserNotificationCenterCategoriesWithCompletionHandler:(void (^ _Nonnull)(NSSet<UNNotificationCategory *> * _Nonnull))completionHandler;
		[Export("getUserNotificationCenterCategoriesWithCompletionHandler:")]
		void GetUserNotificationCenterCategoriesWithCompletionHandler(Action<NSSet<UNNotificationCategory>> completionHandler);

		// -(void)addNotificationRequest:(UNNotificationRequest * _Nonnull)request withCompletionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export("addNotificationRequest:withCompletionHandler:")]
		void AddNotificationRequest(UNNotificationRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(void)getPendingNotificationRequestsWithCompletionHandler:(void (^ _Nonnull)(NSArray<UNNotificationRequest *> * _Nonnull))completionHandler;
		[Export("getPendingNotificationRequestsWithCompletionHandler:")]
		void GetPendingNotificationRequestsWithCompletionHandler(Action<NSArray<UNNotificationRequest>> completionHandler);

		// -(void)removePendingNotificationRequestsWithIdentifiers:(NSArray<NSString *> * _Nonnull)identifiers;
		[Export("removePendingNotificationRequestsWithIdentifiers:")]
		void RemovePendingNotificationRequestsWithIdentifiers(string[] identifiers);

		// -(void)removeAllPendingNotificationRequests;
		[Export("removeAllPendingNotificationRequests")]
		void RemoveAllPendingNotificationRequests();

		// -(void)getDeliveredNotificationsWithCompletionHandler:(void (^ _Nonnull)(NSArray<UNNotification *> * _Nonnull))completionHandler;
		[Export("getDeliveredNotificationsWithCompletionHandler:")]
		void GetDeliveredNotificationsWithCompletionHandler(Action<NSArray<UNNotification>> completionHandler);

		// -(void)removeDeliveredNotificationsWithIdentifiers:(NSArray<NSString *> * _Nonnull)identifiers;
		[Export("removeDeliveredNotificationsWithIdentifiers:")]
		void RemoveDeliveredNotificationsWithIdentifiers(string[] identifiers);

		// -(void)removeAllDeliveredNotifications;
		[Export("removeAllDeliveredNotifications")]
		void RemoveAllDeliveredNotifications();

		// -(void)registerForRemoteNotifications;
		[Export("registerForRemoteNotifications")]
		void RegisterForRemoteNotifications();

		// -(BOOL)isRegisteredForRemoteNotifications;
		[Export("isRegisteredForRemoteNotifications")]
		bool IsRegisteredForRemoteNotifications { get; }

		// -(void)registerUserNotificationSettings:(UIUserNotificationSettings * _Nonnull)notificationSettings;
		[Export("registerUserNotificationSettings:")]
		void RegisterUserNotificationSettings(UIUserNotificationSettings notificationSettings);

		// -(UIUserNotificationSettings * _Nonnull)currentUserNotificationSettings;
		[Export("currentUserNotificationSettings")]
		UIUserNotificationSettings CurrentUserNotificationSettings { get; }

		// -(void)didRegisterUserNotificationSettings:(UIUserNotificationSettings * _Nonnull)notificationSettings;
		[Export("didRegisterUserNotificationSettings:")]
		void DidRegisterUserNotificationSettings(UIUserNotificationSettings notificationSettings);

		// -(void)registerDeviceToken:(NSData * _Nonnull)deviceToken;
		[Export("registerDeviceToken:")]
		void RegisterDeviceToken(NSData deviceToken);

		// -(NSString * _Nullable)deviceToken;
		[NullAllowed, Export("deviceToken")]
		string DeviceToken { get; }

		// -(void)applicationDidFailToRegisterForRemoteNotificationsWithError:(NSError * _Nonnull)error;
		[Export("applicationDidFailToRegisterForRemoteNotificationsWithError:")]
		void ApplicationDidFailToRegisterForRemoteNotificationsWithError(NSError error);

		// -(void)shouldDisplayAlertViewIfPushReceived:(BOOL)desiredState;
		[Export("shouldDisplayAlertViewIfPushReceived:")]
		void ShouldDisplayAlertViewIfPushReceived(bool desiredState);

		// -(void)applicationLaunchedWithOptions:(NSDictionary * _Nullable)launchOptions;
		[Export("applicationLaunchedWithOptions:")]
		void ApplicationLaunchedWithOptions([NullAllowed] NSDictionary launchOptions);

		// -(void)applicationTerminated;
		[Export("applicationTerminated")]
		void ApplicationTerminated();

		// -(void)handleNotification:(NSDictionary * _Nonnull)userInfo forApplicationState:(UIApplicationState)applicationState;
		[Export("handleNotification:forApplicationState:")]
		void HandleNotification(NSDictionary userInfo, UIApplicationState applicationState);

		// -(void)handleRemoteNotification:(NSDictionary * _Nullable)userInfo;
		[Export("handleRemoteNotification:")]
		void HandleRemoteNotification([NullAllowed] NSDictionary userInfo);

		// -(void)handleLocalNotification:(UILocalNotification * _Nullable)localNotification;
		[Export("handleLocalNotification:")]
		void HandleLocalNotification([NullAllowed] UILocalNotification localNotification);

		// -(void)handleUserNotificationResponse:(UNNotificationResponse * _Nullable)notificationResponse;
		[Export("handleUserNotificationResponse:")]
		void HandleUserNotificationResponse([NullAllowed] UNNotificationResponse notificationResponse);

		// -(BOOL)setSubscriberKey:(NSString * _Nonnull)subscriberKey;
		[Export("setSubscriberKey:")]
		bool SetSubscriberKey(string subscriberKey);

		// -(NSString * _Nullable)getSubscriberKey;
		[NullAllowed, Export("getSubscriberKey")]
		string SubscriberKey { get; }

		// -(BOOL)addTag:(NSString * _Nonnull)tag;
		[Export("addTag:")]
		bool AddTag(string tag);

		// -(NSString * _Nullable)removeTag:(NSString * _Nonnull)tag;
		[Export("removeTag:")]
		[return: NullAllowed]
		string RemoveTag(string tag);

		// -(NSSet * _Nonnull)allTags __attribute__((deprecated("allTags is deprecated. Please use getTags instead.")));
		[Export("allTags")]
		NSSet AllTags { get; }

		// -(NSSet * _Nonnull)getTags;
		[Export("getTags")]
		NSSet Tags { get; }

		// -(BOOL)addAttributeNamed:(NSString * _Nonnull)name value:(NSString * _Nonnull)value;
		[Export("addAttributeNamed:value:")]
		bool AddAttributeNamed(string name, string value);

		// -(NSString * _Nullable)removeAttributeNamed:(NSString * _Nonnull)name;
		[Export("removeAttributeNamed:")]
		[return: NullAllowed]
		string RemoveAttributeNamed(string name);

		// -(NSDictionary * _Nonnull)allAttributes __attribute__((deprecated("allAttributes has been deprecated. Please use getAttributes instead")));
		[Export("allAttributes")]
		NSDictionary AllAttributes { get; }

		// -(NSDictionary * _Nonnull)getAttributes;
		[Export("getAttributes")]
		NSDictionary Attributes { get; }

		// -(void)startListeningForApplicationNotifications;
		[Export("startListeningForApplicationNotifications")]
		void StartListeningForApplicationNotifications();

		// -(void)stopListeningForApplicationNotifications;
		[Export("stopListeningForApplicationNotifications")]
		void StopListeningForApplicationNotifications();

		// -(void)applicationDidBecomeActiveNotificationReceived;
		[Export("applicationDidBecomeActiveNotificationReceived")]
		void ApplicationDidBecomeActiveNotificationReceived();

		// -(void)applicationDidEnterBackgroundNotificationReceived;
		[Export("applicationDidEnterBackgroundNotificationReceived")]
		void ApplicationDidEnterBackgroundNotificationReceived();

		// +(NSString * _Nonnull)safeDeviceIdentifier;
		[Static]
		[Export("safeDeviceIdentifier")]
		string SafeDeviceIdentifier { get; }

		// +(NSString * _Nonnull)hardwareIdentifier;
		[Static]
		[Export("hardwareIdentifier")]
		string HardwareIdentifier { get; }

		// +(BOOL)isPushEnabled;
		[Static]
		[Export("isPushEnabled")]
		bool IsPushEnabled { get; }

		// +(NSString * _Nonnull)getSDKVersionName;
		[Static]
		[Export("getSDKVersionName")]
		string SDKVersionName { get; }

		// +(NSString * _Nonnull)getSDKVersionCode;
		[Static]
		[Export("getSDKVersionCode")]
		string SDKVersionCode { get; }

		// +(void)setETLoggerToRequiredState:(BOOL)state;
		[Static]
		[Export("setETLoggerToRequiredState:")]
		void SetETLoggerToRequiredState(bool state);

		// +(void)setLoggerWithHandler:(void (^ _Nullable)(NSString * _Nonnull))customLogger;
		[Static]
		[Export("setLoggerWithHandler:")]
		void SetLoggerWithHandler([NullAllowed] Action<NSString> customLogger);

		// +(NSString * _Nullable)getSDKState;
		[Static]
		[NullAllowed, Export("getSDKState")]
		string SDKState { get; }

		// -(BOOL)refreshWithFetchCompletionHandler:(void (^ _Nullable)(UIBackgroundFetchResult))completionHandler;
		[Export("refreshWithFetchCompletionHandler:")]
		bool RefreshWithFetchCompletionHandler([NullAllowed] Action<UIBackgroundFetchResult> completionHandler);

		// +(NSArray * _Nonnull)getCloudPages;
		[Static]
		[Export("getCloudPages")]
		NSObject[] CloudPages { get; }
	}

	// @interface ETWKLandingPagePresenter : UIViewController <WKNavigationDelegate>
	[BaseType(typeof(UIViewController))]
	interface ETWKLandingPagePresenter : IWKNavigationDelegate
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull landingPagePath;
		[Export("landingPagePath")]
		string LandingPagePath { get; }

		// -(instancetype _Nullable)initForLandingPageAt:(NSString * _Nonnull)landingPage;
		[Export("initForLandingPageAt:")]
		IntPtr Constructor(string landingPage);

		// -(instancetype _Nullable)initForLandingPageAtWithURL:(NSURL * _Nonnull)landingPage;
		[Export("initForLandingPageAtWithURL:")]
		IntPtr Constructor(NSUrl landingPage);
	}

	// @interface ExactTargetEnhancedPushDataSource : NSObject <UITableViewDataSource>
	[BaseType(typeof(NSObject))]
	interface ExactTargetEnhancedPushDataSource : IUITableViewDataSource
	{
		// @property (readonly, copy, nonatomic) NSArray<__kindof ETMessage *> * _Nullable messages;
		[NullAllowed, Export("messages", ArgumentSemantic.Copy)]
		ETMessage[] Messages { get; }

		// @property (nonatomic, weak) UITableView * _Nullable inboxTableView;
		[NullAllowed, Export("inboxTableView", ArgumentSemantic.Weak)]
		UITableView InboxTableView { get; set; }
	}

	// @interface PICart : NSObject <NSCoding, NSCopying>
	[BaseType(typeof(NSObject))]
	interface PICart : INSCoding, INSCopying
	{
		// -(instancetype _Nonnull)initWithCartItems:(NSArray * _Nonnull)cartItems __attribute__((objc_designated_initializer));
		[Export("initWithCartItems:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSObject[] cartItems);

		// -(NSDictionary * _Nonnull)dictionaryRepresentation;
		[Export("dictionaryRepresentation")]
		NSDictionary DictionaryRepresentation { get; }
	}

	// @interface PICartItem : NSObject <NSCoding, NSCopying>
	[BaseType(typeof(NSObject))]
	interface PICartItem : INSCoding, INSCopying
	{
		// -(instancetype _Nonnull)initWithPrice:(NSNumber * _Nonnull)price quantity:(NSNumber * _Nonnull)quantity item:(NSString * _Nonnull)item;
		[Export("initWithPrice:quantity:item:")]
		IntPtr Constructor(NSNumber price, NSNumber quantity, string item);

		// -(instancetype _Nonnull)initWithPrice:(NSNumber * _Nonnull)price quantity:(NSNumber * _Nonnull)quantity item:(NSString * _Nonnull)item uniqueId:(NSString * _Nonnull)uniqueId;
		[Export("initWithPrice:quantity:item:uniqueId:")]
		IntPtr Constructor(NSNumber price, NSNumber quantity, string item, string uniqueId);

		// -(NSDictionary * _Nonnull)dictionaryRepresentation;
		[Export("dictionaryRepresentation")]
		NSDictionary DictionaryRepresentation { get; }
	}

	// @interface PIOrder : NSObject <NSCoding, NSCopying>
	[BaseType(typeof(NSObject))]
	interface PIOrder : INSCoding, INSCopying
	{
		// -(instancetype _Nonnull)initWithOrderNumber:(NSString * _Nonnull)orderNumber shipping:(NSNumber * _Nonnull)shipping discount:(NSNumber * _Nonnull)discount cart:(PICart * _Nonnull)cart __attribute__((objc_designated_initializer));
		[Export("initWithOrderNumber:shipping:discount:cart:")]
		[DesignatedInitializer]
		IntPtr Constructor(string orderNumber, NSNumber shipping, NSNumber discount, PICart cart);

		// -(NSDictionary * _Nonnull)dictionaryRepresentation;
		[Export("dictionaryRepresentation")]
		NSDictionary DictionaryRepresentation { get; }
	}
}

