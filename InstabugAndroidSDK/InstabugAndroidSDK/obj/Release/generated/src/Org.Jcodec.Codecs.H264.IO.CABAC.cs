using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/io/CABAC", DoNotGenerateAcw=true)]
	public partial class CABAC : global::Java.Lang.Object {


		static IntPtr tmp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC']/field[@name='tmp']"
		[Register ("tmp")]
		public IList<int> Tmp {
			get {
				if (tmp_jfieldId == IntPtr.Zero)
					tmp_jfieldId = JNIEnv.GetFieldID (class_ref, "tmp", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, tmp_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (tmp_jfieldId == IntPtr.Zero)
					tmp_jfieldId = JNIEnv.GetFieldID (class_ref, "tmp", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, tmp_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/h264/io/CABAC$BlockType", DoNotGenerateAcw=true)]
		public sealed partial class BlockType : global::Java.Lang.Enum {


			static IntPtr CB_15x16_AC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/field[@name='CB_15x16_AC']"
			[Register ("CB_15x16_AC")]
			public static global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType CB15x16AC {
				get {
					if (CB_15x16_AC_jfieldId == IntPtr.Zero)
						CB_15x16_AC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CB_15x16_AC", "Lorg/jcodec/codecs/h264/io/CABAC$BlockType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CB_15x16_AC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CB_16_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/field[@name='CB_16']"
			[Register ("CB_16")]
			public static global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType Cb16 {
				get {
					if (CB_16_jfieldId == IntPtr.Zero)
						CB_16_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CB_16", "Lorg/jcodec/codecs/h264/io/CABAC$BlockType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CB_16_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CB_16_DC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/field[@name='CB_16_DC']"
			[Register ("CB_16_DC")]
			public static global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType Cb16Dc {
				get {
					if (CB_16_DC_jfieldId == IntPtr.Zero)
						CB_16_DC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CB_16_DC", "Lorg/jcodec/codecs/h264/io/CABAC$BlockType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CB_16_DC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CB_64_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/field[@name='CB_64']"
			[Register ("CB_64")]
			public static global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType Cb64 {
				get {
					if (CB_64_jfieldId == IntPtr.Zero)
						CB_64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CB_64", "Lorg/jcodec/codecs/h264/io/CABAC$BlockType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CB_64_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CHROMA_AC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/field[@name='CHROMA_AC']"
			[Register ("CHROMA_AC")]
			public static global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType ChromaAc {
				get {
					if (CHROMA_AC_jfieldId == IntPtr.Zero)
						CHROMA_AC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHROMA_AC", "Lorg/jcodec/codecs/h264/io/CABAC$BlockType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHROMA_AC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CHROMA_DC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/field[@name='CHROMA_DC']"
			[Register ("CHROMA_DC")]
			public static global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType ChromaDc {
				get {
					if (CHROMA_DC_jfieldId == IntPtr.Zero)
						CHROMA_DC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHROMA_DC", "Lorg/jcodec/codecs/h264/io/CABAC$BlockType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHROMA_DC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CR_15x16_AC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/field[@name='CR_15x16_AC']"
			[Register ("CR_15x16_AC")]
			public static global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType CR15x16AC {
				get {
					if (CR_15x16_AC_jfieldId == IntPtr.Zero)
						CR_15x16_AC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CR_15x16_AC", "Lorg/jcodec/codecs/h264/io/CABAC$BlockType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CR_15x16_AC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CR_16_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/field[@name='CR_16']"
			[Register ("CR_16")]
			public static global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType Cr16 {
				get {
					if (CR_16_jfieldId == IntPtr.Zero)
						CR_16_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CR_16", "Lorg/jcodec/codecs/h264/io/CABAC$BlockType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CR_16_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CR_16_DC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/field[@name='CR_16_DC']"
			[Register ("CR_16_DC")]
			public static global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType Cr16Dc {
				get {
					if (CR_16_DC_jfieldId == IntPtr.Zero)
						CR_16_DC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CR_16_DC", "Lorg/jcodec/codecs/h264/io/CABAC$BlockType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CR_16_DC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CR_64_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/field[@name='CR_64']"
			[Register ("CR_64")]
			public static global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType Cr64 {
				get {
					if (CR_64_jfieldId == IntPtr.Zero)
						CR_64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CR_64", "Lorg/jcodec/codecs/h264/io/CABAC$BlockType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CR_64_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LUMA_15_AC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/field[@name='LUMA_15_AC']"
			[Register ("LUMA_15_AC")]
			public static global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType Luma15Ac {
				get {
					if (LUMA_15_AC_jfieldId == IntPtr.Zero)
						LUMA_15_AC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LUMA_15_AC", "Lorg/jcodec/codecs/h264/io/CABAC$BlockType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LUMA_15_AC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LUMA_16_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/field[@name='LUMA_16']"
			[Register ("LUMA_16")]
			public static global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType Luma16 {
				get {
					if (LUMA_16_jfieldId == IntPtr.Zero)
						LUMA_16_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LUMA_16", "Lorg/jcodec/codecs/h264/io/CABAC$BlockType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LUMA_16_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LUMA_16_DC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/field[@name='LUMA_16_DC']"
			[Register ("LUMA_16_DC")]
			public static global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType Luma16Dc {
				get {
					if (LUMA_16_DC_jfieldId == IntPtr.Zero)
						LUMA_16_DC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LUMA_16_DC", "Lorg/jcodec/codecs/h264/io/CABAC$BlockType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LUMA_16_DC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LUMA_64_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/field[@name='LUMA_64']"
			[Register ("LUMA_64")]
			public static global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType Luma64 {
				get {
					if (LUMA_64_jfieldId == IntPtr.Zero)
						LUMA_64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LUMA_64", "Lorg/jcodec/codecs/h264/io/CABAC$BlockType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LUMA_64_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr codedBlockCtxOff_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/field[@name='codedBlockCtxOff']"
			[Register ("codedBlockCtxOff")]
			public int CodedBlockCtxOff {
				get {
					if (codedBlockCtxOff_jfieldId == IntPtr.Zero)
						codedBlockCtxOff_jfieldId = JNIEnv.GetFieldID (class_ref, "codedBlockCtxOff", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, codedBlockCtxOff_jfieldId);
				}
				set {
					if (codedBlockCtxOff_jfieldId == IntPtr.Zero)
						codedBlockCtxOff_jfieldId = JNIEnv.GetFieldID (class_ref, "codedBlockCtxOff", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, codedBlockCtxOff_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr coeffAbsLevelAdjust_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/field[@name='coeffAbsLevelAdjust']"
			[Register ("coeffAbsLevelAdjust")]
			public int CoeffAbsLevelAdjust {
				get {
					if (coeffAbsLevelAdjust_jfieldId == IntPtr.Zero)
						coeffAbsLevelAdjust_jfieldId = JNIEnv.GetFieldID (class_ref, "coeffAbsLevelAdjust", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, coeffAbsLevelAdjust_jfieldId);
				}
				set {
					if (coeffAbsLevelAdjust_jfieldId == IntPtr.Zero)
						coeffAbsLevelAdjust_jfieldId = JNIEnv.GetFieldID (class_ref, "coeffAbsLevelAdjust", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, coeffAbsLevelAdjust_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr coeffAbsLevelCtxOff_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/field[@name='coeffAbsLevelCtxOff']"
			[Register ("coeffAbsLevelCtxOff")]
			public int CoeffAbsLevelCtxOff {
				get {
					if (coeffAbsLevelCtxOff_jfieldId == IntPtr.Zero)
						coeffAbsLevelCtxOff_jfieldId = JNIEnv.GetFieldID (class_ref, "coeffAbsLevelCtxOff", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, coeffAbsLevelCtxOff_jfieldId);
				}
				set {
					if (coeffAbsLevelCtxOff_jfieldId == IntPtr.Zero)
						coeffAbsLevelCtxOff_jfieldId = JNIEnv.GetFieldID (class_ref, "coeffAbsLevelCtxOff", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, coeffAbsLevelCtxOff_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr lastSigCoeffCtxOff_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/field[@name='lastSigCoeffCtxOff']"
			[Register ("lastSigCoeffCtxOff")]
			public int LastSigCoeffCtxOff {
				get {
					if (lastSigCoeffCtxOff_jfieldId == IntPtr.Zero)
						lastSigCoeffCtxOff_jfieldId = JNIEnv.GetFieldID (class_ref, "lastSigCoeffCtxOff", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, lastSigCoeffCtxOff_jfieldId);
				}
				set {
					if (lastSigCoeffCtxOff_jfieldId == IntPtr.Zero)
						lastSigCoeffCtxOff_jfieldId = JNIEnv.GetFieldID (class_ref, "lastSigCoeffCtxOff", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lastSigCoeffCtxOff_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr lastSigCoeffFldCtxOff_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/field[@name='lastSigCoeffFldCtxOff']"
			[Register ("lastSigCoeffFldCtxOff")]
			public int LastSigCoeffFldCtxOff {
				get {
					if (lastSigCoeffFldCtxOff_jfieldId == IntPtr.Zero)
						lastSigCoeffFldCtxOff_jfieldId = JNIEnv.GetFieldID (class_ref, "lastSigCoeffFldCtxOff", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, lastSigCoeffFldCtxOff_jfieldId);
				}
				set {
					if (lastSigCoeffFldCtxOff_jfieldId == IntPtr.Zero)
						lastSigCoeffFldCtxOff_jfieldId = JNIEnv.GetFieldID (class_ref, "lastSigCoeffFldCtxOff", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lastSigCoeffFldCtxOff_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr sigCoeffFlagCtxOff_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/field[@name='sigCoeffFlagCtxOff']"
			[Register ("sigCoeffFlagCtxOff")]
			public int SigCoeffFlagCtxOff {
				get {
					if (sigCoeffFlagCtxOff_jfieldId == IntPtr.Zero)
						sigCoeffFlagCtxOff_jfieldId = JNIEnv.GetFieldID (class_ref, "sigCoeffFlagCtxOff", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, sigCoeffFlagCtxOff_jfieldId);
				}
				set {
					if (sigCoeffFlagCtxOff_jfieldId == IntPtr.Zero)
						sigCoeffFlagCtxOff_jfieldId = JNIEnv.GetFieldID (class_ref, "sigCoeffFlagCtxOff", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sigCoeffFlagCtxOff_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr sigCoeffFlagFldCtxOff_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/field[@name='sigCoeffFlagFldCtxOff']"
			[Register ("sigCoeffFlagFldCtxOff")]
			public int SigCoeffFlagFldCtxOff {
				get {
					if (sigCoeffFlagFldCtxOff_jfieldId == IntPtr.Zero)
						sigCoeffFlagFldCtxOff_jfieldId = JNIEnv.GetFieldID (class_ref, "sigCoeffFlagFldCtxOff", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, sigCoeffFlagFldCtxOff_jfieldId);
				}
				set {
					if (sigCoeffFlagFldCtxOff_jfieldId == IntPtr.Zero)
						sigCoeffFlagFldCtxOff_jfieldId = JNIEnv.GetFieldID (class_ref, "sigCoeffFlagFldCtxOff", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sigCoeffFlagFldCtxOff_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/h264/io/CABAC$BlockType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BlockType); }
			}

			internal BlockType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/jcodec/codecs/h264/io/CABAC$BlockType;", "")]
			public static unsafe global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/jcodec/codecs/h264/io/CABAC$BlockType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC.BlockType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/jcodec/codecs/h264/io/CABAC$BlockType;", "")]
			public static unsafe global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/jcodec/codecs/h264/io/CABAC$BlockType;");
				try {
					return (global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/io/CABAC", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CABAC); }
		}

		protected CABAC (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC']/constructor[@name='CABAC' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe CABAC (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (CABAC)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_prev4x4PredModeFlag_Lorg_jcodec_codecs_common_biari_MDecoder_;
#pragma warning disable 0169
		static Delegate GetPrev4x4PredModeFlag_Lorg_jcodec_codecs_common_biari_MDecoder_Handler ()
		{
			if (cb_prev4x4PredModeFlag_Lorg_jcodec_codecs_common_biari_MDecoder_ == null)
				cb_prev4x4PredModeFlag_Lorg_jcodec_codecs_common_biari_MDecoder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Prev4x4PredModeFlag_Lorg_jcodec_codecs_common_biari_MDecoder_);
			return cb_prev4x4PredModeFlag_Lorg_jcodec_codecs_common_biari_MDecoder_;
		}

		static bool n_Prev4x4PredModeFlag_Lorg_jcodec_codecs_common_biari_MDecoder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.H264.IO.CABAC __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Common.Biari.MDecoder p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.MDecoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Prev4x4PredModeFlag (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_prev4x4PredModeFlag_Lorg_jcodec_codecs_common_biari_MDecoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC']/method[@name='prev4x4PredModeFlag' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.common.biari.MDecoder']]"
		[Register ("prev4x4PredModeFlag", "(Lorg/jcodec/codecs/common/biari/MDecoder;)Z", "GetPrev4x4PredModeFlag_Lorg_jcodec_codecs_common_biari_MDecoder_Handler")]
		public virtual unsafe bool Prev4x4PredModeFlag (global::Org.Jcodec.Codecs.Common.Biari.MDecoder p0)
		{
			if (id_prev4x4PredModeFlag_Lorg_jcodec_codecs_common_biari_MDecoder_ == IntPtr.Zero)
				id_prev4x4PredModeFlag_Lorg_jcodec_codecs_common_biari_MDecoder_ = JNIEnv.GetMethodID (class_ref, "prev4x4PredModeFlag", "(Lorg/jcodec/codecs/common/biari/MDecoder;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_prev4x4PredModeFlag_Lorg_jcodec_codecs_common_biari_MDecoder_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prev4x4PredModeFlag", "(Lorg/jcodec/codecs/common/biari/MDecoder;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_readCoeffs_Lorg_jcodec_codecs_common_biari_MDecoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayIarrayIarrayI;
#pragma warning disable 0169
		static Delegate GetReadCoeffs_Lorg_jcodec_codecs_common_biari_MDecoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayIarrayIarrayIHandler ()
		{
			if (cb_readCoeffs_Lorg_jcodec_codecs_common_biari_MDecoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayIarrayIarrayI == null)
				cb_readCoeffs_Lorg_jcodec_codecs_common_biari_MDecoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayIarrayIarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr, IntPtr, int>) n_ReadCoeffs_Lorg_jcodec_codecs_common_biari_MDecoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayIarrayIarrayI);
			return cb_readCoeffs_Lorg_jcodec_codecs_common_biari_MDecoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayIarrayIarrayI;
		}

		static int n_ReadCoeffs_Lorg_jcodec_codecs_common_biari_MDecoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayIarrayIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7)
		{
			global::Org.Jcodec.Codecs.H264.IO.CABAC __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Common.Biari.MDecoder p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.MDecoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType p1 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType> (native_p1, JniHandleOwnership.DoNotTransfer);
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] p5 = (int[]) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] p6 = (int[]) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] p7 = (int[]) JNIEnv.GetArray (native_p7, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.ReadCoeffs (p0, p1, p2, p3, p4, p5, p6, p7);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
			if (p6 != null)
				JNIEnv.CopyArray (p6, native_p6);
			if (p7 != null)
				JNIEnv.CopyArray (p7, native_p7);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readCoeffs_Lorg_jcodec_codecs_common_biari_MDecoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayIarrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC']/method[@name='readCoeffs' and count(parameter)=8 and parameter[1][@type='org.jcodec.codecs.common.biari.MDecoder'] and parameter[2][@type='org.jcodec.codecs.h264.io.CABAC.BlockType'] and parameter[3][@type='int[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int[]'] and parameter[7][@type='int[]'] and parameter[8][@type='int[]']]"
		[Register ("readCoeffs", "(Lorg/jcodec/codecs/common/biari/MDecoder;Lorg/jcodec/codecs/h264/io/CABAC$BlockType;[III[I[I[I)I", "GetReadCoeffs_Lorg_jcodec_codecs_common_biari_MDecoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayIarrayIarrayIHandler")]
		public virtual unsafe int ReadCoeffs (global::Org.Jcodec.Codecs.Common.Biari.MDecoder p0, global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType p1, int[] p2, int p3, int p4, int[] p5, int[] p6, int[] p7)
		{
			if (id_readCoeffs_Lorg_jcodec_codecs_common_biari_MDecoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayIarrayIarrayI == IntPtr.Zero)
				id_readCoeffs_Lorg_jcodec_codecs_common_biari_MDecoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayIarrayIarrayI = JNIEnv.GetMethodID (class_ref, "readCoeffs", "(Lorg/jcodec/codecs/common/biari/MDecoder;Lorg/jcodec/codecs/h264/io/CABAC$BlockType;[III[I[I[I)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			IntPtr native_p7 = JNIEnv.NewArray (p7);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (native_p7);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readCoeffs_Lorg_jcodec_codecs_common_biari_MDecoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayIarrayIarrayI, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readCoeffs", "(Lorg/jcodec/codecs/common/biari/MDecoder;Lorg/jcodec/codecs/h264/io/CABAC$BlockType;[III[I[I[I)I"), __args);
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
				if (p6 != null) {
					JNIEnv.CopyArray (native_p6, p6);
					JNIEnv.DeleteLocalRef (native_p6);
				}
				if (p7 != null) {
					JNIEnv.CopyArray (native_p7, p7);
					JNIEnv.DeleteLocalRef (native_p7);
				}
			}
		}

		static Delegate cb_readMBTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_;
#pragma warning disable 0169
		static Delegate GetReadMBTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_Handler ()
		{
			if (cb_readMBTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_ == null)
				cb_readMBTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_ReadMBTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_);
			return cb_readMBTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_;
		}

		static int n_ReadMBTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.H264.IO.CABAC __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Common.Biari.MDecoder p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.MDecoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ReadMBTypeP (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readMBTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC']/method[@name='readMBTypeP' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.common.biari.MDecoder']]"
		[Register ("readMBTypeP", "(Lorg/jcodec/codecs/common/biari/MDecoder;)I", "GetReadMBTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_Handler")]
		public virtual unsafe int ReadMBTypeP (global::Org.Jcodec.Codecs.Common.Biari.MDecoder p0)
		{
			if (id_readMBTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_ == IntPtr.Zero)
				id_readMBTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_ = JNIEnv.GetMethodID (class_ref, "readMBTypeP", "(Lorg/jcodec/codecs/common/biari/MDecoder;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readMBTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readMBTypeP", "(Lorg/jcodec/codecs/common/biari/MDecoder;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_readSubMbTypeB_Lorg_jcodec_codecs_common_biari_MDecoder_;
#pragma warning disable 0169
		static Delegate GetReadSubMbTypeB_Lorg_jcodec_codecs_common_biari_MDecoder_Handler ()
		{
			if (cb_readSubMbTypeB_Lorg_jcodec_codecs_common_biari_MDecoder_ == null)
				cb_readSubMbTypeB_Lorg_jcodec_codecs_common_biari_MDecoder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_ReadSubMbTypeB_Lorg_jcodec_codecs_common_biari_MDecoder_);
			return cb_readSubMbTypeB_Lorg_jcodec_codecs_common_biari_MDecoder_;
		}

		static int n_ReadSubMbTypeB_Lorg_jcodec_codecs_common_biari_MDecoder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.H264.IO.CABAC __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Common.Biari.MDecoder p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.MDecoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ReadSubMbTypeB (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readSubMbTypeB_Lorg_jcodec_codecs_common_biari_MDecoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC']/method[@name='readSubMbTypeB' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.common.biari.MDecoder']]"
		[Register ("readSubMbTypeB", "(Lorg/jcodec/codecs/common/biari/MDecoder;)I", "GetReadSubMbTypeB_Lorg_jcodec_codecs_common_biari_MDecoder_Handler")]
		public virtual unsafe int ReadSubMbTypeB (global::Org.Jcodec.Codecs.Common.Biari.MDecoder p0)
		{
			if (id_readSubMbTypeB_Lorg_jcodec_codecs_common_biari_MDecoder_ == IntPtr.Zero)
				id_readSubMbTypeB_Lorg_jcodec_codecs_common_biari_MDecoder_ = JNIEnv.GetMethodID (class_ref, "readSubMbTypeB", "(Lorg/jcodec/codecs/common/biari/MDecoder;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readSubMbTypeB_Lorg_jcodec_codecs_common_biari_MDecoder_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readSubMbTypeB", "(Lorg/jcodec/codecs/common/biari/MDecoder;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_readSubMbTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_;
#pragma warning disable 0169
		static Delegate GetReadSubMbTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_Handler ()
		{
			if (cb_readSubMbTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_ == null)
				cb_readSubMbTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_ReadSubMbTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_);
			return cb_readSubMbTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_;
		}

		static int n_ReadSubMbTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.H264.IO.CABAC __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Common.Biari.MDecoder p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.MDecoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ReadSubMbTypeP (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readSubMbTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC']/method[@name='readSubMbTypeP' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.common.biari.MDecoder']]"
		[Register ("readSubMbTypeP", "(Lorg/jcodec/codecs/common/biari/MDecoder;)I", "GetReadSubMbTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_Handler")]
		public virtual unsafe int ReadSubMbTypeP (global::Org.Jcodec.Codecs.Common.Biari.MDecoder p0)
		{
			if (id_readSubMbTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_ == IntPtr.Zero)
				id_readSubMbTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_ = JNIEnv.GetMethodID (class_ref, "readSubMbTypeP", "(Lorg/jcodec/codecs/common/biari/MDecoder;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readSubMbTypeP_Lorg_jcodec_codecs_common_biari_MDecoder_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readSubMbTypeP", "(Lorg/jcodec/codecs/common/biari/MDecoder;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_rem4x4PredMode_Lorg_jcodec_codecs_common_biari_MDecoder_;
#pragma warning disable 0169
		static Delegate GetRem4x4PredMode_Lorg_jcodec_codecs_common_biari_MDecoder_Handler ()
		{
			if (cb_rem4x4PredMode_Lorg_jcodec_codecs_common_biari_MDecoder_ == null)
				cb_rem4x4PredMode_Lorg_jcodec_codecs_common_biari_MDecoder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Rem4x4PredMode_Lorg_jcodec_codecs_common_biari_MDecoder_);
			return cb_rem4x4PredMode_Lorg_jcodec_codecs_common_biari_MDecoder_;
		}

		static int n_Rem4x4PredMode_Lorg_jcodec_codecs_common_biari_MDecoder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.H264.IO.CABAC __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Common.Biari.MDecoder p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.MDecoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Rem4x4PredMode (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_rem4x4PredMode_Lorg_jcodec_codecs_common_biari_MDecoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC']/method[@name='rem4x4PredMode' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.common.biari.MDecoder']]"
		[Register ("rem4x4PredMode", "(Lorg/jcodec/codecs/common/biari/MDecoder;)I", "GetRem4x4PredMode_Lorg_jcodec_codecs_common_biari_MDecoder_Handler")]
		public virtual unsafe int Rem4x4PredMode (global::Org.Jcodec.Codecs.Common.Biari.MDecoder p0)
		{
			if (id_rem4x4PredMode_Lorg_jcodec_codecs_common_biari_MDecoder_ == IntPtr.Zero)
				id_rem4x4PredMode_Lorg_jcodec_codecs_common_biari_MDecoder_ = JNIEnv.GetMethodID (class_ref, "rem4x4PredMode", "(Lorg/jcodec/codecs/common/biari/MDecoder;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_rem4x4PredMode_Lorg_jcodec_codecs_common_biari_MDecoder_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rem4x4PredMode", "(Lorg/jcodec/codecs/common/biari/MDecoder;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setCodedBlock_II;
#pragma warning disable 0169
		static Delegate GetSetCodedBlock_IIHandler ()
		{
			if (cb_setCodedBlock_II == null)
				cb_setCodedBlock_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetCodedBlock_II);
			return cb_setCodedBlock_II;
		}

		static void n_SetCodedBlock_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Org.Jcodec.Codecs.H264.IO.CABAC __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCodedBlock (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setCodedBlock_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC']/method[@name='setCodedBlock' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setCodedBlock", "(II)V", "GetSetCodedBlock_IIHandler")]
		public virtual unsafe void SetCodedBlock (int p0, int p1)
		{
			if (id_setCodedBlock_II == IntPtr.Zero)
				id_setCodedBlock_II = JNIEnv.GetMethodID (class_ref, "setCodedBlock", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCodedBlock_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCodedBlock", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPrevCBP_I;
#pragma warning disable 0169
		static Delegate GetSetPrevCBP_IHandler ()
		{
			if (cb_setPrevCBP_I == null)
				cb_setPrevCBP_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPrevCBP_I);
			return cb_setPrevCBP_I;
		}

		static void n_SetPrevCBP_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Codecs.H264.IO.CABAC __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPrevCBP (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPrevCBP_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC']/method[@name='setPrevCBP' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPrevCBP", "(I)V", "GetSetPrevCBP_IHandler")]
		public virtual unsafe void SetPrevCBP (int p0)
		{
			if (id_setPrevCBP_I == IntPtr.Zero)
				id_setPrevCBP_I = JNIEnv.GetMethodID (class_ref, "setPrevCBP", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPrevCBP_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPrevCBP", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeCoeffs_Lorg_jcodec_codecs_common_biari_MEncoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayI;
#pragma warning disable 0169
		static Delegate GetWriteCoeffs_Lorg_jcodec_codecs_common_biari_MEncoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayIHandler ()
		{
			if (cb_writeCoeffs_Lorg_jcodec_codecs_common_biari_MEncoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayI == null)
				cb_writeCoeffs_Lorg_jcodec_codecs_common_biari_MEncoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_WriteCoeffs_Lorg_jcodec_codecs_common_biari_MEncoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayI);
			return cb_writeCoeffs_Lorg_jcodec_codecs_common_biari_MEncoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayI;
		}

		static void n_WriteCoeffs_Lorg_jcodec_codecs_common_biari_MEncoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4, IntPtr native_p5)
		{
			global::Org.Jcodec.Codecs.H264.IO.CABAC __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Common.Biari.MEncoder p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.MEncoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType p1 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType> (native_p1, JniHandleOwnership.DoNotTransfer);
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] p5 = (int[]) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.WriteCoeffs (p0, p1, p2, p3, p4, p5);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
		}
#pragma warning restore 0169

		static IntPtr id_writeCoeffs_Lorg_jcodec_codecs_common_biari_MEncoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CABAC']/method[@name='writeCoeffs' and count(parameter)=6 and parameter[1][@type='org.jcodec.codecs.common.biari.MEncoder'] and parameter[2][@type='org.jcodec.codecs.h264.io.CABAC.BlockType'] and parameter[3][@type='int[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int[]']]"
		[Register ("writeCoeffs", "(Lorg/jcodec/codecs/common/biari/MEncoder;Lorg/jcodec/codecs/h264/io/CABAC$BlockType;[III[I)V", "GetWriteCoeffs_Lorg_jcodec_codecs_common_biari_MEncoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayIHandler")]
		public virtual unsafe void WriteCoeffs (global::Org.Jcodec.Codecs.Common.Biari.MEncoder p0, global::Org.Jcodec.Codecs.H264.IO.CABAC.BlockType p1, int[] p2, int p3, int p4, int[] p5)
		{
			if (id_writeCoeffs_Lorg_jcodec_codecs_common_biari_MEncoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayI == IntPtr.Zero)
				id_writeCoeffs_Lorg_jcodec_codecs_common_biari_MEncoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayI = JNIEnv.GetMethodID (class_ref, "writeCoeffs", "(Lorg/jcodec/codecs/common/biari/MEncoder;Lorg/jcodec/codecs/h264/io/CABAC$BlockType;[III[I)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeCoeffs_Lorg_jcodec_codecs_common_biari_MEncoder_Lorg_jcodec_codecs_h264_io_CABAC_BlockType_arrayIIIarrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeCoeffs", "(Lorg/jcodec/codecs/common/biari/MEncoder;Lorg/jcodec/codecs/h264/io/CABAC$BlockType;[III[I)V"), __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
			}
		}

	}
}
