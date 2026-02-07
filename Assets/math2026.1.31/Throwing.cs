using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour
{
    [SerializeField] private GameObject _throwPoint;
    [SerializeField] private GameObject _landingPoint;

    private bool _throwing = false;

    private Vector3 _pos;
    private Vector3 _pos_t;
    private Vector3 _pos_l;

    private int _time = 0;
    public int endTime = 40;

    private Vector3 _speed;
    private float _upSpeed;
    private float _gravity = 0.03f;

    void Start()
    {
        _pos = _throwPoint.transform.position;
       

        this.transform.position = _pos;

       
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            _throwing = true;
            _time = 0;

            _pos_t = _throwPoint.transform.position;
            _pos_l = _landingPoint.transform.position;

            _pos = _pos_t;
            this.transform.position = _pos;

            _speed = (_pos_l - _pos_t) / endTime;//等速移動の計算・始点から終点まで引くことで移動量を出し、
                                                 //フレームで割ることで1フレーム当たりの移動量が出る。
            _upSpeed = _gravity * endTime / 2f;
        }
    }
    private void FixedUpdate()
    {
        if (_throwing)
        {
            _time += 1;

            _pos.x = _pos_t.x + _speed.x *_time;
            _pos.y = _upSpeed * _time - _gravity * _time * _time/2f;//_upSpeed * _time：どれくらいの勢いで、どれだけ上に行ったか
                                                                    //- _gravity * _time * _time / 2：重力で、どれだけ下に引っ張られたか
            _pos.z = _pos_t.z + _speed.z *_time;

            this.transform.position = _pos;

            if(_time >= endTime)
            {
                _throwing = false; 
                _time = 0;
                _pos = _pos_t;
                this.transform.position = _pos;
            }
        }
    }
}
