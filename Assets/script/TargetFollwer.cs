using Unity.Hierarchy;
using UnityEngine;

public class TargetFollwer : MonoBehaviour
{
    // 타겟을 등록하면 따라가도록 하기

    public Transform Target;
    public Vector3 Offset;
    public float SmothWeight = 0.5f;
    protected Vector3 m_LocalOffset;
    void Start()
    {
        m_LocalOffset = Target.position - this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //
        //float xx = Mathf.Lerp(transform.position.x, Target.position.x - Offset.x, SmothWeight);
        //float zz = Mathf.Lerp(transform.position.z, Target.position.z - Offset.x, SmothWeight);
        //float yy = Mathf.Lerp(transform.position.y ,Target.position.y - Offset.y, SmothWeight);


        transform.position = Vector3.Lerp(transform.position
                        , Target.position - m_LocalOffset + Offset
                        , SmothWeight);

    }
}
