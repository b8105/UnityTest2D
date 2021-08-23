using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using green_mage.state;

namespace green_mage.state {

    class GreenMageStateMachine {
        //! ���݂̏��
        private GreenMageActionState _current_state;
        //! �J�ډ\�ȏ��
        private Dictionary<action.ActionTypeName, GreenMageActionState> _status;

        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public GreenMageStateMachine() {
            _current_state = null;
            _status = new Dictionary<action.ActionTypeName, GreenMageActionState>();
        }

        /// <summary>
        /// �A�N�Z�b�T
        /// </summary>
        public GreenMageActionState current_state {
            get {
                return this._current_state;
            }
        }
        /// <summary>
        /// ����
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
        /// �o�^
        /// </summary>
        /// <param name="state"></param>
        public void RegisterState(in GreenMageActionState state) {
            this._status.Add(state.name, state);
        }
        /// <summary>
        /// �ύX
        /// </summary>
        /// <param name="name"></param>
        public void ChangeState(action.ActionTypeName name) {
            if(_current_state != null) {
                _current_state.Exit();
            } // if

            // ��Ԃ̕ύX
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