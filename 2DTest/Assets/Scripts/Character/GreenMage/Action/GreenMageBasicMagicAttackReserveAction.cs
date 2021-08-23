using UnityEngine;
using green_mage.action;


namespace green_mage.action {
    public class GreenMageBasicMagicAttackReserveActionParameter {
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
    public class GreenMageBasicMagicAttackReserveAction :
        green_mage.action.GreenMageAction,
        green_mage.action.GreenMageActionable {
        //! 時間
        [SerializeField]
        private float _attack_time = 0.0f;
        //! 時間
        [SerializeField]
        private float _attack_time_set = 0.0f;
        //! 時間
        [SerializeField]
        private float _attack_time_max = 3.0f;


        //! 方向
        GreenMageBasicMagicAttackReserveActionParameter.Direction _direction;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public GreenMageBasicMagicAttackReserveAction(in GreenMageRootAction root) :
            base(root) {
            base._sprite_controller.AddActionSprite(this.GetTypeName(), MageSpritePack.SpriteType.Idle);
        }
        /// <summary>
        /// セッター
        /// </summary>
        /// <param name="direction"></param>
        public void SetDirection(GreenMageBasicMagicAttackReserveActionParameter.Direction direction) {
            this._direction = direction;
        }
        /// <summary>
        /// ゲッター
        /// </summary>
        /// <returns></returns>
        public ActionTypeName GetTypeName() {
            return ActionTypeName.BasicMagicAttackReserve;
        }
        /// <summary>
        /// 実行
        /// </summary>
        public ActionResult Execute(float delta_time) {
            var result = new ActionResult();

            _attack_time += delta_time;

            if(_attack_time > _attack_time_max) {
                result.change = true;
                result.next = ActionTypeName.BasicMagicAttackCharge;
                _attack_time = 0.0f;
            } // if
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