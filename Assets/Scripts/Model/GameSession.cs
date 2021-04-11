﻿
using UnityEngine;


namespace Platformer.Model
{
	public class GameSession : MonoBehaviour
	{
		[SerializeField] private PlayerData _data;

		public PlayerData Data => _data;

		private void Awake()
		{
			if (IsSessionExist())
			{
				DestroyImmediate(gameObject);
			}
			else
			{
				DontDestroyOnLoad(this);
			}
		}

		private bool IsSessionExist()
		{
			var sessions = FindObjectsOfType<GameSession>();
			foreach (var gameSession in sessions)
			{
				if (gameSession != this)
					return true;
				
			}
			return false;
		}
	}
}

