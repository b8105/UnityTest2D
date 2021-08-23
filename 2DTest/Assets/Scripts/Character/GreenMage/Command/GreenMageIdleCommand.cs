using green_mage.command;
using green_mage.action;


namespace green_mage.command {
    public class GreenMageIdleCommand : green_mage.command.GreenMageActionCommand {
        //! �p�����[�^
        private green_mage.action.GreenMageIdleActionParameter _parameter = null;
        //! �A�N�V����
        private green_mage.action.GreenMageIdleAction _action;
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        /// <param name="action"></param>
        public GreenMageIdleCommand(in green_mage.action.GreenMageIdleAction action) {
            this._action = action;
            _parameter = new GreenMageIdleActionParameter();
        }
        /// <summary>
        /// ����
        /// </summary>
        public void GenerateParameter(float speed, green_mage.action.GreenMageIdleActionParameter.Direction direction) {
            _parameter = new GreenMageIdleActionParameter();
            this._parameter.direction = direction;
        }
        /// <summary>
        /// ���s
        /// </summary>
        /// <param name="delta_time"></param>
        /// <returns></returns>
        public override green_mage.action.ActionResult Execute(float delta_time) {
            if(_parameter != null) {
                _action.SetDirection(_parameter.direction);
                _parameter = null;
            } // if
            return _action.Execute(delta_time);
        }
    }
}