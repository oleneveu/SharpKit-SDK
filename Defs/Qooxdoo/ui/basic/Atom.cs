// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.basic
{
    /// <summary>
	/// <para>A multi-purpose widget, which combines a label with an icon.</para>
	/// <para>The intended purpose of qx.ui.basic.Atom is to easily align the common icon-text
	/// combination in different ways.</para>
	/// <para>This is useful for all types of buttons, tooltips, ...</para>
	/// <para>Example</para>
	/// <para>Here is a little example of how to use the widget.</para>
	/// <code>
	/// var atom = new qx.ui.basic.Atom("Icon Right", "icon/32/actions/go-next.png");
	/// this.getRoot().add(atom);
	/// </code>
	/// <para>This example creates an atom with the label &#8220;Icon Right&#8221; and an icon.</para>
	/// <para>External Documentation</para>
	/// 
	/// Documentation of this widget in the qooxdoo manual.
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.basic.Atom", OmitOptionalParameters = true, Export = false)]
    public partial class Atom : qx.ui.core.Widget
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Gap"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeGap;

		/// <summary>
		/// Fired on change of the property <see cref="Icon"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeIcon;

		/// <summary>
		/// Fired on change of the property <see cref="Label"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeLabel;

		/// <summary>
		/// Fired on change of the property <see cref="Show"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeShow;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The appearance ID. This ID is used to identify the appearance theme
		/// entry to use for this widget. This controls the styling of the element.</para>
		/// </summary>
		[JsProperty(Name = "appearance", NativeField = true)]
		public string Appearance { get; set; }

		/// <summary>
		/// <para>Whether the content should be rendered centrally when to much space
		/// is available. Affects both axis.</para>
		/// </summary>
		[JsProperty(Name = "center", NativeField = true)]
		public bool Center { get; set; }

		/// <summary>
		/// <para>The space between the icon and the label</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: false
		/// </remarks>
		[JsProperty(Name = "gap", NativeField = true)]
		public double Gap { get; set; }

		/// <summary>
		/// <para>Any URI String supported by qx.ui.basic.Image to display an icon</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "icon", NativeField = true)]
		public string Icon { get; set; }

		/// <summary>
		/// <para>The position of the icon in relation to the text.
		/// Only useful/needed if text and icon is configured and &#8216;show&#8217; is configured as &#8216;both&#8217; (default)</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "top","right","bottom","left","top-left","bottom-left"
		/// </remarks>
		[JsProperty(Name = "iconPosition", NativeField = true)]
		public object IconPosition { get; set; }

		/// <summary>
		/// <para>The label/caption/text of the qx.ui.basic.Atom instance</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "label", NativeField = true)]
		public string Label { get; set; }

		/// <summary>
		/// <para>Switches between rich HTML and text content. The text mode (false) supports
		/// advanced features like ellipsis when the available space is not
		/// enough. HTML mode (true) supports multi-line content and all the
		/// markup features of HTML content.</para>
		/// </summary>
		[JsProperty(Name = "rich", NativeField = true)]
		public bool Rich { get; set; }

		/// <summary>
		/// <para>Configure the visibility of the sub elements/widgets.
		/// Possible values: both, label, icon</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "both","label","icon"
		/// </remarks>
		[JsProperty(Name = "show", NativeField = true)]
		public object Show { get; set; }

		#endregion Properties

		#region Methods

		public Atom() { throw new NotImplementedException(); }

		/// <param name="label">Label to use</param>
		/// <param name="icon">Icon to use</param>
		public Atom(string label, string icon = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property center.</para>
		/// </summary>
		[JsMethod(Name = "getCenter")]
		public bool GetCenter() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property gap.</para>
		/// </summary>
		[JsMethod(Name = "getGap")]
		public double GetGap() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property icon.</para>
		/// </summary>
		[JsMethod(Name = "getIcon")]
		public string GetIcon() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property iconPosition.</para>
		/// </summary>
		[JsMethod(Name = "getIconPosition")]
		public object GetIconPosition() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property label.</para>
		/// </summary>
		[JsMethod(Name = "getLabel")]
		public string GetLabel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property rich.</para>
		/// </summary>
		[JsMethod(Name = "getRich")]
		public bool GetRich() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property show.</para>
		/// </summary>
		[JsMethod(Name = "getShow")]
		public object GetShow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property center
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property center.</param>
		[JsMethod(Name = "initCenter")]
		public void InitCenter(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property gap
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property gap.</param>
		[JsMethod(Name = "initGap")]
		public void InitGap(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property icon
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property icon.</param>
		[JsMethod(Name = "initIcon")]
		public void InitIcon(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property iconPosition
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property iconPosition.</param>
		[JsMethod(Name = "initIconPosition")]
		public void InitIconPosition(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property label
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property label.</param>
		[JsMethod(Name = "initLabel")]
		public void InitLabel(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property rich
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property rich.</param>
		[JsMethod(Name = "initRich")]
		public void InitRich(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property show
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property show.</param>
		[JsMethod(Name = "initShow")]
		public void InitShow(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property center equals true.</para>
		/// </summary>
		[JsMethod(Name = "isCenter")]
		public void IsCenter() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property rich equals true.</para>
		/// </summary>
		[JsMethod(Name = "isRich")]
		public void IsRich() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property center.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetCenter")]
		public void ResetCenter() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property gap.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetGap")]
		public void ResetGap() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property icon.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetIcon")]
		public void ResetIcon() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property iconPosition.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetIconPosition")]
		public void ResetIconPosition() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property label.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetLabel")]
		public void ResetLabel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property rich.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRich")]
		public void ResetRich() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property show.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetShow")]
		public void ResetShow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property center.</para>
		/// </summary>
		/// <param name="value">New value for property center.</param>
		[JsMethod(Name = "setCenter")]
		public void SetCenter(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property gap.</para>
		/// </summary>
		/// <param name="value">New value for property gap.</param>
		[JsMethod(Name = "setGap")]
		public void SetGap(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property icon.</para>
		/// </summary>
		/// <param name="value">New value for property icon.</param>
		[JsMethod(Name = "setIcon")]
		public void SetIcon(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property iconPosition.</para>
		/// </summary>
		/// <param name="value">New value for property iconPosition.</param>
		[JsMethod(Name = "setIconPosition")]
		public void SetIconPosition(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property label.</para>
		/// </summary>
		/// <param name="value">New value for property label.</param>
		[JsMethod(Name = "setLabel")]
		public void SetLabel(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property rich.</para>
		/// </summary>
		/// <param name="value">New value for property rich.</param>
		[JsMethod(Name = "setRich")]
		public void SetRich(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property show.</para>
		/// </summary>
		/// <param name="value">New value for property show.</param>
		[JsMethod(Name = "setShow")]
		public void SetShow(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property center.</para>
		/// </summary>
		[JsMethod(Name = "toggleCenter")]
		public void ToggleCenter() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property rich.</para>
		/// </summary>
		[JsMethod(Name = "toggleRich")]
		public void ToggleRich() { throw new NotImplementedException(); }

		#endregion Methods
    }
}