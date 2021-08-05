using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using green_mage.action;


namespace green_mage.action {
    public class GreenMageWalkActionParameter {
        public enum Direction {
            None,
            Right,
            Left,
        }
        public float speed;
        public Direction direction = Direction.None;
    };

    /// <summary>
    /// クラス
    /// </summary>
    public class GreenMageWalkAction : green_mage.action.GreenMageAction {
        private float _speed;
        private GreenMageRootAction _parent;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public GreenMageWalkAction(GreenMageRootAction parent) {
            _speed = 2.0f;
            _parent = parent;
        }
        /// <summary>
        /// 開始
        /// Start is called before the first frame update
        /// </summary>
        void Start() {
        }
        /// <summary>
        /// 更新
        /// Update is called once per frame
        /// </summary>
        void Update() {
        }


        /// <summary>
        /// セッター
        /// </summary>
        /// <param name="param"></param>
        public void SetParameter(ref GreenMageWalkActionParameter param) {
            this._speed = param.speed;
            if(param.direction == GreenMageWalkActionParameter.Direction.Left) {
                this._speed *= -1.0f;
            } // if
        }
        public ActionTypeName GetTypeName() {
            return ActionTypeName.Walk;
        }

        /// <summary>
        /// 実行
        /// </summary>
        public ActionResult Execute(float delta_time) {

            var result = new ActionResult();

            var velocity = new Vector3(_speed, 0.0f, 0.0f);
            _parent.GetComponent<Rigidbody>().velocity = velocity;
            /*
            if(Input.GetKey(KeyCode.RightArrow)) {
                var velocity = new Vector3(_speed, 0.0f, 0.0f);
                _parent.GetComponent<Rigidbody>().velocity = velocity;
            } // if
            else {
                var velocity = new Vector3(_speed, 0.0f, 0.0f);
                _parent.GetComponent<Rigidbody>().velocity = velocity;
            } // else
            */

            return result;
        }

        public void Enter() {
        }

        public void Exit() {
        }
    }
}