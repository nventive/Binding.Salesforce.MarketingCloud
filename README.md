# Binding.SalesForce.MarketingCloud

## Summary

Bindings are for **SalesForce.MarketingCloud**. 

## Android

The library documentation is located [here](https://salesforce-marketingcloud.github.io/JB4A-SDK-Android/).

This binding is for the SDK version **6.1.0**.

The source `.aar` file is located in [MarketingCloud's Maven repository](http://salesforce-marketingcloud.github.io/JB4A-SDK-Android/repository/com/salesforce/marketingcloud/marketingcloudsdk/).

### Note

In version 5.0.4 all ETPush methods which stood for ExactTargetPush were rebranded to MarketingCloudSdk. See the release history of MarketingCloudSdk.

### **How to use**

Simply compile the projects and use the resulting `.dll`.

For more information, see the official [Xamarin documentation](https://developer.xamarin.com/guides/android/advanced_topics/binding-a-java-library/binding-an-aar/).

### **Log**
_2017-10-15: After integrating the **5.1.3** package in a project, we discovered a name conflict at compilation time. The conflict was with the GoogleMediaFramework (imasdk). The conflict was an obfuscated package (a.a.a.a.a) used in both .jar. Downgrading the SDK to **5.0.6** solves the issue because the conflicting package is not present in this version. Compiling with JDK 1.8 was causing issues on the binding except if the -noverify javaoptions is enabled. We can't build using JDK 1.7 (which fixes the errors) because the library targets Android 7.1 which requires JDK 1.8. **Yes, it's a mess**._

## iOS

The library documentation is located [here](https://salesforce-marketingcloud.github.io/MarketingCloudSDK-iOS) for iOS.

This binding is for the SDK version **6.1.4**.

The source files are located in [MarketingCloud's GitHub repository](https://github.com/salesforce-marketingcloud/MarketingCloudSDK-iOS).

### **How to use**

Simply compile the project and use the resulting `.dll`.

For more information, see the official [Xamarin documentation](https://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/).

The `ApiDefinition` and `Structs` files were generated using [Objective Sharpie](https://developer.xamarin.com/guides/cross-platform/macios/binding/objective-sharpie/).
