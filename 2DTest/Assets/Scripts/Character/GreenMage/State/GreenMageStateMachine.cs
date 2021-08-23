using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using green_mage.state;

namespace green_mage.state {

    class GreenMageStateMachine {
        //! 現在の状態
        private GreenMageActionState _current_state;
        //! 遷移可能な状態
        private Dictionary<action.ActionTypeName, GreenMageActionState> _status;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public GreenMageStateMachine() {
            _current_state = null;
            _status = new Dictionary<action.ActionTypeName, GreenMageActionState>();
        }

        /// <summary>
        /// アクセッサ
        /// </summary>
        public GreenMageActionState current_state {
            get {
                return this._current_state;
            }
        }
        /// <summary>
        /// 判定
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool IsEqual(action.ActionTypeName name) {
            if(_current_state.name == name) {
                return true;
            } // if
            return false;
        }
        /// <summary>
        /// 登録
        /// </summary>
        /// <param name="state"></param>
        public void RegisterState(in GreenMageActionState state) {
            this._status.Add(state.name, state);
        }
        /// <summary>
        /// 変更
        /// </summary>
        /// <param name="name"></param>
        public void ChangeState(action.ActionTypeName name) {
            if(_current_state != null) {
                _current_state.Exit();
            } // if

            // 状態の変更
            var next = _status[name];
            if(next != null) {
                _current_state = next;
                _current_state.Enter();
            } // if
            else {
                _current_state = null;
            } // else
        }
    }
}