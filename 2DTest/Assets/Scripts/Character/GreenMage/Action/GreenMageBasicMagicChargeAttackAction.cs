using UnityEngine;
using green_mage.action;


namespace green_mage.action {
    public class GreenMageBasicMagicChargeAttackActionParameter {
    };
    /// <summary>
    /// �N���X
    /// </summary>
    public class GreenMageBasicMagicChargeAttackAction :
        green_mage.action.GreenMageAction,
        green_mage.action.GreenMageActionable {
        //! ����
        [SerializeField]
        private float _attack_time = 0.0f;
        //! ����
        [SerializeField]
        private float _attack_time_set = 0.0f;
        //! ����
        [SerializeField]
        private float _attack_time_max = 2.0f;
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public GreenMageBasicMagicChargeAttackAction(in GreenMageRootAction root) :
            base(root) {
            base._sprite_controller.AddActionSprite(this.GetTypeName(), MageSpritePack.SpriteType.MeleeAttack);
        }
        /// <summary>
        /// �Q�b�^�[
        /// </summary>
        /// <returns></returns>
        public ActionTypeName GetTypeName() {
            return ActionTypeName.BasicMagicChargeAttack;
        }
        /// <summary>
        /// ���s
        /// </summary>
        public ActionResult Execute(float delta_time) {
            var result = new ActionResult();

            _attack_time += delta_time;

            if(_attack_time > _attack_time_max) {
                result.change = true;
                result.next = ActionTypeName.Idle;
                _attack_time = 0.0f;
            } // if
            return result;
        }
        /// <summary>
        /// �J�n
        /// </summary>
        public void Enter() {
            _sprite_controller.ChangeSprite(this.GetTypeName());
        }
        /// <summary>
        /// �I��
        /// </summary>
        public void Exit() {
        }
    }
}