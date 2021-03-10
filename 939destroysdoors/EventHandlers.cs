using Exiled.Events.EventArgs;
using Exiled.API.Features;
using Interactables.Interobjects.DoorUtils;

namespace _939destroysdoors
{
    public class EventHandlers
    {
        public void OnDoorInteract(InteractingDoorEventArgs ev)
        {
            if(ev.Player.Role == RoleType.Scp93953)
            {
                var door = ev.Door as IDamageableDoor;

                door.IsDestroyed = true;
            }

            else if(ev.Player.Role == RoleType.Scp93989)
            {
                var door = ev.Door as IDamageableDoor;

                door.IsDestroyed = true;
            }

        }
    }
}
