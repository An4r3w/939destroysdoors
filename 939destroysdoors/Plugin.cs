using Exiled.API.Features;
using System;
using PlayerEvent = Exiled.Events.Handlers.Player;

namespace _939destroysdoors
{
     public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "An4r3w";

        public override string Name { get; } = "939destroysdoors";

        public override string Prefix { get; } = "939destroysdoors";

        public override Version RequiredExiledVersion { get; } = new Version(2, 0, 0);

        public override Version Version { get; } = new Version(1, 0, 0);

        internal EventHandlers EventHandlers { get; set; }


        public override void OnEnabled()
        {
            this.EventHandlers = new EventHandlers();

            PlayerEvent.InteractingDoor += EventHandlers.OnDoorInteract;
        }

        public override void OnDisabled()
        {
            this.EventHandlers = null;
        }

    }
}
