using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostPlayerController : MonoBehaviour {
    private float _movement_input_direction;
    private float _movement_spped = 10.0f;
    private bool _is_facing_right = true;
    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    void Start() {
        _rigidbody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        this.CheckInput();
    }

    private void FixedUpdate() {
        this.ApplyMovement();
    }
    private void CheckInput() {
        _movement_input_direction = Input.GetAxisRaw("Horizontal");
    }
    private void CheckMovementDirection() {
        if(_is_facing_right && _movement_input_direction < 0) {
            Flip();
        } // if
        else if(_is_facing_right && _movement_input_direction > 0) {
            Flip();
        } // elses
    }
    private void ApplyMovement() {
        _rigidbody.velocity = new Vector2(_movement_spped * _movement_input_direction, _rigidbody.velocity.y);
    }

    private void Flip() {
        _is_facing_right = !_is_facing_right;
        this.transform.Rotate(0.0f, 180.0f, 0.0f);
    }
}
