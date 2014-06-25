// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom
{
    /// <summary>
	/// <para>This is a cross browser wrapper for requestAnimationFrame. For further
	/// information about the feature, take a look at spec:
	/// http://www.w3.org/TR/animation-timing/</para>
	/// <para>This class offers two ways of using this feature. First, the plain
	/// API the spec describes.</para>
	/// <para>Here is a sample usage:</para>
	/// <code>var start = +(new Date());
	/// var clb = function(time) {
	/// if (time >= start + duration) {
	/// // ... do some last tasks
	/// } else {
	/// var timePassed = time - start;
	/// // ... calculate the current step and apply it
	/// qx.bom.AnimationFrame.request(clb, this);
	/// }
	/// };
	/// qx.bom.AnimationFrame.request(clb, this);
	/// </code>
	/// <para>Another way of using it is to use it as an instance emitting events.</para>
	/// <para>Here is a sample usage of that API:</para>
	/// <code>var frame = new qx.bom.AnimationFrame();
	/// frame.on("end", function() {
	/// // ... do some last tasks
	/// }, this);
	/// frame.on("frame", function(timePassed) {
	/// // ... calculate the current step and apply it
	/// }, this);
	/// frame.startSequence(duration);
	/// </code>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.AnimationFrame", OmitOptionalParameters = true, Export = false)]
    public partial class AnimationFrame : qx.eventx.Emitter
    {
		#region Events

		/// <summary>
		/// <para>Fired as soon as the animation has ended.</para>
		/// </summary>
		public event Action<object> OnEnd;

		/// <summary>
		/// <para>Fired on every frame having the passed time as value.</para>
		/// </summary>
		public event Action<double> OnFrame;

		#endregion Events

		#region Methods

		public AnimationFrame() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Method used to start a series of animation frames. The series will end as
		/// soon as the given duration is over.</para>
		/// </summary>
		/// <param name="duration">The duration the sequence should take.</param>
		[JsMethod(Name = "startSequence")]
		public void StartSequence(double duration) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calculation of the predefined timing functions. Approximation of the real
		/// bezier curves has ben used for easier calculation. This is good and close
		/// enough for the predefined functions like ease or
		/// linear.</para>
		/// </summary>
		/// <param name="func">The defined timing function. One of the following values: &#8220;ease-in&#8221;, &#8220;ease-out&#8221;, &#8220;linear&#8221;, &#8220;ease-in-out&#8221;, &#8220;ease&#8221;.</param>
		/// <param name="x">The percent value of the function.</param>
		/// <returns>The calculated value</returns>
		[JsMethod(Name = "calculateTiming")]
		public static double CalculateTiming(string func, double x) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Request for an animation frame. If the native requestAnimationFrame
		/// method is supported, it will be used. Otherwise, we use timeouts with a
		/// 30ms delay.</para>
		/// </summary>
		/// <param name="callback">The callback function which will get the current time as argument.</param>
		/// <param name="context">The context of the callback.</param>
		/// <returns>The id of the request.</returns>
		[JsMethod(Name = "request")]
		public static double Request(Action<object> callback, object context) { throw new NotImplementedException(); }

		#endregion Methods
    }
}