// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom
{
    /// <summary>
	/// <para>Helper class to work with VML . If this class is used, it initialized VML
	/// support.</para>
	/// Note: This class is only available in Internet Explorer!
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.Vml", OmitOptionalParameters = true, Export = false)]
    public partial class Vml 
    {
		#region Methods

		public Vml() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Create VML element</para>
		/// </summary>
		/// <param name="type">The VML element type</param>
		/// <param name="attributes">An optional map of element attributes</param>
		/// <param name="win">The browser window element, in which the element should be created.</param>
		/// <returns>The VML element</returns>
		[JsMethod(Name = "create")]
		public static qx.html.Element Create(string type, object attributes = null, object win = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Creates an VML image and configures it. The image is always tiled.</para>
		/// </summary>
		/// <param name="source">The URL of the image to display</param>
		/// <param name="width">The desired width of the image element</param>
		/// <param name="height">The desired height of the image element</param>
		/// <param name="xOffset">The horizontal offset of the image inside of the image element.</param>
		/// <param name="yOffset">The vertical offset of the image inside of the image element.</param>
		/// <param name="imageWidth">The full width of the image. This value is required, when an xOffset is given.</param>
		/// <param name="imageHeight">The full height of the image. This value is required, when an yOffset is given.</param>
		/// <returns>the VML element of the image</returns>
		[JsMethod(Name = "createImage")]
		public static qx.html.Element CreateImage(string source, double width, double height, double xOffset = 0, double yOffset = 0, double? imageWidth = null, double? imageHeight = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the image source and configures the image. The image element size
		/// resized to the given size and the image is always tiled.</para>
		/// </summary>
		/// <param name="image">The image VML element created by #createImage.</param>
		/// <param name="source">The URL of the image to display</param>
		/// <param name="width">The desired width of the image element</param>
		/// <param name="height">The desired height of the image element</param>
		/// <param name="xOffset">The horizontal offset of the image inside of the image element.</param>
		/// <param name="yOffset">The vertical offset of the image inside of the image element.</param>
		/// <param name="imageWidth">The full width of the image. This value is required, when an xOffset is given.</param>
		/// <param name="imageHeight">The full height of the image. This value is required, when an yOffset is given.</param>
		[JsMethod(Name = "updateImage")]
		public static void UpdateImage(qx.html.Element image, string source, double width, double height, double xOffset = 0, double yOffset = 0, double? imageWidth = null, double? imageHeight = null) { throw new NotImplementedException(); }

		#endregion Methods
    }
}