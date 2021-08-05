using green_mage.action;


namespace green_mage.state {
    public class GreenMageActionState {
        //! 名前
        action.ActionTypeName _name ;
        //! アクション
        green_mage.action.GreenMageAction _action ;

        public GreenMageActionState(green_mage.action.GreenMageAction action) {
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
        public green_mage.action.GreenMageAction action {
            get {
                return this._action;
            }
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public GreenMageActionState() {
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