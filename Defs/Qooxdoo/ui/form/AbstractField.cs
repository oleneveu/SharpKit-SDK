// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.form
{
    /// <summary>
	/// <para>This is a basic form field with common functionality for
	/// <see cref="TextArea"/> and <see cref="TextField"/>.</para>
	/// <para>On every keystroke the value is synchronized with the
	/// value of the textfield. Value changes can be monitored by listening to the
	/// <see cref="Input"/> or <see cref="ChangeValue"/> events, respectively.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.form.AbstractField", OmitOptionalParameters = true, Export = false)]
    public abstract partial class AbstractField : qx.ui.core.Widget, qx.ui.form.IStringForm, qx.ui.form.IForm
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="ReadOnly"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeReadOnly;

		/// <summary>
		/// <para>Fired when the value was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeValue;

		/// <summary>
		/// <para>The event is fired on every keystroke modifying the value of the field.</para>
		/// <para>The method <see cref="qx.event.type.Data.GetData"/> returns the
		/// current value of the text field.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnInput;

		/// <summary>
		/// <para>Fired when the invalidMessage was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeInvalidMessage;

		/// <summary>
		/// <para>Fired when the required was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeRequired;

		/// <summary>
		/// <para>Fired when the valid state was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeValid;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>RegExp responsible for filtering the value of the textfield. the RegExp
		/// gives the range of valid values.
		/// The following example only allows digits in the textfield.</para>
		/// <code>field.setFilter(/[0-9]/);</code>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "filter", NativeField = true)]
		public JsRegExp Filter { get; set; }

		/// <summary>
		/// <para>Whether the widget is focusable e.g. rendering a focus border and visualize
		/// as active element.</para>
		/// <para>See also <see cref="IsTabable"/> which allows runtime checks for
		/// isChecked or other stuff to test whether the widget is
		/// reachable via the TAB key.</para>
		/// </summary>
		[JsProperty(Name = "focusable", NativeField = true)]
		public bool Focusable { get; set; }

		/// <summary>
		/// <para>Whether the <see cref="ChangeValue"/> event should be fired on every key
		/// input. If set to true, the changeValue event is equal to the
		/// <see cref="Input"/> event.</para>
		/// </summary>
		[JsProperty(Name = "liveUpdate", NativeField = true)]
		public bool LiveUpdate { get; set; }

		/// <summary>
		/// <para>Maximal number of characters that can be entered in the TextArea.</para>
		/// </summary>
		[JsProperty(Name = "maxLength", NativeField = true)]
		public double MaxLength { get; set; }

		/// <summary>
		/// <para>String value which will be shown as a hint if the field is all of:
		/// unset, unfocused and enabled. Set to null to not show a placeholder
		/// text.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "placeholder", NativeField = true)]
		public string Placeholder { get; set; }

		/// <summary>
		/// <para>Whether the field is read only</para>
		/// </summary>
		[JsProperty(Name = "readOnly", NativeField = true)]
		public bool ReadOnly { get; set; }

		/// <summary>
		/// <para>Whether the widget contains content which may be selected by the user.</para>
		/// <para>If the value set to true the native browser selection can
		/// be used for text selection. But it is normally useful for
		/// forms fields, longer texts/documents, editors, etc.</para>
		/// </summary>
		[JsProperty(Name = "selectable", NativeField = true)]
		public bool Selectable { get; set; }

		/// <summary>
		/// <para>Alignment of the text</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "left","center","right"
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "textAlign", NativeField = true)]
		public object TextAlign { get; set; }

		/// <summary>
		/// <para>Message which is shown in an invalid tooltip.</para>
		/// </summary>
		[JsProperty(Name = "invalidMessage", NativeField = true)]
		public string InvalidMessage { get; set; }

		/// <summary>
		/// <para>Flag signaling if a widget is required.</para>
		/// </summary>
		[JsProperty(Name = "required", NativeField = true)]
		public bool Required { get; set; }

		/// <summary>
		/// <para>Message which is shown in an invalid tooltip if the <see cref="Required"/> is
		/// set to true.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "requiredInvalidMessage", NativeField = true)]
		public string RequiredInvalidMessage { get; set; }

		/// <summary>
		/// <para>Flag signaling if a widget is valid. If a widget is invalid, an invalid
		/// state will be set.</para>
		/// </summary>
		[JsProperty(Name = "valid", NativeField = true)]
		public bool Valid { get; set; }

		#endregion Properties

		#region Methods

		public AbstractField() { throw new NotImplementedException(); }

		/// <param name="value">initial text value of the input field (#setValue).</param>
		public AbstractField(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Clears the current selection.
		/// This method only works if the widget is already created and
		/// added to the document.</para>
		/// </summary>
		[JsMethod(Name = "clearTextSelection")]
		public void ClearTextSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property filter.</para>
		/// </summary>
		[JsMethod(Name = "getFilter")]
		public JsRegExp GetFilter() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the element which should be focused.</para>
		/// </summary>
		/// <returns>The html element to focus.</returns>
		[JsMethod(Name = "getFocusElement")]
		public qx.html.Element GetFocusElement() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property liveUpdate.</para>
		/// </summary>
		[JsMethod(Name = "getLiveUpdate")]
		public bool GetLiveUpdate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property maxLength.</para>
		/// </summary>
		[JsMethod(Name = "getMaxLength")]
		public double GetMaxLength() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property placeholder.</para>
		/// </summary>
		[JsMethod(Name = "getPlaceholder")]
		public string GetPlaceholder() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property readOnly.</para>
		/// </summary>
		[JsMethod(Name = "getReadOnly")]
		public bool GetReadOnly() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property textAlign.</para>
		/// </summary>
		[JsMethod(Name = "getTextAlign")]
		public object GetTextAlign() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the current selection.
		/// This method only works if the widget is already created and
		/// added to the document.</para>
		/// </summary>
		/// <returns></returns>
		[JsMethod(Name = "getTextSelection")]
		public string GetTextSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the end of the text selection</para>
		/// </summary>
		/// <returns>End of selection or null if not available</returns>
		[JsMethod(Name = "getTextSelectionEnd")]
		public double GetTextSelectionEnd() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the current selection length.
		/// This method only works if the widget is already created and
		/// added to the document.</para>
		/// </summary>
		/// <returns></returns>
		[JsMethod(Name = "getTextSelectionLength")]
		public double GetTextSelectionLength() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the start of the text selection</para>
		/// </summary>
		/// <returns>Start of selection or null if not available</returns>
		[JsMethod(Name = "getTextSelectionStart")]
		public double GetTextSelectionStart() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>The element&#8217;s user set value.</para>
		/// </summary>
		/// <returns>The value.</returns>
		[JsMethod(Name = "getValue")]
		public string GetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property filter
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property filter.</param>
		[JsMethod(Name = "initFilter")]
		public void InitFilter(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property liveUpdate
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property liveUpdate.</param>
		[JsMethod(Name = "initLiveUpdate")]
		public void InitLiveUpdate(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property maxLength
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property maxLength.</param>
		[JsMethod(Name = "initMaxLength")]
		public void InitMaxLength(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property placeholder
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property placeholder.</param>
		[JsMethod(Name = "initPlaceholder")]
		public void InitPlaceholder(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property readOnly
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property readOnly.</param>
		[JsMethod(Name = "initReadOnly")]
		public void InitReadOnly(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property textAlign
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property textAlign.</param>
		[JsMethod(Name = "initTextAlign")]
		public void InitTextAlign(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property liveUpdate equals true.</para>
		/// </summary>
		[JsMethod(Name = "isLiveUpdate")]
		public void IsLiveUpdate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property readOnly equals true.</para>
		/// </summary>
		[JsMethod(Name = "isReadOnly")]
		public void IsReadOnly() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Used by the layout engine to apply coordinates and dimensions.</para>
		/// </summary>
		/// <param name="left">Any integer value for the left position, always in pixels</param>
		/// <param name="top">Any integer value for the top position, always in pixels</param>
		/// <param name="width">Any positive integer value for the width, always in pixels</param>
		/// <param name="height">Any positive integer value for the height, always in pixels</param>
		/// <returns>A map of which layout sizes changed.</returns>
		[JsMethod(Name = "renderLayout")]
		public object RenderLayout(double left, double top, double width, double height) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property filter.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetFilter")]
		public void ResetFilter() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property liveUpdate.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetLiveUpdate")]
		public void ResetLiveUpdate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property maxLength.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMaxLength")]
		public void ResetMaxLength() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property placeholder.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetPlaceholder")]
		public void ResetPlaceholder() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property readOnly.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetReadOnly")]
		public void ResetReadOnly() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property textAlign.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetTextAlign")]
		public void ResetTextAlign() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the element&#8217;s value to its initial value.</para>
		/// </summary>
		[JsMethod(Name = "resetValue")]
		public void ResetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Selects the whole content</para>
		/// </summary>
		[JsMethod(Name = "selectAllText")]
		public void SelectAllText() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property filter.</para>
		/// </summary>
		/// <param name="value">New value for property filter.</param>
		[JsMethod(Name = "setFilter")]
		public void SetFilter(JsRegExp value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property liveUpdate.</para>
		/// </summary>
		/// <param name="value">New value for property liveUpdate.</param>
		[JsMethod(Name = "setLiveUpdate")]
		public void SetLiveUpdate(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property maxLength.</para>
		/// </summary>
		/// <param name="value">New value for property maxLength.</param>
		[JsMethod(Name = "setMaxLength")]
		public void SetMaxLength(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property placeholder.</para>
		/// </summary>
		/// <param name="value">New value for property placeholder.</param>
		[JsMethod(Name = "setPlaceholder")]
		public void SetPlaceholder(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property readOnly.</para>
		/// </summary>
		/// <param name="value">New value for property readOnly.</param>
		[JsMethod(Name = "setReadOnly")]
		public void SetReadOnly(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property textAlign.</para>
		/// </summary>
		/// <param name="value">New value for property textAlign.</param>
		[JsMethod(Name = "setTextAlign")]
		public void SetTextAlign(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the selection to the given start and end (zero-based).
		/// If no end value is given the selection will extend to the
		/// end of the textfield&#8217;s content.
		/// This method only works if the widget is already created and
		/// added to the document.</para>
		/// </summary>
		/// <param name="start">start of the selection (zero-based)</param>
		/// <param name="end">end of the selection</param>
		[JsMethod(Name = "setTextSelection")]
		public void SetTextSelection(double start, double end) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the element&#8217;s value.</para>
		/// </summary>
		/// <param name="value">The new value of the element.</param>
		[JsMethod(Name = "setValue")]
		public void SetValue(string value) { throw new NotImplementedException(); }

		[JsMethod(Name = "tabFocus")]
		public void TabFocus() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property liveUpdate.</para>
		/// </summary>
		[JsMethod(Name = "toggleLiveUpdate")]
		public void ToggleLiveUpdate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property readOnly.</para>
		/// </summary>
		[JsMethod(Name = "toggleReadOnly")]
		public void ToggleReadOnly() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the invalid message of the widget.</para>
		/// </summary>
		/// <returns>The current set message.</returns>
		[JsMethod(Name = "getInvalidMessage")]
		public string GetInvalidMessage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the current required state of the widget.</para>
		/// </summary>
		/// <returns>True, if the widget is required.</returns>
		[JsMethod(Name = "getRequired")]
		public bool GetRequired() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the invalid message if required of the widget.</para>
		/// </summary>
		/// <returns>The current set message.</returns>
		[JsMethod(Name = "getRequiredInvalidMessage")]
		public string GetRequiredInvalidMessage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the valid state of the widget.</para>
		/// </summary>
		/// <returns>If the state of the widget is valid.</returns>
		[JsMethod(Name = "getValid")]
		public bool GetValid() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property invalidMessage
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property invalidMessage.</param>
		[JsMethod(Name = "initInvalidMessage")]
		public void InitInvalidMessage(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property required
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property required.</param>
		[JsMethod(Name = "initRequired")]
		public void InitRequired(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property requiredInvalidMessage
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property requiredInvalidMessage.</param>
		[JsMethod(Name = "initRequiredInvalidMessage")]
		public void InitRequiredInvalidMessage(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property valid
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property valid.</param>
		[JsMethod(Name = "initValid")]
		public void InitValid(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property required equals true.</para>
		/// </summary>
		[JsMethod(Name = "isRequired")]
		public void IsRequired() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property valid equals true.</para>
		/// </summary>
		[JsMethod(Name = "isValid")]
		public void IsValid() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property invalidMessage.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetInvalidMessage")]
		public void ResetInvalidMessage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property required.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRequired")]
		public void ResetRequired() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property requiredInvalidMessage.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRequiredInvalidMessage")]
		public void ResetRequiredInvalidMessage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property valid.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetValid")]
		public void ResetValid() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the invalid message of the widget.</para>
		/// </summary>
		/// <param name="message">The invalid message.</param>
		[JsMethod(Name = "setInvalidMessage")]
		public void SetInvalidMessage(string message) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the required state of a widget.</para>
		/// </summary>
		/// <param name="required">A flag signaling if the widget is required.</param>
		[JsMethod(Name = "setRequired")]
		public void SetRequired(bool required) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the invalid message if required of the widget.</para>
		/// </summary>
		/// <param name="message">The invalid message.</param>
		[JsMethod(Name = "setRequiredInvalidMessage")]
		public void SetRequiredInvalidMessage(string message) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the valid state of the widget.</para>
		/// </summary>
		/// <param name="valid">The valid state of the widget.</param>
		[JsMethod(Name = "setValid")]
		public void SetValid(bool valid) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property required.</para>
		/// </summary>
		[JsMethod(Name = "toggleRequired")]
		public void ToggleRequired() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property valid.</para>
		/// </summary>
		[JsMethod(Name = "toggleValid")]
		public void ToggleValid() { throw new NotImplementedException(); }

		#endregion Methods
    }
}