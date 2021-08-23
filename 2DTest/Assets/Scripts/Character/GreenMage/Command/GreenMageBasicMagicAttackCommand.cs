using green_mage.command;
using green_mage.action;


namespace green_mage.command {
    public class GreenMageBasicMagicAttackCommand : green_mage.command.GreenMageActionCommand {
        //! �p�����[�^
        private green_mage.action.GreenMageBasicMagicAttackActionParameter _parameter = null;
        //! �A�N�V����
        private green_mage.action.GreenMageBasicMagicAttackAction _action;
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        /// <param name="action"></param>
        public GreenMageBasicMagicAttackCommand(in green_mage.action.GreenMageBasicMagicAttackAction action) {
            this._action = action;
            _parameter = new GreenMageBasicMagicAttackActionParameter();
        }
        /// <summary>
        /// ����
        /// </summary>
        public void GenerateParameter(float speed, green_mage.action.GreenMageBasicMagicAttackActionParameter.Direction direction) {
            _parameter = new GreenMageBasicMagicAttackActionParameter();
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