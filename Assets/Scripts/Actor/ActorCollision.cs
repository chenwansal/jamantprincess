using System;
using System.Collections.Generic;
using UnityEngine;

namespace Jam {

    public class ActorCollision : MonoBehaviour {

        [HideInInspector]
        public Collider2D col;
        public LayerMask groundLayer;

        [HideInInspector]
        public bool isOnGround;
        [HideInInspector]
        public bool isOnCeiling;
        [HideInInspector]
        public bool isOnWall;
        [HideInInspector]
        public bool isOnLeftWall;
        [HideInInspector]
        public bool isOnRightWall;
        [HideInInspector]
        public bool isClimbOverPlatform;

        public Vector2 topOffset, bottomOffset, leftOffset, rightOffset, climbUpOffset;
        public float collisionRadius;
        public Vector2 collisionSquareSize;

        public void Awake() {

            col = GetComponent<Collider2D>();

        }

        void FixedUpdate() {

            isOnGround = Physics2D.OverlapCircle((Vector2)transform.position + bottomOffset, collisionRadius, groundLayer);
            isOnCeiling = Physics2D.OverlapCircle((Vector2)transform.position + topOffset, collisionRadius, groundLayer);
            isOnLeftWall = Physics2D.OverlapCircle((Vector2)transform.position + leftOffset, collisionRadius, groundLayer);
            isOnRightWall = Physics2D.OverlapCircle((Vector2)transform.position + rightOffset, collisionRadius, groundLayer);
            isClimbOverPlatform = Physics2D.OverlapBox((Vector2)transform.position + climbUpOffset, collisionSquareSize, 0, groundLayer) == null;
            isOnWall = isOnLeftWall || isOnRightWall;

        }

        public bool IsMoveToWall(float _xAxis) {
            if (_xAxis < 0 && isOnLeftWall) return true;
            if (_xAxis > 0 && isOnRightWall) return true;
            return false;
        }

        void OnDrawGizmos() {

            Gizmos.color = Color.red;

            Gizmos.DrawWireSphere((Vector2)transform.position + topOffset, collisionRadius);
            Gizmos.DrawWireSphere((Vector2)transform.position + bottomOffset, collisionRadius);
            Gizmos.DrawWireSphere((Vector2)transform.position + leftOffset, collisionRadius);
            Gizmos.DrawWireSphere((Vector2)transform.position + rightOffset, collisionRadius);
            Gizmos.DrawWireCube((Vector2)transform.position + climbUpOffset, collisionSquareSize);

        }

    }
}