// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.data.controller
{
    /// <summary>
	/// Object Controller
	/// <para>General idea</para>
	/// <para>The idea of the object controller is to make the binding of one model object
	/// containing one or more properties as easy as possible. Therefore the
	/// controller can take a model as property. Every property in that model can be
	/// bound to one or more target properties. The binding will be for
	/// atomic types only like Numbers, Strings, ...</para>
	/// <para>Features</para>
	/// <list type="bullet">
	/// <item>Manages the bindings between the model properties and the different targets</item>
	/// <item>No need for the user to take care of the binding ids</item>
	/// <item>Can create an bidirectional binding (read- / write-binding)</item>
	/// <item>Handles the change of the model which means adding the old targets</item>
	/// </list>
	/// <para>Usage</para>
	/// <para>The controller only can work if a model is set. If the model property is
	/// null, the controller is not working. But it can be null on any time.</para>
	/// <para>Cross reference</para>
	/// <list type="bullet">
	/// <item>If you want to bind a list like widget, use <see cref="qx.data.controller.List"/></item>
	/// <item>If you want to bind a tree widget, use <see cref="qx.data.controller.Tree"/></item>
	/// <item>If you want to bind a form widget, use <see cref="qx.data.controller.Form"/></item>
	/// </list>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.data.controller.Object", OmitOptionalParameters = true, Export = false)]
    public partial class Object : qx.core.Object
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Model"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeModel;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The model object which does have the properties for the binding.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "model", NativeField = true)]
		public qx.core.Object Model { get; set; }

		#endregion Properties

		#region Methods

		public Object() { throw new NotImplementedException(); }

		/// <param name="model">The model for the model property.</param>
		public Object(qx.core.Object model = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds a new target to the controller. After adding the target, the given
		/// property of the model will be bound to the targets property.</para>
		/// </summary>
		/// <param name="targetObject">The object on which the property should be bound.</param>
		/// <param name="targetProperty">The property to which the binding should go.</param>
		/// <param name="sourceProperty">The name of the property in the model.</param>
		/// <param name="bidirectional">Signals if the binding should also work in the reverse direction, from the target to source.</param>
		/// <param name="options">The options Map used by the binding from source to target. The possible options can be found in the qx.data.SingleValueBinding class.</param>
		/// <param name="reverseOptions">The options used by the binding in the reverse direction. The possible options can be found in the qx.data.SingleValueBinding class.</param>
		[JsMethod(Name = "addTarget")]
		public void AddTarget(qx.core.Object targetObject, string targetProperty, string sourceProperty, bool bidirectional = false, object options = null, object reverseOptions = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property model.</para>
		/// </summary>
		[JsMethod(Name = "getModel")]
		public qx.core.Object GetModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property model
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property model.</param>
		[JsMethod(Name = "initModel")]
		public void InitModel(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes the target identified by the three properties.</para>
		/// </summary>
		/// <param name="targetObject">The target object on which the binding exist.</param>
		/// <param name="targetProperty">The targets property name used by the adding of the target.</param>
		/// <param name="sourceProperty">The name of the property of the model.</param>
		[JsMethod(Name = "removeTarget")]
		public void RemoveTarget(qx.core.Object targetObject, string targetProperty, string sourceProperty) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property model.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetModel")]
		public void ResetModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property model.</para>
		/// </summary>
		/// <param name="value">New value for property model.</param>
		[JsMethod(Name = "setModel")]
		public void SetModel(qx.core.Object value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}