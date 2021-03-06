// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom
{
    /// <summary>
	/// <para>History manager implementation for IE greater 7. IE reloads iframe
	/// content on history actions even just hash value changed. This
	/// implementation forwards history states (hashes) to a helper iframe.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.HashHistory", OmitOptionalParameters = true, Export = false)]
    public partial class HashHistory : qx.bom.History
    {
		#region Methods

		public HashHistory() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds an entry to the browser history.</para>
		/// </summary>
		/// <param name="state">a string representing the state of the application. This command will be delivered in the data property of the &#8220;request&#8221; event.</param>
		/// <param name="newTitle">the page title to set after the history entry is done. This title should represent the new state of the application.</param>
		[JsMethod(Name = "addToHistory")]
		public void AddToHistory(string state, string newTitle = null) { throw new NotImplementedException(); }

		#endregion Methods
    }
}