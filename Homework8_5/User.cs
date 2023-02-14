using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Homework8_5
{
    class User
    {


            [JsonInclude]
            public int ClientId { get; set; }
            [JsonInclude]
            public int OrderId { get; set; }

            [JsonInclude]
            public string DateTime { get; set; }

            [JsonInclude]
            public string Longitude { get; set; }

            [JsonInclude]
            public string Latitude { get; set; }





    }
}
