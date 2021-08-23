using green_mage.command;
using green_mage.action;


namespace green_mage.command {
    public class GreenMageJumpUpCommand : green_mage.command.GreenMageActionCommand {
        //! パラメータ
        private green_mage.action.GreenMageJumpUpActionParameter _parameter = null;
        //! アクション
        private green_mage.action.GreenMageJumpUpAction _action;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="action"></param>
        public GreenMageJumpUpCommand(in green_mage.action.GreenMageJumpUpAction action) {
            this._action = action;
            _parameter = new GreenMageJumpUpActionParameter();
        }

        /// <summary>
        /// 生成
        /// </summary>
        public void GenerateParameter() {
        }
        /// <summary>
        /// 実行
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