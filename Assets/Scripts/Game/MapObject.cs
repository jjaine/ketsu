﻿using Ketsu.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ketsu.Game
{
	public class MapObject : MonoBehaviour
	{
        public MapObjectType Type = MapObjectType.Undefined;
        public MapLayer Layer = MapLayer.Dynamic;

        [HideInInspector]
        public IntVector2 Position;

        void Awake()
        {
            UpdatePosition();
        }

        void Start()
        {
            UpdatePosition();
        }

		void Update()
		{

        }

        public void UpdatePosition()
        {
            Position = new IntVector2(
                (int)Mathf.Round(transform.position.x),
                (int)Mathf.Round(transform.position.z)
            );
        }

        public void DelayedAction(float time, Action action)
        {
            StartCoroutine(RunDelayedAction(time, action));
        }

        IEnumerator RunDelayedAction(float time, Action action)
        {
            yield return new WaitForSeconds(time);
            if (action != null) action();
        }
    }
}