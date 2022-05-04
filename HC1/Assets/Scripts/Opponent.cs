using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opponent : MonoBehaviour
{
        private Rigidbody _rigidbody;
        [SerializeField] private Animator _animator;
        [SerializeField] private float _moveSpeed;
        [SerializeField] private float time;
        private float _timeLeft = 0f;
        private bool _timerOn = false;

        private float x, z;

        private void Start()
        {
            _rigidbody = gameObject.GetComponent<Rigidbody>();
            _timeLeft = time;
            _timerOn = true;
        }

        private void FixedUpdate()
        {            
            if (_timerOn)
            {
                if (_timeLeft > 0)
                {
                    _timeLeft -= Time.deltaTime;                    
                } else
                {
                    _timeLeft = time;
                    UpdateTime();
                }
            }

            _rigidbody.velocity = new Vector3(x * _moveSpeed, _rigidbody.velocity.y, z * _moveSpeed);
        }    
        private void UpdateTime()
        {
            x = Random.Range(-1, 2);
            z = Random.Range(-1, 2);
            //_target.position = new Vector3 (transform.position.x + Random.Range(-1, 1), transform.position.y,transform.position.z + Random.Range(-1, 1));
            //Debug.Log("update"); Debug.Log(x); Debug.Log(z);
        }
}