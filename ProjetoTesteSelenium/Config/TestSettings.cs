using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTesteSelenium.Config
{
    public class TestSettings
    {
        public string BaseUrl { get; set; } = string.Empty;
        public string Browser { get; set; } = "Chrome";
        public bool Headless { get; set; }
        public int Timeout { get; set; } = 30;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
