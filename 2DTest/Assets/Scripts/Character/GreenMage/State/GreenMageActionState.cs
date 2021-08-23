using green_mage.action;


namespace green_mage.state {
    public class GreenMageActionState {
        //! 名前
        private action.ActionTypeName _name;
        //! アクション
        private green_mage.action.GreenMageActionable _action;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public GreenMageActionState() {
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="action"></param>
        public GreenMageActionState(in green_mage.action.GreenMageActionable action) {
            this._action = action;
            this._name = this._action.GetTypeName();
        }
        /// <summary>
        /// アクセッサ
        /// </summary>
        public action.ActionTypeName name {
            get {
                return this._name;
            }
        }
        /// <summary>
        /// アクセッサ
        /// </summary>
        public green_mage.action.GreenMageActionable action {
            get {
                return this._action;
            }
        }
        /// <summary>
        /// 開始
        /// </summary>
        public void Enter() {
            this.action.Enter();
        }
        /// <summary>
        /// 終了
        /// </summary>
        public void Exit() {
            this.action.Exit();
        }
    }
}