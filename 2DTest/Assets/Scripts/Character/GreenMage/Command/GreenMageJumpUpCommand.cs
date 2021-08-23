using green_mage.command;
using green_mage.action;


namespace green_mage.command {
    public class GreenMageJumpUpCommand : green_mage.command.GreenMageActionCommand {
        //! �p�����[�^
        private green_mage.action.GreenMageJumpUpActionParameter _parameter = null;
        //! �A�N�V����
        private green_mage.action.GreenMageJumpUpAction _action;

        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        /// <param name="action"></param>
        public GreenMageJumpUpCommand(in green_mage.action.GreenMageJumpUpAction action) {
            this._action = action;
            _parameter = new GreenMageJumpUpActionParameter();
        }

        /// <summary>
        /// ����
        /// </summary>
        public void GenerateParameter() {
        }
        /// <summary>
        /// ���s
        /// </summary>
        /// <param name="delta_time"></param>
        /// <returns></returns>
        public override green_mage.action.ActionResult Execute(float delta_time) {
            if(_parameter != null) {
                _action.SetParameter(_parameter);
                _parameter = null;
            } // if
            return _action.Execute(delta_time);
        }
    }
}