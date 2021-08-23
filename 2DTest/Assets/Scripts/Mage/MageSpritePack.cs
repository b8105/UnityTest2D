using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MageSpritePack : MonoBehaviour {
    public enum SpriteType {
        Idle,
        Run,
        Crouch,
        MeleeAttack,
        Avoidance,
        Damage,
    }
    class MageSpriteData {
        public string path = null;
        public Vector2Int tex_size;
        public MageSpriteData(string str, Vector2Int size) {
            this.path = str;
            this.tex_size = size;
        }
    };

    private Dictionary<SpriteType, Sprite> _sprite_map = new Dictionary<SpriteType, Sprite>();
    private List<SpriteType> _key_list = new List<SpriteType>();
    private List<MageSpriteData> _mage_sprite_data_list = new List<MageSpriteData>();

    public MageSpritePack() {
        // generated and registered by external class
        _key_list.Add(SpriteType.Idle);
        _key_list.Add(SpriteType.Run);
        _key_list.Add(SpriteType.Crouch);
        _key_list.Add(SpriteType.MeleeAttack);
        _key_list.Add(SpriteType.Avoidance);
        _key_list.Add(SpriteType.Damage);

        // í«â¡èáçáÇÌÇπÇÈ
        _mage_sprite_data_list.Add(new MageSpriteData("Assets\\Sprites\\Character\\Mage\\green_mage_idle.png", new Vector2Int(256, 256)));
        _mage_sprite_data_list.Add(new MageSpriteData("Assets\\Sprites\\Character\\Mage\\green_mage_run.png", new Vector2Int(256, 256)));
        _mage_sprite_data_list.Add(new MageSpriteData("Assets\\Sprites\\Character\\Mage\\green_mage_crouch.png", new Vector2Int(256, 256)));
        _mage_sprite_data_list.Add(new MageSpriteData("Assets\\Sprites\\Character\\Mage\\green_mage_melee_attack.png", new Vector2Int(256, 256)));
        _mage_sprite_data_list.Add(new MageSpriteData("Assets\\Sprites\\Character\\Mage\\green_mage_avoidance.png", new Vector2Int(256, 256)));
        _mage_sprite_data_list.Add(new MageSpriteData("Assets\\Sprites\\Character\\Mage\\green_mage_damage.png", new Vector2Int(256, 256)));
    }
    void Generate() {
        int i = 0;
        foreach(var key in _key_list) {
            var data = _mage_sprite_data_list[i];
            var tex = ReadTexture(data.path, data.tex_size.x, data.tex_size.y);
            var sprite = Sprite.Create(
                tex,
                new Rect(0.0f, 0.0f, tex.width, tex.height),
                new Vector2(0.5f, 0.5f));
            sprite.name = key.ToString();
            _sprite_map.Add(key, sprite);
            i++;
        } // for
    }

    public Sprite GetResource(SpriteType key) {
        return this._sprite_map[key];
    }
    void Start() {
        this.Generate();
    }
    // Update is called once per frame
    void Update() {
    }

    byte[] ReadPngFile(string path) {
        FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
        BinaryReader bin = new BinaryReader(fileStream);
        byte[] values = bin.ReadBytes((int)bin.BaseStream.Length);

        bin.Close();
        return values;
    }

    Texture2D ReadTexture(string path, int width, int height) {
        byte[] readBinary = ReadPngFile(path);
        Texture2D texture = new Texture2D(width, height);
        texture.LoadImage(readBinary);
        return texture;
    }
}