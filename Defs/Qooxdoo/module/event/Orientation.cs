// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.module.eventx
{
    /// <summary>
	/// <para>Normalization for orientationchange events
	/// Example:</para>
	/// <code>
	/// q(window).on("orientationchange", function(ev) {
	/// ev.getOrientation();
	/// ev.isLandscape();
	/// });
	/// </code>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.module.event.Orientation", OmitOptionalParameters = true, Export = false)]
    public partial class Orientation 
    {
		#region Methods

		public Orientation() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the current orientation of the viewport in degrees.</para>
		/// <para>All possible values and their meaning:</para>
		/// <list type="bullet">
		/// <item>0: &#8220;Portrait&#8221;</item>
		/// <item>-90: &#8220;Landscape (right, screen turned clockwise)&#8221;</item>
		/// <item>90: &#8220;Landscape (left, screen turned counterclockwise)&#8221;</item>
		/// <item>180: &#8220;Portrait (upside-down portrait)&#8221;</item>
		/// </list>
		/// </summary>
		/// <returns>The current orientation in degrees</returns>
		[JsMethod(Name = "getOrientation")]
		public static double GetOrientation() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the viewport orientation is currently in landscape mode.</para>
		/// </summary>
		/// <returns>true when the viewport orientation is currently in landscape mode.</returns>
		[JsMethod(Name = "isLandscape")]
		public static bool IsLandscape() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the viewport orientation is currently in portrait mode.</para>
		/// </summary>
		/// <returns>true when the viewport orientation is currently in portrait mode.</returns>
		[JsMethod(Name = "isPortrait")]
		public static bool IsPortrait() { throw new NotImplementedException(); }

		#endregion Methods
    }
}