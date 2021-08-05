using green_mage.action;
using green_mage.command;


namespace green_mage.creational {
    public class GreenMageWalkActionCommandFactory {
        //! アクション
        public green_mage.action.GreenMageWalkAction _action;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="action"></param>
        public GreenMageWalkActionCommandFactory(green_mage.action.GreenMageWalkAction action) {
            this._action = action;
        }
        /// <summary>
        /// 作成
        /// </summary>
        /// <returns></returns>
        public GreenMageWalkCommand Create() {
            return new GreenMageWalkCommand(this._action);
        }
    }
}