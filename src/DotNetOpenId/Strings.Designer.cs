﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetOpenId {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotNetOpenId.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HttpContext.Current is null.  There must be an ASP.NET request in process for this operation to succeed..
        /// </summary>
        internal static string CurrentHttpContextRequired {
            get {
                return ResourceManager.GetString("CurrentHttpContextRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OpenID parameter &apos;{0}&apos; was expected to be base64 encoded but is not..
        /// </summary>
        internal static string ExpectedBase64OpenIdQueryParameter {
            get {
                return ResourceManager.GetString("ExpectedBase64OpenIdQueryParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The nonce has expired..
        /// </summary>
        internal static string ExpiredNonce {
            get {
                return ResourceManager.GetString("ExpiredNonce", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Extension parameter key &apos;{0}&apos; encountered, but extension parameter keys should not include their prefix..
        /// </summary>
        internal static string ExtensionParameterKeysWithoutPrefixExpected {
            get {
                return ResourceManager.GetString("ExtensionParameterKeysWithoutPrefixExpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No current HttpContext was detected, so an IAssociationStore must be explicitly provided. Call the Server constructor overload that takes an IAssociationStore..
        /// </summary>
        internal static string IAssociationStoreRequiredWhenNoHttpContextAvailable {
            get {
                return ResourceManager.GetString("IAssociationStoreRequiredWhenNoHttpContextAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot encode &apos;{0}&apos; because it contains an illegal character for Key-Value Form encoding..
        /// </summary>
        internal static string InvalidCharacterInKeyValueFormInput {
            get {
                return ResourceManager.GetString("InvalidCharacterInKeyValueFormInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot decode Key-Value Form because a line was found without a &apos;{0}&apos; character..
        /// </summary>
        internal static string InvalidKeyValueFormCharacterMissing {
            get {
                return ResourceManager.GetString("InvalidKeyValueFormCharacterMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OpenID parameter &apos;{0}&apos; had unexpected value &apos;{1}&apos;..
        /// </summary>
        internal static string InvalidOpenIdQueryParameterValue {
            get {
                return ResourceManager.GetString("InvalidOpenIdQueryParameterValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The scheme must be http or https but was &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidScheme {
            get {
                return ResourceManager.GetString("InvalidScheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The signature verification failed..
        /// </summary>
        internal static string InvalidSignature {
            get {
                return ResourceManager.GetString("InvalidSignature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not a recognized XRI format: &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidXri {
            get {
                return ResourceManager.GetString("InvalidXri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The given key &apos;{0}&apos; already exists..
        /// </summary>
        internal static string KeyAlreadyExists {
            get {
                return ResourceManager.GetString("KeyAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The list of keys do not match the provided dictionary..
        /// </summary>
        internal static string KeysListAndDictionaryDoNotMatch {
            get {
                return ResourceManager.GetString("KeysListAndDictionaryDoNotMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The XRDS document is missing the required CanonicalID element..
        /// </summary>
        internal static string MissingCanonicalIDElement {
            get {
                return ResourceManager.GetString("MissingCanonicalIDElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query parameter &apos;{0}&apos; was missing from the query..
        /// </summary>
        internal static string MissingInternalQueryParameter {
            get {
                return ResourceManager.GetString("MissingInternalQueryParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OpenID parameter &apos;{0}&apos; was missing from the query..
        /// </summary>
        internal static string MissingOpenIdQueryParameter {
            get {
                return ResourceManager.GetString("MissingOpenIdQueryParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query parameter &apos;{0}&apos; was expected in the return_to query &apos;{1}&apos;..
        /// </summary>
        internal static string MissingReturnToQueryParameter {
            get {
                return ResourceManager.GetString("MissingReturnToQueryParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No openid endpoint found..
        /// </summary>
        internal static string OpenIdEndpointNotFound {
            get {
                return ResourceManager.GetString("OpenIdEndpointNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No OpenId url is provided..
        /// </summary>
        internal static string OpenIdTextBoxEmpty {
            get {
                return ResourceManager.GetString("OpenIdTextBoxEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prefix should not begin or end with a period..
        /// </summary>
        internal static string PrefixWithoutPeriodsExpected {
            get {
                return ResourceManager.GetString("PrefixWithoutPeriodsExpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to determine provider&apos;s OpenID version..
        /// </summary>
        internal static string ProviderOpenIdVersionUnknown {
            get {
                return ResourceManager.GetString("ProviderOpenIdVersionUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The nonce has already been used..
        /// </summary>
        internal static string ReplayAttackDetected {
            get {
                return ResourceManager.GetString("ReplayAttackDetected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OpenId provider&apos;s response is not ready.  Use IsResponseReady to check, and fill in the required properties first..
        /// </summary>
        internal static string ResponseNotReady {
            get {
                return ResourceManager.GetString("ResponseNotReady", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; parameter does not have the same value for return_to (&apos;{1}&apos;) and the regular query (&apos;{2}&apos;)..
        /// </summary>
        internal static string ReturnToArgDifferentFromQueryArg {
            get {
                return ResourceManager.GetString("ReturnToArgDifferentFromQueryArg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to return_to &apos;{0}&apos; not under trust_root &apos;{1}&apos;..
        /// </summary>
        internal static string ReturnToNotUnderTrustRoot {
            get {
                return ResourceManager.GetString("ReturnToNotUnderTrustRoot", resourceCulture);
            }
        }
    }
}
