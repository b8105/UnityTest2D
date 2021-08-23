using green_mage.command;
using green_mage.action;


namespace green_mage.command {
    public class GreenMageJumpDownCommand : green_mage.command.GreenMageActionCommand {
        //! パラメータ
        private green_mage.action.GreenMageJumpDownActionParameter _parameter = null;
        //! アクション
        private green_mage.action.GreenMageJumpDownAction _action;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="action"></param>
        public GreenMageJumpDownCommand(in green_mage.action.GreenMageJumpDownAction action) {
            this._action = action;
            _parameter = new GreenMageJumpDownActionParameter();
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