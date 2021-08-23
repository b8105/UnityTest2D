using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using green_mage.action;
using green_mage.command;
using green_mage.input;


namespace green_mage.input {
    public class GreenMageWalkActionPlayerInput : green_mage.input.GreenMageActionPlayerInput {
        //! アクション
        public green_mage.action.GreenMageWalkAction _action;
        //! ジャンプ
        public green_mage.input.GreenMageJumpUpActionPlayerInput _jump_up;
        //! 優先度別コマンド生成
        List<CommandFunc> _command_delegates = new List<CommandFunc>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public GreenMageWalkActionPlayerInput() {
        }

        private green_mage.command.GreenMageActionCommand CreateCommandRight() {
            var command = new GreenMageWalkCommand(this._action);

            float speed = 2.0f;
            var direction = GreenMageWalkActionParameter.Direction.Right;
            command.GenerateParameter(speed, direction);

            return command;
        }
        private green_mage.command.GreenMageActionCommand CreateCommandLeft() {
            var command = new GreenMageWalkCommand(this._action);

            float speed = 2.0f;
            var direction = GreenMageWalkActionParameter.Direction.Left;
            command.GenerateParameter(speed, direction);

            return command;
        }
        private green_mage.command.GreenMageActionCommand CreateCommandChangeToIdle() {
            var command = new GreenMageChangeStateCommand(green_mage.action.ActionTypeName.Idle);
            return command;
        }
        /// <summary>
        /// 登録
        /// </summary>
        /// <param name="action"></param>
        public void RegisterAction(in green_mage.action.GreenMageWalkAction action) {
            this._action = action;
        }
        /// <summary>
        /// 登録
        /// </summary>
        /// <param name="input"></param>
        public void RegisterInput(in green_mage.input.GreenMageJumpUpActionPlayerInput input) {
            this._jump_up = input;
        }
        /// <summary>
        /// ハンドラ
        /// </summary>
        /// <returns></returns>
        public green_mage.command.GreenMageActionCommand InputHandler() {
            green_mage.command.GreenMageActionCommand command = null;
            _command_delegates.Clear();
            
            {
                var func = new CommandFunc(0, new CreateCommand(CreateCommandChangeToIdle));
                _command_delegates.Add(func);
            }
            if(Input.GetKey(KeyCode.RightArrow)) {
                var func = new CommandFunc(1, new CreateCommand(CreateCommandRight));
                _command_delegates.Add(func);
            } // if
            if(Input.GetKey(KeyCode.LeftArrow)) {
                var func = new CommandFunc(1, new CreateCommand(CreateCommandLeft));
                _command_delegates.Add(func);
            } // else

            var temp = _command_delegates.OrderByDescending(x => x.priority);
            return command = temp.ToList()[0].func();
        }
    }
}