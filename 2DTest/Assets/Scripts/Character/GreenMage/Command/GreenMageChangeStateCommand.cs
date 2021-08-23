using green_mage.command;
using green_mage.action;


namespace green_mage.command {
    public class GreenMageChangeStateCommand : green_mage.command.GreenMageActionCommand {
        private green_mage.action.ActionTypeName _next_state;
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        /// <param name="action"></param>
        public GreenMageChangeStateCommand(green_mage.action.ActionTypeName type) {
            this._next_state = type;
        }
        /// <summary>
        /// ���s
        /// </summary>
        /// <param name="delta_time"></param>
        /// <returns></returns>
        public override green_mage.action.ActionResult Execute(float delta_time) {
            var result = new green_mage.action.ActionResult();
            result.change = true;
            result.next = _next_state;
            return result;
        }
    }
}