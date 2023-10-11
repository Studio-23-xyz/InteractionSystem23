using System.Threading;
using com.studio23.ss2.InteractionSystem23.Abstract;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

namespace com.studio23.ss2.InteractionSystem23.Samples.Demo1
{
    public class BiWayDoor:TogglableBase
    {
        public float _doorAnimTime = 1.2f;
        public GameObject _doorObject;
        private Vector3 _closedEulerAngles;
        private Vector3 _openedEulerAngles;
        [SerializeField] private float _doorOpenAngle = 90;

        protected override void Initialize()
        {
            base.Initialize();
            _closedEulerAngles = transform.rotation.eulerAngles;
            _openedEulerAngles = _closedEulerAngles + Vector3.up * _doorOpenAngle;
        }

        public override void SnapToActivatedState()
        {
            _doorObject.transform.rotation = Quaternion.Euler(_openedEulerAngles);

        }

        public override void SnapToDeactivatedState()
        {
            _doorObject.transform.rotation = Quaternion.Euler(_openedEulerAngles);
        }

        protected override void HandleInteractionInitialize()
        {
            
        }

        protected override void HandleInteractionPause()
        {
            
        }

        protected override void HandleInteractionResumed()
        {
            
        }

        protected override void HandleInteractionCompleted()
        {
            
        }
        
        protected override async UniTask DoActivateInteraction(CancellationToken token)
        {
            //basic door opening
            await AnimateDoor(_openedEulerAngles)
                .WithCancellation(token);
        }
        
        protected override async UniTask DoDeactivateInteraction(CancellationToken token)
        {
            //basic door opening
            await AnimateDoor(_closedEulerAngles)
                .WithCancellation(token);
        }

        Tween AnimateDoor(Vector3 endAngles)
        {
            return _doorObject.transform.DORotate(endAngles, _doorAnimTime)
                .SetEase(Ease.Linear);
        }
    }
}