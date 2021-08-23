using green_mage.command;
using green_mage.action;


namespace green_mage.command {
    public class GreenMageBasicMagicChargeAttackCommand : green_mage.command.GreenMageActionCommand {
        //! パラメータ
        private green_mage.action.GreenMageBasicMagicChargeAttackActionParameter _parameter = null;
        //! アクション
        private green_mage.action.GreenMageBasicMagicChargeAttackAction _action;
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="action"></param>
        public GreenMageBasicMagicChargeAttackCommand(in green_mage.action.GreenMageBasicMagicChargeAttackAction action) {
            this._action = action;
            _parameter = new GreenMageBasicMagicChargeAttackActionParameter();
        }
        /// <summary>
        /// 生成
        /// </summary>
        public void GenerateParameter() {
            _parameter = new GreenMageBasicMagicChargeAttackActionParameter();
        }
        /// <summary>
        /// 実行
        /// </summary>
        /// <param name="delta_time"></param>
        /// <returns></returns>
        public override green_mage.action.ActionResult Execute(float delta_time) {
            if(_parameter != null) {
                _parameter = null;
            } // if
            return _action.Execute(delta_time);
        }
    }
}