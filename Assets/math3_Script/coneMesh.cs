using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coneMesh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var _mesh = new Mesh();
        float _theta;
        Vector3[] _point = new Vector3[13];//最初の一点、正１２角形の頂点を出している

        _point[0] = new Vector3(0f, Data.range, 0f);
        for(int i = 1;i<13;i++)//生12角形の円を作っている　このfor文で視野の円錐の底面を表している
        {
            _theta = (i - 1) * Mathf.PI / 6f;　//円の上部を6等分している
            _point[i] = new Vector3(Data.height * Mathf.Cos(_theta),0f,Data.height * Mathf.Sin(_theta));//正１２角形の各頂点の点を計算している
        }
        _mesh.SetVertices(_point);//Vertices= 頂点を格納している

        int[] pointSet = new int[36];//for文で三角錐を作成している
        for (int j = 0; j < 12; j++)//点を三点打つことで三角形を作成している
        {
            pointSet[j * 3] = j + 1;
            pointSet[j * 3 + 1] = 0;
            pointSet[j * 3 + 2] = (pointSet[j * 3] + 1);
        }

        pointSet[35] = 1;//最後の１つはループ分の最後と最初で計算しなくてわならないため1を代入している

        _mesh.SetTriangles(pointSet, 0);//Trianglesをセットして

        var filter = GetComponent<MeshFilter>();//MeshFilterをゲットして
        filter.sharedMesh = _mesh;//MeshFilterを取り付けている
    }
}
