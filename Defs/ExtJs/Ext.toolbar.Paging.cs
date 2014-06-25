//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.toolbar
{
    #region Paging
    /// <inheritdocs />
    /// <summary>
    /// <p>As the number of records increases, the time required for the browser to render them increases. Paging is used to
    /// reduce the amount of data exchanged with the client. Note: if there are more records/rows than can be viewed in the
    /// available screen area, vertical scrollbars will be added.</p>
    /// <p>Paging is typically handled on the server side (see exception below). The client sends parameters to the server side,
    /// which the server needs to interpret and then respond with the appropriate data.</p>
    /// <p><see cref="Ext.toolbar.Paging">Ext.toolbar.Paging</see> is a specialized toolbar that is bound to a <see cref="Ext.data.Store">Ext.data.Store</see> and provides automatic
    /// paging control. This Component <see cref="Ext.data.Store.load">load</see>s blocks of data into the <see cref="Ext.toolbar.PagingConfig.store">store</see> by passing
    /// parameters used for paging criteria.</p>
    /// <p><p><i></i></p></p>
    /// <p>Paging Toolbar is typically used as one of the Grid's toolbars:</p>
    /// <pre><code>var itemsPerPage = 2;   // set the number of items you want per page
    /// var store = <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.data.Store">Ext.data.Store</see>', {
    /// id:'simpsonsStore',
    /// autoLoad: false,
    /// fields:['name', 'email', 'phone'],
    /// pageSize: itemsPerPage, // items per page
    /// proxy: {
    /// type: 'ajax',
    /// url: 'pagingstore.js',  // url that will load data with respect to start and limit params
    /// reader: {
    /// type: 'json',
    /// root: 'items',
    /// totalProperty: 'total'
    /// }
    /// }
    /// });
    /// // specify segment of data you want to load using params
    /// store.load({
    /// params:{
    /// start:0,
    /// limit: itemsPerPage
    /// }
    /// });
    /// <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.grid.Panel">Ext.grid.Panel</see>', {
    /// title: 'Simpsons',
    /// store: store,
    /// columns: [
    /// { header: 'Name',  dataIndex: 'name' },
    /// { header: 'Email', dataIndex: 'email', flex: 1 },
    /// { header: 'Phone', dataIndex: 'phone' }
    /// ],
    /// width: 400,
    /// height: 125,
    /// dockedItems: [{
    /// xtype: 'pagingtoolbar',
    /// store: store,   // same store GridPanel is using
    /// dock: 'bottom',
    /// displayInfo: true
    /// }],
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>()
    /// });
    /// </code></pre>
    /// <p>To use paging, you need to set a pageSize configuration on the Store, and pass the paging requirements to
    /// the server when the store is first loaded.</p>
    /// <pre><code>store.load({
    /// params: {
    /// // specify params for the first page load if using paging
    /// start: 0,
    /// limit: myPageSize,
    /// // other params
    /// foo:   'bar'
    /// }
    /// });
    /// </code></pre>
    /// <p>If using <see cref="Ext.data.StoreConfig.autoLoad">store's autoLoad</see> configuration:</p>
    /// <pre><code>var myStore = <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.data.Store">Ext.data.Store</see>', {
    /// <see cref="Ext.data.StoreConfig.autoLoad">autoLoad</see>: {start: 0, limit: 25},
    /// ...
    /// });
    /// </code></pre>
    /// <p>The packet sent back from the server would have this form:</p>
    /// <pre><code>{
    /// "success": true,
    /// "results": 2000,
    /// "rows": [ // ***Note:** this must be an Array
    /// { "id":  1, "name": "Bill", "occupation": "Gardener" },
    /// { "id":  2, "name":  "Ben", "occupation": "Horticulturalist" },
    /// ...
    /// { "id": 25, "name":  "Sue", "occupation": "Botanist" }
    /// ]
    /// }
    /// </code></pre>
    /// <h2>Paging with Local Data</h2>
    /// <p>Paging can also be accomplished with local data using extensions:</p>
    /// <ul>
    /// <li><i>Ext.ux.data.PagingStore</i></li>
    /// <li>Paging Memory Proxy (examples/ux/PagingMemoryProxy.js)</li>
    /// </ul>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Paging : Toolbar, Ext.util.Bindable
    {
        /// <summary>
        /// Customizable piece of the default paging text. Note that this string is formatted using
        /// {0} as a token that is replaced by the number of total pages. This token should be preserved when overriding this
        /// string if showing the total page count is desired.
        /// Defaults to: <c>&quot;of {0}&quot;</c>
        /// </summary>
        public JsString afterPageText;
        /// <summary>
        /// The text displayed before the input item.
        /// Defaults to: <c>&quot;Page&quot;</c>
        /// </summary>
        public JsString beforePageText;
        /// <summary>
        /// true to display the displayMsg
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool displayInfo;
        /// <summary>
        /// The paging status message to display. Note that this string is
        /// formatted using the braced numbers {0}-{2} as tokens that are replaced by the values for start, end and total
        /// respectively. These tokens should be preserved when overriding this string if showing those values is desired.
        /// Defaults to: <c>&quot;Displaying {0} - {1} of {2}&quot;</c>
        /// </summary>
        public JsString displayMsg;
        /// <summary>
        /// The message to display when no records are found.
        /// Defaults to: <c>&quot;No data to display&quot;</c>
        /// </summary>
        public JsString emptyMsg;
        /// <summary>
        /// The quicktip text displayed for the first page button.
        /// Note: quick tips must be initialized for the quicktip to show.
        /// Defaults to: <c>&quot;First Page&quot;</c>
        /// </summary>
        public JsString firstText;
        /// <summary>
        /// The width in pixels of the input field used to display and change the current page number.
        /// Defaults to: <c>30</c>
        /// </summary>
        public JsNumber inputItemWidth;
        /// <summary>
        /// The quicktip text displayed for the last page button.
        /// Note: quick tips must be initialized for the quicktip to show.
        /// Defaults to: <c>&quot;Last Page&quot;</c>
        /// </summary>
        public JsString lastText;
        /// <summary>
        /// The quicktip text displayed for the next page button.
        /// Note: quick tips must be initialized for the quicktip to show.
        /// Defaults to: <c>&quot;Next Page&quot;</c>
        /// </summary>
        public JsString nextText;
        /// <summary>
        /// true to insert any configured items before the paging buttons.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool prependButtons;
        /// <summary>
        /// The quicktip text displayed for the previous page button.
        /// Note: quick tips must be initialized for the quicktip to show.
        /// Defaults to: <c>&quot;Previous Page&quot;</c>
        /// </summary>
        public JsString prevText;
        /// <summary>
        /// The quicktip text displayed for the Refresh button.
        /// Note: quick tips must be initialized for the quicktip to show.
        /// Defaults to: <c>&quot;Refresh&quot;</c>
        /// </summary>
        public JsString refreshText;
        /// <summary>
        /// The Ext.data.Store the paging toolbar should use as its data source.
        /// </summary>
        public Ext.data.Store store;
        /// <summary>
        /// Binds the paging toolbar to the specified Ext.data.Store (deprecated)
        /// </summary>
        /// <param name="store"><p>The data store to bind</p>
        /// </param>
        public void bind(Ext.data.Store store){}
        /// <summary>
        /// Binds a store to this instance.
        /// </summary>
        /// <param name="store"><p>The store to bind or ID of the store.
        /// When no store given (or when <c>null</c> or <c>undefined</c> passed), unbinds the existing store.</p>
        /// </param>
        /// <param name="initial"><p>True to not remove listeners from existing store.</p>
        /// <p>Defaults to: <c>false</c></p></param>
        public virtual void bindStore(object store=null, object initial=null){}
        /// <summary>
        /// Binds listeners for this component to the store. By default it will add
        /// anything bound by the getStoreListeners method, however it can be overridden
        /// in a subclass to provide any more complicated handling.
        /// </summary>
        /// <param name="store"><p>The store to bind to</p>
        /// </param>
        public virtual void bindStoreListeners(Ext.data.AbstractStore store){}
        /// <summary>
        /// Refresh the current page, has the same effect as clicking the 'refresh' button.
        /// </summary>
        public void doRefresh(){}
        /// <summary>
        /// Gets the standard paging items in the toolbar
        /// </summary>
        private void getPagingItems(){}
        /// <summary>
        /// Gets the current store instance.
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.data.AbstractStore">Ext.data.AbstractStore</see></span><div><p>The store, null if one does not exist.</p>
        /// </div>
        /// </returns>
        public virtual Ext.data.Store getStore(){return null;}
        /// <summary>
        /// Gets the listeners to bind to a new store.
        /// </summary>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>The listeners to be bound to the store in object literal form. The scope
        /// may be omitted, it is assumed to be the current instance.</p>
        /// </div>
        /// </returns>
        public virtual object getStoreListeners(){return null;}
        /// <summary>
        /// Move to the first page, has the same effect as clicking the 'first' button.
        /// </summary>
        public void moveFirst(){}
        /// <summary>
        /// Move to the last page, has the same effect as clicking the 'last' button.
        /// </summary>
        public void moveLast(){}
        /// <summary>
        /// Move to the next page, has the same effect as clicking the 'next' button.
        /// </summary>
        public void moveNext(){}
        /// <summary>
        /// Move to the previous page, has the same effect as clicking the 'previous' button.
        /// </summary>
        public void movePrevious(){}
        /// <summary>
        /// Template method, it is called when a new store is bound
        /// to the current instance.
        /// </summary>
        /// <param name="store"><p>The store being bound</p>
        /// </param>
        /// <param name="initial"><p>True if this store is being bound as initialization of the instance.</p>
        /// </param>
        public virtual void onBindStore(Ext.data.AbstractStore store, bool initial){}
        /// <summary>
        /// Template method, it is called when an existing store is unbound
        /// from the current instance.
        /// </summary>
        /// <param name="store"><p>The store being unbound</p>
        /// </param>
        /// <param name="initial"><p>True if this store is being bound as initialization of the instance.</p>
        /// </param>
        public virtual void onUnbindStore(Ext.data.AbstractStore store, bool initial){}
        /// <summary>
        /// Unbinds the paging toolbar from the specified Ext.data.Store (deprecated)
        /// </summary>
        /// <param name="store"><p>The data store to unbind</p>
        /// </param>
        public void unbind(Ext.data.Store store){}
        /// <summary>
        /// Unbinds listeners from this component to the store. By default it will remove
        /// anything bound by the bindStoreListeners method, however it can be overridden
        /// in a subclass to provide any more complicated handling.
        /// </summary>
        /// <param name="store"><p>The store to unbind from</p>
        /// </param>
        public virtual void unbindStoreListeners(Ext.data.AbstractStore store){}
        public Paging(PagingConfig config){}
        public Paging(){}
        public Paging(params object[] args){}
    }
    #endregion
    #region PagingConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class PagingConfig : ToolbarConfig
    {
        /// <summary>
        /// Customizable piece of the default paging text. Note that this string is formatted using
        /// {0} as a token that is replaced by the number of total pages. This token should be preserved when overriding this
        /// string if showing the total page count is desired.
        /// Defaults to: <c>&quot;of {0}&quot;</c>
        /// </summary>
        public JsString afterPageText;
        /// <summary>
        /// The text displayed before the input item.
        /// Defaults to: <c>&quot;Page&quot;</c>
        /// </summary>
        public JsString beforePageText;
        /// <summary>
        /// true to display the displayMsg
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool displayInfo;
        /// <summary>
        /// The paging status message to display. Note that this string is
        /// formatted using the braced numbers {0}-{2} as tokens that are replaced by the values for start, end and total
        /// respectively. These tokens should be preserved when overriding this string if showing those values is desired.
        /// Defaults to: <c>&quot;Displaying {0} - {1} of {2}&quot;</c>
        /// </summary>
        public JsString displayMsg;
        /// <summary>
        /// The message to display when no records are found.
        /// Defaults to: <c>&quot;No data to display&quot;</c>
        /// </summary>
        public JsString emptyMsg;
        /// <summary>
        /// The quicktip text displayed for the first page button.
        /// Note: quick tips must be initialized for the quicktip to show.
        /// Defaults to: <c>&quot;First Page&quot;</c>
        /// </summary>
        public JsString firstText;
        /// <summary>
        /// The width in pixels of the input field used to display and change the current page number.
        /// Defaults to: <c>30</c>
        /// </summary>
        public JsNumber inputItemWidth;
        /// <summary>
        /// The quicktip text displayed for the last page button.
        /// Note: quick tips must be initialized for the quicktip to show.
        /// Defaults to: <c>&quot;Last Page&quot;</c>
        /// </summary>
        public JsString lastText;
        /// <summary>
        /// The quicktip text displayed for the next page button.
        /// Note: quick tips must be initialized for the quicktip to show.
        /// Defaults to: <c>&quot;Next Page&quot;</c>
        /// </summary>
        public JsString nextText;
        /// <summary>
        /// true to insert any configured items before the paging buttons.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool prependButtons;
        /// <summary>
        /// The quicktip text displayed for the previous page button.
        /// Note: quick tips must be initialized for the quicktip to show.
        /// Defaults to: <c>&quot;Previous Page&quot;</c>
        /// </summary>
        public JsString prevText;
        /// <summary>
        /// The quicktip text displayed for the Refresh button.
        /// Note: quick tips must be initialized for the quicktip to show.
        /// Defaults to: <c>&quot;Refresh&quot;</c>
        /// </summary>
        public JsString refreshText;
        /// <summary>
        /// The Ext.data.Store the paging toolbar should use as its data source.
        /// </summary>
        public Ext.data.Store store;
        public PagingConfig(params object[] args){}
    }
    #endregion
    #region PagingEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class PagingEvents : ToolbarEvents
    {
        /// <summary>
        /// Fires just before the active page is changed. Return false to prevent the active page from being changed.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="page"><p>The page number that will be loaded on change</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforechange(Paging @this, JsNumber page, object eOpts){}
        /// <summary>
        /// Fires after the active page has been changed.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="pageData"><p>An object that has these properties:</p>
        /// <ul>
        /// <li><p><c>total</c> : Number</p>
        /// <p>The total number of records in the dataset as returned by the server</p></li>
        /// <li><p><c>currentPage</c> : Number</p>
        /// <p>The current page number</p></li>
        /// <li><p><c>pageCount</c> : Number</p>
        /// <p>The total number of pages (calculated from the total number of records in the dataset as returned by the
        /// server and the current <see cref="Ext.data.StoreConfig.pageSize">pageSize</see>)</p></li>
        /// <li><p><c>toRecord</c> : Number</p>
        /// <p>The starting record index for the current page</p></li>
        /// <li><p><c>fromRecord</c> : Number</p>
        /// <p>The ending record index for the current page</p></li>
        /// </ul>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void change(Paging @this, object pageData, object eOpts){}
        public PagingEvents(params object[] args){}
    }
    #endregion
}