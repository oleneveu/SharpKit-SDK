﻿using System;
using System.Collections.Generic;
using System.Linq;


using SharpKit.Html;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Json, Export = false)]
    public class MeshLambertMaterialOptions
    {
        public JsNumber color { get; set; }
        public JsNumber emissive { get; set; }
    }
}