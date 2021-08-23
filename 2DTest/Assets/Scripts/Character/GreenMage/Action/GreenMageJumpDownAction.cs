using green_mage.action;


namespace green_mage.action {
    public class GreenMageJumpDownActionParameter {
    };
    /// <summary>
    /// クラス
    /// </summary>
    public class GreenMageJumpDownAction :
        green_mage.action.GreenMageAction,
        green_mage.action.GreenMageActionable {

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public GreenMageJumpDownAction(in GreenMageRootAction root) :
            base(root) {
        }
        /// <summary>
        /// セッター
        /// </summary>
        /// <param name="param"></param>
        public void SetParameter(in GreenMageJumpDownActionParameter param) {
        }
        /// <summary>
        /// ゲッター
        /// </summary>
        /// <returns></returns>
        public ActionTypeName GetTypeName() {
            return ActionTypeName.JumpDown;
        }
        /// <summary>
        /// 実行
        /// </summary>
        public ActionResult Execute(float delta_time) {
            var result = new ActionResult();
            return result;
        }
        /// <summary>
        /// 開始
        /// </summary>
        public void Enter() {
        }
        /// <summary>
        /// 終了
        /// </summary>
        public void Exit() {
        }
    }
}