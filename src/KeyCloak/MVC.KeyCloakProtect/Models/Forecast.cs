﻿using System;

namespace MVC.KeyCloakProtect.Models
{
    public class Forecast
    {
        public DateTime date { get; set; }
        public int temperatureC { get; set; }
        public int temperatureF { get; set; }
        public string summary { get; set; }
    }

}
