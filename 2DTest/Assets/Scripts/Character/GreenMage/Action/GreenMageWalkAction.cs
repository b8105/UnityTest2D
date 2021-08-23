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
    public class GreenMageWalkAction :
        green_mage.action.GreenMageAction,
        green_mage.action.GreenMageActionable {
        //! 速さ
        private float _speed;
        //! 方向
        GreenMageWalkActionParameter.Direction _direction;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public GreenMageWalkAction(in GreenMageRootAction root) : 
            base(root) {
            base._sprite_controller.AddActionSprite(this.GetTypeName(), MageSpritePack.SpriteType.Run);
            _speed = 2.0f;
        }
        /// <summary>
        /// セッター
        /// </summary>
        /// <param name="param"></param>
        public void SetSpeed(float speed) {
            this._speed = speed;
        }
        /// <summary>
        /// セッター
        /// </summary>
        /// <param name="direction"></param>
        public void SetDirection(GreenMageWalkActionParameter.Direction direction) {
            this._direction = direction;
        }
        /// <summary>
        /// ゲッター
        /// </summary>
        /// <returns></returns>
        public ActionTypeName GetTypeName() {
            return ActionTypeName.Walk;
        }
        /// <summary>
        /// 実行
        /// </summary>
        public ActionResult Execute(float delta_time) {
            var result = new ActionResult();


            if(_sprite_controller.IsFacingRight() && _direction == GreenMageWalkActionParameter.Direction.Left) {
                _sprite_controller.FlipX();
            } // if
            else if(!_sprite_controller.IsFacingRight() && _direction == GreenMageWalkActionParameter.Direction.Right) {
                _sprite_controller.FlipX();
            } // else if


            float speed = 0.0f;
            if(_direction == GreenMageWalkActionParameter.Direction.Right) {
                speed = _speed;
            } // if
            else if(_direction == GreenMageWalkActionParameter.Direction.Left) {
                speed = -_speed;
            } // if

            var velocity = new Vector3(speed, 0.0f, 0.0f);
            _rigidbody.velocity = velocity;
            return result;
        }
        /// <summary>
        /// 開始
        /// </summary>
        public void Enter() {
            _sprite_controller.ChangeSprite(this.GetTypeName());
        }
        /// <summary>
        /// 終了
        /// </summary>
        public void Exit() {
        }
    }
}