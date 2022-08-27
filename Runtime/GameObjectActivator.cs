using UnityEngine;

namespace Kogane.Internal
{
    /// <summary>
    /// シーン開始時に指定されたゲームオブジェクトをアクティブにするコンポーネント
    /// </summary>
    [DefaultExecutionOrder( -1000 )]
    [DisallowMultipleComponent]
    internal sealed class GameObjectActivator : MonoBehaviour
    {
        //================================================================================
        // 変数(SerializeField)
        //================================================================================
        [SerializeField] private GameObject[] m_list;

        //================================================================================
        // 関数
        //================================================================================
        /// <summary>
        /// 初期化される時に呼び出されます
        /// </summary>
        private void Awake()
        {
            if ( m_list == null || m_list.Length <= 0 ) return;

            for ( var i = 0; i < m_list.Length; i++ )
            {
                var item = m_list[ i ];
                if ( item == null ) continue;
                item.SetActive( true );
            }
        }
    }
}