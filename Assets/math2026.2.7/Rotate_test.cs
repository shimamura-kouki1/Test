using UnityEngine;

public class Rotate_test : MonoBehaviour
{
    //回転の中心
    [SerializeField] private Vector3 _center = Vector3.zero;
    //回転軸
    [SerializeField] private Vector3 _axis = Vector3.up;
    //周期
    [SerializeField]private float _period = 1;
    //360度を_period で割って計算して、_period辺りの度数を求めているので秒単位になっている。

    void Update()
    {
        transform.RotateAround(_center, _axis, 360 / _period * Time.deltaTime);
    }
    //360 / _period これは度数を出していて、一秒あたりの角度を出している
    //* Time.deltaTimeこれをすることで、一フレーム辺りの角度を出している。
}
