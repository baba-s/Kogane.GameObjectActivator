# Uni Game Object Activater

複数のゲームオブジェクトのアクティブを一括で変更するクラス

## 使用例

```cs
using UniGameObjectActivater;
using UnityEngine;

public class Example : MonoBehaviour
{
    public GameObjectActivater m_activater;

    private void OnGUI()
    {
        if ( GUILayout.Button( "Activate" ) )
        {
            m_activater.Activate();
        }
        if ( GUILayout.Button( "Deactivate" ) )
        {
            m_activater.Deactivate();
        }
    }
}
```