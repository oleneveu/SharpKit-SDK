//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:42 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext
{
    #region XTemplateCompiler
    /// <inheritdocs />
    /// <summary>
    /// <p><strong>NOTE</strong> This is a private utility class for internal use by the framework. Don't rely on its existence.</p><p>This class compiles the XTemplate syntax into a function object. The function is used
    /// like so:</p>
    /// <pre><code> function (out, values, parent, xindex, xcount) {
    /// // out is the output array to store results
    /// // values, parent, xindex and xcount have their historical meaning
    /// }
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class XTemplateCompiler : XTemplateParser
    {
        public XTemplateCompiler(XTemplateCompilerConfig config){}
        public XTemplateCompiler(){}
        public XTemplateCompiler(params object[] args){}
    }
    #endregion
    #region XTemplateCompilerConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class XTemplateCompilerConfig : XTemplateParserConfig
    {
        public XTemplateCompilerConfig(params object[] args){}
    }
    #endregion
    #region XTemplateCompilerEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class XTemplateCompilerEvents : XTemplateParserEvents
    {
        public XTemplateCompilerEvents(params object[] args){}
    }
    #endregion
}
