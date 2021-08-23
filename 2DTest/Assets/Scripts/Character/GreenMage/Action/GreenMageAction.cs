using UnityEngine;
using green_mage.action;


namespace green_mage.action {
    public class GreenMageAction {
        //! ����
        protected Rigidbody2D _rigidbody;
        //! �X�v���C�g
        protected MageSpriteController _sprite_controller;
        //! �e
        protected green_mage.action.GreenMageRootAction _parent;
        public GreenMageAction(in green_mage.action.GreenMageRootAction root) {
            this._parent = root;
            this._rigidbody = _parent.GetComponent<Rigidbody2D>();
            this._sprite_controller = _parent.GetComponent<MageSpriteController>();
        }
    }
}