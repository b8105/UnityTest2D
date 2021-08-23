using UnityEngine;
using green_mage.action;
using green_mage.command;
using green_mage.input;


namespace green_mage.input {
    public class GreenMageJumpDownActionPlayerInput : green_mage.input.GreenMageActionPlayerInput {
        //! アクション
        public green_mage.action.GreenMageJumpDownAction _action;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="action"></param>
        public GreenMageJumpDownActionPlayerInput() {
        }
        /// <summary>
        /// 登録
        /// </summary>
        /// <param name="action"></param>
        public void RegisterAction(in green_mage.action.GreenMageJumpDownAction action) {
            this._action = action;
        }
        /// <summary>
        /// ハンドラ
        /// </summary>
        /// <returns></returns>
        public green_mage.command.GreenMageActionCommand InputHandler() {
            var command = new GreenMageJumpDownCommand(this._action);
            if(Input.GetKey(KeyCode.DownArrow)) {
            } // if
            command.GenerateParameter();
            return command;
        }
    }
}