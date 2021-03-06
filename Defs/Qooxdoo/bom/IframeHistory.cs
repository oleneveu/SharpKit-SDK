// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom
{
    /// <summary>
	/// <para>Implements an iFrame based history manager for IE 6/7/8.</para>
	/// <para>Creates a hidden iFrame and uses document.write to store entries in the
	/// history browser&#8217;s stack.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.IframeHistory", OmitOptionalParameters = true, Export = false)]
    public partial class IframeHistory : qx.bom.History
    {
		#region Methods

		public IframeHistory() { throw new NotImplementedException(); }

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