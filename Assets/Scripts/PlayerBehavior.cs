using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{

    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;
    public float JumpVelocity = 5f;
    private bool _isJumping;
    private float _vInput;
    private float _hInput;
    public float DistanceToGround = 0.1f;
    public LayerMask GroundLayer;
    private CapsuleCollider _col;
    public GameObject Bullet;
    public float BulletSpeed = 100f;
    private bool _isShooting;
    private Rigidbody _rb;

    void Start()
    {

        _rb = GetComponent<Rigidbody>();
        _col = GetComponent<CapsuleCollider>();
    }

    void Update()
    {
        _isShooting |= Input.GetMouseButtonDown(0);
        _isJumping |= Input.GetKeyDown(KeyCode.Space);
        _vInput = Input.GetAxis("Vertical") * MoveSpeed; // 4
        _hInput = Input.GetAxis("Horizontal") * RotateSpeed;
    }
    void FixedUpdate()
    {
        Vector3 rotation = Vector3.up * _hInput;

        Quaternion angleRot = Quaternion.Euler(rotation *
            Time.fixedDeltaTime);

        _rb.MovePosition(this.transform.position +
            this.transform.forward * _vInput * Time.fixedDeltaTime);

         _rb.MoveRotation(_rb.rotation * angleRot);
         if(IsGrounded() && _isJumping)
         {
            _rb.AddForce(Vector3.up * JumpVelocity, ForceMode.Impulse);
         }
         if(_isShooting){
           GameObject newBullet = Instantiate(Bullet,
                this.transform.position + new Vector3(1, 0, 0),
                   this.transform.rotation);
           Rigidbody BulletRB = newBullet.GetComponent<Rigidbody>();
           BulletRB.velocity = this.transform.forward * BulletSpeed;
         }
         _isShooting = false;
         _isJumping = false;
    }
    private bool IsGrounded(){
      Vector3 capsuleBottom = new Vector3(_col.bounds.center.x, _col.bounds.min.y, _col.bounds.center.z);
      bool grounded = Physics.CheckCapsule(_col.bounds.center, capsuleBottom, DistanceToGround, GroundLayer, QueryTriggerInteraction.Ignore);
      return grounded;
    }
}
