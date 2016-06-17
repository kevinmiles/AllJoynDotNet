// Generated from AboutProxy.h

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;

namespace AllJoynDotNet
{
//
    public partial class AboutProxy : AllJoynWrapper
    {
        internal AboutProxy(IntPtr handle) : base(handle) { }
		/// <summary>
		/// Allocate a new alljoyn_aboutproxy object.
		/// </summary>
		/// <param name="bus">reference to alljoyn_busattachment</param>
		/// <param name="busName">unique or well-known name of remote AllJoyn bus</param>
		/// <param name="sessionId">the session received after joining AllJoyn session</param>
		/// <returns>The allocated alljoyn_aboutproxy.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern IntPtr alljoyn_aboutproxy_create(IntPtr bus, [MarshalAs(UnmanagedType.LPStr)]string busName, UInt32 sessionId);
		// extern AJ_API alljoyn_aboutproxy AJ_CALL alljoyn_aboutproxy_create(alljoyn_busattachment bus,const char* busName,alljoyn_sessionid sessionId);

		/// <summary>
		/// Free an alljoyn_aboutproxy object.
		/// </summary>
		/// <param name="proxy">The alljoyn_aboutproxy to be freed</param>
		/// 
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern void alljoyn_aboutproxy_destroy(IntPtr proxy);
		// extern AJ_API void AJ_CALL alljoyn_aboutproxy_destroy(alljoyn_aboutproxy proxy);

		/// <summary>
		/// Get the ObjectDescription array for specified bus name.
		/// </summary>
		/// <param name="proxy">The alljoyn_aboutproxy object to get object description from</param>
		/// <param name="objectDesc">Description of busName's remote objects.</param><!-- out -->
		/// <returns>- ER_OK if successful.
		/// - ER_BUS_REPLY_IS_ERROR_MESSAGE on unknown failure.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_aboutproxy_getobjectdescription(IntPtr proxy, IntPtr objectDesc);
		// extern AJ_API QStatus AJ_CALL alljoyn_aboutproxy_getobjectdescription(alljoyn_aboutproxy proxy,alljoyn_msgarg objectDesc);

		/// <summary>
		/// Get the About data for specified bus name.
		/// </summary>
		/// <param name="proxy">The alljoyn_aboutproxy object to get the about data from</param>
		/// <param name="language">the language used to request the About data.</param>
		/// <param name="data">reference of About data that is filled by the function</param><!-- out -->
		/// <returns>- ER_OK if successful.
		/// - ER_LANGUAGE_NOT_SUPPORTED if the language specified is not supported
		/// - ER_BUS_REPLY_IS_ERROR_MESSAGE on unknown failure</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_aboutproxy_getaboutdata(IntPtr proxy, [MarshalAs(UnmanagedType.LPStr)]string language, IntPtr data);
		// extern AJ_API QStatus AJ_CALL alljoyn_aboutproxy_getaboutdata(alljoyn_aboutproxy proxy,const char* language,alljoyn_msgarg data);

		/// <summary>
		/// GetVersion get the About version
		/// </summary>
		/// <param name="proxy">The alljoyn_aboutproxy object to get the version from</param>
		/// <param name="version">of the service.</param><!-- out -->
		/// <returns>ER_OK on success</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_aboutproxy_getversion(IntPtr proxy, out UInt16 version);
		// extern AJ_API QStatus AJ_CALL alljoyn_aboutproxy_getversion(alljoyn_aboutproxy proxy,uint16_t* version);


    }
}