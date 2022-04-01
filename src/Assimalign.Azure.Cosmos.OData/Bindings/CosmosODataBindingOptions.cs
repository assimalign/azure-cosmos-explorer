﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.OData.Edm;

namespace Assimalign.Azure.Cosmos.OData.Bindings
{
    internal sealed class CosmosODataBindingOptions<T>
        where T : class, new()
    {

        public string Route { get; set; }

        public string Method { get; set; }

        public Type BindingType { get; set; }

        public EdmModel Model { get; set; }

    }
}