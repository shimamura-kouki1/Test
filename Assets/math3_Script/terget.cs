using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terget : MonoBehaviour
{

    [SerializeField] Transform player;
    Vector3 tpos;

    float tr = Data.range;
    float dot;
    // Start is called before the first frame update
    void Start()
    {
        tpos = this.transform.position;　//
    }

    // Update is called once per frame
    void Update()
    {
        var pf = player.forward;

        if((player.position.x - tpos.x)*(player.position.x - tpos.x)+(player.position.z - tpos.z)*(player.position.z -tpos.z)<tr*tr )//プレイヤーとターゲットの距離と事前に決めた範囲
        {
            dot = Vector3.Dot(pf, (tpos - player.position).normalized);//内積
            
            if (Data.cosA < dot)//Data.cosA角度＜
            {
                this.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                this.GetComponent<Renderer>().material.color = Color.white;
            }
        }
        else
        {
            this.GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
