// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.decoration
{
    /// <summary>
	/// <para>Beveled is a variant of a rounded decorator which is quite optimal
	/// regarding performance and still delivers a good set of features:</para>
	/// <list type="bullet">
	/// <item>One pixel rounded border</item>
	/// <item>Inner glow color with optional transparency</item>
	/// <item>Repeated or scaled background image</item>
	/// </list>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.decoration.Beveled", OmitOptionalParameters = true, Export = false)]
    public partial class Beveled : qx.ui.decoration.Abstract
    {
		#region Properties

		/// <summary>
		/// <para>The color of the inner frame.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "innerColor", NativeField = true)]
		public string InnerColor { get; set; }

		/// <summary>
		/// <para>The opacity of the inner frame. As this inner frame
		/// is rendered above the background image this may be
		/// intersting to configure as semi-transparent e.g. 0.4.</para>
		/// </summary>
		[JsProperty(Name = "innerOpacity", NativeField = true)]
		public double InnerOpacity { get; set; }

		/// <summary>
		/// <para>Color of the outer frame. The corners are automatically
		/// rendered with a slight opacity to fade into the background</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "outerColor", NativeField = true)]
		public string OuterColor { get; set; }

		/// <summary>
		/// <para>The URL of the background image</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "backgroundImage", NativeField = true)]
		public string BackgroundImage { get; set; }

		/// <summary>
		/// <para>Property group to define the background position</para>
		/// </summary>
		[JsProperty(Name = "backgroundPosition", NativeField = true)]
		public object BackgroundPosition { get; set; }

		/// <summary>
		/// <para>Either a string or a number, which defines the horizontal position
		/// of the background image.</para>
		/// <para>If the value is an integer it is interpreted as a pixel value, otherwise
		/// the value is taken to be a CSS value. For CSS, the values are &#8220;center&#8221;,
		/// &#8220;left&#8221; and &#8220;right&#8221;.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "backgroundPositionX", NativeField = true)]
		public object BackgroundPositionX { get; set; }

		/// <summary>
		/// <para>Either a string or a number, which defines the vertical position
		/// of the background image.</para>
		/// <para>If the value is an integer it is interpreted as a pixel value, otherwise
		/// the value is taken to be a CSS value. For CSS, the values are &#8220;top&#8221;,
		/// &#8220;center&#8221; and &#8220;bottom&#8221;.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "backgroundPositionY", NativeField = true)]
		public object BackgroundPositionY { get; set; }

		/// <summary>
		/// <para>How the background image should be repeated</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "repeat","repeat-x","repeat-y","no-repeat","scale"
		/// </remarks>
		[JsProperty(Name = "backgroundRepeat", NativeField = true)]
		public object BackgroundRepeat { get; set; }

		/// <summary>
		/// <para>Color of the background</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "backgroundColor", NativeField = true)]
		public string BackgroundColor { get; set; }

		#endregion Properties

		#region Methods

		public Beveled() { throw new NotImplementedException(); }

		/// <param name="outerColor">The outer border color</param>
		/// <param name="innerColor">The inner border color</param>
		/// <param name="innerOpacity">Opacity of inner border</param>
		public Beveled(string outerColor, string innerColor, double innerOpacity) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property innerColor.</para>
		/// </summary>
		[JsMethod(Name = "getInnerColor")]
		public string GetInnerColor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property innerOpacity.</para>
		/// </summary>
		[JsMethod(Name = "getInnerOpacity")]
		public double GetInnerOpacity() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the basic markup structure used for this decoration.
		/// This later updated on DOM to resize or tint the element.</para>
		/// </summary>
		/// <returns>Basic markup</returns>
		[JsMethod(Name = "getMarkup")]
		public string GetMarkup() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property outerColor.</para>
		/// </summary>
		[JsMethod(Name = "getOuterColor")]
		public string GetOuterColor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property innerColor
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property innerColor.</param>
		[JsMethod(Name = "initInnerColor")]
		public void InitInnerColor(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property innerOpacity
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property innerOpacity.</param>
		[JsMethod(Name = "initInnerOpacity")]
		public void InitInnerOpacity(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property outerColor
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property outerColor.</param>
		[JsMethod(Name = "initOuterColor")]
		public void InitOuterColor(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property innerColor.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetInnerColor")]
		public void ResetInnerColor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property innerOpacity.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetInnerOpacity")]
		public void ResetInnerOpacity() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property outerColor.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetOuterColor")]
		public void ResetOuterColor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resizes the element respecting the configured borders
		/// to the given width and height. Should automatically
		/// respect the box model of the client to correctly
		/// compute the dimensions.</para>
		/// </summary>
		/// <param name="element">The element to update</param>
		/// <param name="width">Width of the element</param>
		/// <param name="height">Height of the element</param>
		[JsMethod(Name = "resize")]
		public void Resize(qx.html.Element element, double width, double height) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property innerColor.</para>
		/// </summary>
		/// <param name="value">New value for property innerColor.</param>
		[JsMethod(Name = "setInnerColor")]
		public void SetInnerColor(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property innerOpacity.</para>
		/// </summary>
		/// <param name="value">New value for property innerOpacity.</param>
		[JsMethod(Name = "setInnerOpacity")]
		public void SetInnerOpacity(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property outerColor.</para>
		/// </summary>
		/// <param name="value">New value for property outerColor.</param>
		[JsMethod(Name = "setOuterColor")]
		public void SetOuterColor(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Applies the given background color to the element
		/// or fallback to the background color defined
		/// by the decoration itself.</para>
		/// </summary>
		/// <param name="element">The element to update</param>
		/// <param name="bgcolor">The color to apply or null</param>
		[JsMethod(Name = "tint")]
		public void Tint(qx.html.Element element, string bgcolor) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property backgroundImage.</para>
		/// </summary>
		[JsMethod(Name = "getBackgroundImage")]
		public string GetBackgroundImage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property backgroundPositionX.</para>
		/// </summary>
		[JsMethod(Name = "getBackgroundPositionX")]
		public object GetBackgroundPositionX() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property backgroundPositionY.</para>
		/// </summary>
		[JsMethod(Name = "getBackgroundPositionY")]
		public object GetBackgroundPositionY() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property backgroundRepeat.</para>
		/// </summary>
		[JsMethod(Name = "getBackgroundRepeat")]
		public object GetBackgroundRepeat() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property backgroundImage
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property backgroundImage.</param>
		[JsMethod(Name = "initBackgroundImage")]
		public void InitBackgroundImage(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property backgroundPositionX
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property backgroundPositionX.</param>
		[JsMethod(Name = "initBackgroundPositionX")]
		public void InitBackgroundPositionX(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property backgroundPositionY
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property backgroundPositionY.</param>
		[JsMethod(Name = "initBackgroundPositionY")]
		public void InitBackgroundPositionY(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property backgroundRepeat
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property backgroundRepeat.</param>
		[JsMethod(Name = "initBackgroundRepeat")]
		public void InitBackgroundRepeat(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property backgroundImage.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetBackgroundImage")]
		public void ResetBackgroundImage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property backgroundPosition.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetBackgroundPosition")]
		public void ResetBackgroundPosition() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property backgroundPositionX.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetBackgroundPositionX")]
		public void ResetBackgroundPositionX() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property backgroundPositionY.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetBackgroundPositionY")]
		public void ResetBackgroundPositionY() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property backgroundRepeat.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetBackgroundRepeat")]
		public void ResetBackgroundRepeat() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property backgroundImage.</para>
		/// </summary>
		/// <param name="value">New value for property backgroundImage.</param>
		[JsMethod(Name = "setBackgroundImage")]
		public void SetBackgroundImage(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the values of the property group backgroundPosition.</para>
		/// </summary>
		/// <param name="backgroundPositionY">Sets the value of the property #backgroundPositionY.</param>
		/// <param name="backgroundPositionX">Sets the value of the property #backgroundPositionX.</param>
		[JsMethod(Name = "setBackgroundPosition")]
		public void SetBackgroundPosition(object backgroundPositionY, object backgroundPositionX) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property backgroundPositionX.</para>
		/// </summary>
		/// <param name="value">New value for property backgroundPositionX.</param>
		[JsMethod(Name = "setBackgroundPositionX")]
		public void SetBackgroundPositionX(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property backgroundPositionY.</para>
		/// </summary>
		/// <param name="value">New value for property backgroundPositionY.</param>
		[JsMethod(Name = "setBackgroundPositionY")]
		public void SetBackgroundPositionY(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property backgroundRepeat.</para>
		/// </summary>
		/// <param name="value">New value for property backgroundRepeat.</param>
		[JsMethod(Name = "setBackgroundRepeat")]
		public void SetBackgroundRepeat(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property backgroundColor.</para>
		/// </summary>
		[JsMethod(Name = "getBackgroundColor")]
		public string GetBackgroundColor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property backgroundColor
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property backgroundColor.</param>
		[JsMethod(Name = "initBackgroundColor")]
		public void InitBackgroundColor(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property backgroundColor.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetBackgroundColor")]
		public void ResetBackgroundColor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property backgroundColor.</para>
		/// </summary>
		/// <param name="value">New value for property backgroundColor.</param>
		[JsMethod(Name = "setBackgroundColor")]
		public void SetBackgroundColor(string value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}