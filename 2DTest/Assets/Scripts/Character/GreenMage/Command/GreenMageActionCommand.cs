using green_mage.action;
using System.Runtime.InteropServices;

namespace green_mage.command {
    public class GreenMageActionCommand {
        public virtual green_mage.action.ActionResult Execute(float delta_time) {
            return new ActionResult();
        }
    }
}