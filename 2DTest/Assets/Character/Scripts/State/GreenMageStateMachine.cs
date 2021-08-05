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
        public void RegisterState(GreenMageActionState state) {
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



////! 現在の状態
//std::shared_ptr < base::behavioral::State > _current_state;
////! 現在の状態
////std::vector<std::shared_ptr<base::core::State>> _stack;
////! 遷移可能な状態
//std::unordered_map < std::string, std::shared_ptr < base::behavioral::State >> _status;
//public:
//    /// <summary>
//    /// ゲッター
//    /// </summary>
//    /// <param name=""></param>
//    /// <returns></returns>
//    std::string_view GetCurrentStateName(void) const;
///// <summary>
///// 判定
///// </summary>
///// <param name=""></param>
///// <returns></returns>
//bool EnableState(void) const;
///// <summary>
///// 登録
///// </summary>
///// <typeparam name="T"></typeparam>
///// <typeparam name="...Args"></typeparam>
///// <param name="...params"></param>
//template < typename T, typename... Args >
//  void RegisterState(Args && ... params) {
//    auto ptr = std::make_shared<T>(std::forward<Args>(params)...);
//    _status.emplace(ptr->GetName(), ptr);
//}
///// <summary>
///// 登録
///// </summary>
///// <param name="ptr"></param>
//void RegisterState(const std::shared_ptr<base::behavioral::State>& ptr);
///// <summary>
///// 変更
///// </summary>
///// <param name="name"></param>
//void ChangeState(const std::string& name);
///// <summary>
///// 追加
///// </summary>
///// <param name="name"></param>
////void PushState(const std::string& name);
///// <summary>
///// 削除
///// </summary>
///// <param name=""></param>
////void PopState(void);
///// <summary>
///// 更新
///// </summary>
///// <param name="delta_time"></param>
//void Update(float delta_time);
///// <summary>
///// 解放
///// </summary>
///// <param name=""></param>
//void Release(void);

//#include "StateMachine.h"


//std::string_view base::behavioral::StateMachine::GetCurrentStateName(void) const {
//    return _current_state->GetName();
//}

//bool base::behavioral::StateMachine::EnableState(void) const {
//    return _current_state.get();
//}

//void base::behavioral::StateMachine::RegisterState(const std::shared_ptr<base::behavioral::State>& ptr) {
//    _ASSERT_EXPR(std::strlen(ptr->GetName().data()) != 0, L"Stateに名前がありません");
//    _status.emplace(ptr->GetName(), ptr);
//}

//void base::behavioral::StateMachine::ChangeState(const std::string& name) {
//    //    _stack.clear();
//    // 現在の状態を終了する
//    if(_current_state) {
//        _current_state->Exit();
//    } // if
//    // 状態の変更
//    auto it = _status.find(name);
//    if(it != _status.end()) {
//        _current_state = it->second;
//        _current_state->Enter();
//    } // if
//    else {
//        _current_state = nullptr;
//    } // else
//}

///*
//void base::behavioral ::StateMachine::PushState(const std::string& name) {
//    _stack.push_back(_status.at(name));
//    _current_state = _stack.back();
//}

//void base::behavioral ::StateMachine::PopState(void) {
//    _stack.pop_back();
//}
//*/

//void base::behavioral::StateMachine::Update(float delta_time) {
//    if(!_current_state) {
//        return;
//    } // if
//    _current_state->Update(delta_time);
//}

//void base::behavioral::StateMachine::Release(void) {
//    _current_state.reset();
//    for(auto & state : _status) {
//        state.second.reset();
//    } // for
//    _status.clear();
//}