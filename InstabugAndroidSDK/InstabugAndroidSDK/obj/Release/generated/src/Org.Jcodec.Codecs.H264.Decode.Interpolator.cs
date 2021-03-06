using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.Decode {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Interpolator']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/decode/Interpolator", DoNotGenerateAcw=true)]
	public partial class Interpolator : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/decode/Interpolator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Interpolator); }
		}

		protected Interpolator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Interpolator']/constructor[@name='Interpolator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Interpolator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Interpolator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_fillFullPel_arrayIIIarrayI;
#pragma warning disable 0169
		static Delegate GetFillFullPel_arrayIIIarrayIHandler ()
		{
			if (cb_fillFullPel_arrayIIIarrayI == null)
				cb_fillFullPel_arrayIIIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_FillFullPel_arrayIIIarrayI);
			return cb_fillFullPel_arrayIIIarrayI;
		}

		static void n_FillFullPel_arrayIIIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Interpolator __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Interpolator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] p3 = (int[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.FillFullPel (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		static IntPtr id_fillFullPel_arrayIIIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Interpolator']/method[@name='fillFullPel' and count(parameter)=4 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int[]']]"
		[Register ("fillFullPel", "([III[I)V", "GetFillFullPel_arrayIIIarrayIHandler")]
		protected virtual unsafe void FillFullPel (int[] p0, int p1, int p2, int[] p3)
		{
			if (id_fillFullPel_arrayIIIarrayI == IntPtr.Zero)
				id_fillFullPel_arrayIIIarrayI = JNIEnv.GetMethodID (class_ref, "fillFullPel", "([III[I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fillFullPel_arrayIIIarrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fillFullPel", "([III[I)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static Delegate cb_interpolateChroma_arrayIII;
#pragma warning disable 0169
		static Delegate GetInterpolateChroma_arrayIIIHandler ()
		{
			if (cb_interpolateChroma_arrayIII == null)
				cb_interpolateChroma_arrayIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_InterpolateChroma_arrayIII);
			return cb_interpolateChroma_arrayIII;
		}

		static IntPtr n_InterpolateChroma_arrayIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Interpolator __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Interpolator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.NewArray (__this.InterpolateChroma (p0, p1, p2));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_interpolateChroma_arrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Interpolator']/method[@name='interpolateChroma' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("interpolateChroma", "([III)[I", "GetInterpolateChroma_arrayIIIHandler")]
		public virtual unsafe int[] InterpolateChroma (int[] p0, int p1, int p2)
		{
			if (id_interpolateChroma_arrayIII == IntPtr.Zero)
				id_interpolateChroma_arrayIII = JNIEnv.GetMethodID (class_ref, "interpolateChroma", "([III)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				int[] __ret;
				if (GetType () == ThresholdType)
					__ret = (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_interpolateChroma_arrayIII, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					__ret = (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "interpolateChroma", "([III)[I"), __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_interpolateLuma_arrayIII;
#pragma warning disable 0169
		static Delegate GetInterpolateLuma_arrayIIIHandler ()
		{
			if (cb_interpolateLuma_arrayIII == null)
				cb_interpolateLuma_arrayIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_InterpolateLuma_arrayIII);
			return cb_interpolateLuma_arrayIII;
		}

		static IntPtr n_InterpolateLuma_arrayIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Interpolator __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Interpolator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.NewArray (__this.InterpolateLuma (p0, p1, p2));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_interpolateLuma_arrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Interpolator']/method[@name='interpolateLuma' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("interpolateLuma", "([III)[I", "GetInterpolateLuma_arrayIIIHandler")]
		public virtual unsafe int[] InterpolateLuma (int[] p0, int p1, int p2)
		{
			if (id_interpolateLuma_arrayIII == IntPtr.Zero)
				id_interpolateLuma_arrayIII = JNIEnv.GetMethodID (class_ref, "interpolateLuma", "([III)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				int[] __ret;
				if (GetType () == ThresholdType)
					__ret = (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_interpolateLuma_arrayIII, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					__ret = (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "interpolateLuma", "([III)[I"), __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_roundHPelVertical_IIarrayI;
#pragma warning disable 0169
		static Delegate GetRoundHPelVertical_IIarrayIHandler ()
		{
			if (cb_roundHPelVertical_IIarrayI == null)
				cb_roundHPelVertical_IIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_RoundHPelVertical_IIarrayI);
			return cb_roundHPelVertical_IIarrayI;
		}

		static void n_RoundHPelVertical_IIarrayI (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Interpolator __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Interpolator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.RoundHPelVertical (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_roundHPelVertical_IIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Interpolator']/method[@name='roundHPelVertical' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("roundHPelVertical", "(II[I)V", "GetRoundHPelVertical_IIarrayIHandler")]
		protected virtual unsafe void RoundHPelVertical (int p0, int p1, int[] p2)
		{
			if (id_roundHPelVertical_IIarrayI == IntPtr.Zero)
				id_roundHPelVertical_IIarrayI = JNIEnv.GetMethodID (class_ref, "roundHPelVertical", "(II[I)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_roundHPelVertical_IIarrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "roundHPelVertical", "(II[I)V"), __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_scanHPelCenterWidhRound_IIarrayI;
#pragma warning disable 0169
		static Delegate GetScanHPelCenterWidhRound_IIarrayIHandler ()
		{
			if (cb_scanHPelCenterWidhRound_IIarrayI == null)
				cb_scanHPelCenterWidhRound_IIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_ScanHPelCenterWidhRound_IIarrayI);
			return cb_scanHPelCenterWidhRound_IIarrayI;
		}

		static void n_ScanHPelCenterWidhRound_IIarrayI (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Interpolator __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Interpolator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.ScanHPelCenterWidhRound (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_scanHPelCenterWidhRound_IIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Interpolator']/method[@name='scanHPelCenterWidhRound' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("scanHPelCenterWidhRound", "(II[I)V", "GetScanHPelCenterWidhRound_IIarrayIHandler")]
		protected virtual unsafe void ScanHPelCenterWidhRound (int p0, int p1, int[] p2)
		{
			if (id_scanHPelCenterWidhRound_IIarrayI == IntPtr.Zero)
				id_scanHPelCenterWidhRound_IIarrayI = JNIEnv.GetMethodID (class_ref, "scanHPelCenterWidhRound", "(II[I)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_scanHPelCenterWidhRound_IIarrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scanHPelCenterWidhRound", "(II[I)V"), __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_scanHPelHorizontalWithRound_IIarrayI;
#pragma warning disable 0169
		static Delegate GetScanHPelHorizontalWithRound_IIarrayIHandler ()
		{
			if (cb_scanHPelHorizontalWithRound_IIarrayI == null)
				cb_scanHPelHorizontalWithRound_IIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_ScanHPelHorizontalWithRound_IIarrayI);
			return cb_scanHPelHorizontalWithRound_IIarrayI;
		}

		static void n_ScanHPelHorizontalWithRound_IIarrayI (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Interpolator __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Interpolator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.ScanHPelHorizontalWithRound (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_scanHPelHorizontalWithRound_IIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Interpolator']/method[@name='scanHPelHorizontalWithRound' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("scanHPelHorizontalWithRound", "(II[I)V", "GetScanHPelHorizontalWithRound_IIarrayIHandler")]
		protected virtual unsafe void ScanHPelHorizontalWithRound (int p0, int p1, int[] p2)
		{
			if (id_scanHPelHorizontalWithRound_IIarrayI == IntPtr.Zero)
				id_scanHPelHorizontalWithRound_IIarrayI = JNIEnv.GetMethodID (class_ref, "scanHPelHorizontalWithRound", "(II[I)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_scanHPelHorizontalWithRound_IIarrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scanHPelHorizontalWithRound", "(II[I)V"), __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_scanHPelVertical_IIarrayI;
#pragma warning disable 0169
		static Delegate GetScanHPelVertical_IIarrayIHandler ()
		{
			if (cb_scanHPelVertical_IIarrayI == null)
				cb_scanHPelVertical_IIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_ScanHPelVertical_IIarrayI);
			return cb_scanHPelVertical_IIarrayI;
		}

		static void n_ScanHPelVertical_IIarrayI (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Interpolator __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Interpolator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.ScanHPelVertical (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_scanHPelVertical_IIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Interpolator']/method[@name='scanHPelVertical' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("scanHPelVertical", "(II[I)V", "GetScanHPelVertical_IIarrayIHandler")]
		protected virtual unsafe void ScanHPelVertical (int p0, int p1, int[] p2)
		{
			if (id_scanHPelVertical_IIarrayI == IntPtr.Zero)
				id_scanHPelVertical_IIarrayI = JNIEnv.GetMethodID (class_ref, "scanHPelVertical", "(II[I)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_scanHPelVertical_IIarrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scanHPelVertical", "(II[I)V"), __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_scanQPel_IIarrayI;
#pragma warning disable 0169
		static Delegate GetScanQPel_IIarrayIHandler ()
		{
			if (cb_scanQPel_IIarrayI == null)
				cb_scanQPel_IIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_ScanQPel_IIarrayI);
			return cb_scanQPel_IIarrayI;
		}

		static void n_ScanQPel_IIarrayI (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Interpolator __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Interpolator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.ScanQPel (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_scanQPel_IIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Interpolator']/method[@name='scanQPel' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("scanQPel", "(II[I)V", "GetScanQPel_IIarrayIHandler")]
		protected virtual unsafe void ScanQPel (int p0, int p1, int[] p2)
		{
			if (id_scanQPel_IIarrayI == IntPtr.Zero)
				id_scanQPel_IIarrayI = JNIEnv.GetMethodID (class_ref, "scanQPel", "(II[I)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_scanQPel_IIarrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scanQPel", "(II[I)V"), __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

	}
}
