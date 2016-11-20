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
	[Register("NJKWebViewProgressView", true)]
	public unsafe partial class NJKWebViewProgressView : global::UIKit.UIView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NJKWebViewProgressView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NJKWebViewProgressView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public NJKWebViewProgressView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NJKWebViewProgressView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NJKWebViewProgressView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:")]
		[CompilerGenerated]
		public NJKWebViewProgressView (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			}
		}
		
		[Export ("setProgress:animated:")]
		[CompilerGenerated]
		public virtual void SetProgress (global::System.nfloat progress, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nfloat_bool (this.Handle, Selector.GetHandle ("setProgress:animated:"), progress, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat_bool (this.SuperHandle, Selector.GetHandle ("setProgress:animated:"), progress, animated);
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double BarAnimationDuration {
			[Export ("barAnimationDuration")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("barAnimationDuration"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("barAnimationDuration"));
				}
			}
			
			[Export ("setBarAnimationDuration:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setBarAnimationDuration:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setBarAnimationDuration:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double FadeAnimationDuration {
			[Export ("fadeAnimationDuration")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("fadeAnimationDuration"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fadeAnimationDuration"));
				}
			}
			
			[Export ("setFadeAnimationDuration:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setFadeAnimationDuration:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setFadeAnimationDuration:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double FadeOutDelay {
			[Export ("fadeOutDelay")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("fadeOutDelay"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fadeOutDelay"));
				}
			}
			
			[Export ("setFadeOutDelay:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setFadeOutDelay:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setFadeOutDelay:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat Progress {
			[Export ("progress")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("progress"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("progress"));
				}
			}
			
			[Export ("setProgress:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setProgress:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setProgress:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIView ProgressBarView {
			[Export ("progressBarView")]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("progressBarView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("progressBarView")));
				}
				return ret;
			}
			
			[Export ("setProgressBarView:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setProgressBarView:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setProgressBarView:"), value.Handle);
				}
			}
		}
		
		public partial class NJKWebViewProgressViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal NJKWebViewProgressViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new NJKWebViewProgressViewAppearance Appearance {
			get { return new NJKWebViewProgressViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new NJKWebViewProgressViewAppearance GetAppearance<T> () where T: NJKWebViewProgressView {
			return new NJKWebViewProgressViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new NJKWebViewProgressViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new NJKWebViewProgressViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new NJKWebViewProgressViewAppearance GetAppearance (UITraitCollection traits) {
			return new NJKWebViewProgressViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new NJKWebViewProgressViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new NJKWebViewProgressViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new NJKWebViewProgressViewAppearance GetAppearance<T> (UITraitCollection traits) where T: NJKWebViewProgressView {
			return new NJKWebViewProgressViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new NJKWebViewProgressViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: NJKWebViewProgressView{
			return new NJKWebViewProgressViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class NJKWebViewProgressView */
}
