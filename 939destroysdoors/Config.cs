using Exiled.API.Interfaces;
using System.ComponentModel;

namespace _939destroysdoors
{
    public class Config : IConfig
    {
        [Description("Toggles the plugin")]
        public bool IsEnabled { get; set; } = true;
    }
}
