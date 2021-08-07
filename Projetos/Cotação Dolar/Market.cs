using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CotacaoDolar
{
    public class Market
    {
        //Quando criar um market ,sera criago uma instancia da moeda
        public Market()
        {
            this.Currency = new Currency();
        }

        [JsonProperty(PropertyName = "currencies")]
        public Currency Currency { get; set; }

    }
}
