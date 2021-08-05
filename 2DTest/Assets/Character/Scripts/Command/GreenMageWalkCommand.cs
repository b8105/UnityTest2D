using green_mage.command;
using green_mage.action;


namespace green_mage.command {
    public class GreenMageWalkCommand : green_mage.command.GreenMageActionCommand {
        //! �p�����[�^
        private green_mage.action.GreenMageWalkActionParameter _parameter = null;
        //! �A�N�V����
        private green_mage.action.GreenMageWalkAction _action;

        /// <summary>
        /// �A�N�Z�b�T
        /// </summary>
        //public green_mage.action.GreenMageWalkActionParameter parameter {
        //    private get {
        //        return this._parameter;
        //    }
        //    set {
        //        this._parameter = parameter;
        //    }
        //}

        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        /// <param name="action"></param>
        public GreenMageWalkCommand(green_mage.action.GreenMageWalkAction action) {
            this._action = action;
            _parameter = new GreenMageWalkActionParameter();
        }

        /// <summary>
        /// ����
        /// </summary>
        public void GenerateParameter(float speed, green_mage.action.GreenMageWalkActionParameter.Direction direction) {
            this._parameter.speed = speed;
            this._parameter.direction = direction;
        }
        /// <summary>
        /// ���s
        /// </summary>
        /// <param name="delta_time"></param>
        /// <returns></returns>
        public override green_mage.action.ActionResult Execute(float delta_time) {
            //if(_parameter != null) {
                _action.SetParameter(ref _parameter);
              //  _parameter = null;
            //} // if
            return _action.Execute(delta_time);
        }
    }
}