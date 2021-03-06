// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.table.cellrenderer
{
    /// <summary>
	/// <para>A cell renderer factory which can dynamically exchange the cell renderer
	/// based on information retrieved at runtime. This is useful when different
	/// rows in a column should have different cell renderer based on cell content
	/// or row metadata. A typical example would be a spreadsheet that has different
	/// kind of data in one column.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.table.cellrenderer.Dynamic", OmitOptionalParameters = true, Export = false)]
    public partial class Dynamic : qx.ui.table.cellrenderer.Default
    {
		#region Properties

		/// <summary>
		/// <para>Function that returns a cellRenderer instance which will be
		/// used for the row that is currently being edited. The function is
		/// defined like this:</para>
		/// <code>
		/// myTable.getTableColumnModel().setCellRenderer(function(cellInfo){
		/// // based on the cellInfo map or other information, return the
		/// // appropriate cell renderer
		/// if (cellInfo.row == 5)
		/// return new qx.ui.table.cellrenderer.Boolean;
		/// else
		/// return new qx.ui.table.cellrenderer.Default;
		/// });
		/// </code>
		/// <para>the function MUST return at least a qx.ui.table.cellrenderer.Default</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "cellRendererFactoryFunction", NativeField = true)]
		public Action<object> CellRendererFactoryFunction { get; set; }

		#endregion Properties

		#region Methods

		public Dynamic() { throw new NotImplementedException(); }

		/// <param name="cellRendererFactoryFunction">The initial value for the property #cellRendererFactoryFunction.</param>
		public Dynamic(Action<object> cellRendererFactoryFunction = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Overridden; called whenever the cell updates. The cell will call the
		/// function stored in the cellRendererFactoryFunction to retrieve the
		/// cell renderer which should be used for this particular cell</para>
		/// </summary>
		/// <param name="cellInfo">A map containing the information about the cell to create.</param>
		/// <param name="htmlArr">Target string container. The HTML of the data cell should be appended to this array.</param>
		/// <returns>Data cell HTML</returns>
		[JsMethod(Name = "createDataCellHtml")]
		public string CreateDataCellHtml(object cellInfo, string htmlArr) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property cellRendererFactoryFunction.</para>
		/// </summary>
		[JsMethod(Name = "getCellRendererFactoryFunction")]
		public Action<object> GetCellRendererFactoryFunction() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property cellRendererFactoryFunction
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property cellRendererFactoryFunction.</param>
		[JsMethod(Name = "initCellRendererFactoryFunction")]
		public void InitCellRendererFactoryFunction(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property cellRendererFactoryFunction.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetCellRendererFactoryFunction")]
		public void ResetCellRendererFactoryFunction() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property cellRendererFactoryFunction.</para>
		/// </summary>
		/// <param name="value">New value for property cellRendererFactoryFunction.</param>
		[JsMethod(Name = "setCellRendererFactoryFunction")]
		public void SetCellRendererFactoryFunction(Action<object> value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}