﻿using Ketsu.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ketsu.Game
{
	public class MapObject : MonoBehaviour
	{
		public bool Blocking;

        [HideInInspector]
        public IntVector2 Position;

        void Awake()
        {

        }

        void Start()
        {
            Position = new IntVector2(
                (int)Mathf.Round(transform.position.x),
                (int)Mathf.Round(transform.position.z)
            );
        }

		void Update()
		{

		}
	}
}