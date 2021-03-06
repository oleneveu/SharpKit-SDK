//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:42 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.util
{
    #region Filter
    /// <inheritdocs />
    /// <summary>
    /// <p>Represents a filter that can be applied to a <see cref="Ext.util.MixedCollection">MixedCollection</see>. Can either simply
    /// filter on a property/value pair or pass in a filter function with custom logic. Filters are always used in the
    /// context of MixedCollections, though <see cref="Ext.data.Store">Store</see>s frequently create them when filtering and searching
    /// on their records. Example usage:</p>
    /// <pre><code>//set up a fictional MixedCollection containing a few people to filter on
    /// var allNames = new <see cref="Ext.util.MixedCollection">Ext.util.MixedCollection</see>();
    /// allNames.addAll([
    /// {id: 1, name: 'Ed',    age: 25},
    /// {id: 2, name: 'Jamie', age: 37},
    /// {id: 3, name: 'Abe',   age: 32},
    /// {id: 4, name: 'Aaron', age: 26},
    /// {id: 5, name: 'David', age: 32}
    /// ]);
    /// var ageFilter = new <see cref="Ext.util.Filter">Ext.util.Filter</see>({
    /// property: 'age',
    /// value   : 32
    /// });
    /// var longNameFilter = new <see cref="Ext.util.Filter">Ext.util.Filter</see>({
    /// filterFn: function(item) {
    /// return item.name.length &gt; 4;
    /// }
    /// });
    /// //a new MixedCollection with the 3 names longer than 4 characters
    /// var longNames = allNames.filter(longNameFilter);
    /// //a new MixedCollection with the 2 people of age 32:
    /// var youngFolk = allNames.filter(ageFilter);
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Filter : Ext.Base
    {
        /// <summary>
        /// True to allow any match - no regex start/end line anchors will be added.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool anyMatch;
        /// <summary>
        /// True to make the regex case sensitive (adds 'i' switch to regex).
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool caseSensitive;
        /// <summary>
        /// True to force exact match (^ and $ characters added to the regex). Ignored if anyMatch is true.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool exactMatch;
        /// <summary>
        /// A custom filter function which is passed each item in the Ext.util.MixedCollection in turn. Should return
        /// true to accept each item or false to reject it
        /// </summary>
        public System.Delegate filterFn;
        /// <summary>
        /// The property to filter on. Required unless a filterFn is passed
        /// </summary>
        public JsString property;
        /// <summary>
        /// Optional root property. This is mostly useful when filtering a Store, in which case we set the root to 'data' to
        /// make the filter pull the property out of the data object of each item
        /// </summary>
        public JsString root;
        /// <summary>
        /// Creates new Filter.
        /// </summary>
        /// <param name="config"><p>Config object</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div>
        /// </div>
        /// </returns>
        public Filter(object config=null){}
        /// <summary>
        /// Creates a filter function for the configured property/value/anyMatch/caseSensitive options for this Filter
        /// </summary>
        private void createFilterFn(){}
        /// <summary>
        /// Returns a regular expression based on the given value and matching options
        /// </summary>
        private void createValueMatcher(){}
        /// <summary>
        /// Returns the root property of the given item, based on the configured root property
        /// </summary>
        /// <param name="item"><p>The item</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>The root property of the object</p>
        /// </div>
        /// </returns>
        private object getRoot(object item){return null;}
        public Filter(Ext.util.FilterConfig config){}
        public Filter(params object[] args){}
    }
    #endregion
    #region FilterConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class FilterConfig : Ext.BaseConfig
    {
        /// <summary>
        /// True to allow any match - no regex start/end line anchors will be added.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool anyMatch;
        /// <summary>
        /// True to make the regex case sensitive (adds 'i' switch to regex).
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool caseSensitive;
        /// <summary>
        /// True to force exact match (^ and $ characters added to the regex). Ignored if anyMatch is true.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool exactMatch;
        /// <summary>
        /// A custom filter function which is passed each item in the Ext.util.MixedCollection in turn. Should return
        /// true to accept each item or false to reject it
        /// </summary>
        public System.Delegate filterFn;
        /// <summary>
        /// The property to filter on. Required unless a filterFn is passed
        /// </summary>
        public JsString property;
        /// <summary>
        /// Optional root property. This is mostly useful when filtering a Store, in which case we set the root to 'data' to
        /// make the filter pull the property out of the data object of each item
        /// </summary>
        public JsString root;
        public FilterConfig(params object[] args){}
    }
    #endregion
    #region FilterEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class FilterEvents : Ext.BaseEvents
    {
        public FilterEvents(params object[] args){}
    }
    #endregion
}
