// Generated from BusObject.h

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
		/// <summary>
		/// Callback for property get method.
		/// </summary>
		/// <remarks>
		/// <para>Handle a bus request to read a property from this object.
		/// alljoyn_busobjects that implement properties should provide an implementation
		/// of this function.
		/// The default version simply returns ER_BUS_NO_SUCH_PROPERTY.
		/// </para>
		/// </remarks>
		/// <param name="context">context pointer passed in when creating a new alljoyn_busobject</param>
		/// <param name="ifcName">Identifies the interface that the property is defined on</param>
		/// <param name="propName">Identifies the property to get</param>
		/// <param name="val">Returns the property value. The type of this value is the actual valuetype.</param><!-- out -->
		/// <returns>#ER_BUS_NO_SUCH_PROPERTY (Should be changed to #ER_OK by user implementation of alljoyn_busobject_prop_get_ptrif the request results in successfully reading a property from the object.)</returns>
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate QStatus alljoyn_busobject_prop_get_ptr(IntPtr context, [MarshalAs(UnmanagedType.LPStr)]string ifcName, [MarshalAs(UnmanagedType.LPStr)]string propName, IntPtr val);
		// typedef QStatus (AJ_CALL * alljoyn_busobject_prop_get_ptr)(const void* context, const char* ifcName, const char* propName, alljoyn_msgarg val);
		// 

		/// <summary>
		/// Callback for property set method.
		/// </summary>
		/// <remarks>
		/// <para>Handle a bus attempt to write a property value to this object.
		/// alljoyn_busobjects that implement properties should provide an implementation
		/// of this function.
		/// This default version just replies with ER_BUS_NO_SUCH_PROPERTY
		/// </para>
		/// </remarks>
		/// <param name="context">context pointer passed in when creating a new alljoyn_busobject</param>
		/// <param name="ifcName">Identifies the interface that the property is defined on</param>
		/// <param name="propName">Identifies the property to set</param>
		/// <param name="val">The property value to set. The type of this value is the actual valuetype.</param>
		/// <returns>#ER_BUS_NO_SUCH_PROPERTY (Should be changed to #ER_OK by user implementation of alljoyn_busobject_prop_set_ptris the set request results in successfully changing the property.)</returns>
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate QStatus alljoyn_busobject_prop_set_ptr(IntPtr context, [MarshalAs(UnmanagedType.LPStr)]string ifcName, [MarshalAs(UnmanagedType.LPStr)]string propName, IntPtr val);
		// typedef QStatus (AJ_CALL * alljoyn_busobject_prop_set_ptr)(const void* context, const char* ifcName, const char* propName, alljoyn_msgarg val);
		// 

		/// <summary>
		/// Callback for ObjectRegistered and ObjectUnregistered
		/// </summary>
		/// <remarks>
		/// <para>ObjectRegistered is called by the bus when the alljoyn_busobject has been successfully registered
		/// ObjectUnregistered is called by the bus when the alljoyn_busobject has been successfully unregistered
		/// </para>
		/// </remarks>
		/// <param name="context">context pointer passed in when creating a new alljoyn_busobject</param>
		/// 
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void alljoyn_busobject_object_registration_ptr(IntPtr context);
		// typedef void (AJ_CALL * alljoyn_busobject_object_registration_ptr)(const void* context);
		// 

		/// <summary>
		/// a structure containing a collection of function pointers.
		/// These functions are call by AllJoyn in response to certain events and requests
		/// </summary>
		/// 
		[StructLayout(LayoutKind.Sequential)]
		internal partial class alljoyn_busobject_callbacks
		{
			public alljoyn_busobject_prop_get_ptr property_get;
			public alljoyn_busobject_prop_set_ptr property_set;
			public alljoyn_busobject_object_registration_ptr object_registered;
			public alljoyn_busobject_object_registration_ptr object_unregistered;
			//
			///**
			//* Handle a bus request to read a property from the alljoyn_busobject
			//*/
			//alljoyn_busobject_prop_get_ptr property_get;
			///**
			//* Handle a bus request to write a property value to the alljoyn_busobject
			//*/
			//alljoyn_busobject_prop_set_ptr property_set;
			///**
			//* Called by the message bus when the object has been successfully registered.
			//*
			//* The object can perform any initialization such as adding match rules at this time
			//*/
			//alljoyn_busobject_object_registration_ptr object_registered;
			///**
			//* Called by the message bus when the object has been successfully unregistered.
			//*/
			//alljoyn_busobject_object_registration_ptr object_unregistered;
			//
		}
		// typedef struct {
		// /**
		// * Handle a bus request to read a property from the alljoyn_busobject
		// */
		// alljoyn_busobject_prop_get_ptr property_get;
		// /**
		// * Handle a bus request to write a property value to the alljoyn_busobject
		// */
		// alljoyn_busobject_prop_set_ptr property_set;
		// /**
		// * Called by the message bus when the object has been successfully registered.
		// *
		// * The object can perform any initialization such as adding match rules at this time
		// */
		// alljoyn_busobject_object_registration_ptr object_registered;
		// /**
		// * Called by the message bus when the object has been successfully unregistered.
		// */
		// alljoyn_busobject_object_registration_ptr object_unregistered;
		// } alljoyn_busobject_callbacks;
		// 

		/// <summary>
		/// Type used to add mulitple methods at one time.
		/// </summary>
		/// 
		[StructLayout(LayoutKind.Sequential)]
		internal partial class alljoyn_busobject_methodentry
		{
			public alljoyn_interfacedescription_member member;
			public alljoyn_messagereceiver_methodhandler_ptr method_handler;
			//
			//const alljoyn_interfacedescription_member* member;          /**< Pointer to method's member */
			//alljoyn_messagereceiver_methodhandler_ptr method_handler;   /**< Method implementation */
			//
		}
		// typedef struct {
		// const alljoyn_interfacedescription_member* member;          /**< Pointer to method's member */
		// alljoyn_messagereceiver_methodhandler_ptr method_handler;   /**< Method implementation */
		// } alljoyn_busobject_methodentry;
		// 

//
    public partial class BusObject : AllJoynWrapper
    {
        internal BusObject(IntPtr handle) : base(handle) { }
		/// <summary>
		/// Create an %alljoyn_busobject.
		/// </summary>
		/// <param name="path">Object path for object.</param>
		/// <param name="isPlaceholder">Place-holder objects are created by the bus itself and serve onlyas parent objects (in the object path sense) to other objects.</param>
		/// <param name="callbacks_in">an alljoyn_busobject_callbacks struct containing pointer tocallback functions NULL if no callbacks busoject callback functions
		/// are needed.</param>
		/// <param name="context_in">a context pointer that can be used in the callback functions</param>
		/// <returns>allocated alljoyn_busobject</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern IntPtr alljoyn_busobject_create([MarshalAs(UnmanagedType.LPStr)]string path, Int32 isPlaceholder, alljoyn_busobject_callbacks callbacks_in, IntPtr context_in);
		// extern AJ_API alljoyn_busobject AJ_CALL alljoyn_busobject_create(const char* path, QCC_BOOL isPlaceholder,const alljoyn_busobject_callbacks* callbacks_in, const void* context_in);

		/// <summary>
		/// Destroy an alljoyn_busobject
		/// </summary>
		/// <param name="bus">Bus to destroy.</param>
		/// 
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern void alljoyn_busobject_destroy(IntPtr bus);
		// extern AJ_API void AJ_CALL alljoyn_busobject_destroy(alljoyn_busobject bus);

		/// <summary>
		/// Return the path for the object
		/// </summary>
		/// <param name="bus">alljoyn_busobject on which to get the path.</param>
		/// <returns>Object path</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern IntPtr alljoyn_busobject_getpath(IntPtr bus);
		// extern AJ_API const char* AJ_CALL alljoyn_busobject_getpath(alljoyn_busobject bus);

		/// <summary>
		/// Emit PropertiesChanged to signal the bus that this property has been updated
		/// </summary>
		/// <param name="bus">alljoyn_busobject with which to emit the signal</param>
		/// <param name="ifcName">The name of the interface</param>
		/// <param name="propName">The name of the property being changed</param>
		/// <param name="val">The new value of the property</param>
		/// <param name="id">ID of the session we broadcast the signal to (0 for all)</param>
		/// 
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern void alljoyn_busobject_emitpropertychanged(IntPtr bus, [MarshalAs(UnmanagedType.LPStr)]string ifcName, [MarshalAs(UnmanagedType.LPStr)]string propName, IntPtr val, IntPtr id);
		// extern AJ_API void AJ_CALL alljoyn_busobject_emitpropertychanged(alljoyn_busobject bus,const char* ifcName,const char* propName,alljoyn_msgarg val,alljoyn_sessionid id);

		/// <summary>
		/// Emit PropertiesChanged to signal the bus that this list of properties have been updated
		/// </summary>
		/// <param name="bus">alljoyn_busobject with which to emit the signal</param>
		/// <param name="ifcName">The name of the interface</param>
		/// <param name="propNames">The array of properties being changed</param>
		/// <param name="numProps">The size of the propNames array</param>
		/// <param name="id">ID of the session we broadcast the signal to (0 for all)</param>
		/// 
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern void alljoyn_busobject_emitpropertieschanged(IntPtr bus, [MarshalAs(UnmanagedType.LPStr)]string ifcName, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)]string[] propNames, UIntPtr numProps, IntPtr id);
		// extern AJ_API void AJ_CALL alljoyn_busobject_emitpropertieschanged(alljoyn_busobject bus,const char* ifcName,const char** propNames,size_t numProps,alljoyn_sessionid id);

		/// <summary>
		/// Get the name of this object.
		/// The name is the last component of the path.
		/// </summary>
		/// <remarks>
		/// <para>If the buffer is NULL or the bufferSz is 0, the length of the name + nul will be returned.
		/// </para>
		/// </remarks>
		/// <param name="bus">alljoyn_busobject on which to get the name.</param>
		/// <param name="buffer">A buffer into which to copy the name.</param>
		/// <param name="bufferSz">The size of the buffer provided.</param>
		/// <returns>The size of the name string, if the returned value is > bufferSz, the entire name was not copied into buffer.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern UIntPtr alljoyn_busobject_getname(IntPtr bus, [MarshalAs(UnmanagedType.LPStr)]string buffer, UIntPtr bufferSz);
		// extern AJ_API size_t AJ_CALL alljoyn_busobject_getname(alljoyn_busobject bus, char* buffer, size_t bufferSz);

		/// <summary>
		/// Add an unnanounced interface to this object. If the interface has properties this will also add the
		/// standard property access interface. An interface must be added before its method handlers can be
		/// added. Note that the Peer interface (org.freedesktop.DBus.peer) is implicit on all objects and
		/// cannot be explicitly added, and the Properties interface (org.freedesktop,DBus.Properties) is
		/// automatically added when needed and cannot be explicitly added.
		/// </summary>
		/// <remarks>
		/// <para>Once an object is registered, it should not add any additional interfaces. Doing so would
		/// confuse remote objects that may have already introspected this object.
		/// </para>
		/// </remarks>
		/// <param name="bus">The bus on which to add the interface</param>
		/// <param name="iface">The interface to add</param>
		/// <returns>- #ER_OK if the interface was successfully added.
		/// - #ER_BUS_IFACE_ALREADY_EXISTS if the interface already exists.
		/// - An error status otherwise</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_busobject_addinterface(IntPtr bus, IntPtr iface);
		// extern AJ_API QStatus AJ_CALL alljoyn_busobject_addinterface(alljoyn_busobject bus,const alljoyn_interfacedescription iface);

		/// <summary>
		/// Add a method handler to this object. The interface for the method handler must have already
		/// been added by calling AddInterface().
		/// </summary>
		/// <param name="bus">The alljoyn_busobject onto which the method handler will be added.</param>
		/// <param name="member">Interface member implemented by handler.</param>
		/// <param name="handler">Method handler.</param>
		/// <param name="context">An optional context. This is mainly intended for implementing languagebindings and should normally be NULL.</param>
		/// <returns>- #ER_OK if the method handler was added.
		/// - An error status otherwise</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_busobject_addmethodhandler(IntPtr bus, alljoyn_interfacedescription_member member, alljoyn_messagereceiver_methodhandler_ptr handler, IntPtr context);
		// extern AJ_API QStatus AJ_CALL alljoyn_busobject_addmethodhandler(alljoyn_busobject bus,const alljoyn_interfacedescription_member member,alljoyn_messagereceiver_methodhandler_ptr handler,void* context);

		/// <summary>
		/// Add a set of method handers at once.
		/// </summary>
		/// <param name="bus">The bus on which to add method handlers.</param>
		/// <param name="entries">Array of alljoyn_busobject_methodentry.</param>
		/// <param name="numEntries">Number of entries in array.</param>
		/// <returns>- #ER_OK if all the methods were added
		/// - #ER_BUS_NO_SUCH_INTERFACE is method can not be added because interface does not exist.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_busobject_addmethodhandlers(IntPtr bus, IntPtr entries, UIntPtr numEntries);
		// extern AJ_API QStatus AJ_CALL alljoyn_busobject_addmethodhandlers(alljoyn_busobject bus,const alljoyn_busobject_methodentry* entries,size_t numEntries);

		/// <summary>
		/// Reply to a method call
		/// </summary>
		/// <param name="bus">The bus on which to reply.</param>
		/// <param name="msg">The method call message</param>
		/// <param name="args">The reply arguments (can be NULL)</param>
		/// <param name="numArgs">The number of arguments</param>
		/// <returns>- #ER_OK if successful
		/// - An error status otherwise</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_busobject_methodreply_args(IntPtr bus, IntPtr msg, IntPtr args, UIntPtr numArgs);
		// extern AJ_API QStatus AJ_CALL alljoyn_busobject_methodreply_args(alljoyn_busobject bus, alljoyn_message msg,const alljoyn_msgarg args, size_t numArgs);

		/// <summary>
		/// Reply to a method call with an error message
		/// </summary>
		/// <param name="bus">The bus on which to reply.</param>
		/// <param name="msg">The method call message</param>
		/// <param name="error">The name of the error</param>
		/// <param name="errorMessage">An error message string</param>
		/// <returns>- #ER_OK if successful
		/// - An error status otherwise</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_busobject_methodreply_err(IntPtr bus, IntPtr msg, [MarshalAs(UnmanagedType.LPStr)]string error, [MarshalAs(UnmanagedType.LPStr)]string errorMessage);
		// extern AJ_API QStatus AJ_CALL alljoyn_busobject_methodreply_err(alljoyn_busobject bus, alljoyn_message msg,const char* error, const char* errorMessage);

		/// <summary>
		/// Reply to a method call with an error message
		/// </summary>
		/// <param name="bus">The bus on which to reply.</param>
		/// <param name="msg">The method call message</param>
		/// <param name="status">The status code for the error</param>
		/// <returns>- #ER_OK if successful
		/// - An error status otherwise</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_busobject_methodreply_status(IntPtr bus, IntPtr msg, QStatus status);
		// extern AJ_API QStatus AJ_CALL alljoyn_busobject_methodreply_status(alljoyn_busobject bus, alljoyn_message msg, QStatus status);

		/// <summary>
		/// Get a reference to the underlying alljoyn_busattachment
		/// </summary>
		/// <remarks>
		/// <para>There is no need to call alljoyn_busattachment_create or
		/// alljoyn_busattachment_destory for the return value.
		/// This is handled in the code that registered the alljoyn_busobject with
		/// the alljoyn_busattachment.
		/// </para>
		/// </remarks>
		/// <param name="bus">The alljoyn_busobject to obtain the alljoyn_busattachment from</param>
		/// <returns>a reference to the alljoyn_busattachment</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern IntPtr alljoyn_busobject_getbusattachment(IntPtr bus);
		// extern AJ_API const alljoyn_busattachment AJ_CALL alljoyn_busobject_getbusattachment(alljoyn_busobject bus);

		/// <summary>
		/// Send a signal.
		/// </summary>
		/// <param name="bus">The bus used to send the signal</param>
		/// <param name="destination">The unique or well-known bus name or the signal recipient (NULL for broadcast signals)</param>
		/// <param name="sessionId">A unique SessionId for this AllJoyn session instance. Use ALLJOYN_SESSION_ID_ALL_HOSTEDto emit the signal on all sessions hosted by this bus object's bus attachment.
		/// Use 0 for broadcast and sessionless signals.</param>
		/// <param name="signal">Interface member of signal being emitted.</param>
		/// <param name="args">The arguments for the signal (can be NULL)</param>
		/// <param name="numArgs">The number of arguments</param>
		/// <param name="timeToLive">If non-zero this specifies the useful lifetime for this signal.For sessionless signals the units are seconds.
		/// For all other signals the units are milliseconds.
		/// If delivery of the signal is delayed beyond the timeToLive due to
		/// network congestion or other factors the signal may be discarded. There is
		/// no guarantee that expired signals will not still be delivered.</param>
		/// <param name="flags">Logical OR of the message flags for this signals. The following flags apply to signals:- If #ALLJOYN_MESSAGE_FLAG_GLOBAL_BROADCAST is set broadcast signal (null destination) will be forwarded across bus-to-bus connections.
		/// - If #ALLJOYN_MESSAGE_FLAG_ENCRYPTED is set the message is authenticated and the payload if any is encrypted.
		/// - IF #ALLJOYN_MESSAGE_FLAG_SESSIONLESS is set the message will be sent using the sessionless signal mechanism.</param>
		/// <param name="msg">If non-null, the sent signal message is returned to the caller.</param><!-- out -->
		/// <returns>- #ER_OK if successful
		/// - An error status otherwise</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_busobject_signal(IntPtr bus, [MarshalAs(UnmanagedType.LPStr)]string destination, IntPtr sessionId, alljoyn_interfacedescription_member signal, IntPtr args, UIntPtr numArgs, UInt16 timeToLive, byte flags, IntPtr msg);
		// extern AJ_API QStatus AJ_CALL alljoyn_busobject_signal(alljoyn_busobject bus,const char* destination,alljoyn_sessionid sessionId,const alljoyn_interfacedescription_member signal,const alljoyn_msgarg args,size_t numArgs,uint16_t timeToLive,uint8_t flags,alljoyn_message msg);

		/// <summary>
		/// Remove sessionless message sent from this object from local router's
		/// store/forward cache.
		/// </summary>
		/// <param name="bus">The bus used to send cancel the sessionless message</param>
		/// <param name="serialNumber">Serial number of previously sent sessionless signal.</param>
		/// <returns>ER_OK if successful.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_busobject_cancelsessionlessmessage_serial(IntPtr bus, UInt32 serialNumber);
		// extern AJ_API QStatus AJ_CALL alljoyn_busobject_cancelsessionlessmessage_serial(alljoyn_busobject bus, uint32_t serialNumber);

		/// <summary>
		/// Remove sessionless message sent from this object from local router's
		/// store/forward cache.
		/// </summary>
		/// <param name="bus">The bus used to send cancel the sessionless message</param>
		/// <param name="msg">Message to be removed.</param>
		/// <returns>ER_OK if successful.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_busobject_cancelsessionlessmessage(IntPtr bus, IntPtr msg);
		// extern AJ_API QStatus AJ_CALL alljoyn_busobject_cancelsessionlessmessage(alljoyn_busobject bus, const alljoyn_message msg);

		/// <summary>
		/// Indicates if this object is secure.
		/// </summary>
		/// <param name="bus">The busobject we want to check for security</param>
		/// <returns>Return QCC_TRUE if authentication is required to emit signals orcall methods on this object.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern Int32 alljoyn_busobject_issecure(IntPtr bus);
		// extern AJ_API QCC_BOOL AJ_CALL alljoyn_busobject_issecure(alljoyn_busobject bus);

		/// <summary>
		/// Get a list of the interfaces that are added to this alljoyn_busobject that will be announced.
		/// </summary>
		/// <param name="bus">The bus which contains the interfaces</param>
		/// <param name="interfaces">the array of interface names</param>
		/// <param name="numInterfaces">the number of interface names</param>
		/// <returns>The total number of interfaces found that are announced.  If this number
		/// is larger than `numInterfaces` then only `numInterfaces` will be returned.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern UIntPtr alljoyn_busobject_getannouncedinterfacenames(IntPtr bus, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)]string[] interfaces, UIntPtr numInterfaces);
		// extern AJ_API size_t AJ_CALL alljoyn_busobject_getannouncedinterfacenames(alljoyn_busobject bus,const char** interfaces,size_t numInterfaces);

		/// <summary>
		/// Change the announce flag for an already added interface. Changes in the
		/// announce flag are not visible to other devices till Announce is called.
		/// </summary>
		/// <param name="bus">The bus which contains the interface</param>
		/// <param name="iface">alljoyn_interfacedescription for the interface to setthe announce flag for</param>
		/// <param name="isAnnounced">This interface should be part of the Announce signalUNANNOUNCED - this interface will not be part of the Announce signal
		/// ANNOUNCED   - this interface will be part of the Announce signal</param>
		/// <returns>- #ER_OK if successful
		/// - #ER_BUS_OBJECT_NO_SUCH_INTERFACE if the interface is not part of the bus object.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_busobject_setannounceflag(IntPtr bus, IntPtr iface, alljoyn_about_announceflag isAnnounced);
		// extern AJ_API QStatus AJ_CALL alljoyn_busobject_setannounceflag(alljoyn_busobject bus,const alljoyn_interfacedescription iface,alljoyn_about_announceflag isAnnounced);

		/// <summary>
		/// Add an announced interface to this object. If the interface has properties this will also add the
		/// standard property access interface. An interface must be added before its method handlers can be
		/// added. Note that the Peer interface (org.freedesktop.DBus.peer) is implicit on all objects and
		/// cannot be explicitly added, and the Properties interface (org.freedesktop,DBus.Properties) is
		/// automatically added when needed and cannot be explicitly added.
		/// </summary>
		/// <remarks>
		/// <para>Once an object is registered, it should not add any additional interfaces. Doing so would
		/// confuse remote objects that may have already introspected this object.
		/// </para>
		/// </remarks>
		/// <param name="bus">The bus on which to add the interface</param>
		/// <param name="iface">The interface to add</param>
		/// <returns>- #ER_OK if the interface was successfully added.
		/// - #ER_BUS_IFACE_ALREADY_EXISTS if the interface already exists.
		/// - An error status otherwise</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_busobject_addinterface_announced(IntPtr bus, IntPtr iface);
        // extern AJ_API QStatus AJ_CALL alljoyn_busobject_addinterface_announced(alljoyn_busobject bus,const alljoyn_interfacedescription iface);


    }
}