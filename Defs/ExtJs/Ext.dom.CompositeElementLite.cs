//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.dom
{
    #region CompositeElementLite
    /// <inheritdocs />
    /// <summary>
    /// <p>This class encapsulates a <em>collection</em> of DOM elements, providing methods to filter members, or to perform collective
    /// actions upon the whole set.</p>
    /// <p>Although they are not listed, this class supports all of the methods of <see cref="Ext.dom.Element">Ext.dom.Element</see> and
    /// <see cref="Ext.fx.Anim">Ext.fx.Anim</see>. The methods from these classes will be performed on all the elements in this collection.</p>
    /// <p>Example:</p>
    /// <pre><code>var els = <see cref="Ext.ExtContext.select">Ext.select</see>("#some-el div.some-class");
    /// // or select directly from an existing element
    /// var el = <see cref="Ext.ExtContext.get">Ext.get</see>('some-el');
    /// el.select('div.some-class');
    /// els.setWidth(100); // all elements become 100 width
    /// els.hide(true); // all elements fade out and hide
    /// // or
    /// els.setWidth(100).hide(true);
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class CompositeElementLite : Ext.Base
    {
        /// <summary>
        /// The Array of DOM elements which this CompositeElement encapsulates.
        /// This will not <em>usually</em> be accessed in developers' code, but developers wishing to augment the capabilities
        /// of the CompositeElementLite class may use it when adding methods to the class.
        /// For example to add the <c>nextAll</c> method to the class to <strong>add</strong> all following siblings of selected elements,
        /// the code would be
        /// <code><see cref="Ext.ExtContext.override">Ext.override</see>(<see cref="Ext.dom.CompositeElementLite">Ext.dom.CompositeElementLite</see>, {
        /// nextAll: function() {
        /// var elements = this.elements, i, l = elements.length, n, r = [], ri = -1;
        /// // Loop through all elements in this Composite, accumulating
        /// // an Array of all siblings.
        /// for (i = 0; i &lt; l; i++) {
        /// for (n = elements[i].nextSibling; n; n = n.nextSibling) {
        /// r[++ri] = n;
        /// }
        /// }
        /// // Add all found siblings to this Composite
        /// return this.add(r);
        /// }
        /// });
        /// </code>
        /// Defaults to: <c>[]</c>
        /// </summary>
        public object elements{get;set;}
        /// <summary>
        /// true in this class to identify an object as an instantiated CompositeElement, or subclass thereof.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool isComposite{get;set;}
        /// <summary>
        /// Adds elements to this Composite object.
        /// </summary>
        /// <param name="els"><p>Either an Array of DOM elements to add, or another Composite
        /// object who's elements should be added.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.dom.CompositeElement">Ext.dom.CompositeElement</see></span><div><p>This Composite object.</p>
        /// </div>
        /// </returns>
        public Ext.dom.CompositeElement add(object els){return null;}
        /// <summary>
        /// Removes all elements.
        /// </summary>
        public void clear(){}
        /// <summary>
        /// Returns true if this composite contains the passed element
        /// </summary>
        /// <param name="el"><p>The id of an element, or an <see cref="Ext.dom.Element">Ext.Element</see>, or an HtmlElement to
        /// find within the composite collection.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public bool contains(object el){return false;}
        /// <summary>
        /// Calls the passed function for each element in this composite.
        /// </summary>
        /// <param name="fn"><p>The function to call.</p>
        /// <h3>Parameters</h3><ul><li><span>el</span> : <see cref="Ext.dom.Element">Ext.dom.Element</see><div><p>The current Element in the iteration. <strong>This is the flyweight
        /// (shared) <see cref="Ext.dom.Element">Ext.dom.Element</see> instance, so if you require a a reference to the dom node, use el.dom.</strong></p>
        /// </div></li><li><span>c</span> : <see cref="Ext.dom.CompositeElement">Ext.dom.CompositeElement</see><div><p>This Composite object.</p>
        /// </div></li><li><span>index</span> : <see cref="Number">Number</see><div><p>The zero-based index in the iteration.</p>
        /// </div></li></ul></param>
        /// <param name="scope"><p>The scope (this reference) in which the function is executed.
        /// Defaults to the Element.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.dom.CompositeElement">Ext.dom.CompositeElement</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.dom.CompositeElement each(System.Delegate fn, object scope=null){return null;}
        /// <summary>
        /// Clears this Composite and adds the elements passed.
        /// </summary>
        /// <param name="els"><p>Either an array of DOM elements, or another Composite from which
        /// to fill this Composite.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.dom.CompositeElement">Ext.dom.CompositeElement</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.dom.CompositeElement fill(object els){return null;}
        /// <summary>
        /// Filters this composite to only elements that match the passed selector.
        /// </summary>
        /// <param name="selector"><p>A string CSS selector or a comparison function. The comparison function will be
        /// called with the following arguments:</p>
        /// <ul><li><span>el</span> : <see cref="Ext.dom.Element">Ext.dom.Element</see><div><p>The current DOM element.</p>
        /// </div></li><li><span>index</span> : <see cref="Number">Number</see><div><p>The current index within the collection.</p>
        /// </div></li></ul></param>
        /// <returns>
        /// <span><see cref="Ext.dom.CompositeElement">Ext.dom.CompositeElement</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.dom.CompositeElement filter(object selector){return null;}
        /// <summary>
        /// Returns the first Element
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.dom.Element">Ext.dom.Element</see></span><div>
        /// </div>
        /// </returns>
        public Ext.dom.Element first(){return null;}
        /// <summary>
        /// Returns the number of elements in this Composite.
        /// </summary>
        /// <returns>
        /// <span><see cref="Number">Number</see></span><div>
        /// </div>
        /// </returns>
        public JsNumber getCount(){return null;}
        /// <summary>
        /// Copies all of the functions from Ext.dom.Element's prototype onto CompositeElementLite's prototype.
        /// This is called twice - once immediately below, and once again after additional Ext.dom.Element
        /// are added in Ext JS
        /// </summary>
        private void importElementMethods(){}
        /// <summary>
        /// Find the index of the passed element within the composite collection.
        /// </summary>
        /// <param name="el"><p>The id of an element, or an <see cref="Ext.dom.Element">Ext.dom.Element</see>, or an HtmlElement
        /// to find within the composite collection.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Number">Number</see></span><div><p>The index of the passed <see cref="Ext.dom.Element">Ext.dom.Element</see> in the composite collection, or -1 if not found.</p>
        /// </div>
        /// </returns>
        public JsNumber indexOf(object el){return null;}
        /// <summary>
        /// Returns a flyweight Element of the dom element object at the specified index
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.dom.Element">Ext.dom.Element</see></span><div>
        /// </div>
        /// </returns>
        public Ext.dom.Element item(JsNumber index){return null;}
        /// <summary>
        /// Returns the last Element
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.dom.Element">Ext.dom.Element</see></span><div>
        /// </div>
        /// </returns>
        public Ext.dom.Element last(){return null;}
        /// <summary>
        /// Removes the specified element(s).
        /// </summary>
        /// <param name="el"><p>The id of an element, the Element itself, the index of the
        /// element in this composite or an array of any of those.</p>
        /// </param>
        /// <param name="removeDom"><p>True to also remove the element from the document</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.dom.CompositeElement">Ext.dom.CompositeElement</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.dom.CompositeElement removeElement(object el, object removeDom=null){return null;}
        /// <summary>
        /// Replaces the specified element with the passed element.
        /// </summary>
        /// <param name="el"><p>The id of an element, the Element itself, the index of the
        /// element in this composite to replace.</p>
        /// </param>
        /// <param name="replacement"><p>The id of an element or the Element itself.</p>
        /// </param>
        /// <param name="domReplace"><p>True to remove and replace the element in the document too.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.dom.CompositeElement">Ext.dom.CompositeElement</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.dom.CompositeElement replaceElement(object el, object replacement, object domReplace=null){return null;}
        public CompositeElementLite(CompositeElementLiteConfig config){}
        public CompositeElementLite(){}
        public CompositeElementLite(params object[] args){}
    }
    #endregion
    #region CompositeElementLiteConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class CompositeElementLiteConfig : Ext.BaseConfig
    {
        public CompositeElementLiteConfig(params object[] args){}
    }
    #endregion
    #region CompositeElementLiteEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class CompositeElementLiteEvents : Ext.BaseEvents
    {
        public CompositeElementLiteEvents(params object[] args){}
    }
    #endregion
}
