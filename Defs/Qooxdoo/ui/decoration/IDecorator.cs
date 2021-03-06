// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.decoration
{
    /// <summary>
	/// <para>A decorator is responsible for rendering a widget&#8217;s background and
	/// border. It is passed the widget&#8217;s decoration element <see cref="qx.html.Element"/>
	/// and configures it to display the decoration.</para>
	/// <para>To use the decorator first call the <see cref="GetMarkup"/> method. This method
	/// will return an HTML fragment containing the decoration. After the decoration
	/// has been inserted into the DOM e.g. by using innerHTML the
	/// <see cref="Resize"/> method must be called to give the decoration the proper size.
	/// The first parameter of this call is the root DOM element of the decoration.
	/// The resize call can be repeated as needed.</para>
	/// <para>It is also possible to alter the background color of an decoration using the
	/// <see cref="Tint"/> method.</para>
	/// </summary>
	public interface IDecorator
    {
		#region Methods

		/// <summary>
		/// <para>Get the amount of space, the decoration needs for its border on each
		/// side.</para>
		/// </summary>
		/// <returns>the desired insed a map with the keys top, right, bottom, left.</returns>
		object GetInsets();

		/// <summary>
		/// <para>Returns the basic markup structure used for this decoration.
		/// This later updated on DOM to resize or tint the element.</para>
		/// </summary>
		/// <returns>Basic markup</returns>
		string GetMarkup();

		/// <summary>
		/// <para>Resizes the element respecting the configured borders
		/// to the given width and height. Should automatically
		/// respect the box model of the client to correctly
		/// compute the dimensions.</para>
		/// </summary>
		/// <param name="element">The element to update</param>
		/// <param name="width">Width of the element</param>
		/// <param name="height">Height of the element</param>
		void Resize(qx.html.Element element, double width, double height);

		/// <summary>
		/// <para>Applies the given background color to the element
		/// or fallback to the background color defined
		/// by the decoration itself.</para>
		/// </summary>
		/// <param name="element">The element to update</param>
		/// <param name="bgcolor">The color to apply or null</param>
		void Tint(qx.html.Element element, string bgcolor);

		#endregion Methods
    }
}