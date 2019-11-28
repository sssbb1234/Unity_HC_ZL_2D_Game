using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度"), Range(50, 2000)]
    public int jump = 100;
    [Header("是否死亡")]
    public bool dead;

    public GameObject goScore;
    public GameObject goGM;
    //遊戲物件 分數
    //遊戲物件 管理器



    /// <summary>
    /// 小雞跳躍功能
    /// </summary>
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("按下左鍵");
            goScore.SetActive(true);
            goGM.SetActive(true);
            //顯示物件
        }
    }

    /// <summary>
    /// 小雞死亡功能
    /// </summary>
    private void Dead()
    {

    }

    /// <summary>
    /// 小雞通過水管
    /// </summary>
    private void PassPipe()
    {

    }
    //監聽玩家:滑鼠,鍵盤,搖桿
    private void Update()
    {
        Jump();
    }

}
