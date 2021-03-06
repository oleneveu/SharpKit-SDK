// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.core
{
    /// <summary>
	/// <para>This mixin redirects the layout manager to a child widget of the
	/// including class. This is e.g. used in <see cref="qx.ui.window.Window"/> to configure
	/// the layout manager of the window pane instead of the window directly.</para>
	/// <para>The including class must implement the method getChildrenContainer,
	/// which has to return the widget, to which the layout should be set.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.core.MRemoteLayoutHandling", OmitOptionalParameters = true, Export = false)]
    public partial class MRemoteLayoutHandling 
    {
		#region Methods

		public MRemoteLayoutHandling() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the widget&#8217;s layout manager.</para>
		/// </summary>
		/// <returns>The widget&#8217;s layout manager</returns>
		[JsMethod(Name = "getLayout")]
		public qx.ui.layout.Abstract GetLayout() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set a layout manager for the widget. A a layout manager can only be connected
		/// with one widget. Reset the connection with a previous widget first, if you
		/// like to use it in another widget instead.</para>
		/// </summary>
		/// <param name="layout">The new layout or null to reset the layout.</param>
		[JsMethod(Name = "setLayout")]
		public void SetLayout(qx.ui.layout.Abstract layout) { throw new NotImplementedException(); }

		#endregion Methods
    }
}