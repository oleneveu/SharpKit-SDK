// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.module.eventx
{
    /// <summary>
	/// <para>Normalization for native mouse events</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.module.event.Mouse", OmitOptionalParameters = true, Export = false)]
    public partial class Mouse 
    {
		#region Methods

		public Mouse() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the identifier of the mouse button that change state when the
		/// event was triggered</para>
		/// </summary>
		/// <returns>One of left, right or middle</returns>
		[JsMethod(Name = "getButton")]
		public static string GetButton() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the horizontal position at which the event occurred relative to the
		/// left of the document. This property takes into account any scrolling of
		/// the page.</para>
		/// </summary>
		/// <returns>The horizontal mouse position in the document.</returns>
		[JsMethod(Name = "getDocumentLeft")]
		public static double GetDocumentLeft() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the vertical position at which the event occurred relative to the
		/// top of the document. This property takes into account any scrolling of
		/// the page.</para>
		/// </summary>
		/// <returns>The vertical mouse position in the document.</returns>
		[JsMethod(Name = "getDocumentTop")]
		public static double GetDocumentTop() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the horizontal coordinate at which the event occurred relative to
		/// the origin of the screen coordinate system.</para>
		/// <para>Note: This value is usually not very useful unless you want to
		/// position a native popup window at this coordinate.</para>
		/// </summary>
		/// <returns>The horizontal mouse position on the screen.</returns>
		[JsMethod(Name = "getScreenLeft")]
		public static double GetScreenLeft() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the vertical coordinate at which the event occurred relative to
		/// the origin of the screen coordinate system.</para>
		/// <para>Note: This value is usually not very useful unless you want to
		/// position a native popup window at this coordinate.</para>
		/// </summary>
		/// <returns>The vertical mouse position on the screen.</returns>
		[JsMethod(Name = "getScreenTop")]
		public static double GetScreenTop() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the horizontal coordinate at which the event occurred relative
		/// to the viewport.</para>
		/// </summary>
		/// <returns>The horizontal mouse position</returns>
		[JsMethod(Name = "getViewportLeft")]
		public static double GetViewportLeft() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the vertical coordinate at which the event occurred relative
		/// to the viewport.</para>
		/// </summary>
		/// <returns>The vertical mouse position</returns>
		[JsMethod(Name = "getViewportTop")]
		public static double GetViewportTop() { throw new NotImplementedException(); }

		#endregion Methods
    }
}