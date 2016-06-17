// Generated from InterfaceDescription.h

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
		/// The interface security policy can be inherit, required, or off. If security is
		/// required on an interface, methods on that interface can only be called by an authenticated peer
		/// and signals emitted from that interfaces can only be received by an authenticated peer. If
		/// security is not specified for an interface the interface inherits the security of the objects
		/// that implement it.  If security is not applicable (off) to an interface, authentication is never
		/// required even when implemented by a secure object. For example, security does not apply to
		/// the Introspection interface otherwise secure objects would not be introspectable.
		/// </summary>
		/// 
		internal enum alljoyn_interfacedescription_securitypolicy
		{
		
		AJ_IFC_SECURITY_INHERIT,       /**< Inherit the security of the object that implements the interface */
		AJ_IFC_SECURITY_REQUIRED,      /**< Security is required for an interface */
		AJ_IFC_SECURITY_OFF            /**< Security does not apply to this interface */
		
		}
		// typedef enum {
		// AJ_IFC_SECURITY_INHERIT,       /**< Inherit the security of the object that implements the interface */
		// AJ_IFC_SECURITY_REQUIRED,      /**< Security is required for an interface */
		// AJ_IFC_SECURITY_OFF            /**< Security does not apply to this interface */
		// } alljoyn_interfacedescription_securitypolicy;
		// 

		/// <summary>
		/// Structure representing the member to be added to the Interface
		/// </summary>
		/// 
		[StructLayout(LayoutKind.Sequential)]
		internal partial struct alljoyn_interfacedescription_member
		{
			public IntPtr iface;
			public alljoyn_messagetype memberType;
            public IntPtr name;
			public IntPtr signature;
			public IntPtr returnSignature;
			public IntPtr argNames;
			//[MarshalAs(UnmanagedType.LPStr)] public string name;
			//[MarshalAs(UnmanagedType.LPStr)] public string signature;
			//[MarshalAs(UnmanagedType.LPStr)] public string returnSignature;
			//[MarshalAs(UnmanagedType.LPStr)] public string argNames;
			public IntPtr internal_member;
			//
			//alljoyn_interfacedescription iface;         /**< Interface that this member belongs to */
			//alljoyn_messagetype memberType;             /**< %Member type */
			//const char* name;                           /**< %Member name */
			//const char* signature;                      /**< Method call IN arguments (NULL for signals) */
			//const char* returnSignature;                /**< Signal or method call OUT arguments */
			//const char* argNames;                       /**< Comma separated list of argument names - can be NULL */
			//
			//const void* internal_member;                /**< For internal use only */
			//
		}
		// typedef struct {
		// alljoyn_interfacedescription iface;         /**< Interface that this member belongs to */
		// alljoyn_messagetype memberType;             /**< %Member type */
		// const char* name;                           /**< %Member name */
		// const char* signature;                      /**< Method call IN arguments (NULL for signals) */
		// const char* returnSignature;                /**< Signal or method call OUT arguments */
		// const char* argNames;                       /**< Comma separated list of argument names - can be NULL */
		// 
		// const void* internal_member;                /**< For internal use only */
		// } alljoyn_interfacedescription_member;
		// 

		/// <summary>
		/// Structure representing properties of the Interface
		/// </summary>
		/// 
		[StructLayout(LayoutKind.Sequential)]
		internal partial class alljoyn_interfacedescription_property
		{
			[MarshalAs(UnmanagedType.LPStr)] public string name;
			[MarshalAs(UnmanagedType.LPStr)] public string signature;
			public byte access;
			public IntPtr internal_property;
			//
			//const char* name;               /**< %Property name */
			//const char* signature;          /**< %Property type */
			//uint8_t access;                  /**< Access is #ALLJOYN_PROP_ACCESS_READ, #ALLJOYN_PROP_ACCESS_WRITE, or #ALLJOYN_PROP_ACCESS_RW */
			//
			//const void* internal_property;  /**< For internal use only */
			//
		}
		// typedef struct {
		// const char* name;               /**< %Property name */
		// const char* signature;          /**< %Property type */
		// uint8_t access;                  /**< Access is #ALLJOYN_PROP_ACCESS_READ, #ALLJOYN_PROP_ACCESS_WRITE, or #ALLJOYN_PROP_ACCESS_RW */
		// 
		// const void* internal_property;  /**< For internal use only */
		// } alljoyn_interfacedescription_property;
		// 

//
    public partial class InterfaceDescription : AllJoynWrapper
    {
        internal InterfaceDescription(IntPtr handle) : base(handle) { }
		/// <summary>
		/// find out the amount of annotations the alljoyn_interfacedescription_member has
		/// </summary>
		/// <remarks>
		/// <para>The number of the annotation is only valid as long as no annotations have
		/// been removed or added to the interface.  For this reason this function should
		/// only be used after calling alljoyn_interfacedescription_activate.
		/// </para>
		/// </remarks>
		/// <param name="member">The alljoyn interfacedescription member that we want theannotations count from</param>
		/// <returns>the number of annotations</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern UIntPtr alljoyn_interfacedescription_member_getannotationscount(alljoyn_interfacedescription_member member);
		// extern AJ_API size_t AJ_CALL alljoyn_interfacedescription_member_getannotationscount(alljoyn_interfacedescription_member member);

		/// <summary>
		/// Obtain the name and value for the annotation index.
		/// The order of the annotation is only valid as long as no new annotations are
		/// removed or added to the interface.  For this reason this function should
		/// only be used after calling alljoyn_interfacedescription_activate.
		/// </summary>
		/// <param name="member">the alljoyn interfacedescription member that we want to read annotations from</param>
		/// <param name="index">the index of the annotation of interest</param>
		/// <param name="name">the name of the annotation</param><!-- out -->
		/// <param name="name_size">the size of the name string if name==NULL this will return the size of the name string plus nul character</param><!-- in, out -->
		/// <param name="value">the value of the annotation</param><!-- out -->
		/// <param name="value_size">the size of the value string if value == NULL this will return the size of the value string plus nul character</param><!-- in, out -->
		/// 
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern void alljoyn_interfacedescription_member_getannotationatindex(alljoyn_interfacedescription_member member, UIntPtr index, sbyte name, [In, Out]UIntPtr name_size, sbyte value, [In, Out]UIntPtr value_size);
		// extern AJ_API void AJ_CALL alljoyn_interfacedescription_member_getannotationatindex(alljoyn_interfacedescription_member member,size_t index,char* name, size_t* name_size,char* value, size_t* value_size);

		/// <summary>
		/// Get this member's annotation value return the size of the value string if
		/// name is NULL.
		/// </summary>
		/// <param name="member">The AllJoyn alljoyn_interfacedescription member that we want the annotation from</param>
		/// <param name="name">Name of the annotation to look for</param>
		/// <param name="value">Value to compare with</param><!-- out -->
		/// <param name="value_size">size of the value string if value == NULL it will return the size of the value string plus nul character</param><!-- in, out -->
		/// <returns>true iff annotations[name] == value</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern Int32 alljoyn_interfacedescription_member_getannotation(alljoyn_interfacedescription_member member, [MarshalAs(UnmanagedType.LPStr)]string name, sbyte value, [In, Out]UIntPtr value_size);
		// extern AJ_API QCC_BOOL AJ_CALL alljoyn_interfacedescription_member_getannotation(alljoyn_interfacedescription_member member, const char* name, char* value, size_t* value_size);

		/// <summary>
		/// find out the amount of annotations the alljoyn_interfacedescription_member has
		/// </summary>
		/// <remarks>
		/// <para>The number of the annotation is only valid as long as no annotations have
		/// been removed or added to the interface.  For this reason this function should
		/// only be used after calling alljoyn_interfacedescription_activate.
		/// </para>
		/// </remarks>
		/// <param name="property">The alljoyn interfacedescription property that we want theannotations count from</param>
		/// <returns>the number of annotations</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern UIntPtr alljoyn_interfacedescription_property_getannotationscount(alljoyn_interfacedescription_property property);
		// extern AJ_API size_t AJ_CALL alljoyn_interfacedescription_property_getannotationscount(alljoyn_interfacedescription_property property);

		/// <summary>
		/// Obtain the name and value for the annotation index.
		/// The order of the annotation is only valid as long as no new annotations are
		/// removed or added to the interface.  For this reason this function should
		/// only be used after calling alljoyn_interfacedescription_activate.
		/// </summary>
		/// <param name="property">the alljoyn interfacedescription property that we want to read annotations from</param>
		/// <param name="index">the index of the annotation of interest</param>
		/// <param name="name">the name of the annotation</param><!-- out -->
		/// <param name="name_size">the size of the name string if name==NULL this will return the size of the name string plus nul character</param><!-- in, out -->
		/// <param name="value">the value of the annotation</param><!-- out -->
		/// <param name="value_size">the size of the value string if value == NULL this will return the size of the value string plus nul character</param><!-- in, out -->
		/// 
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern void alljoyn_interfacedescription_property_getannotationatindex(alljoyn_interfacedescription_property property, UIntPtr index, sbyte name, [In, Out]UIntPtr name_size, sbyte value, [In, Out]UIntPtr value_size);
		// extern AJ_API void AJ_CALL alljoyn_interfacedescription_property_getannotationatindex(alljoyn_interfacedescription_property property,size_t index,char* name, size_t* name_size,char* value, size_t* value_size);

		/// <summary>
		/// Get this member's annotation value return the size of the value string if
		/// name is NULL.
		/// </summary>
		/// <param name="property">The AllJoyn alljoyn_interfacedescription property that we want the annotation from.</param>
		/// <param name="name">Name of the annotation to look for</param>
		/// <param name="value">Value to compare with</param><!-- out -->
		/// <param name="value_size">size of the value string if value == NULL it will return the size of the value string plus nul character</param><!-- in, out -->
		/// <returns>true iff annotations[name] == value</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern Int32 alljoyn_interfacedescription_property_getannotation(alljoyn_interfacedescription_property property, [MarshalAs(UnmanagedType.LPStr)]string name, sbyte value, [In, Out]UIntPtr value_size);
		// extern AJ_API QCC_BOOL AJ_CALL alljoyn_interfacedescription_property_getannotation(alljoyn_interfacedescription_property property, const char* name, char* value, size_t* value_size);

		/// <summary>
		/// Activate this interface. An interface must be activated before it can be used. Activating an
		/// interface locks the interface so that is can no longer be modified.
		/// </summary>
		/// <param name="iface">alljoyn_interfacedescription to activate.</param>
		/// 
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern void alljoyn_interfacedescription_activate(IntPtr iface);
		// extern AJ_API void AJ_CALL alljoyn_interfacedescription_activate(alljoyn_interfacedescription iface);

		/// <summary>
		/// Add an annotation to the interface.
		/// </summary>
		/// <param name="iface">Interface onto which the annotation will be added</param>
		/// <param name="name">Name of annotation.</param>
		/// <param name="value">Value of the annotation</param>
		/// <returns>- #ER_OK if successful.
		/// - #ER_BUS_PROPERTY_ALREADY_EXISTS if the property can not be added
		/// because it already exists.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_interfacedescription_addannotation(IntPtr iface, [MarshalAs(UnmanagedType.LPStr)]string name, [MarshalAs(UnmanagedType.LPStr)]string value);
		// extern AJ_API QStatus AJ_CALL alljoyn_interfacedescription_addannotation(alljoyn_interfacedescription iface, const char* name, const char* value);

		/// <summary>
		/// Lookup an interface annotation
		/// </summary>
		/// <param name="iface">Interface on which to lookup the member</param>
		/// <param name="name">Name of the annotation to lookup</param>
		/// <param name="value">The value of the annotation</param><!-- out -->
		/// <param name="value_size">return the size of the string if value == NULL plus nul character orspecifies the max size of value if value != NULL.</param><!-- in, out -->
		/// <returns>QC_FALSE if annotation does not exist, QC_TRUE otherwise.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern Int32 alljoyn_interfacedescription_getannotation(IntPtr iface, [MarshalAs(UnmanagedType.LPStr)]string name, sbyte value, [In, Out]UIntPtr value_size);
		// extern AJ_API QCC_BOOL AJ_CALL alljoyn_interfacedescription_getannotation(alljoyn_interfacedescription iface, const char* name, char* value, size_t* value_size);

		/// <summary>
		/// find out the amount of annotations the alljoyn_interfacedescription has
		/// </summary>
		/// <remarks>
		/// <para>The number of the annotation is only valid as long as no annotations have
		/// been removed or added to the interface.  For this reason this function should
		/// only be used after calling alljoyn_interfacedescription_activate.
		/// </para>
		/// </remarks>
		/// <param name="iface">The alljoyn_interfacedescription that we want the annotations count from</param>
		/// <returns>the number of annotations</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern UIntPtr alljoyn_interfacedescription_getannotationscount(IntPtr iface);
		// extern AJ_API size_t AJ_CALL alljoyn_interfacedescription_getannotationscount(alljoyn_interfacedescription iface);

		/// <summary>
		/// Obtain the name and value for the annotation index.
		/// The order of the annotation is only valid as long as no new annotations are
		/// removed or added to the interface.  For this reason this function should
		/// only be used after calling alljoyn_interfacedescription_activate.
		/// </summary>
		/// <param name="iface">the alljoyn interfacedescription that we want to read annotations from</param>
		/// <param name="index">the index of the annotation of interest</param>
		/// <param name="name">the name of the annotation</param><!-- out -->
		/// <param name="name_size">the size of the name string if name==NULL this will return the size of the name string plus nul character</param><!-- in, out -->
		/// <param name="value">the value of the annotation</param><!-- out -->
		/// <param name="value_size">the size of the value string if value == NULL this will return the size of the value string plus nul character</param><!-- in, out -->
		/// 
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern void alljoyn_interfacedescription_getannotationatindex(IntPtr iface, UIntPtr index, sbyte name, [In, Out]UIntPtr name_size, sbyte value, [In, Out]UIntPtr value_size);
		// extern AJ_API void AJ_CALL alljoyn_interfacedescription_getannotationatindex(alljoyn_interfacedescription iface,size_t index,char* name, size_t* name_size,char* value, size_t* value_size);

		/// <summary>
		/// Lookup a member description by name
		/// </summary>
		/// <param name="iface">Interface on which to lookup the member</param>
		/// <param name="name">Name of the member to lookup</param>
		/// <param name="member">The description of the member</param><!-- out -->
		/// <returns>QCC_FALSE if member does not exist, QCC_TRUE otherwise.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern Int32 alljoyn_interfacedescription_getmember(IntPtr iface, [MarshalAs(UnmanagedType.LPStr)]string name, ref alljoyn_interfacedescription_member member);
		// extern AJ_API QCC_BOOL AJ_CALL alljoyn_interfacedescription_getmember(const alljoyn_interfacedescription iface, const char* name,alljoyn_interfacedescription_member* member);

		/// <summary>
		/// Add a member to the interface.
		/// </summary>
		/// <param name="iface">Interface on which to add the member.</param>
		/// <param name="type">Message type.</param>
		/// <param name="name">Name of member.</param>
		/// <param name="inputSig">Signature of input parameters or NULL for none.</param>
		/// <param name="outSig">Signature of output parameters or NULL for none.</param>
		/// <param name="argNames">Comma separated list of input and then output arg names used in annotation XML.</param>
		/// <param name="annotation">Annotation flags.</param>
		/// <returns>- #ER_OK if successful
		/// - #ER_BUS_MEMBER_ALREADY_EXISTS if member already exists</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_interfacedescription_addmember(IntPtr iface, alljoyn_messagetype type, [MarshalAs(UnmanagedType.LPStr)]string name, [MarshalAs(UnmanagedType.LPStr)]string inputSig, [MarshalAs(UnmanagedType.LPStr)]string outSig, [MarshalAs(UnmanagedType.LPStr)]string argNames, byte annotation);
		// extern AJ_API QStatus AJ_CALL alljoyn_interfacedescription_addmember(alljoyn_interfacedescription iface, alljoyn_messagetype type,const char* name, const char* inputSig, const char* outSig,const char* argNames, uint8_t annotation);

		/// <summary>
		/// Add an annotation to a member
		/// </summary>
		/// <param name="iface">Interface on which to add the member.</param>
		/// <param name="member">Name of member.</param>
		/// <param name="name">Name of annotation</param>
		/// <param name="value">Value for the annotation</param>
		/// <returns>- #ER_OK if successful
		/// - #ER_BUS_MEMBER_ALREADY_EXISTS if member already exists</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_interfacedescription_addmemberannotation(IntPtr iface, [MarshalAs(UnmanagedType.LPStr)]string member, [MarshalAs(UnmanagedType.LPStr)]string name, [MarshalAs(UnmanagedType.LPStr)]string value);
		// extern AJ_API QStatus AJ_CALL alljoyn_interfacedescription_addmemberannotation(alljoyn_interfacedescription iface,const char* member,const char* name,const char* value);

		/// <summary>
		/// Get all the members.
		/// </summary>
		/// <param name="iface">The interface from which to get all members.</param>
		/// <param name="members">A pointer to a Member array to receive the members. Can be NULL inwhich case no members are returned and the return value gives the number
		/// of members available.</param>
		/// <param name="numMembers">The size of the Member array. If this value is smaller than the totalnumber of members only numMembers will be returned.</param>
		/// <returns>The number of members returned or the total number of members if members is NULL.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern UIntPtr alljoyn_interfacedescription_getmembers(IntPtr iface, alljoyn_interfacedescription_member members, UIntPtr numMembers);
		// extern AJ_API size_t AJ_CALL alljoyn_interfacedescription_getmembers(const alljoyn_interfacedescription iface,alljoyn_interfacedescription_member* members,size_t numMembers);

		/// <summary>
		/// Check for existence of a member. Optionally check the signature also.
		/// </summary>
		/// <param name="iface">Interface to query for a member.</param>
		/// <param name="name">Name of the member to lookup</param>
		/// <param name="inSig">Input parameter signature of the member to lookup</param>
		/// <param name="outSig">Output parameter signature of the member to lookup (leave NULL for signals)</param>
		/// <returns>QCC_TRUE if the member name exists.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern Int32 alljoyn_interfacedescription_hasmember(IntPtr iface, [MarshalAs(UnmanagedType.LPStr)]string name, [MarshalAs(UnmanagedType.LPStr)]string inSig, [MarshalAs(UnmanagedType.LPStr)]string outSig);
		// extern AJ_API QCC_BOOL AJ_CALL alljoyn_interfacedescription_hasmember(alljoyn_interfacedescription iface,const char* name, const char* inSig,const char* outSig);

		/// <summary>
		/// Add a method call member to the interface.
		/// </summary>
		/// <param name="iface">Interface on which to add the method member.</param>
		/// <param name="name">Name of method call member.</param>
		/// <param name="inputSig">Signature of input parameters or NULL for none.</param>
		/// <param name="outSig">Signature of output parameters or NULL for none.</param>
		/// <param name="argNames">Comma separated list of input and then output arg names used in annotation XML.</param>
		/// <param name="annotation">Annotation flags. Default value 0.</param>
		/// <param name="accessPerms">Access permission requirements on this call. Default value 0.</param>
		/// <returns>- #ER_OK if successful
		/// - #ER_BUS_MEMBER_ALREADY_EXISTS if member already exists</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_interfacedescription_addmethod(IntPtr iface, [MarshalAs(UnmanagedType.LPStr)]string name, [MarshalAs(UnmanagedType.LPStr)]string inputSig, [MarshalAs(UnmanagedType.LPStr)]string outSig, [MarshalAs(UnmanagedType.LPStr)]string argNames, byte annotation, [MarshalAs(UnmanagedType.LPStr)]string accessPerms);
		// extern AJ_API QStatus AJ_CALL alljoyn_interfacedescription_addmethod(alljoyn_interfacedescription iface, const char* name, const char* inputSig, const char* outSig, const char* argNames, uint8_t annotation, const char* accessPerms);

		/// <summary>
		/// Lookup a member method description by name
		/// </summary>
		/// <param name="iface">Interface on which to lookup the method.</param>
		/// <param name="name">Name of the method to lookup</param>
		/// <param name="member">The description of the member</param><!-- out -->
		/// <returns>- Pointer to member.
		/// - NULL if does not exist.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern Int32 alljoyn_interfacedescription_getmethod(IntPtr iface, [MarshalAs(UnmanagedType.LPStr)]string name, alljoyn_interfacedescription_member member);
		// extern AJ_API QCC_BOOL AJ_CALL alljoyn_interfacedescription_getmethod(alljoyn_interfacedescription iface, const char* name, alljoyn_interfacedescription_member* member);

		/// <summary>
		/// Add a signal member to the interface.
		/// </summary>
		/// <param name="iface">Interface on which to add the signal member.</param>
		/// <param name="name">Name of method call member.</param>
		/// <param name="sig">Signature of parameters or NULL for none.</param>
		/// <param name="argNames">Comma separated list of arg names used in annotation XML.</param>
		/// <param name="annotation">Annotation flags. Default value 0.</param>
		/// <param name="accessPerms">Access permission requirements on this call. Default value 0.</param>
		/// <returns>- #ER_OK if successful
		/// - #ER_BUS_MEMBER_ALREADY_EXISTS if member already exists</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_interfacedescription_addsignal(IntPtr iface, [MarshalAs(UnmanagedType.LPStr)]string name, [MarshalAs(UnmanagedType.LPStr)]string sig, [MarshalAs(UnmanagedType.LPStr)]string argNames, byte annotation, [MarshalAs(UnmanagedType.LPStr)]string accessPerms);
		// extern AJ_API QStatus AJ_CALL alljoyn_interfacedescription_addsignal(alljoyn_interfacedescription iface, const char* name, const char* sig, const char* argNames, uint8_t annotation, const char* accessPerms);

		/// <summary>
		/// Lookup a member signal description by name
		/// </summary>
		/// <param name="iface">Interface to query for signal</param>
		/// <param name="name">Name of the signal to lookup</param>
		/// <param name="member">return a pointer to the signal member or NULL if thesignal does not exist.</param><!-- out -->
		/// <returns>QCC_TRUE is the signal was found QCC_FALSE otherwise</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern Int32 alljoyn_interfacedescription_getsignal(IntPtr iface, [MarshalAs(UnmanagedType.LPStr)]string name, alljoyn_interfacedescription_member member);
		// extern AJ_API QCC_BOOL AJ_CALL alljoyn_interfacedescription_getsignal(alljoyn_interfacedescription iface, const char* name, alljoyn_interfacedescription_member* member);

		/// <summary>
		/// Lookup a property description by name
		/// </summary>
		/// <param name="iface">Interface to query for a property.</param>
		/// <param name="name">Name of the property to lookup</param>
		/// <param name="property">The description of the property</param>
		/// <returns>QCC_TRUE if the property was found, QCC_FALSE otherwise</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern Int32 alljoyn_interfacedescription_getproperty(IntPtr iface, [MarshalAs(UnmanagedType.LPStr)]string name, alljoyn_interfacedescription_property property);
		// extern AJ_API QCC_BOOL AJ_CALL alljoyn_interfacedescription_getproperty(const alljoyn_interfacedescription iface, const char* name,alljoyn_interfacedescription_property* property);

		/// <summary>
		/// Get all the properties.
		/// </summary>
		/// <param name="iface">Interface to query for properties.</param>
		/// <param name="props">A pointer to a Property array to receive the properties. Can be NULL inwhich case no properties are returned and the return value gives the number
		/// of properties available.</param>
		/// <param name="numProps">The size of the Property array. If this value is smaller than the totalnumber of properties only numProperties will be returned.</param>
		/// <returns>The number of properties returned or the total number of properties if props is NULL.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern UIntPtr alljoyn_interfacedescription_getproperties(IntPtr iface, alljoyn_interfacedescription_property props, UIntPtr numProps);
		// extern AJ_API size_t AJ_CALL alljoyn_interfacedescription_getproperties(const alljoyn_interfacedescription iface,alljoyn_interfacedescription_property* props,size_t numProps);

		/// <summary>
		/// Add a property to the interface.
		/// </summary>
		/// <param name="iface">Interface on which to add the property.</param>
		/// <param name="name">Name of property.</param>
		/// <param name="signature">Property type.</param>
		/// <param name="access">#ALLJOYN_PROP_ACCESS_READ, #ALLJOYN_PROP_ACCESS_WRITE or #ALLJOYN_PROP_ACCESS_RW</param>
		/// <returns>- #ER_OK if successful.
		/// - #ER_BUS_PROPERTY_ALREADY_EXISTS if the property can not be added
		/// because it already exists.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_interfacedescription_addproperty(IntPtr iface, [MarshalAs(UnmanagedType.LPStr)]string name, [MarshalAs(UnmanagedType.LPStr)]string signature, byte access);
		// extern AJ_API QStatus AJ_CALL alljoyn_interfacedescription_addproperty(alljoyn_interfacedescription iface, const char* name,const char* signature, uint8_t access);

		/// <summary>
		/// Add an annotation to an existing property
		/// </summary>
		/// <param name="iface">Interface on which to add the property.</param>
		/// <param name="property">Name of property.</param>
		/// <param name="name">Name of annotation</param>
		/// <param name="value">value of annotation</param>
		/// <returns>- #ER_OK if successful.
		/// - #ER_BUS_PROPERTY_ALREADY_EXISTS if the annotation can not be added to the property because it already exists.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_interfacedescription_addpropertyannotation(IntPtr iface, [MarshalAs(UnmanagedType.LPStr)]string property, [MarshalAs(UnmanagedType.LPStr)]string name, [MarshalAs(UnmanagedType.LPStr)]string value);
		// extern AJ_API QStatus AJ_CALL alljoyn_interfacedescription_addpropertyannotation(alljoyn_interfacedescription iface,const char* property,const char* name,const char* value);

		/// <summary>
		/// Get the annotation value for a property
		/// </summary>
		/// <param name="iface">Interface on which to add the property.</param>
		/// <param name="property">Name of the property</param>
		/// <param name="name">Name of annotation</param>
		/// <param name="value">Value for the annotation use NULL to obtain the size of the string in value</param><!-- out -->
		/// <param name="str_size">the size of the char* value if value == NULL return the size of the value string plus nul character</param><!-- in, out -->
		/// <returns>QCC_TRUE if found, QCC_FALSE if not found</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern Int32 alljoyn_interfacedescription_getpropertyannotation(IntPtr iface, [MarshalAs(UnmanagedType.LPStr)]string property, [MarshalAs(UnmanagedType.LPStr)]string name, sbyte value, [In, Out]UIntPtr str_size);
		// extern AJ_API QCC_BOOL AJ_CALL alljoyn_interfacedescription_getpropertyannotation(alljoyn_interfacedescription iface,const char* property,const char* name,char* value,size_t* str_size);

		/// <summary>
		/// Check for existence of a property.
		/// </summary>
		/// <param name="iface">Interface to query.</param>
		/// <param name="name">Name of the property to lookup</param>
		/// <returns>true if the property exists.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern Int32 alljoyn_interfacedescription_hasproperty(IntPtr iface, [MarshalAs(UnmanagedType.LPStr)]string name);
		// extern AJ_API QCC_BOOL AJ_CALL alljoyn_interfacedescription_hasproperty(const alljoyn_interfacedescription iface, const char* name);

		/// <summary>
		/// Check for existence of any properties
		/// </summary>
		/// <param name="iface">Interface to query.</param>
		/// <returns>true if interface has any properties.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern Int32 alljoyn_interfacedescription_hasproperties(IntPtr iface);
		// extern AJ_API QCC_BOOL AJ_CALL alljoyn_interfacedescription_hasproperties(const alljoyn_interfacedescription iface);

		/// <summary>
		/// Returns the name of the interface
		/// </summary>
		/// <param name="iface">Interface to query.</param>
		/// <returns>the interface name.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern IntPtr alljoyn_interfacedescription_getname(IntPtr iface);
		// extern AJ_API const char* AJ_CALL alljoyn_interfacedescription_getname(const alljoyn_interfacedescription iface);

		/// <summary>
		/// Returns a description of the interface in introspection XML format
		/// </summary>
		/// <param name="iface">Interface to query</param>
		/// <param name="str">The character string that will hold the XML stringrepresentation of the interface</param><!-- out -->
		/// <param name="buf">The size of the char* array that will hold the string</param>
		/// <param name="indent">Number of space chars to use in XML indentation.</param>
		/// <returns>The number of characters (including the terminating null byte) whichwould have been written to the final string if enough space is
		/// available.  Thus returning a value larger than buf means the output
		/// was truncated.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern UIntPtr alljoyn_interfacedescription_introspect(IntPtr iface, sbyte str, UIntPtr buf, UIntPtr indent);
		// extern AJ_API size_t AJ_CALL alljoyn_interfacedescription_introspect(const alljoyn_interfacedescription iface, char* str, size_t buf, size_t indent);

		/// <summary>
		/// Indicates if this interface is secure. Secure interfaces require end-to-end authentication.
		/// The arguments for methods calls made to secure interfaces and signals emitted by secure
		/// interfaces are encrypted.
		/// </summary>
		/// <param name="iface">Interface to query.</param>
		/// <returns>true if the interface is secure.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern Int32 alljoyn_interfacedescription_issecure(IntPtr iface);
		// extern AJ_API QCC_BOOL AJ_CALL alljoyn_interfacedescription_issecure(const alljoyn_interfacedescription iface);

		/// <summary>
		/// Get the security policy that applies to this interface.
		/// </summary>
		/// <param name="iface">Interface to query. for its security policy</param>
		/// <returns>Returns the security policy for this interface.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern alljoyn_interfacedescription_securitypolicy alljoyn_interfacedescription_getsecuritypolicy(IntPtr iface);
		// extern AJ_API alljoyn_interfacedescription_securitypolicy AJ_CALL alljoyn_interfacedescription_getsecuritypolicy(const alljoyn_interfacedescription iface);

		/// <summary>
		/// Equality operation.
		/// </summary>
		/// <param name="one">Interface to compare to other</param>
		/// <param name="other">Interface to compare to one</param>
		/// <returns>QCC_TRUE if one == other</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern Int32 alljoyn_interfacedescription_eql(IntPtr one, IntPtr other);
		// extern AJ_API QCC_BOOL AJ_CALL alljoyn_interfacedescription_eql(const alljoyn_interfacedescription one,const alljoyn_interfacedescription other);

		/// <summary>
		/// Equality operation.
		/// </summary>
		/// <param name="one">alljoyn_interfacedescription_member to compare to other</param>
		/// <param name="other">alljoyn_interfacedescription_member to compare to one</param>
		/// <returns>QCC_TRUE if one == other</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern Int32 alljoyn_interfacedescription_member_eql(alljoyn_interfacedescription_member one, alljoyn_interfacedescription_member other);
		// extern AJ_API QCC_BOOL AJ_CALL alljoyn_interfacedescription_member_eql(const alljoyn_interfacedescription_member one,const alljoyn_interfacedescription_member other);

		/// <summary>
		/// Equality operation.
		/// </summary>
		/// <param name="one">alljoyn_interfacedescription_property to compare to other</param>
		/// <param name="other">alljoyn_interfacedescription_property to compare to one</param>
		/// <returns>QCC_TRUE if one == other</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern Int32 alljoyn_interfacedescription_property_eql(alljoyn_interfacedescription_property one, alljoyn_interfacedescription_property other);
		// extern AJ_API QCC_BOOL AJ_CALL alljoyn_interfacedescription_property_eql(const alljoyn_interfacedescription_property one,const alljoyn_interfacedescription_property other);


    }
}