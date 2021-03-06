// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.progressive.structure
{
    /// <summary>
	/// <para>Abstract structure definition for Progressive</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.progressive.structure.Abstract", OmitOptionalParameters = true, Export = false)]
    public abstract partial class Abstract : qx.core.Object
    {
		#region Methods

		public Abstract() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>The abstract structure for use by Progressive.  It defines the pane
		/// container in which items are progressively rendered.</para>
		/// </summary>
		/// <param name="pane">The container to use as the pane, applied to the Progressive structure.  If null, a qx.ui.core.Widget will be instantiated for use as the pane.</param>
		public Abstract(qx.ui.core.Widget pane) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Apply the structure typically defined in the constructor to the
		/// Progressive.</para>
		/// </summary>
		/// <param name="progressive">The Progressive to which the structure is to be applied.</param>
		[JsMethod(Name = "applyStructure")]
		public void ApplyStructure(qx.ui.progressive.Progressive progressive) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the pane in which this Progressive renders.</para>
		/// </summary>
		/// <returns></returns>
		[JsMethod(Name = "getPane")]
		public qx.ui.core.Widget GetPane() { throw new NotImplementedException(); }

		#endregion Methods
    }
}