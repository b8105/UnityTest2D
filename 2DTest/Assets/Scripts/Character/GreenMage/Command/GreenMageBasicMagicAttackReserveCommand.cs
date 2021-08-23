using green_mage.command;
using green_mage.action;


namespace green_mage.command {
    public class GreenMageBasicMagicAttackReserveCommand : green_mage.command.GreenMageActionCommand {
        //! �p�����[�^
        private green_mage.action.GreenMageBasicMagicAttackReserveActionParameter _parameter = null;
        //! �A�N�V����
        private green_mage.action.GreenMageBasicMagicAttackReserveAction _action;
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        /// <param name="action"></param>
        public GreenMageBasicMagicAttackReserveCommand(in green_mage.action.GreenMageBasicMagicAttackReserveAction action) {
            this._action = action;
            _parameter = new GreenMageBasicMagicAttackReserveActionParameter();
        }
        /// <summary>
        /// ����
        /// </summary>
        public void GenerateParameter(float speed, green_mage.action.GreenMageBasicMagicAttackReserveActionParameter.Direction direction) {
            _parameter = new GreenMageBasicMagicAttackReserveActionParameter();
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