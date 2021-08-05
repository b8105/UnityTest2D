using System;
using System.Reflection;
using green_mage.action;
using green_mage.command;


namespace green_mage.creational {
    public class GreenMageActionCommandFactory<Action, Command> {
        //! アクション
        public Action _action;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="action"></param>
        public GreenMageActionCommandFactory(Action action) {
            this._action = action;
        }
        /// <summary>
        /// 作成
        /// </summary>
        /// <returns></returns>
        //public Command Create() {
            //var command = new Command();
            //command.RegisterAction(ref _action);
            //return command;
        //}
    }
}