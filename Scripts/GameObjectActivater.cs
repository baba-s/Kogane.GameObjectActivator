using System;
using UnityEngine;

namespace UniGameObjectActivater
{
	/// <summary>
	/// ゲームオブジェクトのアクティブを変更するクラス
	/// </summary>
	[Serializable]
	public sealed class GameObjectActivater
	{
		//================================================================================
		// 変数(SerializeField)
		//================================================================================
		[SerializeField] private GameObject[] m_list = default;
		
		//================================================================================
		// 関数
		//================================================================================
		/// <summary>
		/// ゲームオブジェクトをアクティブにします
		/// </summary>
		public void Activate()
		{
			SetActiveAll( true );
		}
		
		/// <summary>
		/// ゲームオブジェクトを非アクティブにします
		/// </summary>
		public void Deactivate()
		{
			SetActiveAll( false );
		}
		
		/// <summary>
		/// ゲームオブジェクトのアクティブを変更する時に使用する関数
		/// </summary>
		private void SetActiveAll( bool isActive )
		{
			if ( m_list == null || m_list.Length <= 0 ) return;

			for ( int i = 0; i < m_list.Length; i++ )
			{
				var item = m_list[ i ];
				if ( item == null ) continue;
				item.SetActive( isActive );
			}
		}
	}
}