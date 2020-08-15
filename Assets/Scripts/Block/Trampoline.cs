using System;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using JackUtil;

namespace Jam {

    public class Trampoline : BlockBase {

        public Sprite waiting;
        public Sprite activated;
        public float bouncePower;

        protected override void PlayerEnter(ActorBase _actor) {

            _actor.transform.position = new Vector3(_actor.transform.position.x, transform.position.y + 0.4f, _actor.transform.position.z);

            _actor.rig.velocity = new Vector2(_actor.rig.velocity.x, bouncePower);
            _actor.EnterState(StateType.ForceJump);

            Sequence _action = DOTween.Sequence();
            sr.sprite = activated;
            _action.AppendInterval(0.2f);
            _action.AppendCallback(() => {
                sr.sprite = waiting;
            });

        }
    }
}