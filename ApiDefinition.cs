using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace NJKWebViewProgressLab
{
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     CGPoint Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
	//

	//typedef void (^NJKWebViewProgressBlock)(float progress);
	//delegate void SetWebViewProgress(NSObject obj, ref bool stop)

	[BaseType(typeof(UIWebViewDelegate))]
	interface NJKWebViewProgress
	{
		//@property(nonatomic, njk_weak) id<NJKWebViewProgressDelegate> progressDelegate;
		[Export("progressDelegate")]
		NJKWebViewProgressDelegate ProgressDelegate { get; set; }

		//@property(nonatomic, njk_weak) id<UIWebViewDelegate> webViewProxyDelegate;
		[Export("webViewProxyDelegate")]
		UIWebViewDelegate WebViewProxyDelegate { get; set; }

		//@property(nonatomic, copy) NJKWebViewProgressBlock progressBlock;
		[Export("progressBlock")]
		Action<nfloat> ProgressBlock { get; set; }

		//@property(nonatomic, readonly) float progress; // 0.0..1.0
		[Export("progress")]
		nfloat Progress { get; set; }

		//- (void)reset;
		[Export("reset")]
		void Reset();
	}

	[BaseType(typeof(NSObject))]
	[Model]
	[Protocol]
	interface NJKWebViewProgressDelegate
	{
		//- (void)webViewProgress:(NJKWebViewProgress *)webViewProgress updateProgress:(float)progress;
		[Export("webViewProgress:updateProgress:")]
		void WebViewProgress(NJKWebViewProgress webViewProgress, nfloat progress);
	}

	[BaseType(typeof(UIView))]
	interface NJKWebViewProgressView
	{
		[Export("initWithFrame:")]
		IntPtr Constructor(CGRect frame);

		//@property(nonatomic) float progress;
		[Export("progress")]
		nfloat Progress { get; set; }

		//@property(nonatomic) UIView* progressBarView;
		[Export("progressBarView")]
		UIView ProgressBarView { get; set; }

		//@property(nonatomic) NSTimeInterval barAnimationDuration; // default 0.1
		[Export("barAnimationDuration")]
		double BarAnimationDuration { get; set; }

		//@property(nonatomic) NSTimeInterval fadeAnimationDuration; // default 0.27
		[Export("fadeAnimationDuration")]
		double FadeAnimationDuration { get; set; }

		//@property(nonatomic) NSTimeInterval fadeOutDelay; // default 0.1
		[Export("fadeOutDelay")]
		double FadeOutDelay { get; set; }

		//- (void)setProgress:(float)progress animated:(BOOL)animated;
		[Export("setProgress:animated:")]
		void SetProgress(nfloat progress, bool animated);
	}
}
