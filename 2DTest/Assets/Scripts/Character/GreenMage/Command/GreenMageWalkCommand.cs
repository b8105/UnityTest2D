using green_mage.command;
using green_mage.action;


namespace green_mage.command {
    public class GreenMageWalkCommand : green_mage.command.GreenMageActionCommand {
        //! �p�����[�^
        private green_mage.action.GreenMageWalkActionParameter _parameter = null;
        //! �A�N�V����
        private green_mage.action.GreenMageWalkAction _action;
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        /// <param name="action"></param>
        public GreenMageWalkCommand(in green_mage.action.GreenMageWalkAction action) {
            this._action = action;
            _parameter = new GreenMageWalkActionParameter();
        }
        /// <summary>
        /// ����
        /// </summary>
        public void GenerateParameter(float speed, green_mage.action.GreenMageWalkActionParameter.Direction direction) {
            _parameter = new GreenMageWalkActionParameter();
            this._parameter.speed = speed;
            this._parameter.direction = direction;
        }
        /// <summary>
        /// ���s
        /// </summary>
        /// <param name="delta_time"></param>
        /// <returns></returns>
        public override green_mage.action.ActionResult Execute(float delta_time) {
            if(_parameter != null) {
                _action.SetSpeed(_parameter.speed);
                _action.SetDirection(_parameter.direction);
                _parameter = null;
            } // if
            return _action.Execute(delta_time);
        }
    }
}