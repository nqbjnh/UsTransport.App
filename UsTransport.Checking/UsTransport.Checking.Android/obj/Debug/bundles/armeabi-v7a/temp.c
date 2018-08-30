void (*mono_jit_set_aot_mode_ptr) (int mode);
/* This source code was produced by mkbundle, do not edit */

#ifndef NULL
#define NULL (void *)0
#endif

typedef struct {
	const char *name;
	const unsigned char *data;
	const unsigned int size;
} MonoBundledAssembly;
void          mono_register_bundled_assemblies (const MonoBundledAssembly **assemblies);
void          mono_register_config_for_assembly (const char* assembly_name, const char* config_xml);

#define MONO_AOT_MODE_NORMAL 1
#define MONO_AOT_MODE_FULL 3
#define MONO_AOT_MODE_LLVMONLY 4
typedef struct _compressed_data {
	MonoBundledAssembly assembly;
	int compressed_size;
} CompressedAssembly;

extern const unsigned char assembly_data_UsTransport_Checking_Android_dll [];
static CompressedAssembly assembly_bundle_UsTransport_Checking_Android_dll = {{"UsTransport.Checking.Android.dll", assembly_data_UsTransport_Checking_Android_dll, 104448}, 37755};
extern const unsigned char assembly_data_FastAndroidCamera_dll [];
static CompressedAssembly assembly_bundle_FastAndroidCamera_dll = {{"FastAndroidCamera.dll", assembly_data_FastAndroidCamera_dll, 11264}, 4963};
extern const unsigned char assembly_data_FormsViewGroup_dll [];
static CompressedAssembly assembly_bundle_FormsViewGroup_dll = {{"FormsViewGroup.dll", assembly_data_FormsViewGroup_dll, 12800}, 4957};
extern const unsigned char assembly_data_Newtonsoft_Json_dll [];
static CompressedAssembly assembly_bundle_Newtonsoft_Json_dll = {{"Newtonsoft.Json.dll", assembly_data_Newtonsoft_Json_dll, 653312}, 245024};
extern const unsigned char assembly_data_UsTransport_Checking_dll [];
static CompressedAssembly assembly_bundle_UsTransport_Checking_dll = {{"UsTransport.Checking.dll", assembly_data_UsTransport_Checking_dll, 110080}, 38857};
extern const unsigned char assembly_data_Xamarin_Android_Arch_Core_Common_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Arch_Core_Common_dll = {{"Xamarin.Android.Arch.Core.Common.dll", assembly_data_Xamarin_Android_Arch_Core_Common_dll, 17920}, 6135};
extern const unsigned char assembly_data_Xamarin_Android_Arch_Lifecycle_Common_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Arch_Lifecycle_Common_dll = {{"Xamarin.Android.Arch.Lifecycle.Common.dll", assembly_data_Xamarin_Android_Arch_Lifecycle_Common_dll, 14336}, 5378};
extern const unsigned char assembly_data_Xamarin_Android_Arch_Lifecycle_Runtime_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Arch_Lifecycle_Runtime_dll = {{"Xamarin.Android.Arch.Lifecycle.Runtime.dll", assembly_data_Xamarin_Android_Arch_Lifecycle_Runtime_dll, 5120}, 1953};
extern const unsigned char assembly_data_Xamarin_Android_Support_Animated_Vector_Drawable_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Animated_Vector_Drawable_dll = {{"Xamarin.Android.Support.Animated.Vector.Drawable.dll", assembly_data_Xamarin_Android_Support_Animated_Vector_Drawable_dll, 6144}, 2221};
extern const unsigned char assembly_data_Xamarin_Android_Support_Annotations_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Annotations_dll = {{"Xamarin.Android.Support.Annotations.dll", assembly_data_Xamarin_Android_Support_Annotations_dll, 5632}, 2139};
extern const unsigned char assembly_data_Xamarin_Android_Support_Compat_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Compat_dll = {{"Xamarin.Android.Support.Compat.dll", assembly_data_Xamarin_Android_Support_Compat_dll, 161792}, 41857};
extern const unsigned char assembly_data_Xamarin_Android_Support_Core_UI_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Core_UI_dll = {{"Xamarin.Android.Support.Core.UI.dll", assembly_data_Xamarin_Android_Support_Core_UI_dll, 119808}, 31608};
extern const unsigned char assembly_data_Xamarin_Android_Support_Core_Utils_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Core_Utils_dll = {{"Xamarin.Android.Support.Core.Utils.dll", assembly_data_Xamarin_Android_Support_Core_Utils_dll, 36352}, 10947};
extern const unsigned char assembly_data_Xamarin_Android_Support_Design_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Design_dll = {{"Xamarin.Android.Support.Design.dll", assembly_data_Xamarin_Android_Support_Design_dll, 58368}, 15973};
extern const unsigned char assembly_data_Xamarin_Android_Support_Fragment_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Fragment_dll = {{"Xamarin.Android.Support.Fragment.dll", assembly_data_Xamarin_Android_Support_Fragment_dll, 168448}, 40872};
extern const unsigned char assembly_data_Xamarin_Android_Support_Media_Compat_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Media_Compat_dll = {{"Xamarin.Android.Support.Media.Compat.dll", assembly_data_Xamarin_Android_Support_Media_Compat_dll, 6656}, 2362};
extern const unsigned char assembly_data_Xamarin_Android_Support_Transition_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Transition_dll = {{"Xamarin.Android.Support.Transition.dll", assembly_data_Xamarin_Android_Support_Transition_dll, 10752}, 2747};
extern const unsigned char assembly_data_Xamarin_Android_Support_v4_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_v4_dll = {{"Xamarin.Android.Support.v4.dll", assembly_data_Xamarin_Android_Support_v4_dll, 8704}, 2947};
extern const unsigned char assembly_data_Xamarin_Android_Support_v7_AppCompat_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_v7_AppCompat_dll = {{"Xamarin.Android.Support.v7.AppCompat.dll", assembly_data_Xamarin_Android_Support_v7_AppCompat_dll, 367104}, 88793};
extern const unsigned char assembly_data_Xamarin_Android_Support_v7_CardView_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_v7_CardView_dll = {{"Xamarin.Android.Support.v7.CardView.dll", assembly_data_Xamarin_Android_Support_v7_CardView_dll, 18944}, 6283};
extern const unsigned char assembly_data_Xamarin_Android_Support_v7_MediaRouter_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_v7_MediaRouter_dll = {{"Xamarin.Android.Support.v7.MediaRouter.dll", assembly_data_Xamarin_Android_Support_v7_MediaRouter_dll, 5632}, 2029};
extern const unsigned char assembly_data_Xamarin_Android_Support_v7_Palette_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_v7_Palette_dll = {{"Xamarin.Android.Support.v7.Palette.dll", assembly_data_Xamarin_Android_Support_v7_Palette_dll, 5120}, 1967};
extern const unsigned char assembly_data_Xamarin_Android_Support_v7_RecyclerView_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_v7_RecyclerView_dll = {{"Xamarin.Android.Support.v7.RecyclerView.dll", assembly_data_Xamarin_Android_Support_v7_RecyclerView_dll, 6144}, 2271};
extern const unsigned char assembly_data_Xamarin_Android_Support_Vector_Drawable_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Vector_Drawable_dll = {{"Xamarin.Android.Support.Vector.Drawable.dll", assembly_data_Xamarin_Android_Support_Vector_Drawable_dll, 5120}, 1977};
extern const unsigned char assembly_data_Xamarin_Forms_Core_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Forms_Core_dll = {{"Xamarin.Forms.Core.dll", assembly_data_Xamarin_Forms_Core_dll, 666624}, 257955};
extern const unsigned char assembly_data_Xamarin_Forms_Platform_Android_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Forms_Platform_Android_dll = {{"Xamarin.Forms.Platform.Android.dll", assembly_data_Xamarin_Forms_Platform_Android_dll, 331344}, 143478};
extern const unsigned char assembly_data_Xamarin_Forms_Platform_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Forms_Platform_dll = {{"Xamarin.Forms.Platform.dll", assembly_data_Xamarin_Forms_Platform_dll, 16960}, 7028};
extern const unsigned char assembly_data_Xamarin_Forms_Xaml_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Forms_Xaml_dll = {{"Xamarin.Forms.Xaml.dll", assembly_data_Xamarin_Forms_Xaml_dll, 77824}, 33770};
extern const unsigned char assembly_data_ZXing_Net_Mobile_Core_dll [];
static CompressedAssembly assembly_bundle_ZXing_Net_Mobile_Core_dll = {{"ZXing.Net.Mobile.Core.dll", assembly_data_ZXing_Net_Mobile_Core_dll, 12800}, 5226};
extern const unsigned char assembly_data_ZXing_Net_Mobile_Forms_Android_dll [];
static CompressedAssembly assembly_bundle_ZXing_Net_Mobile_Forms_Android_dll = {{"ZXing.Net.Mobile.Forms.Android.dll", assembly_data_ZXing_Net_Mobile_Forms_Android_dll, 9728}, 4511};
extern const unsigned char assembly_data_ZXing_Net_Mobile_Forms_dll [];
static CompressedAssembly assembly_bundle_ZXing_Net_Mobile_Forms_dll = {{"ZXing.Net.Mobile.Forms.dll", assembly_data_ZXing_Net_Mobile_Forms_dll, 15360}, 5992};
extern const unsigned char assembly_data_zxing_portable_dll [];
static CompressedAssembly assembly_bundle_zxing_portable_dll = {{"zxing.portable.dll", assembly_data_zxing_portable_dll, 444416}, 203654};
extern const unsigned char assembly_data_ZXingNetMobile_dll [];
static CompressedAssembly assembly_bundle_ZXingNetMobile_dll = {{"ZXingNetMobile.dll", assembly_data_ZXingNetMobile_dll, 40960}, 19656};
extern const unsigned char assembly_data_Java_Interop_dll [];
static CompressedAssembly assembly_bundle_Java_Interop_dll = {{"Java.Interop.dll", assembly_data_Java_Interop_dll, 192224}, 66854};
extern const unsigned char assembly_data_Mono_Android_dll [];
static CompressedAssembly assembly_bundle_Mono_Android_dll = {{"Mono.Android.dll", assembly_data_Mono_Android_dll, 24227040}, 5332300};
extern const unsigned char assembly_data_mscorlib_dll [];
static CompressedAssembly assembly_bundle_mscorlib_dll = {{"mscorlib.dll", assembly_data_mscorlib_dll, 3870424}, 1359196};
extern const unsigned char assembly_data_System_Core_dll [];
static CompressedAssembly assembly_bundle_System_Core_dll = {{"System.Core.dll", assembly_data_System_Core_dll, 1009376}, 346289};
extern const unsigned char assembly_data_System_dll [];
static CompressedAssembly assembly_bundle_System_dll = {{"System.dll", assembly_data_System_dll, 2064592}, 747415};
extern const unsigned char assembly_data_System_Net_Http_dll [];
static CompressedAssembly assembly_bundle_System_Net_Http_dll = {{"System.Net.Http.dll", assembly_data_System_Net_Http_dll, 123112}, 53591};
extern const unsigned char assembly_data_System_Xml_dll [];
static CompressedAssembly assembly_bundle_System_Xml_dll = {{"System.Xml.dll", assembly_data_System_Xml_dll, 2422488}, 813459};
extern const unsigned char assembly_data_System_Xml_Linq_dll [];
static CompressedAssembly assembly_bundle_System_Xml_Linq_dll = {{"System.Xml.Linq.dll", assembly_data_System_Xml_Linq_dll, 126696}, 52863};
extern const unsigned char assembly_data_System_Runtime_dll [];
static CompressedAssembly assembly_bundle_System_Runtime_dll = {{"System.Runtime.dll", assembly_data_System_Runtime_dll, 19184}, 9164};
extern const unsigned char assembly_data_System_ComponentModel_Composition_dll [];
static CompressedAssembly assembly_bundle_System_ComponentModel_Composition_dll = {{"System.ComponentModel.Composition.dll", assembly_data_System_ComponentModel_Composition_dll, 264968}, 107626};
extern const unsigned char assembly_data_System_Diagnostics_Debug_dll [];
static CompressedAssembly assembly_bundle_System_Diagnostics_Debug_dll = {{"System.Diagnostics.Debug.dll", assembly_data_System_Diagnostics_Debug_dll, 11528}, 6467};
extern const unsigned char assembly_data_System_Threading_dll [];
static CompressedAssembly assembly_bundle_System_Threading_dll = {{"System.Threading.dll", assembly_data_System_Threading_dll, 12536}, 6820};
extern const unsigned char assembly_data_System_Collections_dll [];
static CompressedAssembly assembly_bundle_System_Collections_dll = {{"System.Collections.dll", assembly_data_System_Collections_dll, 12032}, 6685};
extern const unsigned char assembly_data_System_Collections_Concurrent_dll [];
static CompressedAssembly assembly_bundle_System_Collections_Concurrent_dll = {{"System.Collections.Concurrent.dll", assembly_data_System_Collections_Concurrent_dll, 11544}, 6516};
extern const unsigned char assembly_data_System_Reflection_dll [];
static CompressedAssembly assembly_bundle_System_Reflection_dll = {{"System.Reflection.dll", assembly_data_System_Reflection_dll, 12536}, 6777};
extern const unsigned char assembly_data_System_Linq_Expressions_dll [];
static CompressedAssembly assembly_bundle_System_Linq_Expressions_dll = {{"System.Linq.Expressions.dll", assembly_data_System_Linq_Expressions_dll, 13576}, 7034};
extern const unsigned char assembly_data_System_Reflection_Primitives_dll [];
static CompressedAssembly assembly_bundle_System_Reflection_Primitives_dll = {{"System.Reflection.Primitives.dll", assembly_data_System_Reflection_Primitives_dll, 12048}, 6540};
extern const unsigned char assembly_data_System_Dynamic_Runtime_dll [];
static CompressedAssembly assembly_bundle_System_Dynamic_Runtime_dll = {{"System.Dynamic.Runtime.dll", assembly_data_System_Dynamic_Runtime_dll, 12544}, 6710};
extern const unsigned char assembly_data_System_ObjectModel_dll [];
static CompressedAssembly assembly_bundle_System_ObjectModel_dll = {{"System.ObjectModel.dll", assembly_data_System_ObjectModel_dll, 12032}, 6638};
extern const unsigned char assembly_data_System_Linq_dll [];
static CompressedAssembly assembly_bundle_System_Linq_dll = {{"System.Linq.dll", assembly_data_System_Linq_dll, 10992}, 6434};
extern const unsigned char assembly_data_System_Runtime_InteropServices_dll [];
static CompressedAssembly assembly_bundle_System_Runtime_InteropServices_dll = {{"System.Runtime.InteropServices.dll", assembly_data_System_Runtime_InteropServices_dll, 14616}, 7597};
extern const unsigned char assembly_data_System_Runtime_Extensions_dll [];
static CompressedAssembly assembly_bundle_System_Runtime_Extensions_dll = {{"System.Runtime.Extensions.dll", assembly_data_System_Runtime_Extensions_dll, 12040}, 6564};
extern const unsigned char assembly_data_System_Reflection_Extensions_dll [];
static CompressedAssembly assembly_bundle_System_Reflection_Extensions_dll = {{"System.Reflection.Extensions.dll", assembly_data_System_Reflection_Extensions_dll, 11536}, 6400};
extern const unsigned char assembly_data_System_Runtime_Serialization_dll [];
static CompressedAssembly assembly_bundle_System_Runtime_Serialization_dll = {{"System.Runtime.Serialization.dll", assembly_data_System_Runtime_Serialization_dll, 844544}, 278087};
extern const unsigned char assembly_data_System_ServiceModel_Internals_dll [];
static CompressedAssembly assembly_bundle_System_ServiceModel_Internals_dll = {{"System.ServiceModel.Internals.dll", assembly_data_System_ServiceModel_Internals_dll, 225024}, 89850};
extern const unsigned char assembly_data_netstandard_dll [];
static CompressedAssembly assembly_bundle_netstandard_dll = {{"netstandard.dll", assembly_data_netstandard_dll, 91888}, 29163};
extern const unsigned char assembly_data_System_Data_dll [];
static CompressedAssembly assembly_bundle_System_Data_dll = {{"System.Data.dll", assembly_data_System_Data_dll, 1942752}, 669208};
extern const unsigned char assembly_data_System_Numerics_dll [];
static CompressedAssembly assembly_bundle_System_Numerics_dll = {{"System.Numerics.dll", assembly_data_System_Numerics_dll, 130280}, 49684};
extern const unsigned char assembly_data_System_Transactions_dll [];
static CompressedAssembly assembly_bundle_System_Transactions_dll = {{"System.Transactions.dll", assembly_data_System_Transactions_dll, 38640}, 16933};
extern const unsigned char assembly_data_System_Diagnostics_StackTrace_dll [];
static CompressedAssembly assembly_bundle_System_Diagnostics_StackTrace_dll = {{"System.Diagnostics.StackTrace.dll", assembly_data_System_Diagnostics_StackTrace_dll, 13592}, 7258};
extern const unsigned char assembly_data_System_Globalization_Extensions_dll [];
static CompressedAssembly assembly_bundle_System_Globalization_Extensions_dll = {{"System.Globalization.Extensions.dll", assembly_data_System_Globalization_Extensions_dll, 13592}, 7416};
extern const unsigned char assembly_data_System_IO_Compression_dll [];
static CompressedAssembly assembly_bundle_System_IO_Compression_dll = {{"System.IO.Compression.dll", assembly_data_System_IO_Compression_dll, 106224}, 49923};
extern const unsigned char assembly_data_System_IO_Compression_FileSystem_dll [];
static CompressedAssembly assembly_bundle_System_IO_Compression_FileSystem_dll = {{"System.IO.Compression.FileSystem.dll", assembly_data_System_IO_Compression_FileSystem_dll, 29960}, 13505};
extern const unsigned char assembly_data_System_Runtime_Serialization_Xml_dll [];
static CompressedAssembly assembly_bundle_System_Runtime_Serialization_Xml_dll = {{"System.Runtime.Serialization.Xml.dll", assembly_data_System_Runtime_Serialization_Xml_dll, 14112}, 7640};
extern const unsigned char assembly_data_System_Runtime_Serialization_Primitives_dll [];
static CompressedAssembly assembly_bundle_System_Runtime_Serialization_Primitives_dll = {{"System.Runtime.Serialization.Primitives.dll", assembly_data_System_Runtime_Serialization_Primitives_dll, 12584}, 6858};
extern const unsigned char assembly_data_System_Security_Cryptography_Algorithms_dll [];
static CompressedAssembly assembly_bundle_System_Security_Cryptography_Algorithms_dll = {{"System.Security.Cryptography.Algorithms.dll", assembly_data_System_Security_Cryptography_Algorithms_dll, 16680}, 8547};
extern const unsigned char assembly_data_System_Security_SecureString_dll [];
static CompressedAssembly assembly_bundle_System_Security_SecureString_dll = {{"System.Security.SecureString.dll", assembly_data_System_Security_SecureString_dll, 12048}, 6660};
extern const unsigned char assembly_data_System_Web_Services_dll [];
static CompressedAssembly assembly_bundle_System_Web_Services_dll = {{"System.Web.Services.dll", assembly_data_System_Web_Services_dll, 220912}, 79564};
extern const unsigned char assembly_data_System_Xml_XPath_XDocument_dll [];
static CompressedAssembly assembly_bundle_System_Xml_XPath_XDocument_dll = {{"System.Xml.XPath.XDocument.dll", assembly_data_System_Xml_XPath_XDocument_dll, 12048}, 6764};
extern const unsigned char assembly_data_Mono_Security_dll [];
static CompressedAssembly assembly_bundle_Mono_Security_dll = {{"Mono.Security.dll", assembly_data_Mono_Security_dll, 316640}, 132937};
extern const unsigned char assembly_data_System_Threading_Tasks_dll [];
static CompressedAssembly assembly_bundle_System_Threading_Tasks_dll = {{"System.Threading.Tasks.dll", assembly_data_System_Threading_Tasks_dll, 12552}, 6855};
extern const unsigned char assembly_data_System_Text_Encoding_dll [];
static CompressedAssembly assembly_bundle_System_Text_Encoding_dll = {{"System.Text.Encoding.dll", assembly_data_System_Text_Encoding_dll, 12032}, 6527};
extern const unsigned char assembly_data_System_IO_dll [];
static CompressedAssembly assembly_bundle_System_IO_dll = {{"System.IO.dll", assembly_data_System_IO_dll, 11496}, 6552};
extern const unsigned char assembly_data_System_Text_RegularExpressions_dll [];
static CompressedAssembly assembly_bundle_System_Text_RegularExpressions_dll = {{"System.Text.RegularExpressions.dll", assembly_data_System_Text_RegularExpressions_dll, 11544}, 6498};
extern const unsigned char assembly_data_System_Globalization_dll [];
static CompressedAssembly assembly_bundle_System_Globalization_dll = {{"System.Globalization.dll", assembly_data_System_Globalization_dll, 12032}, 6552};

static const CompressedAssembly *compressed [] = {
	&assembly_bundle_UsTransport_Checking_Android_dll,
	&assembly_bundle_FastAndroidCamera_dll,
	&assembly_bundle_FormsViewGroup_dll,
	&assembly_bundle_Newtonsoft_Json_dll,
	&assembly_bundle_UsTransport_Checking_dll,
	&assembly_bundle_Xamarin_Android_Arch_Core_Common_dll,
	&assembly_bundle_Xamarin_Android_Arch_Lifecycle_Common_dll,
	&assembly_bundle_Xamarin_Android_Arch_Lifecycle_Runtime_dll,
	&assembly_bundle_Xamarin_Android_Support_Animated_Vector_Drawable_dll,
	&assembly_bundle_Xamarin_Android_Support_Annotations_dll,
	&assembly_bundle_Xamarin_Android_Support_Compat_dll,
	&assembly_bundle_Xamarin_Android_Support_Core_UI_dll,
	&assembly_bundle_Xamarin_Android_Support_Core_Utils_dll,
	&assembly_bundle_Xamarin_Android_Support_Design_dll,
	&assembly_bundle_Xamarin_Android_Support_Fragment_dll,
	&assembly_bundle_Xamarin_Android_Support_Media_Compat_dll,
	&assembly_bundle_Xamarin_Android_Support_Transition_dll,
	&assembly_bundle_Xamarin_Android_Support_v4_dll,
	&assembly_bundle_Xamarin_Android_Support_v7_AppCompat_dll,
	&assembly_bundle_Xamarin_Android_Support_v7_CardView_dll,
	&assembly_bundle_Xamarin_Android_Support_v7_MediaRouter_dll,
	&assembly_bundle_Xamarin_Android_Support_v7_Palette_dll,
	&assembly_bundle_Xamarin_Android_Support_v7_RecyclerView_dll,
	&assembly_bundle_Xamarin_Android_Support_Vector_Drawable_dll,
	&assembly_bundle_Xamarin_Forms_Core_dll,
	&assembly_bundle_Xamarin_Forms_Platform_Android_dll,
	&assembly_bundle_Xamarin_Forms_Platform_dll,
	&assembly_bundle_Xamarin_Forms_Xaml_dll,
	&assembly_bundle_ZXing_Net_Mobile_Core_dll,
	&assembly_bundle_ZXing_Net_Mobile_Forms_Android_dll,
	&assembly_bundle_ZXing_Net_Mobile_Forms_dll,
	&assembly_bundle_zxing_portable_dll,
	&assembly_bundle_ZXingNetMobile_dll,
	&assembly_bundle_Java_Interop_dll,
	&assembly_bundle_Mono_Android_dll,
	&assembly_bundle_mscorlib_dll,
	&assembly_bundle_System_Core_dll,
	&assembly_bundle_System_dll,
	&assembly_bundle_System_Net_Http_dll,
	&assembly_bundle_System_Xml_dll,
	&assembly_bundle_System_Xml_Linq_dll,
	&assembly_bundle_System_Runtime_dll,
	&assembly_bundle_System_ComponentModel_Composition_dll,
	&assembly_bundle_System_Diagnostics_Debug_dll,
	&assembly_bundle_System_Threading_dll,
	&assembly_bundle_System_Collections_dll,
	&assembly_bundle_System_Collections_Concurrent_dll,
	&assembly_bundle_System_Reflection_dll,
	&assembly_bundle_System_Linq_Expressions_dll,
	&assembly_bundle_System_Reflection_Primitives_dll,
	&assembly_bundle_System_Dynamic_Runtime_dll,
	&assembly_bundle_System_ObjectModel_dll,
	&assembly_bundle_System_Linq_dll,
	&assembly_bundle_System_Runtime_InteropServices_dll,
	&assembly_bundle_System_Runtime_Extensions_dll,
	&assembly_bundle_System_Reflection_Extensions_dll,
	&assembly_bundle_System_Runtime_Serialization_dll,
	&assembly_bundle_System_ServiceModel_Internals_dll,
	&assembly_bundle_netstandard_dll,
	&assembly_bundle_System_Data_dll,
	&assembly_bundle_System_Numerics_dll,
	&assembly_bundle_System_Transactions_dll,
	&assembly_bundle_System_Diagnostics_StackTrace_dll,
	&assembly_bundle_System_Globalization_Extensions_dll,
	&assembly_bundle_System_IO_Compression_dll,
	&assembly_bundle_System_IO_Compression_FileSystem_dll,
	&assembly_bundle_System_Runtime_Serialization_Xml_dll,
	&assembly_bundle_System_Runtime_Serialization_Primitives_dll,
	&assembly_bundle_System_Security_Cryptography_Algorithms_dll,
	&assembly_bundle_System_Security_SecureString_dll,
	&assembly_bundle_System_Web_Services_dll,
	&assembly_bundle_System_Xml_XPath_XDocument_dll,
	&assembly_bundle_Mono_Security_dll,
	&assembly_bundle_System_Threading_Tasks_dll,
	&assembly_bundle_System_Text_Encoding_dll,
	&assembly_bundle_System_IO_dll,
	&assembly_bundle_System_Text_RegularExpressions_dll,
	&assembly_bundle_System_Globalization_dll,
	NULL
};


static void install_aot_modules (void) {

	mono_jit_set_aot_mode_ptr (MONO_AOT_MODE_NORMAL);

}

static char *image_name = "UsTransport.Checking.Android.dll";

static void install_dll_config_files (void (register_config_for_assembly_func)(const char *, const char *)) {

}

static const char *config_dir = NULL;
static MonoBundledAssembly **bundled;

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <zlib.h>

static int
my_inflate (const Byte *compr, uLong compr_len, Byte *uncompr, uLong uncompr_len)
{
	int err;
	z_stream stream;

	memset (&stream, 0, sizeof (z_stream));
	stream.next_in = (Byte *) compr;
	stream.avail_in = (uInt) compr_len;

	// http://www.zlib.net/manual.html
	err = inflateInit2 (&stream, 16+MAX_WBITS);
	if (err != Z_OK)
		return 1;

	for (;;) {
		stream.next_out = uncompr;
		stream.avail_out = (uInt) uncompr_len;
		err = inflate (&stream, Z_NO_FLUSH);
		if (err == Z_STREAM_END) break;
		if (err != Z_OK) {
			printf ("%d\n", err);
			return 2;
		}
	}

	err = inflateEnd (&stream);
	if (err != Z_OK)
		return 3;

	if (stream.total_out != uncompr_len)
		return 4;
	
	return 0;
}

void mono_mkbundle_init (void (register_bundled_assemblies_func)(const MonoBundledAssembly **), void (register_config_for_assembly_func)(const char *, const char *), void (mono_jit_set_aot_mode_func) (int mode))
{
	CompressedAssembly **ptr;
	MonoBundledAssembly **bundled_ptr;
	Bytef *buffer;
	int nbundles;

	mono_jit_set_aot_mode_ptr = mono_jit_set_aot_mode_func;

	install_dll_config_files (register_config_for_assembly_func);

	ptr = (CompressedAssembly **) compressed;
	nbundles = 0;
	while (*ptr++ != NULL)
		nbundles++;

	bundled = (MonoBundledAssembly **) malloc (sizeof (MonoBundledAssembly *) * (nbundles + 1));
	bundled_ptr = bundled;
	ptr = (CompressedAssembly **) compressed;
	while (*ptr != NULL) {
		uLong real_size;
		uLongf zsize;
		int result;
		MonoBundledAssembly *current;

		real_size = (*ptr)->assembly.size;
		zsize = (*ptr)->compressed_size;
		buffer = (Bytef *) malloc (real_size);
		result = my_inflate ((*ptr)->assembly.data, zsize, buffer, real_size);
		if (result != 0) {
			fprintf (stderr, "mkbundle: Error %d decompressing data for %s\n", result, (*ptr)->assembly.name);
			exit (1);
		}
		(*ptr)->assembly.data = buffer;
		current = (MonoBundledAssembly *) malloc (sizeof (MonoBundledAssembly));
		memcpy (current, *ptr, sizeof (MonoBundledAssembly));
		current->name = (*ptr)->assembly.name;
		*bundled_ptr = current;
		bundled_ptr++;
		ptr++;
	}
	*bundled_ptr = NULL;
	register_bundled_assemblies_func((const MonoBundledAssembly **) bundled);
}
