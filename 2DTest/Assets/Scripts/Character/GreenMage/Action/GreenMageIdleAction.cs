using UnityEngine;
using green_mage.action;


namespace green_mage.action {
    public class GreenMageIdleActionParameter {
        public enum Direction {
            None,
            Right,
            Left,
        }
        public Direction direction = Direction.None;
    };

    /// <summary>
    /// クラス
    /// </summary>
    public class GreenMageIdleAction :
        green_mage.action.GreenMageAction,
        green_mage.action.GreenMageActionable {
        //! 方向
        GreenMageIdleActionParameter.Direction _direction;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public GreenMageIdleAction(in GreenMageRootAction root) :
            base(root) {
            base._sprite_controller.AddActionSprite(this.GetTypeName(), MageSpritePack.SpriteType.Idle);
        }
        /// <summary>
        /// セッター
        /// </summary>
        /// <param name="direction"></param>
        public void SetDirection(GreenMageIdleActionParameter.Direction direction) {
            this._direction = direction;
        }
        /// <summary>
        /// ゲッター
        /// </summary>
        /// <returns></returns>
        public ActionTypeName GetTypeName() {
            return ActionTypeName.Idle;
        }
        /// <summary>
        /// 実行
        /// </summary>
        public ActionResult Execute(float delta_time) {
            var result = new ActionResult();
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