using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LichPlayerController : MonoBehaviour {
    [SerializeField] private float _movement_speed = 10.0f;
    [SerializeField] private float _jump_force = 16.0f;
    [SerializeField] private float _ground_check_radius;
    [SerializeField] private LayerMask _waht_is_ground;
    [SerializeField] Transform _ground_check;

    [SerializeField] private int _amount_of_jumps_left;
    [SerializeField] private int _amount_of_jumps = 1;
    [SerializeField] private float _movement_input_direction;
    [SerializeField] private bool _is_facing_right = true;
    [SerializeField] private bool _is_walking = false;
    [SerializeField] private bool _is_ground = false;
    [SerializeField] private bool _can_jump = false;
    private Rigidbody2D _rigidbody;
    private Animator _animator;


    // Start is called before the first frame update
    void Start() {
        _rigidbody = this.GetComponent<Rigidbody2D>();
        _animator = this.GetComponent<Animator>();
        _amount_of_jumps_left = _amount_of_jumps;
    }

    // Update is called once per frame
    void Update() {
        this.CheckInput();
        this.CheckMovementDirection();
        this.UpdateAnimation();
        this.CheckIfCanJump();
    }

    private void FixedUpdate() {
        this.ApplyMovement();
        this.CheckSurrounding();
    }

    private void CheckInput() {
        _movement_input_direction = Input.GetAxisRaw("Horizontal");
        if(Input.GetButtonDown("Jump")) {
            this.Jump();
        } // if
    }

    private void CheckSurrounding() {
        _is_ground = Physics2D.OverlapCircle(
            _ground_check.transform.position,
            _ground_check_radius,
            _waht_is_ground);
    }
    private void CheckIfCanJump() {
        if(_is_ground && _rigidbody.velocity.y <= 0.0f) {
            _amount_of_jumps_left = _amount_of_jumps;
        } // if

        if(_amount_of_jumps_left <= 0.0f) {
            _can_jump = false;
        } // if
        else {
            _can_jump = true;
        } // else
    }
    private void CheckMovementDirection() {
        if(_is_facing_right && _movement_input_direction > 0) {
            Flip();
        } // if
        else if(!_is_facing_right && _movement_input_direction < 0) {
            Flip();
        } // else if

        if(_rigidbody.velocity.x != 0.0f) {
            _is_walking = true;
        } // if
        else {
            _is_walking = false;
        } // else
    }
    private void UpdateAnimation() {
        _animator.SetBool("is_walking", _is_walking);
    }
    private void ApplyMovement() {
        _rigidbody.velocity = new Vector2(_movement_speed * _movement_input_direction, _rigidbody.velocity.y);
    }
    private void Jump() {
        if(_can_jump) {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jump_force);
            _amount_of_jumps_left--;
        } // if
    }
    private void Flip() {
        _is_facing_right = !_is_facing_right;
        this.transform.Rotate(0.0f, 180.0f, 0.0f);
    }

    private void OnDrawGizmos() {
        Gizmos.DrawWireSphere(_ground_check.position, _ground_check_radius);
    }
}
