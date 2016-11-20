//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace NJKWebViewProgressLab {
	[Protocol (Name = "NJKWebViewProgressDelegate", WrapperType = typeof (NJKWebViewProgressDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WebViewProgress", Selector = "webViewProgress:updateProgress:", ParameterType = new Type [] { typeof (NJKWebViewProgressLab.NJKWebViewProgress), typeof (nfloat) }, ParameterByRef = new bool [] { false, false })]
	public interface INJKWebViewProgressDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class NJKWebViewProgressDelegate_Extensions {
		[CompilerGenerated]
		public static void WebViewProgress (this INJKWebViewProgressDelegate This, NJKWebViewProgress webViewProgress, global::System.nfloat progress)
		{
			if (webViewProgress == null)
				throw new ArgumentNullException ("webViewProgress");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nfloat (This.Handle, Selector.GetHandle ("webViewProgress:updateProgress:"), webViewProgress.Handle, progress);
		}
		
	}
	
	internal sealed class NJKWebViewProgressDelegateWrapper : BaseWrapper, INJKWebViewProgressDelegate {
		public NJKWebViewProgressDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public NJKWebViewProgressDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace NJKWebViewProgressLab {
	[Protocol]
	[Register("NJKWebViewProgressDelegate", false)]
	[Model]
	public unsafe partial class NJKWebViewProgressDelegate : NSObject, INJKWebViewProgressDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NJKWebViewProgressDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NJKWebViewProgressDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NJKWebViewProgressDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("webViewProgress:updateProgress:")]
		[CompilerGenerated]
		public virtual void WebViewProgress (NJKWebViewProgress webViewProgress, global::System.nfloat progress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class NJKWebViewProgressDelegate */
}
