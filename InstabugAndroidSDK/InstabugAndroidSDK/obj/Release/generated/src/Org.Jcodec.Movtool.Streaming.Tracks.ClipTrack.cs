using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Movtool.Streaming.Tracks {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='ClipTrack']"
	[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/ClipTrack", DoNotGenerateAcw=true)]
	public partial class ClipTrack : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='ClipTrack.ClipPacket']"
		[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/ClipTrack$ClipPacket", DoNotGenerateAcw=true)]
		public partial class ClipPacket : global::Org.Jcodec.Movtool.Streaming.Tracks.VirtualPacketWrapper {

			protected ClipPacket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/movtool/streaming/tracks/ClipTrack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClipTrack); }
		}

		protected ClipTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getPreferredTimescale;
#pragma warning disable 0169
		static Delegate GetGetPreferredTimescaleHandler ()
		{
			if (cb_getPreferredTimescale == null)
				cb_getPreferredTimescale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPreferredTimescale);
			return cb_getPreferredTimescale;
		}

		static int n_GetPreferredTimescale (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.ClipTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.ClipTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreferredTimescale;
		}
#pragma warning restore 0169

		static IntPtr id_getPreferredTimescale;
		public virtual unsafe int PreferredTimescale {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='ClipTrack']/method[@name='getPreferredTimescale' and count(parameter)=0]"
			[Register ("getPreferredTimescale", "()I", "GetGetPreferredTimescaleHandler")]
			get {
				if (id_getPreferredTimescale == IntPtr.Zero)
					id_getPreferredTimescale = JNIEnv.GetMethodID (class_ref, "getPreferredTimescale", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPreferredTimescale);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreferredTimescale", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.ClipTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.ClipTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='ClipTrack']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

	}
}
