using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using green_mage.action;

public class MageSpriteController : MonoBehaviour {
    //! レンダラ－
    [SerializeField]
    private SpriteRenderer _sprite_renderer = null;
    //! リソース
    [SerializeField]
    private MageSpritePack _sprite_pack = null;
    //! マップ
    [SerializeField]
    private Dictionary<green_mage.action.ActionTypeName, MageSpritePack.SpriteType> _action_sprite_dictionary = new Dictionary<green_mage.action.ActionTypeName, MageSpritePack.SpriteType>();
    //! 右を向いている
    [SerializeField]
    private bool _is_facing_right = false;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public MageSpriteController() {
    }
    public bool IsFacingRight() {
        return this._is_facing_right;
    }

    // Start is called before the first frame update
    void Start() {
        _sprite_renderer = this.GetComponent<SpriteRenderer>();
        _sprite_pack = this.GetComponent<MageSpritePack>();
    }

    // Update is called once per frame
    void Update() {
    }
    public void AddActionSprite(green_mage.action.ActionTypeName action_type, MageSpritePack.SpriteType sprite_type) {
        _action_sprite_dictionary.Add(action_type, sprite_type);
    }
    public void ChangeSprite(green_mage.action.ActionTypeName action_type) {
        _sprite_renderer.sprite = _sprite_pack.GetResource(_action_sprite_dictionary[action_type]);
    }
    public void FlipX() {
        _is_facing_right = !_is_facing_right;
        _sprite_renderer.flipX = !_sprite_renderer.flipX;
    }
}