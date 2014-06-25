// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.io
{
    /// <summary>
	/// <para>EXPERIMENTAL &#8211; NOT READY FOR PRODUCTION</para>
	/// <para>Loading of local or remote scripts.</para>
	/// <list type="bullet">
	/// <item>Supports cross-domain communication</item>
	/// <item>Automatically &#8220;embeds&#8221; script so when the loaded event occurs the new features are usable as well</item>
	/// </list
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.io.ScriptLoader", OmitOptionalParameters = true, Export = false)]
    public partial class ScriptLoader 
    {
		#region Methods

		public ScriptLoader() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Aborts a currently running process.</para>
		/// </summary>
		[JsMethod(Name = "abort")]
		public void Abort() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Internal cleanup method used after every successful
		/// or failed loading attempt.</para>
		/// </summary>
		/// <param name="status">Any of success, fail or abort.</param>
		[JsMethod(Name = "dispose")]
		public void Dispose(string status) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Loads the script from the given URL. It is possible to define
		/// a callback and a context in which the callback is executed.</para>
		/// <para>The callback is executed when the process is done with any
		/// of these status messages: success, fail or abort.</para>
		/// <para>Note that browsers not supporting the native &#8220;error&#8221; event detect
		/// network errors as soon as the timeout limit is reached.</para>
		/// </summary>
		/// <param name="url">URL of the script</param>
		/// <param name="callback">Callback to execute</param>
		/// <param name="context">Context in which the function should be executed</param>
		[JsMethod(Name = "load")]
		public void Load(string url, Action<object> callback, object context = null) { throw new NotImplementedException(); }

		#endregion Methods
    }
}