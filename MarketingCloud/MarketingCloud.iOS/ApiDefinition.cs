using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;
using UserNotifications;

namespace MarketingCloud
{
    // @interface MarketingCloudSDK : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MarketingCloudSDK
    {
        // +(instancetype _Nonnull)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        MarketingCloudSDK SharedInstance();

        // -(BOOL)sfmc_configure:(NSError * _Nullable * _Nullable)error;
        [Export("sfmc_configure:")]
        bool Sfmc_configure([NullAllowed] out NSError error);

        // -(BOOL)sfmc_configureWithDictionary:(NSDictionary * _Nonnull)configuration error:(NSError * _Nullable * _Nullable)error;
        [Export("sfmc_configureWithDictionary:error:")]
        bool Sfmc_configureWithDictionary(NSDictionary configuration, [NullAllowed] out NSError error);

        // -(BOOL)sfmc_configureWithDictionary:(NSDictionary * _Nonnull)configuration error:(NSError * _Nullable * _Nullable)error completionHandler:(void (^ _Nullable)(BOOL, NSString * _Nonnull, NSError * _Nonnull))completionHandler;
        [Export("sfmc_configureWithDictionary:error:completionHandler:")]
        bool Sfmc_configureWithDictionary(NSDictionary configuration, [NullAllowed] out NSError error, [NullAllowed] Action<bool, NSString, NSError> completionHandler);

        // -(BOOL)sfmc_configureWithURL:(NSURL * _Nullable)url configurationIndex:(NSNumber * _Nonnull)configurationIndex error:(NSError * _Nullable * _Nullable)error;
        [Export("sfmc_configureWithURL:configurationIndex:error:")]
        bool Sfmc_configureWithURL([NullAllowed] NSUrl url, NSNumber configurationIndex, [NullAllowed] out NSError error);

        // -(BOOL)sfmc_configure:(NSError * _Nullable * _Nullable)error completionHandler:(void (^ _Nullable)(BOOL, NSString * _Nonnull, NSError * _Nullable))completionHandler;
        [Export("sfmc_configure:completionHandler:")]
        bool Sfmc_configure([NullAllowed] out NSError error, [NullAllowed] Action<bool, NSString, NSError> completionHandler);

        // -(BOOL)sfmc_configureWithURL:(NSURL * _Nonnull)url configurationIndex:(NSNumber * _Nonnull)configurationIndex error:(NSError * _Nullable * _Nullable)error completionHandler:(void (^ _Nullable)(BOOL, NSString * _Nonnull, NSError * _Nullable))completionHandler;
        [Export("sfmc_configureWithURL:configurationIndex:error:completionHandler:")]
        bool Sfmc_configureWithURL(NSUrl url, NSNumber configurationIndex, [NullAllowed] out NSError error, [NullAllowed] Action<bool, NSString, NSError> completionHandler);

        // -(void)sfmc_tearDown;
        [Export("sfmc_tearDown")]
        void Sfmc_tearDown();

        // -(BOOL)sfmc_setContactKey:(NSString * _Nonnull)contactKey;
        [Export("sfmc_setContactKey:")]
        bool Sfmc_setContactKey(string contactKey);

        // -(NSString * _Nullable)sfmc_contactKey;
        [NullAllowed, Export("sfmc_contactKey")]
        //[Verify (MethodToProperty)]
        string Sfmc_contactKey { get; }

        // -(BOOL)sfmc_addTag:(NSString * _Nonnull)tag;
        [Export("sfmc_addTag:")]
        bool Sfmc_addTag(string tag);

        // -(BOOL)sfmc_removeTag:(NSString * _Nonnull)tag;
        [Export("sfmc_removeTag:")]
        bool Sfmc_removeTag(string tag);

        // -(NSSet * _Nullable)sfmc_addTags:(NSArray * _Nonnull)tags;
        [Export("sfmc_addTags:")]
        //[Verify (StronglyTypedNSArray)]
        [return: NullAllowed]
        NSSet Sfmc_addTags(NSObject[] tags);

        // -(NSSet * _Nullable)sfmc_removeTags:(NSArray * _Nonnull)tags;
        [Export("sfmc_removeTags:")]
        //[Verify (StronglyTypedNSArray)]
        [return: NullAllowed]
        NSSet Sfmc_removeTags(NSObject[] tags);

        // -(NSSet * _Nullable)sfmc_tags;
        [NullAllowed, Export("sfmc_tags")]
        //[Verify (MethodToProperty)]
        NSSet Sfmc_tags { get; }

        // -(BOOL)sfmc_setAttributeNamed:(NSString * _Nonnull)name value:(NSString * _Nonnull)value;
        [Export("sfmc_setAttributeNamed:value:")]
        bool Sfmc_setAttributeNamed(string name, string value);

        // -(BOOL)sfmc_clearAttributeNamed:(NSString * _Nonnull)name;
        [Export("sfmc_clearAttributeNamed:")]
        bool Sfmc_clearAttributeNamed(string name);

        // -(NSDictionary * _Nullable)sfmc_attributes;
        [NullAllowed, Export("sfmc_attributes")]
        //[Verify (MethodToProperty)]
        NSDictionary Sfmc_attributes { get; }

        // -(NSDictionary * _Nullable)sfmc_setAttributes:(NSArray * _Nonnull)attributes;
        [Export("sfmc_setAttributes:")]
        //[Verify (StronglyTypedNSArray)]
        [return: NullAllowed]
        NSDictionary Sfmc_setAttributes(NSObject[] attributes);

        // -(NSDictionary * _Nullable)sfmc_clearAttributesNamed:(NSArray * _Nonnull)attributeNames;
        [Export("sfmc_clearAttributesNamed:")]
        //[Verify (StronglyTypedNSArray)]
        [return: NullAllowed]
        NSDictionary Sfmc_clearAttributesNamed(NSObject[] attributeNames);

        // -(void)sfmc_setDeviceToken:(NSData * _Nonnull)deviceToken;
        [Export("sfmc_setDeviceToken:")]
        void Sfmc_setDeviceToken(NSData deviceToken);

        // -(NSString * _Nullable)sfmc_deviceToken;
        [NullAllowed, Export("sfmc_deviceToken")]
        //[Verify (MethodToProperty)]
        string Sfmc_deviceToken { get; }

        // -(NSString * _Nullable)sfmc_appID;
        [NullAllowed, Export("sfmc_appID")]
        //[Verify (MethodToProperty)]
        string Sfmc_appID { get; }

        // -(NSString * _Nullable)sfmc_accessToken;
        [NullAllowed, Export("sfmc_accessToken")]
        //[Verify (MethodToProperty)]
        string Sfmc_accessToken { get; }

        // -(NSString * _Nullable)sfmc_deviceIdentifier;
        [NullAllowed, Export("sfmc_deviceIdentifier")]
        //[Verify (MethodToProperty)]
        string Sfmc_deviceIdentifier { get; }

        // -(void)sfmc_setNotificationRequest:(UNNotificationRequest * _Nonnull)request __attribute__((availability(ios, introduced=10)));
        //[iOS(10, 0)]
        [Export("sfmc_setNotificationRequest:")]
        void Sfmc_setNotificationRequest(UNNotificationRequest request);

        // -(UNNotificationRequest * _Nonnull)sfmc_notificationRequest __attribute__((availability(ios, introduced=10)));
        //[iOS(10, 0)]
        [Export("sfmc_notificationRequest")]
        //[Verify (MethodToProperty)]
        UNNotificationRequest Sfmc_notificationRequest { get; }

        // -(void)sfmc_setNotificationUserInfo:(NSDictionary * _Nonnull)userInfo;
        [Export("sfmc_setNotificationUserInfo:")]
        void Sfmc_setNotificationUserInfo(NSDictionary userInfo);

        // -(NSDictionary * _Nonnull)sfmc_notificationUserInfo;
        [Export("sfmc_notificationUserInfo")]
        //[Verify (MethodToProperty)]
        NSDictionary Sfmc_notificationUserInfo { get; }

        // -(void)sfmc_setPushEnabled:(BOOL)pushEnabled;
        [Export("sfmc_setPushEnabled:")]
        void Sfmc_setPushEnabled(bool pushEnabled);

        // -(BOOL)sfmc_pushEnabled;
        [Export("sfmc_pushEnabled")]
        //[Verify (MethodToProperty)]
        bool Sfmc_pushEnabled { get; }

        // -(NSString * _Nullable)sfmc_getSDKState;
        [NullAllowed, Export("sfmc_getSDKState")]
        //[Verify (MethodToProperty)]
        string Sfmc_getSDKState { get; }

        // -(void)sfmc_setDebugLoggingEnabled:(BOOL)enabled;
        [Export("sfmc_setDebugLoggingEnabled:")]
        void Sfmc_setDebugLoggingEnabled(bool enabled);

        // -(BOOL)sfmc_getDebugLoggingEnabled;
        [Export("sfmc_getDebugLoggingEnabled")]
        //[Verify (MethodToProperty)]
        bool Sfmc_getDebugLoggingEnabled { get; }

        // -(BOOL)sfmc_refreshWithFetchCompletionHandler:(void (^ _Nullable)(UIBackgroundFetchResult))completionHandler;
        [Export("sfmc_refreshWithFetchCompletionHandler:")]
        bool Sfmc_refreshWithFetchCompletionHandler([NullAllowed] Action<UIBackgroundFetchResult> completionHandler);

        // -(BOOL)sfmc_setSignedString:(NSString * _Nullable)signedString;
        [Export("sfmc_setSignedString:")]
        bool Sfmc_setSignedString([NullAllowed] string signedString);

        // -(NSString * _Nullable)sfmc_signedString;
        [NullAllowed, Export("sfmc_signedString")]
        //[Verify (MethodToProperty)]
        string Sfmc_signedString { get; }
    }

    // @interface Intelligence (MarketingCloudSDK)
    [Category]
    [BaseType(typeof(MarketingCloudSDK))]
    interface MarketingCloudSDK_Intelligence
    {
        // -(BOOL)sfmc_setPiIdentifier:(NSString * _Nullable)identifier;
        [Export("sfmc_setPiIdentifier:")]
        bool Sfmc_setPiIdentifier([NullAllowed] string identifier);

        // -(NSString * _Nullable)sfmc_piIdentifier;
        [NullAllowed, Export("sfmc_piIdentifier")]
        //[Verify (MethodToProperty)]
        string Sfmc_piIdentifier();

        // -(void)sfmc_trackMessageOpened:(NSDictionary * _Nonnull)inboxMessage;
        [Export("sfmc_trackMessageOpened:")]
        void Sfmc_trackMessageOpened(NSDictionary inboxMessage);

        // -(void)sfmc_trackPageViewWithURL:(NSString * _Nonnull)url title:(NSString * _Nullable)title item:(NSString * _Nullable)item search:(NSString * _Nullable)search;
        [Export("sfmc_trackPageViewWithURL:title:item:search:")]
        void Sfmc_trackPageViewWithURL(string url, [NullAllowed] string title, [NullAllowed] string item, [NullAllowed] string search);

        // -(void)sfmc_trackCartContents:(NSDictionary * _Nonnull)cartDictionary;
        [Export("sfmc_trackCartContents:")]
        void Sfmc_trackCartContents(NSDictionary cartDictionary);

        // -(void)sfmc_trackCartConversion:(NSDictionary * _Nonnull)orderDictionary;
        [Export("sfmc_trackCartConversion:")]
        void Sfmc_trackCartConversion(NSDictionary orderDictionary);

        // -(NSDictionary * _Nullable)sfmc_cartItemDictionaryWithPrice:(NSNumber * _Nonnull)price quantity:(NSNumber * _Nonnull)quantity item:(NSString * _Nonnull)item uniqueId:(NSString * _Nullable)uniqueId;
        [Export("sfmc_cartItemDictionaryWithPrice:quantity:item:uniqueId:")]
        [return: NullAllowed]
        NSDictionary Sfmc_cartItemDictionaryWithPrice(NSNumber price, NSNumber quantity, string item, [NullAllowed] string uniqueId);

        // -(NSDictionary * _Nullable)sfmc_cartDictionaryWithCartItemDictionaryArray:(NSArray * _Nonnull)cartItemDictionaryArray;
        [Export("sfmc_cartDictionaryWithCartItemDictionaryArray:")]
        //[Verify (StronglyTypedNSArray)]
        [return: NullAllowed]
        NSDictionary Sfmc_cartDictionaryWithCartItemDictionaryArray(NSObject[] cartItemDictionaryArray);

        // -(NSDictionary * _Nullable)sfmc_orderDictionaryWithOrderNumber:(NSString * _Nonnull)orderNumber shipping:(NSNumber * _Nonnull)shipping discount:(NSNumber * _Nonnull)discount cart:(NSDictionary * _Nonnull)cartDictionary;
        [Export("sfmc_orderDictionaryWithOrderNumber:shipping:discount:cart:")]
        [return: NullAllowed]
        NSDictionary Sfmc_orderDictionaryWithOrderNumber(string orderNumber, NSNumber shipping, NSNumber discount, NSDictionary cartDictionary);
    }

    [Static]
    //[Verify (ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const _Nonnull MarketingCloudSDKInboxMessageKey;
        [Field("MarketingCloudSDKInboxMessageKey", "__Internal")]
        NSString MarketingCloudSDKInboxMessageKey { get; }
    }

    // @interface MarketingCloudSDKInboxMessagesDataSource : NSObject <UITableViewDataSource>
    [BaseType(typeof(NSObject))]
    interface MarketingCloudSDKInboxMessagesDataSource : IUITableViewDataSource
    {
        // -(id _Nullable)initWithMarketingCloudSDK:(MarketingCloudSDK * _Nonnull)sdk tableView:(UITableView * _Nonnull)tableView;
        [Export("initWithMarketingCloudSDK:tableView:")]
        IntPtr Constructor(MarketingCloudSDK sdk, UITableView tableView);
    }

    // @interface MarketingCloudSDKInboxMessagesDelegate : NSObject <UITableViewDelegate>
    [BaseType(typeof(NSObject))]
    interface MarketingCloudSDKInboxMessagesDelegate : IUITableViewDelegate
    {
        // -(id _Nullable)initWithMarketingCloudSDK:(MarketingCloudSDK * _Nonnull)sdk tableView:(UITableView * _Nonnull)tableView dataSource:(MarketingCloudSDKInboxMessagesDataSource * _Nonnull)dataSource;
        [Export("initWithMarketingCloudSDK:tableView:dataSource:")]
        IntPtr Constructor(MarketingCloudSDK sdk, UITableView tableView, MarketingCloudSDKInboxMessagesDataSource dataSource);
    }

    // @interface InboxMessages (MarketingCloudSDK)
    [Category]
    [BaseType(typeof(MarketingCloudSDK))]
    interface MarketingCloudSDK_InboxMessages
    {
        // -(NSArray * _Nullable)sfmc_getAllMessages;
        [NullAllowed, Export("sfmc_getAllMessages")]
        //[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
        NSObject[] Sfmc_getAllMessages();

        // -(NSArray * _Nullable)sfmc_getUnreadMessages;
        [NullAllowed, Export("sfmc_getUnreadMessages")]
        //[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
        NSObject[] Sfmc_getUnreadMessages();

        // -(NSArray * _Nullable)sfmc_getReadMessages;
        [NullAllowed, Export("sfmc_getReadMessages")]
        //[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
        NSObject[] Sfmc_getReadMessages();

        // -(NSArray * _Nullable)sfmc_getDeletedMessages;
        [NullAllowed, Export("sfmc_getDeletedMessages")]
        //[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
        NSObject[] Sfmc_getDeletedMessages();

        // -(NSUInteger)sfmc_getAllMessagesCount;
        [Export("sfmc_getAllMessagesCount")]
        //[Verify (MethodToProperty)]
        nuint Sfmc_getAllMessagesCount();

        // -(NSUInteger)sfmc_getUnreadMessagesCount;
        [Export("sfmc_getUnreadMessagesCount")]
        //[Verify (MethodToProperty)]
        nuint Sfmc_getUnreadMessagesCount();

        // -(NSUInteger)sfmc_getReadMessagesCount;
        [Export("sfmc_getReadMessagesCount")]
        //[Verify (MethodToProperty)]
        nuint Sfmc_getReadMessagesCount();

        // -(NSUInteger)sfmc_getDeletedMessagesCount;
        [Export("sfmc_getDeletedMessagesCount")]
        //[Verify (MethodToProperty)]
        nuint Sfmc_getDeletedMessagesCount();

        // -(BOOL)sfmc_markMessageRead:(NSDictionary * _Nonnull)messageDictionary;
        [Export("sfmc_markMessageRead:")]
        bool Sfmc_markMessageRead(NSDictionary messageDictionary);

        // -(BOOL)sfmc_markMessageDeleted:(NSDictionary * _Nonnull)messageDictionary;
        [Export("sfmc_markMessageDeleted:")]
        bool Sfmc_markMessageDeleted(NSDictionary messageDictionary);

        // -(BOOL)sfmc_markAllMessagesRead;
        [Export("sfmc_markAllMessagesRead")]
        //[Verify (MethodToProperty)]
        bool Sfmc_markAllMessagesRead();

        // -(BOOL)sfmc_markAllMessagesDeleted;
        [Export("sfmc_markAllMessagesDeleted")]
        //[Verify (MethodToProperty)]
        bool Sfmc_markAllMessagesDeleted();

        // -(BOOL)sfmc_refreshMessages;
        [Export("sfmc_refreshMessages")]
        //[Verify (MethodToProperty)]
        bool Sfmc_refreshMessages();

        // -(MarketingCloudSDKInboxMessagesDataSource * _Nullable)sfmc_inboxMessagesTableViewDataSourceForTableView:(UITableView * _Nonnull)tableView;
        [Export("sfmc_inboxMessagesTableViewDataSourceForTableView:")]
        [return: NullAllowed]
        MarketingCloudSDKInboxMessagesDataSource Sfmc_inboxMessagesTableViewDataSourceForTableView(UITableView tableView);

        // -(MarketingCloudSDKInboxMessagesDelegate * _Nullable)sfmc_inboxMessagesTableViewDelegateForTableView:(UITableView * _Nonnull)tableView dataSource:(MarketingCloudSDKInboxMessagesDataSource * _Nonnull)dataSource;
        [Export("sfmc_inboxMessagesTableViewDelegateForTableView:dataSource:")]
        [return: NullAllowed]
        MarketingCloudSDKInboxMessagesDelegate Sfmc_inboxMessagesTableViewDelegateForTableView(UITableView tableView, MarketingCloudSDKInboxMessagesDataSource dataSource);
    }

    // @protocol MarketingCloudSDKLocationDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MarketingCloudSDKLocationDelegate
    {
        // @required -(BOOL)sfmc_shouldShowLocationMessage:(NSDictionary * _Nonnull)message forRegion:(NSDictionary * _Nonnull)region;
        [Abstract]
        [Export("sfmc_shouldShowLocationMessage:forRegion:")]
        bool ForRegion(NSDictionary message, NSDictionary region);
    }

    // @interface Location (MarketingCloudSDK)
    [Category]
    [BaseType(typeof(MarketingCloudSDK))]
    interface MarketingCloudSDK_Location
    {
        // -(void)sfmc_setLocationDelegate:(id<MarketingCloudSDKLocationDelegate> _Nullable)delegate;
        [Export("sfmc_setLocationDelegate:")]
        void Sfmc_setLocationDelegate([NullAllowed] MarketingCloudSDKLocationDelegate @delegate);

        // -(CLRegion *)sfmc_regionFromDictionary:(NSDictionary * _Nonnull)dictionary;
        [Export("sfmc_regionFromDictionary:")]
        CLRegion Sfmc_regionFromDictionary(NSDictionary dictionary);

        // -(BOOL)sfmc_locationEnabled;
        [Export("sfmc_locationEnabled")]
        //[Verify (MethodToProperty)]
        bool Sfmc_locationEnabled();

        // -(void)sfmc_startWatchingLocation;
        [Export("sfmc_startWatchingLocation")]
        void Sfmc_startWatchingLocation();

        // -(void)sfmc_stopWatchingLocation;
        [Export("sfmc_stopWatchingLocation")]
        void Sfmc_stopWatchingLocation();

        // -(BOOL)sfmc_watchingLocation;
        [Export("sfmc_watchingLocation")]
        //[Verify (MethodToProperty)]
        bool Sfmc_watchingLocation();

        // -(NSDictionary<NSString *,NSString *> * _Nullable)sfmc_lastKnownLocation;
        [NullAllowed, Export("sfmc_lastKnownLocation")]
        //[Verify (MethodToProperty)]
        NSDictionary<NSString, NSString> Sfmc_lastKnownLocation();
    }

    //[Static]
    //[Verify (ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const _Nonnull MarketingCloudSDKErrorDomain;
        [Field("MarketingCloudSDKErrorDomain", "__Internal")]
        NSString MarketingCloudSDKErrorDomain { get; }

        // extern NSNotificationName  _Nonnull const SFMCFrameworkDidSetupNotification;
        [Field("SFMCFrameworkDidSetupNotification", "__Internal")]
        NSString SFMCFrameworkDidSetupNotification { get; }

        // extern NSNotificationName  _Nonnull const SFMCFrameworkDidTeardownNotification;
        [Field("SFMCFrameworkDidTeardownNotification", "__Internal")]
        NSString SFMCFrameworkDidTeardownNotification { get; }

        // extern NSNotificationName  _Nonnull const SFMCFoundationRegistrationResponseSucceededNotification;
        [Field("SFMCFoundationRegistrationResponseSucceededNotification", "__Internal")]
        NSString SFMCFoundationRegistrationResponseSucceededNotification { get; }

        // extern NSNotificationName  _Nonnull const SFMCFoundationUNNotificationReceivedNotification;
        [Field("SFMCFoundationUNNotificationReceivedNotification", "__Internal")]
        NSString SFMCFoundationUNNotificationReceivedNotification { get; }

        // extern NSNotificationName  _Nonnull const SFMCInboxMessagesRefreshCompleteNotification;
        [Field("SFMCInboxMessagesRefreshCompleteNotification", "__Internal")]
        NSString SFMCInboxMessagesRefreshCompleteNotification { get; }

        // extern NSNotificationName  _Nonnull const SFMCInboxMessagesNewInboxMessagesNotification;
        [Field("SFMCInboxMessagesNewInboxMessagesNotification", "__Internal")]
        NSString SFMCInboxMessagesNewInboxMessagesNotification { get; }

        // extern NSNotificationName  _Nonnull const SFMCInboxMessagesUpdateStatusCompleteNotification;
        [Field("SFMCInboxMessagesUpdateStatusCompleteNotification", "__Internal")]
        NSString SFMCInboxMessagesUpdateStatusCompleteNotification { get; }

        // extern NSNotificationName  _Nonnull const SFMCInboxMessagesNotificationHandledNotification;
        [Field("SFMCInboxMessagesNotificationHandledNotification", "__Internal")]
        NSString SFMCInboxMessagesNotificationHandledNotification { get; }

        // extern NSNotificationName  _Nonnull const SFMCOpenDirectMessageNotificationHandledNotification;
        [Field("SFMCOpenDirectMessageNotificationHandledNotification", "__Internal")]
        NSString SFMCOpenDirectMessageNotificationHandledNotification { get; }

        // extern NSNotificationName  _Nonnull const SFMCLocationDidFixLocationNotification;
        [Field("SFMCLocationDidFixLocationNotification", "__Internal")]
        NSString SFMCLocationDidFixLocationNotification { get; }

        // extern NSNotificationName  _Nonnull const SFMCLocationDidReceiveLocationUpdateNotification;
        [Field("SFMCLocationDidReceiveLocationUpdateNotification", "__Internal")]
        NSString SFMCLocationDidReceiveLocationUpdateNotification { get; }

        // extern NSNotificationName  _Nonnull const SFMCLocationGeofenceRefreshCompleteNotification;
        [Field("SFMCLocationGeofenceRefreshCompleteNotification", "__Internal")]
        NSString SFMCLocationGeofenceRefreshCompleteNotification { get; }

        // extern NSNotificationName  _Nonnull const SFMCDidEnterLocationRegionMessageNotification;
        [Field("SFMCDidEnterLocationRegionMessageNotification", "__Internal")]
        NSString SFMCDidEnterLocationRegionMessageNotification { get; }

        // extern NSNotificationName  _Nonnull const SFMCDidExitLocationRegionMessageNotification;
        [Field("SFMCDidExitLocationRegionMessageNotification", "__Internal")]
        NSString SFMCDidExitLocationRegionMessageNotification { get; }

        // extern NSNotificationName  _Nonnull const SFMCDidDisplayLocationMessageNotification;
        [Field("SFMCDidDisplayLocationMessageNotification", "__Internal")]
        NSString SFMCDidDisplayLocationMessageNotification { get; }

        // extern NSNotificationName  _Nonnull const SFMCBeaconRefreshCompleteNotification;
        [Field("SFMCBeaconRefreshCompleteNotification", "__Internal")]
        NSString SFMCBeaconRefreshCompleteNotification { get; }

        // extern NSNotificationName  _Nonnull const SFMCDidRangeBeaconLocationMessageNotification;
        [Field("SFMCDidRangeBeaconLocationMessageNotification", "__Internal")]
        NSString SFMCDidRangeBeaconLocationMessageNotification { get; }

        // extern NSNotificationName  _Nonnull const SFMCLocationDidStartMonitoringForRegionNotification;
        [Field("SFMCLocationDidStartMonitoringForRegionNotification", "__Internal")]
        NSString SFMCLocationDidStartMonitoringForRegionNotification { get; }

        // extern NSNotificationName  _Nonnull const SFMCFrameworkDidBlockNotification;
        [Field("SFMCFrameworkDidBlockNotification", "__Internal")]
        NSString SFMCFrameworkDidBlockNotification { get; }
    }

    //[Static]
    //[Verify (ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const _Nonnull SFMCURLTypeCloudPage;
        [Field("SFMCURLTypeCloudPage", "__Internal")]
        NSString SFMCURLTypeCloudPage { get; }

        // extern NSString *const _Nonnull SFMCURLTypeOpenDirect;
        [Field("SFMCURLTypeOpenDirect", "__Internal")]
        NSString SFMCURLTypeOpenDirect { get; }

        // extern NSString *const _Nonnull SFMCURLTypeAction;
        [Field("SFMCURLTypeAction", "__Internal")]
        NSString SFMCURLTypeAction { get; }
    }

    // @protocol MarketingCloudSDKURLHandlingDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MarketingCloudSDKURLHandlingDelegate
    {
        // @required -(void)sfmc_handleURL:(NSURL *)url type:(NSString * _Nonnull)type;
        [Abstract]
        [Export("sfmc_handleURL:type:")]
        void Type(NSUrl url, string type);
    }

    // @interface URLHandling (MarketingCloudSDK)
    [Category]
    [BaseType(typeof(MarketingCloudSDK))]
    interface MarketingCloudSDK_URLHandling
    {
        // -(void)sfmc_setURLHandlingDelegate:(id<MarketingCloudSDKURLHandlingDelegate> _Nullable)delegate;
        [Export("sfmc_setURLHandlingDelegate:")]
        void Sfmc_setURLHandlingDelegate([NullAllowed] MarketingCloudSDKURLHandlingDelegate @delegate);
    }

    // @interface MarketingCloudSDKConfigBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface MarketingCloudSDKConfigBuilder
    {
        // -(NSDictionary * _Nullable)sfmc_build;
        [NullAllowed, Export("sfmc_build")]
        //[Verify (MethodToProperty)]
        NSDictionary Sfmc_build { get; }

        // -(instancetype _Nonnull)sfmc_setApplicationId:(NSString * _Nonnull)setApplicationId;
        [Export("sfmc_setApplicationId:")]
        MarketingCloudSDKConfigBuilder Sfmc_setApplicationId(string setApplicationId);

        // -(instancetype _Nonnull)sfmc_setAccessToken:(NSString * _Nonnull)setAccessToken;
        [Export("sfmc_setAccessToken:")]
        MarketingCloudSDKConfigBuilder Sfmc_setAccessToken(string setAccessToken);

        // -(instancetype _Nonnull)sfmc_setLocationEnabled:(NSNumber * _Nonnull)setLocationEnabled;
        [Export("sfmc_setLocationEnabled:")]
        MarketingCloudSDKConfigBuilder Sfmc_setLocationEnabled(NSNumber setLocationEnabled);

        // -(instancetype _Nonnull)sfmc_setInboxEnabled:(NSNumber * _Nonnull)setInboxEnabled;
        [Export("sfmc_setInboxEnabled:")]
        MarketingCloudSDKConfigBuilder Sfmc_setInboxEnabled(NSNumber setInboxEnabled);

        // -(instancetype _Nonnull)sfmc_setPiAnalyticsEnabled:(NSNumber * _Nonnull)setPiAnalyticsEnabled;
        [Export("sfmc_setPiAnalyticsEnabled:")]
        MarketingCloudSDKConfigBuilder Sfmc_setPiAnalyticsEnabled(NSNumber setPiAnalyticsEnabled);

        // -(instancetype _Nonnull)sfmc_setUseLegacyPIIdentifier:(NSNumber * _Nonnull)etUseLegacyPIIdentifier;
        [Export("sfmc_setUseLegacyPIIdentifier:")]
        MarketingCloudSDKConfigBuilder Sfmc_setUseLegacyPIIdentifier(NSNumber etUseLegacyPIIdentifier);

        // -(instancetype _Nonnull)sfmc_setAnalyticsEnabled:(NSNumber * _Nonnull)setAnalyticsEnabled;
        [Export("sfmc_setAnalyticsEnabled:")]
        MarketingCloudSDKConfigBuilder Sfmc_setAnalyticsEnabled(NSNumber setAnalyticsEnabled);

        // -(instancetype _Nonnull)sfmc_setMid:(NSString * _Nonnull)setMid;
        [Export("sfmc_setMid:")]
        MarketingCloudSDKConfigBuilder Sfmc_setMid(string setMid);

        // -(instancetype _Nonnull)sfmc_setMarketingCloudServerUrl:(NSString * _Nonnull)setMarketingCloudServerUrl;
        [Export("sfmc_setMarketingCloudServerUrl:")]
        MarketingCloudSDKConfigBuilder Sfmc_setMarketingCloudServerUrl(string setMarketingCloudServerUrl);
    }
}